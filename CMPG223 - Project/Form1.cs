using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223___Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Date: " + DateTime.Today;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //direct to te insert form
                frmInsert form = new frmInsert();
                form.ShowDialog();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //direct to te update form
                frmUpdate form = new frmUpdate();
                form.ShowDialog();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
