using coffeApp.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeApp
{
	public partial class Management : Form
	{
		public User user { get; set; }

		public void SetDataFromLogin(User data)
		{
			user = data;
		}
		public Management()
		{
			InitializeComponent();
			inputStatus.Items.Add("present");
			inputStatus.Items.Add("absent");
			inputStatus.Items.Add("late");
		}
		string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CafeData;User ID=sa;Password=123;";

		private void btnShowOrder_Click(object sender, EventArgs e)
		{
			List<Order> orders = new List<Order>();
			orders = GetOrdersByUserId(user.UserId);
			TableShowOrder.DataSource = orders;
			TableShowOrder.Columns.Remove("PointUse");
			TableShowOrder.Columns.Remove("Status");
		}
		private void btnCalculateRevenue_Click(object sender, EventArgs e)
		{
			List<Order> orders = new List<Order>();
			orders = GetOrdersByUserId(user.UserId);
			int totalRevenue = 0;
			foreach (Order order in orders)
			{
				totalRevenue += order.Total;
			}
			labelRevenue.Text = totalRevenue.ToString() + "VND";
		}
		private void btnShowStaff_Click(object sender, EventArgs e)
		{
			List<Staff> staff = new List<Staff>();
			staff = GetStaffByUserId(user.UserId);
			TableShowStaff.DataSource = staff;
			TableShowStaff.Columns.Remove("UserId");
		}
		private void ShowStaff_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = TableShowStaff.Rows[e.RowIndex];
				int staffId = (int)selectedRow.Cells["StaffId"].Value;
				inputStaffId.Text = staffId.ToString();
			}
		}
		private void btnAddAtendance_Click(object sender, EventArgs e)
		{
			Attendance attendance = new Attendance();
			attendance.DateTime = inputDateTime.Value.Date;
			attendance.StaffId = int.Parse(inputStaffId.Text.ToString());
			attendance.Status = inputStatus.Text.ToString();
			CreateAttendance(attendance);
		}
		private void btnCalculateProfit_Click(object sender, EventArgs e)
		{
			decimal profit = CalculateProfitForUser(user.UserId);
			labelProfit.Text = profit.ToString() + "VND";
		}

		public List<Order> GetOrdersByUserId(int userId)
		{
			List<Order> orders = new List<Order>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// Define your SQL query to select orders by UserId
				string query = "SELECT OrderId, UserId, DateTime, PointUse, Status, Total FROM [Order] WHERE UserId = @UserId";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@UserId", userId);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Order order = new Order
							{
								OrderId = (int)reader["OrderId"],
								UserId = (int)reader["UserId"],
								DateTime = (DateTime)reader["DateTime"],
								PointUse = (int)reader["PointUse"],
								Status = (bool)reader["Status"],
								Total = (int)reader["Total"]
							};

							orders.Add(order);
						}
					}
				}
			}

			return orders;
		}

		public List<Staff> GetStaffByUserId(int userId)
		{
			List<Staff> staffList = new List<Staff>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// Define your SQL query to select staff by UserId
				string query = "SELECT StaffId, Name, Shift, Salary, UserId FROM Staff WHERE UserId = @UserId";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@UserId", userId);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							Staff staff = new Staff
							{
								StaffId = (int)reader["StaffId"],
								Name = reader["Name"].ToString(),
								Shift = reader["Shift"].ToString(),
								Salary = (int)reader["Salary"],
								UserId = (int)reader["UserId"]
							};

							staffList.Add(staff);
						}
					}
				}
			}

			return staffList;
		}
		public void CreateAttendance(Attendance newAttendance)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// Define your SQL query to insert a new Attendance record
				string query = "INSERT INTO Attendance (StaffId, Status, DateTime) VALUES (@StaffId, @Status, @DateTime)";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@StaffId", newAttendance.StaffId);
					command.Parameters.AddWithValue("@Status", newAttendance.Status);
					command.Parameters.AddWithValue("@DateTime", newAttendance.DateTime);
					command.ExecuteNonQuery();
				}
			}
		}
		public decimal CalculateProfitForUser(int userId)
		{
			decimal totalProfit = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// Retrieve data from the DrinkOrder and Drink tables for a specific UserId
				string query = "SELECT DO.DrinkOrderId, DO.DrinkId, DO.Quantity, D.Price, D.Cost " +
							   "FROM DrinkOrder DO " +
							   "INNER JOIN Drink D ON DO.DrinkId = D.DrinkId " +
							   "WHERE DO.UserId = @UserId";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@UserId", userId);

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							int drinkId = (int)reader["DrinkId"];
							int quantity = (int)reader["Quantity"];
							decimal price = (decimal)reader["Price"];
							decimal cost = (decimal)reader["Cost"];

							decimal profit = (price - cost) * quantity;
							totalProfit += profit;
						}
					}
				}
			}

			return totalProfit;
		}

		
	}

}
