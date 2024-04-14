using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace frame
{
    public partial class centre : Form
    {
        public centre()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=laptop-8u1lslt6\\sqlexpress01;Initial Catalog=frame;Integrated Security=True;TrustServerCertificate=True;");
        private void filltable()
        {
            try
            {
                string connectionString = "Data Source=laptop-8u1lslt6\\sqlexpress01;Initial Catalog=frame;Integrated Security=True;TrustServerCertificate=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Supprimer d'abord toutes les lignes existantes dans la table "centre" pour éviter les doublons
                    string deleteQuery = "DELETE FROM centre";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, con);
                    deleteCommand.ExecuteNonQuery();

                    // Insérer les données agrégées dans la table "centre" à partir de la table "stock"
                    string insertQuery = @"
            INSERT INTO centre (center_name, [A+], [A-], [B+], [B-], [O+], [O-], [AB+], [AB-])
            SELECT 
                centre_collecte,
                SUM(CASE WHEN groupe_sanguin = 'A+' THEN quantity ELSE 0 END) AS [A+],
                SUM(CASE WHEN groupe_sanguin = 'A-' THEN quantity ELSE 0 END) AS [A-],
                SUM(CASE WHEN groupe_sanguin = 'B+' THEN quantity ELSE 0 END) AS [B+],
                SUM(CASE WHEN groupe_sanguin = 'B-' THEN quantity ELSE 0 END) AS [B-],
                SUM(CASE WHEN groupe_sanguin = 'O+' THEN quantity ELSE 0 END) AS [O+],
                SUM(CASE WHEN groupe_sanguin = 'O-' THEN quantity ELSE 0 END) AS [O-],
                SUM(CASE WHEN groupe_sanguin = 'AB+' THEN quantity ELSE 0 END) AS [AB+],
                SUM(CASE WHEN groupe_sanguin = 'AB-' THEN quantity ELSE 0 END) AS [AB-]
            FROM stock
            GROUP BY centre_collecte";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, con);
                    insertCommand.ExecuteNonQuery();

                    con.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void populate()
        {
            try
            {
                Con.Open();
                String query = "select * from centre";
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
        private void filterbycenter()
        {
            try
            {
                Con.Open();
                String query = "select * from centre where center_name='" + nom.Text + "' ";

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
                nom.Text = "";
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            filterbycenter();

        }

        private void centre_Load(object sender, EventArgs e)
        {
            filltable();
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

        private void donations_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Vérifier si la cellule actuelle a une valeur de zéro
            if (e.Value != null && e.Value.ToString() == "0")
            {
                // Modifier le style de la cellule pour la colorer en rouge par exemple
                donations.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
            }
        }
    }
}
