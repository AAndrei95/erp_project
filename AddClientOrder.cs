using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Digital_Shop_Software
{
    public partial class AddClientOrder : Form
    {
        string sale_price;
        public int sold_qty;
        public static AddClientOrder addClientOrder;
        public bool new_client = false;

        public AddClientOrder()
        {
            addClientOrder = this;
            InitializeComponent();
        }

        private void AddClientOrder_Load(object sender, EventArgs e)
        {
            Database.GetInstance().Open();
            SQLiteCommand command = new SQLiteCommand(
               "Select * From Product;", Database.instance);
            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    // Adding product codes in combobox
                    p_code.Items.AddRange(new object[]
                    {
                        read.GetValue(read.GetOrdinal("ProductId"))
                    });
                }
            }
            SQLiteCommand cmd = new SQLiteCommand(
               "Select * From client;", Database.instance);
            using (SQLiteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    // Adding client codes in combobox
                    clientid.Items.AddRange(new object[]
                    {
                        read.GetValue(read.GetOrdinal("clientId"))
                    });
                }
            }
            Database.GetInstance().Close();
            // Setting a default value for combobox
            clientid.Text = clientid.Items[0].ToString();
        }

        private void addValues_Click(object sender, EventArgs e)
        {
           
            Order order = new Order();
            Database.GetInstance().Open();
            order.CheckClientOrders();
            Database.GetInstance().Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                new_client = true;
                Customer customer = new Customer();
                AddCustomer addCustomer = new AddCustomer();
                addCustomer.Show();
                Database.GetInstance().Open();
                customer.CheckAddCustomer();
                Database.GetInstance().Close();
            }
        }

        private void p_code_SelectedValueChanged(object sender, EventArgs e)
        {
            Database.GetInstance().Open();
            SQLiteCommand command = new SQLiteCommand(
               "Select * From Product where ProductId = " + Convert.ToInt32(p_code.Text) + ";", Database.instance);
            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    p_name.Text = read.GetValue(read.GetOrdinal("Name")).ToString();
                    category.Text = read.GetValue(read.GetOrdinal("Category")).ToString();
                    s_qty.Text = read.GetValue(read.GetOrdinal("qty")).ToString();
                    o_val.Text = read.GetValue(read.GetOrdinal("SalePrice")).ToString();
                    sale_price = read.GetValue(read.GetOrdinal("SalePrice")).ToString();
                }
            }
            Database.GetInstance().Close();
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            o_val.Text = sale_price.ToString();
            if (string.IsNullOrEmpty(qty.Text) && p_code.Text.Length > 0)
            {
                o_val.Text = sale_price.ToString();
            }
            else if (qty.Text.Length > 0 && p_code.Text.Length > 0 && Convert.ToInt32(qty.Text) < Convert.ToInt32(s_qty.Text))
            {
                try
                {
                    int sale_qty = Convert.ToInt32(qty.Text);
                    decimal price = Convert.ToDecimal(o_val.Text);
                    Action<decimal> updateTotalValue = (totalValue) => o_val.Text = totalValue.ToString();
                    updateTotalValue(price * sale_qty);
                    sold_qty = Convert.ToInt32(s_qty.Text) - Convert.ToInt32(qty.Text);
                }
                catch (Exception ex)
                {
                    qty.Clear();
                    MessageBox.Show("The quantity must be a number!");
                }
            }
            else if (qty.Text.Length > 0 && p_code.Text.Length > 0 && Convert.ToInt32(qty.Text) > Convert.ToInt32(s_qty.Text))
            {
                try
                {
                    MessageBox.Show("There are not enough products in stock!");
                    qty.Clear();
                }
                catch (Exception ex)
                {
                    qty.Clear();
                    MessageBox.Show("The quantity must be a number!");
                }
            }
            else if (qty.Text.Length > 0 && p_code.Text.Length == 0)
            {
                qty.Clear();
                MessageBox.Show("Please make sure that you've selected a product before introducing the quantity!");
            }
            else if (string.IsNullOrEmpty(qty.Text))
            {
                o_val.Text = "0";
            }
        }
    }
}
