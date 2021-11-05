
namespace CSC240_06_01_BedAndBreakfast_bpc
{
    partial class BelleAireForm
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
            this.UxBelleAireDescriptionLabel = new System.Windows.Forms.Label();
            this.UxBelleAirePriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UxBelleAireDescriptionLabel
            // 
            this.UxBelleAireDescriptionLabel.AutoSize = true;
            this.UxBelleAireDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxBelleAireDescriptionLabel.Location = new System.Drawing.Point(179, 43);
            this.UxBelleAireDescriptionLabel.Name = "UxBelleAireDescriptionLabel";
            this.UxBelleAireDescriptionLabel.Size = new System.Drawing.Size(656, 84);
            this.UxBelleAireDescriptionLabel.TabIndex = 0;
            this.UxBelleAireDescriptionLabel.Text = "The BelleAire suite has two bedrooms,\r\n two baths, and a private balcony.";
            this.UxBelleAireDescriptionLabel.Click += new System.EventHandler(this.UxBelleAireDescriptionLabel_Click);
            // 
            // UxBelleAirePriceLabel
            // 
            this.UxBelleAirePriceLabel.AutoSize = true;
            this.UxBelleAirePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxBelleAirePriceLabel.Location = new System.Drawing.Point(335, 249);
            this.UxBelleAirePriceLabel.Name = "UxBelleAirePriceLabel";
            this.UxBelleAirePriceLabel.Size = new System.Drawing.Size(271, 42);
            this.UxBelleAirePriceLabel.TabIndex = 1;
            this.UxBelleAirePriceLabel.Text = "$199 per night";
            // 
            // BelleAireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(995, 631);
            this.Controls.Add(this.UxBelleAirePriceLabel);
            this.Controls.Add(this.UxBelleAireDescriptionLabel);
            this.Name = "BelleAireForm";
            this.Text = "BelleAireForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxBelleAireDescriptionLabel;
        private System.Windows.Forms.Label UxBelleAirePriceLabel;
    }
}