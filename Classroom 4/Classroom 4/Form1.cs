using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            double price = 15000;

            if(chkWindow.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show(
                    "You must make a choice for Power Windows",
                    "Missing Entry");
                return;
            }

            if (chkAir.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show(
                    "You must make a choice for Air Conditioning",
                    "Missing Entry");
                return;
            }

            if (chkChrome.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show(
                    "You must make a choice for Chrome",
                    "Missing Entry");
                return;
            }

            if (chkWindow.Checked == true)
            {
                price = price + 500;
            }

            if (chkAir.Checked == true)
            {
                price = price + 750;
            }

            if (chkChrome.Checked == true)
            {
                price = price + 1000;
            }
            if(rdBusiness.Checked == true)
            {
                price = price - (price * 0.03);
            }

            if(rdBlue.Checked == false && rdWhite.Checked == false)
            {
                MessageBox.Show("You must make a color selection", "Missing Information");
                return;
            }

            lblCalc.Text = String.Format(txtName.Text + ", the cost of your car is {0:C}", price);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
