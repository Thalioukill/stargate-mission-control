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
            this.picMembre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMembre.Location = new System.Drawing.Point(43, 25);
            this.picMembre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMembre.Name = "picMembre";
            this.picMembre.Size = new System.Drawing.Size(151, 129);
            this.picMembre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMembre.TabIndex = 0;
            this.picMembre.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(13, 175);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(230, 30);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom : ";
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(13, 219);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(230, 73);
            this.lbl.TabIndex = 3;
            // 
            // UserControl_MembresMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.picMembre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_MembresMission";
            this.Size = new System.Drawing.Size(246, 302);
            this.Load += new System.EventHandler(this.UserControl_MembresMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMembre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMembre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lbl;
    }
}
