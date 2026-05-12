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
            ((System.ComponentModel.ISupportInitialize)(this.picMission)).BeginInit();
            this.SuspendLayout();
            // 
            // picMission
            // 
            this.picMission.Location = new System.Drawing.Point(30, 17);
            this.picMission.Name = "picMission";
            this.picMission.Size = new System.Drawing.Size(153, 154);
            this.picMission.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMission.TabIndex = 1;
            this.picMission.TabStop = false;
            // 
            // lblNomMission
            // 
            this.lblNomMission.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMission.ForeColor = System.Drawing.Color.Blue;
            this.lblNomMission.Location = new System.Drawing.Point(214, 40);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(217, 25);
            this.lblNomMission.TabIndex = 2;
            this.lblNomMission.Text = "Mission : ";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Blue;
            this.lblDate.Location = new System.Drawing.Point(474, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(293, 44);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Dates : ";
            // 
            // lblChefMission
            // 
            this.lblChefMission.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefMission.ForeColor = System.Drawing.Color.Blue;
            this.lblChefMission.Location = new System.Drawing.Point(214, 97);
            this.lblChefMission.Name = "lblChefMission";
            this.lblChefMission.Size = new System.Drawing.Size(194, 49);
            this.lblChefMission.TabIndex = 4;
            this.lblChefMission.Text = "Chef de Mission : ";
            // 
            // lblBudget
            // 
            this.lblBudget.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.ForeColor = System.Drawing.Color.Blue;
            this.lblBudget.Location = new System.Drawing.Point(474, 97);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(225, 24);
            this.lblBudget.TabIndex = 5;
            this.lblBudget.Text = "Budget : ";
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.Blue;
            this.btnDetails.Location = new System.Drawing.Point(598, 148);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(145, 37);
            this.btnDetails.TabIndex = 6;
            this.btnDetails.Text = "Consulter";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // UserControl_Missions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblChefMission);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNomMission);
            this.Controls.Add(this.picMission);
            this.Name = "UserControl_Missions";
            this.Size = new System.Drawing.Size(782, 205);
            this.Load += new System.EventHandler(this.UserControl_Missions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picMission;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblChefMission;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Button btnDetails;
    }
}
