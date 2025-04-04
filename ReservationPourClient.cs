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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Atlantik
{
    public partial class FormReservationPourClient : Form
    {
        public FormReservationPourClient()
        {
            InitializeComponent();
        }
        private void ReservationPourClient_Load(object sender, EventArgs e)
        {
            lvReservation.GridLines = true;
            lvReservation.FullRowSelect = true;
            lvReservation.View = View.Details;
            MySqlConnection maCnx;
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                string requête;
                maCnx.Open();
                requête = "SELECT * " +
                        "FROM CLIENT";
                var maCde = new MySqlCommand(requête, maCnx);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbNomPrenom.Items.Add(new Client(int.Parse(jeuEnr["NOCLIENT"].ToString()), jeuEnr["NOM"].ToString(), jeuEnr["PRENOM"].ToString()));
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
        private void cmbNomPrenom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] lesReservations = new string[4];
            lvReservation.Clear();
            lvReservation.Columns.Add("N° de réservation");
            lvReservation.Columns.Add("Liaison");
            lvReservation.Columns.Add("N° de traversée");
            lvReservation.Columns.Add("Date de départ");
            MySqlConnection maCnx, maCnx2;
            MySqlDataReader jeuEnr = null, jeuEnr2 = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            maCnx2 = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
            {
                ListViewItem unItem;
                string requête, requête2;
                maCnx.Open();
                requête = "SELECT * " +
                    "FROM reservation " +
                    "WHERE NOCLIENT = @noClient";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noClient", ((Client)cmbNomPrenom.SelectedItem).GetNoClient());
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    lesReservations[0] = jeuEnr["NORESERVATION"].ToString();
                    lesReservations[2] = jeuEnr["NOTRAVERSEE"].ToString();
                    lesReservations[3] = DateTime.Parse(jeuEnr["DATEHEURE"].ToString()).ToString("dd/MM/yyyy à HH:mm");
                    try
                    {
                        maCnx2.Open();
                        requête2 = "SELECT liaison.NOLIAISON, PortDepart.NOM AS 'Port départ', PortArrive.NOM AS 'Port arrivée', NOTRAVERSEE " +
                            "FROM LIAISON " +
                            "INNER JOIN port as PortDepart ON (PortDepart.NOPORT = noport_depart) " +
                            "INNER JOIN port as PortArrive ON (PortArrive.NOPORT = noport_arrivee) " +
                            "INNER JOIN traversee ON (traversee.NOLIAISON = liaison.NOLIAISON) " +
                            "WHERE NOTRAVERSEE = @noTraversee";
                        var maCde2 = new MySqlCommand(requête2, maCnx2);
                        maCde2.Parameters.AddWithValue("@noTraversee", lesReservations[2]);
                        jeuEnr2 = maCde2.ExecuteReader();
                        while (jeuEnr2.Read())
                        {
                            lesReservations[1] = (new Liaison(jeuEnr2.GetValue(1).ToString(), jeuEnr2.GetValue(2).ToString(), int.Parse(jeuEnr2.GetValue(0).ToString())).ToString());
                        }
                    }
                    catch (MySqlException exception)
                    {
                        MessageBox.Show("Erreur " + exception.ToString());
                    }
                    finally
                    {
                        if (jeuEnr2 is object & !jeuEnr.IsClosed)
                        {
                            jeuEnr2.Close();
                        }
                        if (maCnx2 is object & maCnx.State == ConnectionState.Open)
                        {
                            maCnx2.Close();
                        }

                    }
                    unItem = new ListViewItem(lesReservations);
                    unItem.Tag = jeuEnr["NORESERVATION"];
                    lvReservation.Items.Add(unItem);
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
                lvReservation.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void lvReservation_SelectedIndexChanged(object sender, EventArgs e)
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
                requête = "SELECT LIBELLE, QUANTITERESERVEE, MONTANTTOTAL " +
                    "FROM enregistrer INNER JOIN categorie ON categorie.LETTRECATEGORIE = enregistrer.LETTRECATEGORIE " +
                    "INNER JOIN reservation ON reservation.NORESERVATION = enregistrer.NORESERVATION " +
                    "WHERE reservation.NORESERVATION = @noReservation";
                var maCde = new MySqlCommand(requête, maCnx);
                maCde.Parameters.AddWithValue("@noReservation", lvReservation.SelectedItems[0].SubItems[0].Text);
                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    hauteur += 1;
                    Label lblLibelle = new Label();
                    lblLibelle.Size = new Size(150, 20);
                    lblLibelle.Text = jeuEnr["LIBELLE"].ToString();
                    lblLibelle.Location = new Point(10, hauteur * 25);
                    Label lblQuantite = new Label();
                    lblQuantite.Size = new Size(150, 20);
                    lblQuantite.Text = ":   " + jeuEnr["QUANTITERESERVEE"].ToString();
                    lblQuantite.Location = new Point(180, hauteur * 25);
                    gbxDetailsReservation.Controls.Add(lblLibelle);
                    gbxDetailsReservation.Controls.Add(lblQuantite);
                }
                hauteur += 1;
                Label lblMontant = new Label();
                lblMontant.Size = new Size(130, 20);
                lblMontant.Text = "Montant Total : " + jeuEnr["MONTANTTOTAL"].ToString();
                lblMontant.Location = new Point(100, hauteur * 25);
                gbxDetailsReservation.Controls.Add(lblMontant);
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
    }
}
