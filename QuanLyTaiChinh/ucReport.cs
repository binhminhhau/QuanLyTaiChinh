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

namespace QuanLyTaiChinh
{
	public partial class ucReport : UserControl
	{
		
		private DateTime currentMonth;
		public ucReport()
		{
			InitializeComponent();
		}
		// === PHƯƠNG THỨC CHÍNH ĐỂ CẬP NHẬT TOÀN BỘ DỮ LIỆU ===
		public void UpdateReport()
		{
			// 1. Cập nhật Label tháng/năm
			lblMonthYear.Text = currentMonth.ToString("MM / yyyy");

			// 2. Lấy và lọc dữ liệu giao dịch
			var allTransactions = DatabaseHelper.GetTransactions(Session.CurrentUser.Id);
			var monthlyTransactions = allTransactions
				.Where(t => t.Date.Month == currentMonth.Month && t.Date.Year == currentMonth.Year)
				.ToList();

			// 3. Tính toán và hiển thị các thẻ thống kê
			double totalIncome = monthlyTransactions.Where(t => t.Type == "Thu").Sum(t => t.Amount);
			double totalExpense = monthlyTransactions.Where(t => t.Type == "Chi").Sum(t => t.Amount);
			double netBalance = totalIncome - totalExpense;
			lblTotalIncome.Text = $"+{totalIncome:N0} đ";
			lblTotalExpense.Text = $"-{totalExpense:N0} đ";
			lblNetBalance.Text = $"{netBalance:N0} đ";

			// 4. Chuẩn bị dữ liệu cho biểu đồ và bảng chi tiết
			var expenseByCategory = monthlyTransactions
				.Where(t => t.Type == "Chi" && !string.IsNullOrEmpty(t.Category))
				.GroupBy(t => t.Category)
				.Select(g => new CategoryExpense
				{
					Category = g.Key,
					Total = g.Sum(t => t.Amount)
				})
				.ToList();

			// 5. Gọi hàm vẽ biểu đồ
			LoadChart(expenseByCategory);

			// 6. Cập nhật bảng chi tiết
			dgvCategoryDetails.DataSource = null;
			dgvCategoryDetails.DataSource = expenseByCategory;
		}

		// Hàm vẽ biểu đồ
		private void LoadChart(List<CategoryExpense> expenseData)
		{
			chartReport.Series.Clear();
			var series = new Series("Expenses")
			{
				ChartType = SeriesChartType.Doughnut
			};

			if (expenseData.Any())
			{
				foreach (var item in expenseData)
				{
					series.Points.AddXY(item.Category, item.Total);
				}
			}
			else
			{
				series.Points.AddXY("Chưa có chi tiêu", 100);
				series.Points[0].Color = Color.LightGray;
			}
			chartReport.Series.Add(series);
		}

		// === CÁC SỰ KIỆN ĐỂ GỌI HÀM UPDATE ===

		private void ucReport_Load(object sender, EventArgs e)
		{
			currentMonth = DateTime.Now;
			UpdateReport();
		}


		private void btnPreviousMonth_Click(object sender, EventArgs e)
		{
			currentMonth = currentMonth.AddMonths(-1);
			UpdateReport();
		}

		private void btnNextMonth_Click(object sender, EventArgs e)
		{
			currentMonth = currentMonth.AddMonths(1);
			UpdateReport();
		}
		private void lblTotalExpense_Click(object sender, EventArgs e)
		{

		}

		
	}
	public class CategoryExpense
	{
		public string Category { get; set; }
		public double Total { get; set; }
	}
}
