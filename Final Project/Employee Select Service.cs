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
    public partial class selectservice : Form
    {
        public selectservice()
        {
            InitializeComponent();
        }

        private void delivery_Click(object sender, EventArgs e)
        {
            this.Hide();
            dmlogin dm = new dmlogin();
            dm.ShowDialog();
        }

        private void doctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            dclogin dc = new dclogin();
            dc.ShowDialog();
        }
    }
}
