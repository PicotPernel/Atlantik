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
    public partial class FormAfficherTraverseePourLiaisonEtDate: Form
    {
        public FormAfficherTraverseePourLiaisonEtDate()
        {
            InitializeComponent();
        }
        public int GetQuantitéEnregistrée(string lettreCategorie, int noTraversee)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT SUM(QUANTITERESERVEE) from traversee INNER JOIN reservation ON traversee.NOTRAVERSEE = reservation.NOTRAVERSEE INNER JOIN enregistrer ON enregistrer.NORESERVATION = reservation.NORESERVATION WHERE LETTRECATEGORIE = @lettreCategorie AND traversee.NOTRAVERSEE = @noTraversee ORDER BY LETTRECATEGORIE";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);
                maCde.Parameters.AddWithValue("@noTraversee", noTraversee);
                return int.Parse(maCde.ExecuteScalar().ToString());
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Erreur " + exception.ToString());
                return -1;
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
        public int GetCapaciteMax(int noTraversee, int lettreCategorie)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT CAPACITEMAX FROM contenir INNER JOIN bateau ON bateau.NOBATEAU = contenir.NOBATEAU INNER JOIN traversee ON traversee.NOBATEAU = contenir.NOBATEAU WHERE LETTRECATEGORIE = @lettreCategorie AND NOTRAVERSEE = @noTraversee";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@lettreCategorie", lettreCategorie);
                maCde.Parameters.AddWithValue("@noTraversee", noTraversee);
                return int.Parse(maCde.ExecuteScalar().ToString());
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Erreur " + exception.ToString());
                return -1;
            }
            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close();
                }
            }
        }
        public List<Categorie> GetLesCategories()
        {
            List<Categorie> categories = null;
            int i = 0;
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
                    categories.Add(new Categorie(jeuEnr["LETTRECATEGORIE"].ToString(), jeuEnr["LIBELLE"].ToString()));
                }
                return categories;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Erreur " + exception.ToString());
                return null;
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
        public List<Traversee> GetLesTraverseesBateaux(int noLiaison, DateTime dateTraversee)
        {
            List<Traversee> traversees = null;
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT NOTRAVERSEE, DATEHEUREDEPART, NOM FROM traversee INNER JOIN bateau ON bateau.NOBATEAU = traversee.NOBATEAU where NOLIAISON = @noLiaison AND DATEHEUREDEPART = @dateTraversee";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noLiaison", noLiaison);
                maCde.Parameters.AddWithValue("@dateTraversee", dateTraversee);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    traversees.Add(new Traversee(int.Parse(jeuEnr["NOTRAVERSEE"].ToString()), dateTraversee, jeuEnr["NOM"].ToString()));
                }
                return traversees;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Erreur " + exception.ToString());
                return null;
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
        private void FormAfficherTraverseePourLiaisonEtDate_Load(object sender, EventArgs e)
        {
            lvTraversee.GridLines = true;
            lvTraversee.FullRowSelect = true;
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM secteur";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    lbxSecteurs.Items.Add(new Secteur(int.Parse(jeuEnr["nosecteur"].ToString()), jeuEnr["nom"].ToString()));
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
        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLiaison.Items.Clear();
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT noLiaison, PortDepart.nom as 'Port départ', PortArrive.nom as 'Port arrivée' from LIAISON INNER JOIN port as PortDepart on (PortDepart.noport = noport_depart) INNER JOIN port as PortArrive ON (PortArrive.noport = noport_arrivee) WHERE NOSECTEUR = @noSecteur";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noSecteur", ((Secteur)lbxSecteurs.SelectedItem).GetNoSecteur());
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbLiaison.Items.Add(new Liaison(jeuEnr.GetValue(1).ToString(), jeuEnr.GetValue(2).ToString(), int.Parse(jeuEnr.GetValue(0).ToString())));
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
        private void btnAfficherTraversee_Click(object sender, EventArgs e)
        {
            List<Categorie> lesCategories = GetLesCategories();
            List<Traversee> lesTraversee = GetLesTraverseesBateaux(((Liaison)cmbLiaison.SelectedItem).GetNoLiaison(), dateTraversee.Value);
            lvTraversee.Columns.Add("N°", 100);
            lvTraversee.Columns.Add("Heure", 100);
            lvTraversee.Columns.Add("Bateau", 100);
            foreach(Categorie categorie in lesCategories)
            {
                lvTraversee.Columns.Add(((Categorie)categorie).ToString(), 100);
            }
        }
        private void lvTraversee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
