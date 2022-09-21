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
    public partial class emcallinfo : Form
    {
        public emcallinfo()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.ShowDialog();
        }

        private void view_Click(object sender, EventArgs e)
        {
            emcallgridview.Rows.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            SqlCommand selectCommand = new SqlCommand("select * from EmergencyContact", connection);
            SqlDataReader dataFromDb = selectCommand.ExecuteReader();

            while (dataFromDb.Read())
            {

                try
                {
                    var index = emcallgridview.Rows.Add();
                    emcallgridview.Rows[index].Cells[0].Value = dataFromDb["Cid"].ToString();
                    emcallgridview.Rows[index].Cells[1].Value = dataFromDb["Service_Provider"].ToString();
                    emcallgridview.Rows[index].Cells[2].Value = dataFromDb["Contact_Number"].ToString();
                    emcallgridview.Rows[index].Cells[3].Value = dataFromDb["Area"].ToString();

                }
                catch (Exception ed)
                {

                }
            }

            connection.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = search.Text;
            string Query = "Select * from EmergencyContact where Service_Provider Like '%" + SearchData + "%' OR Area Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            emcallgridview.Rows.Clear();
            while (reader.Read())
            {
                emcallgridview.Rows.Add(reader["CId"], reader["Service_Provider"], reader["Contact_Number"], reader["Area"]);

            }
            connection.Close();
        }

        private void srch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = srch.Text;
            string Query = "Select * from EmergencyContact where Service_Provider Like '%" + SearchData + "%' OR Area Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            emcallgridview.Rows.Clear();
            while (reader.Read())
            {
                emcallgridview.Rows.Add(reader["CId"], reader["Service_Provider"], reader["Contact_Number"], reader["Area"]);

            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            string Id = eid.Text;

            string Query = "select * from EmergencyContact where Cid =" + Id;
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                eid.Text = reader["CId"].ToString();
                ename.Text = reader["Service_Provider"].ToString();
                enm.Text = reader["Contact_Number"].ToString();
                earea.Text = reader["Area"].ToString();

            }
            else { MessageBox.Show("No Data!"); }
            connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            string Id = eid.Text;

            string Query = "Delete from EmergencyContact where CId =" + Id;
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Deleted!");

            eid.Text = "";
            ename.Text = "";
            enm.Text = "";
            earea.Text = "";
        }
    }
}
