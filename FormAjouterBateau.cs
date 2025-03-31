using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Atlantik
{
    public partial class FormAjouterBateau: Form
    {
        public FormAjouterBateau()
        {
            InitializeComponent();
        }
        private void FormAjouterBateau_Load(object sender, EventArgs e)
        {
            int hauteur = 0;
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM categorie";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    hauteur += 1;
                    Label lblCapacite = new Label();
                    lblCapacite.Size = new Size(150, 20);
                    lblCapacite.Location = new Point(10, hauteur * 25); 
                    lblCapacite.Text = jeuEnr["LETTRECATEGORIE"].ToString() + " (" + jeuEnr["LIBELLE"].ToString() + ")" + " :";
                    TextBox tbxCapacite= new TextBox();
                    tbxCapacite.Location = new Point(180, hauteur * 25);
                    tbxCapacite.Tag = jeuEnr["LETTRECATEGORIE"];
                    gbxCapaciteMax.Controls.Add(lblCapacite);
                    gbxCapaciteMax.Controls.Add(tbxCapacite);
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Erreur " + exception.ToString());
            }
            finally
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close();
                }
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            long dernierNoBateau = 0;
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "INSERT INTO bateau (NOM) VALUES (@nomBateau)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@nomBateau", tbxNomBateau.Text);
                MessageBox.Show("Lignes affectées : " + maCde.ExecuteNonQuery());
                dernierNoBateau = maCde.LastInsertedId;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Erreur " + exception.ToString());
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
            foreach (Control element in gbxCapaciteMax.Controls)
            {
                if (element is TextBox)
                {
                    try
                    {
                        string requête;
                        maCnx.Open();
                        requête = "INSERT INTO contenir (LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) VALUES (@lettreCategorie, @noBateau, @capaciteMax)";
                        var maCde = new MySqlCommand(requête, maCnx);
                        maCde.Parameters.AddWithValue("@lettreCategorie", element.Tag);
                        maCde.Parameters.AddWithValue("@noBateau", dernierNoBateau);
                        maCde.Parameters.AddWithValue("@capaciteMax", element.Text);
                        MessageBox.Show("Modification effectuée");
                    }
                    catch (MySqlException exception)
                    {
                        MessageBox.Show("Erreur " + exception.ToString());
                    }
                    finally
                    {
                        if (maCnx is object & maCnx.State == ConnectionState.Open)
                        {
                            maCnx.Close();
                        }
                    }
                }
            }
            tbxNomBateau.Text = null;
            foreach (Control element in gbxCapaciteMax.Controls)
            {
                if ((element is TextBox))
                {
                    element.Text = null;
                }
            }
        }
        private void tbxNomBateau_TextChanged(object sender, EventArgs e)
        {

        }
        private void gbxCapaciteMax_Enter(object sender, EventArgs e)
        {

        }
    }
}
