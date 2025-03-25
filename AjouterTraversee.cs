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
    public partial class FormAjouterTraversee: Form
    {
        public FormAjouterTraversee()
        {
            InitializeComponent();
        }
        private void AjouterTraversee_Load(object sender, EventArgs e)
        {
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
                    lbxSecteurs.Items.Add(new Secteur(int.Parse(jeuEnr["NOSECTEUR"].ToString()), jeuEnr["NOM"].ToString()));
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
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * FROM bateau";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbBateaux.Items.Add(new Bateau(int.Parse(jeuEnr["NOBATEAU"].ToString()), jeuEnr["NOM"].ToString()));
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
        private void lblNomBateau_Click(object sender, EventArgs e)
        {

        }

        private void cmbBateaux_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
