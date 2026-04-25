using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            int userId = Session.LoggedInUserID;

            if (userId != -1)
            {
                DatabaseConnection db = new DatabaseConnection();
                db.Connect();

                MySqlCommand cmd = new MySqlCommand("SELECT name, email, address, phone, paymentMethod FROM checkOutInfo WHERE userID = @userId ORDER BY check_ID DESC LIMIT 1", db.connection);
                cmd.Parameters.AddWithValue("@userId", userId);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader.GetString(0);
                    Name_checkout.Text = reader.GetString(1);
                    textBox1.Text = reader.GetString(2);
                    textBox3.Text = reader.GetString(3);

                    string paymentMethod = reader.GetString(4);
                    if (paymentMethod == "COD")
                        radioButton1.Checked = true;
                    else if (paymentMethod == "Card")
                        radioButton2.Checked = true;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userId = Session.LoggedInUserID;

            if (userId != -1)
            {
                string name = textBox2.Text.Trim();
                string email = Name_checkout.Text.Trim();
                string address = textBox1.Text.Trim();
                string phone = textBox3.Text.Trim();
                string paymentMethod = radioButton1.Checked ? "COD" : (radioButton2.Checked ? "Credit Card" : "");

                // Basic Validation
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address)
                    || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(paymentMethod))
                {
                    MessageBox.Show("Please fill in all fields and select a payment method.");
                    return;
                }

                // Email Validation using Regex
                if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                // Phone Number Length Check (11 digits)
                if (phone.Length != 11 || !phone.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter a valid 11-digit phone number.");
                    return;
                }

                DatabaseConnection db = new DatabaseConnection();
                string message;
                db.Connect();

                bool success = db.StoreCheckoutInfo(userId, name, email, address, phone, paymentMethod, out message);

                if (success)
                {
                    foreach (var item in Cart.GetInstance().CartItems)
                    {
     
                        db.UpdateProductStock(item.Name, item.Quantity);
                    }

                    this.Hide();
                    OrderConfirmationForm confirm = new OrderConfirmationForm();
                    confirm.Show();
                }

                db.Close();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home form2 = new Home();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlushPage form2 = new PlushPage();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cart cartForm = Cart.GetInstance();

            if (cartForm.Visible)
            {
                cartForm.BringToFront(); // Bring the existing form to the front
                cartForm.WindowState = FormWindowState.Normal; // Restore if minimized
            }
            else
            {
                cartForm.Show(); // Show the form if it's not visible
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TinyTrinkets form2 = new TinyTrinkets();
            form2.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StationeryPage form2 = new StationeryPage();
            form2.Show();
        }
    }
}
