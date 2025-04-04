﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Atlantik
{
    public partial class FormAjouterSecteur: Form
    {
        public FormAjouterSecteur()
        {
            InitializeComponent();
        }
        private void buttonAjouterSecteur_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]{1,}.*$");
            var résultatTest = objetRegEx.Match(tbxSecteur.Text);
            if (!résultatTest.Success ^ tbxSecteur.Text is null)
            {
                tbxSecteur.BackColor = Color.Red;
            }
            else
            {
                try
                {
                    string requête;
                    maCnx.Open();
                    requête = "Insert INTO secteur (nom) " +
                        "VALUES (@nomSecteur)";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@nomSecteur", tbxSecteur.Text);
                    maCde.ExecuteNonQuery();
                    MessageBox.Show("Modification effectuée");
                    tbxSecteur.Text = null;
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
}
