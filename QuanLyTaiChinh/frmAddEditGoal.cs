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
	public partial class frmAddEditGoal : Form
	{
		public frmAddEditGoal()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SavingsGoal newGoal = new SavingsGoal
			{
				GoalName = txtGoalName.Text,
				TargetAmount = (double)nudTargetAmount.Value,
				CurrentAmount = (double)nudCurrentAmount.Value,
				TargetDate = dtpTargetDate.Value,
				UserId = Session.CurrentUser.Id
			};

			DatabaseHelper.AddSavingsGoal(newGoal);
			this.Close();
		}

		private void frmAddEditGoal_Load(object sender, EventArgs e)
		{

		}
	}
}
