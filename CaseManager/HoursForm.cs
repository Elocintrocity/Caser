using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CaseManager
{
    public partial class HoursForm : Form
    {
        public HoursForm()
        {
            InitializeComponent();
        }

        public void loadInfo(int hours)
        {
            indivHours.Text = hours.ToString();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            openReportDialog.ShowDialog();
        }

        private void sendReportButton_Click(object sender, EventArgs e)
        {
            if(addingHours.Text.Length == 0)
            {
                DialogResult d = MessageBox.Show("Adding hours field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            else
            {
                DialogResult de = MessageBox.Show("Your hours will be sent in to be reviewed. Changes will occur at 9am the next day.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void openReportDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(openReportDialog.OpenFile()))
                {
                    String line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        reportBox.Text += line;
                    }
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                DialogResult de = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
