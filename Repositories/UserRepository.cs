using System.Data.SQLite;

namespace Digital_Shop_Software.Repositories
{
    internal class UserRepository
    {
        // Gets the user by username from the database and returns a tuple containing the username and password.
        public (string Username, string Password)? GetUserByUsername(string username)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "SELECT Username, Password FROM Users WHERE Username = @username;",
                connection);

            command.Parameters.AddWithValue("@username", username);

            using SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string dbUsername = reader["Username"].ToString() ?? "";
                string dbPassword = reader["Password"].ToString() ?? "";

                return (dbUsername, dbPassword);
            }
            
            return null;
        }
    
        // Gets the user ID by username from the database and returns it as an integer.  
        public int GetUserId(string username)
            {
                using SQLiteConnection connection = Database.CreateConnection();
                connection.Open();

                using SQLiteCommand command = new SQLiteCommand(
                    "SELECT UserId FROM Users WHERE Username = @username;",
                    connection);

                command.Parameters.AddWithValue("@username", username);

                object result = command.ExecuteScalar();

                return Convert.ToInt32(result);
            }
    }
}
