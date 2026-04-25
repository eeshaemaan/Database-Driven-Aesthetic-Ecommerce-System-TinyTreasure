using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace WinFormsApp2
{
    public partial class Cart : Form
    {
        private static Cart instance;
        private static List<CartItem> cartItems = new List<CartItem>();

        public List<CartItem> CartItems // so that we can access is in the checkut button
        {
            get { return cartItems; }
        }

        public int GetQuantityInCart(string productName) //returns the quantity of the item in cart
        {
             for (int i = 0; i < cartItems.Count; i++)
            {
                if (cartItems[i].Name == productName)
                {
                    return (int)cartItems[i].Quantity;  
                }
            }
            return 0;  
        }


        public static Cart GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Cart();  // Create new instance if none exists
            }
            return instance;
        }

        private ImageList imageList;

        public Cart()
        {
            InitializeComponent();
            // Call the method to initialize the ListView columns
            InitializeListView();

            // Initialize the ImageList
            imageList = new ImageList();
            imageList.ImageSize = new Size(50, 50);
            // Assigning ImageList to ListView
            listView1.SmallImageList = imageList;

            this.FormClosing += Cart_FormClosing;

        }
        // Prevent form from being disposed
        private void Cart_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide(); // Just hide the form instead of closing it
        }

        private void InitializeListView()
        {


            listView1.Columns.Add("     Product Image    ");
            listView1.Columns.Add("     Item Name        ");
            listView1.Columns.Add("     Price           ");
            listView1.Columns.Add("     Quantity        ");
            listView1.Columns.Add("     Total           ");
        

            listView1.HeaderStyle = ColumnHeaderStyle.None;
            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);



        }

        //Class to hold detail for one product
        public class CartItem
        {
            public string Name { get; set; }        // Item name
            public string Price { get; set; }       // Price as string (e.g., "Rs 100")
            public decimal Quantity { get; set; }   // Quantity added
            public Image ProductImage { get; set; } // Product image

            //Constructor
            public CartItem(string name, string price, decimal quantity, Image productImage)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                ProductImage = productImage;
            }
        }

        public void AddToCart(string itemName, string price, decimal quantity, Image productImage)
        {
            const decimal MaxQuantity = 10;

            string priceWithoutCurrency = price.Replace("Rs", "").Trim();
            decimal itemPrice = decimal.Parse(priceWithoutCurrency);

            var existingItem = cartItems.FirstOrDefault(item => item.Name == itemName);

            if (existingItem != null)
            {
                // Check if adding the new quantity exceeds the limit
                if (existingItem.Quantity + quantity > MaxQuantity)
                {
                    MessageBox.Show($"You can only add up to {MaxQuantity} units of {itemName} to the cart.",
                                    "Quantity Limit Reached",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                existingItem.Quantity += quantity;
            }
            else
            {
                if (quantity > MaxQuantity)
                {
                    MessageBox.Show($"You can only add up to {MaxQuantity} units of {itemName} to the cart.",
                                    "Quantity Limit Reached",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                cartItems.Add(new CartItem(itemName, price, quantity, productImage));
                imageList.Images.Add(productImage);
            }

            UpdateCartDisplay();
        }



        private void UpdateCartDisplay()
        {
            decimal totalPrice = 0;
            // Clear existing items and  previous images in ImageList
            listView1.Items.Clear();
            imageList.Images.Clear();

            if (cartItems.Count == 0)
            {
                pictureBox_EMPTY_CART.Visible = true;
            }
            else
            {
                pictureBox_EMPTY_CART.Visible = false;
            }

            for (int i = 0; i < cartItems.Count; i++)
            {
                var item = cartItems[i];

                decimal itemPrice = decimal.Parse(item.Price.Replace("Rs", "").Trim());
                decimal total = itemPrice * item.Quantity;
                totalPrice += total;

                // Add the image to ImageList
                imageList.Images.Add(item.ProductImage);

                // Creating a ListViewItem with an empty string for the first column whihc rep the image of the product
                ListViewItem listViewItem = new ListViewItem("");
                // Seting the image for the first column
                listViewItem.ImageIndex = imageList.Images.Count - 1;

                // Adding other cols
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.Price);
                listViewItem.SubItems.Add(item.Quantity.ToString());
                listViewItem.SubItems.Add("Rs " + total.ToString());

                if (i % 2 == 0)
                {
                    listViewItem.BackColor = Color.Azure;
                }
                else
                {
                    listViewItem.BackColor = Color.Turquoise;
                }

                // Applying font and color formatting
                foreach (ListViewItem.ListViewSubItem subItem in listViewItem.SubItems)
                {
                    subItem.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                    subItem.ForeColor = Color.DarkSlateGray;
                }


                // Adding the item
                listView1.Items.Add(listViewItem);
            }

            // Update the total price label
            labelTotal.Text = "Total: Rs " + totalPrice.ToString();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
            cartForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Checkout form2 = new Checkout();
            form2.Show();
        

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

        private void pictureBox_EMPTY_CART_Click(object sender, EventArgs e)
        {

        }
    }
}
