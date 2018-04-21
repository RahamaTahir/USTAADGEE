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
    public partial class frmNewPassword : Form
    {
        public frmNewPassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdHome10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Home = new Form1();
            Home.Show();
        }

        private void lnkLogin10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 Home = new Form1();
            Home.Show();
        }

        private void lnkContact10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void lnkAbout10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void cmdRegister10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectRegister SelectR = new frmSelectRegister();
            SelectR.Show();
        }

        private void cmdAdmin10_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin Admin = new frmAdmin();
            Admin.Show();
        }
    }
}
