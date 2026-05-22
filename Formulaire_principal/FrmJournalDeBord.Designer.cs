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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chartBudget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEtatBudget = new System.Windows.Forms.Label();
            this.lblStatsCaptures = new System.Windows.Forms.Label();
            this.grpEvenements.SuspendLayout();
            this.flpAffichage.SuspendLayout();
            this.grpContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.grpDepensesEffectues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilan)).BeginInit();
            this.grpBilan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEvenements
            // 
            this.grpEvenements.Controls.Add(this.flpAffichage);
            this.grpEvenements.Controls.Add(this.btnEnd);
            this.grpEvenements.Controls.Add(this.btnAfter);
            this.grpEvenements.Controls.Add(this.btnBefore);
            this.grpEvenements.Controls.Add(this.btnDepart);
            this.grpEvenements.Location = new System.Drawing.Point(307, 20);
            this.grpEvenements.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEvenements.Name = "grpEvenements";
            this.grpEvenements.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEvenements.Size = new System.Drawing.Size(380, 160);
            this.grpEvenements.TabIndex = 0;
            this.grpEvenements.TabStop = false;
            this.grpEvenements.Text = "Evénements du journal :";
            // 
            // flpAffichage
            // 
            this.flpAffichage.Controls.Add(this.lblDateEvenement);
            this.flpAffichage.Controls.Add(this.lblCommentaire);
            this.flpAffichage.Location = new System.Drawing.Point(15, 28);
            this.flpAffichage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpAffichage.Name = "flpAffichage";
            this.flpAffichage.Size = new System.Drawing.Size(335, 62);
            this.flpAffichage.TabIndex = 1;
            // 
            // lblDateEvenement
            // 
            this.lblDateEvenement.AutoSize = true;
            this.lblDateEvenement.Location = new System.Drawing.Point(2, 0);
            this.lblDateEvenement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateEvenement.Name = "lblDateEvenement";
            this.lblDateEvenement.Size = new System.Drawing.Size(0, 13);
            this.lblDateEvenement.TabIndex = 0;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(6, 0);
            this.lblCommentaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(0, 13);
            this.lblCommentaire.TabIndex = 1;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(254, 108);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(56, 28);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = ">>";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnAfter
            // 
            this.btnAfter.Location = new System.Drawing.Point(175, 108);
            this.btnAfter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(56, 28);
            this.btnAfter.TabIndex = 2;
            this.btnAfter.Text = ">";
            this.btnAfter.UseVisualStyleBackColor = true;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(99, 108);
            this.btnBefore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(56, 28);
            this.btnBefore.TabIndex = 1;
            this.btnBefore.Text = "<";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnDepart
            // 
            this.btnDepart.Location = new System.Drawing.Point(15, 108);
            this.btnDepart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(56, 28);
            this.btnDepart.TabIndex = 0;
            this.btnDepart.Text = "<<";
            this.btnDepart.UseVisualStyleBackColor = true;
            this.btnDepart.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.dgvContacts);
            this.grpContact.Location = new System.Drawing.Point(16, 298);
            this.grpContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpContact.Name = "grpContact";
            this.grpContact.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpContact.Size = new System.Drawing.Size(670, 193);
            this.grpContact.TabIndex = 1;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact avec les informateurs :";
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
            this.dgvContacts.Location = new System.Drawing.Point(15, 34);
            this.dgvContacts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersWidth = 51;
            this.dgvContacts.RowTemplate.Height = 24;
            this.dgvContacts.Size = new System.Drawing.Size(626, 135);
            this.dgvContacts.TabIndex = 0;
            // 
            // grpDepensesEffectues
            // 
            this.grpDepensesEffectues.Controls.Add(this.dgvDepenses);
            this.grpDepensesEffectues.Location = new System.Drawing.Point(734, 127);
            this.grpDepensesEffectues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDepensesEffectues.Name = "grpDepensesEffectues";
            this.grpDepensesEffectues.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDepensesEffectues.Size = new System.Drawing.Size(764, 365);
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
            this.dgvDepenses.Location = new System.Drawing.Point(24, 28);
            this.dgvDepenses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDepenses.Name = "dgvDepenses";
            this.dgvDepenses.ReadOnly = true;
            this.dgvDepenses.RowHeadersWidth = 51;
            this.dgvDepenses.RowTemplate.Height = 24;
            this.dgvDepenses.Size = new System.Drawing.Size(714, 305);
            this.dgvDepenses.TabIndex = 6;
            // 
            // lblTotSommes
            // 
            this.lblTotSommes.AutoSize = true;
            this.lblTotSommes.Location = new System.Drawing.Point(447, 193);
            this.lblTotSommes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotSommes.Name = "lblTotSommes";
            this.lblTotSommes.Size = new System.Drawing.Size(141, 13);
            this.lblTotSommes.TabIndex = 3;
            this.lblTotSommes.Text = "Total des sommes versées : ";
            // 
            // lblTotDepenses
            // 
            this.lblTotDepenses.AutoSize = true;
            this.lblTotDepenses.Location = new System.Drawing.Point(447, 222);
            this.lblTotDepenses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotDepenses.Name = "lblTotDepenses";
            this.lblTotDepenses.Size = new System.Drawing.Size(109, 13);
            this.lblTotDepenses.TabIndex = 4;
            this.lblTotDepenses.Text = "Total des dépenses : ";
            // 
            // btnEditerPDF
            // 
            this.btnEditerPDF.Location = new System.Drawing.Point(307, 245);
            this.btnEditerPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditerPDF.Name = "btnEditerPDF";
            this.btnEditerPDF.Size = new System.Drawing.Size(105, 19);
            this.btnEditerPDF.TabIndex = 5;
            this.btnEditerPDF.Text = "Editer un pdf";
            this.btnEditerPDF.UseVisualStyleBackColor = true;
            this.btnEditerPDF.Click += new System.EventHandler(this.btnEditerPDF_Click);
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
            this.dgvBilan.Location = new System.Drawing.Point(15, 36);
            this.dgvBilan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBilan.Name = "dgvBilan";
            this.dgvBilan.ReadOnly = true;
            this.dgvBilan.RowHeadersWidth = 51;
            this.dgvBilan.RowTemplate.Height = 24;
            this.dgvBilan.Size = new System.Drawing.Size(626, 297);
            this.dgvBilan.TabIndex = 6;
            // 
            // grpBilan
            // 
            this.grpBilan.Controls.Add(this.dgvBilan);
            this.grpBilan.Location = new System.Drawing.Point(16, 518);
            this.grpBilan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBilan.Name = "grpBilan";
            this.grpBilan.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBilan.Size = new System.Drawing.Size(670, 363);
            this.grpBilan.TabIndex = 7;
            this.grpBilan.TabStop = false;
            this.grpBilan.Text = "Bilan des captures : ";
            // 
            // flpGraphiques
            // 
            this.flpGraphiques.Location = new System.Drawing.Point(734, 554);
            this.flpGraphiques.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpGraphiques.Name = "flpGraphiques";
            this.flpGraphiques.Size = new System.Drawing.Size(764, 358);
            this.flpGraphiques.TabIndex = 10;
            // 
            // chartBudget
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBudget.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBudget.Legends.Add(legend1);
            this.chartBudget.Location = new System.Drawing.Point(16, 20);
            this.chartBudget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartBudget.Name = "chartBudget";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBudget.Series.Add(series1);
            this.chartBudget.Size = new System.Drawing.Size(265, 254);
            this.chartBudget.TabIndex = 11;
            this.chartBudget.Text = "chart1";
            // 
            // lblEtatBudget
            // 
            this.lblEtatBudget.AutoSize = true;
            this.lblEtatBudget.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEtatBudget.Location = new System.Drawing.Point(173, 222);
            this.lblEtatBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEtatBudget.Name = "lblEtatBudget";
            this.lblEtatBudget.Size = new System.Drawing.Size(0, 13);
            this.lblEtatBudget.TabIndex = 12;
            // 
            // lblStatsCaptures
            // 
            this.lblStatsCaptures.AutoSize = true;
            this.lblStatsCaptures.Location = new System.Drawing.Point(732, 518);
            this.lblStatsCaptures.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatsCaptures.Name = "lblStatsCaptures";
            this.lblStatsCaptures.Size = new System.Drawing.Size(129, 13);
            this.lblStatsCaptures.TabIndex = 14;
            this.lblStatsCaptures.Text = "Statistiques de captures : ";
            // 
            // FrmJournalDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1443, 862);
            this.Controls.Add(this.lblStatsCaptures);
            this.Controls.Add(this.lblEtatBudget);
            this.Controls.Add(this.flpGraphiques);
            this.Controls.Add(this.chartBudget);
            this.Controls.Add(this.grpBilan);
            this.Controls.Add(this.btnEditerPDF);
            this.Controls.Add(this.lblTotDepenses);
            this.Controls.Add(this.lblTotSommes);
            this.Controls.Add(this.grpDepensesEffectues);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpEvenements);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBudget;
        private System.Windows.Forms.Label lblEtatBudget;
        private System.Windows.Forms.Label lblStatsCaptures;
    }
}