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
    public partial class frmResetPassword : Form
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void cmdHome9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Home = new Form1();
            Home.Show();
        }

        private void lnkLogin9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 Home = new Form1();
            Home.Show();
        }

        private void lnkContactUs9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void lnkAbout9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAboutUs About = new frmAboutUs();
            About.Show();
        }

        private void cmdRegister9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectRegister SelectR = new frmSelectRegister();
            SelectR.Show();
        }

        private void cmdAdmin9_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdmin Admin = new frmAdmin();
            Admin.Show();
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewPassword Np = new frmNewPassword();
            Np.Show();
        }
    }
}
