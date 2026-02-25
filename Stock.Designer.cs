namespace Digital_Shop_Software
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            CloseButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            StockDataGrid = new DataGridView();
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
            SupplierName = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)StockDataGrid).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            resources.ApplyResources(CloseButton, "CloseButton");
            CloseButton.BackColor = Color.White;
            CloseButton.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 60);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Red;
            CloseButton.ForeColor = Color.FromArgb(0, 70, 60);
            CloseButton.Name = "CloseButton";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.ForeColor = Color.FromArgb(0, 70, 60);
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Remove_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Red;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.ForeColor = Color.FromArgb(0, 70, 60);
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Modify_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.Red;
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.ForeColor = Color.FromArgb(0, 70, 60);
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Add_Click;
            // 
            // StockDataGrid
            // 
            StockDataGrid.AllowUserToAddRows = false;
            StockDataGrid.AllowUserToDeleteRows = false;
            resources.ApplyResources(StockDataGrid, "StockDataGrid");
            StockDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StockDataGrid.BackgroundColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            StockDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            StockDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StockDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, SupplierName, Column11 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 70, 60);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            StockDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            StockDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
            StockDataGrid.EnableHeadersVisualStyles = false;
            StockDataGrid.GridColor = Color.FromArgb(0, 70, 60);
            StockDataGrid.Name = "StockDataGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            StockDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(153, 184, 147);
            StockDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            StockDataGrid.RowTemplate.Height = 33;
            StockDataGrid.CellContentDoubleClick += StockDataGrid_CellContentDoubleClick;
            // 
            // Column1
            // 
            resources.ApplyResources(Column1, "Column1");
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column2
            // 
            resources.ApplyResources(Column2, "Column2");
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            resources.ApplyResources(Column3, "Column3");
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            resources.ApplyResources(Column4, "Column4");
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            resources.ApplyResources(Column5, "Column5");
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            resources.ApplyResources(Column6, "Column6");
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            resources.ApplyResources(Column7, "Column7");
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            resources.ApplyResources(Column8, "Column8");
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            resources.ApplyResources(Column9, "Column9");
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            resources.ApplyResources(Column10, "Column10");
            Column10.Name = "Column10";
            // 
            // SupplierName
            // 
            resources.ApplyResources(SupplierName, "SupplierName");
            SupplierName.Name = "SupplierName";
            // 
            // Column11
            // 
            resources.ApplyResources(Column11, "Column11");
            Column11.Name = "Column11";
            // 
            // Stock
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(StockDataGrid);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CloseButton);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stock";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)StockDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private Button button1;
        private Button button2;
        private Button button3;
        public DataGridView StockDataGrid;
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
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Column11;
    }
}
