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

namespace ReadingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] studentInfo =
            {
               "Student No: " + txtStudNo.Text,
               "Last Name" + txtLastName.Text,
               "Program: " + cmbProgram.Text,
               "Gender:" + cmbGender.Text,
               "Age: " + txtAge.Text,
               "Birthday: " + dtpBirthday.Text,
               "Contact No: " + txtContactNo.Text

            };
            string relativePath = @"..\..\MyProject";
            string docPath = Path.GetFullPath(relativePath);
            string fileName = txtStudNo.Text + ".txt";


            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
            {
                foreach (string line in studentInfo)
                {
                    outputFile.WriteLine(line);
                }
            }
            MessageBox.Show("Registration Successful!");
        }
    }
}
