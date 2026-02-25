using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Shop_Software
{
    internal class Report
    {
        public void LoadSalesReport()
        {
            // Method that load the sales report into grid view
            SQLiteCommand command = new SQLiteCommand(
        "Select *," +
        "(Sum(Orders.\"Total Orders\") * Product.SupplierPrice) as \"Net Cost\", " +
        "(Sum(Orders.\"Total Orders\") * Product.SalePrice) as Sale," +
        "((Sum(Orders.\"Total Orders\") * Product.SalePrice) - (Sum(Orders.\"Total Orders\") * Product.SupplierPrice)) as Profit " +
        "from Product Left Join " +
        "(Select fk_ProductId, Sum(OrderQty) as \"Total Orders\"from \"Client Orders\" Group by fk_productid) " +
        "as Orders on Orders.fk_ProductId = Product.ProductId " +
        "Where Orders.\"Total Orders\" > 0 Group by ProductId;"
        , Database.instance);
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
            // Method that loads top 10 products into grid view
            SQLiteCommand command = new SQLiteCommand(
        "Select *," +
        "(Sum(Orders.\"Total Orders\") * Product.SupplierPrice) as \"Net Cost\", " +
        "(Sum(Orders.\"Total Orders\") * Product.SalePrice) as Sale," +
        "((Sum(Orders.\"Total Orders\") * Product.SalePrice) - (Sum(Orders.\"Total Orders\") * Product.SupplierPrice)) as Profit " +
        "from Product Left Join " +
        "(Select fk_ProductId, Sum(OrderQty) as \"Total Orders\"from \"Client Orders\" Group by fk_productid) " +
        "as Orders on Orders.fk_ProductId = Product.ProductId " +
        "Where Orders.\"Total Orders\" > 0 Group by ProductId Order by SalePrice DESC limit 10;"
        , Database.instance);
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
            SQLiteCommand command = new SQLiteCommand(
        "Select *," +
        "(Sum(Orders.\"Total Orders\") * Product.SupplierPrice) as \"Net Cost\", " +
        "(Sum(Orders.\"Total Orders\") * Product.SalePrice) as Sale," +
        "((Sum(Orders.\"Total Orders\") * Product.SalePrice) - (Sum(Orders.\"Total Orders\") * Product.SupplierPrice)) as Profit " +
        "from Product Left Join " +
        "(Select fk_ProductId, Sum(OrderQty) as \"Total Orders\"from \"Client Orders\" Group by fk_productid) " +
        "as Orders on Orders.fk_ProductId = Product.ProductId " +
        "Where Orders.\"Total Orders\" > 0 Group by ProductId Order by SalePrice ASC limit 10;"
        , Database.instance);
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
