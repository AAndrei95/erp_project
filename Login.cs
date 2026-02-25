namespace Digital_Shop_Software
{
    public partial class Login : Form
    {
        // Creating objects and instance
        public static Login login;
        User user = new User();
        public Login()
        {
            login = this;
            InitializeComponent();
        }

        // Read user input and check validate it
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string usr_input = Username.Text;
            string pwd_input = Password.Text;
            user.CheckCredentials(usr_input, pwd_input);
        }

        // Hovering over ShowPass will disable PassChar
        private void ShowPass_MouseHover(Object sender, EventArgs e)
        {
            if (Password.TextLength > 0)
            {
                Password.UseSystemPasswordChar = false;
            }
        }
        private void ShowPass_MouseLeave(Object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }

        // Activate Reset Password form
        private void ResetPass_Click(object sender, EventArgs e)
        {
            ResetPassword r_pass = new ResetPassword();
            if (Username.Text.Length > 0 || Password.Text.Length > 0)
            {
                Username.Clear();
                Password.Clear();
                r_pass.Show(this);
                this.Hide();
            }
            else
            {
                r_pass.Show(this);
                this.Hide();
            }
        }

        // When exit button is pressed the program will close
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}