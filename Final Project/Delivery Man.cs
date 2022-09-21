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
    public partial class deliveryman : Form
    {
        public deliveryman()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vieworder_Click(object sender, EventArgs e)
        {
            deliverygridview.Rows.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            
            SqlCommand selectCommand = new SqlCommand("select * from OrderMedicine", connection);

            SqlDataReader dataFromDb = selectCommand.ExecuteReader();

            while (dataFromDb.Read())
            {



                try
                {
                    var index = deliverygridview.Rows.Add();
                    deliverygridview.Rows[index].Cells[0].Value = dataFromDb["M_id"].ToString();
                    deliverygridview.Rows[index].Cells[1].Value = dataFromDb["Medicine_Name"].ToString();
                    deliverygridview.Rows[index].Cells[2].Value = dataFromDb["Quantity"].ToString();
                    deliverygridview.Rows[index].Cells[3].Value = dataFromDb["Amount"].ToString();
                    deliverygridview.Rows[index].Cells[4].Value = dataFromDb["Address"].ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = search.Text;
            string Query = "Select * from OrderMedicine where Medicine_Name Like '%" + SearchData + "%' OR Address Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            deliverygridview.Rows.Clear();
            while (reader.Read())
            {
                deliverygridview.Rows.Add(reader["M_id"], reader["Medicine_Name"], reader["Quantity"], reader["Amount"], reader["Address"]);

            }
            connection.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = search.Text;
            string Query = "Select * from OrderMedicine where Medicine_Name Like '%" + SearchData + "%' OR Address Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            deliverygridview.Rows.Clear();
            while (reader.Read())
            {
                deliverygridview.Rows.Add(reader["M_id"],reader["Medicine_Name"], reader["Quantity"], reader["Amount"], reader["Address"]);

            }
            connection.Close();
        }
    }
}
