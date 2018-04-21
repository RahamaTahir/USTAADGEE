using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ustaad_G
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void cmdHome4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Home = new Form1();
            Home.Show();
        }

        private void lnkContactUs4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void lnkAbout4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void cmdRegister4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectRegister SelectR = new frmSelectRegister();
            SelectR.Show();
        }
    }
}
