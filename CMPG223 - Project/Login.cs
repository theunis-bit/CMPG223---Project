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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbLoginUsername.Text == "1234" && tbLoginPassword.Text == "Password")
            {
                frmMain form = new frmMain();
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Inncorect password or username");
            }
           
        }

        private void btnLoginCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
