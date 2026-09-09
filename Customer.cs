using Digital_Shop_Software.Repositories;

namespace Digital_Shop_Software
{
    internal class Customer
    {
        public int order_date;
        // Method that loads datagrid
        public void LoadCustomers()
        {
            CustomerRepository customerRepository = new CustomerRepository();

            List<Dictionary<string, object>> customers = customerRepository.GetCustomers();

                foreach (Dictionary<string, object> customer in customers)
                {
                    Customers.customers.CustomerDataGrid.Rows.Add(new object[]
                    {
                        customer["ClientId"],
                        customer["Email"],
                        customer["PhoneNumber"],
                        customer["Registered"],
                        customer["OrderDate"],
                        customer["LastOrder"],
                        customer["Username"]
                    });
                }
        }

        // Method that adds customers in the database and refreshes datagrid
        public void AddCustomers()
        {
            UserRepository userRepository = new UserRepository();
            CustomerRepository customerRepository = new CustomerRepository();

            int userId = userRepository.GetUserId(Login.login.Username.Text);
            int registered = Convert.ToInt32(AddCustomer.addCustomer.reg.Text);
            int orderDate = order_date;
            int lastOrder = order_date;

            if (AddCustomer.addCustomer.checkBox1.Checked)
            {
                orderDate = ConvertToDate();
                lastOrder = order_date;
            }
                
            customerRepository.AddCustomer(
                AddCustomer.addCustomer.email.Text,
                AddCustomer.addCustomer.ph_num.Text,
                registered,
                orderDate,
                lastOrder,
                userId);

            MessageBox.Show("You've succesfully added a new customer into the customer list!");

            Customers.customers.CustomerDataGrid.Rows.Clear();
            LoadCustomers();

            AddCustomer.addCustomer.Close();

             if (AddClientOrder.addClientOrder != null &&
                AddClientOrder.addClientOrder.new_client == true)
            {
                AddClientOrder.addClientOrder.new_client = false;
                AddClientOrder.addClientOrder.clientid.Items.Clear();

                List<int> clientIds = customerRepository.GetClientIds();

                foreach (int clientId in clientIds)
                {
                    AddClientOrder.addClientOrder.clientid.Items.Add(clientId);
                }

                if (AddClientOrder.addClientOrder.clientid.Items.Count > 0)
                {
                    AddClientOrder.addClientOrder.clientid.Text = AddClientOrder.addClientOrder.clientid.Items[0].ToString();
                }
            }
        }

        // Method that converts date string into integer
        public int ConvertToDate()
        {
            string date = AddCustomer.addCustomer.orderDate.Value.ToShortDateString();
            date = date.Replace("/", "");
            order_date = Convert.ToInt32(date);
            return order_date;
        }

        // Method that checks if the mandatory fields are filled
        public void CheckAddCustomer()
        {
            if (string.IsNullOrEmpty(AddCustomer.addCustomer.email.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else if (string.IsNullOrEmpty(AddCustomer.addCustomer.reg.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else { AddCustomers(); }
        }

        // Methods that removes rows from the datagrid along with rows from the database
        public void RemoveCustomer()
        {
            CustomerRepository customerRepository = new CustomerRepository();

            // If minimum a row is selected
            if (Customers.customers.CustomerDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show(
                    "Are you sure you want to remove this row?",
                    "Delete Row", MessageBoxButtons.YesNo);

                if (dg_res == DialogResult.Yes)
                {
                    // For each row selected in the datagrid delete the matching row in the database
                    foreach (DataGridViewRow item in Customers.customers.CustomerDataGrid.SelectedRows)
                    {
                        int id = Convert.ToInt32(Customers.customers.CustomerDataGrid.SelectedRows[0].Cells[0].Value);

                        customerRepository.RemoveCustomer(id);
                        Customers.customers.CustomerDataGrid.Rows.RemoveAt(Customers.customers.CustomerDataGrid.SelectedRows[0].Index);
                    }
                }
            }
            // If no row is selected
            else
            { 
                MessageBox.Show("Please select a row in order to delete it!");
            }
        }

        // Method that allows modifying the datagrid along with the database
        public void ModifyCustomer()
        {
            UserRepository userRepository = new UserRepository();
            CustomerRepository customerRepository = new CustomerRepository();

            Customers.customers.CustomerDataGrid.EndEdit();

            for (int item = 0; item < Customers.customers.CustomerDataGrid.Rows.Count; item++)
            {
                int clientId = Convert.ToInt32(Customers.customers.CustomerDataGrid.Rows[item].Cells[0].Value);
                string email = Customers.customers.CustomerDataGrid.Rows[item].Cells[1].Value?.ToString() ?? "";
                string phoneNumber = Customers.customers.CustomerDataGrid.Rows[item].Cells[2].Value?.ToString() ?? "";
                object registered = Customers.customers.CustomerDataGrid.Rows[item].Cells[3].Value ?? "";
                object orderDate = Customers.customers.CustomerDataGrid.Rows[item].Cells[4].Value ?? "";
                object lastOrder = Customers.customers.CustomerDataGrid.Rows[item].Cells[5].Value ?? "";
                int userId = userRepository.GetUserId(Login.login.Username.Text);

                customerRepository.ModifyCustomer(
                    clientId,
                    email,
                    phoneNumber,
                    registered,
                    orderDate,
                    lastOrder,
                    userId);
            }   
            Customers.customers.CustomerDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
            
            MessageBox.Show("You've succesfully edited the cell!");
        }
    }      
}
