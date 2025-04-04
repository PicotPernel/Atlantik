namespace Atlantik
{
    partial class FormReservationPourClient
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
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.cmbNomPrenom = new System.Windows.Forms.ComboBox();
            this.lvReservation = new System.Windows.Forms.ListView();
            this.gbxDetailsReservation = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(31, 24);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(77, 13);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "Nom, Prénom :";
            // 
            // cmbNomPrenom
            // 
            this.cmbNomPrenom.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbNomPrenom.FormattingEnabled = true;
            this.cmbNomPrenom.Location = new System.Drawing.Point(34, 40);
            this.cmbNomPrenom.Name = "cmbNomPrenom";
            this.cmbNomPrenom.Size = new System.Drawing.Size(121, 21);
            this.cmbNomPrenom.TabIndex = 1;
            this.cmbNomPrenom.SelectedIndexChanged += new System.EventHandler(this.cmbNomPrenom_SelectedIndexChanged);
            // 
            // lvReservation
            // 
            this.lvReservation.HideSelection = false;
            this.lvReservation.Location = new System.Drawing.Point(183, 24);
            this.lvReservation.Name = "lvReservation";
            this.lvReservation.Size = new System.Drawing.Size(591, 150);
            this.lvReservation.TabIndex = 2;
            this.lvReservation.UseCompatibleStateImageBehavior = false;
            this.lvReservation.SelectedIndexChanged += new System.EventHandler(this.lvReservation_SelectedIndexChanged);
            // 
            // gbxDetailsReservation
            // 
            this.gbxDetailsReservation.BackColor = System.Drawing.Color.Transparent;
            this.gbxDetailsReservation.Location = new System.Drawing.Point(34, 180);
            this.gbxDetailsReservation.Name = "gbxDetailsReservation";
            this.gbxDetailsReservation.Size = new System.Drawing.Size(740, 357);
            this.gbxDetailsReservation.TabIndex = 3;
            this.gbxDetailsReservation.TabStop = false;
            this.gbxDetailsReservation.Text = "Réservation";
            // 
            // FormReservationPourClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.gbxDetailsReservation);
            this.Controls.Add(this.lvReservation);
            this.Controls.Add(this.cmbNomPrenom);
            this.Controls.Add(this.lblNomPrenom);
            this.Name = "FormReservationPourClient";
            this.Text = "Atlantik - Afficher les détails d\'une réservation pour un client";
            this.Load += new System.EventHandler(this.ReservationPourClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.ComboBox cmbNomPrenom;
        private System.Windows.Forms.ListView lvReservation;
        private System.Windows.Forms.GroupBox gbxDetailsReservation;
    }
}