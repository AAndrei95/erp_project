using Digital_Shop_Software.Repositories;

namespace Digital_Shop_Software
{
    internal class User
    {
        // Checking Credentials methods
        int dob;
        public string position;
        public void CheckCredentials(string username, string password)
        {
            UserRepository userRepository = new UserRepository();
            
            var user = userRepository.GetUserByUsername(username);

            // If the username does not exist show error message and delete user input
            if (user == null || username == "")
            {
                MessageBox.Show("Invalid username!");
                Login.login.Username.Clear();
                Login.login.Password.Clear();
                return;
            }

            // If the username exist check if the password is correct
            if (PasswordHasher.VerifyPassword(password, user.Value.Password))
                {
                    MainMenu menu = new MainMenu();
                    menu.Show();

                    MessageBox.Show("Login Succesful!\nWelcome " + Login.login.Username.Text);

                    Login.login.Password.Clear();
                    Login.login.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                    Login.login.Password.Clear();
                }
        }

         // Reset password methods
        public void ResetPassUsername(string username, string sq_answer, string new_pass, string new_pass_conf)
        {
            UserRepository userRepository = new UserRepository();
            
            string? db_sq_answer = userRepository.GetSecurityQuestionAnswer(username);
            
            // If the user input does not match security question answer
            if (string.IsNullOrEmpty(db_sq_answer) || username == "")
            {
                MessageBox.Show("Wrong username, please try typing your username again!");
                ResetPassword.r_pass.Username.Clear();
                ResetPassword.r_pass.SQAnswer.Clear();
                ResetPassword.r_pass.New_pass.Clear();
                ResetPassword.r_pass.New_pass_conf.Clear();

                return;
            }
            // If the user input matches security question answer call CheckSQAnswer
            else
            {
                CheckSQAnswer(sq_answer, db_sq_answer, new_pass, new_pass_conf, username);
            }   
        }

        // Method that checks if the security question answer is correct
        public void CheckSQAnswer(
            string sq_answer,
            string db_sq_answer,
            string new_pass,
            string new_pass_conf,
            string username)
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
                ChangePassword(new_pass, new_pass_conf, username);
            }
        }

        // Method that checks if the password is not the current one and changes it
        public void ChangePassword(string new_pass, string new_pass_conf, string username)
        {
            if (!string.IsNullOrEmpty(new_pass) &&  
                new_pass == new_pass_conf)
            {
                string passwordHash = PasswordHasher.HashPassword(new_pass);

                UserRepository userRepository = new UserRepository();
                userRepository.UpdatePassword(username, passwordHash);

                MessageBox.Show("Your password has been changed!");
                ResetPassword.r_pass.Close();
                Login.login.BringToFront();
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
            UserRepository userRepository = new UserRepository();

            string position = userRepository.GetPosition(username) ?? "";
            
            LoadUsers(position);

            return position;
        }

        // Method that loads users in the grid view
        public void LoadUsers(string position)
        {
            UserRepository userRepository = new UserRepository();

            List<Dictionary<string, object>> users = userRepository.GetUsers();

            foreach (Dictionary<string, object> user in users)
            {
                if (position == "Admin")
                {
                    Users.users.UsersDataGrid.Rows.Add(new object[]
                    {
                        user["UserId"],
                        user["Position"],
                        user["Username"],
                        user["Password"],
                        user["DoB"],
                        user["Sex"],
                        user["Email"],
                        user["PhoneNumber"],
                        user["SecurityQuestion"],
                        user["SQAnswer"]
                    });
                }
                else if (position == "Supervisor")
                {
                    Users.users.UsersDataGrid.Rows.Add(new object[]
                    {
                        user["UserId"],
                        user["Position"],
                        user["Username"],
                        user["DoB"],
                        user["Sex"],
                        user["Email"],
                        user["PhoneNumber"]
                    });
                }
                else if (position == "Power User")
                {
                    Users.users.UsersDataGrid.Rows.Add(new object[]
                    {
                        user["UserId"],
                        user["Position"],
                        user["Username"],
                        user["Email"],
                        user["PhoneNumber"]
                    });
                }
                else
                {
                    Users.users.UsersDataGrid.Rows.Add(new object[]
                    {
                        user["UserId"],
                        user["Position"],
                        user["Username"]
                    });
                }
            }
        }

        // Method that adds users in the grid view and database
        public void AddUsers()
        {
            string hashedPassword = PasswordHasher.HashPassword(AddUser.addUser.pass.Text);

            UserRepository userRepository = new UserRepository();

            userRepository.AddUser(
                AddUser.addUser.pos.Text,
                AddUser.addUser.uName.Text,
                hashedPassword,
                ConvertToDate().ToString(),
                AddUser.addUser.sex.Text,
                AddUser.addUser.email.Text,
                AddUser.addUser.ph_num.Text,
                AddUser.addUser.sq.Text,
                AddUser.addUser.sqa.Text);

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
            UserRepository userRepository = new UserRepository();

            if (Users.users.UsersDataGrid.SelectedRows.Count > 0)
            {
                DialogResult dg_res = MessageBox.Show(
                    "Are you sure you want to remove this row?",
                    "Delete Row", MessageBoxButtons.YesNo);

                if (dg_res == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in Users.users.UsersDataGrid.SelectedRows)
                    {
                        int id = Convert.ToInt32(Users.users.UsersDataGrid.SelectedRows[0].Cells[0].Value);

                        userRepository.RemoveUser(id);

                        Users.users.UsersDataGrid.Rows.RemoveAt(Users.users.UsersDataGrid.SelectedRows[0].Index);
                    }
                }
            }
            else
            { 
                MessageBox.Show("Please select a row in order to delete it!"); 
            }
        }

        // Method that allows modifying users gridview and database
        public void ModifyUser()
        {
            UserRepository userRepository = new UserRepository();

            if (Users.users.UsersDataGrid.EditMode == DataGridViewEditMode.EditProgrammatically)
            {
                for (int item = 0; item <= Users.users.UsersDataGrid.Rows.Count - 1; item++)
                {
                   int userId = Convert.ToInt32(Users.users.UsersDataGrid.Rows[item].Cells[0].Value);
                   string passwordHash = Users.users.UsersDataGrid.Rows[item].Cells[3].Value?.ToString() ?? "";

                   userRepository.ModifyUser(
                        userId,
                        Users.users.UsersDataGrid.Rows[item].Cells[1].Value?.ToString() ?? "",
                        Users.users.UsersDataGrid.Rows[item].Cells[2].Value?.ToString() ?? "",
                        passwordHash,
                        Users.users.UsersDataGrid.Rows[item].Cells[4].Value?.ToString() ?? "",
                        Users.users.UsersDataGrid.Rows[item].Cells[5].Value?.ToString() ?? "",
                        Users.users.UsersDataGrid.Rows[item].Cells[6].Value?.ToString() ?? "",
                        Users.users.UsersDataGrid.Rows[item].Cells[7].Value?.ToString() ?? "",
                        Users.users.UsersDataGrid.Rows[item].Cells[8].Value?.ToString() ?? "",
                        Users.users.UsersDataGrid.Rows[item].Cells[9].Value?.ToString() ?? "");
                }
                Users.users.UsersDataGrid.EndEdit();
                Users.users.UsersDataGrid.EditMode = DataGridViewEditMode.EditOnF2;
                
                MessageBox.Show("You've succesfully edited the cell!");
            } 
            else 
            { 
                MessageBox.Show("Please double click on a cell in order to edit it!"); 
            }
        }
    }
}
