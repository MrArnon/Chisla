﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CM_laba1
{
    public partial class Form_for_graphic : Form
    {
        public Form_for_graphic()
        {
            InitializeComponent();
        }

        private void Start_but_Click(object sender, EventArgs e)
        {
            Graphic.Series[0].Points.Clear();
            Graphic.Series[1].Points.Clear();
            Function_graphics graf = new Function_graphics();
            try
            {
                graf.n = Convert.ToInt32(Stepen_box.Text);
                graf.a = Convert.ToDouble(A_box.Text);
                graf.b = Convert.ToDouble(B_box.Text);
                if (graf.a >= graf.b)
                {
                    MessageBox.Show("Неверный ввод");
                    A_box.Text = string.Empty;
                    B_box.Text = string.Empty;
                    Stepen_box.Text = string.Empty;
                    graf.flag = false;
                }
            }
            catch (Exception) { MessageBox.Show("Неверный ввод");
                A_box.Text = string.Empty;
                B_box.Text = string.Empty;
                Stepen_box.Text = string.Empty;
                graf.flag = false; }
            if (graf.flag)
            {
                graf.H();

                //масштабируем по Х
                //Graphic.ChartAreas[0].AxisX.Minimum = -2;
                //Graphic.ChartAreas[0].AxisX.Maximum = 3;
                // Graphic.ChartAreas[0].AxisX.ScaleView.Zoom(-2, 3);
                Graphic.ChartAreas[0].CursorX.IsUserEnabled = true;
                Graphic.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;// выбор интервалов для масштабирования
                Graphic.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                Graphic.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
				Graphic.ChartAreas[0].CursorY.IsUserEnabled = true;
                Graphic.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;// выбор интервалов для масштабирования
                Graphic.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                Graphic.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;


                Graphic.Series[0].Points.Clear();
                Graphic.Series[1].Points.Clear();
                for (double i = graf.a; i <= graf.b; i += graf.h)
                {
                    for (double j = i; (j <= i + graf.h) && j < graf.b; j += (double)(graf.h / graf.m))
                    {

                        Graphic.Series[0].Points.AddXY(j, graf.func(j));
                        Graphic.Series[1].Points.AddXY(j, graf.Polin(j));

                    }
                }
                //
                //Vivod_text.Text=Convert.ToString( graf.func(-1));
                //
            }
        }

		private void Mnogo_but_Click(object sender, EventArgs e)
		{

			Graphic.Series[0].Points.Clear();
			Graphic.Series[2].Points.Clear();
			Function_graphics graf = new Function_graphics();
			try
			{
				graf.n = Convert.ToInt32(Stepen_box.Text);
				graf.a = Convert.ToDouble(A_box.Text);
				graf.b = Convert.ToDouble(B_box.Text);
				if (graf.a >= graf.b)
				{
					MessageBox.Show("Неверный ввод");
					A_box.Text = string.Empty;
					B_box.Text = string.Empty;
					Stepen_box.Text = string.Empty;
					graf.flag = false;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Неверный ввод");
				A_box.Text = string.Empty;
				B_box.Text = string.Empty;
				Stepen_box.Text = string.Empty;
				graf.flag = false;
			}
			if (graf.flag)
			{
				graf.H();

				//масштабируем по Х
				//Graphic.ChartAreas[0].AxisX.Minimum = -2;
				//Graphic.ChartAreas[0].AxisX.Maximum = 3;
				// Graphic.ChartAreas[0].AxisX.ScaleView.Zoom(-2, 3);
				Graphic.ChartAreas[0].CursorX.IsUserEnabled = true;
				Graphic.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;// выбор интервалов для масштабирования
				Graphic.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
				Graphic.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
				Graphic.ChartAreas[0].CursorY.IsUserEnabled = true;
				Graphic.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;// выбор интервалов для масштабирования
				Graphic.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
				Graphic.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;


				Graphic.Series[0].Points.Clear();
				Graphic.Series[2].Points.Clear();
				for (double i = graf.a; i <= graf.b; i += graf.h)
				{
					for (double j = i; (j <= i + graf.h) && j < graf.b; j += (double)(graf.h / graf.m))
					{

						Graphic.Series[0].Points.AddXY(j, graf.func(j));
						

					}


				}
			
				for (double g = graf.a; g < graf.b; g += 0.001)
				{
					Graphic.Series[2].Points.AddXY(g, graf.polynomial(g));
				}
				//
				//Vivod_text.Text=Convert.ToString( graf.func(-1));
				//
			}
		}

		private void Table_but_Click(object sender, EventArgs e)
		{
			Graphic.Series[0].Points.Clear();
			Graphic.Series[3].Points.Clear();
			Function_graphics graf = new Function_graphics();
			try
			{
				graf.n = Convert.ToInt32(Stepen_box.Text);
				graf.a = Convert.ToDouble(A_box.Text);
				graf.b = Convert.ToDouble(B_box.Text);
				if (graf.a >= graf.b)
				{
					MessageBox.Show("Неверный ввод");
					A_box.Text = string.Empty;
					B_box.Text = string.Empty;
					Stepen_box.Text = string.Empty;
					graf.flag = false;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Неверный ввод");
				A_box.Text = string.Empty;
				B_box.Text = string.Empty;
				Stepen_box.Text = string.Empty;
				graf.flag = false;
			}
			if (graf.flag)
			{
				graf.H();

				//масштабируем по Х
				//Graphic.ChartAreas[0].AxisX.Minimum = -2;
				//Graphic.ChartAreas[0].AxisX.Maximum = 3;
				// Graphic.ChartAreas[0].AxisX.ScaleView.Zoom(-2, 3);
				Graphic.ChartAreas[0].CursorX.IsUserEnabled = true;
				Graphic.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;// выбор интервалов для масштабирования
				Graphic.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
				Graphic.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
				Graphic.ChartAreas[0].CursorY.IsUserEnabled = true;
				Graphic.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;// выбор интервалов для масштабирования
				Graphic.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
				Graphic.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;


				Graphic.Series[0].Points.Clear();
				Graphic.Series[3].Points.Clear();
				for (double i = graf.a; i <= graf.b; i += graf.h)
				{
					for (double j = i; (j <= i + graf.h) && j < graf.b; j += (double)(graf.h / graf.m))
					{

						Graphic.Series[0].Points.AddXY(j, graf.func(j));


					}
				}

				graf.tabel = new double[graf.n + 2, graf.n + 2];
				for (double g = graf.a; g < graf.b; g += 0.001)
				{
					Graphic.Series[3].Points.AddXY(g, graf.graf_table(g));
				}
				//insert your code
			}
			}
	}
}

