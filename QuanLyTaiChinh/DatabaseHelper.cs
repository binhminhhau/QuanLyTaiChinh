using QuanLyTaiChinh;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

public class DatabaseHelper
{
	private static readonly string dbFile = "QuanLyTaiChinh.sqlite";
	private static readonly string connectionString = $"Data Source={dbFile};Version=3;";

	// === KHỞI TẠO DATABASE ===
	public static void InitializeDatabase()
	{
		if (!File.Exists(dbFile))
		{
			SQLiteConnection.CreateFile(dbFile);
		}

		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();
			// Tạo bảng Users nếu chưa có
			string createUsersTableSql = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Username TEXT NOT NULL UNIQUE, Password TEXT NOT NULL)";
			using (var command = new SQLiteCommand(createUsersTableSql, connection))
			{
				command.ExecuteNonQuery();
			}

			// Tạo bảng Transactions nếu chưa có
			string createTransactionsTableSql = "CREATE TABLE IF NOT EXISTS Transactions (Id INTEGER PRIMARY KEY AUTOINCREMENT, Description TEXT, Amount REAL NOT NULL, Date TEXT NOT NULL, Type TEXT NOT NULL, Category TEXT, UserId INTEGER NOT NULL, FOREIGN KEY(UserId) REFERENCES Users(Id))";
			using (var command = new SQLiteCommand(createTransactionsTableSql, connection))
			{
				command.ExecuteNonQuery();
			}

