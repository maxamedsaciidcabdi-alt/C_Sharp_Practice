namespace HomeAssignment
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
            this.lbddayoftheweek = new System.Windows.Forms.Label();
            this.lblnameofthemonth = new System.Windows.Forms.Label();
            this.lblmonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtdayoftheweek = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtnumericofmonth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnShowDate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbddayoftheweek
            // 
            this.lbddayoftheweek.AutoSize = true;
            this.lbddayoftheweek.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbddayoftheweek.Location = new System.Drawing.Point(107, 44);
            this.lbddayoftheweek.Name = "lbddayoftheweek";
            this.lbddayoftheweek.Size = new System.Drawing.Size(177, 19);
            this.lbddayoftheweek.TabIndex = 0;
            this.lbddayoftheweek.Text = "Enter day of the week :";
            // 
            // lblnameofthemonth
            // 
            this.lblnameofthemonth.AutoSize = true;
            this.lblnameofthemonth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameofthemonth.Location = new System.Drawing.Point(81, 78);
            this.lblnameofthemonth.Name = "lblnameofthemonth";
            this.lblnameofthemonth.Size = new System.Drawing.Size(203, 19);
            this.lblnameofthemonth.TabIndex = 1;
            this.lblnameofthemonth.Text = "Enter Name of the month :";
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonth.Location = new System.Drawing.Point(31, 112);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(253, 19);
            this.lblmonth.TabIndex = 2;
            this.lblmonth.Text = "Enter the Numeric of the month :";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(156, 153);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(128, 19);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Enter the year : ";
            // 
            // txtdayoftheweek
            // 
            this.txtdayoftheweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayoftheweek.Location = new System.Drawing.Point(315, 43);
            this.txtdayoftheweek.Name = "txtdayoftheweek";
            this.txtdayoftheweek.Size = new System.Drawing.Size(302, 24);
            this.txtdayoftheweek.TabIndex = 4;
            this.txtdayoftheweek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmonth
            // 
            this.txtmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.Location = new System.Drawing.Point(315, 75);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(302, 24);
            this.txtmonth.TabIndex = 5;
            this.txtmonth.TextChanged += new System.EventHandler(this.txtmonth_TextChanged);
            // 
            // txtnumericofmonth
            // 
            this.txtnumericofmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumericofmonth.Location = new System.Drawing.Point(315, 112);
            this.txtnumericofmonth.Name = "txtnumericofmonth";
            this.txtnumericofmonth.Size = new System.Drawing.Size(302, 24);
            this.txtnumericofmonth.TabIndex = 6;
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(315, 153);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(302, 24);
            this.txtyear.TabIndex = 7;
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(12, 220);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(760, 66);
            this.lbloutput.TabIndex = 8;
            // 
            // btnShowDate
            // 
            this.btnShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDate.Location = new System.Drawing.Point(43, 318);
            this.btnShowDate.Name = "btnShowDate";
            this.btnShowDate.Size = new System.Drawing.Size(178, 68);
            this.btnShowDate.TabIndex = 9;
            this.btnShowDate.Text = "Show Date";
            this.btnShowDate.UseVisualStyleBackColor = true;
            this.btnShowDate.Click += new System.EventHandler(this.btnShowDate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(290, 318);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(178, 68);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(521, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 68);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowDate);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtnumericofmonth);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayoftheweek);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblmonth);
            this.Controls.Add(this.lblnameofthemonth);
            this.Controls.Add(this.lbddayoftheweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbddayoftheweek;
        private System.Windows.Forms.Label lblnameofthemonth;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtdayoftheweek;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtnumericofmonth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnShowDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

