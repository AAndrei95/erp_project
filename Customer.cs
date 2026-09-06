using System.Data.SQLite;

namespace Digital_Shop_Software
{
    internal class Customer
    {
        public int order_date;
        // Method that loads datagrid
        public void LoadCustomers()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM CLIENT INNER JOIN USERS ON USERS.USERID = CLIENT.USERID;", connection);
            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    Customers.customers.CustomerDataGrid.Rows.Add(new object[]
                        {
                            read.GetValue(0),
                            read.GetValue(read.GetOrdinal("Email")),
                            read.GetValue(read.GetOrdinal("PhoneNumber")),
                            read.GetValue(read.GetOrdinal("Registered")),
                            read.GetValue(read.GetOrdinal("OrderDate")),
                            read.GetValue(read.GetOrdinal("LastOrder")),
                            read.GetValue(read.GetOrdinal("Username"))
                        });
                }
            }
        }

        // Method that adds customers in the database and refreshes datagrid
        public void AddCustomers()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            User user = new User();
            // If the user has an order
            if (AddCustomer.addCustomer.checkBox1.Checked)
            {
                SQLiteCommand command = new SQLiteCommand(
                    "INSERT INTO Client " +
                    "(Email, PhoneNumber, Registered, OrderDate, LastOrder, UserId) " +
                    "VALUES (@email, @phoneNumber, @registered, @orderDate, @lastOrder, @userId);",
                    connection);

                command.Parameters.AddWithValue("@email", AddCustomer.addCustomer.email.Text);
                command.Parameters.AddWithValue("@phoneNumber", AddCustomer.addCustomer.ph_num.Text);
                command.Parameters.AddWithValue("@registered", Convert.ToInt32(AddCustomer.addCustomer.reg.Text));
                command.Parameters.AddWithValue("@orderDate", ConvertToDate());
                command.Parameters.AddWithValue("@lastOrder", order_date);
                command.Parameters.AddWithValue("@userId", Convert.ToInt32(user.GetUserId()));

                command.ExecuteNonQuery();

                MessageBox.Show("You've succesfully added a new customer into the customer list!");
                Customers.customers.CustomerDataGrid.Rows.Clear();
                LoadCustomers();
                AddCustomer.addCustomer.Close();
            }
            // No order
            else
            {
                SQLiteCommand command = new SQLiteCommand(
                    "INSERT INTO Client " +
                    "(Email, PhoneNumber, Registered, OrderDate, LastOrder, UserId) " +
                    "VALUES (@email, @phoneNumber, @registered, @orderDate, @lastOrder, @userId);",
                    connection);

                command.Parameters.AddWithValue("@email", AddCustomer.addCustomer.email.Text);
                command.Parameters.AddWithValue("@phoneNumber", AddCustomer.addCustomer.ph_num.Text);
                command.Parameters.AddWithValue("@registered", Convert.ToInt32(AddCustomer.addCustomer.reg.Text));
                command.Parameters.AddWithValue("@orderDate", order_date);
                command.Parameters.AddWithValue("@lastOrder", order_date);
                command.Parameters.AddWithValue("@userId", Convert.ToInt32(user.GetUserId()));

                command.ExecuteNonQuery();
                MessageBox.Show("You've succesfully added a new customer into the customer list!");
                try
                {
                    Customers.customers.CustomerDataGrid.Rows.Clear();
                    LoadCustomers();
                }
                catch (Exception ex) { }
                AddCustomer.addCustomer.Close();
                if (AddClientOrder.addClientOrder.new_client == true)
                {
                    AddClientOrder.addClientOrder.new_client = false;
                    AddClientOrder.addClientOrder.clientid.Items.Clear();
                    SQLiteCommand cmd = new SQLiteCommand(
                        "SELECT * FROM CLIENT;", connection);
                    using (SQLiteDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            // Adding client codes in combobox
                            AddClientOrder.addClientOrder.clientid.Items.AddRange(new object[]
                            {
                        read.GetValue(read.GetOrdinal("clientId"))
                            });
                        }
                    }
                    // Setting a default value for combobox
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
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            // If minimum a row is selected
            if (Customers.customers.CustomerDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show("Are you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);
                if (dg_res == DialogResult.Yes)
                {
                    // For each row selected in the datagrid delete the matching row in the database
                    foreach (DataGridViewRow item in Customers.customers.CustomerDataGrid.SelectedRows)
                    {
                        int id = Convert.ToInt32(Customers.customers.CustomerDataGrid.SelectedRows[0].Cells[0].Value);
                        SQLiteCommand command = new SQLiteCommand(
                            "DELETE FROM Client WHERE ClientId = @clientId;",
                            connection);

                        command.Parameters.AddWithValue("@clientId", id);

                        Customers.customers.CustomerDataGrid.Rows.RemoveAt(Customers.customers.CustomerDataGrid.SelectedRows[0].Index);
                        
                        command.ExecuteNonQuery();
                    }
                }
            }
            // If no row is selected
            else
            { MessageBox.Show("Please select a row in order to delete it!"); }
        }

        // Method that allows modifying the datagrid along with the database
        public void ModifyCustomer()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            User user = new User();
            if (Customers.customers.CustomerDataGrid.EditMode == DataGridViewEditMode.EditProgrammatically)
            {
                for (int item = 0; item <= Customers.customers.CustomerDataGrid.Rows.Count - 1; item++)
                {
                    SQLiteCommand command = new SQLiteCommand("UPDATE CLIENT SET " +
                        "email = @email, " +
                        "phonenumber = @phonenumber, " +
                        "registered = @registered, " +
                        "OrderDate = @orderDate, " +
                        "lastorder = @lastOrder, " +
                        "userid = @userid " +
                        "where clientid = @clientid;", connection);
                    command.Parameters.AddWithValue("@clientid", Customers.customers.CustomerDataGrid.Rows[item].Cells[0].Value);
                    command.Parameters.AddWithValue("@email", Customers.customers.CustomerDataGrid.Rows[item].Cells[1].Value);
                    command.Parameters.AddWithValue("@phonenumber", Customers.customers.CustomerDataGrid.Rows[item].Cells[2].Value);
                    command.Parameters.AddWithValue("@registered", Customers.customers.CustomerDataGrid.Rows[item].Cells[3].Value);
                    command.Parameters.AddWithValue("@orderDate", Customers.customers.CustomerDataGrid.Rows[item].Cells[4].Value);
                    command.Parameters.AddWithValue("@lastOrder", Customers.customers.CustomerDataGrid.Rows[item].Cells[5].Value);
                    command.Parameters.AddWithValue("@userid", user.GetUserId());
                    command.ExecuteNonQuery();
                }
                Customers.customers.CustomerDataGrid.EndEdit();
                Customers.customers.CustomerDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
                MessageBox.Show("You've succesfully edited the cell!");
            }
            else { MessageBox.Show("Please double click on a cell in order to edit it!"); }
        }
    }
}
