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

namespace Final_Project
{
    public partial class empinfo : Form
    {
        public empinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dminfocheckgridview.Rows.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("select * from DeliverMan", connection);


            SqlDataReader dataFromDb = selectCommand.ExecuteReader();

            while (dataFromDb.Read())
            {

                try
                {
                    var index = dminfocheckgridview.Rows.Add();

                    dminfocheckgridview.Rows[index].Cells[0].Value = dataFromDb["id"].ToString();
                    dminfocheckgridview.Rows[index].Cells[1].Value = dataFromDb["D_Name"].ToString();

                }
                catch (Exception ed)
                {

                }
            }

            connection.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.ShowDialog();
        }

        private void dview_Click(object sender, EventArgs e)
        {
            dcinfoecheckgridview.Rows.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("select * from Doctor", connection);


            SqlDataReader dataFromDb = selectCommand.ExecuteReader();

            while (dataFromDb.Read())
            {

                try
                {
                    var index = dcinfoecheckgridview.Rows.Add();

                    dcinfoecheckgridview.Rows[index].Cells[0].Value = dataFromDb["id"].ToString();
                    dcinfoecheckgridview.Rows[index].Cells[1].Value = dataFromDb["Employee_Name"].ToString();

                }
                catch (Exception ed)
                {

                }
            }

            connection.Close();
        }

        private void ddelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            string Id = dcid.Text;

            string Query = "Delete from Doctor where id =" + Id;
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Deleted!");

            dcid.Text = "";
            dcname.Text = "";
            
        }

        private void dmdel_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            string Id = dlid.Text;

            string Query = "Delete from DeliverMan where id =" + Id;
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Deleted!");

            dlid.Text = "";
            dlname.Text = "";
        }

        private void DLsrch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = srch.Text;
            string Query = "Select * from DeliverMan where D_Name Like '%"+SearchData+"%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            dminfocheckgridview.Rows.Clear();
            while (reader.Read())
            {
                dminfocheckgridview.Rows.Add(reader["id"], reader["D_Name"]);

            }
            connection.Close();
        }

        private void srch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = srch.Text;
            string Query = "Select * from DeliverMan where D_Name Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            dminfocheckgridview.Rows.Clear();
            while (reader.Read())
            {
                dminfocheckgridview.Rows.Add(reader["id"], reader["D_Name"]);

            }
            connection.Close();
        }

        private void src_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = src.Text;
            string Query = "Select * from Doctor where Employee_Name Like '%" + SearchData + "%' ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            dcinfoecheckgridview.Rows.Clear();
            while (reader.Read())
            {
                dcinfoecheckgridview.Rows.Add(reader["id"], reader["Employee_Name"]);

            }
            connection.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = src.Text;
            string Query = "Select * from Doctor where Employee_Name Like '%" + SearchData + "%' ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            dcinfoecheckgridview.Rows.Clear();
            while (reader.Read())
            {
                dcinfoecheckgridview.Rows.Add(reader["id"], reader["Employee_Name"]);

            }
            connection.Close();
        }
    }
}
