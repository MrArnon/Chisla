namespace Lab_Gaus
{
	partial class Gaus
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
			this.Text_Rows = new System.Windows.Forms.TextBox();
			this.Text_Cols = new System.Windows.Forms.TextBox();
			this.Label_Rows = new System.Windows.Forms.Label();
			this.Label_Cols = new System.Windows.Forms.Label();
			this.Text_output = new System.Windows.Forms.TextBox();
			this.But_Solve = new System.Windows.Forms.Button();
			this.Text_input = new System.Windows.Forms.TextBox();
			this.But_random = new System.Windows.Forms.Button();
			this.But_clear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Text_Rows
			// 
			this.Text_Rows.Location = new System.Drawing.Point(66, 195);
			this.Text_Rows.Name = "Text_Rows";
			this.Text_Rows.Size = new System.Drawing.Size(37, 20);
			this.Text_Rows.TabIndex = 0;
			// 
			// Text_Cols
			// 
			this.Text_Cols.Location = new System.Drawing.Point(302, 195);
			this.Text_Cols.Name = "Text_Cols";
			this.Text_Cols.Size = new System.Drawing.Size(37, 20);
			this.Text_Cols.TabIndex = 1;
			// 
			// Label_Rows
			// 
			this.Label_Rows.AutoSize = true;
			this.Label_Rows.Location = new System.Drawing.Point(22, 179);
			this.Label_Rows.Name = "Label_Rows";
			this.Label_Rows.Size = new System.Drawing.Size(142, 13);
			this.Label_Rows.TabIndex = 2;
			this.Label_Rows.Text = "Введите количество строк";
			// 
			// Label_Cols
			// 
			this.Label_Cols.AutoSize = true;
			this.Label_Cols.Location = new System.Drawing.Point(239, 179);
			this.Label_Cols.Name = "Label_Cols";
			this.Label_Cols.Size = new System.Drawing.Size(160, 13);
			this.Label_Cols.TabIndex = 3;
			this.Label_Cols.Text = "Введите количество столбцов";
			// 
			// Text_output
			// 
			this.Text_output.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Text_output.Location = new System.Drawing.Point(242, 12);
			this.Text_output.Multiline = true;
			this.Text_output.Name = "Text_output";
			this.Text_output.ReadOnly = true;
			this.Text_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Text_output.Size = new System.Drawing.Size(165, 132);
			this.Text_output.TabIndex = 4;
			// 
			// But_Solve
			// 
			this.But_Solve.Location = new System.Drawing.Point(161, 270);
			this.But_Solve.Name = "But_Solve";
			this.But_Solve.Size = new System.Drawing.Size(107, 50);
			this.But_Solve.TabIndex = 5;
			this.But_Solve.Text = "Решить систему";
			this.But_Solve.UseVisualStyleBackColor = true;
			this.But_Solve.Click += new System.EventHandler(this.But_Solve_Click);
			// 
			// Text_input
			// 
			this.Text_input.Location = new System.Drawing.Point(12, 12);
			this.Text_input.Multiline = true;
			this.Text_input.Name = "Text_input";
			this.Text_input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Text_input.Size = new System.Drawing.Size(165, 132);
			this.Text_input.TabIndex = 6;
			// 
			// But_random
			// 
			this.But_random.Location = new System.Drawing.Point(25, 270);
			this.But_random.Name = "But_random";
			this.But_random.Size = new System.Drawing.Size(107, 50);
			this.But_random.TabIndex = 7;
			this.But_random.Text = "Сгенерировать случайную систему";
			this.But_random.UseVisualStyleBackColor = true;
			this.But_random.Click += new System.EventHandler(this.But_random_Click);
			// 
			// But_clear
			// 
			this.But_clear.Location = new System.Drawing.Point(292, 270);
			this.But_clear.Name = "But_clear";
			this.But_clear.Size = new System.Drawing.Size(107, 50);
			this.But_clear.TabIndex = 8;
			this.But_clear.Text = "Очистить поля";
			this.But_clear.UseVisualStyleBackColor = true;
			this.But_clear.Click += new System.EventHandler(this.But_clear_Click);
			// 
			// Gaus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 333);
			this.Controls.Add(this.But_clear);
			this.Controls.Add(this.But_random);
			this.Controls.Add(this.Text_input);
			this.Controls.Add(this.But_Solve);
			this.Controls.Add(this.Text_output);
			this.Controls.Add(this.Label_Cols);
			this.Controls.Add(this.Label_Rows);
			this.Controls.Add(this.Text_Cols);
			this.Controls.Add(this.Text_Rows);
			this.MaximumSize = new System.Drawing.Size(432, 372);
			this.MinimumSize = new System.Drawing.Size(432, 372);
			this.Name = "Gaus";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gaus";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Text_Rows;
		private System.Windows.Forms.TextBox Text_Cols;
		private System.Windows.Forms.Label Label_Rows;
		private System.Windows.Forms.Label Label_Cols;
		private System.Windows.Forms.TextBox Text_output;
		private System.Windows.Forms.Button But_Solve;
		private System.Windows.Forms.TextBox Text_input;
		private System.Windows.Forms.Button But_random;
		private System.Windows.Forms.Button But_clear;
	}
}

