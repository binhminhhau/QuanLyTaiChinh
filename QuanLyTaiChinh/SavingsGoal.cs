using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinh
{
	public class SavingsGoal
	{
		public int Id { get; set; }
		public string GoalName { get; set; } // Tên mục tiêu
		public double TargetAmount { get; set; } // Số tiền mục tiêu
		public double CurrentAmount { get; set; } // Số tiền đã có
		public DateTime TargetDate { get; set; } // Ngày hoàn thành
		public int UserId { get; set; }
	}
}
