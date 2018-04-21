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
    public partial class frmFilteredTutors : Form
    {
        public frmFilteredTutors()
        {
            InitializeComponent();
        }

        private void cmdHome6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Home = new Form1();
            Home.Show();
        }

        private void lnkLogin6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 Home = new Form1();
            Home.Show();
        }

        private void lnkContactUs6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void lnkAbout6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void cmdRegister6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectRegister SelectR = new frmSelectRegister();
            SelectR.Show();
        }

        private void cmdAdmin6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin Admin = new frmAdmin();
            Admin.Show();
        }

        private void cmdSearchL_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearch Search = new frmSearch();
            Search.Show();
        }
    }
}
