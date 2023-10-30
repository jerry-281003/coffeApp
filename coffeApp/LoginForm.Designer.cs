namespace coffeApp
{
	partial class LoginForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			labelUserName = new Label();
			labelPassword = new Label();
			txtUserNameLogin = new TextBox();
			txtPasswordLogin = new TextBox();
			btnLogin = new Button();
			panel1 = new Panel();
			label1 = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// labelUserName
			// 
			labelUserName.AutoSize = true;
			labelUserName.BackColor = Color.FromArgb(255, 224, 192);
			labelUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelUserName.Location = new Point(555, 255);
			labelUserName.Margin = new Padding(2, 0, 2, 0);
			labelUserName.Name = "labelUserName";
			labelUserName.Size = new Size(137, 32);
			labelUserName.TabIndex = 0;
			labelUserName.Text = "User Name:";
			// 
			// labelPassword
			// 
			labelPassword.AutoSize = true;
			labelPassword.BackColor = Color.FromArgb(255, 224, 192);
			labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			labelPassword.Location = new Point(570, 313);
			labelPassword.Margin = new Padding(2, 0, 2, 0);
			labelPassword.Name = "labelPassword";
			labelPassword.Size = new Size(116, 32);
			labelPassword.TabIndex = 1;
			labelPassword.Text = "Password:";
			// 
			// txtUserNameLogin
			// 
			txtUserNameLogin.Location = new Point(697, 255);
			txtUserNameLogin.Margin = new Padding(2, 4, 2, 4);
			txtUserNameLogin.Name = "txtUserNameLogin";
			txtUserNameLogin.Size = new Size(165, 31);
			txtUserNameLogin.TabIndex = 2;
			// 
			// txtPasswordLogin
			// 
			txtPasswordLogin.Location = new Point(697, 316);
			txtPasswordLogin.Margin = new Padding(2, 4, 2, 4);
			txtPasswordLogin.Name = "txtPasswordLogin";
			txtPasswordLogin.Size = new Size(165, 31);
			txtPasswordLogin.TabIndex = 3;
			txtPasswordLogin.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			btnLogin.BackColor = Color.FromArgb(255, 224, 192);
			btnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogin.Location = new Point(697, 383);
			btnLogin.Margin = new Padding(2, 4, 2, 4);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(150, 49);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(255, 224, 192);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(552, 96);
			panel1.Margin = new Padding(4);
			panel1.Name = "panel1";
			panel1.Size = new Size(310, 91);
			panel1.TabIndex = 5;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(44, 16);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(218, 61);
			label1.TabIndex = 0;
			label1.Text = "SIGN IN";
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(973, 626);
			Controls.Add(panel1);
			Controls.Add(btnLogin);
			Controls.Add(txtPasswordLogin);
			Controls.Add(txtUserNameLogin);
			Controls.Add(labelPassword);
			Controls.Add(labelUserName);
			Margin = new Padding(2, 4, 2, 4);
			Name = "LoginForm";
			Text = "LoginForm";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelUserName;
		private Label labelPassword;
		private TextBox txtUserNameLogin;
		private TextBox txtPasswordLogin;
		private Button btnLogin;
		private Panel panel1;
		private Label label1;
	}
}