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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Label_stepen = new System.Windows.Forms.Label();
            this.Stepen_box = new System.Windows.Forms.TextBox();
            this.Start_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graphic)).BeginInit();
            this.SuspendLayout();
            // 
            // Graphic
            // 
            chartArea1.Name = "ChartArea1";
            this.Graphic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graphic.Legends.Add(legend1);
            this.Graphic.Location = new System.Drawing.Point(-1, 2);
            this.Graphic.Name = "Graphic";
            this.Graphic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "Sqrt(3 + x^2) / Sqrt(5 + 7 * x^2)";
            series1.Name = "Func_graf";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "Полином";
            series2.Name = "Polinom_graf";
            this.Graphic.Series.Add(series1);
            this.Graphic.Series.Add(series2);
            this.Graphic.Size = new System.Drawing.Size(850, 300);
            this.Graphic.TabIndex = 0;
            this.Graphic.Text = "График";
            title1.Name = "Graphic_func";
            this.Graphic.Titles.Add(title1);
            // 
            // Label_stepen
            // 
            this.Label_stepen.AutoSize = true;
            this.Label_stepen.Location = new System.Drawing.Point(12, 380);
            this.Label_stepen.Name = "Label_stepen";
            this.Label_stepen.Size = new System.Drawing.Size(146, 13);
            this.Label_stepen.TabIndex = 1;
            this.Label_stepen.Text = "Ввидите степень полинома";
            // 
            // Stepen_box
            // 
            this.Stepen_box.Location = new System.Drawing.Point(164, 377);
            this.Stepen_box.Name = "Stepen_box";
            this.Stepen_box.Size = new System.Drawing.Size(33, 20);
            this.Stepen_box.TabIndex = 2;
            // 
            // Start_but
            // 
            this.Start_but.Location = new System.Drawing.Point(277, 370);
            this.Start_but.Name = "Start_but";
            this.Start_but.Size = new System.Drawing.Size(92, 33);
            this.Start_but.TabIndex = 3;
            this.Start_but.Text = "Построить";
            this.Start_but.UseVisualStyleBackColor = true;
            this.Start_but.Click += new System.EventHandler(this.Start_but_Click);
            // 
            // Form_for_graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 461);
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
    }
}

