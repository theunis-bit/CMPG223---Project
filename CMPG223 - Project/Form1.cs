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

        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24510777\Documents\GitHub\CMPG223---Project\CMPG223 - Project\ScholarData.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader theReader;


        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Date: " + DateTime.Today;

            lbDisplay.Items.Add("ScholarID\tName\tSurname\tAttendance\tSymptoms\tTemperature");
            Launch();
        }

        private void Launch()
        {
            try
            {
                // data grid view
                conn = new SqlConnection(conStr);
                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Dataset";

                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Table");

                dbView.DataSource = ds;
                dbView.DataMember = "Table";

                conn.Close();

                cbxID.DisplayMember = "ScholarID";
                cbxID.DataSource = ds.Tables["Table"];
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //direct to te insert form
                frmInsert form = new frmInsert();
                form.ShowDialog();
                conn.Close();
                conn.Open();
                string sql = "INSERT INTO Dataset(ScholarID, Name, Surname) VALUES(@Id, @nm, @snm)";
                comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@Id", form.ID);
                comm.Parameters.AddWithValue("@nm", form.name);
                comm.Parameters.AddWithValue("@snm", form.surname);
                comm.ExecuteNonQuery();
                Launch();

                conn.Close();

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbDisplay.Items.Clear();
            
            try
            {

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();


                string sql = @"SELECT * FROM Dataset WHERE ScholarID LIKE'%" + textBox1.Text + "%'";
                

                comm = new SqlCommand(sql, conn);
                

                adap.SelectCommand = comm;
                adap.Fill(ds, "Table");

                dbView.DataSource = ds;
                dbView.DataMember = "Table";

                //listbox

                
                comm = new SqlCommand(sql, conn);
                theReader = comm.ExecuteReader();
                lbDisplay.Items.Add("ScholarID\tName\tSurname\tAttendance\tSymptoms\tTemperature");

                while (theReader.Read())
                {

                    
                    lbDisplay.Items.Add(theReader.GetValue(0) + "\t\t" + theReader.GetValue(1) + "\t" + theReader.GetValue(2) + "\t" + theReader.GetValue(3));

                }


                conn.Close();


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //conn.Open();
            string sql = "DELETE FROM Dataset WHERE ScholarID = '" + cbxID.Text +" ' ";
            conn.Open();
            comm = new SqlCommand(sql, conn);
            adap = new SqlDataAdapter();
            adap.DeleteCommand = comm;
            adap.DeleteCommand.ExecuteNonQuery();

            Launch();
            conn.Close();
        }
    }
    
}
