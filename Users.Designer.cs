namespace Digital_Shop_Software
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            CloseButton = new Button();
            UsersDataGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)UsersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderColor = Color.Red;
            button7.FlatAppearance.MouseOverBackColor = Color.Red;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(0, 70, 60);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.ImeMode = ImeMode.NoControl;
            button7.Location = new Point(334, 565);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 32;
            button7.Text = "Modify";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderColor = Color.Red;
            button6.FlatAppearance.MouseOverBackColor = Color.Red;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(0, 70, 60);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.ImeMode = ImeMode.NoControl;
            button6.Location = new Point(452, 565);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 31;
            button6.Text = "Remove";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += RemoveUser_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.Red;
            button5.FlatAppearance.MouseOverBackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 70, 60);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.ImeMode = ImeMode.NoControl;
            button5.Location = new Point(216, 565);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 30;
            button5.Text = "Add";
            button5.TextAlign = ContentAlignment.TopLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += addValues_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CloseButton.BackColor = Color.White;
            CloseButton.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 60);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Red;
            CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.FromArgb(0, 70, 60);
            CloseButton.ImeMode = ImeMode.NoControl;
            CloseButton.Location = new Point(12, 565);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(112, 34);
            CloseButton.TabIndex = 29;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // UsersDataGrid
            // 
            UsersDataGrid.AllowUserToAddRows = false;
            UsersDataGrid.AllowUserToDeleteRows = false;
            UsersDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersDataGrid.BackgroundColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UsersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UsersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 70, 60);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UsersDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            UsersDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
            UsersDataGrid.EnableHeadersVisualStyles = false;
            UsersDataGrid.GridColor = Color.FromArgb(0, 70, 60);
            UsersDataGrid.ImeMode = ImeMode.NoControl;
            UsersDataGrid.Location = new Point(12, 12);
            UsersDataGrid.Name = "UsersDataGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            UsersDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            UsersDataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(153, 184, 147);
            UsersDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            UsersDataGrid.RowTemplate.Height = 33;
            UsersDataGrid.Size = new Size(552, 547);
            UsersDataGrid.TabIndex = 33;
            UsersDataGrid.CellContentDoubleClick += UsersDataGrid_CellContentDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "EmpNr";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column2
            // 
            Column2.HeaderText = "Position";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "User";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Password";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "DoB";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Sex";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "PhoneNr";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "SQuestion";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "SQAnswer";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(576, 611);
            Controls.Add(UsersDataGrid);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)UsersDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Button button6;
        private Button button5;
        private Button CloseButton;
        public DataGridView UsersDataGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}