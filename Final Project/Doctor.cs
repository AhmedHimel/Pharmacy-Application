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
    public partial class doctor : Form
    {
        public doctor()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void viewp_Click(object sender, EventArgs e)
        {
            doctorgridview.Rows.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True"); 
            connection.Open();            

            SqlCommand selectCommand = new SqlCommand("select * from DoctorConsultation", connection);


            SqlDataReader dataFromDb = selectCommand.ExecuteReader();

            while (dataFromDb.Read())
            {

                try
                {
                    var index = doctorgridview.Rows.Add();

                    doctorgridview.Rows[index].Cells[0].Value = dataFromDb["Doctor_Id"].ToString();
                    doctorgridview.Rows[index].Cells[1].Value = dataFromDb["Email"].ToString();
                    doctorgridview.Rows[index].Cells[2].Value = dataFromDb["Location"].ToString();
                    doctorgridview.Rows[index].Cells[3].Value = dataFromDb["Consultation_Time"].ToString();
                }
                catch (Exception ed) 
                {

                }
            }

            connection.Close();


        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            healthcare hc = new healthcare();
            hc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            string Id = id.Text;

            string Query = "Delete from DoctorConsultation where Doctor_Id =" + Id;
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Deleted!");

            id.Text = "";
            eml.Text = "";
            loc.Text = "";
            tm.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = search.Text;
            string Query = "Select * from DoctorConsultation where Email Like '%" + SearchData + "%' OR Location Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            doctorgridview.Rows.Clear();
            while (reader.Read())
            {
                doctorgridview.Rows.Add(reader["Doctor_Id"], reader["Email"], reader["Location"], reader["Consultation_Time"]);

            }
            connection.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = search.Text;
            string Query = "Select * from DoctorConsultation where Email Like '%" + SearchData + "%' OR Location Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            doctorgridview.Rows.Clear();
            while (reader.Read())
            {
                doctorgridview.Rows.Add(reader["Doctor_Id"], reader["Email"], reader["Location"], reader["Consultation_Time"]);

            }
            connection.Close();
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            string Id = id.Text;

            string Query = "select * from DoctorConsultation where Doctor_Id =" + Id;
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                id.Text = reader["Doctor_Id"].ToString();
                eml.Text = reader["Email"].ToString();
                loc.Text = reader["Location"].ToString();
                tm.Text = reader["Consultation_Time"].ToString();

            }
            else { MessageBox.Show("No Data!"); }
            connection.Close();
        }
    }
}
