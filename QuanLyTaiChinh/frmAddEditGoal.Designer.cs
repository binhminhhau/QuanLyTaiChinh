namespace QuanLyTaiChinh
{
	partial class frmAddEditGoal
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtGoalName = new Guna.UI2.WinForms.Guna2TextBox();
			this.nudTargetAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.nudCurrentAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.dtpTargetDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudTargetAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCurrentAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// txtGoalName
			// 
			this.txtGoalName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtGoalName.DefaultText = "";
			this.txtGoalName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtGoalName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtGoalName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtGoalName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtGoalName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtGoalName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtGoalName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtGoalName.Location = new System.Drawing.Point(237, 47);
			this.txtGoalName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtGoalName.Name = "txtGoalName";
			this.txtGoalName.PlaceholderText = "";
			this.txtGoalName.SelectedText = "";
			this.txtGoalName.Size = new System.Drawing.Size(286, 60);
			this.txtGoalName.TabIndex = 0;
			// 
			// nudTargetAmount
			// 
			this.nudTargetAmount.BackColor = System.Drawing.Color.Transparent;
			this.nudTargetAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudTargetAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudTargetAmount.Location = new System.Drawing.Point(237, 216);
			this.nudTargetAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudTargetAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.nudTargetAmount.Name = "nudTargetAmount";
			this.nudTargetAmount.Size = new System.Drawing.Size(286, 60);
			this.nudTargetAmount.TabIndex = 1;
			// 
			// nudCurrentAmount
			// 
			this.nudCurrentAmount.BackColor = System.Drawing.Color.Transparent;
			this.nudCurrentAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudCurrentAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.nudCurrentAmount.Location = new System.Drawing.Point(237, 117);
			this.nudCurrentAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudCurrentAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.nudCurrentAmount.Name = "nudCurrentAmount";
			this.nudCurrentAmount.Size = new System.Drawing.Size(286, 89);
			this.nudCurrentAmount.TabIndex = 2;
			// 
			// dtpTargetDate
			// 
			this.dtpTargetDate.Checked = true;
			this.dtpTargetDate.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.dtpTargetDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.dtpTargetDate.Location = new System.Drawing.Point(278, 296);
			this.dtpTargetDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dtpTargetDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dtpTargetDate.Name = "dtpTargetDate";
			this.dtpTargetDate.Size = new System.Drawing.Size(214, 36);
			this.dtpTargetDate.TabIndex = 3;
			this.dtpTargetDate.Value = new System.DateTime(2025, 9, 17, 21, 50, 57, 331);
			// 
			// btnSave
			// 
			this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(70, 391);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(180, 45);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Lưu";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(396, 391);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(228, 44);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Hủy";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tên mục tiêu:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 155);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Số tiền hiện có";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(54, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Số tiền mục tiêu";
			// 
			// frmAddEditGoal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dtpTargetDate);
			this.Controls.Add(this.nudCurrentAmount);
			this.Controls.Add(this.nudTargetAmount);
			this.Controls.Add(this.txtGoalName);
			this.Name = "frmAddEditGoal";
			this.Text = "frmAddEditGoal";
			this.Load += new System.EventHandler(this.frmAddEditGoal_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudTargetAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCurrentAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TextBox txtGoalName;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudTargetAmount;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudCurrentAmount;
		private Guna.UI2.WinForms.Guna2DateTimePicker dtpTargetDate;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private Guna.UI2.WinForms.Guna2Button btnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}