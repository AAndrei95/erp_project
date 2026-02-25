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
    public partial class Stock : Form
    {
        public static Stock stock;
        public Stock()
        {
            stock = this;
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            // Loads products into the grid view
            Database.GetInstance().Open();
            Products products = new Products();
            products.LoadStock();
            Database.GetInstance().Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            // Modify stock
            Database.GetInstance().Open();
            Products products = new Products();
            products.ModifyStock();
            Database.instance.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddStock addStock = new AddStock();
            addStock.Show(this);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            // Remove products
            Products products = new Products();
            Database.GetInstance().Open();
            products.RemoveProduct();
            Database.GetInstance().Close();

        }

        private void StockDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Double click to start modifying a column
            if (e.ColumnIndex == 0 || e.ColumnIndex == 10 || e.ColumnIndex == 11)
            {
                MessageBox.Show("You cannot modify this column!");
            }
            else
            {
                StockDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
                StockDataGrid.BeginEdit(true);
            }
        }
    }
}
