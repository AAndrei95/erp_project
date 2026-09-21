using Digital_Shop_Software.Data.Repositories;
using Xunit;

namespace Digital_Shop_Software.Tests
{
    public class ProductRepositoryTests
    {
        [Fact]
        public void AddProduct_ShouldAllowProductToBeRetrieved()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository userRepository = new UserRepository();
                ProductRepository productRepository = new ProductRepository();

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

                using (var connection = Digital_Shop_Software.Data.Database.CreateConnection())
                {
                    connection.Open();

                    using var command = new System.Data.SQLite.SQLiteCommand(
                        "INSERT INTO Supplier (SupplierName, Description, Email, PhoneNumber, Representative) " +
                        "VALUES ('Test Supplier', 'Test Description', 'supplier@example.com', '07111111111', 'Test Rep');",
                        connection);

                    command.ExecuteNonQuery();
                }

                int supplierId;

                using (var connection = Digital_Shop_Software.Data.Database.CreateConnection())
                {
                    connection.Open();

                    using var command = new System.Data.SQLite.SQLiteCommand(
                        "SELECT SupplierId FROM Supplier WHERE SupplierName = 'Test Supplier';",
                        connection);

                    supplierId = Convert.ToInt32(command.ExecuteScalar());
                }

                productRepository.AddProduct(
                    "Test Product",
                    "Test Category",
                    "Test Description",
                    10.50m,
                    15.99m,
                    20,
                    0,
                    0,
                    20260921,
                    supplierId,
                    userId);

                List<Dictionary<string, object>> products =
                    productRepository.GetProducts();

