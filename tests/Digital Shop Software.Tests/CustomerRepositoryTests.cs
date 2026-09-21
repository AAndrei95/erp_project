using Digital_Shop_Software.Data.Repositories;
using Xunit;

namespace Digital_Shop_Software.Tests
{
    public class CustomerRepositoryTests
    {
        [Fact]
        public void AddCustomer_ShouldAllowCustomerToBeRetrieved()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository userRepository = new UserRepository();
                CustomerRepository customerRepository = new CustomerRepository();

                userRepository.AddUser(
                    "Admin",
                    "testuser",
                    "TestPasswordHash",
                    "20000101",
                    "M",
                    "test@example.com",
                    "01234567890",
                    "What is your favourite colour?",
                    "Blue");

                int userId = userRepository.GetUserId("testuser");

                customerRepository.AddCustomer(
                    "customer@example.com",
                    "07123456789",
                    1,
                    20260921,
                    20260921,
                    userId);

                List<Dictionary<string, object>> customers =
                    customerRepository.GetCustomers();

                Assert.Single(customers);
                Assert.Equal(
                    "customer@example.com",
                    customers[0]["Email"].ToString());
                Assert.Equal(
                    "07123456789",
                    customers[0]["PhoneNumber"].ToString());
                Assert.Equal(
                    "testuser",
                    customers[0]["Username"].ToString());
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void GetClientIds_ShouldReturnCustomerIds()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository userRepository = new UserRepository();
                CustomerRepository customerRepository = new CustomerRepository();

                userRepository.AddUser(
                    "Admin",
                    "testuser",
                    "TestPasswordHash",
                    "20000101",
                    "M",
                    "test@example.com",
                    "01234567890",
                    "What is your favourite colour?",
                    "Blue");

                int userId = userRepository.GetUserId("testuser");

                customerRepository.AddCustomer(
                    "customer@example.com",
                    "07123456789",
                    1,
                    20260921,
                    20260921,
                    userId);

                List<int> clientIds = customerRepository.GetClientIds();

                Assert.Single(clientIds);
                Assert.True(clientIds[0] > 0);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }
        
        [Fact]
        public void ModifyCustomer_ShouldUpdateCustomer()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository userRepository = new UserRepository();
                CustomerRepository customerRepository = new CustomerRepository();

                userRepository.AddUser(
                    "Admin",
                    "testuser",
                    "TestPasswordHash",
                    "20000101",
                    "M",
                    "test@example.com",
                    "01234567890",
                    "What is your favourite colour?",
                    "Blue");

                int userId = userRepository.GetUserId("testuser");

                customerRepository.AddCustomer(
                    "customer@example.com",
                    "07123456789",
                    1,
                    20260921,
                    20260921,
                    userId);

                List<int> clientIds = customerRepository.GetClientIds();
                int clientId = clientIds[0];

                customerRepository.ModifyCustomer(
                    clientId,
                    "updated@example.com",
                    "07987654321",
                    0,
                    20260920,
                    20260922,
                    userId);

                List<Dictionary<string, object>> customers =
                    customerRepository.GetCustomers();

                Assert.Single(customers);
                Assert.Equal(
                    "updated@example.com",
                    customers[0]["Email"].ToString());
                Assert.Equal(
                    "07987654321",
                    customers[0]["PhoneNumber"].ToString());
                Assert.Equal(
                    "0",
                    customers[0]["Registered"].ToString());
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void RemoveCustomer_ShouldRemoveCustomer()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository userRepository = new UserRepository();
                CustomerRepository customerRepository = new CustomerRepository();

                userRepository.AddUser(
                    "Admin",
                    "testuser",
                    "TestPasswordHash",
                    "20000101",
                    "M",
                    "test@example.com",
                    "01234567890",
                    "What is your favourite colour?",
                    "Blue");

                int userId = userRepository.GetUserId("testuser");

                customerRepository.AddCustomer(
                    "customer@example.com",
                    "07123456789",
                    1,
                    20260921,
                    20260921,
                    userId);

                int clientId = customerRepository.GetClientIds()[0];

                customerRepository.RemoveCustomer(clientId);

                List<Dictionary<string, object>> customers =
                    customerRepository.GetCustomers();

                Assert.Empty(customers);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }
    }
}
