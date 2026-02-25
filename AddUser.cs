using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Shop_Software
{
    public partial class AddUser : Form
    {
        public static AddUser addUser;
        public AddUser()
        {
            addUser = this;
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // Adding default security questions 
            Action<string> addItem = (question) => sq.Items.Add(question);
            addItem("In what city were you born?");
            addItem("What is the name of your favorite pet?");
            addItem("What is your mother's maiden name?");
            addItem("What high school did you attend?");
            addItem("What was the name of your elementary school?");
            addItem("What was the make of your first car?");
            addItem("What was your favorite food as a child?");
            sq.Text = sq.Items[0].ToString();
            // Setting minimun date of birth to 18 years
            dOb.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addValues_Click(object sender, EventArgs e)
        {
            // Checking user input and adding in the user list
            User user = new User();
            Database.GetInstance().Open();
            user.CheckAddUsers();
            Database.GetInstance().Close();
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
