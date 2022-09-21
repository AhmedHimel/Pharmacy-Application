using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class userselect : Form
    {
        
        public userselect()
        {
            InitializeComponent();
           
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ordermedicine_Click(object sender, EventArgs e)
        {
            this.Hide();
            ordermedicine om = new ordermedicine();
            om.ShowDialog();
            
        }

        private void emergencycall_Click(object sender, EventArgs e)
        {
            this.Hide();
            emergencycall om = new emergencycall();
            om.ShowDialog();
        }
            

        private void doctorconsulation_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorconsultation dc = new doctorconsultation();
            dc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            healthcare hc = new healthcare();
            hc.ShowDialog();
        }
    }
}
