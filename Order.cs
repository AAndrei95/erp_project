using System.Data.SQLite;

namespace Digital_Shop_Software
{
    internal class Order
    {
        public void LoadClientOrders()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            // Loads client orders into grid view
            SQLiteCommand command = new SQLiteCommand(
                "SELECT * FROM \"Client Orders\" " +
                "INNER JOIN Client ON Client.ClientId = \"Client Orders\".fk_ClientId " +
                "INNER JOIN Product ON Product.ProductId = \"Client Orders\".fk_ProductId;",
                connection);
                
            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    Orders.orders.ClientOrderDataGrid.Rows.Add(new object[]
                       {
                            read.GetValue(0),
                            read.GetValue(read.GetOrdinal("ClientId")),
                            read.GetValue(read.GetOrdinal("Email")),
                            read.GetValue(read.GetOrdinal("PhoneNumber")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("OrderQty")),
                            read.GetValue(read.GetOrdinal("Value")),
                            read.GetValue(read.GetOrdinal("Registered"))
                       });
                }
            }
        }

        public void LoadPurchaseOrders()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            // Loads purchase orders into grid view
            SQLiteCommand command = new SQLiteCommand(
                "SELECT * FROM \"Purchase Orders\" INNER JOIN Product ON Product.ProductId = \"Purchase Orders\".fk_ProductId;",
                connection);

            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    Orders.orders.PurchaseOrdersDataGrid.Rows.Add(new object[]
                       {
                            read.GetValue(0),
                            read.GetValue(read.GetOrdinal("PONumber")),
                            read.GetValue(read.GetOrdinal("PODate")),
                            read.GetValue(read.GetOrdinal("Name")),
                            read.GetValue(read.GetOrdinal("Qty")),
                            read.GetValue(read.GetOrdinal("SupplierPrice")),
                            read.GetValue(read.GetOrdinal("POValue")),
                            read.GetValue(read.GetOrdinal("TBDDate"))
                       });
                }
            }
        }

        public void AddCustomerOrder()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            // Add customer order in database and gridview
            Customer customer = new Customer();

            SQLiteCommand command = new SQLiteCommand(
                "INSERT INTO \"Client Orders\" " +
                "(OrderQty, fk_clientId, fk_productId, Value) " +
                "VALUES (@orderQty, @clientId, @productId, @value);",
                connection);

            command.Parameters.AddWithValue("@orderQty", Convert.ToInt32(AddClientOrder.addClientOrder.qty.Text));
            command.Parameters.AddWithValue("@clientId", Convert.ToInt32(AddClientOrder.addClientOrder.clientid.Text));
            command.Parameters.AddWithValue("@productId", Convert.ToInt32(AddClientOrder.addClientOrder.p_code.Text));
            command.Parameters.AddWithValue("@value", Convert.ToDecimal(AddClientOrder.addClientOrder.o_val.Text));
               
            command.ExecuteNonQuery();

            SQLiteCommand cmd = new SQLiteCommand(
                "UPDATE Client SET LastOrder = @lastOrder WHERE ClientId = @clientId;",
                connection);

            cmd.Parameters.AddWithValue(
                "@lastOrder",
                Convert.ToInt32(
                    AddClientOrder.addClientOrder.order_date.Value
                        .ToShortDateString()
                        .Replace("/", "")));
            cmd.Parameters.AddWithValue("@clientId", Convert.ToInt32(AddClientOrder.addClientOrder.clientid.Text));

            cmd.ExecuteNonQuery();

            SQLiteCommand cmd2 = new SQLiteCommand(
                "UPDATE Product SET Qty = @qty WHERE ProductId = @productId;",
                connection);

            cmd2.Parameters.AddWithValue("@qty", AddClientOrder.addClientOrder.sold_qty);                           
            cmd2.Parameters.AddWithValue("@productId", Convert.ToInt32(AddClientOrder.addClientOrder.p_code.Text));    

            cmd2.ExecuteNonQuery();
            
            MessageBox.Show("You've succesfully added a new Order into the client order list!");
            Orders.orders.ClientOrderDataGrid.Rows.Clear();
            LoadClientOrders();
            AddClientOrder.addClientOrder.Close();
        }

        public void CheckClientOrders()
        {
            if (string.IsNullOrEmpty(AddClientOrder.addClientOrder.p_code.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else if (string.IsNullOrEmpty(AddClientOrder.addClientOrder.qty.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else { AddCustomerOrder(); }
        }

        public void RemoveCustomerOrder()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            // If minimum a row is selected
            if (Orders.orders.ClientOrderDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show("Please be aware that if you delete a row in this table the product stock won't change.\nAre you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);
                if (dg_res == DialogResult.Yes)
                {
                    // For each row selected in the datagrid delete the matching row in the database
                    foreach (DataGridViewRow item in Orders.orders.ClientOrderDataGrid.SelectedRows)
                    {
                        int id = Convert.ToInt32(Orders.orders.ClientOrderDataGrid.SelectedRows[0].Cells[0].Value);

                        SQLiteCommand command = new SQLiteCommand(
                            "DELETE FROM \"Client Orders\" WHERE id = @id;",
                            connection);

                        command.Parameters.AddWithValue("@id", id);

                        Orders.orders.ClientOrderDataGrid.Rows.RemoveAt(Orders.orders.ClientOrderDataGrid.SelectedRows[0].Index);

                        command.ExecuteNonQuery();
                    }
                }
            }
            // If no row is selected
            else
            { MessageBox.Show("Please select a row in order to delete it!"); }
        }

        public void ModifyCustomerOrder()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            User user = new User();
            if (Orders.orders.ClientOrderDataGrid.EditMode == DataGridViewEditMode.EditProgrammatically)
            {
                DialogResult dg_res = MessageBox.Show("Please be aware that if you modify a cell in this table the product stock won't change as well as the value of the order.\nAre you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);
                if (dg_res == DialogResult.Yes)
                {
                    for (int item = 0; item <= Orders.orders.ClientOrderDataGrid.Rows.Count - 1; item++)
                    {
                        SQLiteCommand command = new SQLiteCommand(
                            "UPDATE \"Client Orders\" SET " +
                            "orderQty = @orderQty, " +
                            "clientId = @clientId, " +
                            "value = @value " +
                            "WHERE id = @id;",
                            connection);

                        command.Parameters.AddWithValue( "@id", Orders.orders.ClientOrderDataGrid.Rows[item].Cells[0].Value);                         
                        command.Parameters.AddWithValue("@orderQty", Orders.orders.ClientOrderDataGrid.Rows[item].Cells[5].Value);                           
                        command.Parameters.AddWithValue("@clientId", Orders.orders.ClientOrderDataGrid.Rows[item].Cells[1].Value);                     
                        command.Parameters.AddWithValue("@Value", Orders.orders.ClientOrderDataGrid.Rows[item].Cells[6].Value);
                                                        
                        command.ExecuteNonQuery();
                    }
                    Orders.orders.ClientOrderDataGrid.EndEdit();
                    Orders.orders.ClientOrderDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
                    MessageBox.Show("You've succesfully edited the cell!");
                }
            }
            else { MessageBox.Show("Please double click on a cell in order to edit it!"); }
        }

        public void AddPurchaseOrders()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            // Add purchase order in database and gridview
            //Customer customer = new Customer();
           SQLiteCommand command = new SQLiteCommand(
                "INSERT INTO \"Purchase Orders\" " +
                "(PONumber, PODate, qty, POValue, fk_productid, TBDDate) " +
                "VALUES (@poNumber, @poDate, @qty, @poValue, @productId, @tbdDate);",
                connection);

            command.Parameters.AddWithValue("@poNumber", GetPONumber());
            command.Parameters.AddWithValue(
                "@poDate",
                Convert.ToInt32(
                    AddPurchaseOrder.addPurchaseOrder.po_date.Value
                        .ToShortDateString()
                        .Replace("/", "")));
            command.Parameters.AddWithValue("@qty", Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.qty.Text));   
            command.Parameters.AddWithValue("@poValue", Convert.ToDecimal(AddPurchaseOrder.addPurchaseOrder.o_val.Text));              
            command.Parameters.AddWithValue("@productId", Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.p_code.Text));            
            command.Parameters.AddWithValue(
                "@tbdDate",
                Convert.ToInt32(
                    AddPurchaseOrder.addPurchaseOrder.del_date.Value
                        .ToShortDateString()
                        .Replace("/", "")));

            command.ExecuteNonQuery();

            SQLiteCommand cmd2 = new SQLiteCommand(
                "UPDATE Product SET " +
                "Qty = @qty, " +
                "OnOrder = @onOrder, " +
                "OnOrderQty = @onOrderQty, " +
                "DeliveryDate = @deliveryDate " +
                "WHERE ProductId = @productId;",
                connection);

            cmd2.Parameters.AddWithValue( "@qty",  AddPurchaseOrder.addPurchaseOrder.new_stock);
            cmd2.Parameters.AddWithValue("@onOrder", 1);  
            cmd2.Parameters.AddWithValue( "@onOrderQty", Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.qty.Text));   
            cmd2.Parameters.AddWithValue(
                "@deliveryDate",
                Convert.ToInt32(
                    AddPurchaseOrder.addPurchaseOrder.del_date.Value
                        .ToShortDateString()
                        .Replace("/", "")));
            cmd2.Parameters.AddWithValue("@productId", Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.p_code.Text));

            cmd2.ExecuteNonQuery();

            MessageBox.Show("You've succesfully placed a supplier order!");
            Orders.orders.PurchaseOrdersDataGrid.Rows.Clear();
            LoadPurchaseOrders();
            AddPurchaseOrder.addPurchaseOrder.Close();
        }

        public void CheckPurchaseOrders()
        {
            if (string.IsNullOrEmpty(AddPurchaseOrder.addPurchaseOrder.p_code.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else if (string.IsNullOrEmpty(AddPurchaseOrder.addPurchaseOrder.qty.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else { AddPurchaseOrders(); }
        }

        public int GetPONumber()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            int PONumber = 0;

            SQLiteCommand command = new SQLiteCommand(
                "SELECT * FROM \"Purchase Orders\" ORDER BY PoNumber DESC LIMIT 1;",
                connection);

            using(SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    PONumber = Convert.ToInt32(read.GetValue(read.GetOrdinal("PONumber")));
                }
                return PONumber + 1;
            }
        }

        public void RemovePurchaseOrder()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            // If minimum a row is selected
            if (Orders.orders.PurchaseOrdersDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show("Please be aware that if you delete a row in this table the product stock won't change.\nAre you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);
                if (dg_res == DialogResult.Yes)
                {
                    // For each row selected in the datagrid delete the matching row in the database
                    foreach (DataGridViewRow item in Orders.orders.PurchaseOrdersDataGrid.SelectedRows)
                    {
                        int id = Convert.ToInt32(Orders.orders.PurchaseOrdersDataGrid.SelectedRows[0].Cells[0].Value);
                        
                        SQLiteCommand command = new SQLiteCommand(
                            "DELETE FROM \"Purchase Orders\" WHERE POid = @poId;",
                            connection);

                        command.Parameters.AddWithValue("@poId", id);

                        Orders.orders.PurchaseOrdersDataGrid.Rows.RemoveAt(Orders.orders.PurchaseOrdersDataGrid.SelectedRows[0].Index);
                        
                        command.ExecuteNonQuery();
                    }
                }
            }
            // If no row is selected
            else
            { MessageBox.Show("Please select a row in order to delete it!"); }
        }
        public void ModifyPurchaseOrder()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            User user = new User();
            if (Orders.orders.PurchaseOrdersDataGrid.EditMode == DataGridViewEditMode.EditProgrammatically)
            {
                DialogResult dg_res = MessageBox.Show("Please be aware that if you modify a cell in this table the product stock won't change as well as the value of the order.\nAre you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);
                if (dg_res == DialogResult.Yes)
                {
                    for (int item = 0; item <= Orders.orders.PurchaseOrdersDataGrid.Rows.Count - 1; item++)
                    {
                        SQLiteCommand command = new SQLiteCommand(
                            "UPDATE \"Purchase Orders\" SET " +
                            "podate = @poDate, " +
                            "qty = @qty, " +
                            "POValue = @poValue, " +
                            "TBDDate = @tbdDate " +
                            "WHERE poid = @poId;",
                            connection);
                            
                        command.Parameters.AddWithValue("@poId", Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[0].Value); 
                        command.Parameters.AddWithValue("@poDate", Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[2].Value);   
                        command.Parameters.AddWithValue("@qty", Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[4].Value);   
                        command.Parameters.AddWithValue("@poValue", Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[6].Value);  
                        command.Parameters.AddWithValue("@tbdDate", Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[7].Value);
  
                        command.ExecuteNonQuery();
                    }
                    Orders.orders.PurchaseOrdersDataGrid.EndEdit();
                    Orders.orders.PurchaseOrdersDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
                    MessageBox.Show("You've succesfully edited the cell!");
                }
            }
            else { MessageBox.Show("Please double click on a cell in order to edit it!"); }
        }
    }
}
