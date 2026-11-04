using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Asigment_Open_Save
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Allow saving to an existing file without confirmation
            saveFileDialog1.OverwritePrompt = false;
        }

        private void openfiledialog_Click(object sender, EventArgs e)
        {
            //Example of Dialog results ok or cancel
            //Reading the file - using open file dialog
            //import class
            StreamReader Reads;

            //create dialog result
            DialogResult Result;

            //Results variable only store ok or cancle
            Result = openFileDialog1.ShowDialog();

            //checking the user selection
            if (Result == DialogResult.OK) //true
                                           //ok==ok
            {
                //open the file 
                //static path
                //Reads = File.OpenText(@"C:\Users\dhaaf\Downloads\Saving_files\php.txt");

                //Daynamic reading path file
                Reads = File.OpenText(openFileDialog1.FileName);

                //process the file
                string lines;
                while (Reads.EndOfStream == false)
                {
                    //using lines
                    lines = Reads.ReadLine();

                    //store list box when reading item the file
                    listBox1.Items.Add(lines);
                }

                //close the file
                Reads.Close();

            }
            else if (Result == DialogResult.Cancel)
            //cancel==cancel
            {
                MessageBox.Show("waala cancalay");

            }
        }

        private void saveFileDialog_Click(object sender, EventArgs e)
        {
            //Example creating new file - writing the file using savefileDialog control
            //import class
            StreamWriter Writes;

            //prepare the dialog results
            DialogResult results;

            //Assign variable of dialogresults
            results = saveFileDialog1.ShowDialog();

            //check user selection - save or cancel
            if (results == DialogResult.OK)//true
            {
                ////open the file - creating new file
                //Writes = File.CreateText(saveFileDialog1.FileName);

                //open the file - append new data without deleting old data
                Writes = File.AppendText(saveFileDialog1.FileName);

                //process the file
                Writes.WriteLine("waxaan bartaa java");
                //Writes.WriteLine("Inaa heerfiican kagaaro rajeena inshallah");


                //close the  file
                Writes.Close();
               

            }
            else if (results == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel ayaa taabatay");
            }
        }

        private void clearlistbox_Click(object sender, EventArgs e)
        {
            //clear listbox
            listBox1.Items.Clear();
        }

        private void Append_Click(object sender, EventArgs e)
        {
           
        }
    }
}
