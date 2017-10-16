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
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Label_stepen = new System.Windows.Forms.Label();
            this.Stepen_box = new System.Windows.Forms.TextBox();
            this.Start_but = new System.Windows.Forms.Button();
            this.A_box = new System.Windows.Forms.TextBox();
            this.B_box = new System.Windows.Forms.TextBox();
            this.Label_interval = new System.Windows.Forms.Label();
            this.Vivod_text = new System.Windows.Forms.TextBox();
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
            this.Graphic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.LegendText = "Sqrt(3 + x^2) / Sqrt(5 + 7 * x^2)";
            series5.Name = "Func_graf";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.LegendText = "Полином";
            series6.Name = "Polinom_graf";
            this.Graphic.Series.Add(series5);
            this.Graphic.Series.Add(series6);
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
            // Start_but
            // 
            this.Start_but.Location = new System.Drawing.Point(280, 394);
            this.Start_but.Name = "Start_but";
            this.Start_but.Size = new System.Drawing.Size(92, 33);
            this.Start_but.TabIndex = 3;
            this.Start_but.Text = "Построить";
            this.Start_but.UseVisualStyleBackColor = true;
            this.Start_but.Click += new System.EventHandler(this.Start_but_Click);
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
            // Form_for_graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 461);
            this.Controls.Add(this.Vivod_text);
            this.Controls.Add(this.Label_interval);
            this.Controls.Add(this.B_box);
            this.Controls.Add(this.A_box);
            this.Controls.Add(this.Start_but);
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
        private System.Windows.Forms.Button Start_but;
        private System.Windows.Forms.TextBox A_box;
        private System.Windows.Forms.TextBox B_box;
        private System.Windows.Forms.Label Label_interval;
        private System.Windows.Forms.TextBox Vivod_text;
    }
}

