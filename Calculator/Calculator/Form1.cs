using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSales.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;

            double sales = Convert.ToDouble(txtSales.Text);

            double commission = sales * .02;

            MessageBox.Show(String.Format("Your commission is {0:C}", commission),

            name + "'s Commission",

            MessageBoxButtons.OK,

            MessageBoxIcon.Information
            );



        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.SelectAll();
        }
    }
}
