namespace WinFormsApp2
{
    partial class Cart
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            button5 = new Button();
            panel1 = new Panel();
            button12 = new Button();
            button13 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            listView1 = new ListView();
            labelTotal = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            pictureBox_EMPTY_CART = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_EMPTY_CART).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Turquoise;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.ImageAlign = ContentAlignment.BottomLeft;
            label2.Location = new Point(-3, 0);
            label2.MinimumSize = new Size(810, 60);
            label2.Name = "label2";
            label2.Size = new Size(810, 60);
            label2.TabIndex = 7;
            label2.Text = "            Cart      ";
            label2.Click += label2_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Turquoise;
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label3
            // 
            label3.BackColor = Color.MintCream;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(26, 89);
            label3.Name = "label3";
            label3.Size = new Size(241, 46);
            label3.TabIndex = 10;
            label3.Text = "Items Selected";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = Color.MintCream;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSlateGray;
            label6.Location = new Point(4, 717);
            label6.Name = "label6";
            label6.Size = new Size(803, 255);
            label6.TabIndex = 0;
            label6.Text = resources.GetString("label6.Text");
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SlateGray;
            label7.Location = new Point(4, 733);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 1;
            label7.Text = "About Us";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SlateGray;
            label9.Location = new Point(4, 850);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 2;
            label9.Text = "Contact Us";
            label9.Click += label9_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumTurquoise;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlDarkDark;
            button5.Location = new Point(677, 12);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 45;
            button5.Text = "Navigate";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(677, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(111, 256);
            panel1.TabIndex = 46;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint_2;
            // 
            // button12
            // 
            button12.BackColor = Color.MediumTurquoise;
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ControlDarkDark;
            button12.Location = new Point(-2, 164);
            button12.Name = "button12";
            button12.Size = new Size(110, 29);
            button12.TabIndex = 4;
            button12.Text = "Stationary";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.MediumTurquoise;
            button13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = SystemColors.ControlDarkDark;
            button13.Location = new Point(0, 106);
            button13.Name = "button13";
            button13.Size = new Size(110, 29);
            button13.TabIndex = 5;
            button13.Text = "Tiny Trinkets";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumTurquoise;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(-2, 212);
            button3.Name = "button3";
            button3.Size = new Size(110, 29);
            button3.TabIndex = 2;
            button3.Text = "Cart";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(0, 52);
            button2.Name = "button2";
            button2.Size = new Size(108, 29);
            button2.TabIndex = 1;
            button2.Text = "Plushies";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumTurquoise;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(666, 388);
            label1.Name = "label1";
            label1.Size = new Size(67, 31);
            label1.TabIndex = 51;
            label1.Text = "Total";
            label1.Click += label1_Click_2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Burger_Bar_free_icons_designed_by_Febrian_Hidayat;
            pictureBox2.Location = new Point(646, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // listView1
            // 
            listView1.BackColor = Color.MintCream;
            listView1.Location = new Point(4, 138);
            listView1.Name = "listView1";
            listView1.Size = new Size(609, 576);
            listView1.TabIndex = 48;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.MediumTurquoise;
            labelTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = SystemColors.ControlDarkDark;
            labelTotal.Location = new Point(646, 368);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(0, 20);
            labelTotal.TabIndex = 49;
            labelTotal.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MediumTurquoise;
            textBox1.Location = new Point(619, 274);
            textBox1.MinimumSize = new Size(180, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 200);
            textBox1.TabIndex = 50;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlDarkDark;
            button4.Location = new Point(619, 445);
            button4.Name = "button4";
            button4.Size = new Size(180, 29);
            button4.TabIndex = 52;
            button4.Text = "Proceed to Checkout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox_EMPTY_CART
            // 
            pictureBox_EMPTY_CART.Image = Properties.Resources.Empty_Cart_Icon;
            pictureBox_EMPTY_CART.Location = new Point(5, 137);
            pictureBox_EMPTY_CART.Name = "pictureBox_EMPTY_CART";
            pictureBox_EMPTY_CART.Size = new Size(608, 577);
            pictureBox_EMPTY_CART.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_EMPTY_CART.TabIndex = 53;
            pictureBox_EMPTY_CART.TabStop = false;
            pictureBox_EMPTY_CART.Click += pictureBox_EMPTY_CART_Click;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 840);
            Controls.Add(pictureBox_EMPTY_CART);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(labelTotal);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            MaximumSize = new Size(1500, 1496);
            MinimumSize = new Size(816, 814);
            Name = "Cart";
            Text = "Cart";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_EMPTY_CART).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private Label label3;
        private Label label6;
        private Label label9;
        private Label label7;
        private Button button5;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private ListView listView1;
        private Label labelTotal;
        private TextBox textBox1;
        private Label label1;
        private Button button4;
        private Button button12;
        private Button button13;
        private PictureBox pictureBox_EMPTY_CART;
    }
}
