﻿
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
            this.UxBelleAireCheckBox1 = new System.Windows.Forms.CheckBox();
            this.UxLincolnCheckBox1 = new System.Windows.Forms.CheckBox();
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
            this.UxRateLabel.Location = new System.Drawing.Point(329, 158);
            this.UxRateLabel.Name = "UxRateLabel";
            this.UxRateLabel.Size = new System.Drawing.Size(325, 51);
            this.UxRateLabel.TabIndex = 1;
            this.UxRateLabel.Text = "Check our rates";
            // 
            // UxBelleAireCheckBox1
            // 
            this.UxBelleAireCheckBox1.AutoSize = true;
            this.UxBelleAireCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxBelleAireCheckBox1.Location = new System.Drawing.Point(329, 274);
            this.UxBelleAireCheckBox1.Name = "UxBelleAireCheckBox1";
            this.UxBelleAireCheckBox1.Size = new System.Drawing.Size(320, 46);
            this.UxBelleAireCheckBox1.TabIndex = 2;
            this.UxBelleAireCheckBox1.Text = "Belle Aire Suite";
            this.UxBelleAireCheckBox1.UseVisualStyleBackColor = true;
            // 
            // UxLincolnCheckBox1
            // 
            this.UxLincolnCheckBox1.AutoSize = true;
            this.UxLincolnCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UxLincolnCheckBox1.Location = new System.Drawing.Point(329, 341);
            this.UxLincolnCheckBox1.Name = "UxLincolnCheckBox1";
            this.UxLincolnCheckBox1.Size = new System.Drawing.Size(290, 46);
            this.UxLincolnCheckBox1.TabIndex = 3;
            this.UxLincolnCheckBox1.Text = "Lincoln Room";
            this.UxLincolnCheckBox1.UseVisualStyleBackColor = true;
            // 
            // BaileysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1022, 763);
            this.Controls.Add(this.UxLincolnCheckBox1);
            this.Controls.Add(this.UxBelleAireCheckBox1);
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
        private System.Windows.Forms.CheckBox UxBelleAireCheckBox1;
        private System.Windows.Forms.CheckBox UxLincolnCheckBox1;
    }
}

