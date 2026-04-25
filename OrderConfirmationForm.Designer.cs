namespace WinFormsApp2
{
    partial class OrderConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderConfirmationForm));
            label1 = new Label();
            label2 = new Label();
            Home = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(85, 100);
            label1.Name = "label1";
            label1.Size = new Size(405, 38);
            label1.TabIndex = 0;
            label1.Text = "Thanks for shopping!\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(51, 171);
            label2.Name = "label2";
            label2.Size = new Size(498, 33);
            label2.TabIndex = 1;
            label2.Text = "Your order has been confirmed.";
            // 
            // Home
            // 
            Home.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Home.ForeColor = Color.DimGray;
            Home.Location = new Point(195, 384);
            Home.Name = "Home";
            Home.Size = new Size(195, 71);
            Home.TabIndex = 2;
            Home.Text = "Back To Home Page";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(242, 246);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // OrderConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(592, 526);
            Controls.Add(pictureBox1);
            Controls.Add(Home);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderConfirmationForm";
            Text = "OrderConfirmationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Home;
        private PictureBox pictureBox1;
    }
}