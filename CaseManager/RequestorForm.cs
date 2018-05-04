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
    public partial class RequestorForm : Form
    {
        public RequestorForm()
        {
            InitializeComponent();
        }

        public void loadInfo(String name, String requestDate, String company)
        {
            requestorName.Text = name;
            requestCo.Text = company;
            requestedDate.Value = DateTime.ParseExact(requestDate, "mm/dd/yyyy", null);
            switch(name)
            {
                case("Nancy Yang"):
                    pointOfContact.Text = "281-521-4914";
                    coPhone.Text = "831-485-1563";
                    break;
                case("Jose Diaz"):
                    pointOfContact.Text = "262-914-5156";
                    coPhone.Text = "262-246-6215";
                    break;
                case("Allison Forrest"):
                    pointOfContact.Text = "672-626-1336";
                    coPhone.Text = "672-726-9589";
                    break;
                case("Katie Aldridge"):
                    pointOfContact.Text = "832-462-8532";
                    coPhone.Text = "281-525-9256";
                    break;
                default:
                    break;
            }
        }

        private void editRequestorButton_Click(object sender, EventArgs e)
        {
            requestorName.Enabled = true;
            pointOfContact.Enabled = true;
            requestedDate.Enabled = true;
            requestCo.Enabled = true;
            coPhone.Enabled = true;
            editRequestorButton.Enabled = false;
            saveRequestorButton.Enabled = true;
            cancelRequestorButton.Enabled = true;
        }

        private void saveRequestorButton_Click(object sender, EventArgs e)
        {
            requestorName.Enabled = false;
            pointOfContact.Enabled = false;
            requestedDate.Enabled = false;
            requestCo.Enabled = false;
            coPhone.Enabled = false;
            editRequestorButton.Enabled = true;
            saveRequestorButton.Enabled = false;
            cancelRequestorButton.Enabled = false;
            feedbackRequestor.Text = "Edits recorded and sent for validation.";
        }

        private void cancelRequestorButton_Click(object sender, EventArgs e)
        {
            requestorName.Enabled = false;
            pointOfContact.Enabled = false;
            requestedDate.Enabled = false;
            requestCo.Enabled = false;
            coPhone.Enabled = false;
            editRequestorButton.Enabled = true;
            saveRequestorButton.Enabled = false;
            cancelRequestorButton.Enabled = false;
        }
    }
}
