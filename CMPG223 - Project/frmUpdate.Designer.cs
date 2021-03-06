
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
            this.tbUpdateScholarID = new System.Windows.Forms.TextBox();
            this.tbUpdateTemperature = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.cbSymptoms = new System.Windows.Forms.ComboBox();
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(51, 267);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(165, 267);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCancel.TabIndex = 11;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // cbSymptoms
            // 
            this.cbSymptoms.FormattingEnabled = true;
            this.cbSymptoms.Items.AddRange(new object[] {
            "None",
            "Fever",
            "Cough",
            "Loss of taste or smell",
            "Sore throat",
            "Headache"});
            this.cbSymptoms.Location = new System.Drawing.Point(119, 134);
            this.cbSymptoms.Name = "cbSymptoms";
            this.cbSymptoms.Size = new System.Drawing.Size(121, 21);
            this.cbSymptoms.TabIndex = 12;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 302);
            this.Controls.Add(this.cbSymptoms);
            this.Controls.Add(this.btnUpdateCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbUpdateTemperature);
            this.Controls.Add(this.tbUpdateScholarID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdate";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUpdateTemperature;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdateCancel;
        public System.Windows.Forms.TextBox tbUpdateScholarID;
        private System.Windows.Forms.ComboBox cbSymptoms;
    }
}