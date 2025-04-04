namespace Atlantik
{
    partial class FormModifierParametres
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
            this.gbxIdentifiants = new System.Windows.Forms.GroupBox();
            this.tbxCleHMAC = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxRang = new System.Windows.Forms.TextBox();
            this.tbxSite = new System.Windows.Forms.TextBox();
            this.lblCleHMAC = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblRang = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.cbxEnProduction = new System.Windows.Forms.CheckBox();
            this.lblSiteMel = new System.Windows.Forms.Label();
            this.tbxMel = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.gbxIdentifiants.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxIdentifiants
            // 
            this.gbxIdentifiants.Controls.Add(this.tbxCleHMAC);
            this.gbxIdentifiants.Controls.Add(this.tbxId);
            this.gbxIdentifiants.Controls.Add(this.tbxRang);
            this.gbxIdentifiants.Controls.Add(this.tbxSite);
            this.gbxIdentifiants.Controls.Add(this.lblCleHMAC);
            this.gbxIdentifiants.Controls.Add(this.lblIdentifiant);
            this.gbxIdentifiants.Controls.Add(this.lblRang);
            this.gbxIdentifiants.Controls.Add(this.lblSite);
            this.gbxIdentifiants.Location = new System.Drawing.Point(12, 12);
            this.gbxIdentifiants.Name = "gbxIdentifiants";
            this.gbxIdentifiants.Size = new System.Drawing.Size(460, 300);
            this.gbxIdentifiants.TabIndex = 0;
            this.gbxIdentifiants.TabStop = false;
            this.gbxIdentifiants.Text = "Identifiants PayBox";
            // 
            // tbxCleHMAC
            // 
            this.tbxCleHMAC.Location = new System.Drawing.Point(169, 126);
            this.tbxCleHMAC.Multiline = true;
            this.tbxCleHMAC.Name = "tbxCleHMAC";
            this.tbxCleHMAC.Size = new System.Drawing.Size(234, 159);
            this.tbxCleHMAC.TabIndex = 7;
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(169, 90);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(234, 20);
            this.tbxId.TabIndex = 6;
            // 
            // tbxRang
            // 
            this.tbxRang.Location = new System.Drawing.Point(169, 60);
            this.tbxRang.Name = "tbxRang";
            this.tbxRang.Size = new System.Drawing.Size(234, 20);
            this.tbxRang.TabIndex = 5;
            // 
            // tbxSite
            // 
            this.tbxSite.Location = new System.Drawing.Point(169, 27);
            this.tbxSite.Name = "tbxSite";
            this.tbxSite.Size = new System.Drawing.Size(234, 20);
            this.tbxSite.TabIndex = 4;
            // 
            // lblCleHMAC
            // 
            this.lblCleHMAC.AutoSize = true;
            this.lblCleHMAC.Location = new System.Drawing.Point(15, 133);
            this.lblCleHMAC.Name = "lblCleHMAC";
            this.lblCleHMAC.Size = new System.Drawing.Size(62, 13);
            this.lblCleHMAC.TabIndex = 3;
            this.lblCleHMAC.Text = "Clé HMAC :";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(15, 97);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(59, 13);
            this.lblIdentifiant.TabIndex = 2;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(18, 67);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(39, 13);
            this.lblRang.TabIndex = 1;
            this.lblRang.Text = "Rang :";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(18, 34);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(31, 13);
            this.lblSite.TabIndex = 0;
            this.lblSite.Text = "Site :";
            // 
            // cbxEnProduction
            // 
            this.cbxEnProduction.AutoSize = true;
            this.cbxEnProduction.Location = new System.Drawing.Point(12, 318);
            this.cbxEnProduction.Name = "cbxEnProduction";
            this.cbxEnProduction.Size = new System.Drawing.Size(98, 17);
            this.cbxEnProduction.TabIndex = 1;
            this.cbxEnProduction.Text = "En production :";
            this.cbxEnProduction.UseVisualStyleBackColor = true;
            // 
            // lblSiteMel
            // 
            this.lblSiteMel.AutoSize = true;
            this.lblSiteMel.Location = new System.Drawing.Point(181, 318);
            this.lblSiteMel.Name = "lblSiteMel";
            this.lblSiteMel.Size = new System.Drawing.Size(51, 13);
            this.lblSiteMel.TabIndex = 2;
            this.lblSiteMel.Text = "Mél Site :";
            // 
            // tbxMel
            // 
            this.tbxMel.Location = new System.Drawing.Point(238, 319);
            this.tbxMel.Name = "tbxMel";
            this.tbxMel.Size = new System.Drawing.Size(177, 20);
            this.tbxMel.TabIndex = 3;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(14, 367);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(458, 23);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // FormModifierParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 403);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbxMel);
            this.Controls.Add(this.lblSiteMel);
            this.Controls.Add(this.cbxEnProduction);
            this.Controls.Add(this.gbxIdentifiants);
            this.Name = "FormModifierParametres";
            this.Text = "Atlantik - Modifier paramètres";
            this.Load += new System.EventHandler(this.FormModifierParametres_Load);
            this.gbxIdentifiants.ResumeLayout(false);
            this.gbxIdentifiants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIdentifiants;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxRang;
        private System.Windows.Forms.TextBox tbxSite;
        private System.Windows.Forms.Label lblCleHMAC;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblRang;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox tbxCleHMAC;
        private System.Windows.Forms.CheckBox cbxEnProduction;
        private System.Windows.Forms.Label lblSiteMel;
        private System.Windows.Forms.TextBox tbxMel;
        private System.Windows.Forms.Button btnModifier;
    }
}