using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            try
            {

                // creating variables
                String food1 = txtfood1.Text;
                int food1price = int.Parse(txtfood1price.Text);
                String food2 = txtfood2.Text;
                int food2price = int.Parse(txtfood2price.Text);

                // calculating tax by multiplying 0.07
                double tax = (food1price + food2price) * 0.07;
                // calculating final total
                double total = food1price + food2price + tax;
                // output
                lbloutput.Text ="Total is: " + (total.ToString()) + " Tax is: " + (tax.ToString());
            }

            catch 
            {
                // Error telling message
                MessageBox.Show("Pease enter valid info.");
            }
        }
    }
}
