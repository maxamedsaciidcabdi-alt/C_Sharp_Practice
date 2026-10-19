namespace Hotel_Room_Booking_System
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lplGuestAge = new System.Windows.Forms.Label();
            this.lplNights = new System.Windows.Forms.Label();
            this.lplGuests = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtGuestAge = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.rdoStandard = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoHight = new System.Windows.Forms.RadioButton();
            this.grpAditionalOptions = new System.Windows.Forms.GroupBox();
            this.chkBreakFast = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBookingDetails = new System.Windows.Forms.RichTextBox();
            this.grpPersonalInfo.SuspendLayout();
            this.grpRoomType.SuspendLayout();
            this.grpAditionalOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Blue;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1169, 72);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hotel Room Booking System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.txtNights);
            this.grpPersonalInfo.Controls.Add(this.txtGuests);
            this.grpPersonalInfo.Controls.Add(this.txtGuestAge);
            this.grpPersonalInfo.Controls.Add(this.txtGuestName);
            this.grpPersonalInfo.Controls.Add(this.lplGuests);
            this.grpPersonalInfo.Controls.Add(this.lplNights);
            this.grpPersonalInfo.Controls.Add(this.lplGuestAge);
            this.grpPersonalInfo.Controls.Add(this.lblGuestName);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalInfo.Location = new System.Drawing.Point(14, 90);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(584, 225);
            this.grpPersonalInfo.TabIndex = 1;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Information";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(46, 46);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(132, 22);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Guest Name :";
            // 
            // lplGuestAge
            // 
            this.lplGuestAge.AutoSize = true;
            this.lplGuestAge.Location = new System.Drawing.Point(62, 90);
            this.lplGuestAge.Name = "lplGuestAge";
            this.lplGuestAge.Size = new System.Drawing.Size(116, 22);
            this.lplGuestAge.TabIndex = 1;
            this.lplGuestAge.Text = "Guest Age :";
            // 
            // lplNights
            // 
            this.lplNights.AutoSize = true;
            this.lplNights.Location = new System.Drawing.Point(-5, 132);
            this.lplNights.Name = "lplNights";
            this.lplNights.Size = new System.Drawing.Size(183, 22);
            this.lplNights.TabIndex = 2;
            this.lplNights.Text = " Number of Nights :";
            // 
            // lplGuests
            // 
            this.lplGuests.AutoSize = true;
            this.lplGuests.Location = new System.Drawing.Point(-1, 177);
            this.lplGuests.Name = "lplGuests";
            this.lplGuests.Size = new System.Drawing.Size(179, 22);
            this.lplGuests.TabIndex = 3;
            this.lplGuests.Text = " Number of Guest :";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(184, 40);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(249, 28);
            this.txtGuestName.TabIndex = 2;
            // 
            // txtGuestAge
            // 
            this.txtGuestAge.Location = new System.Drawing.Point(184, 87);
            this.txtGuestAge.Name = "txtGuestAge";
            this.txtGuestAge.Size = new System.Drawing.Size(249, 28);
            this.txtGuestAge.TabIndex = 4;
            // 
            // txtGuests
            // 
            this.txtGuests.Location = new System.Drawing.Point(184, 171);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(249, 28);
            this.txtGuests.TabIndex = 5;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(184, 132);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(249, 28);
            this.txtNights.TabIndex = 6;
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.rdoHight);
            this.grpRoomType.Controls.Add(this.rdoNormal);
            this.grpRoomType.Controls.Add(this.rdoStandard);
            this.grpRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRoomType.Location = new System.Drawing.Point(17, 335);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Size = new System.Drawing.Size(581, 90);
            this.grpRoomType.TabIndex = 3;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Room Type";
            // 
            // rdoStandard
            // 
            this.rdoStandard.AutoSize = true;
            this.rdoStandard.Location = new System.Drawing.Point(26, 42);
            this.rdoStandard.Name = "rdoStandard";
            this.rdoStandard.Size = new System.Drawing.Size(116, 26);
            this.rdoStandard.TabIndex = 4;
            this.rdoStandard.TabStop = true;
            this.rdoStandard.Text = "Standard";
            this.rdoStandard.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(218, 42);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(98, 26);
            this.rdoNormal.TabIndex = 5;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoHight
            // 
            this.rdoHight.AutoSize = true;
            this.rdoHight.Location = new System.Drawing.Point(412, 42);
            this.rdoHight.Name = "rdoHight";
            this.rdoHight.Size = new System.Drawing.Size(82, 26);
            this.rdoHight.TabIndex = 6;
            this.rdoHight.TabStop = true;
            this.rdoHight.Text = "Hight";
            this.rdoHight.UseVisualStyleBackColor = true;
            // 
            // grpAditionalOptions
            // 
            this.grpAditionalOptions.Controls.Add(this.chkBreakFast);
            this.grpAditionalOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAditionalOptions.Location = new System.Drawing.Point(17, 454);
            this.grpAditionalOptions.Name = "grpAditionalOptions";
            this.grpAditionalOptions.Size = new System.Drawing.Size(581, 92);
            this.grpAditionalOptions.TabIndex = 4;
            this.grpAditionalOptions.TabStop = false;
            this.grpAditionalOptions.Text = "Aditional Options";
            // 
            // chkBreakFast
            // 
            this.chkBreakFast.AutoSize = true;
            this.chkBreakFast.Location = new System.Drawing.Point(42, 38);
            this.chkBreakFast.Name = "chkBreakFast";
            this.chkBreakFast.Size = new System.Drawing.Size(356, 26);
            this.chkBreakFast.TabIndex = 0;
            this.chkBreakFast.Text = "Breakfast (10 Per Guest Per nights)";
            this.chkBreakFast.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(43, 566);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 44);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(235, 566);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 44);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(429, 566);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookingDetails.Location = new System.Drawing.Point(672, 90);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.ReadOnly = true;
            this.grpBookingDetails.Size = new System.Drawing.Size(485, 540);
            this.grpBookingDetails.TabIndex = 8;
            this.grpBookingDetails.Text = "Booking Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1169, 633);
            this.Controls.Add(this.grpBookingDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpAditionalOptions);
            this.Controls.Add(this.grpRoomType);
            this.Controls.Add(this.grpPersonalInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpRoomType.ResumeLayout(false);
            this.grpRoomType.PerformLayout();
            this.grpAditionalOptions.ResumeLayout(false);
            this.grpAditionalOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.Label lplGuests;
        private System.Windows.Forms.Label lplNights;
        private System.Windows.Forms.Label lplGuestAge;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.TextBox txtGuestAge;
        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.RadioButton rdoStandard;
        private System.Windows.Forms.RadioButton rdoHight;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.GroupBox grpAditionalOptions;
        private System.Windows.Forms.CheckBox chkBreakFast;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox grpBookingDetails;
    }
}

