using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseManager
{
    public partial class ExhibitionForm : Form
    {
        Dictionary<String, String> dict = new Dictionary<String, String>();

        public ExhibitionForm()
        {
            InitializeComponent();
        }

        public void loadImage(String exhibit)
        {
            if (exhibit.Contains("Barracuda"))
            {
                exhibitionImage.Image = Image.FromFile("barracuda.jpg");
                dict.Add("Seagate", "Barracuda");
                evidenceList.Items.Add("Seagate Hard Drive");
            }        
            else if (exhibit.Contains("Samsung"))
            {
                exhibitionImage.Image = Image.FromFile("samsung.jpg");
                dict.Add("Samsung", "SM-G360T1");
                evidenceList.Items.Add("Samsung Phone");
            }
            else if (exhibit.Contains("HP"))
            {
                exhibitionImage.Image = Image.FromFile("hp.jpg");
                dict.Add("Hewlett Packard", "HP-650");
                evidenceList.Items.Add("HP Laptop");
            }
            else if (exhibit.Contains("Apple"))
            {
                exhibitionImage.Image = Image.FromFile("apple.jpg");
                dict.Add("Apple", "A1675");
                evidenceList.Items.Add("Apple Laptop");
            }
            else
                exhibitionImage.Image = Image.FromFile("default.png");
        }

        private void evidenceListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            evidenceInfo.GridLines = true;
            evidenceInfo.ShowGroups = true;
            downloadReportButton.Enabled = true;
            editReportButton.Enabled = true;
            if(dict.Keys.Contains("Seagate"))
            {
                evidenceInfo.Items.Add("Name: Seagate");
                evidenceInfo.Items.Add("Model: B12345");
                evidenceInfo.Items.Add("Kind: Barracuda");
                evidenceInfo.Items.Add("Size: 2TB");
                reportBox.Text = "This is a report of the Seagate Barracuda hard drive.";

            }
            else if (dict.Keys.Contains("Samsung"))
            {
                evidenceInfo.Items.Add("Name: Samsung");
                evidenceInfo.Items.Add("Model: SM-G360T1");
                evidenceInfo.Items.Add("Kind: Galaxy Note 6");
                evidenceInfo.Items.Add("Size: 16GB");
                reportBox.Text = "This is a report of the Samsung phone.";
            }
            else if (dict.Keys.Contains("Hewlett Packard"))
            {
                evidenceInfo.Items.Add("Name: Hewlett-Packard");
                evidenceInfo.Items.Add("Model: HP-650");
                evidenceInfo.Items.Add("Kind: Spectre");
                evidenceInfo.Items.Add("Size: 256GB");
                reportBox.Text = "This is a report of the HP laptop.";
            }
            else if (dict.Keys.Contains("Apple"))
            {
                evidenceInfo.Items.Add("Name: Apple");
                evidenceInfo.Items.Add("Model: A1675");
                evidenceInfo.Items.Add("Kind: Macintosh");
                evidenceInfo.Items.Add("Size: 256GB");
                reportBox.Text = "This is a report of the Apple laptop.";
            }

        }

        private void uploadEvidenceButton_Click(object sender, EventArgs e)
        {
            uploadEvidence.ShowDialog();
        }

        private void downloadReportButton_Click(object sender, EventArgs e)
        {
            saveReport.ShowDialog();
        }

        private void editReportButton_Click(object sender, EventArgs e)
        {
            reportBox.Enabled = true;
            saveReportButton.Enabled = true;
            cancelEditButton.Enabled = true;
        }

        private void saveReportButton_Click(object sender, EventArgs e)
        {
            DialogResult de = MessageBox.Show("Your edits will be validated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            saveReportButton.Enabled = false;
            cancelEditButton.Enabled = false;
        }

        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            reportBox.Enabled = false;
            saveReportButton.Enabled = false;
            cancelEditButton.Enabled = false;
            reportBox.Cursor = DefaultCursor;
        }
    }
}
