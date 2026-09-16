using Digital_Shop_Software.Services;

namespace Digital_Shop_Software
{
    internal class Order
    {
        public void LoadClientOrders()
        {
            OrderService orderService = new OrderService();

            List<Dictionary<string, object>> orders = orderService.GetClientOrders();

            foreach (Dictionary<string, object> order in orders)
            {
                Orders.orders.ClientOrderDataGrid.Rows.Add(new object[]
                {
                    order["Id"],
                    order["ClientId"],
                    order["Email"],
                    order["PhoneNumber"],
                    order["Name"],
                    order["OrderQty"],
                    order["Value"],
                    order["Registered"]
                });
            }
        }

        public void LoadPurchaseOrders()
        {
            OrderService orderService = new OrderService();

            List<Dictionary<string, object>> orders = orderService.GetPurchaseOrders();

            // Loads purchase orders into grid view
            foreach (Dictionary<string, object> order in orders)
            {
                Orders.orders.PurchaseOrdersDataGrid.Rows.Add(new object[]
                {
                    order["POId"],
                    order["PONumber"],
                    order["PODate"],
                    order["Name"],
                    order["Qty"],
                    order["SupplierPrice"],
                    order["POValue"],
                    order["TBDDate"]
                });
            }
        }

        public void AddCustomerOrder()
        {
            OrderService orderService = new OrderService();

            int orderQty = Convert.ToInt32(AddClientOrder.addClientOrder.qty.Text);
            int clientId = Convert.ToInt32(AddClientOrder.addClientOrder.clientid.Text);
            int productId = Convert.ToInt32(AddClientOrder.addClientOrder.p_code.Text);
            decimal value = Convert.ToDecimal(AddClientOrder.addClientOrder.o_val.Text);
            int lastOrder = Convert.ToInt32(AddClientOrder.addClientOrder.order_date.Value.ToShortDateString().Replace("/", ""));

            orderService.AddCustomerOrder(orderQty, clientId, productId, value);
            orderService.UpdateClientLastOrder(clientId, lastOrder);
            orderService.UpdateProductQuantity(productId, AddClientOrder.addClientOrder.sold_qty);

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
            OrderService orderService = new OrderService();

            // If minimum a row is selected
            if (Orders.orders.ClientOrderDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show(
                    "Please be aware that if you delete a row in this table the product stock won't change." +
                    "\nAre you sure you want to remove this row?",
                    "Delete Row",
                    MessageBoxButtons.YesNo);

                if (dg_res == DialogResult.Yes)
                {
                    // For each row selected in the datagrid delete the matching row in the database
                    foreach (DataGridViewRow item in Orders.orders.ClientOrderDataGrid.SelectedRows)
                    {
                        int orderId = Convert.ToInt32(item.Cells[0].Value);

                        orderService.RemoveCustomerOrder(orderId);

                        Orders.orders.ClientOrderDataGrid.Rows.Remove(item);
                    }
                }
            }
            // If no row is selected
            else
            {
                MessageBox.Show("Please select a row in order to delete it!");
            }
        }

        public void ModifyCustomerOrder()
        {
            OrderService orderService = new OrderService();

            DialogResult dg_res = MessageBox.Show(
                "Please be aware that if you modify a cell in this table the product stock won't change as well as the value of the order." +
                "\nAre you sure you want to remove this row?",
                "Delete Row",
                MessageBoxButtons.YesNo);

            if (dg_res != DialogResult.Yes)
            {
                return;
            }
            Orders.orders.ClientOrderDataGrid.EndEdit();

            for (int item = 0;
                item < Orders.orders.ClientOrderDataGrid.Rows.Count;
                item++)
            {
                if (Orders.orders.ClientOrderDataGrid.Rows[item].IsNewRow)
                {
                    continue;
                }

                int orderId = Convert.ToInt32(Orders.orders.ClientOrderDataGrid.Rows[item].Cells[0].Value);
                int clientId = Convert.ToInt32(Orders.orders.ClientOrderDataGrid.Rows[item].Cells[1].Value);
                int orderQty = Convert.ToInt32(Orders.orders.ClientOrderDataGrid.Rows[item].Cells[5].Value);
                decimal value = Convert.ToDecimal(Orders.orders.ClientOrderDataGrid.Rows[item].Cells[6].Value);

                orderService.ModifyCustomerOrder(orderId, orderQty, clientId, value);
            }

            Orders.orders.ClientOrderDataGrid.EditMode = DataGridViewEditMode.EditOnF2;

            MessageBox.Show("You've succesfully edited the cell!");
        }

