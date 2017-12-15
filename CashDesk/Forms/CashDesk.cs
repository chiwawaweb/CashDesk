using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashDesk.Forms
{
    public partial class CashDesk : Form
    {
        public CashDesk()
        {
            InitializeComponent();
        }

        private void BtnT0_Click(object sender, EventArgs e)
        {
            DisplayDigit(0);
        }

        private void DisplayDigit(int digit)
        {
            TxtEcranSaisie.Text += digit.ToString();
        }

        private void BtnT1_Click(object sender, EventArgs e)
        {
            DisplayDigit(1);
        }

        private void BtnTC_Click(object sender, EventArgs e)
        {
            int l = TxtEcranSaisie.Text.Length;
            if (l > 0)
            {
                TxtEcranSaisie.Text = TxtEcranSaisie.Text.Substring(0, l - 1);
            }
        }

        private void BtnT3_Click(object sender, EventArgs e)
        {
            DisplayDigit(3);
        }

        private void BtnT4_Click(object sender, EventArgs e)
        {
            DisplayDigit(4);
        }

        private void BtnT2_Click(object sender, EventArgs e)
        {
            DisplayDigit(2);
        }

        private void BtnT5_Click(object sender, EventArgs e)
        {
            DisplayDigit(5);
        }

        private void BtnT6_Click(object sender, EventArgs e)
        {
            DisplayDigit(6);
        }

        private void BtnT7_Click(object sender, EventArgs e)
        {
            DisplayDigit(7);
        }

        private void BtnT8_Click(object sender, EventArgs e)
        {
            DisplayDigit(8);
        }

        private void BtnT9_Click(object sender, EventArgs e)
        {
            DisplayDigit(9);
        }
    }
}
