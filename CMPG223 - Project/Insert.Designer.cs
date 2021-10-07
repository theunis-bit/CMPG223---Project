
namespace CMPG223___Project
{
    partial class Insert
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInsertCancel = new System.Windows.Forms.Button();
            this.tbxInsertScholarID = new System.Windows.Forms.TextBox();
            this.tbxInsertName = new System.Windows.Forms.TextBox();
            this.tbxInsertSurname = new System.Windows.Forms.TextBox();
            this.lblScholasrID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScholarDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(134, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnInsertCancel
            // 
            this.btnInsertCancel.Location = new System.Drawing.Point(224, 140);
            this.btnInsertCancel.Name = "btnInsertCancel";
            this.btnInsertCancel.Size = new System.Drawing.Size(75, 23);
            this.btnInsertCancel.TabIndex = 1;
            this.btnInsertCancel.Text = "Cancel";
            this.btnInsertCancel.UseVisualStyleBackColor = true;
            // 
            // tbxInsertScholarID
            // 
            this.tbxInsertScholarID.Location = new System.Drawing.Point(134, 45);
            this.tbxInsertScholarID.Name = "tbxInsertScholarID";
            this.tbxInsertScholarID.Size = new System.Drawing.Size(165, 20);
            this.tbxInsertScholarID.TabIndex = 2;
            // 
            // tbxInsertName
            // 
            this.tbxInsertName.Location = new System.Drawing.Point(134, 74);
            this.tbxInsertName.Name = "tbxInsertName";
            this.tbxInsertName.Size = new System.Drawing.Size(165, 20);
            this.tbxInsertName.TabIndex = 3;
            // 
            // tbxInsertSurname
            // 
            this.tbxInsertSurname.Location = new System.Drawing.Point(134, 100);
            this.tbxInsertSurname.Name = "tbxInsertSurname";
            this.tbxInsertSurname.Size = new System.Drawing.Size(165, 20);
            this.tbxInsertSurname.TabIndex = 4;
            // 
            // lblScholasrID
            // 
            this.lblScholasrID.AutoSize = true;
            this.lblScholasrID.Location = new System.Drawing.Point(27, 48);
            this.lblScholasrID.Name = "lblScholasrID";
            this.lblScholasrID.Size = new System.Drawing.Size(63, 13);
            this.lblScholasrID.TabIndex = 5;
            this.lblScholasrID.Text = "Scholar ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Scholar Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scholar Surname: ";
            // 
            // lblScholarDetails
            // 
            this.lblScholarDetails.AutoSize = true;
            this.lblScholarDetails.Location = new System.Drawing.Point(30, 13);
            this.lblScholarDetails.Name = "lblScholarDetails";
            this.lblScholarDetails.Size = new System.Drawing.Size(107, 13);
            this.lblScholarDetails.TabIndex = 8;
            this.lblScholarDetails.Text = "Enter Scholar details:";
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 191);
            this.Controls.Add(this.lblScholarDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScholasrID);
            this.Controls.Add(this.tbxInsertSurname);
            this.Controls.Add(this.tbxInsertName);
            this.Controls.Add(this.tbxInsertScholarID);
            this.Controls.Add(this.btnInsertCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "Insert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInsertCancel;
        private System.Windows.Forms.TextBox tbxInsertScholarID;
        private System.Windows.Forms.TextBox tbxInsertName;
        private System.Windows.Forms.TextBox tbxInsertSurname;
        private System.Windows.Forms.Label lblScholasrID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScholarDetails;
    }
}