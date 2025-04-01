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
using Mysqlx.Prepare;
using static Mysqlx.Datatypes.Scalar.Types;

namespace Atlantik
{
    public partial class FormAjouterLiaison: Form
    {
        public FormAjouterLiaison()
        {
            InitializeComponent();
        }

        private void FormAjouterLiaison_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * " +
                    "FROM secteur";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    lbxSecteurs.Items.Add(new Secteur (int.Parse(jeuEnr["nosecteur"].ToString()), jeuEnr["nom"].ToString()));
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
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * " +
                    "FROM port";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbDepart.Items.Add(new Port(int.Parse(jeuEnr["noport"].ToString()), jeuEnr["nom"].ToString()));
                    cmbArrivee.Items.Add(new Port(int.Parse(jeuEnr["noport"].ToString()), jeuEnr["nom"].ToString()));
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
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "Insert INTO liaison (NOPORT_DEPART, NOSECTEUR, NOPORT_ARRIVEE, DISTANCE) " +
                    "VALUES (@noDepart, @noSecteur, @noArrivee, @distance)";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noDepart", (((Port)cmbDepart.SelectedItem).GetNoPort()));
                maCde.Parameters.AddWithValue("@noArrivee", (((Port)cmbArrivee.SelectedItem).GetNoPort()));
                maCde.Parameters.AddWithValue("@noSecteur", (((Secteur)lbxSecteurs.SelectedItem).GetNoSecteur()));
                maCde.Parameters.AddWithValue("@distance", double.Parse(tbxDistance.Text));
                MessageBox.Show("Lignes ajoutées : " + maCde.ExecuteNonQuery());
                cmbDepart.SelectedItem = null;
                cmbArrivee.SelectedItem = null;
                lbxSecteurs.SelectedItem = null;
                tbxDistance.Text = null;
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
