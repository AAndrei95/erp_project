using Digital_Shop_Software.Repositories;

namespace Digital_Shop_Software.Services
{
    internal class ProductService
    {
        private readonly ProductRepository productRepository;
        private readonly UserRepository userRepository;

        public ProductService()
        {
            productRepository = new ProductRepository();
            userRepository = new UserRepository();
        }

        public List<Dictionary<string, object>> GetProducts()
        {
            return productRepository.GetProducts();
        }

        public void AddProduct(
            string name,
            string category,
            string description,
            decimal supplierPrice,
            decimal salePrice,
            int qty,
            int onOrder,
            int onOrderQty,
            int deliveryDate,
            string supplierName,
            string username)
        {
            int supplierId = productRepository.GetSupplierId(supplierName);
            int userId = userRepository.GetUserId(username);

            productRepository.AddProduct(
                name,
                category,
                description,
                supplierPrice,
                salePrice,
                qty,
                onOrder,
                onOrderQty,
                deliveryDate,
                supplierId,
                userId);
        }

        public void RemoveProduct(int productId)
        {
            productRepository.RemoveProduct(productId);
        }

        public void ModifyProduct(
            int productId,
            string name,
            string category,
            string description,
            decimal supplierPrice,
            decimal salePrice,
            int qty,
            int onOrder,
            int onOrderQty,
            int deliveryDate,
            string username)
        {
            int userId = userRepository.GetUserId(username);

            productRepository.ModifyProduct(
                productId,
                name,
                category,
                description,
                supplierPrice,
                salePrice,
                qty,
                onOrder,
                onOrderQty,
                deliveryDate,
                userId);
        }
    }
}
