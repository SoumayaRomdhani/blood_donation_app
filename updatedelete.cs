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
    public partial class updatedelete : Form
    {
        public updatedelete()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=laptop-8u1lslt6\\sqlexpress01;Initial Catalog=frame;Integrated Security=True;TrustServerCertificate=True;");
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
        private void updatedelete_Load(object sender, EventArgs e)
        {
            populate();
        }
        
        private void donneurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }
        int key = 0;
        private void donneurs_CellContentClickdonneurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is selected
            {

                DataGridViewRow row = this.donneurs.Rows[e.RowIndex];

                nom.Text = row.Cells["nom"].Value?.ToString() ?? "";
                prenom.Text = row.Cells["prenom"].Value?.ToString() ?? "";
                adresse.Text = row.Cells["adresse"].Value?.ToString() ?? "";
                

                // Populate bloodtype ComboBox
                string bloodtype = row.Cells["groupe_sanguin"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(bloodtype))
                {
                    bt.SelectedItem = bloodtype; // Assuming bt already contains gender options
                }
                // Populate medical history ComboBox
                string medicalhistory = row.Cells["antecedentsMedicaux"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(medicalhistory))
                {
                    mh.SelectedItem = medicalhistory; // Assuming mh already contains gender options
                }
                //populate birthday datepicker
                string birthday = row.Cells["birthdayDate"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(birthday))
                {
                    // Convertir la chaîne de date en DateTime
                    DateTime birthdayDate;
                    if (DateTime.TryParse(birthday, out birthdayDate))
                    {
                        bd.Value = birthdayDate;
                    }
                    else
                    {
                        // Gérer le cas où la conversion échoue
                        MessageBox.Show("Invalid date format: " + birthday);
                    }
                }

                // Extracting key
                if (int.TryParse(row.Cells[0].Value.ToString(), out int extractedKey))
                {
                    key = extractedKey;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select the member to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM donneurs WHERE Id = @key;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member deleted successfully");
                    Con.Close();
                    populate(); // Assuming populate() method repopulates the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                    Con.Open();
                    string query = "UPDATE donneurs set nom='" + nom.Text + "',prenom='" + prenom.Text + "',birthdayDate='" + bd.Text + "',adresse='" + adresse.Text + "',groupe_sanguin='" + bt.Text + "',antecedentsMedicaux='" + mh.Text + "' where Id=@key";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("donator updated successfully");
                    Con.Close();
                    populate(); // Assuming populate() method repopulates the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
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
    }
}
