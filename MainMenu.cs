using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Digital_Shop_Software
{
    public partial class MainMenu : Form
    {
        // Creating objects and instance
        public static MainMenu menu;
        // Variables
        bool so_button = false;
        bool ex_button = false;
        public MainMenu()
        {
            menu = this;
            InitializeComponent();
        }
        // Form loading - display username of the connected user
        private void MainMenu_Load(object sender, EventArgs e)
        {
            Username.Text = "User : " + Login.login.Username.Text;
        }

        // Show stock form upon button click
        private void StockButton_Click(object sender, EventArgs e)
        {
            Display.Controls.Clear();
            Stock stock = new Stock();
            stock.TopLevel = false;
            Display.Controls.Add(stock);
            stock.BringToFront();
            stock.Show();
            stock.Size = this.Display.Size;
        }
        // Show suppliers form upon button click
        private void SuppliersButton_Click(object sender, EventArgs e)
        {
            Display.Controls.Clear();
            Suppliers suppliers = new Suppliers();
            suppliers.TopLevel = false;
            Display.Controls.Add(suppliers);
            suppliers.BringToFront();
            suppliers.Show();
            suppliers.Size = this.Display.Size;
        }
        // Show customers form upon button click
        private void CustomersButton_Click(object sender, EventArgs e)
        {
            Display.Controls.Clear();
            Customers customers = new Customers();
            customers.TopLevel = false;
            Display.Controls.Add(customers);
            customers.BringToFront();
            customers.Show();
            customers.Size = this.Display.Size;
        }
        // Show orders form upon button click
        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Display.Controls.Clear();
            Orders orders = new Orders();
            orders.TopLevel = false;
            Display.Controls.Add(orders);
            orders.BringToFront();
            orders.Show();
            orders.Size = this.Display.Size;
        }
        // Show reports form upon button click
        private void ReportsButton_Click(object sender, EventArgs e)
        {
            Display.Controls.Clear();
            Reports reports = new Reports();
            reports.TopLevel = false;
            Display.Controls.Add(reports);
            reports.BringToFront();
            reports.Show();
            reports.Size = this.Display.Size;
        }
        // Show users form upon button click
        private void UsersButton_Click(object sender, EventArgs e)
        {
            Display.Controls.Clear();
            Users users = new Users();
            users.TopLevel = false;
            Display.Controls.Add(users);
            users.BringToFront();
            users.Show();
            users.Size = this.Display.Size;
        }
        // Exit the form when exit button is pressed
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ex_button = true;
        }
        // Sign out of the application when sign out button is pressed
        private void SignOutButton_Click(object sender, EventArgs e)
        {
            so_button = true;
            this.Close();
        }
        // Upon form closing when signing out or exiting the app a message will appear to confirm your choice
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // When sign out button is pressed
            if (e.CloseReason == CloseReason.UserClosing && so_button == true)
            {
                DialogResult dialog_res = MessageBox.Show("Are you sure you want to sign out?", "Sign Out", MessageBoxButtons.YesNo);
                if (dialog_res == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    so_button = false;
                    Login.login.Show();
                }
            }
            // When exit button is pressed
            else if (e.CloseReason == CloseReason.UserClosing && ex_button == true)
            {
                DialogResult dialog_res = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
                if (dialog_res == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    Environment.Exit(0);
                }
            }
            // Other closing methods
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
                    Environment.Exit(0);
                }
            }
        }

        // Clearing the froms from the Display pannel 
        private void MainMenu_Txt_Click(object sender, EventArgs e)
        {
            Display.Controls.Clear();
        }

        //Resizing forms according to Display
        private void MainMenu_Resize(object sender, EventArgs e)
        {
            // Upon Normal window state
            if (this.WindowState == FormWindowState.Normal)
            {
                if (Display.Controls.Contains(Stock.stock))
                {
                    Stock.stock.Size = this.Display.Size;
                }
                else if (Display.Controls.Contains(Suppliers.suppliers))
                {
                    Suppliers.suppliers.Size = this.Display.Size;
                }
                else if (Display.Controls.Contains(Customers.customers))
                {
                    Customers.customers.Size = this.Display.Size;
                }
                else if (Display.Controls.Contains(Orders.orders))
                {
                    Orders.orders.Size = this.Display.Size;
                }
                else if (Display.Controls.Contains(Reports.reports))
                {
                    Reports.reports.Size = this.Display.Size;
                }
                else if (Display.Controls.Contains(Users.users))
                {
                    Users.users.UsersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    Users.users.Size = this.Display.Size;
                }
            }
            // Upon maximized window state
            else if (this.WindowState == FormWindowState.Maximized)
            {
                if (Display.Controls.Contains(Stock.stock))
                {
                    Stock.stock.Size = this.Display.Size;
                }
                else if (Display.Controls.Contains(Suppliers.suppliers))
                {
                    Suppliers.suppliers.Size = this.Display.Size;
                }
                else if (Display.Controls.Contains(Customers.customers))
                {
                    Customers.customers.Size = this.Display.Size;
                }
                else if (Display.Controls.Contains(Orders.orders))
                {
                    Orders.orders.Size = this.Display.Size;
                }
                else if (Display.Controls.Contains(Reports.reports))
                {
                    Reports.reports.Size = this.Display.Size;
                }
                else if (Display.Controls.Contains(Users.users))
                {
                    Users.users.UsersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    Users.users.Size = this.Display.Size;
                }
            }
        }
    }
}

