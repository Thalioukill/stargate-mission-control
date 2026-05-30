namespace Formulaire_principal
{
    partial class UserControl_Missions
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
            this.picMission = new System.Windows.Forms.PictureBox();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblChefMission = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.lblNbJours = new System.Windows.Forms.Label();
            this.lblStatusMission = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMission)).BeginInit();
            this.SuspendLayout();
            // 
            // picMission
            // 
            this.picMission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMission.Location = new System.Drawing.Point(27, 24);
            this.picMission.Name = "picMission";
            this.picMission.Size = new System.Drawing.Size(197, 170);
            this.picMission.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMission.TabIndex = 1;
            this.picMission.TabStop = false;
            // 
            // lblNomMission
            // 
            this.lblNomMission.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMission.ForeColor = System.Drawing.Color.Black;
            this.lblNomMission.Location = new System.Drawing.Point(257, 24);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(411, 38);
            this.lblNomMission.TabIndex = 2;
            this.lblNomMission.Text = "★ Mission : ";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(731, 88);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(400, 44);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Dates : ";
            // 
            // lblChefMission
            // 
            this.lblChefMission.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefMission.ForeColor = System.Drawing.Color.Black;
            this.lblChefMission.Location = new System.Drawing.Point(257, 88);
            this.lblChefMission.Name = "lblChefMission";
            this.lblChefMission.Size = new System.Drawing.Size(411, 49);
            this.lblChefMission.TabIndex = 4;
            this.lblChefMission.Text = "Chef de Mission : ";
            // 
            // lblBudget
            // 
            this.lblBudget.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.ForeColor = System.Drawing.Color.Black;
            this.lblBudget.Location = new System.Drawing.Point(257, 145);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(411, 59);
            this.lblBudget.TabIndex = 5;
            this.lblBudget.Text = "Budget : ";
            // 
            // btnDetails
            // 
            this.btnDetails.BackgroundImage = global::Formulaire_principal.Properties.Resources.recherche;
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.Black;
            this.btnDetails.Location = new System.Drawing.Point(1226, 149);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(57, 52);
            this.btnDetails.TabIndex = 6;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // lblNbJours
            // 
            this.lblNbJours.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbJours.ForeColor = System.Drawing.Color.Black;
            this.lblNbJours.Location = new System.Drawing.Point(731, 145);
            this.lblNbJours.Name = "lblNbJours";
            this.lblNbJours.Size = new System.Drawing.Size(450, 56);
            this.lblNbJours.TabIndex = 7;
            this.lblNbJours.Text = "Nombre de jours de la mission : ";
            // 
            // lblStatusMission
            // 
            this.lblStatusMission.AutoSize = true;
            this.lblStatusMission.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusMission.Location = new System.Drawing.Point(731, 34);
            this.lblStatusMission.Name = "lblStatusMission";
            this.lblStatusMission.Size = new System.Drawing.Size(0, 28);
            this.lblStatusMission.TabIndex = 8;
            // 
            // UserControl_Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblStatusMission);
            this.Controls.Add(this.lblNbJours);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblChefMission);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNomMission);
            this.Controls.Add(this.picMission);
            this.Name = "UserControl_Missions";
            this.Size = new System.Drawing.Size(1301, 218);
            this.Load += new System.EventHandler(this.UserControl_Missions_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picMission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMission;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblChefMission;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label lblNbJours;
        private System.Windows.Forms.Label lblStatusMission;
    }
}
