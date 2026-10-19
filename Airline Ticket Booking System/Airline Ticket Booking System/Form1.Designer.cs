namespace Airline_Ticket_Booking_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAirlineTicket = new System.Windows.Forms.Label();
            this.lblPersonalInfo = new System.Windows.Forms.GroupBox();
            this.lblPassengerName = new System.Windows.Forms.Label();
            this.lblPassengerAge = new System.Windows.Forms.Label();
            this.lblNumberOfTrickets = new System.Windows.Forms.Label();
            this.lblBaggageWeight = new System.Windows.Forms.Label();
            this.txtPassengerAge = new System.Windows.Forms.TextBox();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.lblTravelClass = new System.Windows.Forms.GroupBox();
            this.rtbBookingDetails = new System.Windows.Forms.RichTextBox();
            this.rdoFristClass = new System.Windows.Forms.RadioButton();
            this.rdoNormalClass = new System.Windows.Forms.RadioButton();
            this.rdoBusinessClass = new System.Windows.Forms.RadioButton();
            this.lblAditionalOption = new System.Windows.Forms.GroupBox();
            this.chkTravelInsurance = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPersonalInfo.SuspendLayout();
            this.lblTravelClass.SuspendLayout();
            this.lblAditionalOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAirlineTicket
            // 
            this.lblAirlineTicket.BackColor = System.Drawing.Color.Blue;
            this.lblAirlineTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAirlineTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirlineTicket.ForeColor = System.Drawing.Color.White;
            this.lblAirlineTicket.Location = new System.Drawing.Point(0, 0);
            this.lblAirlineTicket.Name = "lblAirlineTicket";
            this.lblAirlineTicket.Size = new System.Drawing.Size(1296, 62);
            this.lblAirlineTicket.TabIndex = 0;
            this.lblAirlineTicket.Text = "Airline Ticket Booking System";
            this.lblAirlineTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.BackColor = System.Drawing.Color.SkyBlue;
            this.lblPersonalInfo.Controls.Add(this.txtPassengerName);
            this.lblPersonalInfo.Controls.Add(this.txtNumberOfTickets);
            this.lblPersonalInfo.Controls.Add(this.txtPassengerAge);
            this.lblPersonalInfo.Controls.Add(this.txtBaggageWeight);
            this.lblPersonalInfo.Controls.Add(this.lblBaggageWeight);
            this.lblPersonalInfo.Controls.Add(this.lblNumberOfTrickets);
            this.lblPersonalInfo.Controls.Add(this.lblPassengerAge);
            this.lblPersonalInfo.Controls.Add(this.lblPassengerName);
            this.lblPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalInfo.Location = new System.Drawing.Point(8, 75);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(692, 239);
            this.lblPersonalInfo.TabIndex = 1;
            this.lblPersonalInfo.TabStop = false;
            this.lblPersonalInfo.Text = "Personal Information";
            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Location = new System.Drawing.Point(42, 51);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(174, 22);
            this.lblPassengerName.TabIndex = 0;
            this.lblPassengerName.Text = "Passenger Name :";
            // 
            // lblPassengerAge
            // 
            this.lblPassengerAge.AutoSize = true;
            this.lblPassengerAge.Location = new System.Drawing.Point(58, 90);
            this.lblPassengerAge.Name = "lblPassengerAge";
            this.lblPassengerAge.Size = new System.Drawing.Size(158, 22);
            this.lblPassengerAge.TabIndex = 1;
            this.lblPassengerAge.Text = "Passenger Age :";
            // 
            // lblNumberOfTrickets
            // 
            this.lblNumberOfTrickets.AutoSize = true;
            this.lblNumberOfTrickets.Location = new System.Drawing.Point(24, 127);
            this.lblNumberOfTrickets.Name = "lblNumberOfTrickets";
            this.lblNumberOfTrickets.Size = new System.Drawing.Size(192, 22);
            this.lblNumberOfTrickets.TabIndex = 2;
            this.lblNumberOfTrickets.Text = "Number of Trickets :";
            // 
            // lblBaggageWeight
            // 
            this.lblBaggageWeight.AutoSize = true;
            this.lblBaggageWeight.Location = new System.Drawing.Point(6, 164);
            this.lblBaggageWeight.Name = "lblBaggageWeight";
            this.lblBaggageWeight.Size = new System.Drawing.Size(210, 22);
            this.lblBaggageWeight.TabIndex = 3;
            this.lblBaggageWeight.Text = "Baggage Weight (kg) :";
            // 
            // txtPassengerAge
            // 
            this.txtPassengerAge.Location = new System.Drawing.Point(258, 84);
            this.txtPassengerAge.Name = "txtPassengerAge";
            this.txtPassengerAge.Size = new System.Drawing.Size(273, 28);
            this.txtPassengerAge.TabIndex = 4;
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Location = new System.Drawing.Point(258, 121);
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(273, 28);
            this.txtNumberOfTickets.TabIndex = 5;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Location = new System.Drawing.Point(258, 158);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(273, 28);
            this.txtBaggageWeight.TabIndex = 6;
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(258, 47);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(273, 28);
            this.txtPassengerName.TabIndex = 7;
            // 
            // lblTravelClass
            // 
            this.lblTravelClass.Controls.Add(this.rdoBusinessClass);
            this.lblTravelClass.Controls.Add(this.rdoNormalClass);
            this.lblTravelClass.Controls.Add(this.rdoFristClass);
            this.lblTravelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTravelClass.Location = new System.Drawing.Point(13, 344);
            this.lblTravelClass.Name = "lblTravelClass";
            this.lblTravelClass.Size = new System.Drawing.Size(687, 108);
            this.lblTravelClass.TabIndex = 2;
            this.lblTravelClass.TabStop = false;
            this.lblTravelClass.Text = "Travel Class";
            // 
            // rtbBookingDetails
            // 
            this.rtbBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBookingDetails.Location = new System.Drawing.Point(758, 86);
            this.rtbBookingDetails.Name = "rtbBookingDetails";
            this.rtbBookingDetails.Size = new System.Drawing.Size(526, 591);
            this.rtbBookingDetails.TabIndex = 3;
            this.rtbBookingDetails.Text = "Airline Booking Details";
            // 
            // rdoFristClass
            // 
            this.rdoFristClass.AutoSize = true;
            this.rdoFristClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFristClass.Location = new System.Drawing.Point(23, 41);
            this.rdoFristClass.Name = "rdoFristClass";
            this.rdoFristClass.Size = new System.Drawing.Size(119, 24);
            this.rdoFristClass.TabIndex = 0;
            this.rdoFristClass.TabStop = true;
            this.rdoFristClass.Text = "Frist Class";
            this.rdoFristClass.UseVisualStyleBackColor = true;
            // 
            // rdoNormalClass
            // 
            this.rdoNormalClass.AutoSize = true;
            this.rdoNormalClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNormalClass.Location = new System.Drawing.Point(278, 41);
            this.rdoNormalClass.Name = "rdoNormalClass";
            this.rdoNormalClass.Size = new System.Drawing.Size(139, 24);
            this.rdoNormalClass.TabIndex = 1;
            this.rdoNormalClass.TabStop = true;
            this.rdoNormalClass.Text = "Normal Class";
            this.rdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // rdoBusinessClass
            // 
            this.rdoBusinessClass.AutoSize = true;
            this.rdoBusinessClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBusinessClass.Location = new System.Drawing.Point(501, 41);
            this.rdoBusinessClass.Name = "rdoBusinessClass";
            this.rdoBusinessClass.Size = new System.Drawing.Size(156, 24);
            this.rdoBusinessClass.TabIndex = 2;
            this.rdoBusinessClass.TabStop = true;
            this.rdoBusinessClass.Text = "Business Class";
            this.rdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // lblAditionalOption
            // 
            this.lblAditionalOption.Controls.Add(this.chkTravelInsurance);
            this.lblAditionalOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAditionalOption.Location = new System.Drawing.Point(13, 478);
            this.lblAditionalOption.Name = "lblAditionalOption";
            this.lblAditionalOption.Size = new System.Drawing.Size(687, 84);
            this.lblAditionalOption.TabIndex = 4;
            this.lblAditionalOption.TabStop = false;
            this.lblAditionalOption.Text = "Aditional Options";
            // 
            // chkTravelInsurance
            // 
            this.chkTravelInsurance.AutoSize = true;
            this.chkTravelInsurance.Location = new System.Drawing.Point(23, 42);
            this.chkTravelInsurance.Name = "chkTravelInsurance";
            this.chkTravelInsurance.Size = new System.Drawing.Size(371, 26);
            this.chkTravelInsurance.TabIndex = 0;
            this.chkTravelInsurance.Text = "Add Travel insurance ($25 Per ticket)";
            this.chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(36, 600);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 58);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(302, 600);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 58);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(542, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 58);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1296, 679);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAditionalOption);
            this.Controls.Add(this.rtbBookingDetails);
            this.Controls.Add(this.lblTravelClass);
            this.Controls.Add(this.lblPersonalInfo);
            this.Controls.Add(this.lblAirlineTicket);
            this.Name = "Form1";
            this.Text = "Form1";
            this.lblPersonalInfo.ResumeLayout(false);
            this.lblPersonalInfo.PerformLayout();
            this.lblTravelClass.ResumeLayout(false);
            this.lblTravelClass.PerformLayout();
            this.lblAditionalOption.ResumeLayout(false);
            this.lblAditionalOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAirlineTicket;
        private System.Windows.Forms.GroupBox lblPersonalInfo;
        private System.Windows.Forms.Label lblBaggageWeight;
        private System.Windows.Forms.Label lblNumberOfTrickets;
        private System.Windows.Forms.Label lblPassengerAge;
        private System.Windows.Forms.Label lblPassengerName;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.TextBox txtPassengerAge;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.GroupBox lblTravelClass;
        private System.Windows.Forms.RichTextBox rtbBookingDetails;
        private System.Windows.Forms.RadioButton rdoFristClass;
        private System.Windows.Forms.RadioButton rdoBusinessClass;
        private System.Windows.Forms.RadioButton rdoNormalClass;
        private System.Windows.Forms.GroupBox lblAditionalOption;
        private System.Windows.Forms.CheckBox chkTravelInsurance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

