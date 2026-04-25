using System.Data;

namespace WinFormsApp2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            resultsPanel.Visible = false;
            this.AutoScroll = true;
            searchTextBox.TextChanged -= searchTextBox_TextChanged;
            searchTextBox.TextChanged += searchTextBox_TextChanged;

            searchTextBox.KeyDown += searchTextBox_KeyDown;

            button11.Click += button11_Click;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void Form_Resize(object sender, EventArgs e)
        {
            int croppedHeight = this.ClientSize.Height - 350; // adjust this value as needed
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Size = new Size(this.ClientSize.Width, croppedHeight);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SendToBack();
            pictureBox2.Invalidate();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Detail form2 = new Detail();
            //form2.Show();
            Detail detailPage = HelperFunctions.GetProductDetailPage("Stitch Plushie", "item2");
            detailPage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Detail form2 = new Detail();
            //form2.Show();
            Detail detailPage = HelperFunctions.GetProductDetailPage("Brown Cat", "item1");
            detailPage.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Detail form2 = new Detail();
            //form2.Show();
            Detail detailPage = HelperFunctions.GetProductDetailPage("Barbie Wallet", "BarbieWallet");
            detailPage.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Detail form2 = new Detail();
            //form2.Show();
            Detail detailPage = HelperFunctions.GetProductDetailPage("Ghost Keychains", "ghostKeychain");
            detailPage.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //    Detail form2 = new Detail();
            //    form2.Show();
            Detail detailPage = HelperFunctions.GetProductDetailPage("IceBear Mug", "icebearMug");
            detailPage.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Detail form2 = new Detail();
            //form2.Show();
            Detail detailPage = HelperFunctions.GetProductDetailPage("Pack of 6 highlighters", "Highlighters");
            detailPage.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
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

        private void button7_Click(object sender, EventArgs e)
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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (resultsPanel == null)
            {
                MessageBox.Show("Error: resultsPanel is not initialized.");
                return;
            }

            string input = searchTextBox.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                resultsPanel.Visible = false;
                return;
            }

            resultsPanel.Controls.Clear();
            resultsPanel.Visible = true;

            DatabaseConnection dbConnection = new DatabaseConnection();

            // Step 1: Get all products
            DataTable fullProductList = dbConnection.GetAllProducts(); // <- You add this method in DatabaseConnection class

            // Step 2: Create an empty filtered result table
            DataTable searchResults = fullProductList.Clone();

            // Step 3: Add rows that match user input (partial match)
            foreach (DataRow row in fullProductList.Rows)
            {
                string productName = row["prod_name"].ToString().ToLower();
                if (productName.Contains(input))
                {
                    searchResults.ImportRow(row);
                }
            }


            Dictionary<string, string> productToImage = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "stitch plushie", "item2" },
        { "brown cat", "item1" },
        { "barbie wallet", "BarbieWallet" },
        { "ghost keychains", "ghostKeychain" },
        { "icebear mug", "icebearMug" },
        { "highlighters", "Highlighters" },
        { "pooh plushie", "poohPlushie" },
        { "capybara plushie", "capybaraPlushie" },
        { "mood plush", "moodPlush" },
        { "cat plushie", "catPlushie" },
        { "alien plushie", "alienPlushie" },
        { "pastel diaries", "pastelDiaries" },
        { "mushroom pouch", "mushroomPouch" },
        { "bubble teddy pens", "bubbleTeddyPens" },
        { "smooth gel pens", "smoothGelPensSet" },
        { "watercolor pens", "WaterColorPens" },
        { "blue stationary holder", "BlueStationaryHolder" },
        { "cute plant pot", "cutePlantPot" },
        { "flower tray", "flowerTray" },
        { "panda keychain", "pandaKeychain" },
        { "pink heart earrings", "pinkheartEarrings" },
        { "hello kitty chain", "helloKittyChain" },
        { "pastel pink bag", "pastelPinkBag" }
    };

            foreach (DataRow row in searchResults.Rows)
            {
                string productName = row["prod_name"].ToString();
                string imgKey = productName.ToLower();

                string imageName = productToImage.ContainsKey(imgKey)
                    ? productToImage[imgKey]
                    : imgKey.Replace(" ", "");

                // Assuming "price" is the column in the DataRow for the price
                string productPrice = row["price"].ToString();

                // Now passing the price along with productName and imageName
                ProductCard card = new ProductCard(productName, productPrice, imageName);
                resultsPanel.Controls.Add(card);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TinyTrinkets form2 = new TinyTrinkets();
            form2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (resultsPanel == null)
            {
                MessageBox.Show("Error: resultsPanel is not initialized.");
                return;
            }

            resultsPanel.Controls.Clear();
            resultsPanel.Visible = true;

            string userInput = searchTextBox.Text.Trim().ToLower(); // Normalize input

            if (string.IsNullOrWhiteSpace(userInput))
            {
                MessageBox.Show("Please enter a product name to search.");
                return;
            }

            DatabaseConnection dbConnection = new DatabaseConnection();

            DataTable fullProductList = dbConnection.GetAllProducts();

            DataTable searchResults = fullProductList.Clone();

            foreach (DataRow row in fullProductList.Rows)
            {
                string productName = row["prod_name"].ToString().ToLower();
                if (productName.Contains(userInput))
                {
                    searchResults.ImportRow(row);
                }
            }


            resultsPanel.Controls.Clear(); // Clear previous search results

            if (searchResults.Rows.Count == 0)
            {
                MessageBox.Show("No products found.");
                return;
            }

            var productImageMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "stitch plushie", "item2" },
        { "brown cat", "item1" },
        { "barbie wallet", "BarbieWallet" },
        { "ghost keychains", "ghostKeychain" },
        { "icebear mug", "icebearMug" },
        { "highlighters", "Highlighters" },

        { "pooh plushie", "poohPlushie" },
        { "capybara plushie", "capybaraPlushie" },
        { "mood plush", "moodPlush" },
        { "cat plushie", "catPlushie" },
        { "alien plushie", "alienPlushie" },

        { "pastel diaries", "pastelDiaries" },
        { "mushroom pouch", "mushroomPouch" },
        { "bubble teddy pens", "bubbleTeddyPens" },
        { "smooth gel pens", "smoothGelPensSet" },
        { "watercolor pens", "WaterColorPens" },
        { "blue stationary holder", "BlueStationaryHolder" },

        { "cute plant pot", "cutePlantPot" },
        { "flower tray", "flowerTray" },
        { "panda keychain", "pandaKeychain" },
        { "pink heart earrings", "pinkheartEarrings" },
        { "hello kitty chain", "helloKittyChain" },
        { "pastel pink bag", "pastelPinkBag" }
    };

            bool exactMatchFound = false;

            foreach (DataRow row in searchResults.Rows)
            {
                string dbName = row["prod_name"].ToString().Trim();
                string dbNameLower = dbName.ToLower();

                if (dbNameLower == userInput)
                {
                    // Exact match: Open detail page directly
                    string imageName = productImageMap.ContainsKey(userInput)
                        ? productImageMap[userInput]
                        : userInput.Replace(" ", ""); // fallback

                    Detail detailPage = HelperFunctions.GetProductDetailPage(dbName, imageName);
                    detailPage.ShowDialog();

                    exactMatchFound = true;
                    break;
                }
            }

            if (!exactMatchFound)
            {
                // Show matching results in the resultsPanel
                foreach (DataRow row in searchResults.Rows)
                {
                    string productName = row["prod_name"].ToString(); // Get product name from the row
                    string productPrice = row["price"].ToString(); // Get product price from the row
                    string imageName = productImageMap.ContainsKey(productName.ToLower())
                        ? productImageMap[productName.ToLower()]
                        : productName.ToLower().Replace(" ", "");

                    // Create ProductCard with name, price, and image name
                    ProductCard card = new ProductCard(productName, productPrice, imageName);
                    resultsPanel.Controls.Add(card);
                }
            }
        }


        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents ding sound and newline
                button11.PerformClick();   // Simulates button click to perform search
            }
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
