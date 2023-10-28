using coffeApp.Model;
using Microsoft.Data.SqlClient;


namespace coffeApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CafeData;User ID=sa;Password=123;";

        public User GetUserByUsernameAndPassword()
        {
            string username = txtUserNameLogin.Text;
            string password = txtPasswordLogin.Text;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                

                string query = "SELECT UserId, Name, UserName, Point FROM [User] WHERE UserName = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // User found, create a User object
                            User user = new User
                            {
                                UserId = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                UserName = reader.GetString(2),                             
                                Point = reader.GetInt32(3)
                            };
                            return user;
                        }
                    }
                }
            }

            return null; // User not found
        }
       
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

                   int? userId = (int?)command.ExecuteScalar();

                    if (userId != null)
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

                            if (userRoles.Contains("Branch stores"))
                            {
                                // Open the Customer form
                                UserForm userForm = new UserForm();
                                userForm.SetDataFromLogin(GetUserByUsernameAndPassword());
                                userForm.Show();
                            }
                            else if (userRoles.Contains("Manager"))
                            {
                                // Open the Admin form
                                ManagementAll managementAll = new ManagementAll();
								managementAll.Show();
							}
                            else
                            {
                                MessageBox.Show("User does not have a valid role.");
                            }
                        }                      
                        this.Hide(); 
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