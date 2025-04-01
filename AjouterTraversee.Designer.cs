namespace Atlantik
{
    partial class FormAjouterTraversee
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
            this.lblSecteurs = new System.Windows.Forms.Label();
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.cmbBateaux = new System.Windows.Forms.ComboBox();
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.lblLiaisons = new System.Windows.Forms.Label();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblDateHeureDepart = new System.Windows.Forms.Label();
            this.lblDateHeureArrivee = new System.Windows.Forms.Label();
            this.dateDepart = new System.Windows.Forms.DateTimePicker();
            this.dateArrivee = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(26, 35);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblSecteurs.TabIndex = 0;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(227, 35);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(71, 13);
            this.lblNomBateau.TabIndex = 1;
            this.lblNomBateau.Text = "Nom bateau :";
            // 
            // cmbBateaux
            // 
            this.cmbBateaux.FormattingEnabled = true;
            this.cmbBateaux.Location = new System.Drawing.Point(230, 63);
            this.cmbBateaux.Name = "cmbBateaux";
            this.cmbBateaux.Size = new System.Drawing.Size(177, 21);
            this.cmbBateaux.TabIndex = 2;
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(29, 62);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(177, 329);
            this.lbxSecteurs.TabIndex = 3;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // lblLiaisons
            // 
            this.lblLiaisons.AutoSize = true;
            this.lblLiaisons.Location = new System.Drawing.Point(227, 105);
            this.lblLiaisons.Name = "lblLiaisons";
            this.lblLiaisons.Size = new System.Drawing.Size(46, 13);
            this.lblLiaisons.TabIndex = 4;
            this.lblLiaisons.Text = "Liaison :";
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(230, 133);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(177, 21);
            this.cmbLiaison.TabIndex = 5;
            // 
            // lblDateHeureDepart
            // 
            this.lblDateHeureDepart.AutoSize = true;
            this.lblDateHeureDepart.Location = new System.Drawing.Point(227, 175);
            this.lblDateHeureDepart.Name = "lblDateHeureDepart";
            this.lblDateHeureDepart.Size = new System.Drawing.Size(111, 13);
            this.lblDateHeureDepart.TabIndex = 6;
            this.lblDateHeureDepart.Text = "Date et heure départ :";
            // 
            // lblDateHeureArrivee
            // 
            this.lblDateHeureArrivee.AutoSize = true;
            this.lblDateHeureArrivee.Location = new System.Drawing.Point(227, 241);
            this.lblDateHeureArrivee.Name = "lblDateHeureArrivee";
            this.lblDateHeureArrivee.Size = new System.Drawing.Size(113, 13);
            this.lblDateHeureArrivee.TabIndex = 7;
            this.lblDateHeureArrivee.Text = "Date et heure arrivée :";
            // 
            // dateDepart
            // 
            this.dateDepart.CustomFormat = "dd/MM/yyyy à hh:mm";
            this.dateDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDepart.Location = new System.Drawing.Point(230, 200);
            this.dateDepart.Name = "dateDepart";
            this.dateDepart.Size = new System.Drawing.Size(177, 20);
            this.dateDepart.TabIndex = 8;
            this.dateDepart.Value = new System.DateTime(2000, 1, 1, 1, 0, 0, 0);
            // 
            // dateArrivee
            // 
            this.dateArrivee.CustomFormat = "dd/MM/yyyy à hh:mm";
            this.dateArrivee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateArrivee.Location = new System.Drawing.Point(230, 257);
            this.dateArrivee.Name = "dateArrivee";
            this.dateArrivee.Size = new System.Drawing.Size(177, 20);
            this.dateArrivee.TabIndex = 9;
            this.dateArrivee.Value = new System.DateTime(2000, 1, 1, 1, 0, 0, 0);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(230, 367);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(177, 23);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjouterTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 436);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dateArrivee);
            this.Controls.Add(this.dateDepart);
            this.Controls.Add(this.lblDateHeureArrivee);
            this.Controls.Add(this.lblDateHeureDepart);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaisons);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.cmbBateaux);
            this.Controls.Add(this.lblNomBateau);
            this.Controls.Add(this.lblSecteurs);
            this.Name = "FormAjouterTraversee";
            this.Text = "Atlantik - Ajouter une traversée";
            this.Load += new System.EventHandler(this.AjouterTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteurs;
        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.ComboBox cmbBateaux;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.Label lblLiaisons;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblDateHeureDepart;
        private System.Windows.Forms.Label lblDateHeureArrivee;
        private System.Windows.Forms.DateTimePicker dateDepart;
        private System.Windows.Forms.DateTimePicker dateArrivee;
        private System.Windows.Forms.Button btnAjouter;
    }
}