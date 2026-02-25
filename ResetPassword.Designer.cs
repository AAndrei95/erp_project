namespace Digital_Shop_Software
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            SQAnswer = new TextBox();
            New_pass = new TextBox();
            New_pass_conf = new TextBox();
            SQuestion_txt = new Label();
            New_pass_txt = new Label();
            Pass_conf_txt = new Label();
            label3 = new Label();
            Instruction_txt = new TextBox();
            CancelButton = new Button();
            ResetPassButton = new Button();
            Hint = new Label();
            Username_txt = new Label();
            Username = new TextBox();
            SuspendLayout();
            // 
            // SQAnswer
            // 
            SQAnswer.BackColor = Color.AntiqueWhite;
            SQAnswer.Cursor = Cursors.IBeam;
            SQAnswer.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SQAnswer.ForeColor = Color.FromArgb(0, 70, 60);
            SQAnswer.Location = new Point(222, 145);
            SQAnswer.Name = "SQAnswer";
            SQAnswer.Size = new Size(180, 32);
            SQAnswer.TabIndex = 1;
            // 
            // New_pass
            // 
            New_pass.BackColor = Color.AntiqueWhite;
            New_pass.Cursor = Cursors.IBeam;
            New_pass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            New_pass.ForeColor = Color.FromArgb(0, 70, 60);
            New_pass.Location = new Point(222, 205);
            New_pass.Name = "New_pass";
            New_pass.Size = new Size(180, 34);
            New_pass.TabIndex = 2;
            New_pass.UseSystemPasswordChar = true;
            // 
            // New_pass_conf
            // 
            New_pass_conf.BackColor = Color.AntiqueWhite;
            New_pass_conf.Cursor = Cursors.IBeam;
            New_pass_conf.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            New_pass_conf.ForeColor = Color.FromArgb(0, 70, 60);
            New_pass_conf.Location = new Point(222, 265);
            New_pass_conf.Name = "New_pass_conf";
            New_pass_conf.Size = new Size(180, 34);
            New_pass_conf.TabIndex = 3;
            New_pass_conf.UseSystemPasswordChar = true;
            // 
            // SQuestion_txt
            // 
            SQuestion_txt.AutoSize = true;
            SQuestion_txt.BackColor = Color.Transparent;
            SQuestion_txt.Font = new Font("Bahnschrift", 8F, FontStyle.Bold, GraphicsUnit.Point);
            SQuestion_txt.ForeColor = Color.FromArgb(255, 201, 134);
            SQuestion_txt.ImeMode = ImeMode.NoControl;
            SQuestion_txt.Location = new Point(222, 123);
            SQuestion_txt.Name = "SQuestion_txt";
            SQuestion_txt.Size = new Size(137, 19);
            SQuestion_txt.TabIndex = 4;
            SQuestion_txt.Text = "Security Question";
            // 
            // New_pass_txt
            // 
            New_pass_txt.AutoSize = true;
            New_pass_txt.BackColor = Color.Transparent;
            New_pass_txt.Font = new Font("Bahnschrift", 8F, FontStyle.Bold, GraphicsUnit.Point);
            New_pass_txt.ForeColor = Color.FromArgb(255, 201, 134);
            New_pass_txt.ImeMode = ImeMode.NoControl;
            New_pass_txt.Location = new Point(222, 183);
            New_pass_txt.Name = "New_pass_txt";
            New_pass_txt.Size = new Size(117, 19);
            New_pass_txt.TabIndex = 5;
            New_pass_txt.Text = "New Password";
            // 
            // Pass_conf_txt
            // 
            Pass_conf_txt.AutoSize = true;
            Pass_conf_txt.BackColor = Color.Transparent;
            Pass_conf_txt.Font = new Font("Bahnschrift", 8F, FontStyle.Bold, GraphicsUnit.Point);
            Pass_conf_txt.ForeColor = Color.FromArgb(255, 201, 134);
            Pass_conf_txt.ImeMode = ImeMode.NoControl;
            Pass_conf_txt.Location = new Point(222, 243);
            Pass_conf_txt.Name = "Pass_conf_txt";
            Pass_conf_txt.Size = new Size(143, 19);
            Pass_conf_txt.TabIndex = 6;
            Pass_conf_txt.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 201, 134);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(-4, 29);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 7;
            // 
            // Instruction_txt
            // 
            Instruction_txt.BackColor = Color.FromArgb(0, 70, 60);
            Instruction_txt.BorderStyle = BorderStyle.None;
            Instruction_txt.Font = new Font("Bahnschrift", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Instruction_txt.ForeColor = Color.Linen;
            Instruction_txt.Location = new Point(74, 12);
            Instruction_txt.Multiline = true;
            Instruction_txt.Name = "Instruction_txt";
            Instruction_txt.Size = new Size(475, 53);
            Instruction_txt.TabIndex = 8;
            Instruction_txt.Text = "Please enter the answer for your security question below and enter the new password in the marked fields";
            Instruction_txt.TextAlign = HorizontalAlignment.Center;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(255, 201, 134);
            CancelButton.FlatAppearance.BorderColor = Color.Red;
            CancelButton.FlatAppearance.MouseOverBackColor = Color.Red;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CancelButton.ForeColor = Color.FromArgb(0, 70, 60);
            CancelButton.ImeMode = ImeMode.NoControl;
            CancelButton.Location = new Point(335, 315);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 34);
            CancelButton.TabIndex = 9;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // ResetPassButton
            // 
            ResetPassButton.BackColor = Color.FromArgb(255, 201, 134);
            ResetPassButton.FlatAppearance.BorderColor = Color.Red;
            ResetPassButton.FlatAppearance.MouseOverBackColor = Color.Red;
            ResetPassButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ResetPassButton.ForeColor = Color.FromArgb(0, 70, 60);
            ResetPassButton.ImeMode = ImeMode.NoControl;
            ResetPassButton.Location = new Point(174, 315);
            ResetPassButton.Name = "ResetPassButton";
            ResetPassButton.Size = new Size(112, 34);
            ResetPassButton.TabIndex = 10;
            ResetPassButton.Text = "Reset";
            ResetPassButton.UseVisualStyleBackColor = false;
            ResetPassButton.Click += ResetButton_Click;
            // 
            // Hint
            // 
            Hint.Image = (Image)resources.GetObject("Hint.Image");
            Hint.ImeMode = ImeMode.NoControl;
            Hint.Location = new Point(408, 144);
            Hint.Name = "Hint";
            Hint.Size = new Size(35, 33);
            Hint.TabIndex = 11;
            Hint.MouseLeave += Hint_MouseLeave;
            Hint.MouseHover += Hint_MouseHover;
            // 
            // Username_txt
            // 
            Username_txt.AutoSize = true;
            Username_txt.BackColor = Color.Transparent;
            Username_txt.Font = new Font("Bahnschrift", 8F, FontStyle.Bold, GraphicsUnit.Point);
            Username_txt.ForeColor = Color.FromArgb(255, 201, 134);
            Username_txt.ImeMode = ImeMode.NoControl;
            Username_txt.Location = new Point(222, 66);
            Username_txt.Name = "Username_txt";
            Username_txt.Size = new Size(84, 19);
            Username_txt.TabIndex = 13;
            Username_txt.Text = "Username";
            // 
            // Username
            // 
            Username.BackColor = Color.AntiqueWhite;
            Username.Cursor = Cursors.IBeam;
            Username.Font = new Font("Bahnschrift SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.FromArgb(0, 70, 60);
            Username.Location = new Point(222, 88);
            Username.Name = "Username";
            Username.Size = new Size(180, 32);
            Username.TabIndex = 12;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 70, 60);
            ClientSize = new Size(602, 380);
            Controls.Add(Username_txt);
            Controls.Add(Username);
            Controls.Add(Hint);
            Controls.Add(ResetPassButton);
            Controls.Add(CancelButton);
            Controls.Add(Instruction_txt);
            Controls.Add(label3);
            Controls.Add(Pass_conf_txt);
            Controls.Add(New_pass_txt);
            Controls.Add(SQuestion_txt);
            Controls.Add(New_pass_conf);
            Controls.Add(New_pass);
            Controls.Add(SQAnswer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            FormClosing += ResetPassword_FormClosing_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox SQAnswer;
        public TextBox New_pass;
        public TextBox New_pass_conf;
        private Label SQuestion_txt;
        private Label New_pass_txt;
        private Label Pass_conf_txt;
        private Label label3;
        private TextBox Instruction_txt;
        private Button CancelButton;
        private Button ResetPassButton;
        private Label Hint;
        private Label Username_txt;
        public TextBox Username;
    }
}