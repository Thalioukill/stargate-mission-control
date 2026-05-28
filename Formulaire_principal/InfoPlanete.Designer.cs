namespace Formulaire_principal
{
    partial class InfoPlanete
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
            this.picPlanete = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblGravite = new System.Windows.Forms.Label();
            this.lblDataBaz = new System.Windows.Forms.Label();
            this.lblEspeces = new System.Windows.Forms.Label();
            this.lblPourcentage = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanete)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlanete
            // 
            this.picPlanete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPlanete.Location = new System.Drawing.Point(3, 3);
            this.picPlanete.Name = "picPlanete";
            this.picPlanete.Size = new System.Drawing.Size(161, 138);
            this.picPlanete.TabIndex = 0;
            this.picPlanete.TabStop = false;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(3, 144);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(48, 19);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "label1";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(3, 163);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(49, 19);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "label2";
            // 
            // lblGravite
            // 
            this.lblGravite.AutoSize = true;
            this.lblGravite.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGravite.Location = new System.Drawing.Point(4, 182);
            this.lblGravite.Name = "lblGravite";
            this.lblGravite.Size = new System.Drawing.Size(48, 19);
            this.lblGravite.TabIndex = 3;
            this.lblGravite.Text = "label3";
            // 
            // lblDataBaz
            // 
            this.lblDataBaz.AutoSize = true;
            this.lblDataBaz.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBaz.Location = new System.Drawing.Point(4, 201);
            this.lblDataBaz.Name = "lblDataBaz";
            this.lblDataBaz.Size = new System.Drawing.Size(49, 19);
            this.lblDataBaz.TabIndex = 4;
            this.lblDataBaz.Text = "label4";
            // 
            // lblEspeces
            // 
            this.lblEspeces.AutoSize = true;
            this.lblEspeces.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspeces.Location = new System.Drawing.Point(4, 220);
            this.lblEspeces.Name = "lblEspeces";
            this.lblEspeces.Size = new System.Drawing.Size(49, 19);
            this.lblEspeces.TabIndex = 5;
            this.lblEspeces.Text = "label5";
            // 
            // lblPourcentage
            // 
            this.lblPourcentage.AutoSize = true;
            this.lblPourcentage.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPourcentage.Location = new System.Drawing.Point(4, 239);
            this.lblPourcentage.Name = "lblPourcentage";
            this.lblPourcentage.Size = new System.Drawing.Size(49, 19);
            this.lblPourcentage.TabIndex = 6;
            this.lblPourcentage.Text = "label6";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.Location = new System.Drawing.Point(4, 258);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(49, 19);
            this.lblMission.TabIndex = 7;
            this.lblMission.Text = "label7";
            // 
            // InfoPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.lblPourcentage);
            this.Controls.Add(this.lblEspeces);
            this.Controls.Add(this.lblDataBaz);
            this.Controls.Add(this.lblGravite);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.picPlanete);
            this.Name = "InfoPlanete";
            this.Size = new System.Drawing.Size(258, 290);
            this.Load += new System.EventHandler(this.InfoPlanete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlanete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlanete;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblGravite;
        private System.Windows.Forms.Label lblDataBaz;
        private System.Windows.Forms.Label lblEspeces;
        private System.Windows.Forms.Label lblPourcentage;
        private System.Windows.Forms.Label lblMission;
    }
}
