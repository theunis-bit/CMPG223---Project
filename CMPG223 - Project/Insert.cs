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
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
        }
        public string name;
        public string surname;
        public int ID;

        private void btnInsertCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                name = tbxInsertName.Text;
                surname = tbxInsertSurname.Text;
                ID = int.Parse(tbxInsertScholarID.Text);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }


    }
}
