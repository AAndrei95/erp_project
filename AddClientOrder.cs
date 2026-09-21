using Digital_Shop_Software.Services;

namespace Digital_Shop_Software
{
    public partial class AddClientOrder : Form
    {
        string sale_price;
        public int sold_qty;
        public static AddClientOrder addClientOrder;
        public bool new_client = false;

        public AddClientOrder()
        {
            addClientOrder = this;
            InitializeComponent();
        }

        private void AddClientOrder_Load(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            CustomerService customerService = new CustomerService();

            List<int> productIds = productService.GetProductIds();
            List<int> clientIds = customerService.GetClientIds();

            foreach (int productId in productIds)
            {
                p_code.Items.Add(productId);
            }

            foreach (int clientId in clientIds)
            {
                clientid.Items.Add(clientId);
            }

            // Setting a default value for combobox
            clientid.Text = clientid.Items[0].ToString();
        }

        private void addValues_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.CheckClientOrders();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                new_client = true;
                Customer customer = new Customer();
                AddCustomer addCustomer = new AddCustomer();
                addCustomer.Show();
                customer.CheckAddCustomer();
            }
        }

        private void p_code_SelectedValueChanged(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();

            int productId = Convert.ToInt32(p_code.Text);

            Dictionary<string, object>? product =
                productService.GetProductById(productId);

            if (product == null)
            {
                return;
            }

            p_name.Text = product["Name"].ToString();
            category.Text = product["Category"].ToString();
            s_qty.Text = product["Qty"].ToString();
            o_val.Text = product["SalePrice"].ToString();
            sale_price = product["SalePrice"].ToString();
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            o_val.Text = sale_price.ToString();
            if (string.IsNullOrEmpty(qty.Text) && p_code.Text.Length > 0)
            {
                o_val.Text = sale_price.ToString();
            }
            else if (qty.Text.Length > 0 &&
                p_code.Text.Length > 0
                && Convert.ToInt32(qty.Text) < Convert.ToInt32(s_qty.Text))
            {
                try
                {
                    int sale_qty = Convert.ToInt32(qty.Text);
                    decimal price = Convert.ToDecimal(o_val.Text);
                    Action<decimal> updateTotalValue = (totalValue) => o_val.Text = totalValue.ToString();
                    updateTotalValue(price * sale_qty);
                    sold_qty = Convert.ToInt32(s_qty.Text) - Convert.ToInt32(qty.Text);
                }
                catch (Exception ex)
                {
                    qty.Clear();
                    MessageBox.Show("The quantity must be a number!");
                }
            }
            else if (qty.Text.Length > 0
                && p_code.Text.Length > 0 &&
                Convert.ToInt32(qty.Text) > Convert.ToInt32(s_qty.Text))
            {
                try
                {
                    MessageBox.Show("There are not enough products in stock!");
                    qty.Clear();
                }
                catch (Exception ex)
                {
                    qty.Clear();
                    MessageBox.Show("The quantity must be a number!");
                }
            }
            else if (qty.Text.Length > 0 && p_code.Text.Length == 0)
            {
                qty.Clear();
                MessageBox.Show("Please make sure that you've selected a product before introducing the quantity!");
            }
            else if (string.IsNullOrEmpty(qty.Text))
            {
                o_val.Text = "0";
            }
        }
    }
}
