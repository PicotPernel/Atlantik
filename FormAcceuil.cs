﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik
{
    public partial class FormAccueil: Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }
        private void unSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterSecteur formAjouterSecteur = new FormAjouterSecteur();
            formAjouterSecteur.Show();
        }

        private void mi_unPortAjouter_Click(object sender, EventArgs e)
        {
            FormAjouterPort formAjouterPort = new FormAjouterPort();
            formAjouterPort.Show();
        }

        private void miUneLiaisonAjouter_Click(object sender, EventArgs e)
        {
            FormAjouterLiaison formAjouterLiaison = new FormAjouterLiaison();
            formAjouterLiaison.Show();

        }
        private void lesTarifsPourUneLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTarifPourLiaison formTarifPourLiaison = new FormTarifPourLiaison();
            formTarifPourLiaison.Show();
        }
        private void miUnBateauAjouter_Click(object sender, EventArgs e)
        {
            FormAjouterBateau formAjouterBateau = new FormAjouterBateau();
            formAjouterBateau.Show();
        }
        private void miUneTraverseeAjouter_Click(object sender, EventArgs e)
        {
            FormAjouterTraversee formAjouterTraversee = new FormAjouterTraversee();
            formAjouterTraversee.Show();
        }
        private void miBateauModifier_Click(object sender, EventArgs e)
        {
            FormModiferBateau formModiferBateau = new FormModiferBateau();
            formModiferBateau.Show();
        }
        private void lesTraversééesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAfficherTraverseePourLiaisonEtDate lesTraverseePourUneDate = new FormAfficherTraverseePourLiaisonEtDate();
            lesTraverseePourUneDate.Show();
        }

        private void miDetailsReservationsAfficher_Click(object sender, EventArgs e)
        {
            FormReservationPourClient formReservationPourClient = new FormReservationPourClient();
            formReservationPourClient.Show();
        }

        private void miParametresModifier_Click(object sender, EventArgs e)
        {
            FormModifierParametres formModifierParametres = new FormModifierParametres();
            formModifierParametres.Show();
        }
    }
}
