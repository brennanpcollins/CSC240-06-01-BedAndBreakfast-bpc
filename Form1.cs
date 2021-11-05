using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_06_01_BedAndBreakfast_bpc
{
    public partial class BaileysForm : Form
    {
        public BaileysForm()
        {
            InitializeComponent();
        }

        private void UxBelleAireCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (UxBelleAireCheckBox1.Checked)
            {
                BelleAireForm belleAireForm = new BelleAireForm();
                belleAireForm.ShowDialog();
                UxBelleAireCheckBox1.Checked = false;
            }
        }

        private void UxLincolnCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (UxLincolnCheckBox1.Checked)
            {
                LincolnForm lincolnForm = new LincolnForm();
                lincolnForm.ShowDialog();
                UxLincolnCheckBox1.Checked = false;
            }
        }

        private void UxMealButton_Click(object sender, EventArgs e)
        {
            BreakfastOptionForm breakfastform = new
                BreakfastOptionForm();
            breakfastform.ShowDialog();
        }
    }
}
