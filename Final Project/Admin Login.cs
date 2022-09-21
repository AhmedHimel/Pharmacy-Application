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
    public partial class adlogin : Form
    {
        public adlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            con.Open();
            String Username = adname.Text;
            String Password = adpass.Text;



            if (Username != "" && Password != "")
            {

                String query = "select * from Admin where  Admin_Name ='" + Username + "'and Admin_Password = '" + Password + "'";
                SqlDataAdapter adaptar = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adaptar.Fill(table);



                if (table.Rows.Count > 0)
                {
                    int user_id = table.Rows[0].Field<int>("id");

                    AdminInfo.adminId = user_id;
                    AdminInfo.adminName = Username;
                    MessageBox.Show("Successfully Logged In");
                    this.Hide();
                    admin ad = new admin();
                    ad.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or Password!");
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            healthcare hc = new healthcare();
            hc.ShowDialog();
        }
    }
    static class AdminInfo
    {
        public static int adminId;
        public static string adminName;



    }
}
