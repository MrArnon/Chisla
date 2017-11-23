using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Gaus
{
	class Gaus_Method
	{
		public double[,] Matrix {get;set;}
		public int Rows { get; set; }
		public int Cols { get; set; }
		public string Result { get; set; }
		public Gaus_Method()
		{

		}
		public Gaus_Method(int Row, int Colum)
		{
			/*Matrix = new double[Row][];
			for (int i = 0; i < Row; i++)
				Matrix[i] = new double[Colum];
	*/
			Matrix = new double[Row, Colum];
			Rows = Row;
			Cols = Colum;
	
			
		}
		public void Randomize()
		{
		
			Random rnd = new Random();
			for (int i=0;i<Rows;i++)
				for (int j=0;j<Cols;j++)
					Matrix[i,j] = rnd.Next(0, 10);
				
		}
		public void Reader(String[] s)
		{
			
			
			for (int i = 0; i < Rows; i++)
			{
			
				string[] str_rows = s[i].Split(' ');
				for (int j = 0; j < Cols; j++)
				{
					
					Matrix[i,j] = (double)Convert.ToInt32 (str_rows[j]);
				
				}
			
			}
		}
		public void Gaus_Solve()
		{
			int m = Rows - 1;



			for (int i = 0; i < m; i++)
			{

				for (int j = i; j < m; j++)
				{
					Triangular(i, j);
				}

			}
			
			//ToTriangle(Matrix);
			Rank();
			Solve();
		}
		private void Solve()
		{
			double[] x = new double[Rows];

			try
			{
				x[Rows - 1] = Matrix[Rows - 1, Cols - 1] / Matrix[Rows - 1, Cols - 2];
			}
			catch (System.NullReferenceException) { }//обработано
			for (int k = Rows - 2; k >= 0; k--)
			{
				double f = Matrix[k, k];
				double r = Matrix[k, Cols - 1];
				for (int j = k + 1; j < Cols - 1; j++)
				{
					r -= Matrix[k, j] * x[j];
				}
				x[k] = r / f;
			}
			bool b = true;
			int i = 0;
			while (b && i < Rows)
			{
				b = !Double.IsNaN(x[i]) && !Double.IsNegativeInfinity(x[i]) && !Double.IsPositiveInfinity(x[i]);
				i++;
			}

			if (Result != "Система неразрешима" + "\r\n")
			{
				if (b)
				{
					for (int j = 0; j < Cols - 1; j++)
					{
						Result += "  " + x[j] + "\r\n";
					}
				}
				else Result = "Решений бесконечно много" + "\r\n";
			}
		}
		private void Rank()
		{
			
			int rankAb = 0;
			for (int i = 0; i < Rows; i++)
			{
				bool b = true;
				int j = 0;
				while (b && j < Cols)
				{
					b = Matrix[i, j] != 0;
					j++;
				}
				if (b) rankAb++;
			}
			rankAb = Rows - rankAb;
			int rankA = 0;
			for (int i = 0; i < Rows; i++)
			{
				bool b = true;
				int j = 0;
				while (b && j < (Cols-1))
				{
					b = Matrix[i, j] != 0;
					j++;
				}
				if (b) rankA++;
			}
			rankA = Rows - rankA;
			if (rankA == rankAb)
			{
				if (rankAb == (Cols - 1)) Result = "Решение единственно"+"\r\n";
				else
					if (rankAb < (Cols - 1)) Result = "Решений бесконечно много" + "\r\n";
			}
			else Result = "Система неразрешима" + "\r\n";

				
		}
		public void Triangular(int x,int y)
		{

			double[] Line1 = new double[Cols];
			double[] Line2 = new double[Cols];


			
			for (int i = 0; i < Cols; i++)
			{
				Line1[i] = Matrix[x,i];
				Line2[i] = Matrix[y + 1, i];
			}


			
			double Koef1 = Line1[x];
			double Koef2 = Line2[y];
			for (int i = 0; i < Cols; i++)
			{
				Line1[i] *= Koef2;
				Line2[i] *= Koef1;
			}


			
			if ((Line1[x] > 0 && Line2[x] > 0) || (Line1[x] < 0 && Line2[x] < 0))
			{
				for (int i = 0; i < Cols; i++)
				{
					Line2[i] = Line1[i] - Line2[i];
				}
			}
			else
			{
				for (int i = 0; i < Cols; i++)
				{
					Line2[i] = Line1[i] + Line2[i];
				}
			}


			for (int i = 0; i < Cols; i++)
			{
				Matrix[y + 1, i] = Line2[i];
			}
		}
	/*	private void ToTriangle(double[,] matrix)
		{
			int n = matrix.GetLength(0);
			if (n != matrix.GetLength(1))
				throw new ArgumentException("Square matrix expected", "matrix");
				
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					double koef = matrix[j, i] / matrix[i, i];
					for (int k = i; k < n; k++)
						matrix[j, k] -= matrix[i, k] * koef;
				}
			}
		}*/

		public string Output ()
		{
			string str=string.Empty;
			for (int i = 0; i < Rows; i++)
			{
				for (int j = 0; j < Cols; j++)
					str += Matrix[i,j] + " ";
				str += "\r\n";
			}
			return str;
		}
	}
}
