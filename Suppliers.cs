namespace Digital_Shop_Software
{
    public partial class Suppliers : Form
    {
        public static Suppliers suppliers;
        public Suppliers()
        {
            suppliers = this;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // Loads suppliers in the grid view
            Supplier supplier = new Supplier();
            supplier.LoadSuppliers();
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.Show(this);
        }

        private void RemoveSupplier_Click(object sender, EventArgs e)
        {
            // Removes supplier from the grid view and database
            Supplier supplier = new Supplier();
            supplier.RemoveSupplier();
        }

        private void ModifySupplier_Click(object sender, EventArgs e)
        {
            // Modify supplier in the gridview and database
            Supplier supplier = new Supplier();
            supplier.ModifySupplier();
        }

        private void SupplierDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Double click to start modifying 
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("You cannot modify this column!");
            }
            else
            {
                SupplierDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
                SupplierDataGrid.BeginEdit(true);
            }
        }
    }
}
