using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Gaus
{
	public partial class Gaus : Form
	{
		Gaus_Method gaus_Method = new Gaus_Method();
		public Gaus()
		{
			InitializeComponent();
		}

		private void But_random_Click(object sender, EventArgs e)
		{
			try
			{
				gaus_Method = new Gaus_Method(Convert.ToInt32(Text_Rows.Text), Convert.ToInt32(Text_Cols.Text));
				gaus_Method.Randomize();
			}
			catch (System.FormatException) { MessageBox.Show("Некорректный ввод!", "Ошибка"); Text_Rows.Text = Text_Cols.Text = string.Empty; }
			Text_input.Text=gaus_Method.Output();
		}

		private void But_Solve_Click(object sender, EventArgs e)
		{
			try
			{
				gaus_Method = new Gaus_Method(Convert.ToInt32(Text_Rows.Text), Convert.ToInt32(Text_Cols.Text));
				
				
			}
			catch (System.FormatException) { MessageBox.Show("Некорректный ввод!", "Ошибка");Text_Rows.Text = Text_Cols.Text = string.Empty; }
			try
			{
				String[] s = Text_input.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
				gaus_Method.Reader(s);
				/*int m = gaus_Method.Rows - 1;
				for (int i = 0; i < m; i++)
				{

					for (int j = i; j < m; j++)
					{
						gaus_Method.Triangular(i, j);
				}

				}*/			gaus_Method.Gaus_Solve();
				Text_output.Text = gaus_Method.Result;
				//Text_output.Text = gaus_Method.Output();
			}
			catch (System.FormatException) { MessageBox.Show("Вводите числа через один пробел!", "Ошибка"); Text_output.Text= Text_input.Text = string.Empty; }
			
		}

		private void But_clear_Click(object sender, EventArgs e)
		{
			Text_Cols.Text=Text_Rows.Text= Text_output.Text = Text_input.Text = string.Empty;
			gaus_Method = new Gaus_Method();
		}
	}
}
