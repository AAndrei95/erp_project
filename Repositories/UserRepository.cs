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
        
        // Updates the password for a user in the database based on their username.
        public void UpdatePassword(string username, string passwordHash)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "UPDATE Users SET Password = @password WHERE Username = @username;",
                connection);

            command.Parameters.AddWithValue("@password", passwordHash);
            command.Parameters.AddWithValue("@username", username);

            command.ExecuteNonQuery();
        }

        // Gets the security question answer for a user by username from the database and returns it as a string.
        public string? GetSecurityQuestionAnswer(string username)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "SELECT SQAnswer FROM Users WHERE Username = @username;",
                connection);

            command.Parameters.AddWithValue("@username", username);

            object result = command.ExecuteScalar();

            return result?.ToString();
        }

        // Gets the position for a user by username from the database and returns it as a string.
        public string? GetPosition(string username)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "SELECT Position FROM Users WHERE Username = @username;",
                connection);

            command.Parameters.AddWithValue("@username", username);

            object result = command.ExecuteScalar();

            return result?.ToString();
        }

        // Gets all users from the database and returns a list of dictionaries, where each dictionary represents a user with their column names as keys and corresponding values.
        public List<Dictionary<string, object>> GetUsers()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "SELECT * FROM Users;",
                connection);

            using SQLiteDataReader reader = command.ExecuteReader();

            var users = new List<Dictionary<string, object>>();

            while (reader.Read())
            {
                var user = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    user[reader.GetName(i)] = reader.GetValue(i);
                }

                users.Add(user);
            }
            return users;
        }

        // Adds a new user to the database with the provided details.
        public void AddUser(
            string position,
            string username,
            string passwordHash,
            string dob,
            string sex,
            string email,
            string phoneNumber,
            string securityQuestion,
            string securityAnswer)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "INSERT INTO Users " +
                "(Position, Username, Password, DoB, Sex, Email, PhoneNumber, SecurityQuestion, SQAnswer) " +
                "VALUES (@position, @username, @password, @dob, @sex, @email, @phoneNumber, @securityQuestion, @sqAnswer);",
                connection);

            command.Parameters.AddWithValue("@position", position);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", passwordHash);
            command.Parameters.AddWithValue("@dob", dob);
            command.Parameters.AddWithValue("@sex", sex);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@securityQuestion", securityQuestion);
            command.Parameters.AddWithValue("@sqAnswer", securityAnswer);

            command.ExecuteNonQuery();
        }

        // Removes a user from the database based on their user ID.
        public void RemoveUser(int userId)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "DELETE FROM Users WHERE UserId = @userId;",
                connection);

            command.Parameters.AddWithValue("@userId", userId);

            command.ExecuteNonQuery();
        }

        // Modifies the details of an existing user in the database based on their user ID.
        public void ModifyUser(
            int userId,
            string position,
            string username,
            string passwordHash,
            object dob,
            string sex,
            string email,
            string phoneNumber,
            string securityQuestion,
            string securityAnswer)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(
                "UPDATE Users SET " +
                "Position = @position, " +
                "Username = @username, " +
                "Password = @password, " +
                "DoB = @dob, " +
                "Sex = @sex, " +
                "Email = @email, " +
                "PhoneNumber = @phoneNumber, " +
                "SecurityQuestion = @securityQuestion, " +
                "SQAnswer = @sqAnswer " +
                "WHERE UserId = @userId;",
                connection);

            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@position", position);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", passwordHash);
            command.Parameters.AddWithValue("@dob", dob);
            command.Parameters.AddWithValue("@sex", sex);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@securityQuestion", securityQuestion);
            command.Parameters.AddWithValue("@sqAnswer", securityAnswer);

            command.ExecuteNonQuery();
        }
    }
}
