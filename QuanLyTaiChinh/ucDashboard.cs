using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Collections.Specialized.BitVector32;

namespace QuanLyTaiChinh
{
	public partial class ucDashboard : UserControl
	{
		public ucDashboard()
		{
			InitializeComponent();
		}

		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ucDashboard_Load(object sender, EventArgs e)
		{

			// Lấy tất cả giao dịch của người dùng
			var allTransactions = DatabaseHelper.GetTransactions(Session.CurrentUser.Id);

			// Lọc ra các giao dịch trong tháng và năm hiện tại
			var monthlyTransactions = allTransactions
				.Where(t => t.Date.Month == DateTime.Now.Month && t.Date.Year == DateTime.Now.Year)
				.ToList();

			// Tính toán tổng thu và chi
			double totalIncome = monthlyTransactions.Where(t => t.Type == "Thu").Sum(t => t.Amount);
			double totalExpense = monthlyTransactions.Where(t => t.Type == "Chi").Sum(t => t.Amount);
			double balance = totalIncome - totalExpense;

			// Cập nhật các thẻ thông tin (Card)
			// "N0" để định dạng số có dấu phẩy
			lblTotalIncome.Text = totalIncome.ToString("N0") + " VNĐ";
			lblTotalExpense.Text = totalExpense.ToString("N0") + " VNĐ";
			lblBalance.Text = balance.ToString("N0") + " VNĐ";

			// Tải biểu đồ
			LoadChart(totalIncome, totalExpense);

			// Lấy và hiển thị nhận xét
			FinancialAdvisor advisor = new FinancialAdvisor();
			txtAdvice.Text = advisor.GetAdvice(totalIncome, totalExpense);
		}

		private void LoadChart(double income, double expense)
		{
			// Xóa dữ liệu cũ
			chartOverview.Series.Clear();

			// Tạo một series mới cho biểu đồ tròn
			Series series = new Series("Data")
			{
				ChartType = SeriesChartType.Pie
			};

			// Thêm dữ liệu vào series
			if (income > 0 || expense > 0)
			{
				series.Points.AddXY("Thu nhập", income);
				series.Points.AddXY("Chi tiêu", expense);
			}
			else
			{
				// Trường hợp không có dữ liệu
				series.Points.AddXY("Chưa có dữ liệu", 100);
				series.Points[0].Color = Color.LightGray;
			}

			// Tùy chỉnh
			series.Points[0].Color = Color.FromArgb(46, 213, 115); // Màu xanh lá
			if (series.Points.Count > 1)
			{
				series.Points[1].Color = Color.FromArgb(231, 76, 60); // Màu đỏ
			}
			series.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
			series["PieLabelStyle"] = "Outside";
			series.LabelForeColor = Color.White;

			// Thêm series vào Chart
			chartOverview.Series.Add(series);
			chartOverview.Legends[0].ForeColor = Color.White;
			chartOverview.BackColor = Color.Transparent;
			chartOverview.ChartAreas[0].BackColor = Color.Transparent;
		}

		private void guna2Panel1_VisibleChanged(object sender, EventArgs e)
		{

		}

		private void ucDashboard_VisibleChanged(object sender, EventArgs e)
		{

		}

		private void txtAdvice_TextChanged(object sender, EventArgs e)
		{

		}

		private void chartOverview_Click(object sender, EventArgs e)
		{

		}
	}
}
