namespace QuanLyTaiChinh
{
	partial class ucSavings
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvSavingsGoals = new Guna.UI2.WinForms.Guna2DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblGoalName = new System.Windows.Forms.Label();
			this.progressGoal = new Guna.UI2.WinForms.Guna2ProgressBar();
			this.lblProgressText = new System.Windows.Forms.Label();
			this.lblAmountRemaining = new System.Windows.Forms.Label();
			this.lblDailySuggestion = new System.Windows.Forms.Label();
			this.txtSavingsAdvice = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.btnAddGoal = new Guna.UI2.WinForms.Guna2Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSavingsGoals)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.Controls.Add(this.btnAddGoal, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.dgvSavingsGoals, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 551);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// dgvSavingsGoals
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvSavingsGoals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSavingsGoals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSavingsGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSavingsGoals.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSavingsGoals.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSavingsGoals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvSavingsGoals.Location = new System.Drawing.Point(3, 3);
			this.dgvSavingsGoals.Name = "dgvSavingsGoals";
			this.dgvSavingsGoals.RowHeadersVisible = false;
			this.dgvSavingsGoals.RowHeadersWidth = 62;
			this.dgvSavingsGoals.RowTemplate.Height = 28;
			this.dgvSavingsGoals.Size = new System.Drawing.Size(272, 269);
			this.dgvSavingsGoals.TabIndex = 0;
			this.dgvSavingsGoals.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvSavingsGoals.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvSavingsGoals.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvSavingsGoals.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvSavingsGoals.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvSavingsGoals.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvSavingsGoals.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvSavingsGoals.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvSavingsGoals.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvSavingsGoals.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvSavingsGoals.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvSavingsGoals.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSavingsGoals.ThemeStyle.HeaderStyle.Height = 4;
			this.dgvSavingsGoals.ThemeStyle.ReadOnly = false;
			this.dgvSavingsGoals.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvSavingsGoals.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvSavingsGoals.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvSavingsGoals.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvSavingsGoals.ThemeStyle.RowsStyle.Height = 28;
			this.dgvSavingsGoals.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvSavingsGoals.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvSavingsGoals.SelectionChanged += new System.EventHandler(this.dgvSavingsGoals_SelectionChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtSavingsAdvice);
			this.panel1.Controls.Add(this.lblDailySuggestion);
			this.panel1.Controls.Add(this.lblAmountRemaining);
			this.panel1.Controls.Add(this.lblProgressText);
			this.panel1.Controls.Add(this.progressGoal);
			this.panel1.Controls.Add(this.lblGoalName);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.ForeColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(281, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(411, 269);
			this.panel1.TabIndex = 2;
			// 
			// lblGoalName
			// 
			this.lblGoalName.AutoSize = true;
			this.lblGoalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGoalName.ForeColor = System.Drawing.Color.White;
			this.lblGoalName.Location = new System.Drawing.Point(142, 14);
			this.lblGoalName.Name = "lblGoalName";
			this.lblGoalName.Size = new System.Drawing.Size(79, 29);
			this.lblGoalName.TabIndex = 0;
			this.lblGoalName.Text = "label1";
			// 
			// progressGoal
			// 
			this.progressGoal.Location = new System.Drawing.Point(32, 46);
			this.progressGoal.Name = "progressGoal";
			this.progressGoal.Size = new System.Drawing.Size(300, 30);
			this.progressGoal.TabIndex = 1;
			this.progressGoal.Text = "guna2ProgressBar1";
			this.progressGoal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// lblProgressText
			// 
			this.lblProgressText.AutoSize = true;
			this.lblProgressText.ForeColor = System.Drawing.Color.White;
			this.lblProgressText.Location = new System.Drawing.Point(159, 91);
			this.lblProgressText.Name = "lblProgressText";
			this.lblProgressText.Size = new System.Drawing.Size(51, 20);
			this.lblProgressText.TabIndex = 2;
			this.lblProgressText.Text = "label1";
			// 
			// lblAmountRemaining
			// 
			this.lblAmountRemaining.AutoSize = true;
			this.lblAmountRemaining.ForeColor = System.Drawing.Color.White;
			this.lblAmountRemaining.Location = new System.Drawing.Point(28, 127);
			this.lblAmountRemaining.Name = "lblAmountRemaining";
			this.lblAmountRemaining.Size = new System.Drawing.Size(51, 20);
			this.lblAmountRemaining.TabIndex = 3;
			this.lblAmountRemaining.Text = "label1";
			// 
			// lblDailySuggestion
			// 
			this.lblDailySuggestion.AutoSize = true;
			this.lblDailySuggestion.ForeColor = System.Drawing.Color.White;
			this.lblDailySuggestion.Location = new System.Drawing.Point(28, 169);
			this.lblDailySuggestion.Name = "lblDailySuggestion";
			this.lblDailySuggestion.Size = new System.Drawing.Size(51, 20);
			this.lblDailySuggestion.TabIndex = 4;
			this.lblDailySuggestion.Text = "label1";
			// 
			// txtSavingsAdvice
			// 
			this.txtSavingsAdvice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSavingsAdvice.DefaultText = "";
			this.txtSavingsAdvice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSavingsAdvice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSavingsAdvice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSavingsAdvice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSavingsAdvice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSavingsAdvice.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtSavingsAdvice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSavingsAdvice.Location = new System.Drawing.Point(63, 209);
			this.txtSavingsAdvice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSavingsAdvice.Multiline = true;
			this.txtSavingsAdvice.Name = "txtSavingsAdvice";
			this.txtSavingsAdvice.PlaceholderText = "";
			this.txtSavingsAdvice.ReadOnly = true;
			this.txtSavingsAdvice.SelectedText = "";
			this.txtSavingsAdvice.Size = new System.Drawing.Size(286, 60);
			this.txtSavingsAdvice.TabIndex = 5;
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
			// btnAddGoal
			// 
			this.btnAddGoal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAddGoal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAddGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAddGoal.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnAddGoal.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnAddGoal.ForeColor = System.Drawing.Color.White;
			this.btnAddGoal.Location = new System.Drawing.Point(3, 506);
			this.btnAddGoal.Name = "btnAddGoal";
			this.btnAddGoal.Size = new System.Drawing.Size(272, 42);
			this.btnAddGoal.TabIndex = 3;
			this.btnAddGoal.Text = "Thêm mục tiêu mới";
			this.btnAddGoal.Click += new System.EventHandler(this.btnAddGoal_Click);
			// 
			// ucSavings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ucSavings";
			this.Size = new System.Drawing.Size(695, 551);
			this.Load += new System.EventHandler(this.ucSavings_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSavingsGoals)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Guna.UI2.WinForms.Guna2DataGridView dgvSavingsGoals;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblGoalName;
		private Guna.UI2.WinForms.Guna2TextBox txtSavingsAdvice;
		private System.Windows.Forms.Label lblDailySuggestion;
		private System.Windows.Forms.Label lblAmountRemaining;
		private System.Windows.Forms.Label lblProgressText;
		private Guna.UI2.WinForms.Guna2ProgressBar progressGoal;
		private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
		private Guna.UI2.WinForms.Guna2Button btnAddGoal;
	}
}
