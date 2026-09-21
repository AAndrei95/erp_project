using Digital_Shop_Software.Data.Repositories;

namespace Digital_Shop_Software.Services
{
    internal class CustomerService
    {
        private readonly CustomerRepository customerRepository;
        private readonly UserRepository userRepository;

        public CustomerService()
        {
            customerRepository = new CustomerRepository();
            userRepository = new UserRepository();
        }

        public List<Dictionary<string, object>> GetCustomers()
        {
            return customerRepository.GetCustomers();
        }

        public void AddCustomer(
            string email,
            string phoneNumber,
            int registered,
            int orderDate,
            int lastOrder,
            string username)
        {
            int userId = userRepository.GetUserId(username);

            customerRepository.AddCustomer(
                email,
                phoneNumber,
                registered,
                orderDate,
                lastOrder,
                userId);
        }

        public List<int> GetClientIds()
        {
            return customerRepository.GetClientIds();
        }

        public void RemoveCustomer(int customerId)
        {
            customerRepository.RemoveCustomer(customerId);
        }

        public void ModifyCustomer(
            int clientId,
            string email,
            string phoneNumber,
            object registered,
            object orderDate,
            object lastOrder,
            string username)
        {
            int userId = userRepository.GetUserId(username);

            customerRepository.ModifyCustomer(
                clientId,
                email,
                phoneNumber,
                registered,
                orderDate,
                lastOrder,
                userId);
        }
    }
}
