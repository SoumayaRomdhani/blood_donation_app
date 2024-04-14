using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frame
{
    public partial class viewdonators : Form
    {
        public viewdonators()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=laptop-8u1lslt6\\sqlexpress01;Initial Catalog=frame;Integrated Security=True;TrustServerCertificate=True;");
        private void filterbyname()
        {
            try
            {
                Con.Open();
                String query = "select * from donneurs where nom='" + nom.Text + "' ";

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);

                // Vérifier si le DataSet est vide
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Ce nom n'existe pas.");
                }
                else
                {
                    donneurs.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void filterbloodtype()
        {
            try
            {
                Con.Open();
                String query = "select * from donneurs where groupe_sanguin='" + bt.SelectedItem.ToString() + "' ";

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);

                // Vérifier si le DataSet est vide
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("no one has this blood type ");
                }
                else
                {
                    donneurs.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void populate()
        {
            try
            {
                Con.Open();
                String query = "select * from donneurs";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                donneurs.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void viewdonators_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterbyname();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filterbloodtype();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu ad = new menu();
            ad.Show();
            this.Hide();
        }
    }
}
