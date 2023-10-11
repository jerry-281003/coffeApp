using Microsoft.Data.SqlClient;


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
                string query = "SELECT COUNT(*) FROM [User] WHERE UserName = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password); // Note: Password should be hashed in a real application.

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount == 1)
                    {
                        MessageBox.Show("Login successful");
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