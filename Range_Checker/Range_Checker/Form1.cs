using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {


            // Declare a variable to store the number
            int number;

            try
            {
                //  converting the TextBox value into an integer
                if (int.TryParse(numberTextBox.Text, out number))
                {
                    // Check if the number is between 1 and 10
                    // && means AND
                    if (number >= 1 && number <= 10)
                    {
                        // Number is inside the required range
                        rangeDecisionTextBox.Text = "The number is in the range.";
                    }
                    else
                    {
                        // Number is outside the required range
                        rangeDecisionTextBox.Text = "The number is outside the range.";
                    }
                }
                else
                {
                    // The user did not enter a valid integer
                    MessageBox.Show("Please enter a valid integer.");
                }
            }
            catch (Exception ex)
            {
                // Handles unexpected errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
    

        private void clearbtn_Click(object sender, EventArgs e)
        {
            // Clearing text box and label
            numberTextBox.Clear();
            rangeDecisionTextBox.Text = " ";

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            // Closing 
            this.Close();
        }
    }
}
