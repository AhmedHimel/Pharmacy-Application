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
    public partial class uslogin : Form
    {
        public uslogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registration rg = new registration();
            rg.ShowDialog();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
            con.Open();
            String Username = username.Text;
            String Password = password.Text;



            if (Username != "" && Password != "")
            {

                String query = "select * from UserInfo where  User_Name ='" + Username + "'and User_Password = '" + Password + "'";
                SqlDataAdapter adaptar = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adaptar.Fill(table);



                if (table.Rows.Count > 0)
                {
                    int user_id = table.Rows[0].Field<int>("id");

                    UserInfo.UId = user_id;
                    UserInfo.UName = Username;
                    MessageBox.Show("Successfully Logged In");
                    this.Hide();
                    userselect us = new userselect();
                    us.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or Password!");
                }
                con.Close();
            }
        }
    }
    static class UserInfo
    {
        public static int UId;
        public static string UName;
    }
}
