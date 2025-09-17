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
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			// Xóa control cũ đang có trong panel chính
			pnlMainContent.Controls.Clear();

			// Tạo một "trang" Giao dịch mới
			ucTransactions transactionControl = new ucTransactions();
			transactionControl.Dock = DockStyle.Fill;

			// Thêm "trang" Giao dịch vào panel chính
			pnlMainContent.Controls.Add(transactionControl);
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			btnDashboard_Click(null, null);
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			pnlMainContent.Controls.Clear();
			ucDashboard dashboardControl = new ucDashboard();
			dashboardControl.Dock = DockStyle.Fill;
			pnlMainContent.Controls.Add(dashboardControl);	
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			// Xóa control cũ đang có trong panel chính
			pnlMainContent.Controls.Clear();

			// Tạo một "trang" Báo cáo mới
			ucReport reportControl = new ucReport();
			reportControl.Dock = DockStyle.Fill;
			reportControl.UpdateReport(); 
			pnlMainContent.Controls.Add(reportControl);
		}

		private void btnTietKiem_Click(object sender, EventArgs e)
		{
			pnlMainContent.Controls.Clear();
			ucSavings savingsControl = new ucSavings();
			savingsControl.Dock = DockStyle.Fill;
			pnlMainContent.Controls.Add(savingsControl);
		}
	}
}
