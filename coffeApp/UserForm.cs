using coffeApp.Model;

namespace coffeApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();


        }
        public User user { get; set; }

        public void SetDataFromLogin(User data)
        {
            user = data;
        }
        bool menuExpand = false;


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
            subMenu2.SetDataFromLogin(user);
            subMenu2.Show();
        }

        private void Aboutbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
            BusinessInformation businessInformation = new BusinessInformation();
            businessInformation.Show();
        }
    }
}