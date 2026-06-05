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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.flpMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.plMissions = new System.Windows.Forms.Panel();
            this.grpNbMissionsTrouvees = new System.Windows.Forms.GroupBox();
            this.grpFiltres = new System.Windows.Forms.GroupBox();
            this.btnValiderNbJoursMission = new System.Windows.Forms.Button();
            this.btnValiderNbJoursMin = new System.Windows.Forms.Button();
            this.rdbRAZ = new System.Windows.Forms.RadioButton();
            this.lblNbMission = new System.Windows.Forms.Label();
            this.nupNbMissions = new System.Windows.Forms.NumericUpDown();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.lblBd = new System.Windows.Forms.Label();
            this.txtBudgetMin = new System.Windows.Forms.TextBox();
            this.lblPlanete = new System.Windows.Forms.Label();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.btnRAZ = new System.Windows.Forms.Button();
            this.cboChefMission = new System.Windows.Forms.ComboBox();
            this.lblChefMission = new System.Windows.Forms.Label();
            this.rdbAVenir = new System.Windows.Forms.RadioButton();
            this.rdbEnCours = new System.Windows.Forms.RadioButton();
            this.rdbPasse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTableauDeBord = new System.Windows.Forms.Label();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiTableauDeBord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMission = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiPlanete = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiAliens = new System.Windows.Forms.ToolStripMenuItem();
            this.plPlanetes = new System.Windows.Forms.Panel();
            this.grpPlanetes = new System.Windows.Forms.GroupBox();
            this.lblErreur3 = new System.Windows.Forms.Label();
            this.flpPlanete = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPlanetes = new System.Windows.Forms.Label();
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.grpEspeces = new System.Windows.Forms.GroupBox();
            this.flpEspece = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReinitialiserEspeces = new System.Windows.Forms.Button();
            this.btnReinitialiserDataBaz = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.txtMaxMission = new System.Windows.Forms.TextBox();
            this.txtMinMission = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbSans = new System.Windows.Forms.RadioButton();
            this.rdbAvec = new System.Windows.Forms.RadioButton();
            this.txtMaxGrav = new System.Windows.Forms.TextBox();
            this.txtMinGrav = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.plAliens = new System.Windows.Forms.Panel();
            this.lblAliens = new System.Windows.Forms.Label();
            this.grpFiltresAlliees = new System.Windows.Forms.GroupBox();
            this.btnReinitialiserAlliees = new System.Windows.Forms.Button();
            this.cboBienveillance = new System.Windows.Forms.ComboBox();
            this.btnRechercherAlliees = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCouleurAlliees = new System.Windows.Forms.ComboBox();
            this.txtNomAlliees = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblErreur2 = new System.Windows.Forms.Label();
            this.flp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpAlliees = new System.Windows.Forms.GroupBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpFiltresEnnemis = new System.Windows.Forms.GroupBox();
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
            this.ttRAZ = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlProgressBar = new System.Windows.Forms.Panel();
            this.plBoiteChargement = new System.Windows.Forms.Panel();
            this.plChargement = new System.Windows.Forms.Panel();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblPourcentage = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ttBudgetMin = new System.Windows.Forms.ToolTip(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.plMissions.SuspendLayout();
            this.grpNbMissionsTrouvees.SuspendLayout();
            this.grpFiltres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbMissions)).BeginInit();
            this.msMenu.SuspendLayout();
            this.plPlanetes.SuspendLayout();
            this.grpPlanetes.SuspendLayout();
            this.grpFiltre.SuspendLayout();
            this.grpEspeces.SuspendLayout();
            this.plAliens.SuspendLayout();
            this.grpFiltresAlliees.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpAlliees.SuspendLayout();
            this.grpFiltresEnnemis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlProgressBar.SuspendLayout();
            this.plBoiteChargement.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMissions
            // 
            this.flpMissions.AutoScroll = true;
            this.flpMissions.Location = new System.Drawing.Point(13, 40);
            this.flpMissions.Margin = new System.Windows.Forms.Padding(4);
            this.flpMissions.Name = "flpMissions";
            this.flpMissions.Size = new System.Drawing.Size(1427, 493);
            this.flpMissions.TabIndex = 4;
            // 
            // plMissions
            // 
            this.plMissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.plMissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMissions.Controls.Add(this.grpNbMissionsTrouvees);
            this.plMissions.Controls.Add(this.grpFiltres);
            this.plMissions.Controls.Add(this.lblTableauDeBord);
            this.plMissions.Location = new System.Drawing.Point(376, 27);
            this.plMissions.Margin = new System.Windows.Forms.Padding(4);
            this.plMissions.Name = "plMissions";
            this.plMissions.Size = new System.Drawing.Size(1521, 975);
            this.plMissions.TabIndex = 0;
            // 
            // grpNbMissionsTrouvees
            // 
            this.grpNbMissionsTrouvees.Controls.Add(this.flpMissions);
            this.grpNbMissionsTrouvees.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNbMissionsTrouvees.Location = new System.Drawing.Point(27, 397);
            this.grpNbMissionsTrouvees.Name = "grpNbMissionsTrouvees";
            this.grpNbMissionsTrouvees.Size = new System.Drawing.Size(1448, 552);
            this.grpNbMissionsTrouvees.TabIndex = 7;
            this.grpNbMissionsTrouvees.TabStop = false;
            this.grpNbMissionsTrouvees.Text = "Nombre de missions trouvées : ";
            // 
            // grpFiltres
            // 
            this.grpFiltres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.grpFiltres.Controls.Add(this.label15);
            this.grpFiltres.Controls.Add(this.btnValiderNbJoursMission);
            this.grpFiltres.Controls.Add(this.btnValiderNbJoursMin);
            this.grpFiltres.Controls.Add(this.rdbRAZ);
            this.grpFiltres.Controls.Add(this.lblNbMission);
            this.grpFiltres.Controls.Add(this.nupNbMissions);
            this.grpFiltres.Controls.Add(this.btnRecherche);
            this.grpFiltres.Controls.Add(this.lblBd);
            this.grpFiltres.Controls.Add(this.txtBudgetMin);
            this.grpFiltres.Controls.Add(this.lblPlanete);
            this.grpFiltres.Controls.Add(this.cboPlanete);
            this.grpFiltres.Controls.Add(this.btnRAZ);
            this.grpFiltres.Controls.Add(this.cboChefMission);
            this.grpFiltres.Controls.Add(this.lblChefMission);
            this.grpFiltres.Controls.Add(this.rdbAVenir);
            this.grpFiltres.Controls.Add(this.rdbEnCours);
            this.grpFiltres.Controls.Add(this.rdbPasse);
            this.grpFiltres.Controls.Add(this.label1);
            this.grpFiltres.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltres.Location = new System.Drawing.Point(27, 104);
            this.grpFiltres.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltres.Name = "grpFiltres";
            this.grpFiltres.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltres.Size = new System.Drawing.Size(1448, 267);
            this.grpFiltres.TabIndex = 5;
            this.grpFiltres.TabStop = false;
            this.grpFiltres.Text = "Filtres";
            // 
            // btnValiderNbJoursMission
            // 
            this.btnValiderNbJoursMission.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnValiderNbJoursMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValiderNbJoursMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderNbJoursMission.Location = new System.Drawing.Point(1204, 163);
            this.btnValiderNbJoursMission.Margin = new System.Windows.Forms.Padding(5);
            this.btnValiderNbJoursMission.Name = "btnValiderNbJoursMission";
            this.btnValiderNbJoursMission.Size = new System.Drawing.Size(41, 40);
            this.btnValiderNbJoursMission.TabIndex = 17;
            this.btnValiderNbJoursMission.UseVisualStyleBackColor = true;
            this.btnValiderNbJoursMission.Click += new System.EventHandler(this.btnValiderNbJoursMission_Click);
            // 
            // btnValiderNbJoursMin
            // 
            this.btnValiderNbJoursMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValiderNbJoursMin.BackgroundImage")));
            this.btnValiderNbJoursMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValiderNbJoursMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderNbJoursMin.Location = new System.Drawing.Point(1619, 200);
            this.btnValiderNbJoursMin.Margin = new System.Windows.Forms.Padding(5);
            this.btnValiderNbJoursMin.Name = "btnValiderNbJoursMin";
            this.btnValiderNbJoursMin.Size = new System.Drawing.Size(55, 51);
            this.btnValiderNbJoursMin.TabIndex = 16;
            this.btnValiderNbJoursMin.UseVisualStyleBackColor = true;
            // 
            // rdbRAZ
            // 
            this.rdbRAZ.AutoSize = true;
            this.rdbRAZ.Checked = true;
            this.rdbRAZ.Location = new System.Drawing.Point(63, 84);
            this.rdbRAZ.Name = "rdbRAZ";
            this.rdbRAZ.Size = new System.Drawing.Size(102, 32);
            this.rdbRAZ.TabIndex = 15;
            this.rdbRAZ.TabStop = true;
            this.rdbRAZ.Text = "Toutes";
            this.rdbRAZ.UseVisualStyleBackColor = true;
            this.rdbRAZ.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // lblNbMission
            // 
            this.lblNbMission.Location = new System.Drawing.Point(1123, 93);
            this.lblNbMission.Name = "lblNbMission";
            this.lblNbMission.Size = new System.Drawing.Size(277, 63);
            this.lblNbMission.TabIndex = 14;
            this.lblNbMission.Text = "Nombre de jours minimum des missions :";
            this.lblNbMission.Click += new System.EventHandler(this.lblNbMission_Click);
            // 
            // nupNbMissions
            // 
            this.nupNbMissions.Location = new System.Drawing.Point(1128, 168);
            this.nupNbMissions.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nupNbMissions.Name = "nupNbMissions";
            this.nupNbMissions.Size = new System.Drawing.Size(68, 35);
            this.nupNbMissions.TabIndex = 13;
            this.nupNbMissions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRecherche
            // 
            this.btnRecherche.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnRecherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecherche.Location = new System.Drawing.Point(973, 148);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(5);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(41, 40);
            this.btnRecherche.TabIndex = 12;
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // lblBd
            // 
            this.lblBd.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBd.Location = new System.Drawing.Point(722, 214);
            this.lblBd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBd.Name = "lblBd";
            this.lblBd.Size = new System.Drawing.Size(319, 28);
            this.lblBd.TabIndex = 11;
            // 
            // txtBudgetMin
            // 
            this.txtBudgetMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBudgetMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBudgetMin.Location = new System.Drawing.Point(727, 152);
            this.txtBudgetMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtBudgetMin.Name = "txtBudgetMin";
            this.txtBudgetMin.ShortcutsEnabled = false;
            this.txtBudgetMin.Size = new System.Drawing.Size(237, 35);
            this.txtBudgetMin.TabIndex = 9;
            this.ttBudgetMin.SetToolTip(this.txtBudgetMin, "Filtre par budget MINIMUM");
            this.txtBudgetMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBudgetMax_KeyPress);
            // 
            // lblPlanete
            // 
            this.lblPlanete.AutoSize = true;
            this.lblPlanete.Location = new System.Drawing.Point(349, 179);
            this.lblPlanete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(97, 28);
            this.lblPlanete.TabIndex = 8;
            this.lblPlanete.Text = "Planète :";
            // 
            // cboPlanete
            // 
            this.cboPlanete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPlanete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPlanete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPlanete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlanete.FormattingEnabled = true;
            this.cboPlanete.Location = new System.Drawing.Point(355, 211);
            this.cboPlanete.Margin = new System.Windows.Forms.Padding(4);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(291, 36);
            this.cboPlanete.TabIndex = 7;
            this.cboPlanete.SelectionChangeCommitted += new System.EventHandler(this.cbo_SelectionChangeCommitted);
            // 
            // btnRAZ
            // 
            this.btnRAZ.BackgroundImage = global::Formulaire_principal.Properties.Resources.raz_vrai;
            this.btnRAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRAZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRAZ.Location = new System.Drawing.Point(1368, 197);
            this.btnRAZ.Margin = new System.Windows.Forms.Padding(4);
            this.btnRAZ.Name = "btnRAZ";
            this.btnRAZ.Size = new System.Drawing.Size(57, 52);
            this.btnRAZ.TabIndex = 6;
            this.ttRAZ.SetToolTip(this.btnRAZ, "Remise à zéro des filtres");
            this.btnRAZ.UseVisualStyleBackColor = true;
            this.btnRAZ.Click += new System.EventHandler(this.btnRAZ_Click);
            // 
            // cboChefMission
            // 
            this.cboChefMission.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboChefMission.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboChefMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboChefMission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChefMission.FormattingEnabled = true;
            this.cboChefMission.Location = new System.Drawing.Point(355, 122);
            this.cboChefMission.Margin = new System.Windows.Forms.Padding(4);
            this.cboChefMission.Name = "cboChefMission";
            this.cboChefMission.Size = new System.Drawing.Size(291, 36);
            this.cboChefMission.TabIndex = 5;
            this.cboChefMission.SelectionChangeCommitted += new System.EventHandler(this.cbo_SelectionChangeCommitted);
            // 
            // lblChefMission
            // 
            this.lblChefMission.AutoSize = true;
            this.lblChefMission.Location = new System.Drawing.Point(349, 90);
            this.lblChefMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChefMission.Name = "lblChefMission";
            this.lblChefMission.Size = new System.Drawing.Size(181, 28);
            this.lblChefMission.TabIndex = 4;
            this.lblChefMission.Text = "Chef de mission :";
            // 
            // rdbAVenir
            // 
            this.rdbAVenir.AutoSize = true;
            this.rdbAVenir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAVenir.Location = new System.Drawing.Point(63, 216);
            this.rdbAVenir.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAVenir.Name = "rdbAVenir";
            this.rdbAVenir.Size = new System.Drawing.Size(106, 32);
            this.rdbAVenir.TabIndex = 3;
            this.rdbAVenir.Text = "À venir";
            this.rdbAVenir.UseVisualStyleBackColor = true;
            this.rdbAVenir.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // rdbEnCours
            // 
            this.rdbEnCours.AutoSize = true;
            this.rdbEnCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbEnCours.Location = new System.Drawing.Point(63, 168);
            this.rdbEnCours.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEnCours.Name = "rdbEnCours";
            this.rdbEnCours.Size = new System.Drawing.Size(120, 32);
            this.rdbEnCours.TabIndex = 2;
            this.rdbEnCours.Text = "En cours";
            this.rdbEnCours.UseVisualStyleBackColor = true;
            this.rdbEnCours.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // rdbPasse
            // 
            this.rdbPasse.AutoSize = true;
            this.rdbPasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbPasse.Location = new System.Drawing.Point(63, 123);
            this.rdbPasse.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPasse.Name = "rdbPasse";
            this.rdbPasse.Size = new System.Drawing.Size(107, 32);
            this.rdbPasse.TabIndex = 1;
            this.rdbPasse.Text = "Passées";
            this.rdbPasse.UseVisualStyleBackColor = true;
            this.rdbPasse.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "★ Statut des missions : ";
            // 
            // lblTableauDeBord
            // 
            this.lblTableauDeBord.AutoSize = true;
            this.lblTableauDeBord.Font = new System.Drawing.Font("Kristen ITC", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableauDeBord.Location = new System.Drawing.Point(29, 22);
            this.lblTableauDeBord.Name = "lblTableauDeBord";
            this.lblTableauDeBord.Size = new System.Drawing.Size(407, 45);
            this.lblTableauDeBord.TabIndex = 3;
            this.lblTableauDeBord.Text = "TABLEAU DE BORD";
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.msMenu.BackgroundImage = global::Formulaire_principal.Properties.Resources.Fond_menuStrip;
            this.msMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.msMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTableauDeBord,
            this.tsmiMission,
            this.tmsiPlanete,
            this.tmsiAliens});
            this.msMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.MinimumSize = new System.Drawing.Size(267, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(7, 4, 0, 4);
            this.msMenu.Size = new System.Drawing.Size(295, 1019);
            this.msMenu.Stretch = false;
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiTableauDeBord
            // 
            this.tsmiTableauDeBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.tsmiTableauDeBord.Checked = true;
            this.tsmiTableauDeBord.CheckOnClick = true;
            this.tsmiTableauDeBord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiTableauDeBord.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiTableauDeBord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tsmiTableauDeBord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmiTableauDeBord.Margin = new System.Windows.Forms.Padding(15, 160, 2, 1);
            this.tsmiTableauDeBord.Name = "tsmiTableauDeBord";
            this.tsmiTableauDeBord.Size = new System.Drawing.Size(271, 34);
            this.tsmiTableauDeBord.Text = "★ Tableau de bord  ";
            this.tsmiTableauDeBord.Click += new System.EventHandler(this.tsmiTableauDeBord_Click);
            // 
            // tsmiMission
            // 
            this.tsmiMission.BackColor = System.Drawing.Color.Transparent;
            this.tsmiMission.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tsmiMission.Margin = new System.Windows.Forms.Padding(15, 70, 2, 1);
            this.tsmiMission.Name = "tsmiMission";
            this.tsmiMission.Size = new System.Drawing.Size(271, 34);
            this.tsmiMission.Text = "★ Créer une mission";
            this.tsmiMission.Click += new System.EventHandler(this.tsmiMission_Click);
            // 
            // tmsiPlanete
            // 
            this.tmsiPlanete.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmsiPlanete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tmsiPlanete.Margin = new System.Windows.Forms.Padding(15, 70, 2, 1);
            this.tmsiPlanete.Name = "tmsiPlanete";
            this.tmsiPlanete.Size = new System.Drawing.Size(270, 34);
            this.tmsiPlanete.Text = "★ Planètes              ";
            this.tmsiPlanete.Click += new System.EventHandler(this.tmsiPlanete_Click);
            // 
            // tmsiAliens
            // 
            this.tmsiAliens.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmsiAliens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tmsiAliens.Margin = new System.Windows.Forms.Padding(15, 70, 2, 1);
            this.tmsiAliens.Name = "tmsiAliens";
            this.tmsiAliens.Size = new System.Drawing.Size(266, 34);
            this.tmsiAliens.Text = "★ Aliens                 ";
            this.tmsiAliens.Click += new System.EventHandler(this.tmsiAliens_Click);
            // 
            // plPlanetes
            // 
            this.plPlanetes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.plPlanetes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plPlanetes.Controls.Add(this.grpPlanetes);
            this.plPlanetes.Controls.Add(this.lblPlanetes);
            this.plPlanetes.Controls.Add(this.grpFiltre);
            this.plPlanetes.Location = new System.Drawing.Point(376, 27);
            this.plPlanetes.Margin = new System.Windows.Forms.Padding(5);
            this.plPlanetes.Name = "plPlanetes";
            this.plPlanetes.Size = new System.Drawing.Size(1521, 975);
            this.plPlanetes.TabIndex = 2;
            this.plPlanetes.Visible = false;
            // 
            // grpPlanetes
            // 
            this.grpPlanetes.Controls.Add(this.lblErreur3);
            this.grpPlanetes.Controls.Add(this.flpPlanete);
            this.grpPlanetes.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlanetes.Location = new System.Drawing.Point(593, 83);
            this.grpPlanetes.Name = "grpPlanetes";
            this.grpPlanetes.Size = new System.Drawing.Size(897, 872);
            this.grpPlanetes.TabIndex = 5;
            this.grpPlanetes.TabStop = false;
            this.grpPlanetes.Text = "Planètes : ";
            // 
            // lblErreur3
            // 
            this.lblErreur3.AutoSize = true;
            this.lblErreur3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur3.Location = new System.Drawing.Point(227, 406);
            this.lblErreur3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreur3.Name = "lblErreur3";
            this.lblErreur3.Size = new System.Drawing.Size(365, 20);
            this.lblErreur3.TabIndex = 1;
            this.lblErreur3.Text = "Aucun résultat ne correspond à votre recherche";
            this.lblErreur3.Visible = false;
            // 
            // flpPlanete
            // 
            this.flpPlanete.AutoScroll = true;
            this.flpPlanete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flpPlanete.Location = new System.Drawing.Point(8, 37);
            this.flpPlanete.Margin = new System.Windows.Forms.Padding(5);
            this.flpPlanete.Name = "flpPlanete";
            this.flpPlanete.Size = new System.Drawing.Size(881, 824);
            this.flpPlanete.TabIndex = 2;
            // 
            // lblPlanetes
            // 
            this.lblPlanetes.AutoSize = true;
            this.lblPlanetes.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetes.Location = new System.Drawing.Point(29, 22);
            this.lblPlanetes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanetes.Name = "lblPlanetes";
            this.lblPlanetes.Size = new System.Drawing.Size(249, 45);
            this.lblPlanetes.TabIndex = 4;
            this.lblPlanetes.Text = "PLANÈTES :";
            // 
            // grpFiltre
            // 
            this.grpFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.grpFiltre.Controls.Add(this.grpEspeces);
            this.grpFiltre.Controls.Add(this.btnRechercher);
            this.grpFiltre.Controls.Add(this.label7);
            this.grpFiltre.Controls.Add(this.btnReinitialiserEspeces);
            this.grpFiltre.Controls.Add(this.btnReinitialiserDataBaz);
            this.grpFiltre.Controls.Add(this.btnReinitialiser);
            this.grpFiltre.Controls.Add(this.txtMaxMission);
            this.grpFiltre.Controls.Add(this.txtMinMission);
            this.grpFiltre.Controls.Add(this.label11);
            this.grpFiltre.Controls.Add(this.label12);
            this.grpFiltre.Controls.Add(this.rdbSans);
            this.grpFiltre.Controls.Add(this.rdbAvec);
            this.grpFiltre.Controls.Add(this.txtMaxGrav);
            this.grpFiltre.Controls.Add(this.txtMinGrav);
            this.grpFiltre.Controls.Add(this.label5);
            this.grpFiltre.Controls.Add(this.txtMaxTemp);
            this.grpFiltre.Controls.Add(this.txtMinTemp);
            this.grpFiltre.Controls.Add(this.label13);
            this.grpFiltre.Controls.Add(this.label14);
            this.grpFiltre.Controls.Add(this.txtNom);
            this.grpFiltre.Controls.Add(this.label16);
            this.grpFiltre.Controls.Add(this.label17);
            this.grpFiltre.Controls.Add(this.label18);
            this.grpFiltre.Controls.Add(this.label19);
            this.grpFiltre.Controls.Add(this.label20);
            this.grpFiltre.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltre.Location = new System.Drawing.Point(32, 79);
            this.grpFiltre.Margin = new System.Windows.Forms.Padding(5);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Padding = new System.Windows.Forms.Padding(5);
            this.grpFiltre.Size = new System.Drawing.Size(553, 874);
            this.grpFiltre.TabIndex = 3;
            this.grpFiltre.TabStop = false;
            this.grpFiltre.Text = "Filtres";
            // 
            // grpEspeces
            // 
            this.grpEspeces.Controls.Add(this.flpEspece);
            this.grpEspeces.Location = new System.Drawing.Point(37, 453);
            this.grpEspeces.Name = "grpEspeces";
            this.grpEspeces.Size = new System.Drawing.Size(403, 176);
            this.grpEspeces.TabIndex = 28;
            this.grpEspeces.TabStop = false;
            this.grpEspeces.Text = "Espèces :";
            // 
            // flpEspece
            // 
            this.flpEspece.AutoScroll = true;
            this.flpEspece.Location = new System.Drawing.Point(8, 35);
            this.flpEspece.Margin = new System.Windows.Forms.Padding(5);
            this.flpEspece.Name = "flpEspece";
            this.flpEspece.Size = new System.Drawing.Size(387, 134);
            this.flpEspece.TabIndex = 22;
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnRechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.Location = new System.Drawing.Point(461, 799);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(5);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(71, 61);
            this.btnRechercher.TabIndex = 23;
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Max";
            // 
            // btnReinitialiserEspeces
            // 
            this.btnReinitialiserEspeces.BackgroundImage = global::Formulaire_principal.Properties.Resources.reinitialiser3;
            this.btnReinitialiserEspeces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReinitialiserEspeces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinitialiserEspeces.Location = new System.Drawing.Point(455, 579);
            this.btnReinitialiserEspeces.Margin = new System.Windows.Forms.Padding(5);
            this.btnReinitialiserEspeces.Name = "btnReinitialiserEspeces";
            this.btnReinitialiserEspeces.Size = new System.Drawing.Size(57, 51);
            this.btnReinitialiserEspeces.TabIndex = 26;
            this.btnReinitialiserEspeces.UseVisualStyleBackColor = true;
            this.btnReinitialiserEspeces.Click += new System.EventHandler(this.btnReinitialiserEspeces_Click);
            // 
            // btnReinitialiserDataBaz
            // 
            this.btnReinitialiserDataBaz.BackgroundImage = global::Formulaire_principal.Properties.Resources.reinitialiser3;
            this.btnReinitialiserDataBaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReinitialiserDataBaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinitialiserDataBaz.Location = new System.Drawing.Point(403, 378);
            this.btnReinitialiserDataBaz.Margin = new System.Windows.Forms.Padding(5);
            this.btnReinitialiserDataBaz.Name = "btnReinitialiserDataBaz";
            this.btnReinitialiserDataBaz.Size = new System.Drawing.Size(57, 51);
            this.btnReinitialiserDataBaz.TabIndex = 25;
            this.btnReinitialiserDataBaz.UseVisualStyleBackColor = true;
            this.btnReinitialiserDataBaz.Click += new System.EventHandler(this.btnReinitialiserDataBaz_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BackColor = System.Drawing.SystemColors.Control;
            this.btnReinitialiser.BackgroundImage = global::Formulaire_principal.Properties.Resources.raz_vrai;
            this.btnReinitialiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReinitialiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinitialiser.Location = new System.Drawing.Point(371, 800);
            this.btnReinitialiser.Margin = new System.Windows.Forms.Padding(5);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(71, 61);
            this.btnReinitialiser.TabIndex = 24;
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // txtMaxMission
            // 
            this.txtMaxMission.Location = new System.Drawing.Point(225, 752);
            this.txtMaxMission.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaxMission.Name = "txtMaxMission";
            this.txtMaxMission.ShortcutsEnabled = false;
            this.txtMaxMission.Size = new System.Drawing.Size(111, 35);
            this.txtMaxMission.TabIndex = 21;
            this.txtMaxMission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxMission_KeyDown);
            this.txtMaxMission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxMission_KeyPress);
            // 
            // txtMinMission
            // 
            this.txtMinMission.Location = new System.Drawing.Point(225, 701);
            this.txtMinMission.Margin = new System.Windows.Forms.Padding(5);
            this.txtMinMission.Name = "txtMinMission";
            this.txtMinMission.ShortcutsEnabled = false;
            this.txtMinMission.Size = new System.Drawing.Size(111, 35);
            this.txtMinMission.TabIndex = 20;
            this.txtMinMission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinMission_KeyDown);
            this.txtMinMission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinMission_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 704);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 28);
            this.label11.TabIndex = 19;
            this.label11.Text = "Minimum : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 755);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 28);
            this.label12.TabIndex = 18;
            this.label12.Text = "Maximum :";
            // 
            // rdbSans
            // 
            this.rdbSans.AutoSize = true;
            this.rdbSans.ForeColor = System.Drawing.Color.Red;
            this.rdbSans.Location = new System.Drawing.Point(309, 387);
            this.rdbSans.Margin = new System.Windows.Forms.Padding(5);
            this.rdbSans.Name = "rdbSans";
            this.rdbSans.Size = new System.Drawing.Size(77, 32);
            this.rdbSans.TabIndex = 17;
            this.rdbSans.TabStop = true;
            this.rdbSans.Text = "Sans";
            this.rdbSans.UseVisualStyleBackColor = true;
            this.rdbSans.Click += new System.EventHandler(this.rdbSans_Click);
            // 
            // rdbAvec
            // 
            this.rdbAvec.AutoSize = true;
            this.rdbAvec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdbAvec.Location = new System.Drawing.Point(199, 387);
            this.rdbAvec.Margin = new System.Windows.Forms.Padding(5);
            this.rdbAvec.Name = "rdbAvec";
            this.rdbAvec.Size = new System.Drawing.Size(85, 32);
            this.rdbAvec.TabIndex = 16;
            this.rdbAvec.TabStop = true;
            this.rdbAvec.Text = "Avec";
            this.rdbAvec.UseVisualStyleBackColor = true;
            this.rdbAvec.Click += new System.EventHandler(this.rdbAvec_Click);
            // 
            // txtMaxGrav
            // 
            this.txtMaxGrav.Location = new System.Drawing.Point(280, 293);
            this.txtMaxGrav.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaxGrav.Name = "txtMaxGrav";
            this.txtMaxGrav.ShortcutsEnabled = false;
            this.txtMaxGrav.Size = new System.Drawing.Size(100, 35);
            this.txtMaxGrav.TabIndex = 15;
            this.txtMaxGrav.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxGrav_KeyDown);
            this.txtMaxGrav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxGrav_KeyPress);
            // 
            // txtMinGrav
            // 
            this.txtMinGrav.Location = new System.Drawing.Point(280, 243);
            this.txtMinGrav.Margin = new System.Windows.Forms.Padding(5);
            this.txtMinGrav.Name = "txtMinGrav";
            this.txtMinGrav.ShortcutsEnabled = false;
            this.txtMinGrav.Size = new System.Drawing.Size(100, 35);
            this.txtMinGrav.TabIndex = 14;
            this.txtMinGrav.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinGrav_KeyDown);
            this.txtMinGrav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinGrav_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Min";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(280, 157);
            this.txtMaxTemp.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.ShortcutsEnabled = false;
            this.txtMaxTemp.Size = new System.Drawing.Size(100, 35);
            this.txtMaxTemp.TabIndex = 11;
            this.txtMaxTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxTemp_KeyDown);
            this.txtMaxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxTemp_KeyPress);
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(280, 109);
            this.txtMinTemp.Margin = new System.Windows.Forms.Padding(5);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.ShortcutsEnabled = false;
            this.txtMinTemp.Size = new System.Drawing.Size(100, 35);
            this.txtMinTemp.TabIndex = 10;
            this.txtMinTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinTemp_KeyDown);
            this.txtMinTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinTemp_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(211, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 28);
            this.label13.TabIndex = 9;
            this.label13.Text = "Min";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(211, 157);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 28);
            this.label14.TabIndex = 8;
            this.label14.Text = "Max";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(141, 48);
            this.txtNom.Margin = new System.Windows.Forms.Padding(5);
            this.txtNom.Name = "txtNom";
            this.txtNom.ShortcutsEnabled = false;
            this.txtNom.Size = new System.Drawing.Size(276, 35);
            this.txtNom.TabIndex = 7;
            this.txtNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNom_KeyDown);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(45, 243);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 28);
            this.label16.TabIndex = 5;
            this.label16.Text = "Gravité :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(48, 387);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 28);
            this.label17.TabIndex = 4;
            this.label17.Text = "DataBaz :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 112);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 28);
            this.label18.TabIndex = 3;
            this.label18.Text = "Temperature :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(49, 651);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(319, 28);
            this.label19.TabIndex = 2;
            this.label19.Text = "Nombre de missions effectués :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(37, 48);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 28);
            this.label20.TabIndex = 0;
            this.label20.Text = "Nom :";
            // 
            // plAliens
            // 
            this.plAliens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.plAliens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plAliens.Controls.Add(this.lblAliens);
            this.plAliens.Controls.Add(this.grpFiltresAlliees);
            this.plAliens.Controls.Add(this.groupBox3);
            this.plAliens.Controls.Add(this.grpAlliees);
            this.plAliens.Controls.Add(this.grpFiltresEnnemis);
            this.plAliens.Location = new System.Drawing.Point(376, 27);
            this.plAliens.Margin = new System.Windows.Forms.Padding(4);
            this.plAliens.Name = "plAliens";
            this.plAliens.Size = new System.Drawing.Size(1520, 976);
            this.plAliens.TabIndex = 1;
            // 
            // lblAliens
            // 
            this.lblAliens.AutoSize = true;
            this.lblAliens.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliens.Location = new System.Drawing.Point(29, 22);
            this.lblAliens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAliens.Name = "lblAliens";
            this.lblAliens.Size = new System.Drawing.Size(178, 45);
            this.lblAliens.TabIndex = 8;
            this.lblAliens.Text = "ALIENS ";
            // 
            // grpFiltresAlliees
            // 
            this.grpFiltresAlliees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.grpFiltresAlliees.Controls.Add(this.btnReinitialiserAlliees);
            this.grpFiltresAlliees.Controls.Add(this.cboBienveillance);
            this.grpFiltresAlliees.Controls.Add(this.btnRechercherAlliees);
            this.grpFiltresAlliees.Controls.Add(this.label4);
            this.grpFiltresAlliees.Controls.Add(this.label2);
            this.grpFiltresAlliees.Controls.Add(this.label3);
            this.grpFiltresAlliees.Controls.Add(this.cboCouleurAlliees);
            this.grpFiltresAlliees.Controls.Add(this.txtNomAlliees);
            this.grpFiltresAlliees.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltresAlliees.Location = new System.Drawing.Point(5, 79);
            this.grpFiltresAlliees.Margin = new System.Windows.Forms.Padding(5);
            this.grpFiltresAlliees.Name = "grpFiltresAlliees";
            this.grpFiltresAlliees.Padding = new System.Windows.Forms.Padding(5);
            this.grpFiltresAlliees.Size = new System.Drawing.Size(747, 321);
            this.grpFiltresAlliees.TabIndex = 4;
            this.grpFiltresAlliees.TabStop = false;
            this.grpFiltresAlliees.Text = "Filtres";
            // 
            // btnReinitialiserAlliees
            // 
            this.btnReinitialiserAlliees.BackgroundImage = global::Formulaire_principal.Properties.Resources.raz_vrai;
            this.btnReinitialiserAlliees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReinitialiserAlliees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinitialiserAlliees.Location = new System.Drawing.Point(589, 260);
            this.btnReinitialiserAlliees.Margin = new System.Windows.Forms.Padding(5);
            this.btnReinitialiserAlliees.Name = "btnReinitialiserAlliees";
            this.btnReinitialiserAlliees.Size = new System.Drawing.Size(57, 52);
            this.btnReinitialiserAlliees.TabIndex = 11;
            this.btnReinitialiserAlliees.UseVisualStyleBackColor = true;
            this.btnReinitialiserAlliees.Click += new System.EventHandler(this.btnReinitialiserAlliees_Click);
            // 
            // cboBienveillance
            // 
            this.cboBienveillance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBienveillance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBienveillance.FormattingEnabled = true;
            this.cboBienveillance.Location = new System.Drawing.Point(371, 168);
            this.cboBienveillance.Margin = new System.Windows.Forms.Padding(5);
            this.cboBienveillance.Name = "cboBienveillance";
            this.cboBienveillance.Size = new System.Drawing.Size(297, 36);
            this.cboBienveillance.TabIndex = 9;
            this.cboBienveillance.SelectedIndexChanged += new System.EventHandler(this.cboBienveillance_SelectedIndexChanged);
            this.cboBienveillance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AliensAllies_KeyDown);
            // 
            // btnRechercherAlliees
            // 
            this.btnRechercherAlliees.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnRechercherAlliees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRechercherAlliees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherAlliees.Location = new System.Drawing.Point(677, 260);
            this.btnRechercherAlliees.Margin = new System.Windows.Forms.Padding(5);
            this.btnRechercherAlliees.Name = "btnRechercherAlliees";
            this.btnRechercherAlliees.Size = new System.Drawing.Size(57, 52);
            this.btnRechercherAlliees.TabIndex = 2;
            this.btnRechercherAlliees.UseVisualStyleBackColor = true;
            this.btnRechercherAlliees.Click += new System.EventHandler(this.btnRechercherAlliees_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bienveillance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Couleur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom (like)";
            // 
            // cboCouleurAlliees
            // 
            this.cboCouleurAlliees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCouleurAlliees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCouleurAlliees.FormattingEnabled = true;
            this.cboCouleurAlliees.Location = new System.Drawing.Point(12, 168);
            this.cboCouleurAlliees.Margin = new System.Windows.Forms.Padding(5);
            this.cboCouleurAlliees.Name = "cboCouleurAlliees";
            this.cboCouleurAlliees.Size = new System.Drawing.Size(297, 36);
            this.cboCouleurAlliees.TabIndex = 1;
            this.cboCouleurAlliees.SelectedIndexChanged += new System.EventHandler(this.cboCouleurAlliees_SelectedIndexChanged);
            this.cboCouleurAlliees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AliensAllies_KeyDown);
            // 
            // txtNomAlliees
            // 
            this.txtNomAlliees.Location = new System.Drawing.Point(12, 72);
            this.txtNomAlliees.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomAlliees.Name = "txtNomAlliees";
            this.txtNomAlliees.ShortcutsEnabled = false;
            this.txtNomAlliees.Size = new System.Drawing.Size(297, 35);
            this.txtNomAlliees.TabIndex = 0;
            this.txtNomAlliees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomAlliees_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblErreur2);
            this.groupBox3.Controls.Add(this.flp2);
            this.groupBox3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(763, 411);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(752, 556);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informations sur les races ennemies";
            // 
            // lblErreur2
            // 
            this.lblErreur2.AutoSize = true;
            this.lblErreur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur2.Location = new System.Drawing.Point(133, 277);
            this.lblErreur2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreur2.Name = "lblErreur2";
            this.lblErreur2.Size = new System.Drawing.Size(365, 20);
            this.lblErreur2.TabIndex = 1;
            this.lblErreur2.Text = "Aucun résultat ne correspond à votre recherche";
            this.lblErreur2.Visible = false;
            // 
            // flp2
            // 
            this.flp2.AutoScroll = true;
            this.flp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp2.Location = new System.Drawing.Point(5, 33);
            this.flp2.Margin = new System.Windows.Forms.Padding(5);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(742, 518);
            this.flp2.TabIndex = 0;
            // 
            // grpAlliees
            // 
            this.grpAlliees.Controls.Add(this.lblErreur);
            this.grpAlliees.Controls.Add(this.flp1);
            this.grpAlliees.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAlliees.Location = new System.Drawing.Point(5, 411);
            this.grpAlliees.Margin = new System.Windows.Forms.Padding(5);
            this.grpAlliees.Name = "grpAlliees";
            this.grpAlliees.Padding = new System.Windows.Forms.Padding(5);
            this.grpAlliees.Size = new System.Drawing.Size(747, 556);
            this.grpAlliees.TabIndex = 5;
            this.grpAlliees.TabStop = false;
            this.grpAlliees.Text = "Informations sur les races alliées";
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.Location = new System.Drawing.Point(133, 277);
            this.lblErreur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(365, 20);
            this.lblErreur.TabIndex = 0;
            this.lblErreur.Text = "Aucun résultat ne correspond à votre recherche";
            this.lblErreur.Visible = false;
            // 
            // flp1
            // 
            this.flp1.AutoScroll = true;
            this.flp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp1.Location = new System.Drawing.Point(5, 33);
            this.flp1.Margin = new System.Windows.Forms.Padding(5);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(737, 518);
            this.flp1.TabIndex = 0;
            // 
            // grpFiltresEnnemis
            // 
            this.grpFiltresEnnemis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
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
            this.grpFiltresEnnemis.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltresEnnemis.Location = new System.Drawing.Point(763, 81);
            this.grpFiltresEnnemis.Margin = new System.Windows.Forms.Padding(5);
            this.grpFiltresEnnemis.Name = "grpFiltresEnnemis";
            this.grpFiltresEnnemis.Padding = new System.Windows.Forms.Padding(5);
            this.grpFiltresEnnemis.Size = new System.Drawing.Size(752, 319);
            this.grpFiltresEnnemis.TabIndex = 6;
            this.grpFiltresEnnemis.TabStop = false;
            this.grpFiltresEnnemis.Text = "Filtres";
            // 
            // btnReinitialiserEnnemis
            // 
            this.btnReinitialiserEnnemis.BackgroundImage = global::Formulaire_principal.Properties.Resources.raz_vrai;
            this.btnReinitialiserEnnemis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReinitialiserEnnemis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinitialiserEnnemis.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialiserEnnemis.Location = new System.Drawing.Point(607, 257);
            this.btnReinitialiserEnnemis.Margin = new System.Windows.Forms.Padding(5);
            this.btnReinitialiserEnnemis.Name = "btnReinitialiserEnnemis";
            this.btnReinitialiserEnnemis.Size = new System.Drawing.Size(57, 52);
            this.btnReinitialiserEnnemis.TabIndex = 12;
            this.btnReinitialiserEnnemis.UseVisualStyleBackColor = true;
            this.btnReinitialiserEnnemis.Click += new System.EventHandler(this.btnReinitialiserEnnemis_Click);
            // 
            // cboAgressivite
            // 
            this.cboAgressivite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAgressivite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAgressivite.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAgressivite.FormattingEnabled = true;
            this.cboAgressivite.Location = new System.Drawing.Point(17, 267);
            this.cboAgressivite.Margin = new System.Windows.Forms.Padding(5);
            this.cboAgressivite.Name = "cboAgressivite";
            this.cboAgressivite.Size = new System.Drawing.Size(297, 36);
            this.cboAgressivite.TabIndex = 10;
            this.cboAgressivite.SelectedIndexChanged += new System.EventHandler(this.cboAgressivite_SelectedIndexChanged);
            this.cboAgressivite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AliensEnnemis_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Agressivité";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Type arme";
            // 
            // cboTypeArme
            // 
            this.cboTypeArme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTypeArme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTypeArme.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeArme.FormattingEnabled = true;
            this.cboTypeArme.Location = new System.Drawing.Point(364, 175);
            this.cboTypeArme.Margin = new System.Windows.Forms.Padding(5);
            this.cboTypeArme.Name = "cboTypeArme";
            this.cboTypeArme.Size = new System.Drawing.Size(297, 36);
            this.cboTypeArme.TabIndex = 5;
            this.cboTypeArme.SelectedIndexChanged += new System.EventHandler(this.cboTypeArme_SelectedIndexChanged);
            this.cboTypeArme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AliensEnnemis_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Couleur";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 28);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nom (like)";
            // 
            // btnRechercherEnnemis
            // 
            this.btnRechercherEnnemis.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnRechercherEnnemis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRechercherEnnemis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherEnnemis.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherEnnemis.Location = new System.Drawing.Point(685, 259);
            this.btnRechercherEnnemis.Margin = new System.Windows.Forms.Padding(5);
            this.btnRechercherEnnemis.Name = "btnRechercherEnnemis";
            this.btnRechercherEnnemis.Size = new System.Drawing.Size(57, 52);
            this.btnRechercherEnnemis.TabIndex = 2;
            this.btnRechercherEnnemis.UseVisualStyleBackColor = true;
            this.btnRechercherEnnemis.Click += new System.EventHandler(this.btnRechercherEnnemis_Click);
            // 
            // cboCouleurEnnemis
            // 
            this.cboCouleurEnnemis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCouleurEnnemis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCouleurEnnemis.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCouleurEnnemis.FormattingEnabled = true;
            this.cboCouleurEnnemis.Location = new System.Drawing.Point(15, 175);
            this.cboCouleurEnnemis.Margin = new System.Windows.Forms.Padding(5);
            this.cboCouleurEnnemis.Name = "cboCouleurEnnemis";
            this.cboCouleurEnnemis.Size = new System.Drawing.Size(297, 36);
            this.cboCouleurEnnemis.TabIndex = 1;
            this.cboCouleurEnnemis.SelectedIndexChanged += new System.EventHandler(this.cboCouleurEnnemis_SelectedIndexChanged);
            this.cboCouleurEnnemis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AliensEnnemis_KeyDown);
            // 
            // txtNomEnnemis
            // 
            this.txtNomEnnemis.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomEnnemis.Location = new System.Drawing.Point(17, 88);
            this.txtNomEnnemis.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomEnnemis.Name = "txtNomEnnemis";
            this.txtNomEnnemis.ShortcutsEnabled = false;
            this.txtNomEnnemis.Size = new System.Drawing.Size(297, 35);
            this.txtNomEnnemis.TabIndex = 0;
            this.txtNomEnnemis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomEnnemis_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlProgressBar
            // 
            this.pnlProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.pnlProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlProgressBar.BackgroundImage")));
            this.pnlProgressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlProgressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProgressBar.Controls.Add(this.plBoiteChargement);
            this.pnlProgressBar.Controls.Add(this.lblCharge);
            this.pnlProgressBar.Controls.Add(this.lblPourcentage);
            this.pnlProgressBar.Location = new System.Drawing.Point(376, 27);
            this.pnlProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnlProgressBar.Name = "pnlProgressBar";
            this.pnlProgressBar.Size = new System.Drawing.Size(1520, 975);
            this.pnlProgressBar.TabIndex = 3;
            this.pnlProgressBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProgressBar_Paint);
            // 
            // plBoiteChargement
            // 
            this.plBoiteChargement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.plBoiteChargement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plBoiteChargement.Controls.Add(this.plChargement);
            this.plBoiteChargement.Location = new System.Drawing.Point(467, 490);
            this.plBoiteChargement.Margin = new System.Windows.Forms.Padding(2);
            this.plBoiteChargement.Name = "plBoiteChargement";
            this.plBoiteChargement.Size = new System.Drawing.Size(595, 65);
            this.plBoiteChargement.TabIndex = 3;
            // 
            // plChargement
            // 
            this.plChargement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(85)))), ((int)(((byte)(212)))));
            this.plChargement.Location = new System.Drawing.Point(1, -1);
            this.plChargement.Margin = new System.Windows.Forms.Padding(2);
            this.plChargement.Name = "plChargement";
            this.plChargement.Size = new System.Drawing.Size(0, 64);
            this.plChargement.TabIndex = 4;
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.Location = new System.Drawing.Point(460, 420);
            this.lblCharge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(224, 39);
            this.lblCharge.TabIndex = 2;
            this.lblCharge.Text = "Chargement...";
            // 
            // lblPourcentage
            // 
            this.lblPourcentage.AutoSize = true;
            this.lblPourcentage.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPourcentage.Location = new System.Drawing.Point(468, 577);
            this.lblPourcentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPourcentage.Name = "lblPourcentage";
            this.lblPourcentage.Size = new System.Drawing.Size(0, 30);
            this.lblPourcentage.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(722, 84);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(242, 64);
            this.label15.TabIndex = 18;
            this.label15.Text = "Budget minimum des missions : ";
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formulaire_principal.Properties.Resources.fond_acceuil1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1923, 1019);
            this.Controls.Add(this.pnlProgressBar);
            this.Controls.Add(this.plAliens);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.plMissions);
            this.Controls.Add(this.plPlanetes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil Stargate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plMissions.ResumeLayout(false);
            this.plMissions.PerformLayout();
            this.grpNbMissionsTrouvees.ResumeLayout(false);
            this.grpFiltres.ResumeLayout(false);
            this.grpFiltres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNbMissions)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.plPlanetes.ResumeLayout(false);
            this.plPlanetes.PerformLayout();
            this.grpPlanetes.ResumeLayout(false);
            this.grpPlanetes.PerformLayout();
            this.grpFiltre.ResumeLayout(false);
            this.grpFiltre.PerformLayout();
            this.grpEspeces.ResumeLayout(false);
            this.plAliens.ResumeLayout(false);
            this.plAliens.PerformLayout();
            this.grpFiltresAlliees.ResumeLayout(false);
            this.grpFiltresAlliees.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpAlliees.ResumeLayout(false);
            this.grpAlliees.PerformLayout();
            this.grpFiltresEnnemis.ResumeLayout(false);
            this.grpFiltresEnnemis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlProgressBar.ResumeLayout(false);
            this.pnlProgressBar.PerformLayout();
            this.plBoiteChargement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChefMission;
        private System.Windows.Forms.Label lblPlanete;
        private System.Windows.Forms.FlowLayoutPanel flpMissions;
        private System.Windows.Forms.Panel plMissions;
        private System.Windows.Forms.GroupBox grpFiltres;
        private System.Windows.Forms.ComboBox cboChefMission;
        private System.Windows.Forms.RadioButton rdbAVenir;
        private System.Windows.Forms.RadioButton rdbEnCours;
        private System.Windows.Forms.RadioButton rdbPasse;
        private System.Windows.Forms.ComboBox cboPlanete;
        private System.Windows.Forms.Button btnRAZ;
        private System.Windows.Forms.Label lblBd;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TextBox txtBudgetMin;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiTableauDeBord;
        private System.Windows.Forms.ToolStripMenuItem tsmiMission;
        private System.Windows.Forms.ToolStripMenuItem tmsiPlanete;
        private System.Windows.Forms.ToolStripMenuItem tmsiAliens;
        private System.Windows.Forms.Panel plPlanetes;
        private System.Windows.Forms.GroupBox grpFiltre;
        private System.Windows.Forms.Button btnReinitialiserEspeces;
        private System.Windows.Forms.Button btnReinitialiserDataBaz;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.FlowLayoutPanel flpEspece;
        private System.Windows.Forms.TextBox txtMaxMission;
        private System.Windows.Forms.TextBox txtMinMission;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdbSans;
        private System.Windows.Forms.RadioButton rdbAvec;
        private System.Windows.Forms.TextBox txtMaxGrav;
        private System.Windows.Forms.TextBox txtMinGrav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.FlowLayoutPanel flpPlanete;
        private System.Windows.Forms.GroupBox grpFiltresAlliees;
        private System.Windows.Forms.Button btnReinitialiserAlliees;
        private System.Windows.Forms.ComboBox cboBienveillance;
        private System.Windows.Forms.Button btnRechercherAlliees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCouleurAlliees;
        private System.Windows.Forms.TextBox txtNomAlliees;
        private System.Windows.Forms.GroupBox grpFiltresEnnemis;
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
        private System.Windows.Forms.GroupBox grpAlliees;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flp2;
        private System.Windows.Forms.Panel plAliens;
        private System.Windows.Forms.ToolTip ttRAZ;
        private System.Windows.Forms.Label lblTableauDeBord;
        private System.Windows.Forms.Label lblPlanetes;
        private System.Windows.Forms.Label lblAliens;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Label lblErreur2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNbMission;
        private System.Windows.Forms.NumericUpDown nupNbMissions;
        private System.Windows.Forms.RadioButton rdbRAZ;
        private System.Windows.Forms.GroupBox grpNbMissionsTrouvees;
        private System.Windows.Forms.Button btnValiderNbJoursMin;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.GroupBox grpPlanetes;
        private System.Windows.Forms.Button btnValiderNbJoursMission;
        private System.Windows.Forms.GroupBox grpEspeces;
        private System.Windows.Forms.Label lblErreur3;
        private System.Windows.Forms.Panel pnlProgressBar;
        private System.Windows.Forms.Label lblPourcentage;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Panel plChargement;
        private System.Windows.Forms.Panel plBoiteChargement;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip ttBudgetMin;
        private System.Windows.Forms.Label label15;
    }
}

