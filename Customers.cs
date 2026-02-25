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
    public partial class Customers : Form
    {
        User user = new User();
        public static Customers customers;
        public Customers()
        {
            customers = this;
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Customers_Load(object sender, EventArgs e)
        {
            // Loads customer data into grid view
            Database.GetInstance().Open();
            Customer customer = new Customer();
            customer.LoadCustomers();
            Database.GetInstance().Close();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            // Displays customer add form
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Removes a rows when button is clicked
            Customer customer = new Customer();
            Database.GetInstance().Open();
            customer.RemoveCustomer();
            Database.GetInstance().Close();
        }

        private void Modify_Click(object sender, EventArgs e)
        {

            // Modifies a row
            Customer customer = new Customer();
            Database.GetInstance().Open();
            customer.ModifyCustomer();
            Database.GetInstance().Close();
        }

        private void CustomerDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the cell is pressed twice it can be modified, except 2 columns
            if (e.ColumnIndex == 0 || e.ColumnIndex == 6)
            {
                MessageBox.Show("You cannot edit this column!");
            }
            else
            {
                CustomerDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
                CustomerDataGrid.BeginEdit(true);
            }

        }
    }
}
