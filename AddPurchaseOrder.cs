using Digital_Shop_Software.Services;

namespace Digital_Shop_Software
{
    public partial class AddPurchaseOrder : Form
    {
        public int new_stock;
        public string supplier_price;
        public static AddPurchaseOrder addPurchaseOrder;
        public AddPurchaseOrder()
        {
            addPurchaseOrder = this;
            InitializeComponent();
        }

        private void AddPurchaseOrder_Load(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();

            po_date.MinDate = DateTime.Now;
            del_date.MinDate = po_date.Value;

            List<int> productIds = productService.GetProductIds();

            foreach (int productId in productIds)
            {
                p_code.Items.Add(productId);
            }
        }

        private void po_date_ValueChanged(object sender, EventArgs e)
        {
            del_date.MinDate = po_date.Value;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            o_val.Text = product["SupplierPrice"].ToString();
            supplier_price = product["SupplierPrice"].ToString();
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            o_val.Text = supplier_price.ToString();
            if (string.IsNullOrEmpty(qty.Text) && p_code.Text.Length > 0)
            {
                o_val.Text = supplier_price.ToString();
            }
            else if (qty.Text.Length > 0 && p_code.Text.Length > 0)
            {
                try
                {
                    int buy_qty = Convert.ToInt32(qty.Text);
                    decimal price = Convert.ToDecimal(o_val.Text);
                    Action<decimal> updateTotalValue = (totalValue) => o_val.Text = totalValue.ToString();
                    updateTotalValue(price * buy_qty);
                    new_stock = Convert.ToInt32(s_qty.Text) + Convert.ToInt32(qty.Text);
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
                MessageBox.Show(
                    "Please make sure that you've selected a product before introducing the quantity!");
            }
            else if (string.IsNullOrEmpty(qty.Text))
            {
                o_val.Text = "0";
            }
        }

        private void addValues_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.CheckPurchaseOrders();
        }
    }
}
