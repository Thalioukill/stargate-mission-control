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
            this.components = new System.ComponentModel.Container();
            this.flpMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.plMissions = new System.Windows.Forms.Panel();
            this.grpFiltres = new System.Windows.Forms.GroupBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.lblBd = new System.Windows.Forms.Label();
            this.txtBudgetMax = new System.Windows.Forms.TextBox();
            this.lblPlanete = new System.Windows.Forms.Label();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.btnRAZ = new System.Windows.Forms.Button();
            this.cboChefMission = new System.Windows.Forms.ComboBox();
            this.lblChefMission = new System.Windows.Forms.Label();
            this.rdbAVenir = new System.Windows.Forms.RadioButton();
            this.rdbEnCours = new System.Windows.Forms.RadioButton();
            this.rdbPasse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiTableauDeBord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMission = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiPlanete = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiAliens = new System.Windows.Forms.ToolStripMenuItem();
            this.plAliens = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblErreur2 = new System.Windows.Forms.Label();
            this.flp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpAlliees = new System.Windows.Forms.GroupBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpFiltresEnnemis = new System.Windows.Forms.GroupBox();
            this.btnAgressivité = new System.Windows.Forms.Button();
            this.btnTypeArme = new System.Windows.Forms.Button();
            this.btnReinitialiserCouleurEnnemis = new System.Windows.Forms.Button();
            this.btnReinitialiserEnnemis = new System.Windows.Forms.Button();
            this.cboAgressivite = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTypeArme = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRechercherEnnemis = new System.Windows.Forms.Button();
            this.cboCouleurEnnemis = new System.Windows.Forms.ComboBox();
            this.txtNomEnnemis = new System.Windows.Forms.TextBox();
            this.grpFiltresAlliees = new System.Windows.Forms.GroupBox();
            this.btnReinitialiserBienveillance = new System.Windows.Forms.Button();
            this.btnReinitialiserCouleurAlliees = new System.Windows.Forms.Button();
            this.btnReinitialiserAlliees = new System.Windows.Forms.Button();
            this.cboBienveillance = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRechercherAlliees = new System.Windows.Forms.Button();
            this.cboCouleurAlliees = new System.Windows.Forms.ComboBox();
            this.txtNomAlliees = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.plMissions.SuspendLayout();
            this.grpFiltres.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.plAliens.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpAlliees.SuspendLayout();
            this.grpFiltresEnnemis.SuspendLayout();
            this.grpFiltresAlliees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMissions
            // 
            this.flpMissions.AutoScroll = true;
            this.flpMissions.Location = new System.Drawing.Point(15, 19);
            this.flpMissions.Margin = new System.Windows.Forms.Padding(2);
            this.flpMissions.Name = "flpMissions";
            this.flpMissions.Size = new System.Drawing.Size(1117, 453);
            this.flpMissions.TabIndex = 4;
            // 
            // plMissions
            // 
            this.plMissions.Controls.Add(this.grpFiltres);
            this.plMissions.Controls.Add(this.flpMissions);
            this.plMissions.Location = new System.Drawing.Point(227, 36);
            this.plMissions.Margin = new System.Windows.Forms.Padding(2);
            this.plMissions.Name = "plMissions";
            this.plMissions.Size = new System.Drawing.Size(1199, 736);
            this.plMissions.TabIndex = 0;
            // 
            // grpFiltres
            // 
            this.grpFiltres.Controls.Add(this.btnRecherche);
            this.grpFiltres.Controls.Add(this.lblBd);
            this.grpFiltres.Controls.Add(this.txtBudgetMax);
            this.grpFiltres.Controls.Add(this.lblPlanete);
            this.grpFiltres.Controls.Add(this.cboPlanete);
            this.grpFiltres.Controls.Add(this.btnRAZ);
            this.grpFiltres.Controls.Add(this.cboChefMission);
            this.grpFiltres.Controls.Add(this.lblChefMission);
            this.grpFiltres.Controls.Add(this.rdbAVenir);
            this.grpFiltres.Controls.Add(this.rdbEnCours);
            this.grpFiltres.Controls.Add(this.rdbPasse);
            this.grpFiltres.Controls.Add(this.label1);
            this.grpFiltres.Location = new System.Drawing.Point(15, 488);
            this.grpFiltres.Margin = new System.Windows.Forms.Padding(2);
            this.grpFiltres.Name = "grpFiltres";
            this.grpFiltres.Padding = new System.Windows.Forms.Padding(2);
            this.grpFiltres.Size = new System.Drawing.Size(1117, 92);
            this.grpFiltres.TabIndex = 5;
            this.grpFiltres.TabStop = false;
            this.grpFiltres.Text = "Filtres";
            // 
            // btnRecherche
            // 
            this.btnRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecherche.Location = new System.Drawing.Point(835, 23);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 28);
            this.btnRecherche.TabIndex = 12;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // lblBd
            // 
            this.lblBd.AutoSize = true;
            this.lblBd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBd.Location = new System.Drawing.Point(643, 28);
            this.lblBd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBd.Name = "lblBd";
            this.lblBd.Size = new System.Drawing.Size(93, 13);
            this.lblBd.TabIndex = 11;
            this.lblBd.Text = "Budget maximum :";
            // 
            // txtBudgetMax
            // 
            this.txtBudgetMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBudgetMax.Location = new System.Drawing.Point(645, 56);
            this.txtBudgetMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtBudgetMax.Name = "txtBudgetMax";
            this.txtBudgetMax.Size = new System.Drawing.Size(114, 20);
            this.txtBudgetMax.TabIndex = 9;
            this.txtBudgetMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBudgetMax_KeyPress);
            // 
            // lblPlanete
            // 
            this.lblPlanete.AutoSize = true;
            this.lblPlanete.Location = new System.Drawing.Point(442, 28);
            this.lblPlanete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(49, 13);
            this.lblPlanete.TabIndex = 8;
            this.lblPlanete.Text = "Planète :";
            // 
            // cboPlanete
            // 
            this.cboPlanete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPlanete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlanete.FormattingEnabled = true;
            this.cboPlanete.Location = new System.Drawing.Point(444, 54);
            this.cboPlanete.Margin = new System.Windows.Forms.Padding(2);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(144, 21);
            this.cboPlanete.TabIndex = 7;
            // 
            // btnRAZ
            // 
            this.btnRAZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRAZ.Location = new System.Drawing.Point(835, 56);
            this.btnRAZ.Margin = new System.Windows.Forms.Padding(2);
            this.btnRAZ.Name = "btnRAZ";
            this.btnRAZ.Size = new System.Drawing.Size(75, 28);
            this.btnRAZ.TabIndex = 6;
            this.btnRAZ.Text = "Reset";
            this.btnRAZ.UseVisualStyleBackColor = true;
            this.btnRAZ.Click += new System.EventHandler(this.btnRAZ_Click);
            // 
            // cboChefMission
            // 
            this.cboChefMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboChefMission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChefMission.FormattingEnabled = true;
            this.cboChefMission.Location = new System.Drawing.Point(249, 54);
            this.cboChefMission.Margin = new System.Windows.Forms.Padding(2);
            this.cboChefMission.Name = "cboChefMission";
            this.cboChefMission.Size = new System.Drawing.Size(144, 21);
            this.cboChefMission.TabIndex = 5;
            // 
            // lblChefMission
            // 
            this.lblChefMission.AutoSize = true;
            this.lblChefMission.Location = new System.Drawing.Point(247, 28);
            this.lblChefMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChefMission.Name = "lblChefMission";
            this.lblChefMission.Size = new System.Drawing.Size(87, 13);
            this.lblChefMission.TabIndex = 4;
            this.lblChefMission.Text = "Chef de mission :";
            // 
            // rdbAVenir
            // 
            this.rdbAVenir.AutoSize = true;
            this.rdbAVenir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAVenir.Location = new System.Drawing.Point(121, 67);
            this.rdbAVenir.Margin = new System.Windows.Forms.Padding(2);
            this.rdbAVenir.Name = "rdbAVenir";
            this.rdbAVenir.Size = new System.Drawing.Size(58, 17);
            this.rdbAVenir.TabIndex = 3;
            this.rdbAVenir.Text = "À venir";
            this.rdbAVenir.UseVisualStyleBackColor = true;
            // 
            // rdbEnCours
            // 
            this.rdbEnCours.AutoSize = true;
            this.rdbEnCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbEnCours.Location = new System.Drawing.Point(121, 46);
            this.rdbEnCours.Margin = new System.Windows.Forms.Padding(2);
            this.rdbEnCours.Name = "rdbEnCours";
            this.rdbEnCours.Size = new System.Drawing.Size(67, 17);
            this.rdbEnCours.TabIndex = 2;
            this.rdbEnCours.Text = "En cours";
            this.rdbEnCours.UseVisualStyleBackColor = true;
            // 
            // rdbPasse
            // 
            this.rdbPasse.AutoSize = true;
            this.rdbPasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbPasse.Location = new System.Drawing.Point(121, 25);
            this.rdbPasse.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPasse.Name = "rdbPasse";
            this.rdbPasse.Size = new System.Drawing.Size(65, 17);
            this.rdbPasse.TabIndex = 1;
            this.rdbPasse.Text = "Passées";
            this.rdbPasse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statut des missions : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTableauDeBord,
            this.tsmiMission,
            this.tmsiPlanete,
            this.tmsiAliens});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(150, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(172, 823);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTableauDeBord
            // 
            this.tsmiTableauDeBord.Margin = new System.Windows.Forms.Padding(25, 50, 2, 1);
            this.tsmiTableauDeBord.Name = "tsmiTableauDeBord";
            this.tsmiTableauDeBord.Size = new System.Drawing.Size(104, 19);
            this.tsmiTableauDeBord.Text = "Tableau de bord";
            this.tsmiTableauDeBord.Click += new System.EventHandler(this.tsmiTableauDeBord_Click);
            // 
            // tsmiMission
            // 
            this.tsmiMission.Margin = new System.Windows.Forms.Padding(25, 50, 2, 1);
            this.tsmiMission.Name = "tsmiMission";
            this.tsmiMission.Size = new System.Drawing.Size(141, 19);
            this.tsmiMission.Text = "Création d\'une mission";
            // 
            // tmsiPlanete
            // 
            this.tmsiPlanete.Margin = new System.Windows.Forms.Padding(25, 50, 2, 1);
            this.tmsiPlanete.Name = "tmsiPlanete";
            this.tmsiPlanete.Size = new System.Drawing.Size(63, 19);
            this.tmsiPlanete.Text = "Planètes";
            // 
            // tmsiAliens
            // 
            this.tmsiAliens.Margin = new System.Windows.Forms.Padding(25, 50, 2, 1);
            this.tmsiAliens.Name = "tmsiAliens";
            this.tmsiAliens.Size = new System.Drawing.Size(51, 19);
            this.tmsiAliens.Text = "Aliens";
            this.tmsiAliens.Click += new System.EventHandler(this.tmsiAliens_Click);
            // 
            // plAliens
            // 
            this.plAliens.Controls.Add(this.groupBox3);
            this.plAliens.Controls.Add(this.grpAlliees);
            this.plAliens.Controls.Add(this.grpFiltresEnnemis);
            this.plAliens.Controls.Add(this.grpFiltresAlliees);
            this.plAliens.Location = new System.Drawing.Point(227, 36);
            this.plAliens.Margin = new System.Windows.Forms.Padding(2);
            this.plAliens.Name = "plAliens";
            this.plAliens.Size = new System.Drawing.Size(1199, 736);
            this.plAliens.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblErreur2);
            this.groupBox3.Controls.Add(this.flp2);
            this.groupBox3.Location = new System.Drawing.Point(586, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 370);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informations sur les races ennemis";
            // 
            // lblErreur2
            // 
            this.lblErreur2.AutoSize = true;
            this.lblErreur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur2.Location = new System.Drawing.Point(55, 175);
            this.lblErreur2.Name = "lblErreur2";
            this.lblErreur2.Size = new System.Drawing.Size(311, 17);
            this.lblErreur2.TabIndex = 1;
            this.lblErreur2.Text = "Aucun résultat ne correspond à votre recherche";
            this.lblErreur2.Visible = false;
            // 
            // flp2
            // 
            this.flp2.AutoScroll = true;
            this.flp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp2.Location = new System.Drawing.Point(3, 16);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(406, 351);
            this.flp2.TabIndex = 0;
            // 
            // grpAlliees
            // 
            this.grpAlliees.Controls.Add(this.lblErreur);
            this.grpAlliees.Controls.Add(this.flp1);
            this.grpAlliees.Location = new System.Drawing.Point(73, 41);
            this.grpAlliees.Name = "grpAlliees";
            this.grpAlliees.Size = new System.Drawing.Size(401, 370);
            this.grpAlliees.TabIndex = 5;
            this.grpAlliees.TabStop = false;
            this.grpAlliees.Text = "Informations sur les races alliées";
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.Location = new System.Drawing.Point(55, 175);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(311, 17);
            this.lblErreur.TabIndex = 0;
            this.lblErreur.Text = "Aucun résultat ne correspond à votre recherche";
            this.lblErreur.Visible = false;
            // 
            // flp1
            // 
            this.flp1.AutoScroll = true;
            this.flp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp1.Location = new System.Drawing.Point(3, 16);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(395, 351);
            this.flp1.TabIndex = 0;
            // 
            // grpFiltresEnnemis
            // 
            this.grpFiltresEnnemis.Controls.Add(this.btnAgressivité);
            this.grpFiltresEnnemis.Controls.Add(this.btnTypeArme);
            this.grpFiltresEnnemis.Controls.Add(this.btnReinitialiserCouleurEnnemis);
            this.grpFiltresEnnemis.Controls.Add(this.btnReinitialiserEnnemis);
            this.grpFiltresEnnemis.Controls.Add(this.cboAgressivite);
            this.grpFiltresEnnemis.Controls.Add(this.label6);
            this.grpFiltresEnnemis.Controls.Add(this.label8);
            this.grpFiltresEnnemis.Controls.Add(this.cboTypeArme);
            this.grpFiltresEnnemis.Controls.Add(this.label9);
            this.grpFiltresEnnemis.Controls.Add(this.label10);
            this.grpFiltresEnnemis.Controls.Add(this.btnRechercherEnnemis);
            this.grpFiltresEnnemis.Controls.Add(this.cboCouleurEnnemis);
            this.grpFiltresEnnemis.Controls.Add(this.txtNomEnnemis);
            this.grpFiltresEnnemis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltresEnnemis.Location = new System.Drawing.Point(586, 418);
            this.grpFiltresEnnemis.Name = "grpFiltresEnnemis";
            this.grpFiltresEnnemis.Size = new System.Drawing.Size(412, 223);
            this.grpFiltresEnnemis.TabIndex = 6;
            this.grpFiltresEnnemis.TabStop = false;
            this.grpFiltresEnnemis.Text = "Filtres";
            // 
            // btnAgressivité
            // 
            this.btnAgressivité.Location = new System.Drawing.Point(183, 178);
            this.btnAgressivité.Name = "btnAgressivité";
            this.btnAgressivité.Size = new System.Drawing.Size(181, 34);
            this.btnAgressivité.TabIndex = 15;
            this.btnAgressivité.Text = "Réinitialiser agressivité";
            this.btnAgressivité.UseVisualStyleBackColor = true;
            this.btnAgressivité.Click += new System.EventHandler(this.btnAgressivité_Click);
            // 
            // btnTypeArme
            // 
            this.btnTypeArme.Location = new System.Drawing.Point(183, 125);
            this.btnTypeArme.Name = "btnTypeArme";
            this.btnTypeArme.Size = new System.Drawing.Size(181, 34);
            this.btnTypeArme.TabIndex = 14;
            this.btnTypeArme.Text = "Réinitialiser type arme";
            this.btnTypeArme.UseVisualStyleBackColor = true;
            this.btnTypeArme.Click += new System.EventHandler(this.btnTypeArme_Click);
            // 
            // btnReinitialiserCouleurEnnemis
            // 
            this.btnReinitialiserCouleurEnnemis.Location = new System.Drawing.Point(183, 77);
            this.btnReinitialiserCouleurEnnemis.Name = "btnReinitialiserCouleurEnnemis";
            this.btnReinitialiserCouleurEnnemis.Size = new System.Drawing.Size(181, 34);
            this.btnReinitialiserCouleurEnnemis.TabIndex = 14;
            this.btnReinitialiserCouleurEnnemis.Text = "Réinitialiser couleur";
            this.btnReinitialiserCouleurEnnemis.UseVisualStyleBackColor = true;
            this.btnReinitialiserCouleurEnnemis.Click += new System.EventHandler(this.btnReinitialiserCouleurEnnemis_Click);
            // 
            // btnReinitialiserEnnemis
            // 
            this.btnReinitialiserEnnemis.Location = new System.Drawing.Point(292, 20);
            this.btnReinitialiserEnnemis.Name = "btnReinitialiserEnnemis";
            this.btnReinitialiserEnnemis.Size = new System.Drawing.Size(116, 44);
            this.btnReinitialiserEnnemis.TabIndex = 12;
            this.btnReinitialiserEnnemis.Text = "Tout réinitialiser";
            this.btnReinitialiserEnnemis.UseVisualStyleBackColor = true;
            this.btnReinitialiserEnnemis.Click += new System.EventHandler(this.btnReinitialiserEnnemis_Click);
            // 
            // cboAgressivite
            // 
            this.cboAgressivite.FormattingEnabled = true;
            this.cboAgressivite.Location = new System.Drawing.Point(8, 184);
            this.cboAgressivite.Name = "cboAgressivite";
            this.cboAgressivite.Size = new System.Drawing.Size(169, 24);
            this.cboAgressivite.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Agressivité";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Type arme";
            // 
            // cboTypeArme
            // 
            this.cboTypeArme.FormattingEnabled = true;
            this.cboTypeArme.Location = new System.Drawing.Point(8, 135);
            this.cboTypeArme.Name = "cboTypeArme";
            this.cboTypeArme.Size = new System.Drawing.Size(169, 24);
            this.cboTypeArme.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Couleur";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nom (like)";
            // 
            // btnRechercherEnnemis
            // 
            this.btnRechercherEnnemis.Location = new System.Drawing.Point(183, 20);
            this.btnRechercherEnnemis.Name = "btnRechercherEnnemis";
            this.btnRechercherEnnemis.Size = new System.Drawing.Size(104, 44);
            this.btnRechercherEnnemis.TabIndex = 2;
            this.btnRechercherEnnemis.Text = "Rechercher";
            this.btnRechercherEnnemis.UseVisualStyleBackColor = true;
            this.btnRechercherEnnemis.Click += new System.EventHandler(this.btnRechercherEnnemis_Click);
            // 
            // cboCouleurEnnemis
            // 
            this.cboCouleurEnnemis.FormattingEnabled = true;
            this.cboCouleurEnnemis.Location = new System.Drawing.Point(8, 88);
            this.cboCouleurEnnemis.Name = "cboCouleurEnnemis";
            this.cboCouleurEnnemis.Size = new System.Drawing.Size(169, 24);
            this.cboCouleurEnnemis.TabIndex = 1;
            // 
            // txtNomEnnemis
            // 
            this.txtNomEnnemis.Location = new System.Drawing.Point(8, 41);
            this.txtNomEnnemis.Name = "txtNomEnnemis";
            this.txtNomEnnemis.Size = new System.Drawing.Size(169, 23);
            this.txtNomEnnemis.TabIndex = 0;
            // 
            // grpFiltresAlliees
            // 
            this.grpFiltresAlliees.Controls.Add(this.btnReinitialiserBienveillance);
            this.grpFiltresAlliees.Controls.Add(this.btnReinitialiserCouleurAlliees);
            this.grpFiltresAlliees.Controls.Add(this.btnReinitialiserAlliees);
            this.grpFiltresAlliees.Controls.Add(this.cboBienveillance);
            this.grpFiltresAlliees.Controls.Add(this.label4);
            this.grpFiltresAlliees.Controls.Add(this.label2);
            this.grpFiltresAlliees.Controls.Add(this.label3);
            this.grpFiltresAlliees.Controls.Add(this.btnRechercherAlliees);
            this.grpFiltresAlliees.Controls.Add(this.cboCouleurAlliees);
            this.grpFiltresAlliees.Controls.Add(this.txtNomAlliees);
            this.grpFiltresAlliees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltresAlliees.Location = new System.Drawing.Point(73, 414);
            this.grpFiltresAlliees.Name = "grpFiltresAlliees";
            this.grpFiltresAlliees.Size = new System.Drawing.Size(401, 177);
            this.grpFiltresAlliees.TabIndex = 4;
            this.grpFiltresAlliees.TabStop = false;
            this.grpFiltresAlliees.Text = "Filtres";
            // 
            // btnReinitialiserBienveillance
            // 
            this.btnReinitialiserBienveillance.Location = new System.Drawing.Point(180, 128);
            this.btnReinitialiserBienveillance.Name = "btnReinitialiserBienveillance";
            this.btnReinitialiserBienveillance.Size = new System.Drawing.Size(181, 34);
            this.btnReinitialiserBienveillance.TabIndex = 13;
            this.btnReinitialiserBienveillance.Text = "Réinitialiser bienveillance";
            this.btnReinitialiserBienveillance.UseVisualStyleBackColor = true;
            this.btnReinitialiserBienveillance.Click += new System.EventHandler(this.btnReinitialiserBienveillance_Click);
            // 
            // btnReinitialiserCouleurAlliees
            // 
            this.btnReinitialiserCouleurAlliees.Location = new System.Drawing.Point(180, 80);
            this.btnReinitialiserCouleurAlliees.Name = "btnReinitialiserCouleurAlliees";
            this.btnReinitialiserCouleurAlliees.Size = new System.Drawing.Size(181, 34);
            this.btnReinitialiserCouleurAlliees.TabIndex = 12;
            this.btnReinitialiserCouleurAlliees.Text = "Réinitialiser couleur";
            this.btnReinitialiserCouleurAlliees.UseVisualStyleBackColor = true;
            this.btnReinitialiserCouleurAlliees.Click += new System.EventHandler(this.btnReinitialiserCouleurAlliees_Click);
            // 
            // btnReinitialiserAlliees
            // 
            this.btnReinitialiserAlliees.Location = new System.Drawing.Point(284, 18);
            this.btnReinitialiserAlliees.Name = "btnReinitialiserAlliees";
            this.btnReinitialiserAlliees.Size = new System.Drawing.Size(112, 45);
            this.btnReinitialiserAlliees.TabIndex = 11;
            this.btnReinitialiserAlliees.Text = "Tout réinitialiser";
            this.btnReinitialiserAlliees.UseVisualStyleBackColor = true;
            this.btnReinitialiserAlliees.Click += new System.EventHandler(this.btnReinitialiserAlliees_Click);
            // 
            // cboBienveillance
            // 
            this.cboBienveillance.FormattingEnabled = true;
            this.cboBienveillance.Location = new System.Drawing.Point(6, 134);
            this.cboBienveillance.Name = "cboBienveillance";
            this.cboBienveillance.Size = new System.Drawing.Size(169, 24);
            this.cboBienveillance.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bienveillance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Couleur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom (like)";
            // 
            // btnRechercherAlliees
            // 
            this.btnRechercherAlliees.Location = new System.Drawing.Point(180, 20);
            this.btnRechercherAlliees.Name = "btnRechercherAlliees";
            this.btnRechercherAlliees.Size = new System.Drawing.Size(104, 44);
            this.btnRechercherAlliees.TabIndex = 2;
            this.btnRechercherAlliees.Text = "Rechercher";
            this.btnRechercherAlliees.UseVisualStyleBackColor = true;
            this.btnRechercherAlliees.Click += new System.EventHandler(this.btnRechercherAlliees_Click);
            // 
            // cboCouleurAlliees
            // 
            this.cboCouleurAlliees.FormattingEnabled = true;
            this.cboCouleurAlliees.Location = new System.Drawing.Point(6, 86);
            this.cboCouleurAlliees.Name = "cboCouleurAlliees";
            this.cboCouleurAlliees.Size = new System.Drawing.Size(169, 24);
            this.cboCouleurAlliees.TabIndex = 1;
            // 
            // txtNomAlliees
            // 
            this.txtNomAlliees.Location = new System.Drawing.Point(6, 40);
            this.txtNomAlliees.Name = "txtNomAlliees";
            this.txtNomAlliees.Size = new System.Drawing.Size(169, 23);
            this.txtNomAlliees.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1443, 823);
            this.Controls.Add(this.plAliens);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.plMissions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil Stargate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plMissions.ResumeLayout(false);
            this.grpFiltres.ResumeLayout(false);
            this.grpFiltres.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.plAliens.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpAlliees.ResumeLayout(false);
            this.grpAlliees.PerformLayout();
            this.grpFiltresEnnemis.ResumeLayout(false);
            this.grpFiltresEnnemis.PerformLayout();
            this.grpFiltresAlliees.ResumeLayout(false);
            this.grpFiltresAlliees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpMissions;
        private System.Windows.Forms.Panel plMissions;
        private System.Windows.Forms.GroupBox grpFiltres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChefMission;
        private System.Windows.Forms.Label lblChefMission;
        private System.Windows.Forms.RadioButton rdbAVenir;
        private System.Windows.Forms.RadioButton rdbEnCours;
        private System.Windows.Forms.RadioButton rdbPasse;
        private System.Windows.Forms.Label lblPlanete;
        private System.Windows.Forms.ComboBox cboPlanete;
        private System.Windows.Forms.Button btnRAZ;
        private System.Windows.Forms.Label lblBd;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox txtBudgetMax;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTableauDeBord;
        private System.Windows.Forms.ToolStripMenuItem tsmiMission;
        private System.Windows.Forms.ToolStripMenuItem tmsiPlanete;
        private System.Windows.Forms.ToolStripMenuItem tmsiAliens;
        private System.Windows.Forms.Panel plAliens;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flp2;
        private System.Windows.Forms.GroupBox grpAlliees;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.GroupBox grpFiltresEnnemis;
        private System.Windows.Forms.Button btnAgressivité;
        private System.Windows.Forms.Button btnTypeArme;
        private System.Windows.Forms.Button btnReinitialiserCouleurEnnemis;
        private System.Windows.Forms.Button btnReinitialiserEnnemis;
        private System.Windows.Forms.ComboBox cboAgressivite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTypeArme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRechercherEnnemis;
        private System.Windows.Forms.ComboBox cboCouleurEnnemis;
        private System.Windows.Forms.TextBox txtNomEnnemis;
        private System.Windows.Forms.GroupBox grpFiltresAlliees;
        private System.Windows.Forms.Button btnReinitialiserBienveillance;
        private System.Windows.Forms.Button btnReinitialiserCouleurAlliees;
        private System.Windows.Forms.Button btnReinitialiserAlliees;
        private System.Windows.Forms.ComboBox cboBienveillance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRechercherAlliees;
        private System.Windows.Forms.ComboBox cboCouleurAlliees;
        private System.Windows.Forms.TextBox txtNomAlliees;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Label lblErreur2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

