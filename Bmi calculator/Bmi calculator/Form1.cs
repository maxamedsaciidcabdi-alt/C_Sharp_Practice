using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bmi_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // try block
            try
            {
                // Creating Variables
                double weight;
                double height;

                // Validate weight
                if (!double.TryParse(txtWeight.Text, out weight) || weight <= 0)
                {
                    MessageBox.Show("Please enter a valid weight in kg.");
                   
                }

                // Validate height
                if (!double.TryParse(txtHeight.Text, out height) || height <= 0)
                {
                    MessageBox.Show("Please enter a valid height in meters.");
                    return;
                }
                // Using if-else 
                double heightSquared;

                if (height > 0)
                {
                    heightSquared = height * height;
                }
                else
                {
                    MessageBox.Show("Height must be greater than zero.");
                    return;
                }

                // Calculate BMI
                double bmi = weight / heightSquared;

                // Displaying result
                lblBMI.Text = bmi.ToString("F2");

                // Display BMI category
                if (bmi < 18.5)
                {
                    lblCategory.Text = "Underweight";
                }
                else if (bmi < 25)
                {
                    lblCategory.Text = "Optimal weight";
                }
                else if (bmi < 30)
                {
                    lblCategory.Text = "Overweight";
                }
                else
                {
                    lblCategory.Text = "Obesity";
                }
            }

            catch
            {
                MessageBox.Show("Enter Valid Details");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clearing Textboxes
            txtWeight.Text = String.Empty;
            txtHeight.Text = String.Empty;
            // Clearing Labels
            lblBMI.Text = "";
            lblCategory.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closing the program
            this.Close();
        }
    }
}
