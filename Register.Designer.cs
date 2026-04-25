namespace WinFormsApp2
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox_Username = new TextBox();
            textBox_Email = new TextBox();
            textBox_Password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox_Confirm_Pass = new TextBox();
            label6 = new Label();
            button_login = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Brush Script MT", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(64, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 34);
            label1.TabIndex = 16;
            label1.Text = "Tiny Treasure Store";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Turquoise;
            pictureBox1.Image = Properties.Resources.LOGO;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // textBox_Username
            // 
            textBox_Username.BackColor = Color.Turquoise;
            textBox_Username.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox_Username.ForeColor = SystemColors.WindowFrame;
            textBox_Username.Location = new Point(196, 210);
            textBox_Username.Margin = new Padding(2);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(408, 30);
            textBox_Username.TabIndex = 18;
            textBox_Username.TextChanged += textBox_Username_TextChanged;
            // 
            // textBox_Email
            // 
            textBox_Email.BackColor = Color.Turquoise;
            textBox_Email.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox_Email.ForeColor = SystemColors.WindowFrame;
            textBox_Email.Location = new Point(196, 311);
            textBox_Email.Margin = new Padding(2);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(408, 30);
            textBox_Email.TabIndex = 19;
            textBox_Email.TextChanged += textBox_Email_TextChanged;
            // 
            // textBox_Password
            // 
            textBox_Password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Password.BackColor = Color.Turquoise;
            textBox_Password.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox_Password.ForeColor = SystemColors.WindowFrame;
            textBox_Password.Location = new Point(196, 410);
            textBox_Password.Margin = new Padding(2);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(408, 30);
            textBox_Password.TabIndex = 20;
            textBox_Password.TextChanged += textBox_Password_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(323, 103);
            label2.Name = "label2";
            label2.Size = new Size(101, 31);
            label2.TabIndex = 21;
            label2.Text = "Register";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 172);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 22;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 272);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 23;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 370);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 24;
            label5.Text = "Password";
            // 
            // textBox_Confirm_Pass
            // 
            textBox_Confirm_Pass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Confirm_Pass.BackColor = Color.Turquoise;
            textBox_Confirm_Pass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox_Confirm_Pass.ForeColor = SystemColors.WindowFrame;
            textBox_Confirm_Pass.Location = new Point(196, 501);
            textBox_Confirm_Pass.Margin = new Padding(2);
            textBox_Confirm_Pass.Name = "textBox_Confirm_Pass";
            textBox_Confirm_Pass.Size = new Size(408, 30);
            textBox_Confirm_Pass.TabIndex = 25;
            textBox_Confirm_Pass.TextChanged += textBox_Confirm_Pass_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 467);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 26;
            label6.Text = "Confirm Password";
            // 
            // button_login
            // 
            button_login.BackColor = Color.Gainsboro;
            button_login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_login.ForeColor = SystemColors.ControlDarkDark;
            button_login.Location = new Point(299, 599);
            button_login.Margin = new Padding(2);
            button_login.Name = "button_login";
            button_login.Size = new Size(184, 37);
            button_login.TabIndex = 27;
            button_login.Text = "Register Now";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(178, 164);
            label7.Name = "label7";
            label7.Size = new Size(21, 28);
            label7.TabIndex = 28;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(178, 265);
            label8.Name = "label8";
            label8.Size = new Size(21, 28);
            label8.TabIndex = 29;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(178, 363);
            label9.Name = "label9";
            label9.Size = new Size(21, 28);
            label9.TabIndex = 30;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(178, 459);
            label10.Name = "label10";
            label10.Size = new Size(21, 28);
            label10.TabIndex = 31;
            label10.Text = "*";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 686);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button_login);
            Controls.Add(label6);
            Controls.Add(textBox_Confirm_Pass);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Username);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox_Username;
        private TextBox textBox_Email;
        private TextBox textBox_Password;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox_Confirm_Pass;
        private Label label6;
        private Button button_login;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}