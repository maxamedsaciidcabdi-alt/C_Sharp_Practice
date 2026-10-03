using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_With_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            // Declare variables
            double hoursWorked;
            double hourlyPayRate;
            double grossPay;

            try
            {
                // Convert the values entered in the TextBoxes to numbers
                hoursWorked = Convert.ToDouble(hoursWorkedTextBox.Text);
                hourlyPayRate = Convert.ToDouble(hourlyPayRateTextBox.Text);

                // Check if hours worked is valid
                if (hoursWorked >= 0)
                {
                    // Nested if: check if hourly pay rate is valid
                    if (hourlyPayRate >= 0)
                    {
                        // Check if the employee worked overtime
                        if (hoursWorked <= 40)
                        {
                            // No overtime
                            grossPay = hoursWorked * hourlyPayRate;
                        }
                        else
                        {
                            // Calculate regular pay for the first 40 hours
                            double regularPay = 40 * hourlyPayRate;

                            // Calculate overtime hours
                            double overtimeHours = hoursWorked - 40;

                            // Overtime is paid at 1.5 times the normal rate
                            double overtimePay = overtimeHours * hourlyPayRate * 1.5;

                            // Add regular pay and overtime pay
                            grossPay = regularPay + overtimePay;
                        }

                        // Display the gross pay
                        grossPayLabel.Text = grossPay.ToString("C2");
                    }
                    else
                    {
                        // Hourly pay rate cannot be negative
                        MessageBox.Show("Hourly pay rate cannot be negative.");
                    }
                }
                else
                {
                    // Hours worked cannot be negative
                    MessageBox.Show("Hours worked cannot be negative.");
                }
            }
            catch (Exception ex)
            {
                // Runs when the user enters letters or invalid text
                MessageBox.Show("Please enter valid numbers.");
            }
           
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clearing Text Box
            hoursWorkedTextBox.Text = " ";
            hourlyPayRateTextBox.Text = " ";
            grossPayLabel.Text= " ";
        }
    }
}
