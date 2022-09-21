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
    public partial class ordermedicine : Form
    {
        
        public ordermedicine()
        {
            InitializeComponent();
        }

        private void ordermedicine_Load(object sender, EventArgs e)
        {

        }

        private void order_Click(object sender, EventArgs e)
        {

            if (medicineid.Text != "" && medicinename.Text != "" && price.Text != "" && qntity.Text != "" && address.Text != "")
            {
                int quantity = int.Parse(qntity.Text);
                float Price = float.Parse(price.Text);
                float Amount = Price * quantity;

                SqlConnection scon = new SqlConnection(@"Data Source=HIMEL\SQLEXPRESS;Initial Catalog=HealthCare_Service;Integrated Security=True");
                scon.Open();
                string query = "insert into OrderMedicine(M_Id,Medicine_Name,Price,Quantity,Amount,Address) values ('" + medicineid.Text + "','" + medicinename.Text + "','" + price.Text + "','" + qntity.Text + "','" + Amount + "','" + address.Text + "')";
                SqlCommand insert = new SqlCommand(query, scon);
                insert.ExecuteNonQuery();

                MessageBox.Show("Your Order Confirmed!");

                scon.Close();
                
            }

            else 
            {
                MessageBox.Show("Please Fill up");
                return;
            }


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

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

            string Id = medicineid.Text;

            string Query = "select * from MedicineInfo where Mid =" + Id;
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                medicineid.Text = reader["Mid"].ToString();
                medicinename.Text = reader["MName"].ToString();
                price.Text = reader["price"].ToString();
            }
            else { MessageBox.Show("Sorry!Don't have this medicine right Now."); }
            connection.Close();
        }
    }
}
