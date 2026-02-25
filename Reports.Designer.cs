namespace Digital_Shop_Software
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            CloseButton = new Button();
            ReportSelection = new ComboBox();
            SalesReportDataGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            Qty = new Label();
            Cost = new Label();
            Sales = new Label();
            Profit = new Label();
            TopProdDataView = new DataGridView();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            BottomProdDataView = new DataGridView();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            top_prod = new Label();
            buttom_prod = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)SalesReportDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TopProdDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BottomProdDataView).BeginInit();
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
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ReportSelection
            // 
            ReportSelection.FormattingEnabled = true;
            resources.ApplyResources(ReportSelection, "ReportSelection");
            ReportSelection.Name = "ReportSelection";
            ReportSelection.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // SalesReportDataGrid
            // 
            SalesReportDataGrid.AllowUserToAddRows = false;
            SalesReportDataGrid.AllowUserToDeleteRows = false;
            resources.ApplyResources(SalesReportDataGrid, "SalesReportDataGrid");
            SalesReportDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalesReportDataGrid.BackgroundColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SalesReportDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SalesReportDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalesReportDataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 70, 60);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            SalesReportDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            SalesReportDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            SalesReportDataGrid.EnableHeadersVisualStyles = false;
            SalesReportDataGrid.GridColor = Color.FromArgb(0, 70, 60);
            SalesReportDataGrid.Name = "SalesReportDataGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SalesReportDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(153, 184, 147);
            SalesReportDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            SalesReportDataGrid.RowTemplate.Height = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Qty
            // 
            resources.ApplyResources(Qty, "Qty");
            Qty.ForeColor = Color.FromArgb(0, 60, 70);
            Qty.Name = "Qty";
            // 
            // Cost
            // 
            resources.ApplyResources(Cost, "Cost");
            Cost.ForeColor = Color.FromArgb(0, 60, 70);
            Cost.Name = "Cost";
            // 
            // Sales
            // 
            resources.ApplyResources(Sales, "Sales");
            Sales.ForeColor = Color.FromArgb(0, 60, 70);
            Sales.Name = "Sales";
            // 
            // Profit
            // 
            resources.ApplyResources(Profit, "Profit");
            Profit.ForeColor = Color.FromArgb(0, 60, 70);
            Profit.Name = "Profit";
            // 
            // TopProdDataView
            // 
            TopProdDataView.AllowUserToAddRows = false;
            TopProdDataView.AllowUserToDeleteRows = false;
            resources.ApplyResources(TopProdDataView, "TopProdDataView");
            TopProdDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TopProdDataView.BackgroundColor = Color.AntiqueWhite;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            TopProdDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            TopProdDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TopProdDataView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(0, 70, 60);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            TopProdDataView.DefaultCellStyle = dataGridViewCellStyle6;
            TopProdDataView.EditMode = DataGridViewEditMode.EditProgrammatically;
            TopProdDataView.EnableHeadersVisualStyles = false;
            TopProdDataView.GridColor = Color.FromArgb(0, 70, 60);
            TopProdDataView.Name = "TopProdDataView";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            TopProdDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(153, 184, 147);
            TopProdDataView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            TopProdDataView.RowTemplate.Height = 33;
            // 
            // dataGridViewTextBoxColumn8
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn9
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn11, "dataGridViewTextBoxColumn11");
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn12, "dataGridViewTextBoxColumn12");
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn13, "dataGridViewTextBoxColumn13");
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn14, "dataGridViewTextBoxColumn14");
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // BottomProdDataView
            // 
            BottomProdDataView.AllowUserToAddRows = false;
            BottomProdDataView.AllowUserToDeleteRows = false;
            resources.ApplyResources(BottomProdDataView, "BottomProdDataView");
            BottomProdDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BottomProdDataView.BackgroundColor = Color.AntiqueWhite;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            BottomProdDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            BottomProdDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BottomProdDataView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn20, dataGridViewTextBoxColumn21 });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.AntiqueWhite;
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(0, 70, 60);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            BottomProdDataView.DefaultCellStyle = dataGridViewCellStyle10;
            BottomProdDataView.EditMode = DataGridViewEditMode.EditProgrammatically;
            BottomProdDataView.EnableHeadersVisualStyles = false;
            BottomProdDataView.GridColor = Color.FromArgb(0, 70, 60);
            BottomProdDataView.Name = "BottomProdDataView";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 201, 134);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            BottomProdDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(153, 184, 147);
            BottomProdDataView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            BottomProdDataView.RowTemplate.Height = 33;
            // 
            // dataGridViewTextBoxColumn15
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn15, "dataGridViewTextBoxColumn15");
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn16
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn16, "dataGridViewTextBoxColumn16");
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn17, "dataGridViewTextBoxColumn17");
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn18, "dataGridViewTextBoxColumn18");
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn19, "dataGridViewTextBoxColumn19");
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn20, "dataGridViewTextBoxColumn20");
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            resources.ApplyResources(dataGridViewTextBoxColumn21, "dataGridViewTextBoxColumn21");
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // top_prod
            // 
            resources.ApplyResources(top_prod, "top_prod");
            top_prod.ForeColor = Color.FromArgb(0, 60, 70);
            top_prod.Name = "top_prod";
            // 
            // buttom_prod
            // 
            resources.ApplyResources(buttom_prod, "buttom_prod");
            buttom_prod.ForeColor = Color.FromArgb(192, 0, 0);
            buttom_prod.Name = "buttom_prod";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(0, 60, 70);
            label1.Image = Properties.Resources.icons8_arrow_16;
            label1.Name = "label1";
            // 
            // Reports
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(label1);
            Controls.Add(buttom_prod);
            Controls.Add(top_prod);
            Controls.Add(BottomProdDataView);
            Controls.Add(TopProdDataView);
            Controls.Add(Profit);
            Controls.Add(Sales);
            Controls.Add(Cost);
            Controls.Add(Qty);
            Controls.Add(SalesReportDataGrid);
            Controls.Add(ReportSelection);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)SalesReportDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)TopProdDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)BottomProdDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CloseButton;
        private ComboBox ReportSelection;
        public DataGridView SalesReportDataGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        public Label Qty;
        public Label Cost;
        public Label Sales;
        public Label Profit;
        public DataGridView TopProdDataView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        public DataGridView BottomProdDataView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private Label top_prod;
        private Label buttom_prod;
        private Label label1;
    }
}