namespace Atlantik
{
    partial class FormTarifPourLiaison
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxTarifs = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cmbLiaisons = new System.Windows.Forms.ComboBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lblPeriodes = new System.Windows.Forms.Label();
            this.cmbPeriodes = new System.Windows.Forms.ComboBox();
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.lblSecteurs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gbxTarifs
            // 
            this.gbxTarifs.Location = new System.Drawing.Point(412, 43);
            this.gbxTarifs.Name = "gbxTarifs";
            this.gbxTarifs.Size = new System.Drawing.Size(378, 572);
            this.gbxTarifs.TabIndex = 0;
            this.gbxTarifs.TabStop = false;
            this.gbxTarifs.Text = "Tarifs par Catégorie - Type";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(213, 712);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(387, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cmbLiaisons
            // 
            this.cmbLiaisons.FormattingEnabled = true;
            this.cmbLiaisons.Location = new System.Drawing.Point(38, 504);
            this.cmbLiaisons.Name = "cmbLiaisons";
            this.cmbLiaisons.Size = new System.Drawing.Size(317, 21);
            this.cmbLiaisons.TabIndex = 2;
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(35, 488);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(51, 13);
            this.lblLiaison.TabIndex = 3;
            this.lblLiaison.Text = "Liaisons :";
            // 
            // lblPeriodes
            // 
            this.lblPeriodes.AutoSize = true;
            this.lblPeriodes.Location = new System.Drawing.Point(35, 578);
            this.lblPeriodes.Name = "lblPeriodes";
            this.lblPeriodes.Size = new System.Drawing.Size(54, 13);
            this.lblPeriodes.TabIndex = 4;
            this.lblPeriodes.Text = "Périodes :";
            // 
            // cmbPeriodes
            // 
            this.cmbPeriodes.FormattingEnabled = true;
            this.cmbPeriodes.Location = new System.Drawing.Point(38, 594);
            this.cmbPeriodes.Name = "cmbPeriodes";
            this.cmbPeriodes.Size = new System.Drawing.Size(317, 21);
            this.cmbPeriodes.TabIndex = 5;
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(38, 59);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(317, 368);
            this.lbxSecteurs.TabIndex = 6;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(35, 43);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblSecteurs.TabIndex = 7;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // FormTarifPourLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 821);
            this.Controls.Add(this.lblSecteurs);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.cmbPeriodes);
            this.Controls.Add(this.lblPeriodes);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.cmbLiaisons);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.gbxTarifs);
            this.Name = "FormTarifPourLiaison";
            this.Text = "Atlantik - Ajouter Un tarif pour une liaison";
            this.Load += new System.EventHandler(this.FormTarifPourLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTarifs;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cmbLiaisons;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.Label lblPeriodes;
        private System.Windows.Forms.ComboBox cmbPeriodes;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.Label lblSecteurs;
    }
}