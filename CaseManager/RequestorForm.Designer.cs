namespace CaseManager
{
    partial class RequestorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestorForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelRequestorButton = new System.Windows.Forms.Button();
            this.saveRequestorButton = new System.Windows.Forms.Button();
            this.editRequestorButton = new System.Windows.Forms.Button();
            this.coPhone = new System.Windows.Forms.TextBox();
            this.requestCo = new System.Windows.Forms.TextBox();
            this.requestedDate = new System.Windows.Forms.DateTimePicker();
            this.pointOfContact = new System.Windows.Forms.TextBox();
            this.requestorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.feedbackRequestor = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelRequestorButton);
            this.groupBox1.Controls.Add(this.saveRequestorButton);
            this.groupBox1.Controls.Add(this.editRequestorButton);
            this.groupBox1.Controls.Add(this.coPhone);
            this.groupBox1.Controls.Add(this.requestCo);
            this.groupBox1.Controls.Add(this.requestedDate);
            this.groupBox1.Controls.Add(this.pointOfContact);
            this.groupBox1.Controls.Add(this.requestorName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // cancelRequestorButton
            // 
            this.cancelRequestorButton.Location = new System.Drawing.Point(20, 234);
            this.cancelRequestorButton.Name = "cancelRequestorButton";
            this.cancelRequestorButton.Size = new System.Drawing.Size(75, 23);
            this.cancelRequestorButton.TabIndex = 12;
            this.cancelRequestorButton.Text = "Cancel";
            this.cancelRequestorButton.UseVisualStyleBackColor = true;
            this.cancelRequestorButton.Click += new System.EventHandler(this.cancelRequestorButton_Click);
            // 
            // saveRequestorButton
            // 
            this.saveRequestorButton.Location = new System.Drawing.Point(267, 234);
            this.saveRequestorButton.Name = "saveRequestorButton";
            this.saveRequestorButton.Size = new System.Drawing.Size(75, 23);
            this.saveRequestorButton.TabIndex = 11;
            this.saveRequestorButton.Text = "Save";
            this.saveRequestorButton.UseVisualStyleBackColor = true;
            this.saveRequestorButton.Click += new System.EventHandler(this.saveRequestorButton_Click);
            // 
            // editRequestorButton
            // 
            this.editRequestorButton.Location = new System.Drawing.Point(143, 234);
            this.editRequestorButton.Name = "editRequestorButton";
            this.editRequestorButton.Size = new System.Drawing.Size(75, 23);
            this.editRequestorButton.TabIndex = 10;
            this.editRequestorButton.Text = "Edit";
            this.editRequestorButton.UseVisualStyleBackColor = true;
            this.editRequestorButton.Click += new System.EventHandler(this.editRequestorButton_Click);
            // 
            // coPhone
            // 
            this.coPhone.Enabled = false;
            this.coPhone.Location = new System.Drawing.Point(96, 165);
            this.coPhone.Name = "coPhone";
            this.coPhone.Size = new System.Drawing.Size(206, 20);
            this.coPhone.TabIndex = 9;
            // 
            // requestCo
            // 
            this.requestCo.Enabled = false;
            this.requestCo.Location = new System.Drawing.Point(119, 132);
            this.requestCo.Name = "requestCo";
            this.requestCo.Size = new System.Drawing.Size(182, 20);
            this.requestCo.TabIndex = 8;
            // 
            // requestedDate
            // 
            this.requestedDate.Enabled = false;
            this.requestedDate.Location = new System.Drawing.Point(102, 101);
            this.requestedDate.Name = "requestedDate";
            this.requestedDate.Size = new System.Drawing.Size(200, 20);
            this.requestedDate.TabIndex = 7;
            // 
            // pointOfContact
            // 
            this.pointOfContact.Enabled = false;
            this.pointOfContact.Location = new System.Drawing.Point(96, 64);
            this.pointOfContact.Name = "pointOfContact";
            this.pointOfContact.Size = new System.Drawing.Size(205, 20);
            this.pointOfContact.TabIndex = 6;
            // 
            // requestorName
            // 
            this.requestorName.Enabled = false;
            this.requestorName.Location = new System.Drawing.Point(103, 30);
            this.requestorName.Name = "requestorName";
            this.requestorName.Size = new System.Drawing.Size(199, 20);
            this.requestorName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Point of Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Company Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Requested:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Requestor Compnay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requestor Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.feedbackRequestor);
            this.groupBox2.Location = new System.Drawing.Point(393, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Feedback Log";
            // 
            // feedbackRequestor
            // 
            this.feedbackRequestor.Cursor = System.Windows.Forms.Cursors.Default;
            this.feedbackRequestor.Enabled = false;
            this.feedbackRequestor.Location = new System.Drawing.Point(7, 20);
            this.feedbackRequestor.Name = "feedbackRequestor";
            this.feedbackRequestor.ReadOnly = true;
            this.feedbackRequestor.Size = new System.Drawing.Size(200, 250);
            this.feedbackRequestor.TabIndex = 0;
            this.feedbackRequestor.Text = "";
            // 
            // RequestorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestorForm";
            this.Text = "RequestorForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveRequestorButton;
        private System.Windows.Forms.Button editRequestorButton;
        private System.Windows.Forms.TextBox coPhone;
        private System.Windows.Forms.TextBox requestCo;
        private System.Windows.Forms.DateTimePicker requestedDate;
        private System.Windows.Forms.TextBox pointOfContact;
        private System.Windows.Forms.TextBox requestorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox feedbackRequestor;
        private System.Windows.Forms.Button cancelRequestorButton;
    }
}