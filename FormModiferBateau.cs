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
    public partial class FormModiferBateau: Form
    {
        public FormModiferBateau()
        {
            InitializeComponent();
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * " +
                    "FROM Bateau";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbNomBateau.Items.Add(new Bateau(int.Parse(jeuEnr["NOBATEAU"].ToString()), jeuEnr["NOM"].ToString()));
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
        private void FormAjouterBateau_Load(object sender, EventArgs e)
        {
        }
        private void cmbNomBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hauteur = 0;
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT NOBATEAU, categorie.LETTRECATEGORIE, LIBELLE, CAPACITEMAX FROM categorie " +
                    "INNER JOIN contenir on (contenir.LETTRECATEGORIE = categorie.LETTRECATEGORIE) WHERE NOBATEAU = @noBateau";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noBateau", ((Bateau)cmbNomBateau.SelectedItem).GetNoBateau());
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    hauteur += 1;
                    Label lblCapacite = new Label();
                    lblCapacite.Size = new Size(150, 20);
                    lblCapacite.Location = new Point(10, hauteur * 25);
                    lblCapacite.Text = jeuEnr["LETTRECATEGORIE"].ToString() + " (" + jeuEnr["LIBELLE"].ToString() + ")" + " :";
                    TextBox tbxCapacite = tbxCapacite = new TextBox();
                    tbxCapacite.Location = new Point(180, hauteur * 25);
                    tbxCapacite.Tag = jeuEnr["LETTRECATEGORIE"].ToString();
                    tbxCapacite.Text = jeuEnr["CAPACITEMAX"].ToString();
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
        private void btnModifier_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            foreach (Control element in gbxCapaciteMax.Controls)
            {
                if (element is TextBox)
                {
                    try
                    {
                        string requête;
                        maCnx.Open();
                        requête = "UPDATE contenir " +
                            "SET CAPACITEMAX = @capacite " +
                            "WHERE contenir.LETTRECATEGORIE = @lettreCategorie AND contenir.NOBATEAU = @noBateau";
                        var maCde = new MySqlCommand(requête, maCnx);
                        maCde.Parameters.AddWithValue("@capacite", int.Parse(((TextBox)element).Text));
                        maCde.Parameters.AddWithValue("@lettreCategorie", ((TextBox)element).Tag);
                        maCde.Parameters.AddWithValue("@noBateau", ((Bateau)cmbNomBateau.SelectedItem).GetNoBateau());
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
        }
        private void gbxCapaciteMax_Enter(object sender, EventArgs e)
        {

        }
    }   
}
