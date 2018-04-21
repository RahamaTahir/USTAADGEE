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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void lnkAbout3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void lnkLogin3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 Home = new Form1();
            Home.Show();
        }

        private void cmdHome3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Home = new Form1();
            Home.Show();
        }

        private void lnkContactUs3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void cmdRegister3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectRegister SelectR = new frmSelectRegister();
            SelectR.Show();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFilteredTutors Filtered = new frmFilteredTutors();
            Filtered.Show();
        }

        private void cmdViewDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMyAccount MyAcc = new frmMyAccount();
            MyAcc.Show();
        }

        private void cmdAdmin3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin Admin = new frmAdmin();
            Admin.Show();
        }
    }
}
