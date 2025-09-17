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
	public partial class ucTransactions : UserControl
	{
		public ucTransactions()
		{
			InitializeComponent();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Mở form thêm mới dưới dạng một cửa sổ dialog
			frmAddEditTransaction form = new frmAddEditTransaction();
			form.ShowDialog();

			// Sau khi form thêm mới đóng lại, tải lại danh sách giao dịch
			LoadTransactions();
		}
		private void LoadTransactions()
		{
			// Lấy danh sách giao dịch của người dùng hiện tại từ database
			List<Transaction> transactions = DatabaseHelper.GetTransactions(Session.CurrentUser.Id);

			// Gán danh sách này làm nguồn dữ liệu cho DataGridView
			// Giả sử DataGridView của bạn tên là dgvTransactions
			dgvTransactions.DataSource = transactions;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (dgvTransactions.SelectedRows.Count == 0)
			{
				MessageBox.Show("Vui lòng chọn một giao dịch để sửa.", "Thông báo");
				return;
			}

			// Lấy dữ liệu của dòng đang được chọn
			// Lưu ý: dgvTransactions.DataSource phải được ép kiểu về List<Transaction>
			var transactions = (List<Transaction>)dgvTransactions.DataSource;
			var selectedTransaction = transactions[dgvTransactions.SelectedRows[0].Index];

			// Mở form Sửa và truyền đối tượng giao dịch vào
			frmAddEditTransaction form = new frmAddEditTransaction(selectedTransaction);
			form.ShowDialog();

			// Tải lại dữ liệu sau khi sửa
			LoadTransactions();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			// Kiểm tra xem người dùng đã chọn dòng nào chưa
			if (dgvTransactions.SelectedRows.Count == 0)
			{
				MessageBox.Show("Vui lòng chọn một giao dịch để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Lấy ID của giao dịch từ dòng đã chọn
			int transactionId = Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["Id"].Value);

			// Hỏi xác nhận trước khi xóa
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				// Gọi hàm xóa trong DatabaseHelper
				DatabaseHelper.DeleteTransaction(transactionId, Session.CurrentUser.Id);
				// Tải lại danh sách
				LoadTransactions();
			}
		}

		private void ucTransactions_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		private void LoadData()
		{
			// Giả sử bạn có một user đang đăng nhập trong Session
			if (Session.CurrentUser != null)
			{
				List<Transaction> transactions = DatabaseHelper.GetTransactions(Session.CurrentUser.Id);
				dgvTransactions.DataSource = null;
				dgvTransactions.DataSource = transactions;
			}
		}
	}
}
