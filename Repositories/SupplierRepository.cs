using System.Data.SQLite;

namespace Digital_Shop_Software.Repositories
{
    internal class SupplierRepository
    {
        // Method to retrieve all suppliers from the database.       
        public List<Dictionary<string, object>> GetSuppliers()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "SELECT " +
                "SupplierId, " +
                "SupplierName, " +
                "Description, " +
                "Email, " +
                "PhoneNumber, " +
                "Representative " +
                "FROM Supplier;",
                connection);

            using SQLiteDataReader reader = command.ExecuteReader();

            var suppliers = new List<Dictionary<string, object>>();

            while (reader.Read())
            {
                var supplier = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    supplier[reader.GetName(i)] = reader.GetValue(i);
                }

                suppliers.Add(supplier);
            }

            return suppliers;
        }

        // Adds a new supplier to the database with the provided details.
        public void AddSupplier(
            string supplierName,
            string description,
            string email,
            string phoneNumber,
            string representative)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "INSERT INTO Supplier " +
                "(SupplierName, Description, Email, PhoneNumber, Representative) " +
                "VALUES (@supplierName, @description, @email, @phoneNumber, @representative);",
                connection);

            command.Parameters.AddWithValue("@supplierName", supplierName);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@representative", representative);

            command.ExecuteNonQuery();
        }

        // Removes a supplier from the database based on their supplier ID.
        public void RemoveSupplier(int supplierId)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "DELETE FROM Supplier WHERE SupplierId = @supplierId;",
                connection);

            command.Parameters.AddWithValue("@supplierId", supplierId);

            command.ExecuteNonQuery();
        }

        // Modifies the details of an existing supplier in the database based on their supplier ID.
        public void ModifySupplier(
            int supplierId,
            object supplierName,
            object description,
            object email,
            object phoneNumber,
            object representative)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "UPDATE Supplier SET " +
                "SupplierName = @supplierName, " +
                "Description = @description, " +
                "Email = @email, " +
                "PhoneNumber = @phoneNumber, " +
                "Representative = @representative " +
                "WHERE SupplierId = @supplierId;",
                connection);

            command.Parameters.AddWithValue("@supplierId", supplierId);
            command.Parameters.AddWithValue("@supplierName", supplierName);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@representative", representative);

            command.ExecuteNonQuery();
        }
    }
}
