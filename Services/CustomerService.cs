using Digital_Shop_Software.Repositories;

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
    }
}
