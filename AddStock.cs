using Digital_Shop_Software.Services;

namespace Digital_Shop_Software
{
    public partial class AddStock : Form
    {
        public static AddStock addStock;
        public AddStock()
        {
            addStock = this;
            InitializeComponent();
        }
        private void AddStock_Load(object sender, EventArgs e)
        {
            SupplierService supplierService = new SupplierService();

            List<string> supplierNames = supplierService.GetSupplierNames();
               
            foreach (string supplierName in supplierNames)
            {
                sup_name.Items.Add(supplierName);
            }

            // On order bool combobox
            onOrder.Items.Add(0);
            onOrder.Items.Add(1);

            // Setting a default value for both comboboxes
            sup_name.Text = sup_name.Items[0].ToString();
            onOrder.Text = onOrder.Items[0].ToString();
        }

        private void addValues_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.CheckAddStock();
            // Checking if there are no error with user input and adding the product in stock 
            if (products.error == 0)
            {
                products.AddProducts();
                MessageBox.Show("You've succesfully added a product into the stock!");
                this.Close();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
