
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp2
{
    partial class Login
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
            textBox_Username = new TextBox();
            textBox_Email = new TextBox();
            textBox_Password = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            button_login = new Button();
            button_register = new Button();
            label_new_user = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Username
            // 
            textBox_Username.BackColor = Color.Turquoise;
            textBox_Username.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox_Username.ForeColor = SystemColors.WindowFrame;
            textBox_Username.Location = new Point(226, 282);
            textBox_Username.Margin = new Padding(2);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(408, 30);
            textBox_Username.TabIndex = 0;
            textBox_Username.TextChanged += textBox1_TextChanged;
            // 
            // textBox_Email
            // 
            textBox_Email.BackColor = Color.Turquoise;
            textBox_Email.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox_Email.ForeColor = SystemColors.WindowFrame;
            textBox_Email.Location = new Point(226, 343);
            textBox_Email.Margin = new Padding(2);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(408, 30);
            textBox_Email.TabIndex = 1;
            textBox_Email.TextChanged += textBox_Email_TextChanged;
            // 
            // textBox_Password
            // 
            textBox_Password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Password.BackColor = Color.Turquoise;
            textBox_Password.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox_Password.ForeColor = SystemColors.WindowFrame;
            textBox_Password.Location = new Point(226, 410);
            textBox_Password.Margin = new Padding(2);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(408, 30);
            textBox_Password.TabIndex = 6;
            textBox_Password.TextChanged += textBox_Password_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LOGO;
            pictureBox3.Location = new Point(319, 86);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 151);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
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
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 60);
            panel1.TabIndex = 16;
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
            // button_login
            // 
            button_login.BackColor = Color.Gainsboro;
            button_login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_login.ForeColor = SystemColors.ControlDarkDark;
            button_login.Location = new Point(319, 464);
            button_login.Margin = new Padding(2);
            button_login.Name = "button_login";
            button_login.Size = new Size(184, 37);
            button_login.TabIndex = 8;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button1_Click;
            // 
            // button_register
            // 
            button_register.BackColor = Color.Gainsboro;
            button_register.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_register.ForeColor = SystemColors.ControlDarkDark;
            button_register.Location = new Point(328, 585);
            button_register.Margin = new Padding(2);
            button_register.Name = "button_register";
            button_register.Size = new Size(184, 37);
            button_register.TabIndex = 28;
            button_register.Text = "Register Now";
            button_register.UseVisualStyleBackColor = false;
            button_register.Click += button_register_Click;
            // 
            // label_new_user
            // 
            label_new_user.AutoSize = true;
            label_new_user.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_new_user.ForeColor = SystemColors.ControlDarkDark;
            label_new_user.Location = new Point(64, 531);
            label_new_user.Name = "label_new_user";
            label_new_user.Size = new Size(118, 28);
            label_new_user.TabIndex = 29;
            label_new_user.Text = "New User ?";
            label_new_user.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(226, 253);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 30;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(226, 318);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 31;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(226, 385);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 32;
            label4.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(827, 633);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label_new_user);
            Controls.Add(button_register);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(button_login);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Username);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "Login";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Username;
        private TextBox textBox_Email;
        private TextBox textBox_Password;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Button button_login;
        private Button button_register;
        private Label label_new_user;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
