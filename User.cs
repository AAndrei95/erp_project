using System.Data.SQLite;

namespace Digital_Shop_Software
{
    internal class User
    {
        // Checking Credentials methods
        int dob;
        public string userId;
        public string position;
        public void CheckCredentials(string username, string password)
        {
            // Opening database connection
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            var db_username = "";
            var db_password = "";
            // Setting the command
            string db_user = "Select Username, Password from Users where Username =@username;";

            SQLiteCommand command = new SQLiteCommand(db_user, connection);

            command.Parameters.AddWithValue("@username", username);
            // Executing the command
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Grabbing from the database the username and password accordind to user input
                    db_username = reader["Username"].ToString();
                    db_password = reader["Password"].ToString();
                }
                // If the username does not exist show message and delete user input
                if (username != db_username || username == "")
                {
                    MessageBox.Show("Invalid username!");
                    Login.login.Username.Clear();
                    Login.login.Password.Clear();
                }
                // If the username exist call method CheckPassword
                else
                if (PasswordHasher.VerifyPassword(password, db_password))
                    {
                        MainMenu menu = new MainMenu();
                        menu.Show();

                        MessageBox.Show(
                            "Login Succesful!\nWelcome " + Login.login.Username.Text);

                        Login.login.Password.Clear();
                        Login.login.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password!");
                        Login.login.Password.Clear();
                    }
            }
        }

        // Reset password methods
        public void Reset_Pass_Username(string username, string sq_answer, string new_pass, string new_pass_conf)
        {
            // Opening database connection
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            var db_username = "";
            var db_sq_answer = "";
            var db_old_pass = "";
            // Setting the command
            string db_get_answer = "Select Username, SQAnswer, Password from Users where Username = @username;";

            SQLiteCommand command = new SQLiteCommand(db_get_answer, connection);

            command.Parameters.AddWithValue("@username", username);
            // Executing the command
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Grabbing from the database the username and the answer to the security question answer
                    db_username = reader["Username"].ToString();
                    db_sq_answer = reader["SQAnswer"].ToString();
                    db_old_pass = reader["Password"].ToString();
                }
                // If the user input does not match security question answer
                if (username != db_username || username == "")
                {
                    MessageBox.Show("Wrong username, please try typing your username again!");
                    ResetPassword.r_pass.Username.Clear();
                    ResetPassword.r_pass.SQAnswer.Clear();
                    ResetPassword.r_pass.New_pass.Clear();
                    ResetPassword.r_pass.New_pass_conf.Clear();
                }
                // If the user input matches security question answer call CheckSQAnswer
                else
                {
                    CheckSQAnswer(sq_answer, db_sq_answer, new_pass, new_pass_conf, username, db_old_pass);
                }
            }
        }

        // Method that checks if the security question answer is correct
        public void CheckSQAnswer(
            string sq_answer,
            string db_sq_answer,
            string new_pass,
            string new_pass_conf,
            string username,
            string db_old_pass)
        {
            // If incorrect answer
            if (sq_answer != db_sq_answer || sq_answer == "")
            {
                MessageBox.Show("The answer for the security question is incorrect, please try again.");
                ResetPassword.r_pass.SQAnswer.Clear();
                ResetPassword.r_pass.New_pass.Clear();
                ResetPassword.r_pass.New_pass_conf.Clear();
            }
            // Call ChangePassword method
            else
            {
                ChangePassword(new_pass, new_pass_conf, username, db_old_pass);
            }
        }

        // Method that checks if the password is not the current one and changes it
        public void ChangePassword(string new_pass, string new_pass_conf, string username, string db_old_pass)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();
            
            if (!string.IsNullOrEmpty(new_pass) && new_pass != db_old_pass && new_pass == new_pass_conf)
            {
                string db_set_pass =
                    "UPDATE Users SET Password = @password WHERE Username = @username;";
                SQLiteCommand command = new SQLiteCommand(db_set_pass, connection);

                command.Parameters.AddWithValue("@password", new_pass);
                command.Parameters.AddWithValue("@username", username);

                command.ExecuteNonQuery();

                MessageBox.Show("Your password has been changed!");
                ResetPassword.r_pass.Close();
                Login.login.BringToFront();
            }
            else if (new_pass == db_old_pass) {
                MessageBox.Show("Your new password cannot be your old password!.");
                ResetPassword.r_pass.SQAnswer.Clear();
                ResetPassword.r_pass.New_pass.Clear();
                ResetPassword.r_pass.New_pass_conf.Clear();
            }
            else
            {
                MessageBox.Show("Password confirmation does not match.");
                ResetPassword.r_pass.SQAnswer.Clear();
                ResetPassword.r_pass.New_pass.Clear();
                ResetPassword.r_pass.New_pass_conf.Clear();
            }
        }

        public string GetPosition(string username)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();
            
            string get_positon = "Select * from Users where Username =@username;";
            SQLiteCommand command = new SQLiteCommand(get_positon, connection);
            command.Parameters.AddWithValue("@username", username);
            // Executing the command
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Grabbing from the database the username and password accordind to user input
                    position = reader["Position"].ToString();
                    LoadUsers(position);
                }
                return position;
            }
        }

        // Method that loads users in the grid view
        public void LoadUsers(string position)
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            SQLiteCommand command = new SQLiteCommand("Select * From Users", connection);
            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    if (position == "Admin")
                    {
                        Users.users.UsersDataGrid.Rows.Add(new object[] 
                        {
                            read.GetValue(0),
                            read.GetValue(read.GetOrdinal("Position")),
                            read.GetValue(read.GetOrdinal("Username")),
                            read.GetValue(read.GetOrdinal("Password")),
                            read.GetValue(read.GetOrdinal("DoB")),
                            read.GetValue(read.GetOrdinal("Sex")),
                            read.GetValue(read.GetOrdinal("Email")),
                            read.GetValue(read.GetOrdinal("PhoneNumber")),
                            read.GetValue(read.GetOrdinal("SecurityQuestion")),
                            read.GetValue(read.GetOrdinal("SQAnswer"))
                        });
                    }
                    else if (position == "Supervisor")
                    {
                        Users.users.UsersDataGrid.Rows.Add(new object[] 
                        {
                            read.GetValue(0),
                            read.GetValue(read.GetOrdinal("Position")),
                            read.GetValue(read.GetOrdinal("Username")),
                            read.GetValue(read.GetOrdinal("DoB")),
                            read.GetValue(read.GetOrdinal("Sex")),
                            read.GetValue(read.GetOrdinal("Email")),
                            read.GetValue(read.GetOrdinal("PhoneNumber")),
                        });
                    }
                    else if (position == "Power User")
                    {
                        Users.users.UsersDataGrid.Rows.Add(new object[] 
                        {
                            read.GetValue(0),
                            read.GetValue(read.GetOrdinal("Position")),
                            read.GetValue(read.GetOrdinal("Username")),
                            read.GetValue(read.GetOrdinal("Email")),
                            read.GetValue(read.GetOrdinal("PhoneNumber")),
                        });
                    }
                    else
                    {
                        Users.users.UsersDataGrid.Rows.Add(new object[]
                        {
                            read.GetValue(0),
                            read.GetValue(read.GetOrdinal("Position")),
                            read.GetValue(read.GetOrdinal("Username")),
                        });
                    }
                }
            }
        }

        public string GetUserId()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            string get_positon = "Select * from Users where Username =@username;";
            SQLiteCommand command = new SQLiteCommand(get_positon, connection);
            command.Parameters.AddWithValue("@username", Login.login.Username.Text);
            // Executing the command
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Grabbing from the database the username and password accordind to user input
                    userId = reader["UserId"].ToString();
                }
                return userId;
            }
        }

        // Method that adds users in the grid view and database
        public void AddUsers()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            SQLiteCommand command = new SQLiteCommand(
                "INSERT INTO Users " +
                "(Position, Username, Password, DoB, Sex, Email, PhoneNumber, SecurityQuestion, SQAnswer) " +
                "VALUES (@position, @username, @password, @dob, @sex, @email, @phoneNumber, @securityQuestion, @sqAnswer);",
                connection);
            
            string hashedPassword = PasswordHasher.HashPassword(AddUser.addUser.pass.Text);

            command.Parameters.AddWithValue("@position", AddUser.addUser.pos.Text);
            command.Parameters.AddWithValue("@username", AddUser.addUser.uName.Text);
            command.Parameters.AddWithValue("@password", hashedPassword);
            command.Parameters.AddWithValue("@dob", ConvertToDate());
            command.Parameters.AddWithValue("@sex", AddUser.addUser.sex.Text);
            command.Parameters.AddWithValue("@email", AddUser.addUser.email.Text);
            command.Parameters.AddWithValue("@phoneNumber", AddUser.addUser.ph_num.Text);
            command.Parameters.AddWithValue("@securityQuestion", AddUser.addUser.sq.Text);
            command.Parameters.AddWithValue("@sqAnswer", AddUser.addUser.sqa.Text);

            command.ExecuteNonQuery();

            MessageBox.Show("You've succesfully added a new user into the user list!");
            Users.users.UsersDataGrid.Rows.Clear();
            GetPosition(Login.login.Username.Text);
            AddUser.addUser.Close();
        }

        // Method that checks is the marked fields are completed
        public void CheckAddUsers()
        {
            if (string.IsNullOrEmpty(AddUser.addUser.uName.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else if (string.IsNullOrEmpty(AddUser.addUser.pass.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else if (string.IsNullOrEmpty(AddUser.addUser.pos.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else if (string.IsNullOrEmpty(AddUser.addUser.dOb.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else if (string.IsNullOrEmpty(AddUser.addUser.sq.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else if (string.IsNullOrEmpty(AddUser.addUser.sqa.Text))
            {
                MessageBox.Show("Please fill in all the fields marked with *");
            }
            else { AddUsers(); }
        }
        // Method that converts a string date to integer
        public int ConvertToDate()
        {
            string date = AddUser.addUser.dOb.Value.ToShortDateString();
            date = date.Replace("/", "");
            dob = Convert.ToInt32(date);
            return dob;
        }

        // Method that removes users from database and gridview
        public void RemoveUser()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            if (Users.users.UsersDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show("Are you sure you want to remove this row?", "Delete Row", MessageBoxButtons.YesNo);
                if (dg_res == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in Users.users.UsersDataGrid.SelectedRows)
                    {
                        int id = Convert.ToInt32(Users.users.UsersDataGrid.SelectedRows[0].Cells[0].Value);

                        SQLiteCommand command = new SQLiteCommand(
                            "DELETE FROM Users WHERE UserId = @userId;",
                            connection);

                        command.Parameters.AddWithValue("@userId", id);

                        Users.users.UsersDataGrid.Rows.RemoveAt(Users.users.UsersDataGrid.SelectedRows[0].Index);

                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            { MessageBox.Show("Please select a row in order to delete it!"); }
        }

        // Method that allows modifying users gridview and database
        public void ModifyUser()
        {
            using SQLiteConnection connection = Database.CreateConnection();
            connection.Open();

            if (Users.users.UsersDataGrid.EditMode == DataGridViewEditMode.EditProgrammatically)
            {
                for (int item = 0; item <= Users.users.UsersDataGrid.Rows.Count - 1; item++)
                {
                    SQLiteCommand command = new SQLiteCommand("Update Users set " +
                        "position = @position, " +
                        "Username = @username, " +
                        "Password = @password, " +
                        "dob = @dob, " +
                        "sex = @sex, " +
                        "email = @email, " +
                        "phonenumber = @phoneNumber, " +
                        "SecurityQuestion = @SecurityQuestion, " +
                        "SQAnswer = @SQAnswer where userid = @userid;", connection);

                    command.Parameters.AddWithValue("@userid", Users.users.UsersDataGrid.Rows[item].Cells[0].Value);
                    command.Parameters.AddWithValue("@position", Users.users.UsersDataGrid.Rows[item].Cells[1].Value);
                    command.Parameters.AddWithValue("@username", Users.users.UsersDataGrid.Rows[item].Cells[2].Value);
                    command.Parameters.AddWithValue("@password", Users.users.UsersDataGrid.Rows[item].Cells[3].Value);
                    command.Parameters.AddWithValue("@dob", Users.users.UsersDataGrid.Rows[item].Cells[4].Value);
                    command.Parameters.AddWithValue("@sex", Users.users.UsersDataGrid.Rows[item].Cells[5].Value);
                    command.Parameters.AddWithValue("@email", Users.users.UsersDataGrid.Rows[item].Cells[6].Value);
                    command.Parameters.AddWithValue("@phoneNumber", Users.users.UsersDataGrid.Rows[item].Cells[7].Value);
                    command.Parameters.AddWithValue("@SecurityQuestion", Users.users.UsersDataGrid.Rows[item].Cells[8].Value);
                    command.Parameters.AddWithValue("@SQAnswer", Users.users.UsersDataGrid.Rows[item].Cells[9].Value);
                    
                    command.ExecuteNonQuery();
                }
                Users.users.UsersDataGrid.EndEdit();
                Users.users.UsersDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
                MessageBox.Show("You've succesfully edited the cell!");
            } else { MessageBox.Show("Please double click on a cell in order to edit it!"); }
        }
    }
}
