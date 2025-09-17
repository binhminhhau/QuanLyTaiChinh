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
	public partial class ucSavings : UserControl
	{
		public ucSavings()
		{
			InitializeComponent();
		}
		private void LoadGoals()
		{
			if (Session.CurrentUser == null) return; // Kiểm tra an toàn

			// Lấy danh sách mục tiêu của người dùng hiện tại
			List<SavingsGoal> goals = DatabaseHelper.GetSavingsGoals(Session.CurrentUser.Id);

			// "Reset" và gán nguồn dữ liệu cho DataGridView
			dgvSavingsGoals.DataSource = null;
			dgvSavingsGoals.DataSource = goals;
		}
		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ucSavings_Load(object sender, EventArgs e)
		{
			LoadGoals();
		}

		private void btnAddGoal_Click(object sender, EventArgs e)
		{
			frmAddEditGoal form = new frmAddEditGoal();
			form.ShowDialog();
			// Tải lại danh sách sau khi thêm
			LoadGoals();
		}

		private void dgvSavingsGoals_SelectionChanged(object sender, EventArgs e)
		{
			// Bước 1: Kiểm tra an toàn
			if (dgvSavingsGoals.SelectedRows.Count == 0 || dgvSavingsGoals.SelectedRows[0].DataBoundItem == null)
			{
				// Xóa thông tin chi tiết nếu không có gì được chọn
				lblGoalName.Text = "Vui lòng chọn một mục tiêu";
				lblProgressText.Text = "";
				lblAmountRemaining.Text = "";
				lblDailySuggestion.Text = "";
				progressGoal.Value = 0;
				return;
			}

			// Bước 2: Lấy mục tiêu được chọn
			SavingsGoal selectedGoal = (SavingsGoal)dgvSavingsGoals.SelectedRows[0].DataBoundItem;

			// Bước 3: Cập nhật giao diện
			lblGoalName.Text = selectedGoal.GoalName;

			// Cập nhật thanh tiến độ (đã sửa lỗi)
			// Cập nhật thanh tiến độ
			if (selectedGoal.TargetAmount > 0)
			{
				// GÁN LẠI MAXIMUM CHO PROGRESSBAR
				progressGoal.Maximum = (int)selectedGoal.TargetAmount;

				// Gán Value là số tiền hiện tại
				// Dùng Math.Min để đảm bảo Value không vượt quá Maximum
				progressGoal.Value = (int)Math.Min(selectedGoal.CurrentAmount, selectedGoal.TargetAmount);
			}
			else
			{
				progressGoal.Maximum = 100; // Đặt về mặc định
				progressGoal.Value = 0;
			}

			lblProgressText.Text = $"{selectedGoal.CurrentAmount:N0} / {selectedGoal.TargetAmount:N0} VNĐ";

			double amountRemaining = selectedGoal.TargetAmount - selectedGoal.CurrentAmount;
			lblAmountRemaining.Text = $"Còn lại: {amountRemaining:N0} VNĐ";

			// Tính toán và đưa ra gợi ý
			double daysRemaining = (selectedGoal.TargetDate.Date - DateTime.Now.Date).TotalDays;

			if (daysRemaining >= 1 && amountRemaining > 0)
			{
				double dailySuggestion = amountRemaining / daysRemaining;
				lblDailySuggestion.Text = $"Gợi ý: {dailySuggestion:N0} VNĐ / ngày";
			}
			else if (amountRemaining <= 0)
			{
				lblDailySuggestion.Text = "Chúc mừng, bạn đã hoàn thành mục tiêu!";
			}
			else
			{
				lblDailySuggestion.Text = "Mục tiêu đã quá hạn!";
			}
		}
	}
}
