namespace QuanLyTaiChinh
{
	partial class ucDashboard
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
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartOverview = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblBalance = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblTotalExpense = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblTotalIncome = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAdvice = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			((System.ComponentModel.ISupportInitialize)(this.chartOverview)).BeginInit();
			this.guna2Panel3.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chartOverview
			// 
			chartArea1.Name = "ChartArea1";
			this.chartOverview.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartOverview.Legends.Add(legend1);
			this.chartOverview.Location = new System.Drawing.Point(0, 429);
			this.chartOverview.Name = "chartOverview";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartOverview.Series.Add(series1);
			this.chartOverview.Size = new System.Drawing.Size(552, 221);
			this.chartOverview.TabIndex = 0;
			this.chartOverview.Text = "chart1";
			this.chartOverview.Click += new System.EventHandler(this.chartOverview_Click);
			// 
			// guna2Panel3
			// 
			this.guna2Panel3.Controls.Add(this.lblBalance);
			this.guna2Panel3.Controls.Add(this.label7);
			this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel3.Location = new System.Drawing.Point(0, 291);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new System.Drawing.Size(822, 141);
			this.guna2Panel3.TabIndex = 5;
			// 
			// lblBalance
			// 
			this.lblBalance.AutoSize = true;
			this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBalance.ForeColor = System.Drawing.Color.Transparent;
			this.lblBalance.Location = new System.Drawing.Point(380, 84);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new System.Drawing.Size(108, 37);
			this.lblBalance.TabIndex = 1;
			this.lblBalance.Text = "label8";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(398, 36);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 25);
			this.label7.TabIndex = 0;
			this.label7.Text = "SỐ DƯ";
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.Controls.Add(this.lblTotalExpense);
			this.guna2Panel2.Controls.Add(this.label5);
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel2.Location = new System.Drawing.Point(0, 154);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(822, 137);
			this.guna2Panel2.TabIndex = 4;
			// 
			// lblTotalExpense
			// 
			this.lblTotalExpense.AutoSize = true;
			this.lblTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalExpense.ForeColor = System.Drawing.Color.Transparent;
			this.lblTotalExpense.Location = new System.Drawing.Point(380, 76);
			this.lblTotalExpense.Name = "lblTotalExpense";
			this.lblTotalExpense.Size = new System.Drawing.Size(108, 37);
			this.lblTotalExpense.TabIndex = 1;
			this.lblTotalExpense.Text = "label6";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(331, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(230, 25);
			this.label5.TabIndex = 0;
			this.label5.Text = "TỔNG CHI THÁNG NÀY";
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.lblTotalIncome);
			this.guna2Panel1.Controls.Add(this.label3);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(822, 154);
			this.guna2Panel1.TabIndex = 3;
			this.guna2Panel1.VisibleChanged += new System.EventHandler(this.guna2Panel1_VisibleChanged);
			this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
			// 
			// lblTotalIncome
			// 
			this.lblTotalIncome.AutoSize = true;
			this.lblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalIncome.ForeColor = System.Drawing.Color.Transparent;
			this.lblTotalIncome.Location = new System.Drawing.Point(380, 80);
			this.lblTotalIncome.Name = "lblTotalIncome";
			this.lblTotalIncome.Size = new System.Drawing.Size(108, 37);
			this.lblTotalIncome.TabIndex = 1;
			this.lblTotalIncome.Text = "label4";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(324, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(237, 25);
			this.label3.TabIndex = 0;
			this.label3.Text = "TỔNG THU THÁNG NÀY";
			// 
			// txtAdvice
			// 
			this.txtAdvice.BackColor = System.Drawing.Color.Transparent;
			this.txtAdvice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtAdvice.DefaultText = "";
			this.txtAdvice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtAdvice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtAdvice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtAdvice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtAdvice.Dock = System.Windows.Forms.DockStyle.Right;
			this.txtAdvice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtAdvice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdvice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtAdvice.Location = new System.Drawing.Point(555, 432);
			this.txtAdvice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtAdvice.Multiline = true;
			this.txtAdvice.Name = "txtAdvice";
			this.txtAdvice.PlaceholderText = "";
			this.txtAdvice.ReadOnly = true;
			this.txtAdvice.SelectedText = "";
			this.txtAdvice.Size = new System.Drawing.Size(267, 221);
			this.txtAdvice.TabIndex = 6;
			this.txtAdvice.TextChanged += new System.EventHandler(this.txtAdvice_TextChanged);
			// 
			// guna2ContextMenuStrip1
			// 
			this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
			this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
			this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
			this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// ucDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtAdvice);
			this.Controls.Add(this.guna2Panel3);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.chartOverview);
			this.Name = "ucDashboard";
			this.Size = new System.Drawing.Size(822, 653);
			this.Load += new System.EventHandler(this.ucDashboard_Load);
			this.VisibleChanged += new System.EventHandler(this.ucDashboard_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.chartOverview)).EndInit();
			this.guna2Panel3.ResumeLayout(false);
			this.guna2Panel3.PerformLayout();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartOverview;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private System.Windows.Forms.Label lblTotalExpense;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Label lblTotalIncome;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txtAdvice;
		private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
	}
}
