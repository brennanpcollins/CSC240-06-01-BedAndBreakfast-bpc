
namespace CSC240_06_01_BedAndBreakfast_bpc
{
    partial class LincolnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LincolnForm));
            this.UxLincolnDescriptionLabel = new System.Windows.Forms.Label();
            this.UxLincolnPriceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UxLincolnDescriptionLabel
            // 
            this.UxLincolnDescriptionLabel.AutoSize = true;
            this.UxLincolnDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxLincolnDescriptionLabel.Location = new System.Drawing.Point(203, 64);
            this.UxLincolnDescriptionLabel.Name = "UxLincolnDescriptionLabel";
            this.UxLincolnDescriptionLabel.Size = new System.Drawing.Size(653, 84);
            this.UxLincolnDescriptionLabel.TabIndex = 0;
            this.UxLincolnDescriptionLabel.Text = "Return to the 1850s in this lovely room\r\n               with a private bath.";
            // 
            // UxLincolnPriceLabel
            // 
            this.UxLincolnPriceLabel.AutoSize = true;
            this.UxLincolnPriceLabel.BackColor = System.Drawing.Color.White;
            this.UxLincolnPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxLincolnPriceLabel.Location = new System.Drawing.Point(494, 270);
            this.UxLincolnPriceLabel.Name = "UxLincolnPriceLabel";
            this.UxLincolnPriceLabel.Size = new System.Drawing.Size(271, 42);
            this.UxLincolnPriceLabel.TabIndex = 1;
            this.UxLincolnPriceLabel.Text = "$110 per night";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LincolnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 717);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UxLincolnPriceLabel);
            this.Controls.Add(this.UxLincolnDescriptionLabel);
            this.Name = "LincolnForm";
            this.Text = "Lincoln Room";
            this.Load += new System.EventHandler(this.LincolnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxLincolnDescriptionLabel;
        private System.Windows.Forms.Label UxLincolnPriceLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}