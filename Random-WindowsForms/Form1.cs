using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_WindowsForms
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

        private void txtMinNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int min = Convert.ToInt32(txtMinNumber.Text);
            int max = Convert.ToInt32(txtMaxNumber.Text);
            lblDisplayResult.Text = Convert.ToString(rand.Next(min, max));
        }

        private void btnLinkFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");  // Enter your link Facebook
        }

        private void btnLinkGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/");  // Enter your link GitHub
        }

        private void btnLinkYoutube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/");  // Enter your link Youtube
        }
    }
}
