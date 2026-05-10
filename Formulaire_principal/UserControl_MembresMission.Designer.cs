namespace Formulaire_principal
{
    partial class UserControl_MembresMission
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.picMembre = new System.Windows.Forms.PictureBox();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblSpecialite_Grade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // picMembre
            // 
            this.picMembre.Location = new System.Drawing.Point(24, 25);
            this.picMembre.Name = "picMembre";
            this.picMembre.Size = new System.Drawing.Size(148, 129);
            this.picMembre.TabIndex = 0;
            this.picMembre.TabStop = false;
            // 
            // lblnom
            // 
            this.lblnom.Location = new System.Drawing.Point(24, 173);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(148, 23);
            this.lblnom.TabIndex = 1;
            this.lblnom.Text = "Nom : ";
            // 
            // lblSpecialite_Grade
            // 
            this.lblSpecialite_Grade.AutoSize = true;
            this.lblSpecialite_Grade.Location = new System.Drawing.Point(24, 209);
            this.lblSpecialite_Grade.Name = "lblSpecialite_Grade";
            this.lblSpecialite_Grade.Size = new System.Drawing.Size(0, 16);
            this.lblSpecialite_Grade.TabIndex = 2;
            // 
            // UserControl_MembresMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSpecialite_Grade);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.picMembre);
            this.Name = "UserControl_MembresMission";
            this.Size = new System.Drawing.Size(196, 251);
            this.Load += new System.EventHandler(this.UserControl_MembresMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMembre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMembre;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblSpecialite_Grade;
    }
}
