using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0;

            if (chkHamburger.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("You must make a choice for hamburger","Missing Entry");
                return;
            }

            if (chkFries.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("You must make a choice for fries", "Missing Entry");
                return;
            }

            if (chkDrink.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("You must make a choice for a drink", "Missing Entry");
                return;
            }

            if(rdCake.Checked == false && rdIce.Checked == false){

                MessageBox.Show("You must make a dessert selection", "Missing Information");
                return;

            }

            if(chkHamburger.Checked == true)
            {
                price = price + 2.00;
            }

            if (chkFries.Checked == true)
            {
                price = price + 1.50;
            }

            if (chkDrink.Checked == true)
            {
                price = price + 1.00;
            }

            lblCalc.Text = String.Format("Your total price is {0:C} .", price);
        }
    }
}
