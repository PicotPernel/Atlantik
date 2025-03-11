namespace Atlantik
{
    partial class FormAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mm_ajouter = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_unSecteurAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_unPortAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_uneLiaisonAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_tarifsLiaisonsAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_unBateauAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_uneTraverseeAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_modifier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_bateauModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_parametresModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_afficher = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_traverseeAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_detailsReservationsAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_APropos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mm_ajouter,
            this.mm_modifier,
            this.mm_afficher,
            this.mm_APropos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mm_ajouter
            // 
            this.mm_ajouter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_unSecteurAjouter,
            this.mi_unPortAjouter,
            this.mi_uneLiaisonAjouter,
            this.mi_tarifsLiaisonsAjouter,
            this.mi_unBateauAjouter,
            this.mi_uneTraverseeAjouter});
            this.mm_ajouter.Name = "mm_ajouter";
            this.mm_ajouter.Size = new System.Drawing.Size(58, 20);
            this.mm_ajouter.Text = "Ajouter";
            this.mm_ajouter.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // mi_unSecteurAjouter
            // 
            this.mi_unSecteurAjouter.Name = "mi_unSecteurAjouter";
            this.mi_unSecteurAjouter.Size = new System.Drawing.Size(287, 22);
            this.mi_unSecteurAjouter.Text = "Un secteur";
            this.mi_unSecteurAjouter.Click += new System.EventHandler(this.unSecteurToolStripMenuItem_Click);
            // 
            // mi_unPortAjouter
            // 
            this.mi_unPortAjouter.Name = "mi_unPortAjouter";
            this.mi_unPortAjouter.Size = new System.Drawing.Size(287, 22);
            this.mi_unPortAjouter.Text = "Un port";
            this.mi_unPortAjouter.Click += new System.EventHandler(this.mi_unPortAjouter_Click);
            // 
            // mi_uneLiaisonAjouter
            // 
            this.mi_uneLiaisonAjouter.Name = "mi_uneLiaisonAjouter";
            this.mi_uneLiaisonAjouter.Size = new System.Drawing.Size(287, 22);
            this.mi_uneLiaisonAjouter.Text = "Une liaison";
            // 
            // mi_tarifsLiaisonsAjouter
            // 
            this.mi_tarifsLiaisonsAjouter.Name = "mi_tarifsLiaisonsAjouter";
            this.mi_tarifsLiaisonsAjouter.Size = new System.Drawing.Size(287, 22);
            this.mi_tarifsLiaisonsAjouter.Text = "Les tarifs pour une liaison et une période";
            this.mi_tarifsLiaisonsAjouter.Click += new System.EventHandler(this.lesTarifsPourUneLToolStripMenuItem_Click);
            // 
            // mi_unBateauAjouter
            // 
            this.mi_unBateauAjouter.Name = "mi_unBateauAjouter";
            this.mi_unBateauAjouter.Size = new System.Drawing.Size(287, 22);
            this.mi_unBateauAjouter.Text = "Un bateau";
            // 
            // mi_uneTraverseeAjouter
            // 
            this.mi_uneTraverseeAjouter.Name = "mi_uneTraverseeAjouter";
            this.mi_uneTraverseeAjouter.Size = new System.Drawing.Size(287, 22);
            this.mi_uneTraverseeAjouter.Text = "Une traversée";
            // 
            // mm_modifier
            // 
            this.mm_modifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_bateauModifier,
            this.mi_parametresModifier});
            this.mm_modifier.Name = "mm_modifier";
            this.mm_modifier.Size = new System.Drawing.Size(64, 20);
            this.mm_modifier.Text = "Modifier";
            // 
            // mi_bateauModifier
            // 
            this.mi_bateauModifier.Name = "mi_bateauModifier";
            this.mi_bateauModifier.Size = new System.Drawing.Size(191, 22);
            this.mi_bateauModifier.Text = "Un bateau";
            // 
            // mi_parametresModifier
            // 
            this.mi_parametresModifier.Name = "mi_parametresModifier";
            this.mi_parametresModifier.Size = new System.Drawing.Size(191, 22);
            this.mi_parametresModifier.Text = "Les paramètres du site";
            // 
            // mm_afficher
            // 
            this.mm_afficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_traverseeAfficher,
            this.mi_detailsReservationsAfficher});
            this.mm_afficher.Name = "mm_afficher";
            this.mm_afficher.Size = new System.Drawing.Size(61, 20);
            this.mm_afficher.Text = "Afficher";
            // 
            // mi_traverseeAfficher
            // 
            this.mi_traverseeAfficher.Name = "mi_traverseeAfficher";
            this.mi_traverseeAfficher.Size = new System.Drawing.Size(529, 22);
            this.mi_traverseeAfficher.Text = "Les traversées pour une liaison et une date donnée avec places restantes par caté" +
    "gories";
            this.mi_traverseeAfficher.Click += new System.EventHandler(this.lesTraversééesToolStripMenuItem_Click);
            // 
            // mi_detailsReservationsAfficher
            // 
            this.mi_detailsReservationsAfficher.Name = "mi_detailsReservationsAfficher";
            this.mi_detailsReservationsAfficher.Size = new System.Drawing.Size(529, 22);
            this.mi_detailsReservationsAfficher.Text = "Les détails d\'une reservation pour un client";
            // 
            // mm_APropos
            // 
            this.mm_APropos.Name = "mm_APropos";
            this.mm_APropos.Size = new System.Drawing.Size(67, 20);
            this.mm_APropos.Text = "À Propos";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 296);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAccueil";
            this.Text = "Atlantik - Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mm_ajouter;
        private System.Windows.Forms.ToolStripMenuItem mi_unSecteurAjouter;
        private System.Windows.Forms.ToolStripMenuItem mi_unPortAjouter;
        private System.Windows.Forms.ToolStripMenuItem mi_uneLiaisonAjouter;
        private System.Windows.Forms.ToolStripMenuItem mi_tarifsLiaisonsAjouter;
        private System.Windows.Forms.ToolStripMenuItem mi_unBateauAjouter;
        private System.Windows.Forms.ToolStripMenuItem mi_uneTraverseeAjouter;
        private System.Windows.Forms.ToolStripMenuItem mm_modifier;
        private System.Windows.Forms.ToolStripMenuItem mi_bateauModifier;
        private System.Windows.Forms.ToolStripMenuItem mi_parametresModifier;
        private System.Windows.Forms.ToolStripMenuItem mm_afficher;
        private System.Windows.Forms.ToolStripMenuItem mi_traverseeAfficher;
        private System.Windows.Forms.ToolStripMenuItem mm_APropos;
        private System.Windows.Forms.ToolStripMenuItem mi_detailsReservationsAfficher;
    }
}

