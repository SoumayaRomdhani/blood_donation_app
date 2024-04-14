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
    public partial class don : Form
    {
        public don()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                try
                {
                    string connectionString = "Data Source=laptop-8u1lslt6\\sqlexpress01;Initial Catalog=frame;Integrated Security=True;TrustServerCertificate=True;";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Recherche du donneur dans la table des donneurs
                        string queryDonneur = "SELECT groupe_sanguin FROM donneurs WHERE nom = @nom AND prenom = @prenom";
                        SqlCommand cmdDonneur = new SqlCommand(queryDonneur, con);
                        cmdDonneur.Parameters.AddWithValue("@nom", nom.Text);
                        cmdDonneur.Parameters.AddWithValue("@prenom", prenom.Text);

                        string groupeSanguin = cmdDonneur.ExecuteScalar()?.ToString(); // Exécutez la commande et récupérez le groupe sanguin

                        if (string.IsNullOrEmpty(groupeSanguin))
                        {
                            MessageBox.Show("Donator not found .");
                            return;
                        }
                    // Vérification de la quantité de sang
                    int quantity = int.Parse(bq.Text);
                    if (quantity > 450)
                    {
                        MessageBox.Show("The quantity of blood cannot exceed 450 milliliters.");
                        return;
                    }
                    // Vérifier les antécédents médicaux du donneur
                    string queryAntecedents = "SELECT antecedentsMedicaux FROM donneurs WHERE nom = @nom AND prenom = @prenom";
                    SqlCommand cmdAntecedents = new SqlCommand(queryAntecedents, con);
                    cmdAntecedents.Parameters.AddWithValue("@nom", nom.Text);
                    cmdAntecedents.Parameters.AddWithValue("@prenom", prenom.Text);

                    string antecedentsMedicaux = cmdAntecedents.ExecuteScalar()?.ToString(); // Récupérer les antécédents médicaux

                    if (!antecedentsMedicaux.Equals("sain(e)"))
                    {
                        MessageBox.Show("The donator has medical history and cannot donate blood.");
                        return;
                    }

                    // Obtenir la date du dernier don de sang du donneur
                    string queryLastDonationDate = "SELECT MAX(date_don) FROM stock WHERE nom = @nom AND prenom = @prenom";
                    SqlCommand cmdLastDonationDate = new SqlCommand(queryLastDonationDate, con);
                    cmdLastDonationDate.Parameters.AddWithValue("@nom", nom.Text);
                    cmdLastDonationDate.Parameters.AddWithValue("@prenom", prenom.Text);

                    object lastDonationDateObj = cmdLastDonationDate.ExecuteScalar();
                    DateTime? lastDonationDate = lastDonationDateObj != DBNull.Value ? Convert.ToDateTime(lastDonationDateObj) : (DateTime?)null;

                    // Vérifier si le délai depuis le dernier don est supérieur à 56 jours
                    if (lastDonationDate.HasValue && (DateTime.Now - lastDonationDate.Value).TotalDays < 56)
                    {
                        MessageBox.Show("The donor must wait at least 56 days between blood donations.");
                        return;
                    }

                    // Insertion dans la table Stock avec le groupe sanguin récupéré
                    string queryStock = "INSERT INTO stock (nom, prenom, date_don, groupe_sanguin, centre_collecte, date_expiration, quantity) " +
                                            "VALUES (@nom, @prenom, @date_don, @groupe_sanguin, @centre_collecte, DATEADD(day, 42, @date_don), @quantity)";
                        SqlCommand cmdStock = new SqlCommand(queryStock, con);
                        cmdStock.Parameters.AddWithValue("@nom", nom.Text);
                        cmdStock.Parameters.AddWithValue("@prenom", prenom.Text);
                        cmdStock.Parameters.AddWithValue("@date_don", dd.Value.Date.ToString("yyyy-MM-dd"));
                        cmdStock.Parameters.AddWithValue("@groupe_sanguin", groupeSanguin);
                        cmdStock.Parameters.AddWithValue("@centre_collecte", bcc.Text);
                        cmdStock.Parameters.AddWithValue("@quantity", bq.Text);

                        cmdStock.ExecuteNonQuery();
                        MessageBox.Show("Donator's blood donation successfully added");
                        con.Close();
                        nom.Text = "";
                        prenom.Text = "";
                        dd.Text = "";
                        bcc.Text = "";
                        bq.Text = "";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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
