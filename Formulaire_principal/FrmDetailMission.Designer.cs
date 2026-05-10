namespace Formulaire_principal
{
    partial class FrmDetailMission
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
            this.lblNomMission = new System.Windows.Forms.Label();
            this.picMission = new System.Windows.Forms.PictureBox();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblSoldeApresDepenses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMission)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Location = new System.Drawing.Point(382, 83);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(59, 16);
            this.lblNomMission.TabIndex = 0;
            this.lblNomMission.Text = "Mission :";
            // 
            // picMission
            // 
            this.picMission.Location = new System.Drawing.Point(25, 23);
            this.picMission.Name = "picMission";
            this.picMission.Size = new System.Drawing.Size(168, 154);
            this.picMission.TabIndex = 2;
            this.picMission.TabStop = false;
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(25, 221);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(106, 16);
            this.lblDateDepart.TabIndex = 3;
            this.lblDateDepart.Text = "Date de départ : ";
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Location = new System.Drawing.Point(25, 268);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(101, 16);
            this.lblDateRetour.TabIndex = 4;
            this.lblDateRetour.Text = "Date de retour : ";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(530, 221);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(56, 16);
            this.lblBudget.TabIndex = 5;
            this.lblBudget.Text = "Budget :";
            // 
            // lblSoldeApresDepenses
            // 
            this.lblSoldeApresDepenses.AutoSize = true;
            this.lblSoldeApresDepenses.Location = new System.Drawing.Point(533, 268);
            this.lblSoldeApresDepenses.Name = "lblSoldeApresDepenses";
            this.lblSoldeApresDepenses.Size = new System.Drawing.Size(154, 16);
            this.lblSoldeApresDepenses.TabIndex = 6;
            this.lblSoldeApresDepenses.Text = "Solde après dépenses : ";
            // 
            // FrmDetailMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 692);
            this.Controls.Add(this.lblSoldeApresDepenses);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblDateRetour);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.picMission);
            this.Controls.Add(this.lblNomMission);
            this.Name = "FrmDetailMission";
            this.Text = "Fiche Mission : ";
            this.Load += new System.EventHandler(this.FrmDetailMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.PictureBox picMission;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblSoldeApresDepenses;
    }
}