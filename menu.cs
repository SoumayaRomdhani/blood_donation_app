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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            menu3 ad = new menu3();
            ad.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            menu2 ad = new menu2();
            ad.Show();
            this.Hide();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Form3 ad = new Form3();
            ad.Show();
            this.Hide();
        }
    }
}
