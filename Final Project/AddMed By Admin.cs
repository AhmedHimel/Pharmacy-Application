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
    public partial class addmed : Form
    {
        public addmed()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (mid.Text != "" && medname.Text != "" && price.Text != "")
            {
                SqlConnection scon = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
                scon.Open();

                string query = "insert into MedicineInfo(Mid,MName,price) values ('" + mid.Text + "','" + medname.Text + "','" + price.Text + "')";
                SqlCommand insert = new SqlCommand(query, scon);
                insert.ExecuteNonQuery();
                MessageBox.Show("Medicine Addeed!");
                scon.Close();

            }
            else
            {

                MessageBox.Show("Please Fill up");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            medinfo mf = new medinfo();
            mf.ShowDialog();
        }
    }
}
