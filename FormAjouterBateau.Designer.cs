﻿namespace Atlantik
{
    partial class FormAjouterBateau
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblNomDuBateau = new System.Windows.Forms.Label();
            this.gbxCapaciteMax = new System.Windows.Forms.GroupBox();
            this.tbxNomBateau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(29, 633);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(295, 23);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblNomDuBateau
            // 
            this.lblNomDuBateau.AutoSize = true;
            this.lblNomDuBateau.Location = new System.Drawing.Point(26, 22);
            this.lblNomDuBateau.Name = "lblNomDuBateau";
            this.lblNomDuBateau.Size = new System.Drawing.Size(86, 13);
            this.lblNomDuBateau.TabIndex = 6;
            this.lblNomDuBateau.Text = "Nom du bateau :";
            // 
            // gbxCapaciteMax
            // 
            this.gbxCapaciteMax.Location = new System.Drawing.Point(29, 85);
            this.gbxCapaciteMax.Name = "gbxCapaciteMax";
            this.gbxCapaciteMax.Size = new System.Drawing.Size(295, 542);
            this.gbxCapaciteMax.TabIndex = 5;
            this.gbxCapaciteMax.TabStop = false;
            this.gbxCapaciteMax.Text = "Capacités maximales";
            // 
            // tbxNomBateau
            // 
            this.tbxNomBateau.Location = new System.Drawing.Point(29, 38);
            this.tbxNomBateau.Name = "tbxNomBateau";
            this.tbxNomBateau.Size = new System.Drawing.Size(295, 20);
            this.tbxNomBateau.TabIndex = 9;
            // 
            // FormAjouterBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 668);
            this.Controls.Add(this.tbxNomBateau);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblNomDuBateau);
            this.Controls.Add(this.gbxCapaciteMax);
            this.Name = "FormAjouterBateau";
            this.Text = "Atlantik - Ajouter un bateau";
            this.Load += new System.EventHandler(this.FormAjouterBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblNomDuBateau;
        private System.Windows.Forms.GroupBox gbxCapaciteMax;
        private System.Windows.Forms.TextBox tbxNomBateau;
    }
}