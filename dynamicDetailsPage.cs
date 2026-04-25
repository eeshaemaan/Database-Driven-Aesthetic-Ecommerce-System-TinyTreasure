namespace WinFormsApp2
{
    public partial class Detail : Form
    {
        public Detail(string productName, string productImage, string productPrice, string productDesc)
        {
            this.lblProductImage = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductDesc = new System.Windows.Forms.Label();
            lblProductName.Text = productName;
            lblProductImage.Text = productImage;
            lblProductPrice.Text = productPrice;
            lblProductDesc.Text = productDesc;
            InitializeComponent();
            pictureBox2.Image = Properties.Resources.ResourceManager.GetObject(lblProductImage.Text.Trim()) as Image;
            label1.Text = lblProductName.Text; // Set product name dynamically
            label4.Text = lblProductPrice.Text; // productPrice is already a formatted string
            label3.Text = lblProductDesc.Text;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Get product details from the form
            decimal quantity = numericUpDown1.Value;
            string productName = lblProductName.Text;
            string productPrice = lblProductPrice.Text;
            Image productImage = pictureBox2.Image;

            if (quantity == 0)
            {
                MessageBox.Show("Please select a quantity greater than 0 before adding to the cart.\n :)", "Invalid Quantity :(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();
            dbConnection.Connect();

            // Available quantity in stock
            int availableQuantity = dbConnection.GetProductStock(productName);

            // Quantity already in cart
            int quantityInCart = Cart.GetInstance().GetQuantityInCart(productName);

            // checkin is again adding prid wont exceed the total stock amount
            int effectiveAvailable = availableQuantity - quantityInCart;

            if (effectiveAvailable >= quantity)
            {
                    Cart.GetInstance().AddToCart(productName, productPrice, quantity, productImage);
                    Cart.GetInstance().Show();
                
            }
            else
            {
                // If not enough stock is available
                MessageBox.Show($"Sorry, only {effectiveAvailable} items are available.",
                                "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dbConnection.Close();
        }


        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Home form2 = new Home();
            form2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PlushPage form2 = new PlushPage();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cart cartForm = Cart.GetInstance();

            if (cartForm.Visible)
            {
                // Bring the existing form to the front
                cartForm.BringToFront();
                cartForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                cartForm.Show(); // Show the form if it's not visible
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StationeryPage form2 = new StationeryPage();
            form2.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TinyTrinkets form2 = new TinyTrinkets();
            form2.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
