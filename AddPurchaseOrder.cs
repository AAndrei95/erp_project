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

namespace Digital_Shop_Software
{
    public partial class AddPurchaseOrder : Form
    {
        public int new_stock;
        public string supplier_price;
        public static AddPurchaseOrder addPurchaseOrder;
        public AddPurchaseOrder()
        {
            addPurchaseOrder = this;
            InitializeComponent();
        }

        private void AddPurchaseOrder_Load(object sender, EventArgs e)
        {
            po_date.MinDate = DateTime.Now;
            del_date.MinDate = po_date.Value;

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
            Database.GetInstance().Close();
        }

        private void po_date_ValueChanged(object sender, EventArgs e)
        {
            del_date.MinDate = po_date.Value;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    o_val.Text = read.GetValue(read.GetOrdinal("SupplierPrice")).ToString();
                    supplier_price = read.GetValue(read.GetOrdinal("SupplierPrice")).ToString();
                }
            }
            Database.GetInstance().Close();
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            o_val.Text = supplier_price.ToString();
            if (string.IsNullOrEmpty(qty.Text) && p_code.Text.Length > 0)
            {
                o_val.Text = supplier_price.ToString();
            }
            else if (qty.Text.Length > 0 && p_code.Text.Length > 0)
            {
                try
                {
                    int buy_qty = Convert.ToInt32(qty.Text);
                    decimal price = Convert.ToDecimal(o_val.Text);
                    Action<decimal> updateTotalValue = (totalValue) => o_val.Text = totalValue.ToString();
                    updateTotalValue(price * buy_qty);
                    new_stock = Convert.ToInt32(s_qty.Text) + Convert.ToInt32(qty.Text);
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

        private void addValues_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            Database.GetInstance().Open();
            order.CheckPurchaseOrders();
            Database.GetInstance().Close();
        }
    }
}
