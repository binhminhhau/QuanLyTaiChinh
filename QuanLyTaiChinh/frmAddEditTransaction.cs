using Guna.UI2.WinForms;
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
	public partial class frmAddEditTransaction : Form
	{
		private string selectedCategory = "";
		private Transaction _transactionToEdit;
		public frmAddEditTransaction()
		{
			InitializeComponent();
		}

		public frmAddEditTransaction(Transaction transaction)
		{
			InitializeComponent();
			_transactionToEdit = transaction;
		}
		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void frmAddEditTransaction_Load(object sender, EventArgs e)
		{
			// Nếu là sửa, điền thông tin cũ vào form
			if (_transactionToEdit != null)
			{
				this.Text = "Sửa Giao dịch"; // Đổi tiêu đề form
				txtDescription.Text = _transactionToEdit.Description;
				nudAmount.Value = (decimal)_transactionToEdit.Amount;
				dtpDate.Value = _transactionToEdit.Date;
				cmbType.SelectedItem = _transactionToEdit.Type;
			}
			else
			{
				this.Text = "Thêm Giao dịch mới";
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (_transactionToEdit == null) // Trường hợp THÊM MỚI
			{
				Transaction newTrans = new Transaction
				{
					Description = txtDescription.Text,
					Amount = (double)nudAmount.Value,
					Date = dtpDate.Value,
					Type = cmbType.SelectedItem.ToString(),
					Category = this.selectedCategory,
					UserId = Session.CurrentUser.Id
				};
				DatabaseHelper.AddTransaction(newTrans);
			}
			else // Trường hợp SỬA
			{
				_transactionToEdit.Description = txtDescription.Text;
				_transactionToEdit.Amount = (double)nudAmount.Value;
				_transactionToEdit.Date = dtpDate.Value;
				_transactionToEdit.Type = cmbType.SelectedItem.ToString();
				DatabaseHelper.UpdateTransaction(_transactionToEdit);
			}
			this.Close();
		}

		// Sự kiện nút Hủy không đổi
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			// Lấy thông tin từ nút được bấm
			Guna2Button clickedButton = (Guna2Button)sender;

			// Lưu lại tên danh mục
			selectedCategory = clickedButton.Text;

			// (Tùy chọn) Thêm hiệu ứng để người dùng biết đã chọn nút nào
			// Ví dụ: Bỏ viền tất cả các nút rồi thêm viền cho nút được chọn
			foreach (Control control in flpCategories.Controls)
			{
				if (control is Guna2Button)
				{
					((Guna2Button)control).BorderThickness = 0;
				}
			}
			clickedButton.BorderThickness = 3;
			clickedButton.BorderColor = Color.Aqua;
		}
	}
	
}
