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
    public partial class caseManagerForm : Form
    {
        public caseManagerForm()
        {
            InitializeComponent();
        }

        private void caseManagerForm_Load(object sender, EventArgs e)
        {
            caseViewer.Rows.Add("02/14/2018 10:34:39 AM", "03/09/2018", "180207-01", "Nancy Yang", "That One Group",
                22, "Homicide (Subject: Allen Walk)", "Samsung (SM-G360T1)", "Closed");
            caseViewer.Rows.Add("04/07/2018 1:46:30 PM", "04/26/2018", "734610-07", "Jose Diaz", "Penguin Tech",
                17, "Cyber", "Seagate (Barracuda)", "Active");
            caseViewer.Rows.Add("02/20/2018 2:21:36 PM", "04/10/2018", "532617-43", "Allison Forrest", "Great Co",
                9, "Whaling (Subject: Sara Rowley)", "Apple (A1675)", "Closed");
            caseViewer.Rows.Add("04/20/2018 9:25:52 AM", "05/13/2018", "387617-12", "Katie Aldridge", "Marciano Co",
                7, "White Collar (Subject: Marcus Leal)", "HP (HP-650)", "On Hold");
            caseViewer.Rows[0].Cells[8].Style.BackColor = Color.LightGreen;
            caseViewer.Rows[1].Cells[8].Style.BackColor = Color.Red;
            caseViewer.Rows[2].Cells[8].Style.BackColor = Color.LightGreen;
            caseViewer.Rows[3].Cells[8].Style.BackColor = Color.Yellow;
            for(int i = 0; i< caseViewer.RowCount; i++)
            {
                caseViewer.Rows[i].Cells[3].Style.Font = new Font("Ariel", 8, FontStyle.Underline);
                caseViewer.Rows[i].Cells[5].Style.Font = new Font("Ariel", 8, FontStyle.Underline);
                caseViewer.Rows[i].Cells[6].Style.Font = new Font("Ariel", 8, FontStyle.Underline);
                caseViewer.Rows[i].Cells[7].Style.Font = new Font("Ariel", 8, FontStyle.Underline);
                caseViewer.Rows[i].Cells[8].Style.Font = new Font("Ariel", 8, FontStyle.Underline);
            }
                

        }

        private void caseViewer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)//Requestor
            {
                object info = caseViewer.CurrentCell.Value;
                object dateReq = caseViewer.CurrentRow.Cells[1].Value;
                object company = caseViewer.CurrentRow.Cells[4].Value;
                String date = dateReq.ToString();
                String co = company.ToString();
                String name = (String)info;
                RequestorForm req = new RequestorForm();
                req.Show();
                req.loadInfo(name,date,co);
            }
            if(e.ColumnIndex == 5)//Hours
            {
                object info = caseViewer.CurrentCell.Value;
                int hours = (int)info;
                HoursForm h = new HoursForm();
                h.Show();
            }
            if(e.ColumnIndex == 6)//Offense
            {
                object info = caseViewer.CurrentCell.Value;
                String offense = (String)info;
                //DialogResult de = MessageBox.Show(offense, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OffenseForm off = new OffenseForm();
                off.Show();
                off.loadInfo(offense);
            }
            if(e.ColumnIndex == 7)//Exhibition
            {
                object info = caseViewer.CurrentCell.Value;
                String exhibition = (String)info;
                ExhibitionForm exhibit = new ExhibitionForm();
                exhibit.Show();
                exhibit.loadImage(exhibition);
            }
            if(e.ColumnIndex == 8)//Status
            {
                object info = caseViewer.CurrentCell.Value;
                String status = (String)info;
                //if not closed..
                StatusForm stat = new StatusForm();
                stat.Show();
            }
        }

        private void newCaseButton_Click(object sender, EventArgs e)
        {
            NewCaseForm caseInfo = new NewCaseForm();
            caseInfo.Show();
        }

        private void importCaseButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            DialogResult de = MessageBox.Show("In Progress", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void addCase(String[] info, DateTime[] dates)
        {
            caseViewer.Rows.Add(DateTime.Now, "03/09/2018", "180207-01", "Nancy Yang", "That One Group",
                0, "Homicide (Subject: Allen Walk)", "Samsung (SM-G360T1)", "Active");
            caseViewer.Rows[4].Cells[8].Style.BackColor = Color.Red;
        }
    }
}
