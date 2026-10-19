namespace Vehicle_Rental_Managment_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblexpreince = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.txtexperience = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoeconomy = new System.Windows.Forms.RadioButton();
            this.rdosuv = new System.Windows.Forms.RadioButton();
            this.rdoluxury = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkinsurance = new System.Windows.Forms.CheckBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lstresults = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtexperience);
            this.groupBox1.Controls.Add(this.txtdays);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblexpreince);
            this.groupBox1.Controls.Add(this.lbldays);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(25, 55);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(158, 22);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Customer Name:";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(25, 100);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(142, 22);
            this.lblage.TabIndex = 2;
            this.lblage.Text = "Customer Age:";
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.Location = new System.Drawing.Point(25, 149);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(227, 22);
            this.lbldays.TabIndex = 3;
            this.lbldays.Text = "Number Of Rental Days:";
            // 
            // lblexpreince
            // 
            this.lblexpreince.AutoSize = true;
            this.lblexpreince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpreince.Location = new System.Drawing.Point(25, 195);
            this.lblexpreince.Name = "lblexpreince";
            this.lblexpreince.Size = new System.Drawing.Size(259, 22);
            this.lblexpreince.TabIndex = 4;
            this.lblexpreince.Text = "Years Of Driving Expreince:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(307, 55);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(207, 26);
            this.txtname.TabIndex = 5;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(307, 100);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(207, 26);
            this.txtage.TabIndex = 6;
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(307, 148);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(207, 26);
            this.txtdays.TabIndex = 7;
            // 
            // txtexperience
            // 
            this.txtexperience.Location = new System.Drawing.Point(307, 195);
            this.txtexperience.Name = "txtexperience";
            this.txtexperience.Size = new System.Drawing.Size(207, 26);
            this.txtexperience.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vehicle Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoluxury);
            this.groupBox2.Controls.Add(this.rdosuv);
            this.groupBox2.Controls.Add(this.rdoeconomy);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(29, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 110);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // rdoeconomy
            // 
            this.rdoeconomy.AutoSize = true;
            this.rdoeconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoeconomy.Location = new System.Drawing.Point(29, 58);
            this.rdoeconomy.Name = "rdoeconomy";
            this.rdoeconomy.Size = new System.Drawing.Size(116, 26);
            this.rdoeconomy.TabIndex = 10;
            this.rdoeconomy.TabStop = true;
            this.rdoeconomy.Text = "Economy";
            this.rdoeconomy.UseVisualStyleBackColor = true;
            // 
            // rdosuv
            // 
            this.rdosuv.AutoSize = true;
            this.rdosuv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdosuv.Location = new System.Drawing.Point(202, 60);
            this.rdosuv.Name = "rdosuv";
            this.rdosuv.Size = new System.Drawing.Size(75, 26);
            this.rdosuv.TabIndex = 11;
            this.rdosuv.TabStop = true;
            this.rdosuv.Text = "SUV";
            this.rdosuv.UseVisualStyleBackColor = true;
            // 
            // rdoluxury
            // 
            this.rdoluxury.AutoSize = true;
            this.rdoluxury.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoluxury.Location = new System.Drawing.Point(368, 58);
            this.rdoluxury.Name = "rdoluxury";
            this.rdoluxury.Size = new System.Drawing.Size(95, 26);
            this.rdoluxury.TabIndex = 12;
            this.rdoluxury.TabStop = true;
            this.rdoluxury.Text = "Luxury";
            this.rdoluxury.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkinsurance);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(29, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 89);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Insurance Option";
            // 
            // chkinsurance
            // 
            this.chkinsurance.AutoSize = true;
            this.chkinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkinsurance.Location = new System.Drawing.Point(21, 49);
            this.chkinsurance.Name = "chkinsurance";
            this.chkinsurance.Size = new System.Drawing.Size(262, 24);
            this.chkinsurance.TabIndex = 14;
            this.chkinsurance.Text = "Add Insurance($15 Per Day)";
            this.chkinsurance.UseVisualStyleBackColor = true;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(15, 26);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(127, 46);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnexit);
            this.groupBox4.Controls.Add(this.btnclear);
            this.groupBox4.Controls.Add(this.btncalculate);
            this.groupBox4.Location = new System.Drawing.Point(88, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(629, 87);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(228, 26);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(127, 46);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(442, 25);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(127, 46);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lstresults
            // 
            this.lstresults.FormattingEnabled = true;
            this.lstresults.ItemHeight = 20;
            this.lstresults.Location = new System.Drawing.Point(605, 9);
            this.lstresults.Name = "lstresults";
            this.lstresults.Size = new System.Drawing.Size(325, 464);
            this.lstresults.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstresults);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblexpreince;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtexperience;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoluxury;
        private System.Windows.Forms.RadioButton rdosuv;
        private System.Windows.Forms.RadioButton rdoeconomy;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkinsurance;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox lstresults;
        private System.Windows.Forms.Label label4;
    }
}

