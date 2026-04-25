
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp2
{
    partial class Checkout
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            Name_checkout = new TextBox();
            button_checkout = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label13 = new Label();
            label14 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            label4 = new Label();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button12 = new Button();
            button13 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            label15 = new Label();
            pictureBox3 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 97);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Details:";
            // 
            // Name_checkout
            // 
            Name_checkout.BackColor = Color.DarkTurquoise;
            Name_checkout.BorderStyle = BorderStyle.FixedSingle;
            Name_checkout.ForeColor = SystemColors.ButtonHighlight;
            Name_checkout.Location = new Point(182, 320);
            Name_checkout.Margin = new Padding(2);
            Name_checkout.Name = "Name_checkout";
            Name_checkout.PlaceholderText = "Enter Your Email";
            Name_checkout.Size = new Size(278, 27);
            Name_checkout.TabIndex = 2;
            // 
            // button_checkout
            // 
            button_checkout.BackColor = SystemColors.ButtonFace;
            button_checkout.Location = new Point(282, 554);
            button_checkout.Margin = new Padding(2);
            button_checkout.Name = "button_checkout";
            button_checkout.Size = new Size(90, 27);
            button_checkout.TabIndex = 6;
            button_checkout.Text = "Check Out";
            button_checkout.UseVisualStyleBackColor = false;
            button_checkout.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkTurquoise;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(182, 370);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Your Address";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkTurquoise;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.ForeColor = SystemColors.ButtonHighlight;
            textBox3.Location = new Point(182, 419);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter Your Phone Number";
            textBox3.Size = new Size(278, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkTurquoise;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(182, 272);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Your Name";
            textBox2.Size = new Size(278, 27);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(182, 498);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "COD";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(346, 498);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 24);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Card";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 466);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 14;
            label2.Text = "Payment Method:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.103447F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.89655F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Location = new Point(-7, 602);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(8, 8, 8, 8);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 56.9444427F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 43.0555573F));
            tableLayoutPanel1.Size = new Size(652, 147);
            tableLayoutPanel1.TabIndex = 17;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label13, 0, 0);
            tableLayoutPanel5.Controls.Add(label14, 0, 1);
            tableLayoutPanel5.Location = new Point(385, 84);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2258072F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7741928F));
            tableLayoutPanel5.Size = new Size(253, 52);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(2, 0);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(113, 20);
            label13.TabIndex = 0;
            label13.Text = "instagram page";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(2, 27);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(109, 20);
            label14.TabIndex = 1;
            label14.Text = "facebook page";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Controls.Add(label11, 0, 1);
            tableLayoutPanel2.Controls.Add(label12, 0, 2);
            tableLayoutPanel2.Location = new Point(385, 10);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2258072F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7741928F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(253, 70);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(2, 0);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 0;
            label8.Text = "Contact";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(2, 21);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(51, 18);
            label11.TabIndex = 1;
            label11.Text = "phone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(2, 39);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 2;
            label12.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 82);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 1;
            label4.Text = "ISB Pakistan";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 40);
            label3.TabIndex = 0;
            label3.Text = "Tiny Treasure Shop";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(label6, 0, 1);
            tableLayoutPanel3.Controls.Add(label7, 0, 2);
            tableLayoutPanel3.Location = new Point(134, 10);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2258072F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7741928F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.Size = new Size(228, 70);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(2, 0);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 0;
            label5.Text = "Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 21);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 18);
            label6.TabIndex = 1;
            label6.Text = "Home";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 39);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 2;
            label7.Text = "About us";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label9, 0, 0);
            tableLayoutPanel4.Controls.Add(label10, 0, 1);
            tableLayoutPanel4.Location = new Point(134, 84);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2258072F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7741928F));
            tableLayoutPanel4.Size = new Size(228, 52);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 0);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 0;
            label9.Text = "locations";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(2, 27);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 1;
            label10.Text = "products";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.checkout1;
            pictureBox1.Location = new Point(211, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 107);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(534, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(111, 252);
            panel1.TabIndex = 47;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // button12
            // 
            button12.BackColor = Color.MediumTurquoise;
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.ForeColor = SystemColors.ControlDarkDark;
            button12.Location = new Point(1, 153);
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
            button13.Location = new Point(1, 103);
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
            button3.Location = new Point(-2, 201);
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
            // button4
            // 
            button4.BackColor = Color.MediumTurquoise;
            button4.Dock = DockStyle.Top;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlDarkDark;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(111, 29);
            button4.TabIndex = 0;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumTurquoise;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlDarkDark;
            button5.Location = new Point(539, 12);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 46;
            button5.Text = "Navigate";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Turquoise;
            pictureBox2.Image = Properties.Resources.LOGO;
            pictureBox2.Location = new Point(8, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label15.BackColor = Color.Turquoise;
            label15.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.ImageAlign = ContentAlignment.BottomLeft;
            label15.Location = new Point(-7, -2);
            label15.MinimumSize = new Size(810, 60);
            label15.Name = "label15";
            label15.Size = new Size(810, 60);
            label15.TabIndex = 48;
            label15.Text = "             Checkout ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Burger_Bar_free_icons_designed_by_Febrian_Hidayat;
            pictureBox3.Location = new Point(508, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 50;
            pictureBox3.TabStop = false;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(645, 746);
            Controls.Add(pictureBox3);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Controls.Add(label15);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(button_checkout);
            Controls.Add(Name_checkout);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Checkout";
            Text = "Checkout";
            Load += Checkout_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Name_checkout;
        private Button button_checkout;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label9;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label13;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox2;
        private Label label15;
        private PictureBox pictureBox3;
        private Button button12;
        private Button button13;
    }
}
