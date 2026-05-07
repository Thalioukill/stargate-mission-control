namespace Formulaire_principal
{
    partial class FrmAccueil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlanetes = new System.Windows.Forms.Button();
            this.btnMission = new System.Windows.Forms.Button();
            this.btnAliens = new System.Windows.Forms.Button();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlanetes
            // 
            this.btnPlanetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanetes.Location = new System.Drawing.Point(929, 537);
            this.btnPlanetes.Name = "btnPlanetes";
            this.btnPlanetes.Size = new System.Drawing.Size(148, 54);
            this.btnPlanetes.TabIndex = 0;
            this.btnPlanetes.Text = "Planète";
            this.btnPlanetes.UseVisualStyleBackColor = true;
            this.btnPlanetes.Click += new System.EventHandler(this.btnPlanetes_Click);
            // 
            // btnMission
            // 
            this.btnMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMission.Location = new System.Drawing.Point(379, 537);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(181, 66);
            this.btnMission.TabIndex = 1;
            this.btnMission.Text = "Nouvelle Mission";
            this.btnMission.UseVisualStyleBackColor = true;
            this.btnMission.Click += new System.EventHandler(this.btnMission_Click);
            // 
            // btnAliens
            // 
            this.btnAliens.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAliens.Location = new System.Drawing.Point(670, 537);
            this.btnAliens.Name = "btnAliens";
            this.btnAliens.Size = new System.Drawing.Size(148, 54);
            this.btnAliens.TabIndex = 3;
            this.btnAliens.Text = "Aliens";
            this.btnAliens.UseVisualStyleBackColor = true;
            this.btnAliens.Click += new System.EventHandler(this.btnAliens_Click);
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableauDeBord.Location = new System.Drawing.Point(116, 537);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Size = new System.Drawing.Size(191, 66);
            this.btnTableauDeBord.TabIndex = 2;
            this.btnTableauDeBord.Text = "Tableau de bord";
            this.btnTableauDeBord.UseVisualStyleBackColor = true;
            this.btnTableauDeBord.Click += new System.EventHandler(this.btnTableauDeBord_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 629);
            this.Controls.Add(this.btnAliens);
            this.Controls.Add(this.btnTableauDeBord);
            this.Controls.Add(this.btnMission);
            this.Controls.Add(this.btnPlanetes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil Stargate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlanetes;
        private System.Windows.Forms.Button btnMission;
        private System.Windows.Forms.Button btnAliens;
        private System.Windows.Forms.Button btnTableauDeBord;
    }
}

