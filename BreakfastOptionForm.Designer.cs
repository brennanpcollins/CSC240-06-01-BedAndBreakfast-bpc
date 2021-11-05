
namespace CSC240_06_01_BedAndBreakfast_bpc
{
    partial class BreakfastOptionForm
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
            this.UxBreakfastDescriptionLabel = new System.Windows.Forms.Label();
            this.UxContRadioButton = new System.Windows.Forms.RadioButton();
            this.UxFullRadioButton = new System.Windows.Forms.RadioButton();
            this.UxDeluxeRadioButton = new System.Windows.Forms.RadioButton();
            this.UxPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UxBreakfastDescriptionLabel
            // 
            this.UxBreakfastDescriptionLabel.AutoSize = true;
            this.UxBreakfastDescriptionLabel.Font = new System.Drawing.Font("Algerian", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxBreakfastDescriptionLabel.Location = new System.Drawing.Point(12, 127);
            this.UxBreakfastDescriptionLabel.Name = "UxBreakfastDescriptionLabel";
            this.UxBreakfastDescriptionLabel.Size = new System.Drawing.Size(717, 48);
            this.UxBreakfastDescriptionLabel.TabIndex = 0;
            this.UxBreakfastDescriptionLabel.Text = "Select your breakfast option:";
            this.UxBreakfastDescriptionLabel.Click += new System.EventHandler(this.UxBreakfastDescriptionLabel_Click);
            // 
            // UxContRadioButton
            // 
            this.UxContRadioButton.AutoSize = true;
            this.UxContRadioButton.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxContRadioButton.Location = new System.Drawing.Point(226, 231);
            this.UxContRadioButton.Name = "UxContRadioButton";
            this.UxContRadioButton.Size = new System.Drawing.Size(263, 39);
            this.UxContRadioButton.TabIndex = 1;
            this.UxContRadioButton.TabStop = true;
            this.UxContRadioButton.Text = "Continental";
            this.UxContRadioButton.UseVisualStyleBackColor = true;
            this.UxContRadioButton.CheckedChanged += new System.EventHandler(this.UxContRadioButton_CheckedChanged);
            // 
            // UxFullRadioButton
            // 
            this.UxFullRadioButton.AutoSize = true;
            this.UxFullRadioButton.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxFullRadioButton.Location = new System.Drawing.Point(226, 311);
            this.UxFullRadioButton.Name = "UxFullRadioButton";
            this.UxFullRadioButton.Size = new System.Drawing.Size(123, 39);
            this.UxFullRadioButton.TabIndex = 2;
            this.UxFullRadioButton.TabStop = true;
            this.UxFullRadioButton.Text = "Full";
            this.UxFullRadioButton.UseVisualStyleBackColor = true;
            this.UxFullRadioButton.CheckedChanged += new System.EventHandler(this.UxFullRadioButton_CheckedChanged);
            // 
            // UxDeluxeRadioButton
            // 
            this.UxDeluxeRadioButton.AutoSize = true;
            this.UxDeluxeRadioButton.Font = new System.Drawing.Font("Algerian", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxDeluxeRadioButton.Location = new System.Drawing.Point(226, 392);
            this.UxDeluxeRadioButton.Name = "UxDeluxeRadioButton";
            this.UxDeluxeRadioButton.Size = new System.Drawing.Size(170, 39);
            this.UxDeluxeRadioButton.TabIndex = 3;
            this.UxDeluxeRadioButton.TabStop = true;
            this.UxDeluxeRadioButton.Text = "Deluxe";
            this.UxDeluxeRadioButton.UseVisualStyleBackColor = true;
            this.UxDeluxeRadioButton.CheckedChanged += new System.EventHandler(this.UxDeluxeRadioButton_CheckedChanged);
            // 
            // UxPriceLabel
            // 
            this.UxPriceLabel.AutoSize = true;
            this.UxPriceLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxPriceLabel.Location = new System.Drawing.Point(444, 548);
            this.UxPriceLabel.Name = "UxPriceLabel";
            this.UxPriceLabel.Size = new System.Drawing.Size(173, 54);
            this.UxPriceLabel.TabIndex = 4;
            this.UxPriceLabel.Text = "Price:";
            // 
            // BreakfastOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 725);
            this.Controls.Add(this.UxPriceLabel);
            this.Controls.Add(this.UxDeluxeRadioButton);
            this.Controls.Add(this.UxFullRadioButton);
            this.Controls.Add(this.UxContRadioButton);
            this.Controls.Add(this.UxBreakfastDescriptionLabel);
            this.Name = "BreakfastOptionForm";
            this.Text = "BreakfastOptionForm";
            this.Load += new System.EventHandler(this.BreakfastOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxBreakfastDescriptionLabel;
        private System.Windows.Forms.RadioButton UxContRadioButton;
        private System.Windows.Forms.RadioButton UxFullRadioButton;
        private System.Windows.Forms.RadioButton UxDeluxeRadioButton;
        private System.Windows.Forms.Label UxPriceLabel;
    }
}