			string createSavingsTableSql = "CREATE TABLE IF NOT EXISTS SavingsGoals (Id INTEGER PRIMARY KEY AUTOINCREMENT, GoalName TEXT, TargetAmount REAL NOT NULL, CurrentAmount REAL NOT NULL, TargetDate TEXT, UserId INTEGER NOT NULL)";
			using (var command = new SQLiteCommand(createSavingsTableSql, connection))
			{
				command.ExecuteNonQuery();
			}

		}
		
	}

	// === CÁC PHƯƠNG THỨC XỬ LÝ USER ===
	public static bool RegisterUser(string username, string password)
	{
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();
			string checkSql = "SELECT COUNT(*) FROM Users WHERE Username = @user";
			using (var command = new SQLiteCommand(checkSql, connection))
			{
				command.Parameters.AddWithValue("@user", username);
				if (Convert.ToInt32(command.ExecuteScalar()) > 0)
				{
					return false; // User đã tồn tại
				}
			}

			string insertSql = "INSERT INTO Users (Username, Password) VALUES (@user, @pass)";
			using (var command = new SQLiteCommand(insertSql, connection))
			{
				command.Parameters.AddWithValue("@user", username);
				command.Parameters.AddWithValue("@pass", password);
				command.ExecuteNonQuery();
				return true;
			}
		}
	}

	public static User ValidateUser(string username, string password)
	{
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();
			string sql = "SELECT Id, Username FROM Users WHERE Username = @user AND Password = @pass";
			using (var command = new SQLiteCommand(sql, connection))
			{
				command.Parameters.AddWithValue("@user", username);
				command.Parameters.AddWithValue("@pass", password);
				using (var reader = command.ExecuteReader())
				{
					if (reader.Read())
					{
						return new User
						{
							Id = Convert.ToInt32(reader["Id"]),
							Username = Convert.ToString(reader["Username"])
						};
					}
				}
			}
		}
		return null; // Trả về null nếu không hợp lệ
	}

	// === CÁC PHƯƠNG THỨC XỬ LÝ TRANSACTION (CRUD) ===
	public static void AddTransaction(Transaction trans)
	{
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();
			string sql = "INSERT INTO Transactions (Description, Amount, Date, Type, Category, UserId) VALUES (@desc, @amount, @date, @type, @category, @userId)";
			using (var command = new SQLiteCommand(sql, connection))
			{
				command.Parameters.AddWithValue("@desc", trans.Description);
				command.Parameters.AddWithValue("@amount", trans.Amount);
				command.Parameters.AddWithValue("@date", trans.Date.ToString("yyyy-MM-dd HH:mm:ss"));
				command.Parameters.AddWithValue("@type", trans.Type);
				command.Parameters.AddWithValue("@category", trans.Category);
				command.Parameters.AddWithValue("@userId", trans.UserId);
				command.ExecuteNonQuery();
			}
		}
	}
	public static void UpdateTransaction(Transaction trans)
	{
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();
			string sql = "UPDATE Transactions SET Description = @desc, Amount = @amount, Date = @date, Type = @type, Category = @category WHERE Id = @id AND UserId = @userId";
			using (var command = new SQLiteCommand(sql, connection))
			{
				command.Parameters.AddWithValue("@desc", trans.Description);
				command.Parameters.AddWithValue("@amount", trans.Amount);
				command.Parameters.AddWithValue("@date", trans.Date.ToString("yyyy-MM-dd HH:mm:ss"));
				command.Parameters.AddWithValue("@type", trans.Type);
				command.Parameters.AddWithValue("@category", trans.Category);
				command.Parameters.AddWithValue("@id", trans.Id);
				command.Parameters.AddWithValue("@userId", trans.UserId);
				command.ExecuteNonQuery();
			}
		}
	}
	

	public static void DeleteTransaction(int transactionId, int userId)
	{
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();
			string sql = "DELETE FROM Transactions WHERE Id = @id AND UserId = @userId";
			using (var command = new SQLiteCommand(sql, connection))
			{
				command.Parameters.AddWithValue("@id", transactionId);
				command.Parameters.AddWithValue("@userId", userId);
				command.ExecuteNonQuery();
			}
		}
	}

	public static List<Transaction> GetTransactions(int userId)
	{
		var transactions = new List<Transaction>();
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();
			string sql = "SELECT * FROM Transactions WHERE UserId = @userId ORDER BY Date DESC";
			using (var command = new SQLiteCommand(sql, connection))
			{
				command.Parameters.AddWithValue("@userId", userId);
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						transactions.Add(new Transaction
						{
							Id = Convert.ToInt32(reader["Id"]),
							Description = Convert.ToString(reader["Description"]),
							Amount = Convert.ToDouble(reader["Amount"]),
							Date = Convert.ToDateTime(reader["Date"]),
							Type = Convert.ToString(reader["Type"]),
							Category = Convert.ToString(reader["Category"]),
							UserId = Convert.ToInt32(reader["UserId"])
						});
					}
				}
			}
		}
		return transactions;

	}
	// === CÁC PHƯƠNG THỨC XỬ LÝ SAVINGS GOAL (CRUD) ===

	// CREATE: Thêm một mục tiêu tiết kiệm mới
	public static void AddSavingsGoal(SavingsGoal goal)
	{
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();
			string sql = "INSERT INTO SavingsGoals (GoalName, TargetAmount, CurrentAmount, TargetDate, UserId) VALUES (@name, @target, @current, @date, @userId)";
			using (var command = new SQLiteCommand(sql, connection))
			{
				command.Parameters.AddWithValue("@name", goal.GoalName);
				command.Parameters.AddWithValue("@target", goal.TargetAmount);
				command.Parameters.AddWithValue("@current", goal.CurrentAmount);
				command.Parameters.AddWithValue("@date", goal.TargetDate.ToString("yyyy-MM-dd"));
				command.Parameters.AddWithValue("@userId", goal.UserId);
				command.ExecuteNonQuery();
			}
		}
	}

	// READ: Lấy tất cả mục tiêu của một người dùng
	public static List<SavingsGoal> GetSavingsGoals(int userId)
	{
		var goals = new List<SavingsGoal>();
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();
			string sql = "SELECT * FROM SavingsGoals WHERE UserId = @userId";
			using (var command = new SQLiteCommand(sql, connection))
			{
				command.Parameters.AddWithValue("@userId", userId);
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						goals.Add(new SavingsGoal
						{
							Id = Convert.ToInt32(reader["Id"]),
							GoalName = Convert.ToString(reader["GoalName"]),
							TargetAmount = Convert.ToDouble(reader["TargetAmount"]),
							CurrentAmount = Convert.ToDouble(reader["CurrentAmount"]),
							TargetDate = Convert.ToDateTime(reader["TargetDate"]),
							UserId = Convert.ToInt32(reader["UserId"])
						});
					}
				}
			}
		}
		return goals;
	}

	// UPDATE: Cập nhật một mục tiêu (ví dụ: cập nhật số tiền đã có)
	public static void UpdateSavingsGoal(SavingsGoal goal)
	{
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();
			string sql = "UPDATE SavingsGoals SET GoalName = @name, TargetAmount = @target, CurrentAmount = @current, TargetDate = @date WHERE Id = @id AND UserId = @userId";
			using (var command = new SQLiteCommand(sql, connection))
			{
				command.Parameters.AddWithValue("@name", goal.GoalName);
				command.Parameters.AddWithValue("@target", goal.TargetAmount);
				command.Parameters.AddWithValue("@current", goal.CurrentAmount);
				command.Parameters.AddWithValue("@date", goal.TargetDate.ToString("yyyy-MM-dd"));
				command.Parameters.AddWithValue("@id", goal.Id);
				command.Parameters.AddWithValue("@userId", goal.UserId);
				command.ExecuteNonQuery();
			}
		}
	}

	// DELETE: Xóa một mục tiêu
	public static void DeleteSavingsGoal(int goalId, int userId)
	{
		using (var connection = new SQLiteConnection(connectionString))
		{
			connection.Open();
			string sql = "DELETE FROM SavingsGoals WHERE Id = @id AND UserId = @userId";
			using (var command = new SQLiteCommand(sql, connection))
			{
				command.Parameters.AddWithValue("@id", goalId);
				command.Parameters.AddWithValue("@userId", userId);
				command.ExecuteNonQuery();
			}
		}
	}

	// Bạn có thể thêm các hàm Update và Delete tương tự nếu cần
}