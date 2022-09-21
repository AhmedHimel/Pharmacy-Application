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
    public partial class emergencycall : Form
    {
        public emergencycall()
        {
            InitializeComponent();
        }

        private void vecontact_Click(object sender, EventArgs e)
        {
            ecallgridview.Rows.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            SqlCommand selectCommand = new SqlCommand("select * from EmergencyContact", connection);
            SqlDataReader dataFromDb = selectCommand.ExecuteReader();

            while (dataFromDb.Read())
            {

                try
                {
                    var index = ecallgridview.Rows.Add();
                    ecallgridview.Rows[index].Cells[0].Value = dataFromDb["Cid"].ToString();
                    ecallgridview.Rows[index].Cells[1].Value = dataFromDb["Service_Provider"].ToString();
                    ecallgridview.Rows[index].Cells[2].Value = dataFromDb["Contact_Number"].ToString();
                    ecallgridview.Rows[index].Cells[3].Value = dataFromDb["Area"].ToString();

                }
                catch (Exception ed)
                {

                }
            }

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            userselect hc = new userselect();
            hc.ShowDialog();
        }

        private void srch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = search.Text;
            string Query = "Select * from EmergencyContact where Service_Provider Like '%" + SearchData + "%' OR Area Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            ecallgridview.Rows.Clear();
            while (reader.Read())
            {
                ecallgridview.Rows.Add(reader["CId"], reader["Service_Provider"], reader["Contact_Number"], reader["Area"]);

            }
            connection.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = search.Text;
            string Query = "Select * from EmergencyContact where Service_Provider Like '%" + SearchData + "%' OR Area Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            ecallgridview.Rows.Clear();
            while (reader.Read())
            {
                ecallgridview.Rows.Add(reader["CId"], reader["Service_Provider"], reader["Contact_Number"], reader["Area"]);

            }
            connection.Close();
        }
    }
}
