namespace Formulaire_principal
{
    partial class FrmJournalDeBord
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
            this.grpEvenements = new System.Windows.Forms.GroupBox();
            this.btnDepart = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnAfter = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.flpAffichage = new System.Windows.Forms.FlowLayoutPanel();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.grpDepensesEffectues = new System.Windows.Forms.GroupBox();
            this.lblTotSommes = new System.Windows.Forms.Label();
            this.lblTotDepenses = new System.Windows.Forms.Label();
            this.btnEditerPDF = new System.Windows.Forms.Button();
            this.lblDateEvenement = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.grpEvenements.SuspendLayout();
            this.flpAffichage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEvenements
            // 
            this.grpEvenements.Controls.Add(this.flpAffichage);
            this.grpEvenements.Controls.Add(this.btnStart);
            this.grpEvenements.Controls.Add(this.btnAfter);
            this.grpEvenements.Controls.Add(this.btnBefore);
            this.grpEvenements.Controls.Add(this.btnDepart);
            this.grpEvenements.Location = new System.Drawing.Point(45, 67);
            this.grpEvenements.Name = "grpEvenements";
            this.grpEvenements.Size = new System.Drawing.Size(1011, 197);
            this.grpEvenements.TabIndex = 0;
            this.grpEvenements.TabStop = false;
            this.grpEvenements.Text = "Evénements du journal";
            // 
            // btnDepart
            // 
            this.btnDepart.Location = new System.Drawing.Point(194, 130);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(75, 34);
            this.btnDepart.TabIndex = 0;
            this.btnDepart.Text = "<<";
            this.btnDepart.UseVisualStyleBackColor = true;
            this.btnDepart.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(378, 130);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(75, 34);
            this.btnBefore.TabIndex = 1;
            this.btnBefore.Text = "<";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnAfter
            // 
            this.btnAfter.Location = new System.Drawing.Point(525, 130);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(75, 34);
            this.btnAfter.TabIndex = 2;
            this.btnAfter.Text = ">";
            this.btnAfter.UseVisualStyleBackColor = true;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(692, 130);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 34);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = ">>";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // flpAffichage
            // 
            this.flpAffichage.Controls.Add(this.lblDateEvenement);
            this.flpAffichage.Controls.Add(this.lblCommentaire);
            this.flpAffichage.Location = new System.Drawing.Point(20, 34);
            this.flpAffichage.Name = "flpAffichage";
            this.flpAffichage.Size = new System.Drawing.Size(968, 76);
            this.flpAffichage.TabIndex = 1;
            // 
            // grpContact
            // 
            this.grpContact.Location = new System.Drawing.Point(45, 324);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(998, 200);
            this.grpContact.TabIndex = 1;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact avec les informateurs";
            // 
            // grpDepensesEffectues
            // 
            this.grpDepensesEffectues.Location = new System.Drawing.Point(1098, 67);
            this.grpDepensesEffectues.Name = "grpDepensesEffectues";
            this.grpDepensesEffectues.Size = new System.Drawing.Size(1179, 568);
            this.grpDepensesEffectues.TabIndex = 2;
            this.grpDepensesEffectues.TabStop = false;
            this.grpDepensesEffectues.Text = "Dépenses effectuées :";
            // 
            // lblTotSommes
            // 
            this.lblTotSommes.AutoSize = true;
            this.lblTotSommes.Location = new System.Drawing.Point(45, 579);
            this.lblTotSommes.Name = "lblTotSommes";
            this.lblTotSommes.Size = new System.Drawing.Size(180, 16);
            this.lblTotSommes.TabIndex = 3;
            this.lblTotSommes.Text = "Total des sommes versées : ";
            // 
            // lblTotDepenses
            // 
            this.lblTotDepenses.AutoSize = true;
            this.lblTotDepenses.Location = new System.Drawing.Point(1098, 673);
            this.lblTotDepenses.Name = "lblTotDepenses";
            this.lblTotDepenses.Size = new System.Drawing.Size(137, 16);
            this.lblTotDepenses.TabIndex = 4;
            this.lblTotDepenses.Text = "Total des dépenses : ";
            // 
            // btnEditerPDF
            // 
            this.btnEditerPDF.Location = new System.Drawing.Point(45, 711);
            this.btnEditerPDF.Name = "btnEditerPDF";
            this.btnEditerPDF.Size = new System.Drawing.Size(140, 23);
            this.btnEditerPDF.TabIndex = 5;
            this.btnEditerPDF.Text = "Editer un pdf";
            this.btnEditerPDF.UseVisualStyleBackColor = true;
            // 
            // lblDateEvenement
            // 
            this.lblDateEvenement.AutoSize = true;
            this.lblDateEvenement.Location = new System.Drawing.Point(3, 0);
            this.lblDateEvenement.Name = "lblDateEvenement";
            this.lblDateEvenement.Size = new System.Drawing.Size(0, 16);
            this.lblDateEvenement.TabIndex = 0;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(9, 0);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(0, 16);
            this.lblCommentaire.TabIndex = 1;
            // 
            // FrmJournalDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2309, 1172);
            this.Controls.Add(this.btnEditerPDF);
            this.Controls.Add(this.lblTotDepenses);
            this.Controls.Add(this.lblTotSommes);
            this.Controls.Add(this.grpDepensesEffectues);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpEvenements);
            this.Name = "FrmJournalDeBord";
            this.Text = "Journal de bord : ";
            this.Load += new System.EventHandler(this.FrmJournalDeBord_Load);
            this.grpEvenements.ResumeLayout(false);
            this.flpAffichage.ResumeLayout(false);
            this.flpAffichage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEvenements;
        private System.Windows.Forms.FlowLayoutPanel flpAffichage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAfter;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnDepart;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.GroupBox grpDepensesEffectues;
        private System.Windows.Forms.Label lblTotSommes;
        private System.Windows.Forms.Label lblTotDepenses;
        private System.Windows.Forms.Button btnEditerPDF;
        private System.Windows.Forms.Label lblDateEvenement;
        private System.Windows.Forms.Label lblCommentaire;
    }
}