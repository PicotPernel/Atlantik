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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(32, 62);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblSecteurs.TabIndex = 0;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(32, 20);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 1;
            this.lblLiaison.Text = "Liaison :";
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(35, 78);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(152, 264);
            this.lbxSecteurs.TabIndex = 2;
            // 
            // lvTraversee
            // 
            this.lvTraversee.HideSelection = false;
            this.lvTraversee.Location = new System.Drawing.Point(216, 62);
            this.lvTraversee.Name = "lvTraversee";
            this.lvTraversee.Size = new System.Drawing.Size(322, 251);
            this.lvTraversee.TabIndex = 3;
            this.lvTraversee.UseCompatibleStateImageBehavior = false;
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(35, 35);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(152, 21);
            this.cmbLiaison.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(213, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(123, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date (Par défaut du jour)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(322, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Afficher les traversées";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAfficherTraverseePourLiaisonEtDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lvTraversee);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteurs);
            this.Name = "FormAfficherTraverseePourLiaisonEtDate";
            this.Text = "Atlantik - Afficher les traversées pour une liaison et une date donnée ";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}