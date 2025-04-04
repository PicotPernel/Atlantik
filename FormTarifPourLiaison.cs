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
using Mysqlx.Crud;

namespace Atlantik
{
    public partial class FormTarifPourLiaison : Form
    {
        public FormTarifPourLiaison()
        {
            InitializeComponent();
        }
        private void FormTarifPourLiaison_Load(object sender, EventArgs e)
        {
            int hauteur = 0;
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * " +
                    "FROM type";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    hauteur += 1;
                    Label lblTarif = new Label();
                    lblTarif.Size = new Size(150, 20);
                    lblTarif.Text = jeuEnr["LETTRECATEGORIE"].ToString() + jeuEnr["NOTYPE"].ToString() + " - " + jeuEnr["LIBELLE"].ToString() + " :";
                    lblTarif.Location = new Point(10, hauteur * 25);
                    TextBox tbxTarif = tbxTarif = new TextBox();
                    tbxTarif.Location = new Point(180, hauteur * 25);
                    tbxTarif.Tag = jeuEnr["LETTRECATEGORIE"].ToString() + ";" + jeuEnr["NOTYPE"].ToString();
                    gbxTarifs.Controls.Add(lblTarif);
                    gbxTarifs.Controls.Add(tbxTarif);
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
                requête = "SELECT * " +
                    "FROM secteur";
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
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * " +
                    "FROM periode";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbPeriodes.Items.Add(new Periode(int.Parse(jeuEnr["noperiode"].ToString()), DateTime.Parse(jeuEnr["datedebut"].ToString()), DateTime.Parse(jeuEnr["datefin"].ToString()))).ToString();
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
            cmbLiaisons.Items.Clear();
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT noLiaison, PortDepart.nom as 'Port départ', PortArrive.nom as 'Port arrivée' " +
                    "FROM LIAISON " +
                    "INNER JOIN port as PortDepart ON (PortDepart.noport = noport_depart) " +
                    "INNER JOIN port as PortArrive ON (PortArrive.noport = noport_arrivee) " +
                    "WHERE NOSECTEUR = @noSecteur";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noSecteur", ((Secteur)lbxSecteurs.SelectedItem).GetNoSecteur());
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbLiaisons.Items.Add(new Liaison(jeuEnr.GetValue(1).ToString(), jeuEnr.GetValue(2).ToString(), int.Parse(jeuEnr.GetValue(0).ToString())));
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
            foreach (Control element in gbxTarifs.Controls)
                {
                if (element is TextBox)
                {
                    string[] tags = (((TextBox)element).Tag).ToString().Split(';');
                    MySqlConnection maCnx;
                    maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
                    try
                    {
                        string requête;
                        maCnx.Open();
                        requête = "INSERT INTO tarifer " +
                            "VALUES (@noPeriode, @lettreCategorie, @noType, @noLiaison, @tarif)";
                        var maCde = new MySqlCommand(requête, maCnx);
                        maCde.Parameters.AddWithValue("@noPeriode", ((Periode)cmbPeriodes.SelectedItem).GetNoPeriode());
                        maCde.Parameters.AddWithValue("@lettreCategorie", tags[0]);
                        maCde.Parameters.AddWithValue("@noType", tags[1]);
                        maCde.Parameters.AddWithValue("@noLiaison", ((Liaison)cmbLiaisons.SelectedItem).GetNoLiaison());
                        maCde.Parameters.AddWithValue("@tarif", double.Parse(element.Text));
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
            cmbPeriodes.SelectedItem = null;
            cmbLiaisons.SelectedItem = null;
            lbxSecteurs.SelectedItem = null;
            foreach (Control element in gbxTarifs.Controls)
            {
                if (element is TextBox)
                {
                    ((TextBox)element).Text = null;
                }
            }
        }
    }
}

