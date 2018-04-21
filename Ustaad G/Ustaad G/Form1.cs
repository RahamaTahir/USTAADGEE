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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void lnkContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void cmdAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin Admin = new frmAdmin();
            Admin.Show();
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Home = new Form1();
            Home.Show();

        }

        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectRegister SelectR = new frmSelectRegister();
           SelectR.Show();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearch Search = new frmSearch();
            Search.Show();
        }

        private void lnkResetPassowrd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            frmResetPassword Rp = new frmResetPassword();
            Rp.Show();
        }
    }
}
