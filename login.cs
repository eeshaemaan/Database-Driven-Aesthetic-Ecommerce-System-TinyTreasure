namespace WinFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            button_register.Visible = false;
            label_new_user.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox_Username.Text;
            string email = textBox_Email.Text;
            string password = textBox_Password.Text;

            DatabaseConnection dbConnection = new DatabaseConnection();
            dbConnection.Connect();

            // Check if username exists
            if (dbConnection.CheckIfUsernameExists(username))
            {
                // If username exists, check if email matches
                if (dbConnection.CheckIfEmailMatches(username, email))
                {
                    // If email matches, check password
                    if (dbConnection.CheckIfPasswordMatches(username, password))
                    {
                        //If everything matches then open the home form

                        int userId = dbConnection.GetUserIDByUsername(username);
                        Session.LoggedInUserID = userId;
                        Session.Username = username;

                        Home homeForm = new Home();
                        homeForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Email does not match. Please check your email.");
                }
            }
            else
            {
                MessageBox.Show("Username does not exist. Please register first.");
                //Otherwise ask to register
                button_register.Visible = true;
                label_new_user.Visible = true;
            }
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
