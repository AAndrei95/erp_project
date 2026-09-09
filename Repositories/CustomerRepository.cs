using System.Data.SQLite;

namespace Digital_Shop_Software.Repositories
{
    internal class CustomerRepository
    {

        // Method to retrieve all customers from the database.
        public List<Dictionary<string, object>> GetCustomers()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "SELECT " +
                "CLIENT.ClientId, " +
                "CLIENT.Email, " +
                "CLIENT.PhoneNumber, " +
                "CLIENT.Registered, " +
                "CLIENT.OrderDate, " +
                "CLIENT.LastOrder, " +
                "USERS.Username " +
                "FROM CLIENT " +
                "INNER JOIN USERS ON USERS.USERID = CLIENT.USERID;",
                connection);

            using SQLiteDataReader reader = command.ExecuteReader();

            var customers = new List<Dictionary<string, object>>();

            while (reader.Read())
            {
                var customer = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    customer[reader.GetName(i)] = reader.GetValue(i);
                }

                customers.Add(customer);
            }
            return customers;
        }

        // Adds customer into the Client table.
        public void AddCustomer(
            string email,
            string phoneNumber,
            int registered,
            int orderDate,
            int lastOrder,
            int userId)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "INSERT INTO Client " +
                "(Email, PhoneNumber, Registered, OrderDate, LastOrder, UserId) " +
                "VALUES (@email, @phoneNumber, @registered, @orderDate, @lastOrder, @userId);",
                connection);

            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@registered", registered);
            command.Parameters.AddWithValue("@orderDate", orderDate);
            command.Parameters.AddWithValue("@lastOrder", lastOrder);
            command.Parameters.AddWithValue("@userId", userId);

            command.ExecuteNonQuery();
        }

        // Gets all client ids from the database and returns them as an integers.
        public List<int> GetClientIds()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "SELECT ClientId FROM Client;",
                connection);

            using SQLiteDataReader reader = command.ExecuteReader();

            List<int> clientIds = new List<int>();

            while (reader.Read())
            {
                clientIds.Add(reader.GetInt32(
                    reader.GetOrdinal("ClientId")));
            }

            return clientIds;
        }

        // Removes a customer from the database based on the clientId.
        public void RemoveCustomer(int clientId)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "DELETE FROM Client WHERE ClientId = @clientId;",
                connection);

            command.Parameters.AddWithValue("@clientId", clientId);

            command.ExecuteNonQuery();
        }

        // Modifies the details of an existing client in the database based on their client ID.
        public void ModifyCustomer(
            int clientId,
            string email,
            string phoneNumber,
            object registered,
            object orderDate,
            object lastOrder,
            int userId)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "UPDATE CLIENT SET " +
                "email = @email, " +
                "phonenumber = @phoneNumber, " +
                "registered = @registered, " +
                "OrderDate = @orderDate, " +
                "lastorder = @lastOrder, " +
                "userid = @userId " +
                "WHERE clientid = @clientId;",
                connection);

            command.Parameters.AddWithValue("@clientId", clientId);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@registered", registered);
            command.Parameters.AddWithValue("@orderDate", orderDate);
            command.Parameters.AddWithValue("@lastOrder", lastOrder);
            command.Parameters.AddWithValue("@userId", userId);

            command.ExecuteNonQuery();
        }
    }
}