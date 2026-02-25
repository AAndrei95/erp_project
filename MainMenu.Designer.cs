namespace Digital_Shop_Software
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            UsersButton = new Button();
            SignOutButton = new Button();
            ExitButton = new Button();
            ReportsButton = new Button();
            OrdersButton = new Button();
            CustomersButton = new Button();
            SuppliersButton = new Button();
            StockButton = new Button();
            MainMenu_Txt = new Label();
            Username = new Label();
            panel2 = new Panel();
            U_Name = new Label();
            Display = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(0, 70, 60);
            panel1.Controls.Add(UsersButton);
            panel1.Controls.Add(SignOutButton);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(ReportsButton);
            panel1.Controls.Add(OrdersButton);
            panel1.Controls.Add(CustomersButton);
            panel1.Controls.Add(SuppliersButton);
            panel1.Controls.Add(StockButton);
            panel1.Controls.Add(MainMenu_Txt);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 650);
            panel1.TabIndex = 0;
            // 
            // UsersButton
            // 
            UsersButton.AutoSize = true;
            UsersButton.BackColor = Color.FromArgb(255, 201, 134);
            UsersButton.FlatAppearance.BorderColor = Color.Red;
            UsersButton.FlatAppearance.MouseOverBackColor = Color.Red;
            UsersButton.FlatStyle = FlatStyle.Popup;
            UsersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UsersButton.ForeColor = Color.FromArgb(0, 70, 60);
            UsersButton.Image = (Image)resources.GetObject("UsersButton.Image");
            UsersButton.ImageAlign = ContentAlignment.MiddleLeft;
            UsersButton.ImeMode = ImeMode.NoControl;
            UsersButton.Location = new Point(13, 392);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(250, 57);
            UsersButton.TabIndex = 20;
            UsersButton.Text = "Users";
            UsersButton.UseVisualStyleBackColor = false;
            UsersButton.Click += UsersButton_Click;
            // 
            // SignOutButton
            // 
            SignOutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SignOutButton.AutoSize = true;
            SignOutButton.BackColor = Color.FromArgb(255, 201, 134);
            SignOutButton.FlatAppearance.BorderColor = Color.Red;
            SignOutButton.FlatAppearance.MouseOverBackColor = Color.Red;
            SignOutButton.FlatStyle = FlatStyle.Popup;
            SignOutButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SignOutButton.ForeColor = Color.FromArgb(0, 70, 60);
            SignOutButton.Image = (Image)resources.GetObject("SignOutButton.Image");
            SignOutButton.ImageAlign = ContentAlignment.MiddleLeft;
            SignOutButton.ImeMode = ImeMode.NoControl;
            SignOutButton.Location = new Point(13, 494);
            SignOutButton.Name = "SignOutButton";
            SignOutButton.Size = new Size(250, 57);
            SignOutButton.TabIndex = 19;
            SignOutButton.Text = "Sign Out";
            SignOutButton.UseVisualStyleBackColor = false;
            SignOutButton.Click += SignOutButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ExitButton.AutoSize = true;
            ExitButton.BackColor = Color.FromArgb(255, 201, 134);
            ExitButton.FlatAppearance.BorderColor = Color.Red;
            ExitButton.FlatAppearance.MouseOverBackColor = Color.Red;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.FromArgb(0, 70, 60);
            ExitButton.Image = (Image)resources.GetObject("ExitButton.Image");
            ExitButton.ImageAlign = ContentAlignment.MiddleLeft;
            ExitButton.ImeMode = ImeMode.NoControl;
            ExitButton.Location = new Point(13, 557);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(250, 57);
            ExitButton.TabIndex = 18;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.AutoSize = true;
            ReportsButton.BackColor = Color.FromArgb(255, 201, 134);
            ReportsButton.FlatAppearance.BorderColor = Color.Red;
            ReportsButton.FlatAppearance.MouseOverBackColor = Color.Red;
            ReportsButton.FlatStyle = FlatStyle.Popup;
            ReportsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReportsButton.ForeColor = Color.FromArgb(0, 70, 60);
            ReportsButton.Image = (Image)resources.GetObject("ReportsButton.Image");
            ReportsButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReportsButton.ImeMode = ImeMode.NoControl;
            ReportsButton.Location = new Point(13, 329);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(250, 57);
            ReportsButton.TabIndex = 17;
            ReportsButton.Text = "Reports";
            ReportsButton.UseVisualStyleBackColor = false;
            ReportsButton.Click += ReportsButton_Click;
            // 
            // OrdersButton
            // 
            OrdersButton.AutoSize = true;
            OrdersButton.BackColor = Color.FromArgb(255, 201, 134);
            OrdersButton.FlatAppearance.BorderColor = Color.Red;
            OrdersButton.FlatAppearance.MouseOverBackColor = Color.Red;
            OrdersButton.FlatStyle = FlatStyle.Popup;
            OrdersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrdersButton.ForeColor = Color.FromArgb(0, 70, 60);
            OrdersButton.Image = (Image)resources.GetObject("OrdersButton.Image");
            OrdersButton.ImageAlign = ContentAlignment.MiddleLeft;
            OrdersButton.ImeMode = ImeMode.NoControl;
            OrdersButton.Location = new Point(13, 266);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(250, 57);
            OrdersButton.TabIndex = 16;
            OrdersButton.Text = "Orders";
            OrdersButton.UseVisualStyleBackColor = false;
            OrdersButton.Click += OrdersButton_Click;
            // 
            // CustomersButton
            // 
            CustomersButton.AutoSize = true;
            CustomersButton.BackColor = Color.FromArgb(255, 201, 134);
            CustomersButton.FlatAppearance.BorderColor = Color.Red;
            CustomersButton.FlatAppearance.MouseOverBackColor = Color.Red;
            CustomersButton.FlatStyle = FlatStyle.Popup;
            CustomersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomersButton.ForeColor = Color.FromArgb(0, 70, 60);
            CustomersButton.Image = (Image)resources.GetObject("CustomersButton.Image");
            CustomersButton.ImageAlign = ContentAlignment.MiddleLeft;
            CustomersButton.ImeMode = ImeMode.NoControl;
            CustomersButton.Location = new Point(13, 203);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(250, 57);
            CustomersButton.TabIndex = 15;
            CustomersButton.Text = "Customers";
            CustomersButton.UseVisualStyleBackColor = false;
            CustomersButton.Click += CustomersButton_Click;
            // 
            // SuppliersButton
            // 
            SuppliersButton.AutoSize = true;
            SuppliersButton.BackColor = Color.FromArgb(255, 201, 134);
            SuppliersButton.FlatAppearance.BorderColor = Color.Red;
            SuppliersButton.FlatAppearance.MouseOverBackColor = Color.Red;
            SuppliersButton.FlatStyle = FlatStyle.Popup;
            SuppliersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SuppliersButton.ForeColor = Color.FromArgb(0, 70, 60);
            SuppliersButton.Image = (Image)resources.GetObject("SuppliersButton.Image");
            SuppliersButton.ImageAlign = ContentAlignment.MiddleLeft;
            SuppliersButton.ImeMode = ImeMode.NoControl;
            SuppliersButton.Location = new Point(13, 140);
            SuppliersButton.Name = "SuppliersButton";
            SuppliersButton.Size = new Size(250, 57);
            SuppliersButton.TabIndex = 14;
            SuppliersButton.Text = "Suppliers";
            SuppliersButton.UseVisualStyleBackColor = false;
            SuppliersButton.Click += SuppliersButton_Click;
            // 
            // StockButton
            // 
            StockButton.AutoSize = true;
            StockButton.BackColor = Color.FromArgb(255, 201, 134);
            StockButton.FlatAppearance.BorderColor = Color.Red;
            StockButton.FlatAppearance.MouseOverBackColor = Color.Red;
            StockButton.FlatStyle = FlatStyle.Popup;
            StockButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StockButton.ForeColor = Color.FromArgb(0, 70, 60);
            StockButton.Image = (Image)resources.GetObject("StockButton.Image");
            StockButton.ImageAlign = ContentAlignment.MiddleLeft;
            StockButton.ImeMode = ImeMode.NoControl;
            StockButton.Location = new Point(13, 77);
            StockButton.Name = "StockButton";
            StockButton.Size = new Size(250, 57);
            StockButton.TabIndex = 13;
            StockButton.Text = "Stock";
            StockButton.UseVisualStyleBackColor = false;
            StockButton.Click += StockButton_Click;
            // 
            // MainMenu_Txt
            // 
            MainMenu_Txt.AutoSize = true;
            MainMenu_Txt.BackColor = Color.Transparent;
            MainMenu_Txt.Font = new Font("Bahnschrift", 14F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenu_Txt.ForeColor = Color.FromArgb(255, 201, 134);
            MainMenu_Txt.ImeMode = ImeMode.NoControl;
            MainMenu_Txt.Location = new Point(60, 9);
            MainMenu_Txt.Name = "MainMenu_Txt";
            MainMenu_Txt.Size = new Size(152, 34);
            MainMenu_Txt.TabIndex = 12;
            MainMenu_Txt.Text = "Main Menu";
            MainMenu_Txt.Click += MainMenu_Txt_Click;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Bahnschrift", 8F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.FromArgb(255, 201, 134);
            Username.ImeMode = ImeMode.NoControl;
            Username.Location = new Point(3, 6);
            Username.Name = "Username";
            Username.Size = new Size(180, 19);
            Username.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 70, 60);
            panel2.Controls.Add(Username);
            panel2.Controls.Add(U_Name);
            panel2.Location = new Point(271, 614);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 34);
            panel2.TabIndex = 1;
            // 
            // U_Name
            // 
            U_Name.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            U_Name.AutoSize = true;
            U_Name.BackColor = Color.Transparent;
            U_Name.Font = new Font("Bahnschrift", 8F, FontStyle.Bold, GraphicsUnit.Point);
            U_Name.ForeColor = Color.FromArgb(255, 201, 134);
            U_Name.ImeMode = ImeMode.NoControl;
            U_Name.Location = new Point(364, 6);
            U_Name.Name = "U_Name";
            U_Name.Size = new Size(213, 19);
            U_Name.TabIndex = 5;
            U_Name.Text = "DS Software Solutions  2023";
            // 
            // Display
            // 
            Display.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Display.BackColor = Color.AntiqueWhite;
            Display.Location = new Point(271, 3);
            Display.Name = "Display";
            Display.Size = new Size(576, 611);
            Display.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(0, 70, 60);
            panel4.Location = new Point(840, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 614);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(0, 70, 60);
            panel5.Location = new Point(269, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(571, 10);
            panel5.TabIndex = 0;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(850, 648);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(Display);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainMenu_FormClosing;
            Load += MainMenu_Load;
            Resize += MainMenu_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label MainMenu_Txt;
        private Button StockButton;
        private Button ReportsButton;
        private Button OrdersButton;
        private Button CustomersButton;
        private Button SuppliersButton;
        private Button ExitButton;
        private Button SignOutButton;
        private Button UsersButton;
        private Panel panel2;
        private Label U_Name;
        public Label Username;
        private Panel Display;
        private Panel panel4;
        private Panel panel5;
    }
}