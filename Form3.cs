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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu ad = new menu();
            ad.Show();
            this.Hide();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            demandeurs ad = new demandeurs();
            ad.Show();
            this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            updatedeletedemande ad = new updatedeletedemande();
            ad.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            centre ad = new centre();
            ad.Show();
            this.Hide();
        }
    }
}
