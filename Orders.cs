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
    public partial class Orders : Form
    {
        public static Orders orders;
        Order order = new Order();
        public Orders()
        {
            orders = this;
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // Adding combobox items for orders
            comboBox1.Items.Add("Client Orders");
            comboBox1.Items.Add("Purchase Orders");
            Database.GetInstance().Open();
            Order order = new Order();
            order.LoadClientOrders();
            order.LoadPurchaseOrders();
            Database.GetInstance().Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // Displaying grid view in accordance with combobox selection
            if (comboBox1.SelectedIndex == 0)
            {
                ClientOrderDataGrid.Visible = true;
                PurchaseOrdersDataGrid.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                PurchaseOrdersDataGrid.Visible = true;
                ClientOrderDataGrid.Visible = false;
            }
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            AddPurchaseOrder addPurchaseOrder = new AddPurchaseOrder();
            AddClientOrder addClientOrder = new AddClientOrder();
            if (comboBox1.SelectedIndex == 0)
            {
                addClientOrder.Show();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                addPurchaseOrder.Show();
            }
        }

        private void RemoveOrder_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                order.RemoveCustomerOrder();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                order.RemovePurchaseOrder();
            }
        }
        private void ModifyOrder_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                order.ModifyCustomerOrder();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                order.ModifyCustomerOrder();
            }
        }

        private void ClientOrderDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 7)
            {
                MessageBox.Show("You cannot modify this column!");
            }
            else
            {
                ClientOrderDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
                ClientOrderDataGrid.BeginEdit(true);
            }
        }

        private void PurchaseOrdersDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 5 || e.ColumnIndex == 3)
            {
                MessageBox.Show("You cannot modify this column!");
            }
            else
            {
                ClientOrderDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
                ClientOrderDataGrid.BeginEdit(true);
            }
        }
    }
}

