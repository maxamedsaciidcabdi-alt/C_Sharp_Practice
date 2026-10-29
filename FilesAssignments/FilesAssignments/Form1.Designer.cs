namespace FilesAssignments
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
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnReadLines = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnClearContents = new System.Windows.Forms.Button();
            this.lstFileContents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateFile.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.Location = new System.Drawing.Point(196, 36);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(194, 91);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = false;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnReadLines
            // 
            this.btnReadLines.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReadLines.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadLines.Location = new System.Drawing.Point(453, 36);
            this.btnReadLines.Name = "btnReadLines";
            this.btnReadLines.Size = new System.Drawing.Size(194, 91);
            this.btnReadLines.TabIndex = 1;
            this.btnReadLines.Text = "Read File";
            this.btnReadLines.UseVisualStyleBackColor = false;
            this.btnReadLines.Click += new System.EventHandler(this.btnReadLines_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteFile.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFile.Location = new System.Drawing.Point(196, 148);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(194, 59);
            this.btnDeleteFile.TabIndex = 2;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnClearContents
            // 
            this.btnClearContents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClearContents.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearContents.Location = new System.Drawing.Point(453, 148);
            this.btnClearContents.Name = "btnClearContents";
            this.btnClearContents.Size = new System.Drawing.Size(194, 59);
            this.btnClearContents.TabIndex = 3;
            this.btnClearContents.Text = "Clear File Contents";
            this.btnClearContents.UseVisualStyleBackColor = false;
            this.btnClearContents.Click += new System.EventHandler(this.btnClearContents_Click);
            // 
            // lstFileContents
            // 
            this.lstFileContents.FormattingEnabled = true;
            this.lstFileContents.ItemHeight = 16;
            this.lstFileContents.Location = new System.Drawing.Point(141, 239);
            this.lstFileContents.Name = "lstFileContents";
            this.lstFileContents.Size = new System.Drawing.Size(558, 180);
            this.lstFileContents.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.lstFileContents);
            this.Controls.Add(this.btnClearContents);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnReadLines);
            this.Controls.Add(this.btnCreateFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnReadLines;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnClearContents;
        private System.Windows.Forms.ListBox lstFileContents;
    }
}

