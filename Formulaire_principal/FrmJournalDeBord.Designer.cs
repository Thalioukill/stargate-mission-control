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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpEvenements = new System.Windows.Forms.GroupBox();
            this.lblApres = new System.Windows.Forms.Label();
            this.lblAvant = new System.Windows.Forms.Label();
            this.lblNavigation = new System.Windows.Forms.Label();
            this.flpAffichage = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDateEvenement = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnAfter = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnDepart = new System.Windows.Forms.Button();
            this.grpDepensesEffectues = new System.Windows.Forms.GroupBox();
            this.lblBudgetInitial = new System.Windows.Forms.Label();
            this.lblBudgetActuel = new System.Windows.Forms.Label();
            this.rrdDepensesMax = new System.Windows.Forms.RadioButton();
            this.rdbListeDepenses = new System.Windows.Forms.RadioButton();
            this.dgvDepenses = new System.Windows.Forms.DataGridView();
            this.lblPasDeResultat = new System.Windows.Forms.Label();
            this.lblTotSommes = new System.Windows.Forms.Label();
            this.btnEditerPDF = new System.Windows.Forms.Button();
            this.dgvBilan = new System.Windows.Forms.DataGridView();
            this.grpBilan = new System.Windows.Forms.GroupBox();
            this.lblStatsCaptures = new System.Windows.Forms.Label();
            this.rdbCapturesEnnemies = new System.Windows.Forms.RadioButton();
            this.rdbRenta = new System.Windows.Forms.RadioButton();
            this.flpGraphiques = new System.Windows.Forms.FlowLayoutPanel();
            this.chartBudget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEtatBudget = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpInformateurs = new System.Windows.Forms.GroupBox();
            this.dgvInformateurs = new System.Windows.Forms.DataGridView();
            this.rdbInformateurMoinsPayees = new System.Windows.Forms.RadioButton();
            this.rdbInf = new System.Windows.Forms.RadioButton();
            this.lblFIN = new System.Windows.Forms.Label();
            this.errorProviderMembresMissions = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpEvenements.SuspendLayout();
            this.flpAffichage.SuspendLayout();
            this.grpDepensesEffectues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilan)).BeginInit();
            this.grpBilan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpInformateurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMembresMissions)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEvenements
            // 
            this.grpEvenements.Controls.Add(this.lblApres);
            this.grpEvenements.Controls.Add(this.lblAvant);
            this.grpEvenements.Controls.Add(this.lblNavigation);
            this.grpEvenements.Controls.Add(this.flpAffichage);
            this.grpEvenements.Controls.Add(this.btnEnd);
            this.grpEvenements.Controls.Add(this.btnAfter);
            this.grpEvenements.Controls.Add(this.btnBefore);
            this.grpEvenements.Controls.Add(this.btnDepart);
            this.grpEvenements.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEvenements.Location = new System.Drawing.Point(409, 24);
            this.grpEvenements.Name = "grpEvenements";
            this.grpEvenements.Size = new System.Drawing.Size(507, 259);
            this.grpEvenements.TabIndex = 0;
            this.grpEvenements.TabStop = false;
            this.grpEvenements.Text = "Evénements du journal :";
            // 
            // lblApres
            // 
            this.lblApres.AutoSize = true;
            this.lblApres.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApres.Location = new System.Drawing.Point(407, 43);
            this.lblApres.Name = "lblApres";
            this.lblApres.Size = new System.Drawing.Size(0, 24);
            this.lblApres.TabIndex = 6;
            // 
            // lblAvant
            // 
            this.lblAvant.AutoSize = true;
            this.lblAvant.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvant.Location = new System.Drawing.Point(232, 43);
            this.lblAvant.Name = "lblAvant";
            this.lblAvant.Size = new System.Drawing.Size(0, 24);
            this.lblAvant.TabIndex = 5;
            // 
            // lblNavigation
            // 
            this.lblNavigation.AutoSize = true;
            this.lblNavigation.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavigation.Location = new System.Drawing.Point(17, 43);
            this.lblNavigation.Name = "lblNavigation";
            this.lblNavigation.Size = new System.Drawing.Size(57, 24);
            this.lblNavigation.TabIndex = 4;
            this.lblNavigation.Text = "label1";
            // 
            // flpAffichage
            // 
            this.flpAffichage.Controls.Add(this.lblDateEvenement);
            this.flpAffichage.Controls.Add(this.lblCommentaire);
            this.flpAffichage.Location = new System.Drawing.Point(13, 85);
            this.flpAffichage.Name = "flpAffichage";
            this.flpAffichage.Size = new System.Drawing.Size(465, 101);
            this.flpAffichage.TabIndex = 1;
            // 
            // lblDateEvenement
            // 
            this.lblDateEvenement.AutoSize = true;
            this.lblDateEvenement.Location = new System.Drawing.Point(3, 0);
            this.lblDateEvenement.Name = "lblDateEvenement";
            this.lblDateEvenement.Size = new System.Drawing.Size(0, 28);
            this.lblDateEvenement.TabIndex = 0;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(9, 0);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(0, 28);
            this.lblCommentaire.TabIndex = 1;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(364, 201);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 34);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = ">>";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnAfter
            // 
            this.btnAfter.Location = new System.Drawing.Point(258, 201);
            this.btnAfter.Name = "btnAfter";
            this.btnAfter.Size = new System.Drawing.Size(75, 34);
            this.btnAfter.TabIndex = 2;
            this.btnAfter.Text = ">";
            this.btnAfter.UseVisualStyleBackColor = true;
            this.btnAfter.Click += new System.EventHandler(this.btnAfter_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Location = new System.Drawing.Point(157, 201);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(75, 34);
            this.btnBefore.TabIndex = 1;
            this.btnBefore.Text = "<";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnDepart
            // 
            this.btnDepart.Location = new System.Drawing.Point(45, 201);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(75, 34);
            this.btnDepart.TabIndex = 0;
            this.btnDepart.Text = "<<";
            this.btnDepart.UseVisualStyleBackColor = true;
            this.btnDepart.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // grpDepensesEffectues
            // 
            this.grpDepensesEffectues.Controls.Add(this.lblBudgetInitial);
            this.grpDepensesEffectues.Controls.Add(this.lblBudgetActuel);
            this.grpDepensesEffectues.Controls.Add(this.rrdDepensesMax);
            this.grpDepensesEffectues.Controls.Add(this.rdbListeDepenses);
            this.grpDepensesEffectues.Controls.Add(this.dgvDepenses);
            this.grpDepensesEffectues.Controls.Add(this.lblPasDeResultat);
            this.grpDepensesEffectues.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDepensesEffectues.Location = new System.Drawing.Point(11, 1160);
            this.grpDepensesEffectues.Name = "grpDepensesEffectues";
            this.grpDepensesEffectues.Size = new System.Drawing.Size(843, 427);
            this.grpDepensesEffectues.TabIndex = 2;
            this.grpDepensesEffectues.TabStop = false;
            this.grpDepensesEffectues.Text = "DEPENSES :";
            // 
            // lblBudgetInitial
            // 
            this.lblBudgetInitial.AutoSize = true;
            this.lblBudgetInitial.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetInitial.Location = new System.Drawing.Point(541, 31);
            this.lblBudgetInitial.Name = "lblBudgetInitial";
            this.lblBudgetInitial.Size = new System.Drawing.Size(157, 24);
            this.lblBudgetInitial.TabIndex = 9;
            this.lblBudgetInitial.Text = "★ Budget initial : ";
            this.lblBudgetInitial.Visible = false;
            // 
            // lblBudgetActuel
            // 
            this.lblBudgetActuel.AutoSize = true;
            this.lblBudgetActuel.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudgetActuel.Location = new System.Drawing.Point(541, 68);
            this.lblBudgetActuel.Name = "lblBudgetActuel";
            this.lblBudgetActuel.Size = new System.Drawing.Size(158, 24);
            this.lblBudgetActuel.TabIndex = 4;
            this.lblBudgetActuel.Text = "★ Budget actuel :";
            this.lblBudgetActuel.Visible = false;
            // 
            // rrdDepensesMax
            // 
            this.rrdDepensesMax.AutoSize = true;
            this.rrdDepensesMax.Location = new System.Drawing.Point(15, 125);
            this.rrdDepensesMax.Name = "rrdDepensesMax";
            this.rrdDepensesMax.Size = new System.Drawing.Size(585, 32);
            this.rrdDepensesMax.TabIndex = 8;
            this.rrdDepensesMax.Text = "Dépense maximale (comparaison avec les autres missions)";
            this.rrdDepensesMax.UseVisualStyleBackColor = true;
            this.rrdDepensesMax.CheckedChanged += new System.EventHandler(this.rrdDepensesMax_CheckedChanged);
            // 
            // rdbListeDepenses
            // 
            this.rdbListeDepenses.AutoSize = true;
            this.rdbListeDepenses.Checked = true;
            this.rdbListeDepenses.Location = new System.Drawing.Point(15, 60);
            this.rdbListeDepenses.Name = "rdbListeDepenses";
            this.rdbListeDepenses.Size = new System.Drawing.Size(344, 32);
            this.rdbListeDepenses.TabIndex = 7;
            this.rdbListeDepenses.TabStop = true;
            this.rdbListeDepenses.Text = "Liste des dépenses de la mission";
            this.rdbListeDepenses.UseVisualStyleBackColor = true;
            this.rdbListeDepenses.CheckedChanged += new System.EventHandler(this.rdbListeDepenses_CheckedChanged);
            // 
            // dgvDepenses
            // 
            this.dgvDepenses.AllowUserToAddRows = false;
            this.dgvDepenses.AllowUserToDeleteRows = false;
            this.dgvDepenses.AllowUserToResizeColumns = false;
            this.dgvDepenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDepenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDepenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDepenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepenses.Location = new System.Drawing.Point(15, 189);
            this.dgvDepenses.Name = "dgvDepenses";
            this.dgvDepenses.ReadOnly = true;
            this.dgvDepenses.RowHeadersWidth = 51;
            this.dgvDepenses.RowTemplate.Height = 24;
            this.dgvDepenses.Size = new System.Drawing.Size(819, 220);
            this.dgvDepenses.TabIndex = 6;
            // 
            // lblPasDeResultat
            // 
            this.lblPasDeResultat.AutoSize = true;
            this.lblPasDeResultat.Location = new System.Drawing.Point(305, 272);
            this.lblPasDeResultat.Name = "lblPasDeResultat";
            this.lblPasDeResultat.Size = new System.Drawing.Size(68, 28);
            this.lblPasDeResultat.TabIndex = 10;
            this.lblPasDeResultat.Text = "TEST";
            this.lblPasDeResultat.Visible = false;
            // 
            // lblTotSommes
            // 
            this.lblTotSommes.AutoSize = true;
            this.lblTotSommes.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotSommes.Location = new System.Drawing.Point(520, 31);
            this.lblTotSommes.Name = "lblTotSommes";
            this.lblTotSommes.Size = new System.Drawing.Size(259, 24);
            this.lblTotSommes.TabIndex = 3;
            this.lblTotSommes.Text = "★ Total des sommes versées : ";
            // 
            // btnEditerPDF
            // 
            this.btnEditerPDF.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditerPDF.Location = new System.Drawing.Point(409, 301);
            this.btnEditerPDF.Name = "btnEditerPDF";
            this.btnEditerPDF.Size = new System.Drawing.Size(179, 36);
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvBilan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBilan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBilan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilan.Location = new System.Drawing.Point(15, 144);
            this.dgvBilan.Name = "dgvBilan";
            this.dgvBilan.ReadOnly = true;
            this.dgvBilan.RowHeadersWidth = 51;
            this.dgvBilan.RowTemplate.Height = 24;
            this.dgvBilan.Size = new System.Drawing.Size(828, 265);
            this.dgvBilan.TabIndex = 6;
            // 
            // grpBilan
            // 
            this.grpBilan.Controls.Add(this.lblStatsCaptures);
            this.grpBilan.Controls.Add(this.rdbCapturesEnnemies);
            this.grpBilan.Controls.Add(this.rdbRenta);
            this.grpBilan.Controls.Add(this.dgvBilan);
            this.grpBilan.Controls.Add(this.flpGraphiques);
            this.grpBilan.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBilan.Location = new System.Drawing.Point(3, 391);
            this.grpBilan.Name = "grpBilan";
            this.grpBilan.Size = new System.Drawing.Size(862, 763);
            this.grpBilan.TabIndex = 7;
            this.grpBilan.TabStop = false;
            this.grpBilan.Text = "BILAN :";
            // 
            // lblStatsCaptures
            // 
            this.lblStatsCaptures.AutoSize = true;
            this.lblStatsCaptures.Location = new System.Drawing.Point(11, 434);
            this.lblStatsCaptures.Name = "lblStatsCaptures";
            this.lblStatsCaptures.Size = new System.Drawing.Size(269, 28);
            this.lblStatsCaptures.TabIndex = 14;
            this.lblStatsCaptures.Text = "Statistiques de captures : ";
            // 
            // rdbCapturesEnnemies
            // 
            this.rdbCapturesEnnemies.AutoSize = true;
            this.rdbCapturesEnnemies.Checked = true;
            this.rdbCapturesEnnemies.Location = new System.Drawing.Point(16, 42);
            this.rdbCapturesEnnemies.Name = "rdbCapturesEnnemies";
            this.rdbCapturesEnnemies.Size = new System.Drawing.Size(299, 32);
            this.rdbCapturesEnnemies.TabIndex = 8;
            this.rdbCapturesEnnemies.TabStop = true;
            this.rdbCapturesEnnemies.Text = "Captures espèces ennemies";
            this.rdbCapturesEnnemies.UseVisualStyleBackColor = true;
            this.rdbCapturesEnnemies.CheckedChanged += new System.EventHandler(this.rdbCapturesEnnemies_CheckedChanged);
            // 
            // rdbRenta
            // 
            this.rdbRenta.AutoSize = true;
            this.rdbRenta.Location = new System.Drawing.Point(16, 91);
            this.rdbRenta.Name = "rdbRenta";
            this.rdbRenta.Size = new System.Drawing.Size(241, 32);
            this.rdbRenta.TabIndex = 7;
            this.rdbRenta.Text = "Rentabilité (DataBaz)";
            this.rdbRenta.UseVisualStyleBackColor = true;
            this.rdbRenta.CheckedChanged += new System.EventHandler(this.rdbRenta_CheckedChanged);
            // 
            // flpGraphiques
            // 
            this.flpGraphiques.AutoScroll = true;
            this.flpGraphiques.Location = new System.Drawing.Point(8, 466);
            this.flpGraphiques.Name = "flpGraphiques";
            this.flpGraphiques.Size = new System.Drawing.Size(843, 291);
            this.flpGraphiques.TabIndex = 10;
            // 
            // chartBudget
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBudget.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBudget.Legends.Add(legend2);
            this.chartBudget.Location = new System.Drawing.Point(22, 24);
            this.chartBudget.Name = "chartBudget";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBudget.Series.Add(series2);
            this.chartBudget.Size = new System.Drawing.Size(353, 313);
            this.chartBudget.TabIndex = 11;
            this.chartBudget.Text = "chart1";
            // 
            // lblEtatBudget
            // 
            this.lblEtatBudget.AutoSize = true;
            this.lblEtatBudget.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEtatBudget.Location = new System.Drawing.Point(231, 273);
            this.lblEtatBudget.Name = "lblEtatBudget";
            this.lblEtatBudget.Size = new System.Drawing.Size(0, 16);
            this.lblEtatBudget.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.grpInformateurs);
            this.panel1.Controls.Add(this.lblFIN);
            this.panel1.Controls.Add(this.grpDepensesEffectues);
            this.panel1.Controls.Add(this.grpBilan);
            this.panel1.Location = new System.Drawing.Point(22, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 1074);
            this.panel1.TabIndex = 15;
            // 
            // grpInformateurs
            // 
            this.grpInformateurs.Controls.Add(this.dgvInformateurs);
            this.grpInformateurs.Controls.Add(this.rdbInformateurMoinsPayees);
            this.grpInformateurs.Controls.Add(this.rdbInf);
            this.grpInformateurs.Controls.Add(this.lblTotSommes);
            this.grpInformateurs.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformateurs.Location = new System.Drawing.Point(11, 19);
            this.grpInformateurs.Name = "grpInformateurs";
            this.grpInformateurs.Size = new System.Drawing.Size(854, 323);
            this.grpInformateurs.TabIndex = 18;
            this.grpInformateurs.TabStop = false;
            this.grpInformateurs.Text = "INFORMATEURS :";
            // 
            // dgvInformateurs
            // 
            this.dgvInformateurs.AllowUserToAddRows = false;
            this.dgvInformateurs.AllowUserToDeleteRows = false;
            this.dgvInformateurs.AllowUserToResizeColumns = false;
            this.dgvInformateurs.AllowUserToResizeRows = false;
            this.dgvInformateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInformateurs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInformateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformateurs.Location = new System.Drawing.Point(15, 121);
            this.dgvInformateurs.Name = "dgvInformateurs";
            this.dgvInformateurs.ReadOnly = true;
            this.dgvInformateurs.RowHeadersWidth = 51;
            this.dgvInformateurs.RowTemplate.Height = 24;
            this.dgvInformateurs.Size = new System.Drawing.Size(825, 187);
            this.dgvInformateurs.TabIndex = 0;
            // 
            // rdbInformateurMoinsPayees
            // 
            this.rdbInformateurMoinsPayees.AutoSize = true;
            this.rdbInformateurMoinsPayees.Location = new System.Drawing.Point(33, 70);
            this.rdbInformateurMoinsPayees.Name = "rdbInformateurMoinsPayees";
            this.rdbInformateurMoinsPayees.Size = new System.Drawing.Size(490, 32);
            this.rdbInformateurMoinsPayees.TabIndex = 1;
            this.rdbInformateurMoinsPayees.Text = "Informateur(s) le(s) moin(s) payé(s) de la mission ";
            this.rdbInformateurMoinsPayees.UseVisualStyleBackColor = true;
            this.rdbInformateurMoinsPayees.CheckedChanged += new System.EventHandler(this.rdbInformateursMoinsPayees_CheckedChanged);
            // 
            // rdbInf
            // 
            this.rdbInf.AutoSize = true;
            this.rdbInf.Checked = true;
            this.rdbInf.Location = new System.Drawing.Point(31, 36);
            this.rdbInf.Name = "rdbInf";
            this.rdbInf.Size = new System.Drawing.Size(316, 32);
            this.rdbInf.TabIndex = 0;
            this.rdbInf.TabStop = true;
            this.rdbInf.Text = "Contacts avec Informateurs ";
            this.rdbInf.UseVisualStyleBackColor = true;
            this.rdbInf.CheckedChanged += new System.EventHandler(this.rdbInf_CheckedChanged);
            // 
            // lblFIN
            // 
            this.lblFIN.AutoSize = true;
            this.lblFIN.Location = new System.Drawing.Point(819, 2646);
            this.lblFIN.Name = "lblFIN";
            this.lblFIN.Size = new System.Drawing.Size(28, 16);
            this.lblFIN.TabIndex = 15;
            this.lblFIN.Text = "FIN";
            // 
            // errorProviderMembresMissions
            // 
            this.errorProviderMembresMissions.ContainerControl = this;
            // 
            // FrmJournalDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(934, 1175);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEtatBudget);
            this.Controls.Add(this.chartBudget);
            this.Controls.Add(this.btnEditerPDF);
            this.Controls.Add(this.grpEvenements);
            this.Location = new System.Drawing.Point(670, 25);
            this.Name = "FrmJournalDeBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Journal de bord : ";
            this.Load += new System.EventHandler(this.FrmJournalDeBord_Load);
            this.grpEvenements.ResumeLayout(false);
            this.grpEvenements.PerformLayout();
            this.flpAffichage.ResumeLayout(false);
            this.flpAffichage.PerformLayout();
            this.grpDepensesEffectues.ResumeLayout(false);
            this.grpDepensesEffectues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilan)).EndInit();
            this.grpBilan.ResumeLayout(false);
            this.grpBilan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudget)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpInformateurs.ResumeLayout(false);
            this.grpInformateurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMembresMissions)).EndInit();
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
        private System.Windows.Forms.GroupBox grpDepensesEffectues;
        private System.Windows.Forms.Label lblTotSommes;
        private System.Windows.Forms.Label lblBudgetActuel;
        private System.Windows.Forms.Button btnEditerPDF;
        private System.Windows.Forms.Label lblDateEvenement;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.DataGridView dgvDepenses;
        private System.Windows.Forms.DataGridView dgvBilan;
        private System.Windows.Forms.GroupBox grpBilan;
        private System.Windows.Forms.FlowLayoutPanel flpGraphiques;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBudget;
        private System.Windows.Forms.Label lblEtatBudget;
        private System.Windows.Forms.Label lblStatsCaptures;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFIN;
        private System.Windows.Forms.GroupBox grpInformateurs;
        private System.Windows.Forms.RadioButton rdbInformateurMoinsPayees;
        private System.Windows.Forms.RadioButton rdbInf;
        private System.Windows.Forms.RadioButton rrdDepensesMax;
        private System.Windows.Forms.RadioButton rdbListeDepenses;
        private System.Windows.Forms.DataGridView dgvInformateurs;
        private System.Windows.Forms.RadioButton rdbCapturesEnnemies;
        private System.Windows.Forms.RadioButton rdbRenta;
        private System.Windows.Forms.Label lblNavigation;
        private System.Windows.Forms.Label lblApres;
        private System.Windows.Forms.Label lblAvant;
        private System.Windows.Forms.Label lblBudgetInitial;
        private System.Windows.Forms.ErrorProvider errorProviderMembresMissions;
        private System.Windows.Forms.Label lblPasDeResultat;
    }
}