using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Digital_Shop_Software
{
    internal class Products
    {
        // Declaring variables
        public int error = 0;
        decimal sp_price;
        decimal s_price;
        int qty;
        int onOrder;
        int onOrderOty;
        int del_date;
        string supplier_id = "";
        public void LoadStock()
        {
            // Loading grid view with stock data
            SQLiteCommand command = new SQLiteCommand(
                "Select * From Product Inner Join Users on Users.UserId = Product.fk_UserId Inner Join Supplier on Supplier.SupplierId = fk_supplierId;"
                , Database.instance);
            using (SQLiteDataReader read = command.ExecuteReader())
            {
                 while (read.Read())
                {
                    Stock.stock.StockDataGrid.Rows.Add(new object[]
                       {
                            read.GetValue(0),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Category")),
                            read.GetValue(read.GetOrdinal("Description")),
                            read.GetValue(read.GetOrdinal("SupplierPrice")),
                            read.GetValue(read.GetOrdinal("SalePrice")),
                            read.GetValue(read.GetOrdinal("Qty")),
                            read.GetValue(read.GetOrdinal("OnOrder")),
                            read.GetValue(read.GetOrdinal("OnOrderQty")),
                            read.GetValue(read.GetOrdinal("DeliveryDate")),
                            read.GetValue(read.GetOrdinal("SupplierName")),
                            read.GetValue(read.GetOrdinal("Username"))
                       });
                }
            }
        }
        // Method that gets supplier id from database
        public string GetSupplier()
        {
            SQLiteCommand find_Supplier = new SQLiteCommand("Select SupplierId from Supplier where SupplierName = \"" + AddStock.addStock.sup_name.Text + "\";", Database.instance);
            using (SQLiteDataReader read = find_Supplier.ExecuteReader())
            {
                while (read.Read())
                {
                    supplier_id = read["SupplierId"].ToString();
                }
                return supplier_id;
            }
        }
        // Method that adds products into the database and refreshes grid view
        public void AddProducts()
        {
            User user = new User();
            SQLiteCommand command = new SQLiteCommand
                (
                "Insert into Product (Name, Category, Description, SupplierPrice, SalePrice, Qty, OnOrder,OnOrderQty , DeliveryDate, fk_SupplierId, fk_UserId)" +
                "Values(\"" +
                AddStock.addStock.p_name.Text + "\",\""+
                AddStock.addStock.category.Text + "\",\"" +
                AddStock.addStock.description.Text + "\"," +
                sp_price + "," +
                s_price + "," +
                qty + "," +
                onOrder + "," +
                onOrderOty + "," +
                del_date + "," +
                Convert.ToInt32(GetSupplier()) + "," +
                Convert.ToInt32(user.GetUserId()) +
                ");", Database.instance);
            command.ExecuteNonQuery();
            Stock.stock.StockDataGrid.Rows.Clear();
            LoadStock();
        }
        // Method that checks if all marked fields are completed
        public void CheckAddStock()
        {
            if (string.IsNullOrEmpty(AddStock.addStock.p_name.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
                error = 1;
            }
            else if (string.IsNullOrEmpty(AddStock.addStock.category.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
                error = 1;
            }
            else if (string.IsNullOrEmpty(AddStock.addStock.sup_name.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
                error = 1;
            }
            else if (string.IsNullOrEmpty(AddStock.addStock.sup_price.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
                error = 1;
            }
            else if (string.IsNullOrEmpty(AddStock.addStock.sale_price.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
                error = 1;
            }
            else if (string.IsNullOrEmpty(AddStock.addStock.qty.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
                error = 1;
            }
            else if (string.IsNullOrEmpty(AddStock.addStock.onOrder.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
                error = 1;
            }
            else if (string.IsNullOrEmpty(AddStock.addStock.onOrderQty.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
                error = 1;
            }
            else if (string.IsNullOrEmpty(AddStock.addStock.del_date.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
                error = 1;
            }
            else 
            {
                ConvertValues();
            }
        }
        // Method that converts strings into decimals and integers
        public void ConvertValues()
        {
            error = 0;
            try
            {
                sp_price = Convert.ToDecimal(AddStock.addStock.sup_price.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input on Supplier Price field!");
                AddStock.addStock.sup_price.Clear();
                error = 1;
            }
            try
            {
                s_price = Convert.ToDecimal(AddStock.addStock.sale_price.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input on Sale Price field!");
                AddStock.addStock.sale_price.Clear();
                error = 1;
            }
            try
            {
                qty = Convert.ToInt32(AddStock.addStock.qty.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input on Quantity field!");
                AddStock.addStock.qty.Clear();
                error = 1;
            }
            try
            {
                onOrder = Convert.ToInt32(AddStock.addStock.onOrder.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input on On Order field!");
                error = 1;
            }
            try
            {
                onOrderOty = Convert.ToInt32(AddStock.addStock.onOrderQty.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input on On Order Quantity field!");
                AddStock.addStock.onOrderQty.Clear();
                error = 1;
            }
            try
            {
                string date = AddStock.addStock.del_date.Value.ToShortDateString();
                date = date.Replace("/", "");
                del_date = Convert.ToInt32(date);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input on Delivery date field!");
                error = 1;
            }
        }
        // Method that removes products from the griview and database
        public void RemoveProduct()
        {
            if (Stock.stock.StockDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show("Are you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);
                if (dg_res == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in Stock.stock.StockDataGrid.SelectedRows)
                    {
                        int id = Convert.ToInt32(Stock.stock.StockDataGrid.SelectedRows[0].Cells[0].Value);
                        SQLiteCommand command = new SQLiteCommand("delete from product where productid = \"" + id + "\";", Database.instance);
                        Stock.stock.StockDataGrid.Rows.RemoveAt(Stock.stock.StockDataGrid.SelectedRows[0].Index);
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            { MessageBox.Show("Please select a row in order to delete it!"); }
        }
        // Method that alows modifying the grid view cells along with database rows
        public void ModifyStock()
        {
            User user = new User();
            if (Stock.stock.StockDataGrid.EditMode == DataGridViewEditMode.EditProgrammatically)
            {
                for (int item = 0; item <= Stock.stock.StockDataGrid.Rows.Count - 1; item++)
                {
                    SQLiteCommand command = new SQLiteCommand("Update product set " +
                        "Name = @name, " +
                        "category = @category, " +
                        "description = @description, " +
                        "supplierprice = @supplierprice, " +
                        "saleprice = @saleprice, " +
                        "qty = @qty, " +
                        "onOrder = @onOrder, " +
                        "onOrderQty = @OnOrderQty, " +
                        "deliverydate = @deliverydate, " +
                        "fk_Userid = @fk_userid where productid = @productid;", Database.instance);
                    command.Parameters.AddWithValue("@productid", Stock.stock.StockDataGrid.Rows[item].Cells[0].Value);
                    command.Parameters.AddWithValue("@name", Stock.stock.StockDataGrid.Rows[item].Cells[1].Value);
                    command.Parameters.AddWithValue("@category", Stock.stock.StockDataGrid.Rows[item].Cells[2].Value);
                    command.Parameters.AddWithValue("@description", Stock.stock.StockDataGrid.Rows[item].Cells[3].Value);
                    command.Parameters.AddWithValue("@supplierprice", Stock.stock.StockDataGrid.Rows[item].Cells[4].Value);
                    command.Parameters.AddWithValue("@saleprice", Stock.stock.StockDataGrid.Rows[item].Cells[5].Value);
                    command.Parameters.AddWithValue("@qty", Stock.stock.StockDataGrid.Rows[item].Cells[6].Value);
                    command.Parameters.AddWithValue("@onOrder", Stock.stock.StockDataGrid.Rows[item].Cells[7].Value);
                    command.Parameters.AddWithValue("@OnOrderQty", Stock.stock.StockDataGrid.Rows[item].Cells[8].Value);
                    command.Parameters.AddWithValue("@deliverydate", Stock.stock.StockDataGrid.Rows[item].Cells[9].Value);
                    command.Parameters.AddWithValue("@fk_userid", user.GetUserId());
                    command.ExecuteNonQuery();
                }
                Stock.stock.StockDataGrid.EndEdit();
                Stock.stock.StockDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
                MessageBox.Show("You've succesfully edited the cell!");
            }
            else { MessageBox.Show("Please double click on a cell in order to edit it!"); }
        }
    }
}
