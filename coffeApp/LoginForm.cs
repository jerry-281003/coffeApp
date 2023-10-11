﻿using Microsoft.Data.SqlClient;


namespace coffeApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CafeManagemnt;User ID=sa;Password=123;";




        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserNameLogin.Text;
            string password = txtPasswordLogin.Text;
           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check the user's credentials
                string query = "SELECT UserId FROM [User] WHERE UserName = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    String? userId = (String?)command.ExecuteScalar();

                    if(userId!=null)
                    {
                        // Check the user's role
                        string roleQuery = "SELECT R.Name FROM Role R " +
                                           "INNER JOIN UserRole UR ON R.RoleId = UR.RoleId " +
                                           "WHERE UR.UserId = @UserId";
                        using (SqlCommand roleCommand = new SqlCommand(roleQuery, connection))
                        {
                            roleCommand.Parameters.AddWithValue("@UserId", userId.ToString());

                            var roles = roleCommand.ExecuteReader();
                            var userRoles = new List<string>();
                            while (roles.Read())
                            {
                                userRoles.Add(roles.GetString(0));
                            }
                            roles.Close();

                            if (userRoles.Contains("Customer"))
                            {
                                // Open the Customer form
                                UserForm userForm = new UserForm();
                                userForm.Show();
                            }
                            else if (userRoles.Contains("Admin"))
                            {
                                // Open the Admin form
                                
                            }
                            else
                            {
                                MessageBox.Show("User does not have a valid role.");
                            }
                        }

                        // Hide or close the login form
                        this.Hide(); // or this.Close() if you want to close the login form
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
        }
    }
}