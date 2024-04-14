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
    public partial class viewdonations : Form
    {
        public viewdonations()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=laptop-8u1lslt6\\sqlexpress01;Initial Catalog=frame;Integrated Security=True;TrustServerCertificate=True;");
        private void filterbycenter()
        {
            try
            {
                Con.Open();
                String query = "select * from stock where centre_collecte='" + nom.Text + "' ";

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);

                // Vérifier si le DataSet est vide
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("0 donations are done in this blood collection center");
                }
                else
                {
                    donations.DataSource = ds.Tables[0];
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
        private void filterbyname()
        {
            try
            {
                Con.Open();
                String query = "select * from stock where nom='" + name.Text + "' ";

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);

                // Vérifier si le DataSet est vide
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("0 donations are done in this blood collection center");
                }
                else
                {
                    donations.DataSource = ds.Tables[0];
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
                String query = "select * from stock where groupe_sanguin='" + bt.SelectedItem.ToString() + "' ";

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
                    donations.DataSource = ds.Tables[0];
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
                String query = "select * from stock";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                donations.DataSource = ds.Tables[0];
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

        private void viewdonations_Load(object sender, EventArgs e)
        {
            populate();
            ColorizeRows();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterbycenter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filterbloodtype();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void nom_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            filterbyname();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu ad = new menu();
            ad.Show();
            this.Hide();
        }
        private void ColorizeRows()
        {
            foreach (DataGridViewRow row in donations.Rows)
            {
                // Récupérer la date d'expiration de la cellule correspondante
                DateTime expirationDate = Convert.ToDateTime(row.Cells["date_expiration"].Value);

                // Calculer le nombre de jours restants jusqu'à la date d'expiration
                TimeSpan difference = expirationDate - DateTime.Today;
                int daysDifference = difference.Days;

                // Vérifier si le nombre de jours est supérieur à 10
                if (daysDifference > 10)
                {
                    // Colorer toute la ligne en rouge par exemple
                    row.DefaultCellStyle.BackColor = Color.Orchid;
                }
                else
                {
                    // Colorer toute la ligne en vert par exemple
                    row.DefaultCellStyle.BackColor = Color.Gold;
                }
            }
        }

        private void donations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
