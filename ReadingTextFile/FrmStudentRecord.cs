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
        private string _filePath;
        public FrmStudentRecord(string filePath = "")
        
        {

            InitializeComponent();
            _filePath = filePath;
            if (!string.IsNullOrEmpty(_filePath))
            {
                LoadStudentFile();
            }
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Path.GetFullPath(@"..\..\FileStorage"),
                Title = "Browse Text Files",
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFileDialog1.FileName;
                LoadStudentFile();

            }
        }
        private void LoadStudentFile()
        {
            try
            {
                using (StreamReader streamReader = File.OpenText(_filePath))
                {
                    string _getText;
                    lvStudentRecord.Items.Clear();

                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        lvStudentRecord.Items.Add(_getText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvStudentRecord.Items.Clear();
        }

        private void lvShowText_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(Application.StartupPath, "TextFiles"),
                Title = "Browse Text Files",
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                try
                { 
                    using (StreamReader streamReader = File.OpenText(path))
                    {
                        string _getText;
                        lvStudentRecord.Items.Clear();

                        while ((_getText = streamReader.ReadLine()) != null)
                        {
                            lvStudentRecord.Items.Clear();
                            lvStudentRecord.Items.Add(_getText);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }

            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            FrmRegistration registrationForm = new FrmRegistration();
            registrationForm.Show();
            this.Hide();
        }
    }
}

