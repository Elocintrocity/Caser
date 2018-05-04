namespace CaseManager
{
    partial class HoursForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoursForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendReportButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reportBox = new System.Windows.Forms.RichTextBox();
            this.addingHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teamHours = new System.Windows.Forms.TextBox();
            this.indivHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.openReportDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendReportButton);
            this.groupBox1.Controls.Add(this.uploadButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.reportBox);
            this.groupBox1.Controls.Add(this.addingHours);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.teamHours);
            this.groupBox1.Controls.Add(this.indivHours);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contribution";
            // 
            // sendReportButton
            // 
            this.sendReportButton.Location = new System.Drawing.Point(450, 297);
            this.sendReportButton.Name = "sendReportButton";
            this.sendReportButton.Size = new System.Drawing.Size(105, 23);
            this.sendReportButton.TabIndex = 10;
            this.sendReportButton.Text = "Send";
            this.sendReportButton.UseVisualStyleBackColor = true;
            this.sendReportButton.Click += new System.EventHandler(this.sendReportButton_Click);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(450, 233);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(105, 23);
            this.uploadButton.TabIndex = 9;
            this.uploadButton.Text = "Upload Report";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Report:";
            // 
            // reportBox
            // 
            this.reportBox.Location = new System.Drawing.Point(18, 200);
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(404, 155);
            this.reportBox.TabIndex = 7;
            this.reportBox.Text = "";
            // 
            // addingHours
            // 
            this.addingHours.Location = new System.Drawing.Point(104, 95);
            this.addingHours.Name = "addingHours";
            this.addingHours.Size = new System.Drawing.Size(100, 20);
            this.addingHours.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adding:";
            // 
            // teamHours
            // 
            this.teamHours.Enabled = false;
            this.teamHours.Location = new System.Drawing.Point(104, 63);
            this.teamHours.Name = "teamHours";
            this.teamHours.Size = new System.Drawing.Size(100, 20);
            this.teamHours.TabIndex = 4;
            // 
            // indivHours
            // 
            this.indivHours.Enabled = false;
            this.indivHours.Location = new System.Drawing.Point(104, 33);
            this.indivHours.Name = "indivHours";
            this.indivHours.Size = new System.Drawing.Size(100, 20);
            this.indivHours.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team Hours:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(343, 15);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Individual Hours:";
            // 
            // openReportDialog
            // 
            this.openReportDialog.FileName = "openFileDialog1";
            this.openReportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openReportDialog_FileOk);
            // 
            // HoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 398);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HoursForm";
            this.Text = "Hours";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendReportButton;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox reportBox;
        private System.Windows.Forms.TextBox addingHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teamHours;
        private System.Windows.Forms.TextBox indivHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openReportDialog;
    }
}