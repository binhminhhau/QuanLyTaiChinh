namespace QuanLyTaiChinh
{
	partial class ucReport
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblMonthYear = new System.Windows.Forms.Label();
			this.btnNextMonth = new Guna.UI2.WinForms.Guna2Button();
			this.btnPreviousMonth = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblTotalIncome = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblTotalExpense = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblNetBalance = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dgvCategoryDetails = new Guna.UI2.WinForms.Guna2DataGridView();
			this.panel1.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.guna2Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategoryDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblMonthYear);
			this.panel1.Controls.Add(this.btnNextMonth);
			this.panel1.Controls.Add(this.btnPreviousMonth);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(908, 50);
			this.panel1.TabIndex = 0;
			// 
			// lblMonthYear
			// 
			this.lblMonthYear.AutoSize = true;
			this.lblMonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMonthYear.Location = new System.Drawing.Point(392, 4);
			this.lblMonthYear.Name = "lblMonthYear";
			this.lblMonthYear.Size = new System.Drawing.Size(134, 37);
			this.lblMonthYear.TabIndex = 2;
			this.lblMonthYear.Text = "09/2025";
			// 
			// btnNextMonth
			// 
			this.btnNextMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnNextMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnNextMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnNextMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnNextMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnNextMonth.ForeColor = System.Drawing.Color.White;
			this.btnNextMonth.Location = new System.Drawing.Point(662, 3);
			this.btnNextMonth.Name = "btnNextMonth";
			this.btnNextMonth.Size = new System.Drawing.Size(180, 45);
			this.btnNextMonth.TabIndex = 1;
			this.btnNextMonth.Text = ">";
			this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
			// 
			// btnPreviousMonth
			// 
			this.btnPreviousMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnPreviousMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnPreviousMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnPreviousMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnPreviousMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnPreviousMonth.ForeColor = System.Drawing.Color.White;
			this.btnPreviousMonth.Location = new System.Drawing.Point(60, 2);
			this.btnPreviousMonth.Name = "btnPreviousMonth";
			this.btnPreviousMonth.Size = new System.Drawing.Size(180, 45);
			this.btnPreviousMonth.TabIndex = 0;
			this.btnPreviousMonth.Text = "<";
			this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.lblTotalIncome);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Location = new System.Drawing.Point(60, 95);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(384, 100);
			this.guna2Panel1.TabIndex = 1;
			// 
			// lblTotalIncome
			// 
			this.lblTotalIncome.AutoSize = true;
			this.lblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalIncome.ForeColor = System.Drawing.Color.White;
			this.lblTotalIncome.Location = new System.Drawing.Point(51, 36);
			this.lblTotalIncome.Name = "lblTotalIncome";
			this.lblTotalIncome.Size = new System.Drawing.Size(144, 52);
			this.lblTotalIncome.TabIndex = 1;
			this.lblTotalIncome.Text = "label2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(3, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "TỔNG THU";
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.Controls.Add(this.lblTotalExpense);
			this.guna2Panel2.Controls.Add(this.label4);
			this.guna2Panel2.Location = new System.Drawing.Point(495, 95);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(347, 100);
			this.guna2Panel2.TabIndex = 2;
			// 
			// lblTotalExpense
			// 
			this.lblTotalExpense.AutoSize = true;
			this.lblTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalExpense.ForeColor = System.Drawing.Color.White;
			this.lblTotalExpense.Location = new System.Drawing.Point(111, 36);
			this.lblTotalExpense.Name = "lblTotalExpense";
			this.lblTotalExpense.Size = new System.Drawing.Size(144, 52);
			this.lblTotalExpense.TabIndex = 1;
			this.lblTotalExpense.Text = "label3";
			this.lblTotalExpense.Click += new System.EventHandler(this.lblTotalExpense_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(3, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 20);
			this.label4.TabIndex = 0;
			this.label4.Text = "TỔNG CHI";
			// 
			// guna2Panel3
			// 
			this.guna2Panel3.Controls.Add(this.lblNetBalance);
			this.guna2Panel3.Controls.Add(this.label6);
			this.guna2Panel3.Location = new System.Drawing.Point(60, 220);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new System.Drawing.Size(782, 100);
			this.guna2Panel3.TabIndex = 3;
			// 
			// lblNetBalance
			// 
			this.lblNetBalance.AutoSize = true;
			this.lblNetBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNetBalance.ForeColor = System.Drawing.Color.White;
			this.lblNetBalance.Location = new System.Drawing.Point(309, 23);
			this.lblNetBalance.Name = "lblNetBalance";
			this.lblNetBalance.Size = new System.Drawing.Size(144, 52);
			this.lblNetBalance.TabIndex = 1;
			this.lblNetBalance.Text = "label5";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(34, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(60, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "SỐ DƯ";
			// 
			// chartReport
			// 
			this.chartReport.BackColor = System.Drawing.Color.Transparent;
			chartArea1.BackColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "ChartArea1";
			this.chartReport.ChartAreas.Add(chartArea1);
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.chartReport.Legends.Add(legend1);
			this.chartReport.Location = new System.Drawing.Point(60, 337);
			this.chartReport.Name = "chartReport";
			this.chartReport.Size = new System.Drawing.Size(300, 266);
			this.chartReport.TabIndex = 4;
			this.chartReport.Text = "chart1";
			// 
			// dgvCategoryDetails
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			this.dgvCategoryDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCategoryDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCategoryDetails.ColumnHeadersHeight = 4;
			this.dgvCategoryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvCategoryDetails.ColumnHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCategoryDetails.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvCategoryDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dgvCategoryDetails.Location = new System.Drawing.Point(425, 337);
			this.dgvCategoryDetails.Name = "dgvCategoryDetails";
			this.dgvCategoryDetails.ReadOnly = true;
			this.dgvCategoryDetails.RowHeadersVisible = false;
			this.dgvCategoryDetails.RowHeadersWidth = 62;
			this.dgvCategoryDetails.RowTemplate.Height = 28;
			this.dgvCategoryDetails.Size = new System.Drawing.Size(417, 266);
			this.dgvCategoryDetails.TabIndex = 6;
			this.dgvCategoryDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
			this.dgvCategoryDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
			this.dgvCategoryDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvCategoryDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvCategoryDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvCategoryDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvCategoryDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvCategoryDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
			this.dgvCategoryDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
			this.dgvCategoryDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvCategoryDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvCategoryDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvCategoryDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvCategoryDetails.ThemeStyle.HeaderStyle.Height = 4;
			this.dgvCategoryDetails.ThemeStyle.ReadOnly = true;
			this.dgvCategoryDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
			this.dgvCategoryDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvCategoryDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvCategoryDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
			this.dgvCategoryDetails.ThemeStyle.RowsStyle.Height = 28;
			this.dgvCategoryDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
			this.dgvCategoryDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			// 
			// ucReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvCategoryDetails);
			this.Controls.Add(this.chartReport);
			this.Controls.Add(this.guna2Panel3);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "ucReport";
			this.Size = new System.Drawing.Size(908, 624);
			this.Load += new System.EventHandler(this.ucReport_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			this.guna2Panel3.ResumeLayout(false);
			this.guna2Panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategoryDetails)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2Button btnPreviousMonth;
		private System.Windows.Forms.Label lblMonthYear;
		private Guna.UI2.WinForms.Guna2Button btnNextMonth;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Label lblTotalIncome;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private System.Windows.Forms.Label lblTotalExpense;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
		private System.Windows.Forms.Label lblNetBalance;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
		private Guna.UI2.WinForms.Guna2DataGridView dgvCategoryDetails;
	}
}
