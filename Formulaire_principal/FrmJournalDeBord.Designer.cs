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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpEvenements = new System.Windows.Forms.GroupBox();
            this.flpAffichage = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDateEvenement = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnAfter = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnDepart = new System.Windows.Forms.Button();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.grpDepensesEffectues = new System.Windows.Forms.GroupBox();
            this.dgvDepenses = new System.Windows.Forms.DataGridView();
            this.lblTotSommes = new System.Windows.Forms.Label();
            this.lblTotDepenses = new System.Windows.Forms.Label();
            this.btnEditerPDF = new System.Windows.Forms.Button();
            this.dgvBilan = new System.Windows.Forms.DataGridView();
            this.grpBilan = new System.Windows.Forms.GroupBox();
            this.flpGraphiques = new System.Windows.Forms.FlowLayoutPanel();
            this.grpEvenements.SuspendLayout();
            this.flpAffichage.SuspendLayout();
            this.grpContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.grpDepensesEffectues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilan)).BeginInit();
            this.grpBilan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEvenements
            // 
            this.grpEvenements.Controls.Add(this.flpAffichage);
            this.grpEvenements.Controls.Add(this.btnEnd);
            this.grpEvenements.Controls.Add(this.btnAfter);
            this.grpEvenements.Controls.Add(this.btnBefore);
            this.grpEvenements.Controls.Add(this.btnDepart);
            this.grpEvenements.Location = new System.Drawing.Point(45, 67);
            this.grpEvenements.Name = "grpEvenements";
            this.grpEvenements.Size = new System.Drawing.Size(851, 197);
            this.grpEvenements.TabIndex = 0;
            this.grpEvenements.TabStop = false;
            this.grpEvenements.Text = "Evénements du journal";
            // 
            // flpAffichage
            // 
            this.flpAffichage.Controls.Add(this.lblDateEvenement);
            this.flpAffichage.Controls.Add(this.lblCommentaire);
            this.flpAffichage.Location = new System.Drawing.Point(20, 34);
            this.flpAffichage.Name = "flpAffichage";
            this.flpAffichage.Size = new System.Drawing.Size(757, 76);
            this.flpAffichage.TabIndex = 1;
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
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(598, 133);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 34);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = ">>";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnAfter
            // 
            this.btnAfter.Location = new System.Drawing.Point(431, 133);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(75, 34);
            this.btnAfter.TabIndex = 2;
            this.btnAfter.Text = ">";
            this.btnAfter.UseVisualStyleBackColor = true;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(284, 133);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(75, 34);
            this.btnBefore.TabIndex = 1;
            this.btnBefore.Text = "<";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnDepart
            // 
            this.btnDepart.Location = new System.Drawing.Point(100, 133);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(75, 34);
            this.btnDepart.TabIndex = 0;
            this.btnDepart.Text = "<<";
            this.btnDepart.UseVisualStyleBackColor = true;
            this.btnDepart.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.dgvContacts);
            this.grpContact.Location = new System.Drawing.Point(45, 324);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(851, 238);
            this.grpContact.TabIndex = 1;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact avec les informateurs";
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AllowUserToResizeColumns = false;
            this.dgvContacts.AllowUserToResizeRows = false;
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(20, 42);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersWidth = 51;
            this.dgvContacts.RowTemplate.Height = 24;
            this.dgvContacts.Size = new System.Drawing.Size(791, 166);
            this.dgvContacts.TabIndex = 0;
            // 
            // grpDepensesEffectues
            // 
            this.grpDepensesEffectues.Controls.Add(this.dgvDepenses);
            this.grpDepensesEffectues.Location = new System.Drawing.Point(953, 67);
            this.grpDepensesEffectues.Name = "grpDepensesEffectues";
            this.grpDepensesEffectues.Size = new System.Drawing.Size(1179, 568);
            this.grpDepensesEffectues.TabIndex = 2;
            this.grpDepensesEffectues.TabStop = false;
            this.grpDepensesEffectues.Text = "Dépenses effectuées :";
            // 
            // dgvDepenses
            // 
            this.dgvDepenses.AllowUserToAddRows = false;
            this.dgvDepenses.AllowUserToDeleteRows = false;
            this.dgvDepenses.AllowUserToResizeColumns = false;
            this.dgvDepenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvDepenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepenses.Location = new System.Drawing.Point(32, 34);
            this.dgvDepenses.Name = "dgvDepenses";
            this.dgvDepenses.ReadOnly = true;
            this.dgvDepenses.RowHeadersWidth = 51;
            this.dgvDepenses.RowTemplate.Height = 24;
            this.dgvDepenses.Size = new System.Drawing.Size(1095, 494);
            this.dgvDepenses.TabIndex = 6;
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
            this.lblTotDepenses.Location = new System.Drawing.Point(950, 660);
            this.lblTotDepenses.Name = "lblTotDepenses";
            this.lblTotDepenses.Size = new System.Drawing.Size(137, 16);
            this.lblTotDepenses.TabIndex = 4;
            this.lblTotDepenses.Text = "Total des dépenses : ";
            // 
            // btnEditerPDF
            // 
            this.btnEditerPDF.Location = new System.Drawing.Point(45, 1126);
            this.btnEditerPDF.Name = "btnEditerPDF";
            this.btnEditerPDF.Size = new System.Drawing.Size(140, 23);
            this.btnEditerPDF.TabIndex = 5;
            this.btnEditerPDF.Text = "Editer un pdf";
            this.btnEditerPDF.UseVisualStyleBackColor = true;
            // 
            // dgvBilan
            // 
            this.dgvBilan.AllowUserToAddRows = false;
            this.dgvBilan.AllowUserToDeleteRows = false;
            this.dgvBilan.AllowUserToResizeColumns = false;
            this.dgvBilan.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvBilan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBilan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBilan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilan.Location = new System.Drawing.Point(20, 44);
            this.dgvBilan.Name = "dgvBilan";
            this.dgvBilan.ReadOnly = true;
            this.dgvBilan.RowHeadersWidth = 51;
            this.dgvBilan.RowTemplate.Height = 24;
            this.dgvBilan.Size = new System.Drawing.Size(791, 309);
            this.dgvBilan.TabIndex = 6;
            // 
            // grpBilan
            // 
            this.grpBilan.Controls.Add(this.dgvBilan);
            this.grpBilan.Location = new System.Drawing.Point(45, 696);
            this.grpBilan.Name = "grpBilan";
            this.grpBilan.Size = new System.Drawing.Size(851, 394);
            this.grpBilan.TabIndex = 7;
            this.grpBilan.TabStop = false;
            this.grpBilan.Text = "Bilan des captures : ";
            // 
            // flpGraphiques
            // 
            this.flpGraphiques.Location = new System.Drawing.Point(953, 696);
            this.flpGraphiques.Name = "flpGraphiques";
            this.flpGraphiques.Size = new System.Drawing.Size(1052, 440);
            this.flpGraphiques.TabIndex = 10;
            // 
            // FrmJournalDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2243, 1172);
            this.Controls.Add(this.flpGraphiques);
            this.Controls.Add(this.grpBilan);
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
            this.grpContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.grpDepensesEffectues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilan)).EndInit();
            this.grpBilan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEvenements;
        private System.Windows.Forms.FlowLayoutPanel flpAffichage;
        private System.Windows.Forms.Button btnEnd;
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
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridView dgvDepenses;
        private System.Windows.Forms.DataGridView dgvBilan;
        private System.Windows.Forms.GroupBox grpBilan;
        private System.Windows.Forms.FlowLayoutPanel flpGraphiques;
    }
}