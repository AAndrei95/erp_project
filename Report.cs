using Digital_Shop_Software.Services;

namespace Digital_Shop_Software
{
    internal class Report
    {
        public void LoadSalesReport()
        {
            ProductService productService = new ProductService();

            List<Dictionary<string, object>> report = productService.GetSalesReport();

            foreach (Dictionary<string, object> row in report)
            {
                Reports.reports.SalesReportDataGrid.Rows.Add(new object[]
                {
                    row["ProductId"],
                    row["Name"],
                    row["Category"],
                    row["Total Orders"],
                    row["Net Cost"],
                    row["Sale"],
                    row["Profit"]
                });
            }
        }

        public void LoadTopReport()
        {
            ProductService productService = new ProductService();

            List<Dictionary<string, object>> report = productService.GetTopProductsReport();

            foreach (Dictionary<string, object> row in report)
            {
                Reports.reports.TopProdDataView.Rows.Add(new object[]
                {
                    row["ProductId"],
                    row["Name"],
                    row["Category"],
                    row["Total Orders"],
                    row["Net Cost"],
                    row["Sale"],
                    row["Profit"]
                });
            }
        }

        // Method that loads bottom 10 products into grid view
        public void LoadButtomReport()
        {
            ProductService productService = new ProductService();

            List<Dictionary<string, object>> report = productService.GetBottomProductsReport();

            foreach (Dictionary<string, object> row in report)
            {
                Reports.reports.BottomProdDataView.Rows.Add(new object[]
                {
                    row["ProductId"],
                    row["Name"],
                    row["Category"],
                    row["Total Orders"],
                    row["Net Cost"],
                    row["Sale"],
                    row["Profit"]
                });
            }
        }
    }
}
