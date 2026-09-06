namespace Digital_Shop_Software
{
    public partial class Users : Form
    {
        public static Users users;
        User user = new User();
        public Users()
        {
            users = this;
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // Loads users in grid view
            User user = new User();
            user.GetPosition(Login.login.Username.Text);
        }

        private void addValues_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.Show();
        }
        private void RemoveUser_Click(object sender, EventArgs e)
        {
            // Removes user from data grid and database
            User user = new User();
            user.RemoveUser();
        }

        private void UsersDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Double click to modify the cell
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("You cannot modify this column!");
            }
            else
            {
                UsersDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
                UsersDataGrid.BeginEdit(true);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
                // Modify user grid view and database records
                User user = new User();
                user.ModifyUser();           
        }
    }
}
