namespace Atlantik
{
    partial class FormAfficherTraverseePourLiaisonEtDate
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
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.lvTraversee = new System.Windows.Forms.ListView();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTraversee = new System.Windows.Forms.DateTimePicker();
            this.btnAfficherTraversee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(12, 20);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblSecteurs.TabIndex = 0;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(183, 21);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 1;
            this.lblLiaison.Text = "Liaison :";
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(12, 36);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(165, 615);
            this.lbxSecteurs.TabIndex = 2;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // lvTraversee
            // 
            this.lvTraversee.HideSelection = false;
            this.lvTraversee.Location = new System.Drawing.Point(183, 62);
            this.lvTraversee.Name = "lvTraversee";
            this.lvTraversee.Size = new System.Drawing.Size(936, 589);
            this.lvTraversee.TabIndex = 3;
            this.lvTraversee.UseCompatibleStateImageBehavior = false;
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(183, 36);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(216, 21);
            this.cmbLiaison.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(421, 21);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(129, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date (Par défaut du jour) :";
            // 
            // dateTraversee
            // 
            this.dateTraversee.CustomFormat = "dd/MM/yyyy";
            this.dateTraversee.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTraversee.Location = new System.Drawing.Point(424, 37);
            this.dateTraversee.Name = "dateTraversee";
            this.dateTraversee.Size = new System.Drawing.Size(216, 20);
            this.dateTraversee.TabIndex = 6;
            // 
            // btnAfficherTraversee
            // 
            this.btnAfficherTraversee.Location = new System.Drawing.Point(12, 661);
            this.btnAfficherTraversee.Name = "btnAfficherTraversee";
            this.btnAfficherTraversee.Size = new System.Drawing.Size(1111, 23);
            this.btnAfficherTraversee.TabIndex = 7;
            this.btnAfficherTraversee.Text = "Afficher les traversées";
            this.btnAfficherTraversee.UseVisualStyleBackColor = true;
            this.btnAfficherTraversee.Click += new System.EventHandler(this.btnAfficherTraversee_Click);
            // 
            // FormAfficherTraverseePourLiaisonEtDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 699);
            this.Controls.Add(this.btnAfficherTraversee);
            this.Controls.Add(this.dateTraversee);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lvTraversee);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteurs);
            this.Name = "FormAfficherTraverseePourLiaisonEtDate";
            this.Text = "Atlantik - Afficher les traversées pour une liaison et une date donnée ";
            this.Load += new System.EventHandler(this.FormAfficherTraverseePourLiaisonEtDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteurs;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.ListView lvTraversee;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTraversee;
        private System.Windows.Forms.Button btnAfficherTraversee;
    }
}