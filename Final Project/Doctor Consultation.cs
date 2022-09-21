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
    public partial class doctorconsultation : Form
    {
        public doctorconsultation()
        {
            InitializeComponent();
        }

        private void doctorconsultation_Load(object sender, EventArgs e)
        {

        }

        private void apply_Click(object sender, EventArgs e)
        {

            if (did.Text != "" && dnme.Text != "" && emal.Text != "" && lctn.Text != "" && cntime.Text != "")
            {
                SqlConnection scon = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
                scon.Open();

                string query = "insert into DoctorConsultation(Doctor_Id,Doctor_Name,Email,Location,Consultation_Time) values ('" + did.Text + "','" + dnme.Text + "','" + emal.Text+ "','" + lctn.Text + "','" + cntime.Text + "')";
                SqlCommand insert = new SqlCommand(query, scon);
                insert.ExecuteNonQuery();
                MessageBox.Show("Your Request Successfully Sent to Doctor for Consultation!");
                scon.Close();
               
            }
            else
            {
            
                MessageBox.Show("Please Fill up");
                return;
            }

        }


        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            userselect hc = new userselect();
            hc.ShowDialog();
        }

        private void leave_Click(object sender, EventArgs e)
        {
            this.Hide();
            end en = new end();
            en.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            connection.Open();

            string Id = did.Text;

            string Query = "select * from Doctor where id =" + Id;
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                did.Text = reader["id"].ToString();
                dnme.Text = reader["Employee_Name"].ToString();
                
            }
            else { MessageBox.Show("Sorry!Doctor not available with this ID."); }
            connection.Close();
        }
    }
}
