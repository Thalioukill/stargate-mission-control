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
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblSoldeApresDepenses = new System.Windows.Forms.Label();
            this.flpEquipage = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.rtbFeuilleDeRoute = new System.Windows.Forms.RichTextBox();
            this.lblMembres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJournal = new System.Windows.Forms.Button();
            this.flpObjectifCaptures = new System.Windows.Forms.FlowLayoutPanel();
            this.lblObjectifCapture = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMission)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Location = new System.Drawing.Point(211, 29);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(59, 16);
            this.lblNomMission.TabIndex = 0;
            this.lblNomMission.Text = "Mission :";
            // 
            // picMission
            // 
            this.picMission.Location = new System.Drawing.Point(25, 29);
            this.picMission.Name = "picMission";
            this.picMission.Size = new System.Drawing.Size(168, 154);
            this.picMission.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMission.TabIndex = 2;
            this.picMission.TabStop = false;
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(211, 91);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(106, 16);
            this.lblDateDepart.TabIndex = 3;
            this.lblDateDepart.Text = "Date de départ : ";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(541, 91);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(53, 16);
            this.lblBudget.TabIndex = 5;
            this.lblBudget.Text = "Budget ";
            // 
            // lblSoldeApresDepenses
            // 
            this.lblSoldeApresDepenses.AutoSize = true;
            this.lblSoldeApresDepenses.Location = new System.Drawing.Point(541, 134);
            this.lblSoldeApresDepenses.Name = "lblSoldeApresDepenses";
            this.lblSoldeApresDepenses.Size = new System.Drawing.Size(154, 16);
            this.lblSoldeApresDepenses.TabIndex = 6;
            this.lblSoldeApresDepenses.Text = "Solde après dépenses : ";
            // 
            // flpEquipage
            // 
            this.flpEquipage.AutoScroll = true;
            this.flpEquipage.Location = new System.Drawing.Point(25, 461);
            this.flpEquipage.Name = "flpEquipage";
            this.flpEquipage.Size = new System.Drawing.Size(955, 280);
            this.flpEquipage.TabIndex = 7;
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Location = new System.Drawing.Point(211, 134);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(101, 16);
            this.lblDateRetour.TabIndex = 4;
            this.lblDateRetour.Text = "Date de retour : ";
            // 
            // rtbFeuilleDeRoute
            // 
            this.rtbFeuilleDeRoute.Location = new System.Drawing.Point(25, 230);
            this.rtbFeuilleDeRoute.Name = "rtbFeuilleDeRoute";
            this.rtbFeuilleDeRoute.ReadOnly = true;
            this.rtbFeuilleDeRoute.Size = new System.Drawing.Size(955, 184);
            this.rtbFeuilleDeRoute.TabIndex = 8;
            this.rtbFeuilleDeRoute.Text = "";
            // 
            // lblMembres
            // 
            this.lblMembres.AutoSize = true;
            this.lblMembres.Location = new System.Drawing.Point(25, 439);
            this.lblMembres.Name = "lblMembres";
            this.lblMembres.Size = new System.Drawing.Size(159, 16);
            this.lblMembres.TabIndex = 9;
            this.lblMembres.Text = "Membres de l\'équipage : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Feuille de route :";
            // 
            // btnJournal
            // 
            this.btnJournal.Location = new System.Drawing.Point(835, 1023);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(144, 39);
            this.btnJournal.TabIndex = 12;
            this.btnJournal.Text = "Accès Journal";
            this.btnJournal.UseVisualStyleBackColor = true;
            // 
            // flpObjectifCaptures
            // 
            this.flpObjectifCaptures.AutoScroll = true;
            this.flpObjectifCaptures.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpObjectifCaptures.Location = new System.Drawing.Point(25, 798);
            this.flpObjectifCaptures.Name = "flpObjectifCaptures";
            this.flpObjectifCaptures.Size = new System.Drawing.Size(954, 200);
            this.flpObjectifCaptures.TabIndex = 13;
            // 
            // lblObjectifCapture
            // 
            this.lblObjectifCapture.AutoSize = true;
            this.lblObjectifCapture.Location = new System.Drawing.Point(22, 779);
            this.lblObjectifCapture.Name = "lblObjectifCapture";
            this.lblObjectifCapture.Size = new System.Drawing.Size(135, 16);
            this.lblObjectifCapture.TabIndex = 0;
            this.lblObjectifCapture.Text = "Objectif de captures : ";
            // 
            // FrmDetailMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 1074);
            this.Controls.Add(this.lblObjectifCapture);
            this.Controls.Add(this.flpObjectifCaptures);
            this.Controls.Add(this.btnJournal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMembres);
            this.Controls.Add(this.rtbFeuilleDeRoute);
            this.Controls.Add(this.flpEquipage);
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
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblSoldeApresDepenses;
        private System.Windows.Forms.FlowLayoutPanel flpEquipage;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.RichTextBox rtbFeuilleDeRoute;
        private System.Windows.Forms.Label lblMembres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.FlowLayoutPanel flpObjectifCaptures;
        private System.Windows.Forms.Label lblObjectifCapture;
    }
}