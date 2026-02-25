namespace Digital_Shop_Software
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            CloseButton = new Button();
            comboBox1 = new ComboBox();
            ClientOrderDataGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            PurchaseOrdersDataGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ClientOrderDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseOrdersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Red;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 70, 60);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.ImeMode = ImeMode.NoControl;
            button2.Location = new Point(334, 565);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 20;
            button2.Text = "Modify";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += ModifyOrder_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 70, 60);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(452, 565);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 19;
            button1.Text = "Remove";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += RemoveOrder_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.Red;
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 70, 60);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(216, 565);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 18;
            button3.Text = "Add";
            button3.TextAlign = ContentAlignment.TopLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += AddOrder_Click;
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
            CloseButton.TabIndex = 17;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // ClientOrderDataGrid
            // 
            ClientOrderDataGrid.AllowUserToAddRows = false;
            ClientOrderDataGrid.AllowUserToDeleteRows = false;
            ClientOrderDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClientOrderDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClientOrderDataGrid.BackgroundColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ClientOrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ClientOrderDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientOrderDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6, Column7, Column5, Column3, Column8, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 70, 60);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ClientOrderDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            ClientOrderDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
            ClientOrderDataGrid.EnableHeadersVisualStyles = false;
            ClientOrderDataGrid.GridColor = Color.FromArgb(0, 70, 60);
            ClientOrderDataGrid.ImeMode = ImeMode.NoControl;
            ClientOrderDataGrid.Location = new Point(12, 51);
            ClientOrderDataGrid.Name = "ClientOrderDataGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ClientOrderDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ClientOrderDataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(153, 184, 147);
            ClientOrderDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            ClientOrderDataGrid.RowTemplate.Height = 33;
            ClientOrderDataGrid.Size = new Size(552, 508);
            ClientOrderDataGrid.TabIndex = 36;
            ClientOrderDataGrid.Visible = false;
            ClientOrderDataGrid.CellContentDoubleClick += ClientOrderDataGrid_CellContentDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "OrderId";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column2
            // 
            Column2.HeaderText = "ClientId";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column6
            // 
            Column6.HeaderText = "Email";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "PhoneNumber";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // Column5
            // 
            Column5.HeaderText = "ProductName";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column3
            // 
            Column3.HeaderText = "OrderQty";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column8
            // 
            Column8.HeaderText = "Value";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            // 
            // Column4
            // 
            Column4.HeaderText = "Registered";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // PurchaseOrdersDataGrid
            // 
            PurchaseOrdersDataGrid.AllowUserToAddRows = false;
            PurchaseOrdersDataGrid.AllowUserToDeleteRows = false;
            PurchaseOrdersDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PurchaseOrdersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PurchaseOrdersDataGrid.BackgroundColor = Color.AntiqueWhite;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            PurchaseOrdersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            PurchaseOrdersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PurchaseOrdersDataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column9, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 70, 60);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            PurchaseOrdersDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            PurchaseOrdersDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
            PurchaseOrdersDataGrid.EnableHeadersVisualStyles = false;
            PurchaseOrdersDataGrid.GridColor = Color.FromArgb(0, 70, 60);
            PurchaseOrdersDataGrid.ImeMode = ImeMode.NoControl;
            PurchaseOrdersDataGrid.Location = new Point(12, 51);
            PurchaseOrdersDataGrid.Name = "PurchaseOrdersDataGrid";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            PurchaseOrdersDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            PurchaseOrdersDataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(153, 184, 147);
            PurchaseOrdersDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            PurchaseOrdersDataGrid.RowTemplate.Height = 33;
            PurchaseOrdersDataGrid.Size = new Size(552, 508);
            PurchaseOrdersDataGrid.TabIndex = 37;
            PurchaseOrdersDataGrid.Visible = false;
            PurchaseOrdersDataGrid.CellContentDoubleClick += PurchaseOrdersDataGrid_CellContentDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "POId";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            // 
            // Column9
            // 
            Column9.HeaderText = "PONumber";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "PODate";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "ProductName";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Qty";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "SupplierPrice";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "POValue";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "TBDDate";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 60, 70);
            label1.Image = Properties.Resources.icons8_arrow_16;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(195, 17);
            label1.Name = "label1";
            label1.Size = new Size(235, 25);
            label1.TabIndex = 39;
            label1.Text = "   Please select order type!";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(576, 611);
            Controls.Add(label1);
            Controls.Add(PurchaseOrdersDataGrid);
            Controls.Add(ClientOrderDataGrid);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)ClientOrderDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)PurchaseOrdersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private Button CloseButton;
        private ComboBox comboBox1;
        public DataGridView ClientOrderDataGrid;
        public DataGridView PurchaseOrdersDataGrid;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}