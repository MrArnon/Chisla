namespace CM_laba1
{
    partial class Form_for_graphic
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.Graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.Label_stepen = new System.Windows.Forms.Label();
			this.Stepen_box = new System.Windows.Forms.TextBox();
			this.Polin_but = new System.Windows.Forms.Button();
			this.A_box = new System.Windows.Forms.TextBox();
			this.B_box = new System.Windows.Forms.TextBox();
			this.Label_interval = new System.Windows.Forms.Label();
			this.Vivod_text = new System.Windows.Forms.TextBox();
			this.Mnogo_but = new System.Windows.Forms.Button();
			this.Table_but = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Graphic)).BeginInit();
			this.SuspendLayout();
			// 
			// Graphic
			// 
			chartArea3.Name = "ChartArea1";
			this.Graphic.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.Graphic.Legends.Add(legend3);
			this.Graphic.Location = new System.Drawing.Point(-1, 2);
			this.Graphic.Name = "Graphic";
			this.Graphic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
			series9.ChartArea = "ChartArea1";
			series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series9.Legend = "Legend1";
			series9.LegendText = "Sqrt(3 + x^2) / Sqrt(5 + 7 * x^2)";
			series9.Name = "Func_graf";
			series10.ChartArea = "ChartArea1";
			series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series10.Legend = "Legend1";
			series10.LegendText = "Полином";
			series10.Name = "Polinom_graf";
			series11.ChartArea = "ChartArea1";
			series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series11.Legend = "Legend1";
			series11.LegendText = "Многочлен";
			series11.Name = "Mnogo_graf";
			series12.ChartArea = "ChartArea1";
			series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series12.Legend = "Legend1";
			series12.LegendText = "Таблица";
			series12.Name = "Table_graf";
			this.Graphic.Series.Add(series9);
			this.Graphic.Series.Add(series10);
			this.Graphic.Series.Add(series11);
			this.Graphic.Series.Add(series12);
			this.Graphic.Size = new System.Drawing.Size(850, 300);
			this.Graphic.TabIndex = 0;
			this.Graphic.Text = "График";
			title3.Name = "Graphic_func";
			this.Graphic.Titles.Add(title3);
			// 
			// Label_stepen
			// 
			this.Label_stepen.AutoSize = true;
			this.Label_stepen.Location = new System.Drawing.Point(12, 404);
			this.Label_stepen.Name = "Label_stepen";
			this.Label_stepen.Size = new System.Drawing.Size(146, 13);
			this.Label_stepen.TabIndex = 1;
			this.Label_stepen.Text = "Ввидите степень полинома";
			// 
			// Stepen_box
			// 
			this.Stepen_box.Location = new System.Drawing.Point(164, 401);
			this.Stepen_box.Name = "Stepen_box";
			this.Stepen_box.Size = new System.Drawing.Size(33, 20);
			this.Stepen_box.TabIndex = 2;
			// 
			// Polin_but
			// 
			this.Polin_but.Location = new System.Drawing.Point(280, 394);
			this.Polin_but.Name = "Polin_but";
			this.Polin_but.Size = new System.Drawing.Size(92, 33);
			this.Polin_but.TabIndex = 3;
			this.Polin_but.Text = "Полином";
			this.Polin_but.UseVisualStyleBackColor = true;
			this.Polin_but.Click += new System.EventHandler(this.Start_but_Click);
			// 
			// A_box
			// 
			this.A_box.Location = new System.Drawing.Point(15, 350);
			this.A_box.Name = "A_box";
			this.A_box.Size = new System.Drawing.Size(33, 20);
			this.A_box.TabIndex = 4;
			// 
			// B_box
			// 
			this.B_box.Location = new System.Drawing.Point(164, 350);
			this.B_box.Name = "B_box";
			this.B_box.Size = new System.Drawing.Size(33, 20);
			this.B_box.TabIndex = 5;
			// 
			// Label_interval
			// 
			this.Label_interval.AutoSize = true;
			this.Label_interval.Location = new System.Drawing.Point(12, 323);
			this.Label_interval.Name = "Label_interval";
			this.Label_interval.Size = new System.Drawing.Size(151, 13);
			this.Label_interval.TabIndex = 6;
			this.Label_interval.Text = "Ввидите границы интервала";
			// 
			// Vivod_text
			// 
			this.Vivod_text.Location = new System.Drawing.Point(551, 347);
			this.Vivod_text.Name = "Vivod_text";
			this.Vivod_text.Size = new System.Drawing.Size(170, 20);
			this.Vivod_text.TabIndex = 7;
			this.Vivod_text.Visible = false;
			// 
			// Mnogo_but
			// 
			this.Mnogo_but.Location = new System.Drawing.Point(410, 394);
			this.Mnogo_but.Name = "Mnogo_but";
			this.Mnogo_but.Size = new System.Drawing.Size(92, 33);
			this.Mnogo_but.TabIndex = 8;
			this.Mnogo_but.Text = "Многочлен";
			this.Mnogo_but.UseVisualStyleBackColor = true;
			this.Mnogo_but.Click += new System.EventHandler(this.Mnogo_but_Click);
			// 
			// Table_but
			// 
			this.Table_but.Location = new System.Drawing.Point(539, 394);
			this.Table_but.Name = "Table_but";
			this.Table_but.Size = new System.Drawing.Size(92, 33);
			this.Table_but.TabIndex = 9;
			this.Table_but.Text = "Таблица";
			this.Table_but.UseVisualStyleBackColor = true;
			this.Table_but.Click += new System.EventHandler(this.Table_but_Click);
			// 
			// Form_for_graphic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 461);
			this.Controls.Add(this.Table_but);
			this.Controls.Add(this.Mnogo_but);
			this.Controls.Add(this.Vivod_text);
			this.Controls.Add(this.Label_interval);
			this.Controls.Add(this.B_box);
			this.Controls.Add(this.A_box);
			this.Controls.Add(this.Polin_but);
			this.Controls.Add(this.Stepen_box);
			this.Controls.Add(this.Label_stepen);
			this.Controls.Add(this.Graphic);
			this.MaximumSize = new System.Drawing.Size(860, 500);
			this.MinimumSize = new System.Drawing.Size(860, 500);
			this.Name = "Form_for_graphic";
			this.Text = "График функции";
			((System.ComponentModel.ISupportInitialize)(this.Graphic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graphic;
        private System.Windows.Forms.Label Label_stepen;
        private System.Windows.Forms.TextBox Stepen_box;
        private System.Windows.Forms.Button Polin_but;
        private System.Windows.Forms.TextBox A_box;
        private System.Windows.Forms.TextBox B_box;
        private System.Windows.Forms.Label Label_interval;
        private System.Windows.Forms.TextBox Vivod_text;
		private System.Windows.Forms.Button Mnogo_but;
		private System.Windows.Forms.Button Table_but;
	}
}

