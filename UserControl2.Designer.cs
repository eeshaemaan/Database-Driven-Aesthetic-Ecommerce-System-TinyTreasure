namespace WinFormsApp2
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productPictureBox = new PictureBox();
            nameLabel = new Label();
            priceLabel = new Label();
            viewButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            SuspendLayout();
            // 
            // productPictureBox
            // 
            productPictureBox.Location = new Point(53, 22);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(165, 196);
            productPictureBox.TabIndex = 0;
            productPictureBox.TabStop = false;
            productPictureBox.Click += ProductCard_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.LightSeaGreen;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ButtonHighlight;
            nameLabel.Location = new Point(28, 238);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(104, 25);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "nameLabel";
            nameLabel.Click += ProductCard_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = Color.LightSeaGreen;
            priceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.ForeColor = SystemColors.ButtonHighlight;
            priceLabel.Location = new Point(28, 289);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(99, 25);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "priceLabel";
            priceLabel.Click += ProductCard_Click;
            // 
            // viewButton
            // 
            viewButton.BackColor = Color.LightSeaGreen;
            viewButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewButton.ForeColor = SystemColors.ButtonHighlight;
            viewButton.Location = new Point(121, 340);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(134, 52);
            viewButton.TabIndex = 3;
            viewButton.Text = "Details";
            viewButton.UseVisualStyleBackColor = false;
            viewButton.Click += ProductCard_Click;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(viewButton);
            Controls.Add(priceLabel);
            Controls.Add(nameLabel);
            Controls.Add(productPictureBox);
            Name = "ProductCard";
            Size = new Size(269, 411);
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productPictureBox;
        private Label nameLabel;
        private Label priceLabel;
        private Button viewButton;
    }
}
