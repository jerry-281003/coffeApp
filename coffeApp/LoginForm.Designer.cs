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
            labelUserName = new Label();
            labelPassword = new Label();
            txtUserNameLogin = new TextBox();
            txtPasswordLogin = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(124, 55);
            labelUserName.Margin = new Padding(2, 0, 2, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(68, 15);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "User Name:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(125, 89);
            labelPassword.Margin = new Padding(2, 0, 2, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password";
            // 
            // txtUserNameLogin
            // 
            txtUserNameLogin.Location = new Point(200, 55);
            txtUserNameLogin.Margin = new Padding(2, 2, 2, 2);
            txtUserNameLogin.Name = "txtUserNameLogin";
            txtUserNameLogin.Size = new Size(106, 23);
            txtUserNameLogin.TabIndex = 2;
            // 
            // txtPasswordLogin
            // 
            txtPasswordLogin.Location = new Point(200, 89);
            txtPasswordLogin.Margin = new Padding(2, 2, 2, 2);
            txtPasswordLogin.Name = "txtPasswordLogin";
            txtPasswordLogin.Size = new Size(106, 23);
            txtPasswordLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(220, 142);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(78, 20);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnLogin);
            Controls.Add(txtPasswordLogin);
            Controls.Add(txtUserNameLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Margin = new Padding(2, 2, 2, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUserName;
        private Label labelPassword;
        private TextBox txtUserNameLogin;
        private TextBox txtPasswordLogin;
        private Button btnLogin;
    }
}