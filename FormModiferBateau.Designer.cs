namespace Atlantik
{
    partial class FormModiferBateau
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
            this.gbxCapaciteMax = new System.Windows.Forms.GroupBox();
            this.lblNomDuBateau = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.cmbNomBateau = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gbxCapaciteMax
            // 
            this.gbxCapaciteMax.Location = new System.Drawing.Point(29, 85);
            this.gbxCapaciteMax.Name = "gbxCapaciteMax";
            this.gbxCapaciteMax.Size = new System.Drawing.Size(295, 542);
            this.gbxCapaciteMax.TabIndex = 0;
            this.gbxCapaciteMax.TabStop = false;
            this.gbxCapaciteMax.Text = "Capacités maximales";
            // 
            // lblNomDuBateau
            // 
            this.lblNomDuBateau.AutoSize = true;
            this.lblNomDuBateau.Location = new System.Drawing.Point(26, 22);
            this.lblNomDuBateau.Name = "lblNomDuBateau";
            this.lblNomDuBateau.Size = new System.Drawing.Size(86, 13);
            this.lblNomDuBateau.TabIndex = 1;
            this.lblNomDuBateau.Text = "Nom du bateau :";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(29, 633);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(295, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // cmbNomBateau
            // 
            this.cmbNomBateau.FormattingEnabled = true;
            this.cmbNomBateau.Location = new System.Drawing.Point(29, 38);
            this.cmbNomBateau.Name = "cmbNomBateau";
            this.cmbNomBateau.Size = new System.Drawing.Size(295, 21);
            this.cmbNomBateau.TabIndex = 4;
            this.cmbNomBateau.SelectedIndexChanged += new System.EventHandler(this.cmbNomBateau_SelectedIndexChanged);
            // 
            // FormModiferBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 668);
            this.Controls.Add(this.cmbNomBateau);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblNomDuBateau);
            this.Controls.Add(this.gbxCapaciteMax);
            this.Name = "FormModiferBateau";
            this.Text = "Atlantik - Modifer un bateau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCapaciteMax;
        private System.Windows.Forms.Label lblNomDuBateau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox cmbNomBateau;
    }
}