using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiChinh
{
	internal class FinancialAdvisor
	{
		public string GetAdvice(double income, double expense)
		{
			if (income == 0 && expense > 0)
			{
				return "Nhận xét: Bạn chưa có thu nhập nhưng đã bắt đầu chi tiêu. Hãy cẩn thận!\r\n" +
					   "Phương án: Cố gắng tạo ra nguồn thu nhập sớm nhất có thể.";
			}

			if (income == 0 && expense == 0)
			{
				return "Nhận xét: Chào mừng bạn! Hãy bắt đầu ghi chép các khoản thu chi để có những phân tích đầu tiên.";
			}

			double ratio = expense / income;

			if (ratio < 0.5)
			{
				return "Nhận xét: Tình hình tài chính của bạn rất tốt! Tỷ lệ chi tiêu thấp hơn 50% thu nhập.\r\n" +
					   "Phương án: Bạn có thể dùng phần tiền dư dả để tiết kiệm hoặc đầu tư dài hạn (chứng chỉ quỹ, vàng...).";
			}
			else if (ratio <= 0.8)
			{
				return "Nhận xét: Tình hình tài chính ổn định. Bạn đang kiểm soát chi tiêu tốt.\r\n" +
					   "Phương án: Hãy tiếp tục duy trì thói quen này và tìm cách tăng các khoản tiết kiệm nhỏ.";
			}
			else if (ratio <= 1.0)
			{
				return "Nhận xét: Cảnh báo! Chi tiêu đang chiếm gần hết thu nhập của bạn.\r\n" +
					   "Phương án: Hãy xem lại các khoản chi không cần thiết (ăn ngoài, giải trí...) để cắt giảm.";
			}
			else // ratio > 1.0
			{
				return "Nhận xét: Báo động đỏ! Bạn đang chi tiêu nhiều hơn số tiền kiếm được.\r\n" +
					   "Phương án: Cần cắt giảm chi tiêu khẩn cấp và tìm cách tăng thêm thu nhập ngay lập tức.";
			}
		}
	}
}
