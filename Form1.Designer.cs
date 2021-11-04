
namespace CSC240_06_01_BedAndBreakfast_bpc
{
    partial class BaileysForm
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
            this.UxWelcomeLabel = new System.Windows.Forms.Label();
            this.UxRateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UxWelcomeLabel
            // 
            this.UxWelcomeLabel.AutoSize = true;
            this.UxWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxWelcomeLabel.Location = new System.Drawing.Point(271, 72);
            this.UxWelcomeLabel.Name = "UxWelcomeLabel";
            this.UxWelcomeLabel.Size = new System.Drawing.Size(472, 55);
            this.UxWelcomeLabel.TabIndex = 0;
            this.UxWelcomeLabel.Text = "Welcome to Bailey\'s";
            // 
            // UxRateLabel
            // 
            this.UxRateLabel.AutoSize = true;
            this.UxRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxRateLabel.Location = new System.Drawing.Point(335, 199);
            this.UxRateLabel.Name = "UxRateLabel";
            this.UxRateLabel.Size = new System.Drawing.Size(325, 51);
            this.UxRateLabel.TabIndex = 1;
            this.UxRateLabel.Text = "Check our rates";
            // 
            // BaileysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1022, 763);
            this.Controls.Add(this.UxRateLabel);
            this.Controls.Add(this.UxWelcomeLabel);
            this.Name = "BaileysForm";
            this.Text = "Bailey\'s Bed and Breakfast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxWelcomeLabel;
        private System.Windows.Forms.Label UxRateLabel;
    }
}

