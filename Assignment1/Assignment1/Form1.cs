using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            
            String studentName, studentdept, studentsem, Full_info;
            int StudentId ;
            studentName = txtname.Text;
            StudentId = int.Parse(txtstudentid.Text);
            studentdept = txtdepartment.Text;
            studentsem = txtsemester.Text;
            Full_info = studentName + " " + StudentId + " " + studentdept + " " + studentsem;

            lbloutput.Text = Full_info;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();

           
            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
