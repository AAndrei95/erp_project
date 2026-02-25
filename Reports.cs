using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Shop_Software
{
    public partial class Reports : Form
    {
        public static Reports reports;
        public Reports()
        {
            reports = this;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // Adding combobox items and loading the reports
            ReportSelection.Items.Add("Sales Report");
            ReportSelection.Items.Add("Top 10 vs Buttom 10");
            Database.GetInstance().Open();
            Report report = new Report();
            report.LoadSalesReport();
            report.LoadTopReport();
            report.LoadButtomReport();
            Database.GetInstance().Close();
            TopProdDataView.Size = new System.Drawing.Size(600, 435);
            BottomProdDataView.Size = new System.Drawing.Size(600, 435);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // Selecting the report
            Report report = new Report();
            if (ReportSelection.SelectedIndex == 0)
            {
                top_prod.Visible = false;
                buttom_prod.Visible = false;
                TopProdDataView.Visible = false;
                BottomProdDataView.Visible = false;

                SalesReportDataGrid.Visible = true;
                decimal qty = 0;
                decimal profit = 0;
                decimal cost = 0;
                decimal sales = 0;
                for (int i = 0; i < SalesReportDataGrid.Rows.Count; i++)
                {
                    qty += Convert.ToDecimal(SalesReportDataGrid.Rows[i].Cells[3].Value);
                    profit += Convert.ToDecimal(SalesReportDataGrid.Rows[i].Cells[6].Value);
                    cost += Convert.ToDecimal(SalesReportDataGrid.Rows[i].Cells[4].Value);
                    sales += Convert.ToDecimal(SalesReportDataGrid.Rows[i].Cells[5].Value);
                    Qty.Text = "Total Sold Quantity: " + qty.ToString();
                    Cost.Text = "Total Net Cost: " + cost.ToString();
                    Sales.Text = "Total Gross Sales: " + sales.ToString();
                    Profit.Text = "Total Profit: " + profit.ToString();
                    Qty.Visible = true;
                    Cost.Visible = true;
                    Sales.Visible = true;
                    Profit.Visible = true;
                }
            }
            else if (ReportSelection.SelectedIndex == 1)
            {
                SalesReportDataGrid.Visible = false;
                Qty.Visible = false;
                Cost.Visible = false;
                Sales.Visible = false;
                Profit.Visible = false;

                top_prod.Visible = true;
                buttom_prod.Visible = true;
                TopProdDataView.Visible = true;
                BottomProdDataView.Visible = true;
            }
        }
    }
}
