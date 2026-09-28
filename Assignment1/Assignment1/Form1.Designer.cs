namespace Assignment1
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnshowinfo = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(56, 42);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(176, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter the student name";
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(52, 97);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(161, 20);
            this.lblstudentid.TabIndex = 1;
            this.lblstudentid.Text = " Enter the student ID";
            // 
            // lbldepartment
            // 
            this.lbldepartment.AutoSize = true;
            this.lbldepartment.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartment.Location = new System.Drawing.Point(56, 150);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(165, 20);
            this.lbldepartment.TabIndex = 2;
            this.lbldepartment.Text = "Enter the Department";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemester.Location = new System.Drawing.Point(56, 199);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(143, 20);
            this.lblsemester.TabIndex = 3;
            this.lblsemester.Text = "Enter the semester";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(286, 44);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(257, 22);
            this.txtname.TabIndex = 4;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(286, 199);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(257, 22);
            this.txtsemester.TabIndex = 5;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(286, 152);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(257, 22);
            this.txtdepartment.TabIndex = 7;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(286, 95);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(257, 22);
            this.txtstudentid.TabIndex = 8;
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(56, 254);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(487, 71);
            this.lbloutput.TabIndex = 9;
            // 
            // btnshowinfo
            // 
            this.btnshowinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowinfo.Location = new System.Drawing.Point(51, 359);
            this.btnshowinfo.Name = "btnshowinfo";
            this.btnshowinfo.Size = new System.Drawing.Size(162, 30);
            this.btnshowinfo.TabIndex = 10;
            this.btnshowinfo.Text = "Show Information";
            this.btnshowinfo.UseVisualStyleBackColor = true;
            this.btnshowinfo.Click += new System.EventHandler(this.btnshowinfo_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(227, 359);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(162, 30);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(401, 358);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(142, 30);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshowinfo);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnshowinfo;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

