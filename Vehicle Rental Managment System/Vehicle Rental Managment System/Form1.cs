using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Managment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Customer name
                string name = txtname.Text.Trim();

                lstresults.Items.Clear();

                if (string.IsNullOrWhiteSpace(name))
                {
                    lstresults.Items.Add("Please enter customer name.");
                    return;
                }

                // Step 2: Validate numeric inputs
                int age, days, experience;

                if (!int.TryParse(txtage.Text, out age))
                {
                    lstresults.Items.Add("Please enter a valid age.");
                    return;
                }

                if (!int.TryParse(txtdays.Text, out days))
                {
                    lstresults.Items.Add("Please enter valid rental days.");
                    return;
                }

                if (!int.TryParse(txtexperience.Text, out experience))
                {
                    lstresults.Items.Add(
                        "Please enter valid driving experience.");
                    return;
                }

                // Step 3: Validate age
                if (age < 18 || age > 80)
                {
                    lstresults.Items.Add(
                        "Age must be between 18 and 80.");
                    return;
                }

                // Step 4: Validate rental days
                if (days < 1 || days > 30)
                {
                    lstresults.Items.Add(
                        "Rental days must be between 1 and 30.");
                    return;
                }

                // Step 5: Validate driving experience
                if (experience < 0)
                {
                    lstresults.Items.Add(
                        "Driving experience cannot be negative.");
                    return;
                }

                // Step 6: Check eligibility
                if (age < 21)
                {
                    lstresults.Items.Add("RENTAL STATUS: NOT ELIGIBLE");
                    lstresults.Items.Add(
                        "Customer must be at least 21 years old.");
                    return;
                }

                if (experience < 1)
                {
                    lstresults.Items.Add("RENTAL STATUS: NOT ELIGIBLE");
                    lstresults.Items.Add(
                        "At least 1 year of driving experience is required.");
                    return;
                }

                // Step 7: Select vehicle and daily rate
                string vehicleType;
                decimal dailyRate;

                if (rdoeconomy.Checked)
                {
                    vehicleType = "Economy";
                    dailyRate = 35m;
                }
                else if (rdosuv.Checked)
                {
                    vehicleType = "SUV";
                    dailyRate = 60m;
                }
                else if (rdoluxury.Checked)
                {
                    vehicleType = "Luxury";
                    dailyRate = 100m;

                    if (age < 25 || experience < 3)
                    {
                        lstresults.Items.Add(
                            "RENTAL STATUS: NOT ELIGIBLE");
                        lstresults.Items.Add(
                            "Luxury requires age 25+ and 3 years of experience.");
                        return;
                    }
                }
                else
                {
                    lstresults.Items.Add(
                        "Please select a vehicle type.");
                    return;
                }

                // Step 8: Basic rental cost
                decimal basicCost = dailyRate * days;

                // Step 9: Calculate discount
                decimal discountRate = 0m;

                if (days >= 14)
                {
                    discountRate = 0.10m;
                }
                else if (days >= 7)
                {
                    discountRate = 0.05m;
                }

                decimal discount = basicCost * discountRate;

                // Step 10: Calculate insurance
                decimal insuranceCost = 0m;

                if (chkinsurance.Checked)
                {
                    insuranceCost = 15m * days;
                }

                // Step 11: Young driver surcharge
                decimal surcharge = 0m;

                if (age >= 21 && age <= 24)
                {
                    surcharge = basicCost * 0.10m;
                }

                // Step 12: Final rental cost
                decimal finalCost =
                    basicCost - discount + insuranceCost + surcharge;

                // Step 13: Display results in ListBox
                lstresults.Items.Clear();

                lstresults.Items.Add("RENTAL DETAILS");
                lstresults.Items.Add("--------------------------------");

                lstresults.Items.Add("Customer Name: " + name);
                lstresults.Items.Add("Customer Age: " + age);
                lstresults.Items.Add(
                    "Driving Experience: " + experience + " years");
                lstresults.Items.Add("Vehicle Type: " + vehicleType);
                lstresults.Items.Add(
                    "Daily Rate: $" + dailyRate.ToString("0.00"));
                lstresults.Items.Add("Rental Days: " + days);
                lstresults.Items.Add(
                    "Basic Rental Cost: $" + basicCost.ToString("0.00"));
                lstresults.Items.Add(
                    "Discount: -$" + discount.ToString("0.00"));
                lstresults.Items.Add(
                    "Insurance Cost: $" + insuranceCost.ToString("0.00"));
                lstresults.Items.Add(
                    "Young Driver Surcharge: $" +
                    surcharge.ToString("0.00"));

                lstresults.Items.Add("--------------------------------");
                lstresults.Items.Add(
                    "Final Rental Cost: $" + finalCost.ToString("0.00"));
                lstresults.Items.Add("Rental Status: ELIGIBLE");
            }
            catch (Exception ex)
            {
                lstresults.Items.Clear();
                lstresults.Items.Add("An error occurred:");
                lstresults.Items.Add(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtdays.Clear();
            txtexperience.Clear();

            rdoeconomy.Checked = false;
            rdosuv.Checked = false;
            rdoluxury.Checked = false;

            chkinsurance.Checked = false;

            lstresults.Items.Clear();

            txtname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

