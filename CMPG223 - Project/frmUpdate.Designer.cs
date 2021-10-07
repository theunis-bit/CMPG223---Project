
namespace CMPG223___Project
{
    partial class frmUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUpdateScholarID = new System.Windows.Forms.TextBox();
            this.tbUpdateTemperature = new System.Windows.Forms.TextBox();
            this.cbUdateAttendance = new System.Windows.Forms.CheckBox();
            this.clbUpdateSymptoms = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Scholar Symptoms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scholar ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Symptoms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Attendance";
            // 
            // tbUpdateScholarID
            // 
            this.tbUpdateScholarID.Location = new System.Drawing.Point(120, 71);
            this.tbUpdateScholarID.Name = "tbUpdateScholarID";
            this.tbUpdateScholarID.Size = new System.Drawing.Size(120, 20);
            this.tbUpdateScholarID.TabIndex = 5;
            // 
            // tbUpdateTemperature
            // 
            this.tbUpdateTemperature.Location = new System.Drawing.Point(120, 101);
            this.tbUpdateTemperature.Name = "tbUpdateTemperature";
            this.tbUpdateTemperature.Size = new System.Drawing.Size(120, 20);
            this.tbUpdateTemperature.TabIndex = 6;
            // 
            // cbUdateAttendance
            // 
            this.cbUdateAttendance.AutoSize = true;
            this.cbUdateAttendance.Location = new System.Drawing.Point(120, 234);
            this.cbUdateAttendance.Name = "cbUdateAttendance";
            this.cbUdateAttendance.Size = new System.Drawing.Size(15, 14);
            this.cbUdateAttendance.TabIndex = 8;
            this.cbUdateAttendance.UseVisualStyleBackColor = true;
            // 
            // clbUpdateSymptoms
            // 
            this.clbUpdateSymptoms.FormattingEnabled = true;
            this.clbUpdateSymptoms.Items.AddRange(new object[] {
            "Chough",
            "Loss of smell",
            "Loss of taste",
            "Short of breath",
            "Sore troaht"});
            this.clbUpdateSymptoms.Location = new System.Drawing.Point(120, 134);
            this.clbUpdateSymptoms.Name = "clbUpdateSymptoms";
            this.clbUpdateSymptoms.Size = new System.Drawing.Size(120, 79);
            this.clbUpdateSymptoms.TabIndex = 9;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 302);
            this.Controls.Add(this.clbUpdateSymptoms);
            this.Controls.Add(this.cbUdateAttendance);
            this.Controls.Add(this.tbUpdateTemperature);
            this.Controls.Add(this.tbUpdateScholarID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdate";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUpdateScholarID;
        private System.Windows.Forms.TextBox tbUpdateTemperature;
        private System.Windows.Forms.CheckBox cbUdateAttendance;
        private System.Windows.Forms.CheckedListBox clbUpdateSymptoms;
    }
}