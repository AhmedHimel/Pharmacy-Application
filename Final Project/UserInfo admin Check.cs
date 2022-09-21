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
    public partial class userinformation : Form
    {
        public userinformation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userinfocheckgridview.Rows.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            SqlCommand selectCommand = new SqlCommand("select * from UserInfo", connection);


            SqlDataReader dataFromDb = selectCommand.ExecuteReader();

            while (dataFromDb.Read())
            {

                try
                {
                    var index = userinfocheckgridview.Rows.Add();

                    userinfocheckgridview.Rows[index].Cells[0].Value = dataFromDb["User_Name"].ToString();
                    userinfocheckgridview.Rows[index].Cells[1].Value = dataFromDb["Contact_Number"].ToString();
                    userinfocheckgridview.Rows[index].Cells[2].Value = dataFromDb["User_Address"].ToString();
                   




                }
                catch (Exception ed)
                {

                }
            }

            connection.Close();
        }

        private void srch_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = search.Text;
            string Query = "Select * from UserInfo where User_Name Like '%" + SearchData + "%' OR User_Address Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            userinfocheckgridview.Rows.Clear();
            while (reader.Read())
            {
                userinfocheckgridview.Rows.Add(reader["User_Name"], reader["Contact_Number)"], reader["Address"]);

            }
            connection.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();
            string SearchData = search.Text;
            string Query = "Select * from UserInfo where User_Name Like '%" + SearchData + "%' OR User_Address Like '%" + SearchData + "%'";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            userinfocheckgridview.Rows.Clear();
            while (reader.Read())
            {
                userinfocheckgridview.Rows.Add(reader["User_Name"], reader["Contact_Number"], reader["User_Address"]);

            }
            connection.Close();
        }

        

        
    }
}
