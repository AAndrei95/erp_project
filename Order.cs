using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Digital_Shop_Software
{
    internal class Order
    {
        public void LoadClientOrders()
        {
            // Loads client orders into grid view
            SQLiteCommand command = new SQLiteCommand(
                "Select * From \"Client Orders\" Inner Join Client on Client.ClientId = \"Client Orders\".fk_ClientId Inner Join Product on Product.ProductId = \"Client Orders\".fk_ProductId;"
                , Database.instance);
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
            // Loads purchase orders into grid view
            SQLiteCommand command = new SQLiteCommand(
                "Select * From \"Purchase Orders\" Inner Join Product on Product.ProductId = \"Purchase Orders\".fk_ProductId;"
                , Database.instance);
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
            // Add customer order in database and gridview
            Customer customer = new Customer();
            SQLiteCommand command = new SQLiteCommand(
                    "Insert into \"Client Orders\" (OrderQty, fk_clientId, fk_productId,Value)" +
                    "Values(" +
                    Convert.ToInt32(AddClientOrder.addClientOrder.qty.Text) + "," +
                    Convert.ToInt32(AddClientOrder.addClientOrder.clientid.Text) + "," +
                    Convert.ToInt32(AddClientOrder.addClientOrder.p_code.Text) + "," +
                    Convert.ToDecimal(AddClientOrder.addClientOrder.o_val.Text) + ");"
                    ,Database.instance);
            command.ExecuteNonQuery();
            SQLiteCommand cmd = new SQLiteCommand("Update Client Set LastOrder = " + 
                Convert.ToInt32(AddClientOrder.addClientOrder.order_date.Value.ToShortDateString().Replace("/", "")) + 
                " where ClientId = " + Convert.ToInt32(AddClientOrder.addClientOrder.clientid.Text) + ";", Database.instance);
            cmd.ExecuteNonQuery();
            SQLiteCommand cmd2 = new SQLiteCommand("Update product Set qty = " +
                AddClientOrder.addClientOrder.sold_qty +
                " where productId = " + Convert.ToInt32(AddClientOrder.addClientOrder.p_code.Text) + ";", Database.instance);
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
                        SQLiteCommand command = new SQLiteCommand("delete from \"Client Orders\" where id = \"" + id + "\";", Database.instance);
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
            User user = new User();
            if (Orders.orders.ClientOrderDataGrid.EditMode == DataGridViewEditMode.EditProgrammatically)
            {
                DialogResult dg_res = MessageBox.Show("Please be aware that if you modify a cell in this table the product stock won't change as well as the value of the order.\nAre you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);
                if (dg_res == DialogResult.Yes)
                {
                    for (int item = 0; item <= Orders.orders.ClientOrderDataGrid.Rows.Count - 1; item++)
                    {
                        SQLiteCommand command = new SQLiteCommand("Update \"Client Orders\" set " +
                            "orderQty = @orderQty, " +
                            "clientId = @clientId, " +
                            "value = @value, " +
                            "where id = @id;", Database.instance);
                        command.Parameters.AddWithValue("@id", Orders.orders.ClientOrderDataGrid.Rows[item].Cells[0].Value);
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
            // Add purchase order in database and gridview
            //Customer customer = new Customer();
            SQLiteCommand command = new SQLiteCommand(
                    "Insert into \"Purchase Orders\" (PONumber, PODate, qty, POValue,fk_productid, TBDDate)" +
                    "Values(" +
                    GetPONumber() + "," +
                    Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.po_date.Value.ToShortDateString().Replace("/", "")) + "," +
                    Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.qty.Text) + "," +
                    Convert.ToDecimal(AddPurchaseOrder.addPurchaseOrder.o_val.Text) + "," +
                    Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.p_code.Text) + "," +
                    Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.del_date.Value.ToShortDateString().Replace("/", "")) +");"
                    , Database.instance);
            command.ExecuteNonQuery();
            SQLiteCommand cmd2 = new SQLiteCommand("Update product " +
                "Set qty = " + AddPurchaseOrder.addPurchaseOrder.new_stock + 
                ", onorder = " + 1 +
                ", OnOrderQty = " + Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.qty.Text) + 
                ", deliverydate =  " + Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.del_date.Value.ToShortDateString().Replace("/", "")) +
                " where productId = " + Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.p_code.Text) + ";", Database.instance);
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
            int PONumber = 0;
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM \"Purchase Orders\" ORDER BY PoNumber DESC LIMIT 1;", Database.instance);
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
                        SQLiteCommand command = new SQLiteCommand("delete from \"Purchase Orders\" where POid = \"" + id + "\";", Database.instance);
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
            User user = new User();
            if (Orders.orders.PurchaseOrdersDataGrid.EditMode == DataGridViewEditMode.EditProgrammatically)
            {
                DialogResult dg_res = MessageBox.Show("Please be aware that if you modify a cell in this table the product stock won't change as well as the value of the order.\nAre you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);
                if (dg_res == DialogResult.Yes)
                {
                    for (int item = 0; item <= Orders.orders.PurchaseOrdersDataGrid.Rows.Count - 1; item++)
                    {
                        SQLiteCommand command = new SQLiteCommand("Update \"Purchase Orders\" set " +
                            "podate = @poDate, " +
                            "clientId = @clientId, " +
                            "qty = @qty, " +
                            "POValue = @POvalue, " +
                            "TBDDate = @TBDDate, " +
                            "where poid = @poid;", Database.instance);
                        command.Parameters.AddWithValue("@poid", Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[0].Value);
                        command.Parameters.AddWithValue("@poDate", Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[2].Value);
                        command.Parameters.AddWithValue("@qty", Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[4].Value);
                        command.Parameters.AddWithValue("@POvalue", Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[6].Value);
                        command.Parameters.AddWithValue("@TBDDate", Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[7].Value);
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
