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
    public partial class adddonater : Form
    {
        public adddonater()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || adresse.Text == "" || mh.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else if (!IsString(nom.Text) || !IsString(prenom.Text) || !IsString(adresse.Text))
            {
                MessageBox.Show("Le nom, le prénom et l'adresse doivent être des chaînes de caractères.");
            }
            else if (bt.SelectedItem == null || mh.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une valeur pour le groupe sanguin et les antécédents médicaux.");
            }
            else 
            {
                try
                {
                    string connectionString = "Data Source=laptop-8u1lslt6\\sqlexpress01;Initial Catalog=frame;Integrated Security=True;TrustServerCertificate=True;";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "insert into donneurs values (@nom, @prenom, @birthdayDate, @adresse, @groupe_sanguin, @antecedentsMedicaux)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@nom", nom.Text);
                        cmd.Parameters.AddWithValue("@prenom", prenom.Text);
                        cmd.Parameters.AddWithValue("@birthdayDate", bd.Value.Date.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@adresse", adresse.Text);
                        cmd.Parameters.AddWithValue("@groupe_sanguin", bt.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@antecedentsMedicaux", mh.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("donator successfully added");
                        con.Close();
                        nom.Text = "";
                        prenom.Text = "";
                        bd.Text = "";
                        adresse.Text = "";
                        bt.Text = "";
                        mh.Text = "";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nom.Text = "";
            prenom.Text = "";
            bd.Text = "";
            adresse.Text = "";
            bt.Text = "";
            mh.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
