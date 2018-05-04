namespace CaseManager
{
    partial class OffenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OffenseForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelEditButton = new System.Windows.Forms.Button();
            this.saveEditButton = new System.Windows.Forms.Button();
            this.offenseDate = new System.Windows.Forms.DateTimePicker();
            this.editOffenseButton = new System.Windows.Forms.Button();
            this.victimDOB = new System.Windows.Forms.DateTimePicker();
            this.subjectDOB = new System.Windows.Forms.DateTimePicker();
            this.checkICACNo = new System.Windows.Forms.CheckBox();
            this.checkICACYes = new System.Windows.Forms.CheckBox();
            this.victimBox = new System.Windows.Forms.TextBox();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.offenseBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveNotesButton = new System.Windows.Forms.Button();
            this.richNotes = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.feedbackBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelEditButton);
            this.groupBox1.Controls.Add(this.saveEditButton);
            this.groupBox1.Controls.Add(this.offenseDate);
            this.groupBox1.Controls.Add(this.editOffenseButton);
            this.groupBox1.Controls.Add(this.victimDOB);
            this.groupBox1.Controls.Add(this.subjectDOB);
            this.groupBox1.Controls.Add(this.checkICACNo);
            this.groupBox1.Controls.Add(this.checkICACYes);
            this.groupBox1.Controls.Add(this.victimBox);
            this.groupBox1.Controls.Add(this.subjectBox);
            this.groupBox1.Controls.Add(this.offenseBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Location = new System.Drawing.Point(379, 178);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(75, 23);
            this.cancelEditButton.TabIndex = 22;
            this.cancelEditButton.Text = "Cancel Edit";
            this.cancelEditButton.UseVisualStyleBackColor = true;
            this.cancelEditButton.Click += new System.EventHandler(this.cancelEditButton_Click);
            // 
            // saveEditButton
            // 
            this.saveEditButton.Enabled = false;
            this.saveEditButton.Location = new System.Drawing.Point(379, 123);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(75, 23);
            this.saveEditButton.TabIndex = 21;
            this.saveEditButton.Text = "Save Edit";
            this.saveEditButton.UseVisualStyleBackColor = true;
            this.saveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // offenseDate
            // 
            this.offenseDate.Enabled = false;
            this.offenseDate.Location = new System.Drawing.Point(92, 56);
            this.offenseDate.Name = "offenseDate";
            this.offenseDate.Size = new System.Drawing.Size(200, 20);
            this.offenseDate.TabIndex = 20;
            // 
            // editOffenseButton
            // 
            this.editOffenseButton.Location = new System.Drawing.Point(379, 73);
            this.editOffenseButton.Name = "editOffenseButton";
            this.editOffenseButton.Size = new System.Drawing.Size(75, 23);
            this.editOffenseButton.TabIndex = 19;
            this.editOffenseButton.Text = "Edit";
            this.editOffenseButton.UseVisualStyleBackColor = true;
            this.editOffenseButton.Click += new System.EventHandler(this.editOffenseButton_Click);
            // 
            // victimDOB
            // 
            this.victimDOB.Enabled = false;
            this.victimDOB.Location = new System.Drawing.Point(83, 219);
            this.victimDOB.MaxDate = new System.DateTime(2018, 4, 16, 0, 0, 0, 0);
            this.victimDOB.Name = "victimDOB";
            this.victimDOB.Size = new System.Drawing.Size(205, 20);
            this.victimDOB.TabIndex = 18;
            this.victimDOB.Value = new System.DateTime(2018, 4, 16, 0, 0, 0, 0);
            // 
            // subjectDOB
            // 
            this.subjectDOB.Enabled = false;
            this.subjectDOB.Location = new System.Drawing.Point(88, 152);
            this.subjectDOB.MaxDate = new System.DateTime(2018, 4, 16, 0, 0, 0, 0);
            this.subjectDOB.Name = "subjectDOB";
            this.subjectDOB.Size = new System.Drawing.Size(200, 20);
            this.subjectDOB.TabIndex = 17;
            this.subjectDOB.Value = new System.DateTime(2018, 4, 16, 0, 0, 0, 0);
            // 
            // checkICACNo
            // 
            this.checkICACNo.AutoSize = true;
            this.checkICACNo.Enabled = false;
            this.checkICACNo.Location = new System.Drawing.Point(160, 92);
            this.checkICACNo.Name = "checkICACNo";
            this.checkICACNo.Size = new System.Drawing.Size(40, 17);
            this.checkICACNo.TabIndex = 15;
            this.checkICACNo.Text = "No";
            this.checkICACNo.UseVisualStyleBackColor = true;
            // 
            // checkICACYes
            // 
            this.checkICACYes.AutoSize = true;
            this.checkICACYes.Enabled = false;
            this.checkICACYes.Location = new System.Drawing.Point(109, 92);
            this.checkICACYes.Name = "checkICACYes";
            this.checkICACYes.Size = new System.Drawing.Size(44, 17);
            this.checkICACYes.TabIndex = 14;
            this.checkICACYes.Text = "Yes";
            this.checkICACYes.UseVisualStyleBackColor = true;
            // 
            // victimBox
            // 
            this.victimBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.victimBox.Enabled = false;
            this.victimBox.Location = new System.Drawing.Point(88, 185);
            this.victimBox.Name = "victimBox";
            this.victimBox.Size = new System.Drawing.Size(200, 20);
            this.victimBox.TabIndex = 12;
            // 
            // subjectBox
            // 
            this.subjectBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.subjectBox.Enabled = false;
            this.subjectBox.Location = new System.Drawing.Point(92, 120);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(196, 20);
            this.subjectBox.TabIndex = 10;
            // 
            // offenseBox
            // 
            this.offenseBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.offenseBox.Enabled = false;
            this.offenseBox.Location = new System.Drawing.Point(93, 27);
            this.offenseBox.Name = "offenseBox";
            this.offenseBox.Size = new System.Drawing.Size(195, 20);
            this.offenseBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Victim DOB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Victim Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subject DOB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ICAC Reportable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Offense Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Offense Type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveNotesButton);
            this.groupBox2.Controls.Add(this.richNotes);
            this.groupBox2.Location = new System.Drawing.Point(13, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notes";
            // 
            // saveNotesButton
            // 
            this.saveNotesButton.Location = new System.Drawing.Point(590, 99);
            this.saveNotesButton.Name = "saveNotesButton";
            this.saveNotesButton.Size = new System.Drawing.Size(75, 23);
            this.saveNotesButton.TabIndex = 1;
            this.saveNotesButton.Text = "Save";
            this.saveNotesButton.UseVisualStyleBackColor = true;
            this.saveNotesButton.Click += new System.EventHandler(this.saveNotesButton_Click);
            // 
            // richNotes
            // 
            this.richNotes.Location = new System.Drawing.Point(7, 20);
            this.richNotes.Name = "richNotes";
            this.richNotes.Size = new System.Drawing.Size(560, 196);
            this.richNotes.TabIndex = 0;
            this.richNotes.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.feedbackBox);
            this.groupBox3.Location = new System.Drawing.Point(526, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 262);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Feedback Log";
            // 
            // feedbackBox
            // 
            this.feedbackBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.feedbackBox.Enabled = false;
            this.feedbackBox.Location = new System.Drawing.Point(7, 20);
            this.feedbackBox.Name = "feedbackBox";
            this.feedbackBox.ReadOnly = true;
            this.feedbackBox.Size = new System.Drawing.Size(159, 236);
            this.feedbackBox.TabIndex = 0;
            this.feedbackBox.Text = "";
            // 
            // OffenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OffenseForm";
            this.Text = "Offense";
            this.Load += new System.EventHandler(this.OffenseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button editOffenseButton;
        private System.Windows.Forms.DateTimePicker victimDOB;
        private System.Windows.Forms.DateTimePicker subjectDOB;
        private System.Windows.Forms.CheckBox checkICACNo;
        private System.Windows.Forms.CheckBox checkICACYes;
        private System.Windows.Forms.TextBox victimBox;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.TextBox offenseBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richNotes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker offenseDate;
        private System.Windows.Forms.Button saveNotesButton;
        private System.Windows.Forms.Button saveEditButton;
        private System.Windows.Forms.Button cancelEditButton;
        private System.Windows.Forms.RichTextBox feedbackBox;
    }
}