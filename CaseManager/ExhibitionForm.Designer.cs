namespace CaseManager
{
    partial class ExhibitionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExhibitionForm));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Evidence Information", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Name:");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Model:");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Kind:");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Size:");
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exhibitionImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.evidenceInfo = new System.Windows.Forms.ListView();
            this.evidenceList = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Make = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uploadEvidenceButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cancelEditButton = new System.Windows.Forms.Button();
            this.downloadReportButton = new System.Windows.Forms.Button();
            this.saveReportButton = new System.Windows.Forms.Button();
            this.reportBox = new System.Windows.Forms.RichTextBox();
            this.editReportButton = new System.Windows.Forms.Button();
            this.uploadEvidence = new System.Windows.Forms.OpenFileDialog();
            this.saveReport = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitionImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exhibitionImage);
            this.groupBox1.Location = new System.Drawing.Point(512, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exhibit Image";
            // 
            // exhibitionImage
            // 
            this.exhibitionImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("exhibitionImage.InitialImage")));
            this.exhibitionImage.Location = new System.Drawing.Point(7, 20);
            this.exhibitionImage.Name = "exhibitionImage";
            this.exhibitionImage.Size = new System.Drawing.Size(255, 227);
            this.exhibitionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exhibitionImage.TabIndex = 0;
            this.exhibitionImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.evidenceInfo);
            this.groupBox2.Controls.Add(this.evidenceList);
            this.groupBox2.Controls.Add(this.uploadEvidenceButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evidence";
            // 
            // evidenceInfo
            // 
            listViewGroup1.Header = "Evidence Information";
            listViewGroup1.Name = "Information";
            this.evidenceInfo.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            this.evidenceInfo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.evidenceInfo.Location = new System.Drawing.Point(193, 20);
            this.evidenceInfo.Name = "evidenceInfo";
            this.evidenceInfo.Size = new System.Drawing.Size(294, 173);
            this.evidenceInfo.TabIndex = 6;
            this.evidenceInfo.UseCompatibleStateImageBehavior = false;
            this.evidenceInfo.View = System.Windows.Forms.View.Tile;
            // 
            // evidenceList
            // 
            this.evidenceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Make,
            this.Model,
            this.Size});
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "Evidence";
            this.evidenceList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.evidenceList.Location = new System.Drawing.Point(16, 20);
            this.evidenceList.Name = "evidenceList";
            this.evidenceList.Size = new System.Drawing.Size(171, 173);
            this.evidenceList.TabIndex = 5;
            this.evidenceList.UseCompatibleStateImageBehavior = false;
            this.evidenceList.View = System.Windows.Forms.View.List;
            this.evidenceList.SelectedIndexChanged += new System.EventHandler(this.evidenceListView_SelectedIndexChanged);
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Make
            // 
            this.Make.Text = "Make";
            // 
            // Model
            // 
            this.Model.Text = "Model";
            // 
            // Size
            // 
            this.Size.Text = "Size";
            // 
            // uploadEvidenceButton
            // 
            this.uploadEvidenceButton.Location = new System.Drawing.Point(42, 209);
            this.uploadEvidenceButton.Name = "uploadEvidenceButton";
            this.uploadEvidenceButton.Size = new System.Drawing.Size(105, 23);
            this.uploadEvidenceButton.TabIndex = 0;
            this.uploadEvidenceButton.Text = "Upload Evidence";
            this.uploadEvidenceButton.UseVisualStyleBackColor = true;
            this.uploadEvidenceButton.Click += new System.EventHandler(this.uploadEvidenceButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cancelEditButton);
            this.groupBox3.Controls.Add(this.downloadReportButton);
            this.groupBox3.Controls.Add(this.saveReportButton);
            this.groupBox3.Controls.Add(this.reportBox);
            this.groupBox3.Controls.Add(this.editReportButton);
            this.groupBox3.Location = new System.Drawing.Point(13, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 226);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report";
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Enabled = false;
            this.cancelEditButton.Location = new System.Drawing.Point(629, 138);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(115, 23);
            this.cancelEditButton.TabIndex = 4;
            this.cancelEditButton.Text = "Cancel Edit";
            this.cancelEditButton.UseVisualStyleBackColor = true;
            this.cancelEditButton.Click += new System.EventHandler(this.cancelEditButton_Click);
            // 
            // downloadReportButton
            // 
            this.downloadReportButton.Enabled = false;
            this.downloadReportButton.Location = new System.Drawing.Point(629, 32);
            this.downloadReportButton.Name = "downloadReportButton";
            this.downloadReportButton.Size = new System.Drawing.Size(115, 23);
            this.downloadReportButton.TabIndex = 3;
            this.downloadReportButton.Text = "Download Report";
            this.downloadReportButton.UseVisualStyleBackColor = true;
            this.downloadReportButton.Click += new System.EventHandler(this.downloadReportButton_Click);
            // 
            // saveReportButton
            // 
            this.saveReportButton.Enabled = false;
            this.saveReportButton.Location = new System.Drawing.Point(629, 180);
            this.saveReportButton.Name = "saveReportButton";
            this.saveReportButton.Size = new System.Drawing.Size(115, 23);
            this.saveReportButton.TabIndex = 2;
            this.saveReportButton.Text = "Save Report";
            this.saveReportButton.UseVisualStyleBackColor = true;
            this.saveReportButton.Click += new System.EventHandler(this.saveReportButton_Click);
            // 
            // reportBox
            // 
            this.reportBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.reportBox.Enabled = false;
            this.reportBox.Location = new System.Drawing.Point(7, 19);
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(593, 201);
            this.reportBox.TabIndex = 1;
            this.reportBox.Text = "";
            // 
            // editReportButton
            // 
            this.editReportButton.Enabled = false;
            this.editReportButton.Location = new System.Drawing.Point(629, 98);
            this.editReportButton.Name = "editReportButton";
            this.editReportButton.Size = new System.Drawing.Size(115, 23);
            this.editReportButton.TabIndex = 0;
            this.editReportButton.Text = "Edit Report";
            this.editReportButton.UseVisualStyleBackColor = true;
            this.editReportButton.Click += new System.EventHandler(this.editReportButton_Click);
            // 
            // uploadEvidence
            // 
            this.uploadEvidence.FileName = "openFileDialog1";
            // 
            // ExhibitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 511);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExhibitionForm";
            this.Text = "Exhibition";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exhibitionImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox exhibitionImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView evidenceList;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Make;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.Button uploadEvidenceButton;
        private System.Windows.Forms.Button saveReportButton;
        private System.Windows.Forms.RichTextBox reportBox;
        private System.Windows.Forms.Button editReportButton;
        private System.Windows.Forms.Button downloadReportButton;
        private System.Windows.Forms.ListView evidenceInfo;
        private System.Windows.Forms.OpenFileDialog uploadEvidence;
        private System.Windows.Forms.SaveFileDialog saveReport;
        private System.Windows.Forms.Button cancelEditButton;
    }
}