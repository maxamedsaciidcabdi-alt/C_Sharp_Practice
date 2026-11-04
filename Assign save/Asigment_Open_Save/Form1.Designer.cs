namespace Asigment_Open_Save
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
            this.openfiledialog = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.Button();
            this.clearlistbox = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openfiledialog
            // 
            this.openfiledialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openfiledialog.Location = new System.Drawing.Point(36, 41);
            this.openfiledialog.Name = "openfiledialog";
            this.openfiledialog.Size = new System.Drawing.Size(217, 67);
            this.openfiledialog.TabIndex = 0;
            this.openfiledialog.Text = "Open File Dialog";
            this.openfiledialog.UseVisualStyleBackColor = true;
            this.openfiledialog.Click += new System.EventHandler(this.openfiledialog_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileDialog.Location = new System.Drawing.Point(36, 132);
            this.saveFileDialog.Name = "saveFileDialog";
            this.saveFileDialog.Size = new System.Drawing.Size(225, 51);
            this.saveFileDialog.TabIndex = 1;
            this.saveFileDialog.Text = "Save File Dialog";
            this.saveFileDialog.UseVisualStyleBackColor = true;
            this.saveFileDialog.Click += new System.EventHandler(this.saveFileDialog_Click);
            // 
            // clearlistbox
            // 
            this.clearlistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearlistbox.Location = new System.Drawing.Point(36, 189);
            this.clearlistbox.Name = "clearlistbox";
            this.clearlistbox.Size = new System.Drawing.Size(225, 60);
            this.clearlistbox.TabIndex = 2;
            this.clearlistbox.Text = "Clear Listbox";
            this.clearlistbox.UseVisualStyleBackColor = true;
            this.clearlistbox.Click += new System.EventHandler(this.clearlistbox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(359, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 424);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.clearlistbox);
            this.Controls.Add(this.saveFileDialog);
            this.Controls.Add(this.openfiledialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openfiledialog;
        private System.Windows.Forms.Button saveFileDialog;
        private System.Windows.Forms.Button clearlistbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

