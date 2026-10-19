using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        bool bookingApproved = false;
        const decimal TicketPrice = 100m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize booking status
                bookingApproved = false;

                // Get passenger name
                string passengerName = txtPassengerName.Text.Trim();

                // Validate passenger name
                if (passengerName == "")
                {
                    MessageBox.Show("Please enter passenger name.");
                    return;
                }

                // Declare passenger information variables
                int passengerAge;
                int numberOfTickets;
                double baggageWeight;

                // Validate passenger age input
                if (!int.TryParse(txtPassengerAge.Text, out passengerAge))
                {
                    MessageBox.Show("Please enter a valid passenger age.");
                    return;
                }

                // Validate number of tickets input
                if (!int.TryParse(txtNumberOfTickets.Text, out numberOfTickets))
                {
                    MessageBox.Show("Please enter a valid number of tickets.");
                    return;
                }

                // Validate baggage weight input
                if (!double.TryParse(txtBaggageWeight.Text, out baggageWeight))
                {
                    MessageBox.Show("Please enter a valid baggage weight.");
                    return;
                }

                // Check passenger age range
                if (passengerAge < 1 || passengerAge > 100)
                {
                    MessageBox.Show("Passenger age must be between 1 and 100.");
                    return;
                }

                // Check number of tickets range
                if (numberOfTickets < 1 || numberOfTickets > 5)
                {
                    MessageBox.Show("Number of tickets must be between 1 and 5.");
                    return;
                }

                // Check baggage weight range
                if (baggageWeight < 0 || baggageWeight > 50)
                {
                    MessageBox.Show("Baggage weight must be between 0 and 50 kg.");
                    return;
                }

                // Ensure a travel class is selected
                if (!rdoFristClass.Checked &&
                    !rdoNormalClass.Checked &&
                    !rdoBusinessClass.Checked)
                {
                    MessageBox.Show("Please select a travel class.");
                    return;
                }

                // Restrict First Class booking for passengers below 12
                if (passengerAge < 12 && rdoFristClass.Checked)
                {
                    MessageBox.Show(
                        "Booking rejected: Passengers below 12 years cannot book Frist Class."
                    );
                    return;
                }

                // Calculate basic ticket cost
                decimal basicTicketCost = TicketPrice * numberOfTickets;

                // Initialize discount and additional cost variables
                decimal ticketDiscount = 0m;
                decimal ageDiscount = 0m;
                decimal insuranceCost = 0m;
                decimal baggageCost = 0m;
                decimal classCost = 0m;

                // Apply discount for purchasing 3 to 4 tickets
                if (numberOfTickets >= 3 && numberOfTickets <= 4)
                {
                    ticketDiscount = basicTicketCost * 0.05m;
                }
                // Apply discount for purchasing 5 tickets
                else if (numberOfTickets == 5)
                {
                    ticketDiscount = basicTicketCost * 0.10m;
                }

                // Apply age-based discount
                if (passengerAge < 12)
                {
                    ageDiscount = basicTicketCost * 0.20m;
                }
                else if (passengerAge >= 60)
                {
                    ageDiscount = basicTicketCost * 0.10m;
                }

                // Calculate travel insurance cost
                if (chkTravelInsurance.Checked)
                {
                    insuranceCost = 25m * numberOfTickets;
                }

                // Set additional cost according to travel class
                if (rdoFristClass.Checked)
                {
                    classCost = 0m;
                }
                else if (rdoNormalClass.Checked)
                {
                    classCost = 0m;
                }
                else if (rdoBusinessClass.Checked)
                {
                    classCost = 0m;
                }

                // Calculate total discount
                decimal totalDiscount = ticketDiscount + ageDiscount;

                // Calculate final ticket cost
                decimal totalCost =
                    basicTicketCost
                    - totalDiscount
                    + insuranceCost
                    + baggageCost
                    + classCost;

                // Determine selected travel class
                string travelClass = "";

                if (rdoFristClass.Checked)
                    travelClass = "Frist Class";
                else if (rdoNormalClass.Checked)
                    travelClass = "Normal Class";
                else if (rdoBusinessClass.Checked)
                    travelClass = "Business Class";

                // Approve booking after successful validation
                bookingApproved = true;

                // Clear previous booking details
                rtbBookingDetails.Clear();

                // Display booking heading and status
                rtbBookingDetails.AppendText("Airline Ticket Booking Details\r\n");
                rtbBookingDetails.AppendText("------------------------------\r\n");
                rtbBookingDetails.AppendText("Booking Status: Approved\r\n");

                // Display passenger information
                rtbBookingDetails.AppendText("Passenger Name: " + passengerName + "\r\n");
                rtbBookingDetails.AppendText("Passenger Age: " + passengerAge + "\r\n");
                rtbBookingDetails.AppendText("Number of Tickets: " + numberOfTickets + "\r\n");
                rtbBookingDetails.AppendText("Baggage Weight: " + baggageWeight + " kg\r\n");
                rtbBookingDetails.AppendText("Travel Class: " + travelClass + "\r\n");

                // Display basic ticket cost
                rtbBookingDetails.AppendText("Basic Ticket Cost: $" + basicTicketCost.ToString("0.00") + "\r\n");

                // Display discounts
                rtbBookingDetails.AppendText("Ticket Discount: $" + ticketDiscount.ToString("0.00") + "\r\n");
                rtbBookingDetails.AppendText("Age Discount: $" + ageDiscount.ToString("0.00") + "\r\n");
                rtbBookingDetails.AppendText("Total Discount: $" + totalDiscount.ToString("0.00") + "\r\n");

                // Display additional costs
                rtbBookingDetails.AppendText("Travel Insurance: $" + insuranceCost.ToString("0.00") + "\r\n");
                rtbBookingDetails.AppendText("Baggage Cost: $" + baggageCost.ToString("0.00") + "\r\n");
                rtbBookingDetails.AppendText("Class Cost: $" + classCost.ToString("0.00") + "\r\n");

                // Display final total cost
                rtbBookingDetails.AppendText("Total Cost: $" + totalCost.ToString("0.00") + "\r\n");
            }
            catch (Exception ex)
            {
                // Display unexpected error message
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clearing text box
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();

            //clearing radio buttons
            rdoFristClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;

            //clearing check box
            chkTravelInsurance.Checked = false;

            rtbBookingDetails.Clear();

            bookingApproved = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closing window
            this.Close();
        }
    }
}
        
    

