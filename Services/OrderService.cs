using Digital_Shop_Software.Repositories;

namespace Digital_Shop_Software.Services
{
    internal class OrderService
    {
        private readonly OrderRepository orderRepository;

        public OrderService()
        {
            orderRepository = new OrderRepository();
        }

        public List<Dictionary<string, object>> GetClientOrders()
        {
            return orderRepository.GetClientOrders();
        }

        public List<Dictionary<string, object>> GetPurchaseOrders()
        {
            return orderRepository.GetPurchaseOrders();
        }

        public void AddCustomerOrder(
            int orderQty,
            int clientId,
            int productId,
            decimal value)
        {
            orderRepository.AddCustomerOrder(
                orderQty,
                clientId,
                productId,
                value);
        }

        public void UpdateClientLastOrder(
            int clientId,
            int lastOrder)
        {
            orderRepository.UpdateClientLastOrder(
                clientId,
                lastOrder);
        }

        public void UpdateProductQuantity(
            int productId,
            int quantity)
        {
            orderRepository.UpdateProductQuantity(
                productId,
                quantity);
        }

        public void RemoveCustomerOrder(int orderId)
        {
            orderRepository.RemoveCustomerOrder(orderId);
        }

        public void ModifyCustomerOrder(
            int orderId,
            int orderQty,
            int clientId,
            decimal value)
        {
            orderRepository.ModifyCustomerOrder(
                orderId,
                orderQty,
                clientId,
                value);
        }

        public void AddPurchaseOrder(
            int poNumber,
            int poDate,
            int qty,
            decimal poValue,
            int productId,
            int tbdDate)
        {
            orderRepository.AddPurchaseOrder(
                poNumber,
                poDate,
                qty,
                poValue,
                productId,
                tbdDate);
        }

        public void UpdateProductStock(
            int productId,
            int quantity,
            int onOrder,
            int onOrderQty,
            int deliveryDate)
        {
            orderRepository.UpdateProductStock(
                productId,
                quantity,
                onOrder,
                onOrderQty,
                deliveryDate);
        }

        public int GetNextPONumber()
        {
            return orderRepository.GetNextPONumber();
        }

        public void RemovePurchaseOrder(int poId)
        {
            orderRepository.RemovePurchaseOrder(poId);
        }

        public void ModifyPurchaseOrder(
            int poId,
            int poDate,
            int qty,
            decimal poValue,
            int tbdDate)
        {
            orderRepository.ModifyPurchaseOrder(
                poId,
                poDate,
                qty,
                poValue,
                tbdDate);
        }
    }
}
