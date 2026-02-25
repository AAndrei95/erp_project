namespace Digital_Shop_Software
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Username = new TextBox();
            Password = new TextBox();
            U_Name_txt = new Label();
            Password_txt = new Label();
            ResetPass = new Label();
            LoginButton = new Button();
            QuitButton = new Button();
            ShowPass = new Label();
            UserLabel = new Label();
            LockLabel = new Label();
            Title_txt = new Label();
            SuspendLayout();
            // 
            // Username
            // 
            resources.ApplyResources(Username, "Username");
            Username.BackColor = Color.AntiqueWhite;
            Username.Cursor = Cursors.IBeam;
            Username.ForeColor = Color.FromArgb(0, 70, 60);
            Username.Name = "Username";
            // 
            // Password
            // 
            resources.ApplyResources(Password, "Password");
            Password.BackColor = Color.AntiqueWhite;
            Password.ForeColor = Color.FromArgb(0, 70, 60);
            Password.Name = "Password";
            Password.UseSystemPasswordChar = true;
            // 
            // U_Name_txt
            // 
            resources.ApplyResources(U_Name_txt, "U_Name_txt");
            U_Name_txt.BackColor = Color.Transparent;
            U_Name_txt.ForeColor = Color.FromArgb(255, 201, 134);
            U_Name_txt.Name = "U_Name_txt";
            // 
            // Password_txt
            // 
            resources.ApplyResources(Password_txt, "Password_txt");
            Password_txt.BackColor = Color.Transparent;
            Password_txt.ForeColor = Color.FromArgb(255, 201, 134);
            Password_txt.Name = "Password_txt";
            // 
            // ResetPass
            // 
            resources.ApplyResources(ResetPass, "ResetPass");
            ResetPass.BackColor = Color.Transparent;
            ResetPass.ForeColor = Color.Linen;
            ResetPass.Name = "ResetPass";
            ResetPass.Click += ResetPass_Click;
            // 
            // LoginButton
            // 
            resources.ApplyResources(LoginButton, "LoginButton");
            LoginButton.BackColor = Color.FromArgb(255, 201, 134);
            LoginButton.FlatAppearance.BorderColor = Color.Red;
            LoginButton.FlatAppearance.MouseOverBackColor = Color.Red;
            LoginButton.ForeColor = Color.FromArgb(0, 70, 60);
            LoginButton.Name = "LoginButton";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // QuitButton
            // 
            resources.ApplyResources(QuitButton, "QuitButton");
            QuitButton.BackColor = Color.FromArgb(255, 201, 134);
            QuitButton.FlatAppearance.BorderColor = Color.Red;
            QuitButton.FlatAppearance.MouseOverBackColor = Color.Red;
            QuitButton.ForeColor = Color.FromArgb(0, 70, 60);
            QuitButton.Name = "QuitButton";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // ShowPass
            // 
            resources.ApplyResources(ShowPass, "ShowPass");
            ShowPass.Name = "ShowPass";
            ShowPass.MouseLeave += ShowPass_MouseLeave;
            ShowPass.MouseHover += ShowPass_MouseHover;
            // 
            // UserLabel
            // 
            resources.ApplyResources(UserLabel, "UserLabel");
            UserLabel.Name = "UserLabel";
            // 
            // LockLabel
            // 
            resources.ApplyResources(LockLabel, "LockLabel");
            LockLabel.Name = "LockLabel";
            // 
            // Title_txt
            // 
            resources.ApplyResources(Title_txt, "Title_txt");
            Title_txt.AccessibleRole = AccessibleRole.TitleBar;
            Title_txt.BackColor = Color.Transparent;
            Title_txt.CausesValidation = false;
            Title_txt.ForeColor = Color.FromArgb(255, 201, 134);
            Title_txt.Name = "Title_txt";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 70, 60);
            Controls.Add(Title_txt);
            Controls.Add(LockLabel);
            Controls.Add(UserLabel);
            Controls.Add(ShowPass);
            Controls.Add(QuitButton);
            Controls.Add(LoginButton);
            Controls.Add(ResetPass);
            Controls.Add(Password_txt);
            Controls.Add(U_Name_txt);
            Controls.Add(Password);
            Controls.Add(Username);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            TransparencyKey = Color.Transparent;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        public TextBox Username;
        public TextBox Password;
        private Label U_Name_txt;
        private Label Password_txt;
        private Label ResetPass;
        private Button LoginButton;
        private Button QuitButton;
        private Label ShowPass;
        private Label UserLabel;
        private Label LockLabel;
        private Label Title_txt;
    }
}