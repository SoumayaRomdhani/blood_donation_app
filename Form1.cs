using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace frame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("missing informations");
            }
            else if (username.Text == "soumaya" && password.Text == "sou2003")
            {
                menu m = new menu();
                m.Show();
                this.Hide();
            }
            else { MessageBox.Show("wrong informations"); }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
