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
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           FrmRegistration frm = new FrmRegistration();
            frm.ShowDialog();   
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Find Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               lvStudentRecord.Items.Clear();
                string path = openFileDialog1.FileName;
                using (StreamReader sr = File.OpenText(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                       lvStudentRecord.Items.Add(line);
                    }
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvStudentRecord.Items.Clear();
        }
    }
}
