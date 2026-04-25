using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Confirm_Pass_TextChanged(object sender, EventArgs e)
        {

        }



        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text.Trim();
            string email = textBox_Email.Text.Trim();
            string password = textBox_Password.Text;
            string confirmPassword = textBox_Confirm_Pass.Text;

          

            // If text box is empty then change its color to red and siaply msg that all fields are required
            bool hasEmpty = false;

            if (string.IsNullOrWhiteSpace(username))
            {
                textBox_Username.BackColor = Color.MistyRose;
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                textBox_Email.BackColor = Color.MistyRose;
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                textBox_Password.BackColor = Color.MistyRose;
                hasEmpty = true;
            }
            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                textBox_Confirm_Pass.BackColor = Color.MistyRose;
                hasEmpty = true;
            }

            if (hasEmpty)
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            //Correct username sytax validation
            if (username.Length < 6)
            {
                MessageBox.Show("Username must be at least 6 characters long.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z_]+$"))
            {
                MessageBox.Show("Username can only contain letters and underscores (_).");
                return;
            }

            // Email validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Password checks
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*[\W_]).+$"))
            {
                MessageBox.Show("Password must contain at least one letter and one special character.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

           
            DatabaseConnection db = new DatabaseConnection();
            db.Connect();

            if (db.CheckIfUsernameExists(username))
            {
                MessageBox.Show("Username already exists.");
            }
            else
            {
                bool success = db.RegisterUser(username, email, password);
                if (success)
                {
                    MessageBox.Show("Registration successful!");
                    this.Hide();
                    new Home().Show();
                }
            }

            db.Close();
        }
    
    }
}
