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
    public partial class demandeurs : Form
    {
        public demandeurs()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=laptop-8u1lslt6\\sqlexpress01;Initial Catalog=frame;Integrated Security=True;TrustServerCertificate=True;");
        private void filterbloodtype()
        {
            try
            {
                Con.Open();
                String query = "select * from demandeurs where BloodType='" + bt2.SelectedItem.ToString() + "' ";

                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);

                // Vérifier si le DataSet est vide
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("0 institutions has requested this blood type ");
                }
                else
                {
                    demande.DataSource = ds.Tables[0];
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
                String query = "select * from demandeurs";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                demande.DataSource = ds.Tables[0];
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
        // Méthode pour vérifier si une chaîne est composée uniquement de lettres
        private bool IsString(string value)
        {
            // Vérifie si la valeur est vide ou null
            if (string.IsNullOrEmpty(value))
                return false;

            // Vérifie si chaque caractère de la chaîne est une lettre
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }
        private bool IsNumeric(string value)
        {
            // Essayez de convertir la chaîne en un nombre
            // Si réussi, retourne true; sinon, retourne false
            return double.TryParse(value, out _);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || bq.Text == "" || bt.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else if (!IsString(nom.Text) || !IsNumeric(bq.Text))
            {
                MessageBox.Show("The institution name must be a string of characters, and the blood quantity must be a measurable quantity (ml)");
            }
            else if (bt.SelectedItem == null)
            {
                MessageBox.Show("Please select a value for the blood group.");
            }
            else
            {
                try
                {
                    string connectionString = "Data Source=laptop-8u1lslt6\\sqlexpress01;Initial Catalog=frame;Integrated Security=True;TrustServerCertificate=True;";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "insert into demandeurs values (@institution, @BloodType, @BloodQuantity)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@institution", nom.Text);
                        cmd.Parameters.AddWithValue("@BloodType", bt.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@BloodQuantity", bq.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("request successfuly added");
                        con.Close();
                        nom.Text = "";
                        bt.Text = "";
                        bq.Text = "";
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nom.Text = "";
            bq.Text = "";
            bt.Text = "";
            
        }

        private void demandeurs_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filterbloodtype();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu ad = new menu();
            ad.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
