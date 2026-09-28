using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            // stage of input
            // creating variables
            String day_of_the_week, Name_of_the_month,Fulldate;
            int NumericDay;
            int Year;

            //initial values to variables
            day_of_the_week = txtdayoftheweek.Text;
            Name_of_the_month = txtmonth.Text;
            NumericDay = int.Parse(txtnumericofmonth.Text);
            Year = int.Parse(txtyear.Text);

            // stage process concatination of full date
            Fulldate = day_of_the_week + "," + Name_of_the_month + "," + NumericDay + "," + Year;

            //Stage 3 : The output

            lbloutput.Text = Fulldate;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clearing textbox
            txtdayoftheweek.Clear();
            txtmonth.Clear();
            txtnumericofmonth.Clear();
            txtyear.Clear();
            // clearing label - not used function
            lbloutput.Text = "";
            //lbloutput.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // form close - using this keyword and close function
            this.Close();
        }

        private void txtmonth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
