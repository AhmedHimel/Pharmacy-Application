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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            uslogin us = new uslogin();
            us.ShowDialog();
        }

        private void register_Click(object sender, EventArgs e)
        {

            if (uid.Text != null && name.Text != null && number.Text != null && email.Text != null && address.Text != null && password.Text != null)
            {
                SqlConnection con = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
                con.Open();
                string query = "insert into UserInfo(id,User_Name,Contact_Number,User_Email,User_Address,User_Password) values ('" + uid.Text + "','" + name.Text + "','" + number.Text + "','" + email.Text + "','" + address.Text + "','" + password.Text + "')";
                SqlCommand insert = new SqlCommand(query, con);
                insert.ExecuteNonQuery();
                MessageBox.Show("Registation Successfully Done!");
                con.Close();

                this.Hide();
                uslogin ul = new uslogin();
                ul.ShowDialog();

            }
            else
            {

                MessageBox.Show("Please Fill up");
                return;
            }
        }
    }
}
