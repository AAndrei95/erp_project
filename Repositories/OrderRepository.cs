using System.Data.SQLite;

namespace Digital_Shop_Software.Repositories
{
    internal class OrderRepository
    {
        // Gets client orders from the database
        public List<Dictionary<string, object>> GetClientOrders()
        {
            List<Dictionary<string, object>> orders = new List<Dictionary<string, object>>();

            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "SELECT " +
                "\"Client Orders\".Id, " +
                "Client.ClientId, " +
                "Client.Email, " +
                "Client.PhoneNumber, " +
                "Product.Name, " +
                "\"Client Orders\".OrderQty, " +
                "\"Client Orders\".Value, " +
                "Client.Registered " +
                "FROM \"Client Orders\" " +
                "INNER JOIN Client ON Client.ClientId = \"Client Orders\".fk_ClientId " +
                "INNER JOIN Product ON Product.ProductId = \"Client Orders\".fk_ProductId;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            using SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Dictionary<string, object> order = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    order[reader.GetName(i)] = reader.GetValue(i);
                }

                orders.Add(order);
            }

            return orders;
        }

        // Gets purchase orders from the database.
        public List<Dictionary<string, object>> GetPurchaseOrders()
        {
            List<Dictionary<string, object>> orders = new List<Dictionary<string, object>>();

            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "SELECT " +
                "\"Purchase Orders\".POId, " +
                "\"Purchase Orders\".PONumber, " +
                "\"Purchase Orders\".PODate, " +
                "Product.Name, " +
                "\"Purchase Orders\".Qty, " +
                "Product.SupplierPrice, " +
                "\"Purchase Orders\".POValue, " +
                "\"Purchase Orders\".TBDDate " +
                "FROM \"Purchase Orders\" " +
                "INNER JOIN Product ON Product.ProductId = \"Purchase Orders\".fk_ProductId;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            using SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Dictionary<string, object> order = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    order[reader.GetName(i)] = reader.GetValue(i);
                }

                orders.Add(order);
            }

            return orders;
        }

        // Adds a new client order to the database with the provided details.
        public void AddCustomerOrder(
            int orderQty,
            int clientId,
            int productId,
            decimal value)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "INSERT INTO \"Client Orders\" " +
                "(OrderQty, fk_clientId, fk_productId, Value) " +
                "VALUES (@orderQty, @clientId, @productId, @value);";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@orderQty", orderQty);
            command.Parameters.AddWithValue("@clientId", clientId);
            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@value", value);

            command.ExecuteNonQuery();
        }

       // Modifies the last order field of an existing client in the database based on the client ID.
        public void UpdateClientLastOrder(int clientId, int lastOrder)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "UPDATE Client SET " +
                "LastOrder = @lastOrder " +
                "WHERE ClientId = @clientId;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@lastOrder", lastOrder);
            command.Parameters.AddWithValue("@clientId", clientId);

            command.ExecuteNonQuery();
        }

        // Updates the product quanitity in the database.
        public void UpdateProductQuantity(int productId, int quantity)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "UPDATE Product SET " +
                "Qty = @qty " +
                "WHERE ProductId = @productId;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@qty", quantity);
            command.Parameters.AddWithValue("@productId", productId);

            command.ExecuteNonQuery();
        }

        // Removes a customer order from the database based on the order ID.
        public void RemoveCustomerOrder(int orderId)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "DELETE FROM \"Client Orders\" " +
                "WHERE Id = @id;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@id", orderId);

            command.ExecuteNonQuery();
        }

        // Modifies the details of an existing client order in the database.
        public void ModifyCustomerOrder(
            int orderId,
            int orderQty,
            int clientId,
            decimal value)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "UPDATE \"Client Orders\" SET " +
                "OrderQty = @orderQty, " +
                "ClientId = @clientId, " +
                "Value = @value " +
                "WHERE Id = @id;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@id", orderId);
            command.Parameters.AddWithValue("@orderQty", orderQty);
            command.Parameters.AddWithValue("@clientId", clientId);
            command.Parameters.AddWithValue("@value", value);

            command.ExecuteNonQuery();
        }

        // Adds a new purchase order to the database with the provided details.
        public void AddPurchaseOrder(
            int poNumber,
            int poDate,
            int qty,
            decimal poValue,
            int productId,
            int tbdDate)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "INSERT INTO \"Purchase Orders\" " +
                "(PONumber, PODate, Qty, POValue, fk_productId, TBDDate) " +
                "VALUES (@poNumber, @poDate, @qty, @poValue, @productId, @tbdDate);";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@poNumber", poNumber);
            command.Parameters.AddWithValue("@poDate", poDate);
            command.Parameters.AddWithValue("@qty", qty);
            command.Parameters.AddWithValue("@poValue", poValue);
            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@tbdDate", tbdDate);

            command.ExecuteNonQuery();
        }

        // Modifies the details of an existing product in the database.
        public void UpdateProductStock(
            int productId,
            int quantity,
            int onOrder,
            int onOrderQty,
            int deliveryDate)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "UPDATE Product SET " +
                "Qty = @qty, " +
                "OnOrder = @onOrder, " +
                "OnOrderQty = @onOrderQty, " +
                "DeliveryDate = @deliveryDate " +
                "WHERE ProductId = @productId;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@qty", quantity);
            command.Parameters.AddWithValue("@onOrder", onOrder);
            command.Parameters.AddWithValue("@onOrderQty", onOrderQty);
            command.Parameters.AddWithValue("@deliveryDate", deliveryDate);
            command.Parameters.AddWithValue("@productId", productId);

            command.ExecuteNonQuery();
        }

        // Generates the last next PO number.
        public int GetNextPONumber()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "SELECT PONumber " +
                "FROM \"Purchase Orders\" " +
                "ORDER BY PONumber DESC " +
                "LIMIT 1;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            object result = command.ExecuteScalar();

            if (result == null || result == DBNull.Value)
            {
                return 1;
            }

            return Convert.ToInt32(result) + 1;
        }

        // Removes a purchase order from the database.
        public void RemovePurchaseOrder(int poId)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "DELETE FROM \"Purchase Orders\" " +
                "WHERE POId = @poId;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@poId", poId);

            command.ExecuteNonQuery();
        }

        // Modifies the details of an existing purchase order in the database based.
        public void ModifyPurchaseOrder(
            int poId,
            int poDate,
            int qty,
            decimal poValue,
            int tbdDate)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string query =
                "UPDATE \"Purchase Orders\" SET " +
                "PODate = @poDate, " +
                "Qty = @qty, " +
                "POValue = @poValue, " +
                "TBDDate = @tbdDate " +
                "WHERE POId = @poId;";

            using SQLiteCommand command = new SQLiteCommand(query, connection);

            command.Parameters.AddWithValue("@poId", poId);
            command.Parameters.AddWithValue("@poDate", poDate);
            command.Parameters.AddWithValue("@qty", qty);
            command.Parameters.AddWithValue("@poValue", poValue);
            command.Parameters.AddWithValue("@tbdDate", tbdDate);

            command.ExecuteNonQuery();
        }
    }
}
