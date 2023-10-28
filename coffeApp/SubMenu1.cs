using coffeApp.Model;
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
	public partial class SubMenu1 : Form
	{
		public User user { get; set; }
		public SubMenu1()
		{
			InitializeComponent();
		}
		public void SetDataFromLogin(User data)
		{
			user = data;
		}
		bool menuExpand = false;
		int total = 0;
		private void SubMenu1_Load(object sender, EventArgs e)
		{

		}
		private void label1_Click(object sender, EventArgs e)
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
			this.Hide();
			SubMenu1 subMenu1 = new SubMenu1();
			subMenu1.Show();
		}

		private void Submenu2button_Click(object sender, EventArgs e)
		{
			this.Hide();
			SubMenu2 subMenu2 = new SubMenu2();
			subMenu2.Show();
		}

		private void Aboutbutton2_Click(object sender, EventArgs e)
		{
			this.Hide();
			BusinessInformation businessInformation = new BusinessInformation();
			businessInformation.Show();
		}

		private void btnMinusEspresso_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberEspresso.Text);
			if (Num > 0)
			{
				Num -= 1;
				total -= 45000;
			}
			numberEspresso.Text = Num.ToString();
			labelTotal.Text = total.ToString();
		}

		private void btnPlusEspresso_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberEspresso.Text);
			Num += 1;
			numberEspresso.Text = Num.ToString();
			total += 45000;
			labelTotal.Text = total.ToString();
		}

		private void btnMinusLatte_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberLatte.Text);
			if (Num > 0)
			{
				Num -= 1;
				total -= 65000;
			}
			numberLatte.Text = Num.ToString();
			labelTotal.Text = total.ToString();
		}

		private void btnPlusLatte_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberLatte.Text);
			Num += 1;
			total += 65000;
			numberLatte.Text = Num.ToString();
			labelTotal.Text = total.ToString();
		}

		private void btnMinusCappuccino_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberCappuccino.Text);
			if (Num > 0)
			{
				Num -= 1;
				total -= 65000;
			}
			numberCappuccino.Text = Num.ToString();
			labelTotal.Text = total.ToString();
		}

		private void btnPlusCappuccino_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberCappuccino.Text);
			Num += 1;
			total += 65000;
			numberCappuccino.Text = Num.ToString();
		}

		private void btnMinusAmericano_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberAmericano.Text);
			if (Num > 0)
			{
				Num -= 1;
				total -= 45000;
			}
			numberAmericano.Text = Num.ToString();
			labelTotal.Text = total.ToString();
		}

		private void btnPlusAmericano_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberAmericano.Text);
			Num += 1;
			total += 45000;
			numberAmericano.Text = Num.ToString();
			labelTotal.Text = total.ToString();
		}

		private void btnMinusCaramelMacchiato_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberCaramelMacchiato.Text);
			if (Num > 0)
			{
				Num -= 1;
				total -= 45000;
			}
			numberCaramelMacchiato.Text = Num.ToString();
			labelTotal.Text = total.ToString();

		}

		private void btnPlusCaramelMacchiato_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberCaramelMacchiato.Text);
			Num += 1;
			total += 45000;
			numberCaramelMacchiato.Text = Num.ToString();
			labelTotal.Text = total.ToString();
		}

		private void btnMinusBlackCoffee_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberBlackCoffee.Text);
			if (Num > 0)
			{
				Num -= 1;
				total -= 29000;
			}
			numberBlackCoffee.Text = Num.ToString();
			labelTotal.Text = total.ToString();
		}

		private void btnPlusBlackCoffee_Click(object sender, EventArgs e)
		{
			int Num = int.Parse(numberBlackCoffee.Text);
			Num += 1;
			total += 29000;
			numberBlackCoffee.Text = Num.ToString();
			labelTotal.Text = total.ToString();
		}
	}
}
