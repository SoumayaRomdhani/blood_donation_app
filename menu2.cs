using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frame
{
    public partial class menu2 : Form
    {
        public menu2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            adddonater ad = new adddonater();
            ad.Show();
            this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            viewdonators ad = new viewdonators();
            ad.Show();
            this.Hide();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            updatedelete ad = new updatedelete();
            ad.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu ad = new menu();
            ad.Show();
            this.Hide();
        }
    }
}