        public void AddPurchaseOrders()
        {
            OrderService orderService = new OrderService();

            int poNumber = GetPONumber();
            int poDate = Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.po_date.Value.ToShortDateString().Replace("/", ""));
            int qty = Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.qty.Text);
            decimal poValue = Convert.ToDecimal(AddPurchaseOrder.addPurchaseOrder.o_val.Text);
            int productId = Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.p_code.Text);
            int tbdDate = Convert.ToInt32(AddPurchaseOrder.addPurchaseOrder.del_date.Value.ToShortDateString().Replace("/", ""));

            orderService.AddPurchaseOrder(
                poNumber,
                poDate,
                qty,
                poValue,
                productId,
                tbdDate);

            orderService.UpdateProductStock(
                productId,
                AddPurchaseOrder.addPurchaseOrder.new_stock,
                1,
                qty,
                tbdDate);

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
            OrderService orderService = new OrderService();

            return orderService.GetNextPONumber();
        }

        public void RemovePurchaseOrder()
        {
            OrderService orderService = new OrderService();

            // If minimum a row is selected
            if (Orders.orders.PurchaseOrdersDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show(
                    "Please be aware that if you delete a row in this table the product stock won't change." +
                    "\nAre you sure you want to remove this row?",
                    "Delete Row",
                    MessageBoxButtons.YesNo);

                if (dg_res == DialogResult.Yes)
                {
                    // For each row selected in the datagrid delete the matching row in the database
                    foreach (DataGridViewRow item in Orders.orders.PurchaseOrdersDataGrid.SelectedRows)
                    {
                        int poId = Convert.ToInt32(item.Cells[0].Value);

                        orderService.RemovePurchaseOrder(poId);

                        Orders.orders.PurchaseOrdersDataGrid.Rows.Remove(item);
                    }
                }
            }
            // If no row is selected
            else
            {
                MessageBox.Show("Please select a row in order to delete it!");
            }
        }

        public void ModifyPurchaseOrder()
        {
            OrderService orderService = new OrderService();

            DialogResult dg_res = MessageBox.Show(
                "Please be aware that if you modify a cell in this table the product stock won't change as well as the value of the order." +
                "\nAre you sure you want to remove this row?",
                "Delete Row",
                MessageBoxButtons.YesNo);

            if (dg_res != DialogResult.Yes)
            {
                return;
            }

            Orders.orders.PurchaseOrdersDataGrid.EndEdit();

            for (int item = 0; item < Orders.orders.PurchaseOrdersDataGrid.Rows.Count; item++)
            {
                if (Orders.orders.PurchaseOrdersDataGrid.Rows[item].IsNewRow)
                {
                    continue;
                }

                int poId = Convert.ToInt32(Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[0].Value);
                int poDate = Convert.ToInt32(Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[2].Value);
                int qty = Convert.ToInt32(Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[4].Value);
                decimal poValue = Convert.ToDecimal(Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[6].Value);
                int tbdDate = Convert.ToInt32(Orders.orders.PurchaseOrdersDataGrid.Rows[item].Cells[7].Value);

                orderService.ModifyPurchaseOrder(
                    poId,
                    poDate,
                    qty,
                    poValue,
                    tbdDate);
            }

            Orders.orders.PurchaseOrdersDataGrid.EditMode = DataGridViewEditMode.EditOnF2;

            MessageBox.Show("You've succesfully edited the cell!");
        }
    }
}
