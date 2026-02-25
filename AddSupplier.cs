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
    public partial class AddSupplier : Form
    {
        public static AddSupplier addSupplier;
        public AddSupplier()
        {
            addSupplier = this;
            InitializeComponent();
        }

        private void addValues_Click(object sender, EventArgs e)
        {
            // Checking if user input is correct and adding supplier in the list
            Supplier supplier = new Supplier();
            Database.GetInstance().Open();
            supplier.CheckAddSupplier();
            Database.GetInstance().Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
