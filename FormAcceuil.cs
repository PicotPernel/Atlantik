using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lesTarifsPourUneLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lesTraversééesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
