namespace coffeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            Menulabel = new Label();
            Hambutton = new PictureBox();
            sidebar = new FlowLayoutPanel();
            DashBoardpanel = new Panel();
            Dashboardbutton = new Button();
            MenuContainer = new FlowLayoutPanel();
            Menupanel = new Panel();
            Menubutton = new Button();
            Submenu1panel = new Panel();
            Submenu1button = new Button();
            Submenu2panel = new Panel();
            Submenu2button = new Button();
            Aboutpanel2 = new Panel();
            Aboutbutton2 = new Button();
            Settingspanel = new Panel();
            Settingsbutton = new Button();
            Logoutpanel = new Panel();
            Logoutbutton = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Hambutton).BeginInit();
            sidebar.SuspendLayout();
            DashBoardpanel.SuspendLayout();
            MenuContainer.SuspendLayout();
            Menupanel.SuspendLayout();
            Submenu1panel.SuspendLayout();
            Submenu2panel.SuspendLayout();
            Aboutpanel2.SuspendLayout();
            Settingspanel.SuspendLayout();
            Logoutpanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(Menulabel);
            panel1.Controls.Add(Hambutton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1375, 93);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1236, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 2;
            // 
            // Menulabel
            // 
            Menulabel.AutoSize = true;
            Menulabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Menulabel.Location = new Point(131, 34);
            Menulabel.Name = "Menulabel";
            Menulabel.Size = new Size(80, 31);
            Menulabel.TabIndex = 1;
            Menulabel.Text = "MENU";
            Menulabel.Click += label1_Click;
            // 
            // Hambutton
            // 
            Hambutton.Image = (Image)resources.GetObject("Hambutton.Image");
            Hambutton.Location = new Point(0, 0);
            Hambutton.Name = "Hambutton";
            Hambutton.Size = new Size(125, 94);
            Hambutton.SizeMode = PictureBoxSizeMode.Zoom;
            Hambutton.TabIndex = 0;
            Hambutton.TabStop = false;
            Hambutton.Click += pictureBox1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(DashBoardpanel);
            sidebar.Controls.Add(MenuContainer);
            sidebar.Controls.Add(Aboutpanel2);
            sidebar.Controls.Add(Settingspanel);
            sidebar.Controls.Add(Logoutpanel);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 93);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(211, 621);
            sidebar.TabIndex = 1;
            // 
            // DashBoardpanel
            // 
            DashBoardpanel.Controls.Add(Dashboardbutton);
            DashBoardpanel.Location = new Point(3, 3);
            DashBoardpanel.Name = "DashBoardpanel";
            DashBoardpanel.Size = new Size(211, 67);
            DashBoardpanel.TabIndex = 2;
            DashBoardpanel.Paint += DashBoardpanel_Paint;
            // 
            // Dashboardbutton
            // 
            Dashboardbutton.BackColor = Color.White;
            Dashboardbutton.BackgroundImageLayout = ImageLayout.Zoom;
            Dashboardbutton.ForeColor = Color.Black;
            Dashboardbutton.Image = (Image)resources.GetObject("Dashboardbutton.Image");
            Dashboardbutton.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboardbutton.Location = new Point(-14, -9);
            Dashboardbutton.Name = "Dashboardbutton";
            Dashboardbutton.Padding = new Padding(25, 0, 0, 0);
            Dashboardbutton.RightToLeft = RightToLeft.No;
            Dashboardbutton.Size = new Size(236, 85);
            Dashboardbutton.TabIndex = 3;
            Dashboardbutton.Text = "            Dashboard";
            Dashboardbutton.TextAlign = ContentAlignment.MiddleLeft;
            Dashboardbutton.UseVisualStyleBackColor = false;
            Dashboardbutton.Click += Dashboardbutton_Click_1;
            // 
            // MenuContainer
            // 
            MenuContainer.Controls.Add(Menupanel);
            MenuContainer.Controls.Add(Submenu1panel);
            MenuContainer.Controls.Add(Submenu2panel);
            MenuContainer.Location = new Point(3, 76);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Size = new Size(225, 67);
            MenuContainer.TabIndex = 7;
            // 
            // Menupanel
            // 
            Menupanel.Controls.Add(Menubutton);
            Menupanel.Location = new Point(3, 3);
            Menupanel.Name = "Menupanel";
            Menupanel.Size = new Size(211, 67);
            Menupanel.TabIndex = 4;
            // 
            // Menubutton
            // 
            Menubutton.BackColor = Color.White;
            Menubutton.BackgroundImageLayout = ImageLayout.Zoom;
            Menubutton.ForeColor = Color.Black;
            Menubutton.Image = (Image)resources.GetObject("Menubutton.Image");
            Menubutton.ImageAlign = ContentAlignment.MiddleLeft;
            Menubutton.Location = new Point(-17, -9);
            Menubutton.Name = "Menubutton";
            Menubutton.Padding = new Padding(25, 0, 0, 0);
            Menubutton.RightToLeft = RightToLeft.No;
            Menubutton.Size = new Size(239, 85);
            Menubutton.TabIndex = 3;
            Menubutton.Text = "            Menu";
            Menubutton.TextAlign = ContentAlignment.MiddleLeft;
            Menubutton.UseVisualStyleBackColor = false;
            Menubutton.Click += Menubutton_Click;
            // 
            // Submenu1panel
            // 
            Submenu1panel.Controls.Add(Submenu1button);
            Submenu1panel.Location = new Point(3, 76);
            Submenu1panel.Name = "Submenu1panel";
            Submenu1panel.Size = new Size(211, 67);
            Submenu1panel.TabIndex = 8;
            // 
            // Submenu1button
            // 
            Submenu1button.BackColor = Color.White;
            Submenu1button.BackgroundImageLayout = ImageLayout.Zoom;
            Submenu1button.ForeColor = Color.Black;
            Submenu1button.Image = (Image)resources.GetObject("Submenu1button.Image");
            Submenu1button.ImageAlign = ContentAlignment.MiddleLeft;
            Submenu1button.Location = new Point(-14, -9);
            Submenu1button.Name = "Submenu1button";
            Submenu1button.Padding = new Padding(25, 0, 0, 0);
            Submenu1button.RightToLeft = RightToLeft.No;
            Submenu1button.Size = new Size(236, 85);
            Submenu1button.TabIndex = 3;
            Submenu1button.Text = "Coffee";
            Submenu1button.UseVisualStyleBackColor = false;
            // 
            // Submenu2panel
            // 
            Submenu2panel.Controls.Add(Submenu2button);
            Submenu2panel.Location = new Point(3, 149);
            Submenu2panel.Name = "Submenu2panel";
            Submenu2panel.Size = new Size(211, 67);
            Submenu2panel.TabIndex = 9;
            // 
            // Submenu2button
            // 
            Submenu2button.BackColor = Color.White;
            Submenu2button.BackgroundImageLayout = ImageLayout.Zoom;
            Submenu2button.ForeColor = Color.Black;
            Submenu2button.Image = (Image)resources.GetObject("Submenu2button.Image");
            Submenu2button.ImageAlign = ContentAlignment.MiddleLeft;
            Submenu2button.Location = new Point(-14, -9);
            Submenu2button.Name = "Submenu2button";
            Submenu2button.Padding = new Padding(25, 0, 0, 0);
            Submenu2button.RightToLeft = RightToLeft.No;
            Submenu2button.Size = new Size(236, 85);
            Submenu2button.TabIndex = 3;
            Submenu2button.Text = "Freeze";
            Submenu2button.UseVisualStyleBackColor = false;
            // 
            // Aboutpanel2
            // 
            Aboutpanel2.Controls.Add(Aboutbutton2);
            Aboutpanel2.Location = new Point(3, 149);
            Aboutpanel2.Name = "Aboutpanel2";
            Aboutpanel2.Size = new Size(211, 67);
            Aboutpanel2.TabIndex = 7;
            // 
            // Aboutbutton2
            // 
            Aboutbutton2.BackColor = Color.White;
            Aboutbutton2.BackgroundImageLayout = ImageLayout.Zoom;
            Aboutbutton2.ForeColor = Color.Black;
            Aboutbutton2.Image = (Image)resources.GetObject("Aboutbutton2.Image");
            Aboutbutton2.ImageAlign = ContentAlignment.MiddleLeft;
            Aboutbutton2.Location = new Point(-14, -9);
            Aboutbutton2.Name = "Aboutbutton2";
            Aboutbutton2.Padding = new Padding(25, 0, 0, 0);
            Aboutbutton2.RightToLeft = RightToLeft.No;
            Aboutbutton2.Size = new Size(236, 85);
            Aboutbutton2.TabIndex = 3;
            Aboutbutton2.Text = "            About";
            Aboutbutton2.TextAlign = ContentAlignment.MiddleLeft;
            Aboutbutton2.UseVisualStyleBackColor = false;
            // 
            // Settingspanel
            // 
            Settingspanel.Controls.Add(Settingsbutton);
            Settingspanel.Location = new Point(3, 222);
            Settingspanel.Name = "Settingspanel";
            Settingspanel.Size = new Size(211, 67);
            Settingspanel.TabIndex = 4;
            // 
            // Settingsbutton
            // 
            Settingsbutton.BackColor = Color.White;
            Settingsbutton.BackgroundImageLayout = ImageLayout.Zoom;
            Settingsbutton.ForeColor = Color.Black;
            Settingsbutton.Image = (Image)resources.GetObject("Settingsbutton.Image");
            Settingsbutton.ImageAlign = ContentAlignment.MiddleLeft;
            Settingsbutton.Location = new Point(-15, -9);
            Settingsbutton.Name = "Settingsbutton";
            Settingsbutton.Padding = new Padding(25, 0, 0, 0);
            Settingsbutton.RightToLeft = RightToLeft.No;
            Settingsbutton.Size = new Size(236, 85);
            Settingsbutton.TabIndex = 3;
            Settingsbutton.Text = "            Settings";
            Settingsbutton.TextAlign = ContentAlignment.MiddleLeft;
            Settingsbutton.UseVisualStyleBackColor = false;
            // 
            // Logoutpanel
            // 
            Logoutpanel.Controls.Add(Logoutbutton);
            Logoutpanel.Location = new Point(3, 295);
            Logoutpanel.Name = "Logoutpanel";
            Logoutpanel.Size = new Size(211, 67);
            Logoutpanel.TabIndex = 6;
            // 
            // Logoutbutton
            // 
            Logoutbutton.BackColor = Color.White;
            Logoutbutton.BackgroundImageLayout = ImageLayout.Zoom;
            Logoutbutton.ForeColor = Color.Black;
            Logoutbutton.Image = (Image)resources.GetObject("Logoutbutton.Image");
            Logoutbutton.ImageAlign = ContentAlignment.MiddleLeft;
            Logoutbutton.Location = new Point(-14, -9);
            Logoutbutton.Name = "Logoutbutton";
            Logoutbutton.Padding = new Padding(25, 0, 0, 0);
            Logoutbutton.RightToLeft = RightToLeft.No;
            Logoutbutton.Size = new Size(236, 85);
            Logoutbutton.TabIndex = 3;
            Logoutbutton.Text = "            Logout";
            Logoutbutton.TextAlign = ContentAlignment.MiddleLeft;
            Logoutbutton.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 5;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 5;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1375, 714);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Hambutton).EndInit();
            sidebar.ResumeLayout(false);
            DashBoardpanel.ResumeLayout(false);
            MenuContainer.ResumeLayout(false);
            Menupanel.ResumeLayout(false);
            Submenu1panel.ResumeLayout(false);
            Submenu2panel.ResumeLayout(false);
            Aboutpanel2.ResumeLayout(false);
            Settingspanel.ResumeLayout(false);
            Logoutpanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Menulabel;
        private PictureBox Hambutton;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel sidebar;
        private Panel DashBoardpanel;
        private Button Dashboardbutton;
        private Panel Settingspanel;
        private Button Settingsbutton;
        private Panel Aboutpanel;
        private Button Aboutbutton;
        private FlowLayoutPanel MenuContainer;
        private Panel Logoutpanel;
        private Button Logoutbutton;
        private Panel Menupanel;
        private Button Menubutton;
        private Panel Submenu1panel;
        private Button Submenu1button;
        private Panel Submenu2panel;
        private Button Submenu2button;
        private System.Windows.Forms.Timer menuTransition;
        private Panel Aboutpanel2;
        private Button Aboutbutton2;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}