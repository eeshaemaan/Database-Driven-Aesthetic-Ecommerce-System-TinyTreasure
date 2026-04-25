using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp2
{
    public partial class ProductCard : UserControl
    {
        public string ProductName { get; set; }
        public string ImageFileName { get; set; }
        public string ProductPrice { get; set; }

        public ProductCard(string name, string price, string imageFileName)
        {
            InitializeComponent();

            ProductName = name;
            ProductPrice = price;
            ImageFileName = imageFileName;

            nameLabel.Text = ProductName;
            priceLabel.Text = "Rs. " + ProductPrice;

            // Load image from project resources
            Image img = Properties.Resources.ResourceManager.GetObject(ImageFileName.Trim()) as Image;
            if (img != null)
            {
                productPictureBox.Image = img;
                productPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }

            // Attach click events
            this.Click += ProductCard_Click;
            productPictureBox.Click += ProductCard_Click;
            nameLabel.Click += ProductCard_Click;
            priceLabel.Click += ProductCard_Click;
            viewButton.Click += ProductCard_Click;
        }

        private void ProductCard_Click(object? sender, EventArgs e)
        {
            Detail detailPage = HelperFunctions.GetProductDetailPage(ProductName, ImageFileName);
            detailPage.ShowDialog();
        }
    }
}