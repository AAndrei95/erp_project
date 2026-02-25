using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Shop_Software
{
    public partial class ResetPassword : Form
    {
        // Creating objects and instance
        public static ResetPassword r_pass;
        User user = new User();
        ToolTip toolTip = new ToolTip();
        // Variables 
        bool rb_button = false;
        public ResetPassword()
        {
            r_pass = this;
            InitializeComponent();
        }

        // Showing hint upon mouse hover whee username is inserted
        private void Hint_MouseHover(object sender, EventArgs e)
        {
            Database.GetInstance();
            Database.instance.Open();
            string username = Username.Text;
            var db_username = "";
            var sc_question = "";
            // Creating database command and executing it
            string db_get_username = "Select Username,SecurityQuestion from Users where Username = @username;";
            SQLiteCommand command = new SQLiteCommand(db_get_username, Database.instance);
            command.Parameters.AddWithValue("@username", username);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                //Retriving data from database
                while (reader.Read())
                {
                    sc_question = reader["SecurityQuestion"].ToString();
                    db_username = reader["Username"].ToString();
                }
                // Showing hint if user input matches database records
                if (username.Length == 0 || username != db_username)
                {
                    toolTip.SetToolTip(Hint, "Please insert a correct username for the hint to be displayed!");
                }
                else
                {
                    toolTip.SetToolTip(Hint, sc_question);
                }
            }
        }

        private void Hint_MouseLeave(object sender, EventArgs e)
        {
            toolTip.RemoveAll();
            Database.instance.Close();
        }

        // Validating credentials in order to change the password
        private void ResetButton_Click(object sender, EventArgs e)
        {
            rb_button = true;
            string username = Username.Text;
            string sq_answer = SQAnswer.Text;
            string new_pass = New_pass.Text;
            string new_pass_conf = New_pass_conf.Text;
            user.Reset_Pass_Username(username, sq_answer, new_pass, new_pass_conf);
        }

        // Closing form upon pressing Cancel button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.login.BringToFront();
        }

        // When the form closes from different reasons a confirmation window will appear or not
        private void ResetPassword_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && rb_button == true)
            {
                e.Cancel = false;
                Login.login.Show();
                rb_button = false;
            }
            else
            {
                DialogResult dialog_res = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
                if (dialog_res == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    Login.login.Show();
                }
            }
        }
    }
}
