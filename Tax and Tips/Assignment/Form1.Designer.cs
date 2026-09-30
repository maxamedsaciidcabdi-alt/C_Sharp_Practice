namespace Assignment
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
            this.lblfood1 = new System.Windows.Forms.Label();
            this.lblfood1price = new System.Windows.Forms.Label();
            this.lblfoodtwo = new System.Windows.Forms.Label();
            this.lblfoodtwoprice = new System.Windows.Forms.Label();
            this.txtfood1 = new System.Windows.Forms.TextBox();
            this.txtfood1price = new System.Windows.Forms.TextBox();
            this.txtfood2 = new System.Windows.Forms.TextBox();
            this.txtfood2price = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfood1
            // 
            this.lblfood1.AutoSize = true;
            this.lblfood1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood1.Location = new System.Drawing.Point(203, 59);
            this.lblfood1.Name = "lblfood1";
            this.lblfood1.Size = new System.Drawing.Size(123, 17);
            this.lblfood1.TabIndex = 0;
            this.lblfood1.Text = "Enter Food One: ";
            // 
            // lblfood1price
            // 
            this.lblfood1price.AutoSize = true;
            this.lblfood1price.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood1price.Location = new System.Drawing.Point(166, 99);
            this.lblfood1price.Name = "lblfood1price";
            this.lblfood1price.Size = new System.Drawing.Size(160, 17);
            this.lblfood1price.TabIndex = 1;
            this.lblfood1price.Text = "Enter Food One price: ";
            // 
            // lblfoodtwo
            // 
            this.lblfoodtwo.AutoSize = true;
            this.lblfoodtwo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoodtwo.Location = new System.Drawing.Point(204, 132);
            this.lblfoodtwo.Name = "lblfoodtwo";
            this.lblfoodtwo.Size = new System.Drawing.Size(122, 17);
            this.lblfoodtwo.TabIndex = 2;
            this.lblfoodtwo.Text = "Enter Food Two: ";
            // 
            // lblfoodtwoprice
            // 
            this.lblfoodtwoprice.AutoSize = true;
            this.lblfoodtwoprice.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfoodtwoprice.Location = new System.Drawing.Point(166, 165);
            this.lblfoodtwoprice.Name = "lblfoodtwoprice";
            this.lblfoodtwoprice.Size = new System.Drawing.Size(160, 17);
            this.lblfoodtwoprice.TabIndex = 3;
            this.lblfoodtwoprice.Text = "Enter Food Two Price: ";
            // 
            // txtfood1
            // 
            this.txtfood1.Location = new System.Drawing.Point(345, 54);
            this.txtfood1.Name = "txtfood1";
            this.txtfood1.Size = new System.Drawing.Size(254, 22);
            this.txtfood1.TabIndex = 4;
            // 
            // txtfood1price
            // 
            this.txtfood1price.Location = new System.Drawing.Point(345, 94);
            this.txtfood1price.Name = "txtfood1price";
            this.txtfood1price.Size = new System.Drawing.Size(254, 22);
            this.txtfood1price.TabIndex = 5;
            // 
            // txtfood2
            // 
            this.txtfood2.Location = new System.Drawing.Point(345, 128);
            this.txtfood2.Name = "txtfood2";
            this.txtfood2.Size = new System.Drawing.Size(254, 22);
            this.txtfood2.TabIndex = 6;
            // 
            // txtfood2price
            // 
            this.txtfood2price.Location = new System.Drawing.Point(345, 165);
            this.txtfood2price.Name = "txtfood2price";
            this.txtfood2price.Size = new System.Drawing.Size(254, 22);
            this.txtfood2price.TabIndex = 7;
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(307, 300);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(170, 59);
            this.btncalc.TabIndex = 8;
            this.btncalc.Text = "Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloutput.Location = new System.Drawing.Point(169, 209);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(430, 72);
            this.lbloutput.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtfood2price);
            this.Controls.Add(this.txtfood2);
            this.Controls.Add(this.txtfood1price);
            this.Controls.Add(this.txtfood1);
            this.Controls.Add(this.lblfoodtwoprice);
            this.Controls.Add(this.lblfoodtwo);
            this.Controls.Add(this.lblfood1price);
            this.Controls.Add(this.lblfood1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfood1;
        private System.Windows.Forms.Label lblfood1price;
        private System.Windows.Forms.Label lblfoodtwo;
        private System.Windows.Forms.Label lblfoodtwoprice;
        private System.Windows.Forms.TextBox txtfood1;
        private System.Windows.Forms.TextBox txtfood1price;
        private System.Windows.Forms.TextBox txtfood2;
        private System.Windows.Forms.TextBox txtfood2price;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label lbloutput;
    }
}

