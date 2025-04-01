namespace Atlantik
{
    partial class FormAjouterSecteur
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
            this.tbxSecteur = new System.Windows.Forms.TextBox();
            this.btnAjouterSecteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxSecteur
            // 
            this.tbxSecteur.Location = new System.Drawing.Point(54, 39);
            this.tbxSecteur.Name = "tbxSecteur";
            this.tbxSecteur.Size = new System.Drawing.Size(199, 20);
            this.tbxSecteur.TabIndex = 0;
            this.tbxSecteur.Text = "Nom du secteur";
            this.tbxSecteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjouterSecteur.Location = new System.Drawing.Point(82, 103);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(136, 35);
            this.btnAjouterSecteur.TabIndex = 1;
            this.btnAjouterSecteur.Text = "Ajouter";
            this.btnAjouterSecteur.UseVisualStyleBackColor = true;
            this.btnAjouterSecteur.Click += new System.EventHandler(this.buttonAjouterSecteur_Click);
            // 
            // FormAjouterSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 167);
            this.Controls.Add(this.btnAjouterSecteur);
            this.Controls.Add(this.tbxSecteur);
            this.Name = "FormAjouterSecteur";
            this.Text = "Atlantik - Ajouter un secteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSecteur;
        private System.Windows.Forms.Button btnAjouterSecteur;
    }
}