using Digital_Shop_Software.Repositories;
using Digital_Shop_Software.Services;

namespace Digital_Shop_Software
{
    internal class Supplier
    {
        // Method that load suppliers in the data grid
        public void LoadSuppliers()
        {
            SupplierService supplierService = new SupplierService();

            List<Dictionary<string, object>> suppliers = supplierService.GetSuppliers();

            foreach (Dictionary<string, object> supplier in suppliers)
            {
                 Suppliers.suppliers.SupplierDataGrid.Rows.Add(new object[]
                {
                    supplier["SupplierId"],
                    supplier["SupplierName"],
                    supplier["Description"],
                    supplier["Email"],
                    supplier["PhoneNumber"],
                    supplier["Representative"]
                });
            }
        }

        // Method that adds supplier to data grid and database
        public void AddSuppliers()
        {
            SupplierService supplierService = new SupplierService();

            supplierService.AddSupplier(
                AddSupplier.addSupplier.s_name.Text,
                AddSupplier.addSupplier.desc.Text,
                AddSupplier.addSupplier.email.Text,
                AddSupplier.addSupplier.ph_num.Text,
                AddSupplier.addSupplier.rep.Text);

            Suppliers.suppliers.SupplierDataGrid.Rows.Clear();
            LoadSuppliers();
            
            MessageBox.Show("You've succesfully added a new supplier into the supplier list!");
            AddSupplier.addSupplier.Close();
        }

        // Method that checks if the marked fields are completed
        public void CheckAddSupplier()
        {
            if (string.IsNullOrEmpty(AddSupplier.addSupplier.s_name.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else if (string.IsNullOrEmpty(AddSupplier.addSupplier.email.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else if (string.IsNullOrEmpty(AddSupplier.addSupplier.ph_num.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else if (string.IsNullOrEmpty(AddSupplier.addSupplier.rep.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else { AddSuppliers(); }
        }

        // Method that removes suppliers from the gridview and database
        public void RemoveSupplier()
        {
            SupplierService supplierService = new SupplierService();

            if (Suppliers.suppliers.SupplierDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show(
                    "Are you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);

                if (dg_res == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in Suppliers.suppliers.SupplierDataGrid.SelectedRows)
                    {
                        int supplierId = Convert.ToInt32(item.Cells[0].Value);

                        supplierService.RemoveSupplier(supplierId);

                        Suppliers.suppliers.SupplierDataGrid.Rows.Remove(item);
                    }
                }
            }
            else
            { 
                MessageBox.Show("Please select a row in order to delete it!"); 
            }
        }
        
        // Method that modifies gridview and database supplier table
        public void ModifySupplier()
        {
            SupplierService supplierService = new SupplierService();

            Suppliers.suppliers.SupplierDataGrid.EndEdit();
                
            for (int item = 0; item < Suppliers.suppliers.SupplierDataGrid.Rows.Count; item++)
            {
                int supplierId = Convert.ToInt32(Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[0].Value);
                string supplierName = Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[1].Value?.ToString() ?? "";
                string description = Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[2].Value?.ToString() ?? "";
                string email = Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[3].Value?.ToString() ?? "";
                string phoneNumber = Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[4].Value?.ToString() ?? "";
                string representative = Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[5].Value?.ToString() ?? "";

                supplierService.ModifySupplier(
                    supplierId,
                    supplierName,
                    description,
                    email,
                    phoneNumber,
                    representative);

            }
            Suppliers.suppliers.SupplierDataGrid.EditMode = DataGridViewEditMode.EditOnF2;

            MessageBox.Show("You've succesfully edited the cell!");
        }
    }
}
