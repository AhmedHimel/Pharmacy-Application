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
    public partial class medinfo : Form
    {
        public medinfo()
        {
            InitializeComponent();
        }

        private void view_Click(object sender, EventArgs e)
        {
            medinfogridview.Rows.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("select * from MedicineInfo", connection);


            SqlDataReader dataFromDb = selectCommand.ExecuteReader();

            while (dataFromDb.Read())
            {

                try
                {
                    var index = medinfogridview.Rows.Add();
                    medinfogridview.Rows[index].Cells[0].Value = dataFromDb["Mid"].ToString();
                    medinfogridview.Rows[index].Cells[1].Value = dataFromDb["MName"].ToString();
                    medinfogridview.Rows[index].Cells[2].Value = dataFromDb["price"].ToString();

                }
                catch (Exception ed)
                {

                }
            }

            connection.Close();
        }

        private void addmed_Click(object sender, EventArgs e)
        {
            this.Hide();
            addmed am = new addmed();
            am.ShowDialog();
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
            upmed um = new upmed();
            um.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = sr.Text;
            string Query = "Select * from MedicineInfo where MName Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            medinfogridview.Rows.Clear();
            while (reader.Read())
            {
                medinfogridview.Rows.Add(reader["Mid"], reader["MName"], reader["price"]);

            }
            connection.Close();
        }

        private void sr_TextChanged(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = sr.Text;
            string Query = "Select * from MedicineInfo where MName Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            medinfogridview.Rows.Clear();
            while (reader.Read())
            {
                medinfogridview.Rows.Add(reader["Mid"], reader["MName"], reader["price"]);

            }
            connection.Close();
        }

        private void delmed_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            con.Open();
            string Id = id.Text;
            string Query = "Delete from MedicineInfo where Mid =" + Id;
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Medicine Deleted!");
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            string Mname = mn.Text;

            string Query = "select * from Medicine where M_Name =" + Mname;
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                mn.Text = reader["M_Name"].ToString();
                pr.Text = reader["price"].ToString();

            }
            else { MessageBox.Show("No Data!"); }
            connection.Close();
        }

        private void fetch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            string Id = id.Text;

            string Query = "select * from MedicineInfo where Mid =" + Id;
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                id.Text = reader["Mid"].ToString();
                mn.Text = reader["Mname"].ToString();
                pr.Text = reader["price"].ToString();
                

            }
            else { MessageBox.Show("No Data!"); }
            connection.Close();
        }
    }
}
