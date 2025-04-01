namespace Atlantik
{
    partial class FormAjouterPort
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
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(54, 39);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(199, 20);
            this.tbxPort.TabIndex = 0;
            this.tbxPort.Text = "Nom du port";
            this.tbxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(82, 103);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(136, 35);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // FormAjouterPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 167);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.tbxPort);
            this.Name = "FormAjouterPort";
            this.Text = "Atlantik - Ajouter un port";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Button btnAjouter;
    }
}