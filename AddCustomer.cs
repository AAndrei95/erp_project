using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Shop_Software
{
    public partial class AddCustomer : Form
    {
        public static AddCustomer addCustomer;
        public AddCustomer()
        {
            addCustomer = this;
            InitializeComponent();
        }
        // Check if the customers has an order befere being added in the list
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox17.Visible = true;
                orderDate.Visible = true;
                textBox28.Visible = true;
            }
            else
            {
                textBox17.Visible = false;
                orderDate.Visible = false;
                textBox28.Visible = false;
            }
        }
        // Add customer in the list 
        private void addValues_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            Database.GetInstance().Open();
            customer.CheckAddCustomer();
            Database.GetInstance().Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Adding 0/1 true of false in combobox- registration
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            reg.Items.Add(0);
            reg.Items.Add(1);
            reg.Text = reg.Items[0].ToString();
        }
    }
}
