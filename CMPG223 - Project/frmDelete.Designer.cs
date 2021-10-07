
namespace CMPG223___Project
{
    partial class frmDelete
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
            this.tbDeleteScholar = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDelCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove scholar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scholar ID: ";
            // 
            // tbDeleteScholar
            // 
            this.tbDeleteScholar.Location = new System.Drawing.Point(129, 72);
            this.tbDeleteScholar.Name = "tbDeleteScholar";
            this.tbDeleteScholar.Size = new System.Drawing.Size(100, 20);
            this.tbDeleteScholar.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(37, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelCancel
            // 
            this.btnDelCancel.Location = new System.Drawing.Point(154, 114);
            this.btnDelCancel.Name = "btnDelCancel";
            this.btnDelCancel.Size = new System.Drawing.Size(75, 23);
            this.btnDelCancel.TabIndex = 4;
            this.btnDelCancel.Text = "Cancel";
            this.btnDelCancel.UseVisualStyleBackColor = true;
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 172);
            this.Controls.Add(this.btnDelCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbDeleteScholar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDelete";
            this.Text = "frmDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDeleteScholar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDelCancel;
    }
}