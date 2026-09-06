using System.Data.SQLite;

namespace Digital_Shop_Software
{
    internal class Report
    {
        public void LoadSalesReport()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            // Method that load the sales report into grid view
            SQLiteCommand command = new SQLiteCommand(
                "SELECT *," +
                "(SUM(Orders.\"Total Orders\") * Product.SupplierPrice) as \"Net Cost\", " +
                "(SUM(Orders.\"Total Orders\") * Product.SalePrice) as Sale," +
                "((SUM(Orders.\"Total Orders\") * Product.SalePrice) - (SUM(Orders.\"Total Orders\") * Product.SupplierPrice)) as Profit " +
                "FROM Product LEFT JOIN " +
                "(SELECT fk_ProductId, SUM(OrderQty) as \"Total Orders\"FROM \"Client Orders\" GROUP BY fk_productid) " +
                "as Orders on Orders.fk_ProductId = Product.ProductId " +
                "WHERE Orders.\"Total Orders\" > 0 GROUP BY ProductId;",
                connection);

            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    Reports.reports.SalesReportDataGrid.Rows.Add(new object[]
                       {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Category")),
                            read.GetValue(read.GetOrdinal("Total Orders")),
                            read.GetValue(read.GetOrdinal("Net Cost")),
                            read.GetValue(read.GetOrdinal("Sale")),
                            read.GetValue(read.GetOrdinal("Profit"))
                       });
                }
            }
        }

        public void LoadTopReport()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            // Method that loads top 10 products into grid view
            SQLiteCommand command = new SQLiteCommand(
                "SELECT *," +
                "(SUM(Orders.\"Total Orders\") * Product.SupplierPrice) as \"Net Cost\", " +
                "(SUM(Orders.\"Total Orders\") * Product.SalePrice) as Sale," +
                "((SUM(Orders.\"Total Orders\") * Product.SalePrice) - (SUM(Orders.\"Total Orders\") * Product.SupplierPrice)) as Profit " +
                "FROM Product LEFT JOIN " +
                "(SELECT fk_ProductId, SUM(OrderQty) as \"Total Orders\"FROM \"Client Orders\" GROUP BY fk_productid) " +
                "as Orders on Orders.fk_ProductId = Product.ProductId " +
                "WHERE Orders.\"Total Orders\" > 0 GROUP BY ProductId ORDER BY SalePrice DESC LIMIT 10;",
                connection);
            
            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    Reports.reports.TopProdDataView.Rows.Add(new object[]
                       {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Category")),
                            read.GetValue(read.GetOrdinal("Total Orders")),
                            read.GetValue(read.GetOrdinal("Net Cost")),
                            read.GetValue(read.GetOrdinal("Sale")),
                            read.GetValue(read.GetOrdinal("Profit"))
                       });
                }
            }
        }

        // Method that loads bottom 10 products into grid view
        public void LoadButtomReport()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();
            
            SQLiteCommand command = new SQLiteCommand(
                "SELECT *," +
                "(SUM(Orders.\"Total Orders\") * Product.SupplierPrice) as \"Net Cost\", " +
                "(SUM(Orders.\"Total Orders\") * Product.SalePrice) as Sale," +
                "((SUM(Orders.\"Total Orders\") * Product.SalePrice) - (SUM(Orders.\"Total Orders\") * Product.SupplierPrice)) as Profit " +
                "FROM Product LEFT JOIN " +
                "(SELECT fk_ProductId, SUM(OrderQty) as \"Total Orders\"FROM \"Client Orders\" GROUP BY fk_productid) " +
                "as Orders on Orders.fk_ProductId = Product.ProductId " +
                "WHERE Orders.\"Total Orders\" > 0 GROUP BY ProductId ORDER BY SalePrice ASC LIMIT 10;",
                connection);

            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    Reports.reports.BottomProdDataView.Rows.Add(new object[]
                       {
                            read.GetValue(read.GetOrdinal("ProductId")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Category")),
                            read.GetValue(read.GetOrdinal("Total Orders")),
                            read.GetValue(read.GetOrdinal("Net Cost")),
                            read.GetValue(read.GetOrdinal("Sale")),
                            read.GetValue(read.GetOrdinal("Profit"))
                       });
                }
            }
        }
    }
}
