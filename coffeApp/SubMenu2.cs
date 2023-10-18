using coffeApp.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace coffeApp
{
    public partial class SubMenu2 : Form
    {
        public User user { get; set; }

        public void SetDataFromLogin(User data)
        {
            user = data;
        }
        public SubMenu2()
        {
            InitializeComponent();
            
        }
        bool menuExpand = false;
        int total = 0;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CafeData;User ID=sa;Password=123;";
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DashBoardpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboardbutton_Click_1(object sender, EventArgs e)
        {

        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                MenuContainer.Height += 10;
                if (MenuContainer.Height >= 211)
                {
                    menuTransition.Stop();
                    menuExpand = true;

                }
            }
            else
            {
                MenuContainer.Height -= 10;
                if (MenuContainer.Height <= 67)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void Menubutton_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }


        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 15;
                if (sidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    DashBoardpanel.Width = sidebar.Width;
                    Aboutpanel2.Width = sidebar.Width;
                    Settingspanel.Width = sidebar.Width;
                    MenuContainer.Width = sidebar.Width;
                    Logoutpanel.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 15;
                if (sidebar.Width >= 211)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    DashBoardpanel.Width = sidebar.Width;
                    Aboutpanel2.Width = sidebar.Width;
                    Settingspanel.Width = sidebar.Width;
                    MenuContainer.Width = sidebar.Width;
                    Logoutpanel.Width = sidebar.Width;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void Submenu1button_Click(object sender, EventArgs e)
        {
            this.Close();
            SubMenu1 subMenu1 = new SubMenu1();
            subMenu1.SetDataFromLogin(user);
            subMenu1.Show();
        }

        private void Submenu2button_Click(object sender, EventArgs e)
        {
            this.Close();
            SubMenu2 subMenu2 = new SubMenu2();
            subMenu2.Show();
        }

        private void Aboutbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
            BusinessInformation businessInformation = new BusinessInformation();
            businessInformation.Show();
        }

        private void btnMinusLycheeJellyTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(NumberLycheeJellyTea.Text);
            if (Num > 0)
            { Num -= 1;
                total -= 45000;
            }
            NumberLycheeJellyTea.Text = Num.ToString();
            
        }

        private void btnPlusLycheeJellyTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(NumberLycheeJellyTea.Text);
            Num += 1;
            NumberLycheeJellyTea.Text = Num.ToString();
            total+= 45000;
            TotalBill.Text = total.ToString();
        }

        private void btnMinusGoldenLotusTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberGoldenLotusTea.Text);
            if (Num > 0)
            { Num -= 1;
                total -= 45000;
            }
            numberGoldenLotusTea.Text = Num.ToString();
            
            TotalBill.Text = total.ToString();

        }

        private void btnPlusGoldenLotusTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberGoldenLotusTea.Text);
            Num += 1;
            numberGoldenLotusTea.Text = Num.ToString();
            total += 45000;
            TotalBill.Text = total.ToString();
        }

        private void btnMinusPeachJellyTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberPeachJellyTea.Text);
            if (Num > 0)
            { Num -= 1;
                total -= 45000;
            }
            numberPeachJellyTea.Text = Num.ToString();
            
            TotalBill.Text = total.ToString();
        }
        private void btnPlusPeachJellyTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberPeachJellyTea.Text);
            Num += 1;
            numberPeachJellyTea.Text = Num.ToString();
            total +=  45000;
            TotalBill.Text = total.ToString();
        }

        private void btnMinusRedBeanGreenTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberRedBeanGreenTea.Text);
            if (Num > 0)
            { Num -= 1;
              total -= 45000;
            }
            numberRedBeanGreenTea.Text = Num.ToString();
            
            TotalBill.Text = total.ToString();
        }

        private void btnPlusRedBeanGreenTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberRedBeanGreenTea.Text);
            Num += 1;
            numberRedBeanGreenTea.Text = Num.ToString();
            total += 45000;
            TotalBill.Text = total.ToString();
        }

        private void btnMinusPeachTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberPeachTea.Text);
            if (Num > 0)
            { Num -= 1;
                total -= 45000;
            }
            numberPeachTea.Text = Num.ToString();
            
            TotalBill.Text = total.ToString();
        }

        private void btnPlusPeachTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(numberPeachTea.Text);
            Num += 1;
            numberPeachTea.Text = Num.ToString();
            total += 45000;
            TotalBill.Text = total.ToString();
        }

        private void btnMinusLycheeTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(NumberLycheeJellyTea.Text);
            if (Num > 0)
            { Num -= 1;
                total -= 45000;
            }
            NumberLycheeJellyTea.Text = Num.ToString();
            
            TotalBill.Text = total.ToString();
        }

        private void btnPlusLycheeTea_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(NumberLycheeJellyTea.Text);
            Num += 1;
            NumberLycheeJellyTea.Text = Num.ToString();
            total+= 45000;
            TotalBill.Text = total.ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int DrinkId;
            int DrinkOrderId;
            int Quantity;
            List<int> drinkOrderList = new List<int>();
            DateTime time = DateTime.Now;
            if (total > 0)
            {
                
                if (int.Parse(NumberLycheeJellyTea.Text) > 0)
                {
                    DrinkId = GetDrinkID("Lychee Jelly Tea");
                    Quantity = int.Parse(NumberLycheeJellyTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);
                }
                if (int.Parse(numberPeachTea.Text) > 0)
                {
                    DrinkId = GetDrinkID("Peach Tea");
                    Quantity = int.Parse(numberPeachTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);
                }
                if (int.Parse(numberGoldenLotusTea.Text) > 0)
                {
                    DrinkId = GetDrinkID("Golden Lotus Tea");
                    Quantity = int.Parse(numberGoldenLotusTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);
                }
                if (int.Parse(numberLycheeTea.Text) > 0)
                {
                    DrinkId = GetDrinkID("Lychee Tea");
                    Quantity = int.Parse(numberLycheeTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);
                }
                if (int.Parse(numberRedBeanGreenTea.Text) > 0)
                {
                    DrinkId = GetDrinkID("Red Bean Green Tea");
                    Quantity = int.Parse(numberRedBeanGreenTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);
                }
                if (int.Parse(numberPeachJellyTea.Text) > 0)
                {
                    DrinkId = GetDrinkID("Peach Jelly Tea");
                    Quantity = int.Parse(numberPeachJellyTea.Text);
                    CreateDrinkOrder(DrinkId, Quantity, time);
                    DrinkOrderId = GetDrinkOrderId(DrinkId, Quantity, time);
                    drinkOrderList.Add(DrinkOrderId);
                }
                Order order =new Order();
                order.UserId = user.UserId;
                order.PointUse = 0;
                order.DateTime= DateTime.Now;
                order.Status = false;
                order.Total = total;
                CreateOrder(order);
                total = 0;
            }
            else
            {
                drinkOrderList.Clear();
            }
            
        }
        private int GetDrinkID(String drinkName)
            {
            
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT DrinkId FROM Drink WHERE DrinkName = @DrinkName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DrinkName", drinkName);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int drinkId;
                            if (int.TryParse(result.ToString(), out drinkId))
                            {
                                return drinkId;
                            }
                        }
                    }
                }

                return -1; // Drink not found
            }

        public void CreateDrinkOrder(int DrinkId, int Quantity, DateTime Time)
        {
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO DrinkOrder ( DrinkId, Quantity,Time) " +
                                   "VALUES (@DrinkId, @Quantity,@Time)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DrinkId", DrinkId);
                        command.Parameters.AddWithValue("@Quantity", Quantity);
                        command.Parameters.AddWithValue("@Time", Time);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }



    
        public int GetDrinkOrderId(int drinkId, int quantity, DateTime time)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DrinkOrderId FROM DrinkOrder WHERE DrinkId = @DrinkId AND Quantity = @Quantity AND Time = @Time";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrinkId", drinkId);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Time", time);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int drinkOrderId;
                        if (int.TryParse(result.ToString(), out drinkOrderId))
                        {
                            return drinkOrderId;
                        }
                    }
                }
            }

            return -1; // Drink order not found
        }
        public void CreateOrder(Order order)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO [Order] (UserId, DateTime, PointUse, Status, Total) " +
                               "VALUES (@UserId, @DateTime, @PointUse, @Status, @Total)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", order.UserId);
                    command.Parameters.AddWithValue("@DateTime", order.DateTime);
                    command.Parameters.AddWithValue("@PointUse", order.PointUse);
                    command.Parameters.AddWithValue("@Status", order.Status);
                    command.Parameters.AddWithValue("@Total", order.Total);

                    command.ExecuteNonQuery();
                }
            }
        }

    }


}
