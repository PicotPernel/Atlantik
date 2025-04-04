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
            this.mmAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.miUnSecteurAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.miUnPortAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.miUneLiaisonAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.miTarifsLiaisonsAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.miUnBateauAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.miUneTraverseeAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.mmModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.miBateauModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.miParametresModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAficher = new System.Windows.Forms.ToolStripMenuItem();
            this.miTraverseeAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetailsReservationsAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAtlantik = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmAjouter,
            this.mmModifier,
            this.mmAficher,
            this.mmAPropos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mmAjouter
            // 
            this.mmAjouter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUnSecteurAjouter,
            this.miUnPortAjouter,
            this.miUneLiaisonAjouter,
            this.miTarifsLiaisonsAjouter,
            this.miUnBateauAjouter,
            this.miUneTraverseeAjouter});
            this.mmAjouter.Name = "mmAjouter";
            this.mmAjouter.Size = new System.Drawing.Size(58, 20);
            this.mmAjouter.Text = "Ajouter";
            // 
            // miUnSecteurAjouter
            // 
            this.miUnSecteurAjouter.Name = "miUnSecteurAjouter";
            this.miUnSecteurAjouter.Size = new System.Drawing.Size(287, 22);
            this.miUnSecteurAjouter.Text = "Un secteur";
            this.miUnSecteurAjouter.Click += new System.EventHandler(this.unSecteurToolStripMenuItem_Click);
            // 
            // miUnPortAjouter
            // 
            this.miUnPortAjouter.Name = "miUnPortAjouter";
            this.miUnPortAjouter.Size = new System.Drawing.Size(287, 22);
            this.miUnPortAjouter.Text = "Un port";
            this.miUnPortAjouter.Click += new System.EventHandler(this.mi_unPortAjouter_Click);
            // 
            // miUneLiaisonAjouter
            // 
            this.miUneLiaisonAjouter.Name = "miUneLiaisonAjouter";
            this.miUneLiaisonAjouter.Size = new System.Drawing.Size(287, 22);
            this.miUneLiaisonAjouter.Text = "Une liaison";
            this.miUneLiaisonAjouter.Click += new System.EventHandler(this.miUneLiaisonAjouter_Click);
            // 
            // miTarifsLiaisonsAjouter
            // 
            this.miTarifsLiaisonsAjouter.Name = "miTarifsLiaisonsAjouter";
            this.miTarifsLiaisonsAjouter.Size = new System.Drawing.Size(287, 22);
            this.miTarifsLiaisonsAjouter.Text = "Les tarifs pour une liaison et une période";
            this.miTarifsLiaisonsAjouter.Click += new System.EventHandler(this.lesTarifsPourUneLToolStripMenuItem_Click);
            // 
            // miUnBateauAjouter
            // 
            this.miUnBateauAjouter.Name = "miUnBateauAjouter";
            this.miUnBateauAjouter.Size = new System.Drawing.Size(287, 22);
            this.miUnBateauAjouter.Text = "Un bateau";
            this.miUnBateauAjouter.Click += new System.EventHandler(this.miUnBateauAjouter_Click);
            // 
            // miUneTraverseeAjouter
            // 
            this.miUneTraverseeAjouter.Name = "miUneTraverseeAjouter";
            this.miUneTraverseeAjouter.Size = new System.Drawing.Size(287, 22);
            this.miUneTraverseeAjouter.Text = "Une traversée";
            this.miUneTraverseeAjouter.Click += new System.EventHandler(this.miUneTraverseeAjouter_Click);
            // 
            // mmModifier
            // 
            this.mmModifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBateauModifier,
            this.miParametresModifier});
            this.mmModifier.Name = "mmModifier";
            this.mmModifier.Size = new System.Drawing.Size(64, 20);
            this.mmModifier.Text = "Modifier";
            // 
            // miBateauModifier
            // 
            this.miBateauModifier.Name = "miBateauModifier";
            this.miBateauModifier.Size = new System.Drawing.Size(191, 22);
            this.miBateauModifier.Text = "Un bateau";
            this.miBateauModifier.Click += new System.EventHandler(this.miBateauModifier_Click);
            // 
            // miParametresModifier
            // 
            this.miParametresModifier.Name = "miParametresModifier";
            this.miParametresModifier.Size = new System.Drawing.Size(191, 22);
            this.miParametresModifier.Text = "Les paramètres du site";
            this.miParametresModifier.Click += new System.EventHandler(this.miParametresModifier_Click);
            // 
            // mmAficher
            // 
            this.mmAficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTraverseeAfficher,
            this.miDetailsReservationsAfficher});
            this.mmAficher.Name = "mmAficher";
            this.mmAficher.Size = new System.Drawing.Size(61, 20);
            this.mmAficher.Text = "Afficher";
            // 
            // miTraverseeAfficher
            // 
            this.miTraverseeAfficher.Name = "miTraverseeAfficher";
            this.miTraverseeAfficher.Size = new System.Drawing.Size(529, 22);
            this.miTraverseeAfficher.Text = "Les traversées pour une liaison et une date donnée avec places restantes par caté" +
    "gories";
            this.miTraverseeAfficher.Click += new System.EventHandler(this.lesTraversééesToolStripMenuItem_Click);
            // 
            // miDetailsReservationsAfficher
            // 
            this.miDetailsReservationsAfficher.Name = "miDetailsReservationsAfficher";
            this.miDetailsReservationsAfficher.Size = new System.Drawing.Size(529, 22);
            this.miDetailsReservationsAfficher.Text = "Les détails d\'une reservation pour un client";
            this.miDetailsReservationsAfficher.Click += new System.EventHandler(this.miDetailsReservationsAfficher_Click);
            // 
            // mmAPropos
            // 
            this.mmAPropos.Name = "mmAPropos";
            this.mmAPropos.Size = new System.Drawing.Size(67, 20);
            this.mmAPropos.Text = "À Propos";
            // 
            // lblAtlantik
            // 
            this.lblAtlantik.AutoSize = true;
            this.lblAtlantik.BackColor = System.Drawing.Color.Transparent;
            this.lblAtlantik.Font = new System.Drawing.Font("Mistral", 60F);
            this.lblAtlantik.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAtlantik.Location = new System.Drawing.Point(136, 45);
            this.lblAtlantik.Name = "lblAtlantik";
            this.lblAtlantik.Size = new System.Drawing.Size(259, 95);
            this.lblAtlantik.TabIndex = 1;
            this.lblAtlantik.Text = "Atlantik";
            this.lblAtlantik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atlantik.Properties.Resources.Bateau;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 296);
            this.Controls.Add(this.lblAtlantik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAccueil";
            this.Text = "Atlantik - Accueil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mmAjouter;
        private System.Windows.Forms.ToolStripMenuItem miUnSecteurAjouter;
        private System.Windows.Forms.ToolStripMenuItem miUnPortAjouter;
        private System.Windows.Forms.ToolStripMenuItem miUneLiaisonAjouter;
        private System.Windows.Forms.ToolStripMenuItem miTarifsLiaisonsAjouter;
        private System.Windows.Forms.ToolStripMenuItem miUnBateauAjouter;
        private System.Windows.Forms.ToolStripMenuItem miUneTraverseeAjouter;
        private System.Windows.Forms.ToolStripMenuItem mmModifier;
        private System.Windows.Forms.ToolStripMenuItem miBateauModifier;
        private System.Windows.Forms.ToolStripMenuItem miParametresModifier;
        private System.Windows.Forms.ToolStripMenuItem mmAficher;
        private System.Windows.Forms.ToolStripMenuItem miTraverseeAfficher;
        private System.Windows.Forms.ToolStripMenuItem mmAPropos;
        private System.Windows.Forms.ToolStripMenuItem miDetailsReservationsAfficher;
        private System.Windows.Forms.Label lblAtlantik;
    }
}

