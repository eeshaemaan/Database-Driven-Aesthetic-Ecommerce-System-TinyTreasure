namespace WinFormsApp2
{
    partial class Detail : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblProductImage;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductDesc;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            addToCart = new Button();
            numericUpDown1 = new NumericUpDown();
            button7 = new Button();
            pictureBox6 = new PictureBox();
            productImageBox = new PictureBox();
            panel2 = new Panel();
            button13 = new Button();
            button12 = new Button();
            button2 = new Button();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productImageBox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Turquoise;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.ImageAlign = ContentAlignment.BottomLeft;
            label2.Location = new Point(-4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.MinimumSize = new Size(1012, 75);
            label2.Name = "label2";
            label2.Size = new Size(1012, 75);
            label2.TabIndex = 7;
            label2.Text = "             Product Details   ";
            label2.Click += label2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Turquoise;
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(15, 0);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(98, 140);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(421, 365);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(610, 122);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(549, 199);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(436, 326);
            label3.TabIndex = 11;
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(651, 161);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 30);
            label4.TabIndex = 12;
            label4.Click += label4_Click_1;
            // 
            // addToCart
            // 
            addToCart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addToCart.ForeColor = SystemColors.ControlDarkDark;
            addToCart.Location = new Point(709, 531);
            addToCart.Margin = new Padding(4, 4, 4, 4);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(181, 36);
            addToCart.TabIndex = 14;
            addToCart.Text = "Add to Cart";
            addToCart.UseVisualStyleBackColor = true;
            addToCart.Click += button1_Click_1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.ScrollBar;
            numericUpDown1.ForeColor = SystemColors.WindowFrame;
            numericUpDown1.Location = new Point(624, 531);
            numericUpDown1.Margin = new Padding(4, 4, 4, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(78, 31);
            numericUpDown1.TabIndex = 15;
            // 
            // button7
            // 
            button7.BackColor = Color.MediumTurquoise;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlDarkDark;
            button7.Location = new Point(864, 15);
            button7.Margin = new Padding(4, 4, 4, 4);
            button7.Name = "button7";
            button7.Size = new Size(118, 36);
            button7.TabIndex = 47;
            button7.Text = "Navigate";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Burger_Bar_free_icons_designed_by_Febrian_Hidayat;
            pictureBox6.Location = new Point(825, 15);
            pictureBox6.Margin = new Padding(4, 4, 4, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 51;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click_1;
            // 
            // productImageBox
            // 
            productImageBox.Image = Properties.Resources.detail;
            productImageBox.Location = new Point(0, 568);
            productImageBox.Margin = new Padding(4, 4, 4, 4);
            productImageBox.Name = "productImageBox";
            productImageBox.Size = new Size(1000, 438);
            productImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productImageBox.TabIndex = 0;
            productImageBox.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(button13);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button9);
            panel2.Location = new Point(848, 59);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(139, 314);
            panel2.TabIndex = 67;
            panel2.Visible = false;
            // 
            // button13
            // 
            button13.BackColor = Color.MediumTurquoise;
            button13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = SystemColors.ControlDarkDark;
            button13.Location = new Point(0, 126);
            button13.Margin = new Padding(4);
            button13.Name = "button13";
            button13.Size = new Size(138, 36);
            button13.TabIndex = 5;
            button13.Text = "Tiny Trinkets";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.MediumTurquoise;
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ControlDarkDark;
            button12.Location = new Point(0, 191);
            button12.Margin = new Padding(4);
            button12.Name = "button12";
            button12.Size = new Size(138, 36);
            button12.TabIndex = 4;
            button12.Text = "Stationary";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(1, 254);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(138, 36);
            button2.TabIndex = 2;
            button2.Text = "Cart";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.MediumTurquoise;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlDarkDark;
            button8.Location = new Point(0, 66);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(135, 36);
            button8.TabIndex = 1;
            button8.Text = "Plushies";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.MediumTurquoise;
            button9.Dock = DockStyle.Top;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlDarkDark;
            button9.Location = new Point(0, 0);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(139, 36);
            button9.TabIndex = 0;
            button9.Text = "Home";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // Detail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1000, 1050);
            Controls.Add(panel2);
            Controls.Add(productImageBox);
            Controls.Add(pictureBox6);
            Controls.Add(button7);
            Controls.Add(numericUpDown1);
            Controls.Add(addToCart);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Margin = new Padding(4, 4, 4, 4);
            MaximumSize = new Size(1870, 1861);
            MinimumSize = new Size(1017, 1018);
            Name = "Detail";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)productImageBox).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button addToCart;
        private NumericUpDown numericUpDown1;
        private Button button7;
        private PictureBox pictureBox6;
        private PictureBox productImageBox;
        private Panel panel2;
        private Button button13;
        private Button button12;
        private Button button2;
        private Button button8;
        private Button button9;
    }
}
