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
    public partial class dclogin : Form
    {
        public dclogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration rg = new registration();
            rg.ShowDialog();
        }

        private void lgn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            con.Open();
            String Username = D_username.Text;
            String Password = D_password.Text;



            if (Username != "" && Password != "")
            {

                String query = "select * from Doctor where  Employee_Name ='" + Username + "'and Employee_Password = '" + Password + "'";
                SqlDataAdapter adaptar = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adaptar.Fill(table);



                if (table.Rows.Count > 0)
                {
                    int user_id = table.Rows[0].Field<int>("id");

                    DoctorInfo.DId = user_id;
                    DoctorInfo.DName = Username;
                    MessageBox.Show("Successfully Logged In");
                    this.Hide();
                    doctor d = new doctor();
                    d.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or Password!");
                }
                con.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            healthcare hc = new healthcare();
            hc.ShowDialog();
        }
    }
    static class DoctorInfo
    {
        public static int DId;
        public static string DName;
    }

}
