using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiChinh
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			DatabaseHelper.InitializeDatabase();
			
			DatabaseHelper.RegisterUser("default", "123");
			User defaultUser = DatabaseHelper.ValidateUser("default", "123");
			Session.CurrentUser = defaultUser;

			Application.Run(new frmMain());
		}
	}
}
