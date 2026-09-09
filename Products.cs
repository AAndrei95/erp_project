using Digital_Shop_Software.Repositories;

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
            ProductRepository productRepository = new ProductRepository();

            List<Dictionary<string, object>> products = productRepository.GetProducts();

            // Loading grid view with stock data
            foreach (Dictionary<string, object> product in products)
            {
                Stock.stock.StockDataGrid.Rows.Add(new object[]
                {
                    product["ProductId"],
                    product["Name"],
                    product["Category"],
                    product["Description"],
                    product["SupplierPrice"],
                    product["SalePrice"],
                    product["Qty"],
                    product["OnOrder"],
                    product["OnOrderQty"],
                    product["DeliveryDate"],
                    product["SupplierName"],
                    product["Username"]
                });
            }
        }

        // Method that gets supplier id from database
        public string GetSupplier()
        {
            ProductRepository productRepository = new ProductRepository();

            int supplierId = productRepository.GetSupplierId(AddStock.addStock.sup_name.Text);

            return supplier_id.ToString();
        }

        // Method that adds products into the database and refreshes grid view
        public void AddProducts()
        {
            UserRepository userRepository = new UserRepository();
            ProductRepository productRepository = new ProductRepository();

            int supplierId = productRepository.GetSupplierId(AddStock.addStock.sup_name.Text);
            int userId = userRepository.GetUserId(Login.login.Username.Text);

            productRepository.AddProduct(
                AddStock.addStock.p_name.Text,
                AddStock.addStock.category.Text,
                AddStock.addStock.description.Text,
                sp_price,
                s_price,
                qty,
                onOrder,
                onOrderOty,
                del_date,
                supplierId,
                userId);

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
            ProductRepository productRepository = new ProductRepository();

            if (Stock.stock.StockDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show(
                    "Are you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);

                if (dg_res == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in Stock.stock.StockDataGrid.SelectedRows)
                    {
                        int productId = Convert.ToInt32(item.Cells[0].Value);

                        productRepository.RemoveProduct(productId);

                        Stock.stock.StockDataGrid.Rows.Remove(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row in order to delete it!");
            }
        }

        // Method that alows modifying the grid view cells along with database rows
        public void ModifyStock()
        {
            UserRepository userRepository = new UserRepository();
            ProductRepository productRepository = new ProductRepository();

            Stock.stock.StockDataGrid.EndEdit();

            int userId = userRepository.GetUserId( Login.login.Username.Text);

            for (int item = 0; item < Stock.stock.StockDataGrid.Rows.Count; item++)
            {
                int productId = Convert.ToInt32(Stock.stock.StockDataGrid.Rows[item].Cells[0].Value);
                string name = Stock.stock.StockDataGrid.Rows[item].Cells[1].Value?.ToString() ?? "";
                string category = Stock.stock.StockDataGrid.Rows[item].Cells[2].Value?.ToString() ?? "";
                string description = Stock.stock.StockDataGrid.Rows[item].Cells[3].Value?.ToString() ?? "";
                decimal supplierPrice = Convert.ToDecimal(Stock.stock.StockDataGrid.Rows[item].Cells[4].Value);
                decimal salePrice = Convert.ToDecimal(Stock.stock.StockDataGrid.Rows[item].Cells[5].Value);
                int qty = Convert.ToInt32(Stock.stock.StockDataGrid.Rows[item].Cells[6].Value);
                int onOrder = Convert.ToInt32(Stock.stock.StockDataGrid.Rows[item].Cells[7].Value);
                int onOrderQty = Convert.ToInt32(Stock.stock.StockDataGrid.Rows[item].Cells[8].Value);
                int deliveryDate = Convert.ToInt32(Stock.stock.StockDataGrid.Rows[item].Cells[9].Value);

                productRepository.ModifyProduct(
                    productId,
                    name,
                    category,
                    description,
                    supplierPrice,
                    salePrice,
                    qty,
                    onOrder,
                    onOrderQty,
                    deliveryDate,
                    userId);
            }
            Stock.stock.StockDataGrid.EditMode = DataGridViewEditMode.EditOnF2;

            MessageBox.Show("You've succesfully edited the cell!");
        }
    }
}
