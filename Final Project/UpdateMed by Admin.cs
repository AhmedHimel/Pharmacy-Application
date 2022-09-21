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
    public partial class upmed : Form
    {
        public upmed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = HIMEL\SQLEXPRESS; Initial Catalog = HealthCare_Service; Integrated Security = True");
            con.Open();

            string query = "update MedicineInfo set price = '" + price.Text + "' where MName='" + name.Text + "' ";

            SqlCommand insert = new SqlCommand(query, con);
            insert.ExecuteNonQuery();
            MessageBox.Show("Successfull Updated!");

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            medinfo mf = new medinfo();
            mf.ShowDialog();
        }
    }
}
