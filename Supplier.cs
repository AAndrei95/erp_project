using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Shop_Software
{
    internal class Supplier
    {
        // Method that load suppliers in the data grid
        public void LoadSuppliers()
        {
            SQLiteCommand command = new SQLiteCommand("Select * From Supplier;", Database.instance);
            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    Suppliers.suppliers.SupplierDataGrid.Rows.Add(new object[]
                        {
                            read.GetValue(0),
                            read.GetValue(read.GetOrdinal("SupplierName")),
                            read.GetValue(read.GetOrdinal("Description")),
                            read.GetValue(read.GetOrdinal("Email")),
                            read.GetValue(read.GetOrdinal("PhoneNumber")),
                            read.GetValue(read.GetOrdinal("Representative"))
                        });
                }
            }
        }
        // Method that adds supplier to data grid and database
        public void AddSuppliers()
        {
            Supplier supplier = new Supplier();
            SQLiteCommand command = new SQLiteCommand(
                "Insert Into Supplier (SupplierName, Description, Email, PhoneNumber, Representative)" +
                "Values (\"" + 
                AddSupplier.addSupplier.s_name.Text + "\",\"" +
                AddSupplier.addSupplier.desc.Text + "\",\"" +
                AddSupplier.addSupplier.email.Text + "\",\"" +
                AddSupplier.addSupplier.ph_num.Text + "\",\"" +
                AddSupplier.addSupplier.rep.Text +
                "\");", Database.instance);
            command.ExecuteNonQuery();
            Suppliers.suppliers.SupplierDataGrid.Rows.Clear();
            supplier.LoadSuppliers();
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
            if (Suppliers.suppliers.SupplierDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show("Are you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);
                if (dg_res == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in Suppliers.suppliers.SupplierDataGrid.SelectedRows)
                    {
                        int id = Convert.ToInt32(Suppliers.suppliers.SupplierDataGrid.SelectedRows[0].Cells[0].Value);
                        SQLiteCommand command = new SQLiteCommand("delete from supplier where supplierid = \"" + id + "\";", Database.instance);
                        Suppliers.suppliers.SupplierDataGrid.Rows.RemoveAt(Suppliers.suppliers.SupplierDataGrid.SelectedRows[0].Index);
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            { MessageBox.Show("Please select a row in order to delete it!"); }
        }
        // Method that modifies gridview and database supplier table
        public void ModifySupplier()
        {
            if (Suppliers.suppliers.SupplierDataGrid.EditMode == DataGridViewEditMode.EditProgrammatically)
            {
                for (int item = 0; item <= Suppliers.suppliers.SupplierDataGrid.Rows.Count - 1; item++)
                {
                    SQLiteCommand command = new SQLiteCommand("Update Supplier set " +
                        "SupplierName = @supplierName, " +
                        "description = @description, " +
                        "email = @email, " +
                        "phonenumber = @phoneNumber, " +
                        "Representative = representative " +
                        "where SupplierId = @SupplierId;", Database.instance);
                    command.Parameters.AddWithValue("@SupplierId", Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[0].Value);
                    command.Parameters.AddWithValue("@supplierName", Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[1].Value);
                    command.Parameters.AddWithValue("@description", Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[2].Value);
                    command.Parameters.AddWithValue("@email", Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[3].Value);
                    command.Parameters.AddWithValue("@phoneNumber", Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[4].Value);
                    command.Parameters.AddWithValue("@representative", Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[5].Value);
                    command.Parameters.AddWithValue("@representative", Suppliers.suppliers.SupplierDataGrid.Rows[item].Cells[6].Value);
                    command.ExecuteNonQuery();
                }
                Suppliers.suppliers.SupplierDataGrid.EndEdit();
                Suppliers.suppliers.SupplierDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
                MessageBox.Show("You've succesfully edited the cell!");
            } else { MessageBox.Show("Please double click on a cell in order to edit it!"); }
            
        }
    }
}
