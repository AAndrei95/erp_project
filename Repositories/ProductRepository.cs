using System.Data.SQLite;

namespace Digital_Shop_Software.Repositories
{
    internal class ProductRepository
    {
        // Method to retrieve all products from the database.  
        public List<Dictionary<string, object>> GetProducts()
        {
            List<Dictionary<string, object>> products =
                new List<Dictionary<string, object>>();

            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "SELECT " +
                "Product.ProductId, " +
                "Product.Name, " +
                "Product.Category, " +
                "Product.Description, " +
                "Product.SupplierPrice, " +
                "Product.SalePrice, " +
                "Product.Qty, " +
                "Product.OnOrder, " +
                "Product.OnOrderQty, " +
                "Product.DeliveryDate, " +
                "Supplier.SupplierName, " +
                "Users.Username " +
                "FROM Product " +
                "INNER JOIN Users ON Users.UserId = Product.fk_UserId " +
                "INNER JOIN Supplier ON Supplier.SupplierId = Product.fk_SupplierId;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            using SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Dictionary<string, object> product =
                    new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    product[reader.GetName(i)] = reader.GetValue(i);
                }

                products.Add(product);
            }

            return products;
        }

        // Gets the supplier ID by username from the database and returns it as an integer.  
        public int GetSupplierId(string supplierName)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "SELECT SupplierId " +
                "FROM Supplier " +
                "WHERE SupplierName = @supplierName;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@supplierName", supplierName);

            object result = command.ExecuteScalar();

            return Convert.ToInt32(result);
        }

        // Adds a new product to the database with the provided details.
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
            int supplierId,
            int userId)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "INSERT INTO Product " +
                "(Name, Category, Description, SupplierPrice, SalePrice, Qty, " +
                "OnOrder, OnOrderQty, DeliveryDate, fk_SupplierId, fk_UserId) " +
                "VALUES " +
                "(@name, @category, @description, @supplierPrice, @salePrice, " +
                "@qty, @onOrder, @onOrderQty, @deliveryDate, @supplierId, @userId);";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@category", category);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@supplierPrice", supplierPrice);
            command.Parameters.AddWithValue("@salePrice", salePrice);
            command.Parameters.AddWithValue("@qty", qty);
            command.Parameters.AddWithValue("@onOrder", onOrder);
            command.Parameters.AddWithValue("@onOrderQty", onOrderQty);
            command.Parameters.AddWithValue("@deliveryDate", deliveryDate);
            command.Parameters.AddWithValue("@supplierId", supplierId);
            command.Parameters.AddWithValue("@userId", userId);

            command.ExecuteNonQuery();
        }

        // Removes a product from the database based on the product ID.
        public void RemoveProduct(int productId)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "DELETE FROM Product " +
                "WHERE ProductId = @productId;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@productId", productId);

            command.ExecuteNonQuery();
        }

        // Modifies the details of an existing product in the database based on the product ID.
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
            int userId)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "UPDATE Product SET " +
                "Name = @name, " +
                "Category = @category, " +
                "Description = @description, " +
                "SupplierPrice = @supplierPrice, " +
                "SalePrice = @salePrice, " +
                "Qty = @qty, " +
                "OnOrder = @onOrder, " +
                "OnOrderQty = @onOrderQty, " +
                "DeliveryDate = @deliveryDate, " +
                "fk_UserId = @userId " +
                "WHERE ProductId = @productId;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@category", category);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@supplierPrice", supplierPrice);
            command.Parameters.AddWithValue("@salePrice", salePrice);
            command.Parameters.AddWithValue("@qty", qty);
            command.Parameters.AddWithValue("@onOrder", onOrder);
            command.Parameters.AddWithValue("@onOrderQty", onOrderQty);
            command.Parameters.AddWithValue("@deliveryDate", deliveryDate);
            command.Parameters.AddWithValue("@userId", userId);

            command.ExecuteNonQuery();
        }
    }
}
