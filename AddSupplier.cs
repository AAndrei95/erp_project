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
            supplier.CheckAddSupplier();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
