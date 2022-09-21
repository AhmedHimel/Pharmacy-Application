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
    public partial class dmlogin : Form
    {
        public dmlogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            con.Open();
            String Username = D_usname.Text;
            String Password = D_Pass.Text;



            if (Username != "" && Password != "")
            {

                String query = "select * from DeliverMan where  D_Name ='" + Username + "'and D_Password = '" + Password + "'";
                SqlDataAdapter adaptar = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adaptar.Fill(table);



                if (table.Rows.Count > 0)
                {
                    int user_id = table.Rows[0].Field<int>("id");

                    DeliveryManInfo.DMId = user_id;
                    DeliveryManInfo.DMName = Username;
                    MessageBox.Show("Successfully Logged In");
                    this.Hide();
                    deliveryman dm = new deliveryman();
                    dm.ShowDialog();
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
    static class DeliveryManInfo
    {
        public static int DMId;
        public static string DMName;
    }
}
