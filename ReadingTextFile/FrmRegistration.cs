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
          string studentNumber = txtStudNo.Text.Trim();
            if (string.IsNullOrEmpty(studentNumber))
            {
                MessageBox.Show("Please enter a student number.");
                return;
            }

            string[] studentInfo = {
                "Student Number: " + studentNumber,
                "Last Name: " + txtLastName.Text,
                "First Name: " + txtFirstName.Text,
                "Middle Name: " + txtMI.Text,
                "Gender: " + cmbGender.Text,
                "Birthday: " + dtpBirthday.Value.ToShortDateString(),
                "Program: " + cmbProgram.Text,
                "Contact No: " + txtContactNo.Text,
                "Age: " + txtAge.Text
            };
            string relativePath = @"..\..\FileStorage";
            string docPath = Path.GetFullPath(relativePath);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, studentNumber + ".txt")))
            {
                foreach (string info in studentInfo)
                {
                    outputFile.WriteLine(info);
                }
            }
            MessageBox.Show("Registration file created!");
            FrmStudentRecord studentRecordForm = new FrmStudentRecord();
            studentRecordForm.Show();
            this.Hide();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
