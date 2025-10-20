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
    public partial class FrmOpenTextFile : Form
    {

        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

      
        private void btnOpen_Click(object sender, EventArgs e)
        {
            lvShowText_SelectedIndexChanged(sender, e);
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
                        lvShowText.Items.Clear();

                        while ((_getText = streamReader.ReadLine()) != null)
                        {
                            lvShowText.Items.Add(_getText);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }

            }
        }

        private void btnStudentRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studentRecordForm = new FrmStudentRecord();
            studentRecordForm.Show();
            this.Hide();
        }

   
    }
}