using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinh
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;

			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo");
				return;
			}

			bool success = DatabaseHelper.RegisterUser(username, password);

			if (success)
			{
				MessageBox.Show("Đăng ký tài khoản thành công! Vui lòng đăng nhập.", "Thành công");
			}
			else
			{
				MessageBox.Show("Tên đăng nhập này đã tồn tại. Vui lòng chọn tên khác.", "Lỗi");
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;

			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo");
				return;
			}

			User user = DatabaseHelper.ValidateUser(username, password);

			if (user != null) // Nếu user không phải null, tức là đăng nhập thành công
			{
				// LƯU USER VÀO SESSION
				Session.CurrentUser = user;

				// Mở Form Main và ẩn Form Login
				frmMain mainForm = new frmMain();
				mainForm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi");
			}
		}
	}
}
