using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerControls
{
    public partial class Form1 : Form
    {
        double price = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void friesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblList.Text = lblList.Text + "\n" + "Fries";
            price = price + 1.50;
            lblTotal.Text = String.Format("Total:{0:C}", price);
        }

        private void foodListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hamburger200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblList.Text = lblList.Text + "\n" + "Hamburger";
            price = price + 2.00;
            lblTotal.Text = String.Format("Total:{0:C}",price);
        }

        private void drink100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblList.Text = lblList.Text + "\n" + "Drink";
            price = price + 1.00;
            lblTotal.Text = String.Format("Total:{0:C}", price);
        }
    }
}
