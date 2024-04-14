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
    public partial class updatedeletedemande : Form
    {
        public updatedeletedemande()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=laptop-8u1lslt6\\sqlexpress01;Initial Catalog=frame;Integrated Security=True;TrustServerCertificate=True;");
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
        int key = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || nom.Text == "" || bt.Text == "" || bq.Text == "")
            {
                MessageBox.Show("missing information");
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
                    Con.Open();
                    string query = "UPDATE demandeurs set institution='" + nom.Text + "',BloodType='" + bt.Text + "',BloodQuantity='" + bq.Text + "' where Id=@key";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member updated successfully");
                    Con.Close();
                    populate(); // Assuming populate() method repopulates the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void demande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is selected
            {

                DataGridViewRow row = this.demande.Rows[e.RowIndex];

                nom.Text = row.Cells["institution"].Value?.ToString() ?? "";
                bq.Text = row.Cells["BloodQuantity"].Value?.ToString() ?? "";

                // Populate gender ComboBox
                string bloodtype = row.Cells["BloodType"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(bloodtype))
                {
                    bt.SelectedItem = bloodtype; // Assuming gendercb already contains gender options
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
                MessageBox.Show("select the donator to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM demandeurs WHERE Id = @key;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("request deleted successfully");
                    Con.Close();
                    populate(); // Assuming populate() method repopulates the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updatedeletedemande_Load(object sender, EventArgs e)
        {
            populate();
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
