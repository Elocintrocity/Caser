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
    public partial class NewCaseForm : Form
    {
        public NewCaseForm()
        {
            InitializeComponent();
        }

        private void cancelSubmissionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitCaseButton_Click(object sender, EventArgs e)
        {
            DialogResult de = MessageBox.Show("Submitted for Validation", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void uploadEvidence_Click(object sender, EventArgs e)
        {
            uploadEvidenceDialogue.ShowDialog();
        }

        private void importPic_Click(object sender, EventArgs e)
        {
            importPicDialogue.Title = "Open Image";
            importPicDialogue.Filter = "jpg files (*.jpg) |*.jpg";
            importPicDialogue.ShowDialog();
        }

        private void importPicDialogue_FileOk(object sender, CancelEventArgs e)
        {
            evidencePic.ImageLocation = importPicDialogue.FileName;
        }
    }
}
