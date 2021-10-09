using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223___Project
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        public float temp;
        public string symp;
        public int ID;
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            cbSymptoms.SelectedIndex = 0;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            temp = float.Parse(tbUpdateTemperature.Text);
            symp = cbSymptoms.SelectedItem.ToString();
            ID = int.Parse(tbUpdateScholarID.Text);
            this.Close();
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
