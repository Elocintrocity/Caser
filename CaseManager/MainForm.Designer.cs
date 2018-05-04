namespace CaseManager
{
    partial class caseManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caseManagerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.importCaseButton = new System.Windows.Forms.Button();
            this.newCaseButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.caseViewer = new System.Windows.Forms.DataGridView();
            this.Date_Added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Requested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requestor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exhibition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.importCaseButton);
            this.groupBox1.Controls.Add(this.newCaseButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Case Selection";
            // 
            // importCaseButton
            // 
            this.importCaseButton.Location = new System.Drawing.Point(37, 100);
            this.importCaseButton.Name = "importCaseButton";
            this.importCaseButton.Size = new System.Drawing.Size(75, 23);
            this.importCaseButton.TabIndex = 1;
            this.importCaseButton.Text = "Import Case";
            this.importCaseButton.UseVisualStyleBackColor = true;
            this.importCaseButton.Click += new System.EventHandler(this.importCaseButton_Click);
            // 
            // newCaseButton
            // 
            this.newCaseButton.Location = new System.Drawing.Point(37, 47);
            this.newCaseButton.Name = "newCaseButton";
            this.newCaseButton.Size = new System.Drawing.Size(75, 23);
            this.newCaseButton.TabIndex = 0;
            this.newCaseButton.Text = "New Case";
            this.newCaseButton.UseVisualStyleBackColor = true;
            this.newCaseButton.Click += new System.EventHandler(this.newCaseButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.caseViewer);
            this.groupBox2.Location = new System.Drawing.Point(168, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(944, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cases";
            // 
            // caseViewer
            // 
            this.caseViewer.AllowUserToAddRows = false;
            this.caseViewer.AllowUserToDeleteRows = false;
            this.caseViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.caseViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.caseViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caseViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date_Added,
            this.Date_Requested,
            this.CaseID,
            this.Requestor,
            this.Agency,
            this.Hours,
            this.Offense,
            this.Exhibition,
            this.Status});
            this.caseViewer.Location = new System.Drawing.Point(7, 20);
            this.caseViewer.MultiSelect = false;
            this.caseViewer.Name = "caseViewer";
            this.caseViewer.ReadOnly = true;
            this.caseViewer.Size = new System.Drawing.Size(921, 297);
            this.caseViewer.TabIndex = 0;
            this.caseViewer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.caseViewer_CellDoubleClick);
            // 
            // Date_Added
            // 
            this.Date_Added.HeaderText = "Date Added";
            this.Date_Added.Name = "Date_Added";
            this.Date_Added.ReadOnly = true;
            this.Date_Added.Width = 82;
            // 
            // Date_Requested
            // 
            this.Date_Requested.HeaderText = "Date Requested";
            this.Date_Requested.Name = "Date_Requested";
            this.Date_Requested.ReadOnly = true;
            this.Date_Requested.Width = 101;
            // 
            // CaseID
            // 
            this.CaseID.HeaderText = "Case ID";
            this.CaseID.Name = "CaseID";
            this.CaseID.ReadOnly = true;
            this.CaseID.Width = 65;
            // 
            // Requestor
            // 
            this.Requestor.HeaderText = "Requestor";
            this.Requestor.Name = "Requestor";
            this.Requestor.ReadOnly = true;
            this.Requestor.Width = 81;
            // 
            // Agency
            // 
            this.Agency.HeaderText = "Agency";
            this.Agency.Name = "Agency";
            this.Agency.ReadOnly = true;
            this.Agency.Width = 68;
            // 
            // Hours
            // 
            this.Hours.FillWeight = 25F;
            this.Hours.HeaderText = "Hours";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            this.Hours.Width = 60;
            // 
            // Offense
            // 
            this.Offense.HeaderText = "Offense";
            this.Offense.Name = "Offense";
            this.Offense.ReadOnly = true;
            this.Offense.Width = 69;
            // 
            // Exhibition
            // 
            this.Exhibition.HeaderText = "Exhibition";
            this.Exhibition.Name = "Exhibition";
            this.Exhibition.ReadOnly = true;
            this.Exhibition.Width = 77;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 62;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // caseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 345);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "caseManagerForm";
            this.Text = "Case Manager";
            this.Load += new System.EventHandler(this.caseManagerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caseViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button importCaseButton;
        private System.Windows.Forms.Button newCaseButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView caseViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Added;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Requested;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requestor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exhibition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

