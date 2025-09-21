namespace QuanLyTaiChinh
{
	partial class frmLogin
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(125, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đăng nhập:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(166, 250);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mật khẩu:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtUsername
			// 
			this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUsername.DefaultText = "";
			this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUsername.Location = new System.Drawing.Point(269, 117);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PlaceholderText = "";
			this.txtUsername.SelectedText = "";
			this.txtUsername.Size = new System.Drawing.Size(288, 40);
			this.txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.DefaultText = "";
			this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.Location = new System.Drawing.Point(269, 230);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.PlaceholderText = "";
			this.txtPassword.SelectedText = "";
			this.txtPassword.Size = new System.Drawing.Size(288, 40);
			this.txtPassword.TabIndex = 3;
			// 
			// btnLogin
			// 
			this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(198, 341);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(153, 45);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnRegister
			// 
			this.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnRegister.ForeColor = System.Drawing.Color.White;
			this.btnRegister.Location = new System.Drawing.Point(447, 341);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(153, 45);
			this.btnRegister.TabIndex = 5;
			this.btnRegister.Text = "Đăng ký";
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập / Đăng ký";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txtUsername;
		private Guna.UI2.WinForms.Guna2TextBox txtPassword;
		private Guna.UI2.WinForms.Guna2Button btnLogin;
		private Guna.UI2.WinForms.Guna2Button btnRegister;
	}
}