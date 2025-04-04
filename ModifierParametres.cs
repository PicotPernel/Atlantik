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
    public partial class FormModifierParametres: Form
    {
        int productionState = 0;
        public FormModifierParametres()
        {
            InitializeComponent();
        }
        private void FormModifierParametres_Load(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                int hauteur = 0;
                string requête;
                maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
                maCnx.Open();
                requête = "SELECT * " +
                    "FROM parametres";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                jeuEnr.Read();
                tbxSite.Text = jeuEnr["SITE_PB"].ToString();
                tbxRang.Text = jeuEnr["RANG_PB"].ToString();
                tbxId.Text = jeuEnr["IDENTIFIANT_PB"].ToString();
                tbxCleHMAC.Text = jeuEnr["CLEHMAC_PB"].ToString();
                tbxMel.Text = jeuEnr["MELSITE"].ToString();
                cbxEnProduction.Checked = bool.Parse(jeuEnr["ENPRODUCTION"].ToString());
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
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                if (cbxEnProduction.Checked)
                    productionState = 1;
                else
                    productionState = 0;
                    string requête;
                maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
                maCnx.Open();
                requête = "UPDATE parametres " +
                    "SET SITE_PB = @site, RANG_PB = @rang, IDENTIFIANT_PB = @Id, CLEHMAC_PB = @cleHMAC, ENPRODUCTION = @productionState, MELSITE = @melSite " +
                    "WHERE parametres.NOIDENTIFIANT = 1";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@site", tbxSite.Text);
                maCde.Parameters.AddWithValue("@rang", tbxRang.Text);
                maCde.Parameters.AddWithValue("@Id", tbxId.Text);
                maCde.Parameters.AddWithValue("@cleHMAC", tbxCleHMAC.Text);
                maCde.Parameters.AddWithValue("@productionState", productionState);
                maCde.Parameters.AddWithValue("@melSite", tbxMel.Text);
                maCde.ExecuteNonQuery();
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
