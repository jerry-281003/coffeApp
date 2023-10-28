using coffeApp.Model;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
	public partial class ManagementAll : Form
	{
		public ManagementAll()
		{
			InitializeComponent();
			AdditemtoComboBox();
			ShowStaffs();
		}
		string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CafeData;User ID=sa;Password=123;";

	
		private void btnShowOrder_Click_1(object sender, EventArgs e)
		{
			List<Order> orders = new List<Order>();
			orders = GetOrders();
			TableShowOrder.DataSource = orders;
		}

		private void btnCalculateRevenue_Click(object sender, EventArgs e)
		{
			List<Order> orders = new List<Order>();
			orders = GetOrders();
			int totalRevenue = 0;
			foreach (Order order in orders)
			{
				totalRevenue += order.Total;
			}
			labelRevenue.Text = totalRevenue.ToString() + "VND";
		}

		private void btnAddStaff_Click(object sender, EventArgs e)
		{
			Staff staff = new Staff();
			staff.Salary = int.Parse(inputSalary.Text.ToString());
			staff.Name = inputName.Text.ToString();
			staff.Shift = inputShift.Text.ToString();
			staff.UserId = int.Parse(inputUserId.Text.ToString());
			CreateStaff(staff);
			ShowStaffs();
		}
		private void TableShowStaff_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{

		}

		private void btnCalculateProfit_Click(object sender, EventArgs e)
		{
			decimal profit = CalculateProfit();
			labelProfit.Text = profit.ToString() + "VND";
		}


		public List<Order> GetOrders()
		{
			List<Order> orders = new List<Order>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT OrderId, UserId, DateTime, PointUse, Status, Total FROM [Order]";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
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

		public void CreateStaff(Staff newStaff)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// Define your SQL query to insert a new Staff record
				string query = "INSERT INTO Staff (Name, Shift, Salary, UserId) VALUES (@Name, @Shift, @Salary, @UserId)";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Name", newStaff.Name);
					command.Parameters.AddWithValue("@Shift", newStaff.Shift);
					command.Parameters.AddWithValue("@Salary", newStaff.Salary);
					command.Parameters.AddWithValue("@UserId", newStaff.UserId);
					command.ExecuteNonQuery();
				}
			}
		}
		public void ShowStaffs()
		{
			List<Staff> staff = new List<Staff>();
			staff = GetAllStaff();
			TableShowStaff.DataSource = staff;
		}


		public List<Staff> GetAllStaff()
		{
			List<Staff> staffList = new List<Staff>();

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// Define your SQL query to select all staff
				string query = "SELECT StaffId, Name, Shift, Salary, UserId FROM Staff";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
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
		public decimal CalculateProfit()
		{
			decimal totalProfit = 0;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();

				// Retrieve data from the DrinkOrder table and join with the Drink table to get price and cost information
				string query = "SELECT DO.DrinkOrderId, DO.DrinkId, DO.Quantity, D.Price, D.Cost FROM DrinkOrder DO " +
							   "INNER JOIN Drink D ON DO.DrinkId = D.DrinkId";

				using (SqlCommand command = new SqlCommand(query, connection))
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						int drinkOrderId = (int)reader["DrinkOrderId"];
						int drinkId = (int)reader["DrinkId"];
						int quantity = (int)reader["Quantity"];
						decimal price = (decimal)reader["Price"];
						decimal cost = (decimal)reader["Cost"];

						decimal profit = (price - cost) * quantity;
						totalProfit += profit;
					}
				}
			}

			return totalProfit;
		}
		public void AdditemtoComboBox()
		{
			inputShift.Items.Add("9h-12h");
			inputShift.Items.Add("12h-3h");
			inputShift.Items.Add("3h-6h");
			inputShift.Items.Add("6h-9h");
			inputShift.Items.Add("full time");
			inputUserId.Items.Add("1");
			inputUserId.Items.Add("2");
		}

		
	}

}
