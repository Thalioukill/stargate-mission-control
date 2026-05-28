namespace Formulaire_principal
{
    partial class InfoEnnemis
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
            this.lblArme = new System.Windows.Forms.Label();
            this.lblPlaneteEnnemis = new System.Windows.Forms.Label();
            this.lblCouleurEnnemis = new System.Windows.Forms.Label();
            this.lblAgressivite = new System.Windows.Forms.Label();
            this.lblNomEnnemis = new System.Windows.Forms.Label();
            this.picEnnemis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEnnemis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArme
            // 
            this.lblArme.AutoSize = true;
            this.lblArme.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArme.Location = new System.Drawing.Point(3, 226);
            this.lblArme.Name = "lblArme";
            this.lblArme.Size = new System.Drawing.Size(49, 19);
            this.lblArme.TabIndex = 11;
            this.lblArme.Text = "label5";
            // 
            // lblPlaneteEnnemis
            // 
            this.lblPlaneteEnnemis.AutoSize = true;
            this.lblPlaneteEnnemis.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneteEnnemis.Location = new System.Drawing.Point(3, 209);
            this.lblPlaneteEnnemis.Name = "lblPlaneteEnnemis";
            this.lblPlaneteEnnemis.Size = new System.Drawing.Size(49, 19);
            this.lblPlaneteEnnemis.TabIndex = 10;
            this.lblPlaneteEnnemis.Text = "label4";
            // 
            // lblCouleurEnnemis
            // 
            this.lblCouleurEnnemis.AutoSize = true;
            this.lblCouleurEnnemis.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleurEnnemis.Location = new System.Drawing.Point(3, 192);
            this.lblCouleurEnnemis.Name = "lblCouleurEnnemis";
            this.lblCouleurEnnemis.Size = new System.Drawing.Size(48, 19);
            this.lblCouleurEnnemis.TabIndex = 9;
            this.lblCouleurEnnemis.Text = "label3";
            // 
            // lblAgressivite
            // 
            this.lblAgressivite.AutoSize = true;
            this.lblAgressivite.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgressivite.Location = new System.Drawing.Point(3, 175);
            this.lblAgressivite.Name = "lblAgressivite";
            this.lblAgressivite.Size = new System.Drawing.Size(49, 19);
            this.lblAgressivite.TabIndex = 8;
            this.lblAgressivite.Text = "label2";
            // 
            // lblNomEnnemis
            // 
            this.lblNomEnnemis.AutoSize = true;
            this.lblNomEnnemis.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEnnemis.Location = new System.Drawing.Point(3, 158);
            this.lblNomEnnemis.Name = "lblNomEnnemis";
            this.lblNomEnnemis.Size = new System.Drawing.Size(48, 19);
            this.lblNomEnnemis.TabIndex = 7;
            this.lblNomEnnemis.Text = "label1";
            // 
            // picEnnemis
            // 
            this.picEnnemis.Location = new System.Drawing.Point(3, 3);
            this.picEnnemis.Name = "picEnnemis";
            this.picEnnemis.Size = new System.Drawing.Size(128, 152);
            this.picEnnemis.TabIndex = 6;
            this.picEnnemis.TabStop = false;
            // 
            // InfoEnnemis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblArme);
            this.Controls.Add(this.lblPlaneteEnnemis);
            this.Controls.Add(this.lblCouleurEnnemis);
            this.Controls.Add(this.lblAgressivite);
            this.Controls.Add(this.lblNomEnnemis);
            this.Controls.Add(this.picEnnemis);
            this.Name = "InfoEnnemis";
            this.Size = new System.Drawing.Size(179, 245);
            this.Load += new System.EventHandler(this.InfoEnnemis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEnnemis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArme;
        private System.Windows.Forms.Label lblPlaneteEnnemis;
        private System.Windows.Forms.Label lblCouleurEnnemis;
        private System.Windows.Forms.Label lblAgressivite;
        private System.Windows.Forms.Label lblNomEnnemis;
        private System.Windows.Forms.PictureBox picEnnemis;
    }
}
