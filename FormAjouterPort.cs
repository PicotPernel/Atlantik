﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Atlantik
{
    public partial class FormAjouterPort: Form
    {
        public FormAjouterPort()
        {
            InitializeComponent();
        }
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            MySqlConnection maCnx;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            var objetRegEx = new Regex("^[a-zA-Zéèêëçàâôù ûïî]{1,}.*$");
            var résultatTest = objetRegEx.Match(tbxPort.Text);
            if (!résultatTest.Success ^ tbxPort.Text == null)
            {
                tbxPort.BackColor = Color.Red;
            }
            else
            { 
                try
                {
                    string requête;
                    maCnx.Open();
                    requête = "Insert INTO port (nom) " +
                        "VALUES (@nomPort)";
                    var maCde = new MySqlCommand(requête, maCnx);
                    maCde.Parameters.AddWithValue("@nomPort", tbxPort.Text);
                    maCde.ExecuteNonQuery();
                    MessageBox.Show("Modification effectué");
                    tbxPort.Text = null;
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
