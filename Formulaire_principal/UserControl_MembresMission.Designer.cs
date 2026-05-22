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
            this.lblNom = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // picMembre
            // 
            this.picMembre.Location = new System.Drawing.Point(12, 21);
            this.picMembre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picMembre.Name = "picMembre";
            this.picMembre.Size = new System.Drawing.Size(119, 105);
            this.picMembre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMembre.TabIndex = 0;
            this.picMembre.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(10, 142);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(122, 19);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom : ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(10, 170);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 3;
            // 
            // UserControl_MembresMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.picMembre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControl_MembresMission";
            this.Size = new System.Drawing.Size(143, 219);
            this.Load += new System.EventHandler(this.UserControl_MembresMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMembre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMembre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lbl;
    }
}
