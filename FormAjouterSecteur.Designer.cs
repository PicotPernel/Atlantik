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
            this.tbx_secteur = new System.Windows.Forms.TextBox();
            this.buttonAjouterSecteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_secteur
            // 
            this.tbx_secteur.Location = new System.Drawing.Point(12, 33);
            this.tbx_secteur.Name = "tbx_secteur";
            this.tbx_secteur.Size = new System.Drawing.Size(199, 20);
            this.tbx_secteur.TabIndex = 0;
            this.tbx_secteur.Text = "Nom du secteur";
            this.tbx_secteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_secteur.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonAjouterSecteur
            // 
            this.buttonAjouterSecteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAjouterSecteur.Location = new System.Drawing.Point(40, 98);
            this.buttonAjouterSecteur.Name = "buttonAjouterSecteur";
            this.buttonAjouterSecteur.Size = new System.Drawing.Size(136, 35);
            this.buttonAjouterSecteur.TabIndex = 1;
            this.buttonAjouterSecteur.Text = "Ajouter";
            this.buttonAjouterSecteur.UseVisualStyleBackColor = true;
            this.buttonAjouterSecteur.Click += new System.EventHandler(this.buttonAjouterSecteur_Click);
            // 
            // FormAjoutSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 176);
            this.Controls.Add(this.buttonAjouterSecteur);
            this.Controls.Add(this.tbx_secteur);
            this.Name = "FormAjoutSecteur";
            this.Text = "Atlantik - Ajouter un secteur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_secteur;
        private System.Windows.Forms.Button buttonAjouterSecteur;
    }
}