                Assert.Single(products);
                Assert.Equal("Test Product", products[0]["Name"].ToString());
                Assert.Equal("Test Category", products[0]["Category"].ToString());
                Assert.Equal("Test Supplier", products[0]["SupplierName"].ToString());
                Assert.Equal("testuser", products[0]["Username"].ToString());
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void GetSupplierId_ShouldReturnCorrectSupplierId()
        {
            TestDatabase.Initialize();

            try
            {
                ProductRepository productRepository = new ProductRepository();

                using (var connection = Digital_Shop_Software.Data.Database.CreateConnection())
                {
                    connection.Open();

                    using var command = new System.Data.SQLite.SQLiteCommand(
                        "INSERT INTO Supplier " +
                        "(SupplierName, Description, Email, PhoneNumber, Representative) " +
                        "VALUES ('Test Supplier', 'Test Description', 'supplier@example.com', '07111111111', 'Test Rep');",
                        connection);

                    command.ExecuteNonQuery();
                }

                int supplierId = productRepository.GetSupplierId("Test Supplier");

                Assert.True(supplierId > 0);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void GetProductIds_ShouldReturnProductIds()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository userRepository = new UserRepository();
                ProductRepository productRepository = new ProductRepository();

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

                int supplierId;

                using (var connection = Digital_Shop_Software.Data.Database.CreateConnection())
                {
                    connection.Open();

                    using var command = new System.Data.SQLite.SQLiteCommand(
                        "INSERT INTO Supplier " +
                        "(SupplierName, Description, Email, PhoneNumber, Representative) " +
                        "VALUES ('Test Supplier', 'Test Description', 'supplier@example.com', '07111111111', 'Test Rep');",
                        connection);

                    command.ExecuteNonQuery();

                    using var idCommand = new System.Data.SQLite.SQLiteCommand(
                        "SELECT SupplierId FROM Supplier WHERE SupplierName = 'Test Supplier';",
                        connection);

                    supplierId = Convert.ToInt32(idCommand.ExecuteScalar());
                }

                productRepository.AddProduct(
                    "Test Product",
                    "Test Category",
                    "Test Description",
                    10.50m,
                    15.99m,
                    20,
                    0,
                    0,
                    20260921,
                    supplierId,
                    userId);

                List<int> productIds = productRepository.GetProductIds();

                Assert.Single(productIds);
                Assert.True(productIds[0] > 0);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void GetProductById_ShouldReturnCorrectProduct()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository userRepository = new UserRepository();
                ProductRepository productRepository = new ProductRepository();

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

                int supplierId;

                using (var connection = Digital_Shop_Software.Data.Database.CreateConnection())
                {
                    connection.Open();

                    using var command = new System.Data.SQLite.SQLiteCommand(
                        "INSERT INTO Supplier " +
                        "(SupplierName, Description, Email, PhoneNumber, Representative) " +
                        "VALUES ('Test Supplier', 'Test Description', 'supplier@example.com', '07111111111', 'Test Rep');",
                        connection);

                    command.ExecuteNonQuery();

                    using var idCommand = new System.Data.SQLite.SQLiteCommand(
                        "SELECT SupplierId FROM Supplier WHERE SupplierName = 'Test Supplier';",
                        connection);

                    supplierId = Convert.ToInt32(idCommand.ExecuteScalar());
                }

                productRepository.AddProduct(
                    "Test Product",
                    "Test Category",
                    "Test Description",
                    10.50m,
                    15.99m,
                    20,
                    0,
                    0,
                    20260921,
                    supplierId,
                    userId);

                int productId = productRepository.GetProductIds()[0];

                Dictionary<string, object>? product =
                    productRepository.GetProductById(productId);

                Assert.NotNull(product);
                Assert.Equal("Test Product", product["Name"].ToString());
                Assert.Equal("Test Category", product["Category"].ToString());
                Assert.Equal("20", product["Qty"].ToString());
                Assert.Equal("10.5", product["SupplierPrice"].ToString());
                Assert.Equal("15.99", product["SalePrice"].ToString());
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void GetProductById_ShouldReturnNullForUnknownProduct()
        {
            TestDatabase.Initialize();

            try
            {
                ProductRepository productRepository = new ProductRepository();

                Dictionary<string, object>? product =
                    productRepository.GetProductById(999999);

                Assert.Null(product);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void ModifyProduct_ShouldUpdateProduct()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository userRepository = new UserRepository();
                ProductRepository productRepository = new ProductRepository();

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

                int supplierId;

                using (var connection = Digital_Shop_Software.Data.Database.CreateConnection())
                {
                    connection.Open();

                    using var command = new System.Data.SQLite.SQLiteCommand(
                        "INSERT INTO Supplier " +
                        "(SupplierName, Description, Email, PhoneNumber, Representative) " +
                        "VALUES ('Test Supplier', 'Test Description', 'supplier@example.com', '07111111111', 'Test Rep');",
                        connection);

                    command.ExecuteNonQuery();

                    using var idCommand = new System.Data.SQLite.SQLiteCommand(
                        "SELECT SupplierId FROM Supplier WHERE SupplierName = 'Test Supplier';",
                        connection);

                    supplierId = Convert.ToInt32(idCommand.ExecuteScalar());
                }

                productRepository.AddProduct(
                    "Original Product",
                    "Original Category",
                    "Original Description",
                    10.50m,
                    15.99m,
                    20,
                    0,
                    0,
                    20260921,
                    supplierId,
                    userId);

                int productId = productRepository.GetProductIds()[0];

                productRepository.ModifyProduct(
                    productId,
                    "Updated Product",
                    "Updated Category",
                    "Updated Description",
                    12.50m,
                    19.99m,
                    30,
                    1,
                    5,
                    20260925,
                    userId);

                Dictionary<string, object>? product =
                    productRepository.GetProductById(productId);

                Assert.NotNull(product);
                Assert.Equal("Updated Product", product["Name"].ToString());
                Assert.Equal("Updated Category", product["Category"].ToString());
                Assert.Equal("Updated Description", product["Description"].ToString());
                Assert.Equal("30", product["Qty"].ToString());
                Assert.Equal("12.5", product["SupplierPrice"].ToString());
                Assert.Equal("19.99", product["SalePrice"].ToString());
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }

        [Fact]
        public void RemoveProduct_ShouldRemoveProduct()
        {
            TestDatabase.Initialize();

            try
            {
                UserRepository userRepository = new UserRepository();
                ProductRepository productRepository = new ProductRepository();

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

                int supplierId;

                using (var connection = Digital_Shop_Software.Data.Database.CreateConnection())
                {
                    connection.Open();

                    using var command = new System.Data.SQLite.SQLiteCommand(
                        "INSERT INTO Supplier " +
                        "(SupplierName, Description, Email, PhoneNumber, Representative) " +
                        "VALUES ('Test Supplier', 'Test Description', 'supplier@example.com', '07111111111', 'Test Rep');",
                        connection);

                    command.ExecuteNonQuery();

                    using var idCommand = new System.Data.SQLite.SQLiteCommand(
                        "SELECT SupplierId FROM Supplier WHERE SupplierName = 'Test Supplier';",
                        connection);

                    supplierId = Convert.ToInt32(idCommand.ExecuteScalar());
                }

                productRepository.AddProduct(
                    "Test Product",
                    "Test Category",
                    "Test Description",
                    10.50m,
                    15.99m,
                    20,
                    0,
                    0,
                    20260921,
                    supplierId,
                    userId);

                int productId = productRepository.GetProductIds()[0];

                productRepository.RemoveProduct(productId);

                List<int> productIds = productRepository.GetProductIds();

                Assert.Empty(productIds);
            }
            finally
            {
                TestDatabase.Cleanup();
            }
        }
    }
}
