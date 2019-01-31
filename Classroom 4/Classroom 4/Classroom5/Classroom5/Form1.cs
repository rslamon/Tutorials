using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom5
{
    public partial class Form1 : Form
    {
        public string[] sNames = new string[] { "Bob", "Mike","Steve","Larry","Sally" };
        public Form1()
        {


            InitializeComponent();
            FillList();
        }

      
        private void FillList()
        {
           

            for (int i =0; i < sNames.Length; i++)
            {
                listBooze.Items.Add(sNames[i]);
               
            }
        }

        private void RemoveList()
        {
           for(int a = 0; a <= listBooze.Items.Count; a++)
            {
                if(txtRemove.Text == Convert.ToString(listBooze.Items[a]))
                {
                    listBooze.Items.Remove(txtRemove.Text);
                }
            }
        }
           

                private void btnRemove_Click(object sender, EventArgs e)
                {
                   if (txtRemove.Text.Length > 0)
            {
                RemoveList();
            }
            else
            {
                MessageBox.Show("You need to enter a name");
                return;
            }

                }

        private void listBooze_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You have chosen " + Convert.ToString(listBooze.SelectedItem));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtAdd.Text.Length > 0)
            {
                listBooze.Items.Add(txtAdd.Text);
            }
            else
            {
                MessageBox.Show("You need to add a name.");
                return;
            }
            
        }
    }
}
