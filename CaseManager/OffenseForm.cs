using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CaseManager
{
    public partial class OffenseForm : Form
    {
        static String[] work = new String[6];
        public OffenseForm()
        {
            InitializeComponent();
        }

        private void OffenseForm_Load(object sender, EventArgs e)
        {
        }

        public void loadInfo(String mainInfo)
        {
            if(mainInfo.Contains("Subject"))//this is really messy..I REALLY need DB w/ servers
            {
                String[] pieces = mainInfo.Split(new []{'('},2);
                offenseBox.Text = pieces[0];
                String[] subject = pieces[1].Split(new[] { ' ' }, 2);
                subjectBox.Text = subject[1].Substring(0,subject[1].Length-1);
            }
            else
            {
                offenseBox.Text = mainInfo;
            }
            String offense = offenseBox.Text;
            DateTime badDay;
            DateTime subjectDay;
            DateTime victimDay;
            switch(offense)
            {
                case("Homicide "):
                    badDay = new DateTime(2018,2,7);
                    offenseDate.Value = DateTime.FromOADate(badDay.ToOADate());
                    checkICACNo.Checked = true;
                    subjectDay = new DateTime(1985,6,13);
                    subjectDOB.Value = DateTime.FromOADate(subjectDay.ToOADate());
                    victimBox.Text = "Russell Weasley";
                    victimDay = new DateTime(1997, 4, 1);
                    victimDOB.Value = DateTime.FromOADate(victimDay.ToOADate());
                    if (work != null)
                        richNotes.Text = work[0];
                    break;
                case("Cyber"):
                    badDay = new DateTime(2018,4,1);
                    offenseDate.Value = DateTime.FromOADate(badDay.ToOADate());
                    checkICACNo.Checked = true;
                    subjectDay = new DateTime(1992,5,4);
                    subjectDOB.Value = DateTime.FromOADate(subjectDay.ToOADate());
                    subjectBox.Text = "Good Guys Inc";
                    victimBox.Text = "Henry Avario";
                    victimDay = new DateTime(1993, 5, 11);
                    victimDOB.Value = DateTime.FromOADate(victimDay.ToOADate());
                    if (work != null)
                        richNotes.Text = work[1];
                    break;
                case("Whaling "):
                    badDay = new DateTime(2018,2,2);
                    offenseDate.Value = DateTime.FromOADate(badDay.ToOADate());
                    checkICACNo.Checked = true;
                    subjectDay = new DateTime(1992,1,8);
                    subjectDOB.Value = DateTime.FromOADate(subjectDay.ToOADate());
                    victimBox.Text = "Emiliano Navarro";
                    victimDay = new DateTime(1990, 7, 17);
                    victimDOB.Value = DateTime.FromOADate(victimDay.ToOADate());
                    if (work != null)
                        richNotes.Text = work[2];
                    break;
                case("White Collar "):
                    badDay = new DateTime(2018,4,18);
                    offenseDate.Value = DateTime.FromOADate(badDay.ToOADate());
                    checkICACNo.Checked = true;
                    subjectDay = new DateTime(1991,8,19);
                    subjectDOB.Value = DateTime.FromOADate(subjectDay.ToOADate());
                    victimBox.Text = "Shady Guys Corp";
                    victimDay = new DateTime(1990, 5, 14);
                    victimDOB.Value = DateTime.FromOADate(victimDay.ToOADate());
                    if (work != null)
                        richNotes.Text = work[3];
                    break;
                default:
                    break;
            }
        }

        private void saveNotesButton_Click(object sender, EventArgs e)
        {
            if (offenseBox.Text.Contains("Homicide"))
                work[0] = richNotes.Text;
            else if (offenseBox.Text.Contains("Cyber"))
                work[1] = richNotes.Text;
            else if (offenseBox.Text.Contains("Whaling"))
                work[2] = richNotes.Text;
            else if (offenseBox.Text.Contains("White Collar"))
                work[3] = richNotes.Text;
            else
                work[4] = richNotes.Text;
            DialogResult de = MessageBox.Show("Saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editOffenseButton_Click(object sender, EventArgs e)
        {

            offenseBox.Enabled = true;
            offenseDate.Enabled = true;
            checkICACNo.Enabled = true;
            checkICACYes.Enabled = true;
            subjectBox.Enabled = true;
            subjectDOB.Enabled = true;
            victimBox.Enabled = true;
            victimDOB.Enabled = true;
            saveEditButton.Enabled = true;
            cancelEditButton.Enabled = true;
            editOffenseButton.Enabled = false;
        }

        private void saveEditButton_Click(object sender, EventArgs e)
        {
            offenseBox.Enabled = false;
            offenseDate.Enabled = false;
            checkICACNo.Enabled = false;
            checkICACYes.Enabled = false;
            subjectBox.Enabled = false;
            subjectDOB.Enabled = false;
            victimBox.Enabled = false;
            victimDOB.Enabled = false;
            saveEditButton.Enabled = false;
            cancelEditButton.Enabled = false;
            editOffenseButton.Enabled = true;
            feedbackBox.Text = "Your edited information has been sent to be reviewed. Changes will be made appropriately when validated.";
        }

        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            offenseBox.Enabled = false;
            offenseDate.Enabled = false;
            checkICACNo.Enabled = false;
            checkICACYes.Enabled = false;
            subjectBox.Enabled = false;
            subjectDOB.Enabled = false;
            victimBox.Enabled = false;
            victimDOB.Enabled = false;
            saveEditButton.Enabled = false;
            cancelEditButton.Enabled = false;
            editOffenseButton.Enabled = true;
        }
    }
}
