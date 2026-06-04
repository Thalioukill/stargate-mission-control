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
            this.SuspendLayout();
            // 
            // flpMissions
            // 
            this.flpMissions.AutoScroll = true;
            this.flpMissions.Location = new System.Drawing.Point(20, 62);
            this.flpMissions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flpMissions.Name = "flpMissions";
            this.flpMissions.Size = new System.Drawing.Size(2140, 771);
            this.flpMissions.TabIndex = 4;
            // 
            // plMissions
            // 
            this.plMissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.plMissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMissions.Controls.Add(this.grpNbMissionsTrouvees);
            this.plMissions.Controls.Add(this.grpFiltres);
            this.plMissions.Controls.Add(this.lblTableauDeBord);
            this.plMissions.Location = new System.Drawing.Point(564, 42);
            this.plMissions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.plMissions.Name = "plMissions";
            this.plMissions.Size = new System.Drawing.Size(2280, 1523);
            this.plMissions.TabIndex = 0;
            // 
            // grpNbMissionsTrouvees
            // 
            this.grpNbMissionsTrouvees.Controls.Add(this.flpMissions);
            this.grpNbMissionsTrouvees.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNbMissionsTrouvees.Location = new System.Drawing.Point(40, 621);
            this.grpNbMissionsTrouvees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNbMissionsTrouvees.Name = "grpNbMissionsTrouvees";
            this.grpNbMissionsTrouvees.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpNbMissionsTrouvees.Size = new System.Drawing.Size(2172, 862);
            this.grpNbMissionsTrouvees.TabIndex = 7;
            this.grpNbMissionsTrouvees.TabStop = false;
            this.grpNbMissionsTrouvees.Text = "Nombre de missions trouvées : ";
            // 
            // grpFiltres
            // 
            this.grpFiltres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
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
            this.grpFiltres.Location = new System.Drawing.Point(40, 162);
            this.grpFiltres.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpFiltres.Name = "grpFiltres";
            this.grpFiltres.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpFiltres.Size = new System.Drawing.Size(2172, 417);
            this.grpFiltres.TabIndex = 5;
            this.grpFiltres.TabStop = false;
            this.grpFiltres.Text = "Filtres";
            // 
            // btnValiderNbJoursMission
            // 
            this.btnValiderNbJoursMission.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnValiderNbJoursMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValiderNbJoursMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderNbJoursMission.Location = new System.Drawing.Point(1864, 256);
            this.btnValiderNbJoursMission.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnValiderNbJoursMission.Name = "btnValiderNbJoursMission";
            this.btnValiderNbJoursMission.Size = new System.Drawing.Size(62, 62);
            this.btnValiderNbJoursMission.TabIndex = 17;
            this.btnValiderNbJoursMission.UseVisualStyleBackColor = true;
            this.btnValiderNbJoursMission.Click += new System.EventHandler(this.btnValiderNbJoursMission_Click);
            // 
            // btnValiderNbJoursMin
            // 
            this.btnValiderNbJoursMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnValiderNbJoursMin.BackgroundImage")));
            this.btnValiderNbJoursMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValiderNbJoursMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderNbJoursMin.Location = new System.Drawing.Point(2428, 313);
            this.btnValiderNbJoursMin.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnValiderNbJoursMin.Name = "btnValiderNbJoursMin";
            this.btnValiderNbJoursMin.Size = new System.Drawing.Size(82, 79);
            this.btnValiderNbJoursMin.TabIndex = 16;
            this.btnValiderNbJoursMin.UseVisualStyleBackColor = true;
            // 
            // rdbRAZ
            // 
            this.rdbRAZ.AutoSize = true;
            this.rdbRAZ.Checked = true;
            this.rdbRAZ.Location = new System.Drawing.Point(94, 131);
            this.rdbRAZ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbRAZ.Name = "rdbRAZ";
            this.rdbRAZ.Size = new System.Drawing.Size(162, 48);
            this.rdbRAZ.TabIndex = 15;
            this.rdbRAZ.TabStop = true;
            this.rdbRAZ.Text = "Toutes";
            this.rdbRAZ.UseVisualStyleBackColor = true;
            this.rdbRAZ.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // lblNbMission
            // 
            this.lblNbMission.Location = new System.Drawing.Point(1684, 146);
            this.lblNbMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbMission.Name = "lblNbMission";
            this.lblNbMission.Size = new System.Drawing.Size(416, 98);
            this.lblNbMission.TabIndex = 14;
            this.lblNbMission.Text = "Nombre de jours minimum des missions :";
            this.lblNbMission.Click += new System.EventHandler(this.lblNbMission_Click);
            // 
            // nupNbMissions
            // 
            this.nupNbMissions.Location = new System.Drawing.Point(1690, 260);
            this.nupNbMissions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nupNbMissions.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nupNbMissions.Name = "nupNbMissions";
            this.nupNbMissions.Size = new System.Drawing.Size(160, 51);
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
            this.btnRecherche.Location = new System.Drawing.Point(1468, 254);
            this.btnRecherche.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(62, 62);
            this.btnRecherche.TabIndex = 12;
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // lblBd
            // 
            this.lblBd.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBd.Location = new System.Drawing.Point(1094, 188);
            this.lblBd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBd.Name = "lblBd";
            this.lblBd.Size = new System.Drawing.Size(478, 44);
            this.lblBd.TabIndex = 11;
            this.lblBd.Text = "Budget maximum : ";
            // 
            // txtBudgetMin
            // 
            this.txtBudgetMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBudgetMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBudgetMin.Location = new System.Drawing.Point(1100, 256);
            this.txtBudgetMin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBudgetMin.Name = "txtBudgetMin";
            this.txtBudgetMin.Size = new System.Drawing.Size(354, 51);
            this.txtBudgetMin.TabIndex = 9;
            this.txtBudgetMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBudgetMax_KeyPress);
            // 
            // lblPlanete
            // 
            this.lblPlanete.AutoSize = true;
            this.lblPlanete.Location = new System.Drawing.Point(524, 279);
            this.lblPlanete.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlanete.Name = "lblPlanete";
            this.lblPlanete.Size = new System.Drawing.Size(158, 44);
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
            this.cboPlanete.Location = new System.Drawing.Point(532, 329);
            this.cboPlanete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(434, 52);
            this.cboPlanete.TabIndex = 7;
            this.cboPlanete.SelectionChangeCommitted += new System.EventHandler(this.cbo_SelectionChangeCommitted);
            // 
            // btnRAZ
            // 
            this.btnRAZ.BackgroundImage = global::Formulaire_principal.Properties.Resources.raz_vrai;
            this.btnRAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRAZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRAZ.Location = new System.Drawing.Point(2052, 308);
            this.btnRAZ.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRAZ.Name = "btnRAZ";
            this.btnRAZ.Size = new System.Drawing.Size(86, 81);
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
            this.cboChefMission.Location = new System.Drawing.Point(532, 190);
            this.cboChefMission.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboChefMission.Name = "cboChefMission";
            this.cboChefMission.Size = new System.Drawing.Size(434, 52);
            this.cboChefMission.TabIndex = 5;
            this.cboChefMission.SelectionChangeCommitted += new System.EventHandler(this.cbo_SelectionChangeCommitted);
            // 
            // lblChefMission
            // 
            this.lblChefMission.AutoSize = true;
            this.lblChefMission.Location = new System.Drawing.Point(524, 140);
            this.lblChefMission.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblChefMission.Name = "lblChefMission";
            this.lblChefMission.Size = new System.Drawing.Size(292, 44);
            this.lblChefMission.TabIndex = 4;
            this.lblChefMission.Text = "Chef de mission :";
            // 
            // rdbAVenir
            // 
            this.rdbAVenir.AutoSize = true;
            this.rdbAVenir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbAVenir.Location = new System.Drawing.Point(94, 337);
            this.rdbAVenir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbAVenir.Name = "rdbAVenir";
            this.rdbAVenir.Size = new System.Drawing.Size(166, 48);
            this.rdbAVenir.TabIndex = 3;
            this.rdbAVenir.Text = "À venir";
            this.rdbAVenir.UseVisualStyleBackColor = true;
            this.rdbAVenir.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // rdbEnCours
            // 
            this.rdbEnCours.AutoSize = true;
            this.rdbEnCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbEnCours.Location = new System.Drawing.Point(94, 262);
            this.rdbEnCours.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbEnCours.Name = "rdbEnCours";
            this.rdbEnCours.Size = new System.Drawing.Size(191, 48);
            this.rdbEnCours.TabIndex = 2;
            this.rdbEnCours.Text = "En cours";
            this.rdbEnCours.UseVisualStyleBackColor = true;
            this.rdbEnCours.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // rdbPasse
            // 
            this.rdbPasse.AutoSize = true;
            this.rdbPasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbPasse.Location = new System.Drawing.Point(94, 192);
            this.rdbPasse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbPasse.Name = "rdbPasse";
            this.rdbPasse.Size = new System.Drawing.Size(171, 48);
            this.rdbPasse.TabIndex = 1;
            this.rdbPasse.Text = "Passées";
            this.rdbPasse.UseVisualStyleBackColor = true;
            this.rdbPasse.CheckedChanged += new System.EventHandler(this.btn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "★ Statut des missions : ";
            // 
            // lblTableauDeBord
            // 
            this.lblTableauDeBord.AutoSize = true;
            this.lblTableauDeBord.Font = new System.Drawing.Font("Kristen ITC", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableauDeBord.Location = new System.Drawing.Point(44, 35);
            this.lblTableauDeBord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableauDeBord.Name = "lblTableauDeBord";
            this.lblTableauDeBord.Size = new System.Drawing.Size(627, 74);
            this.lblTableauDeBord.TabIndex = 3;
            this.lblTableauDeBord.Text = "TABLEAU DE BORD";
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.msMenu.BackgroundImage = global::Formulaire_principal.Properties.Resources.Fond_menuStrip;
            this.msMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.msMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.msMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTableauDeBord,
            this.tsmiMission,
            this.tmsiPlanete,
            this.tmsiAliens});
            this.msMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.MinimumSize = new System.Drawing.Size(400, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(10, 6, 0, 6);
            this.msMenu.Size = new System.Drawing.Size(454, 1588);
            this.msMenu.Stretch = false;
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiTableauDeBord
            // 
            this.tsmiTableauDeBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.tsmiTableauDeBord.Checked = true;
            this.tsmiTableauDeBord.CheckOnClick = true;
            this.tsmiTableauDeBord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiTableauDeBord.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiTableauDeBord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tsmiTableauDeBord.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsmiTableauDeBord.Margin = new System.Windows.Forms.Padding(15, 160, 2, 1);
            this.tsmiTableauDeBord.Name = "tsmiTableauDeBord";
            this.tsmiTableauDeBord.Size = new System.Drawing.Size(423, 55);
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
            this.tsmiMission.Size = new System.Drawing.Size(427, 55);
            this.tsmiMission.Text = "★ Créer une mission";
            this.tsmiMission.Click += new System.EventHandler(this.tsmiMission_Click);
            // 
            // tmsiPlanete
            // 
            this.tmsiPlanete.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmsiPlanete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tmsiPlanete.Margin = new System.Windows.Forms.Padding(15, 70, 2, 1);
            this.tmsiPlanete.Name = "tmsiPlanete";
            this.tmsiPlanete.Size = new System.Drawing.Size(415, 55);
            this.tmsiPlanete.Text = "★ Planètes              ";
            this.tmsiPlanete.Click += new System.EventHandler(this.tmsiPlanete_Click);
            // 
            // tmsiAliens
            // 
            this.tmsiAliens.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmsiAliens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tmsiAliens.Margin = new System.Windows.Forms.Padding(15, 70, 2, 1);
            this.tmsiAliens.Name = "tmsiAliens";
            this.tmsiAliens.Size = new System.Drawing.Size(408, 55);
            this.tmsiAliens.Text = "★ Aliens                 ";
            this.tmsiAliens.Click += new System.EventHandler(this.tmsiAliens_Click);
            // 
            // plPlanetes
            // 
            this.plPlanetes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.plPlanetes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plPlanetes.Controls.Add(this.grpPlanetes);
            this.plPlanetes.Controls.Add(this.lblPlanetes);
            this.plPlanetes.Controls.Add(this.grpFiltre);
            this.plPlanetes.Location = new System.Drawing.Point(564, 42);
            this.plPlanetes.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.plPlanetes.Name = "plPlanetes";
            this.plPlanetes.Size = new System.Drawing.Size(2280, 1523);
            this.plPlanetes.TabIndex = 2;
            this.plPlanetes.Visible = false;
            // 
            // grpPlanetes
            // 
            this.grpPlanetes.Controls.Add(this.lblErreur3);
            this.grpPlanetes.Controls.Add(this.flpPlanete);
            this.grpPlanetes.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlanetes.Location = new System.Drawing.Point(890, 129);
            this.grpPlanetes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPlanetes.Name = "grpPlanetes";
            this.grpPlanetes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPlanetes.Size = new System.Drawing.Size(1346, 1362);
            this.grpPlanetes.TabIndex = 5;
            this.grpPlanetes.TabStop = false;
            this.grpPlanetes.Text = "Planètes : ";
            // 
            // lblErreur3
            // 
            this.lblErreur3.AutoSize = true;
            this.lblErreur3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur3.Location = new System.Drawing.Point(340, 635);
            this.lblErreur3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblErreur3.Name = "lblErreur3";
            this.lblErreur3.Size = new System.Drawing.Size(586, 31);
            this.lblErreur3.TabIndex = 1;
            this.lblErreur3.Text = "Aucun résultat ne correspond à votre recherche";
            this.lblErreur3.Visible = false;
            // 
            // flpPlanete
            // 
            this.flpPlanete.AutoScroll = true;
            this.flpPlanete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flpPlanete.Location = new System.Drawing.Point(12, 58);
            this.flpPlanete.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.flpPlanete.Name = "flpPlanete";
            this.flpPlanete.Size = new System.Drawing.Size(1322, 1288);
            this.flpPlanete.TabIndex = 2;
            // 
            // lblPlanetes
            // 
            this.lblPlanetes.AutoSize = true;
            this.lblPlanetes.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetes.Location = new System.Drawing.Point(44, 35);
            this.lblPlanetes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlanetes.Name = "lblPlanetes";
            this.lblPlanetes.Size = new System.Drawing.Size(390, 74);
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
            this.grpFiltre.Location = new System.Drawing.Point(48, 123);
            this.grpFiltre.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpFiltre.Size = new System.Drawing.Size(830, 1365);
            this.grpFiltre.TabIndex = 3;
            this.grpFiltre.TabStop = false;
            this.grpFiltre.Text = "Filtres";
            // 
            // grpEspeces
            // 
            this.grpEspeces.Controls.Add(this.flpEspece);
            this.grpEspeces.Location = new System.Drawing.Point(56, 708);
            this.grpEspeces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEspeces.Name = "grpEspeces";
            this.grpEspeces.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEspeces.Size = new System.Drawing.Size(604, 275);
            this.grpEspeces.TabIndex = 28;
            this.grpEspeces.TabStop = false;
            this.grpEspeces.Text = "Espèces :";
            // 
            // flpEspece
            // 
            this.flpEspece.AutoScroll = true;
            this.flpEspece.Location = new System.Drawing.Point(12, 54);
            this.flpEspece.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.flpEspece.Name = "flpEspece";
            this.flpEspece.Size = new System.Drawing.Size(580, 210);
            this.flpEspece.TabIndex = 22;
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnRechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.Location = new System.Drawing.Point(692, 1248);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(106, 96);
            this.btnRechercher.TabIndex = 23;
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 465);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 44);
            this.label7.TabIndex = 27;
            this.label7.Text = "Max";
            // 
            // btnReinitialiserEspeces
            // 
            this.btnReinitialiserEspeces.BackgroundImage = global::Formulaire_principal.Properties.Resources.reinitialiser3;
            this.btnReinitialiserEspeces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReinitialiserEspeces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinitialiserEspeces.Location = new System.Drawing.Point(682, 904);
            this.btnReinitialiserEspeces.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnReinitialiserEspeces.Name = "btnReinitialiserEspeces";
            this.btnReinitialiserEspeces.Size = new System.Drawing.Size(86, 79);
            this.btnReinitialiserEspeces.TabIndex = 26;
            this.btnReinitialiserEspeces.UseVisualStyleBackColor = true;
            this.btnReinitialiserEspeces.Click += new System.EventHandler(this.btnReinitialiserEspeces_Click);
            // 
            // btnReinitialiserDataBaz
            // 
            this.btnReinitialiserDataBaz.BackgroundImage = global::Formulaire_principal.Properties.Resources.reinitialiser3;
            this.btnReinitialiserDataBaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReinitialiserDataBaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinitialiserDataBaz.Location = new System.Drawing.Point(604, 590);
            this.btnReinitialiserDataBaz.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnReinitialiserDataBaz.Name = "btnReinitialiserDataBaz";
            this.btnReinitialiserDataBaz.Size = new System.Drawing.Size(86, 79);
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
            this.btnReinitialiser.Location = new System.Drawing.Point(556, 1250);
            this.btnReinitialiser.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(106, 96);
            this.btnReinitialiser.TabIndex = 24;
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // txtMaxMission
            // 
            this.txtMaxMission.Location = new System.Drawing.Point(338, 1175);
            this.txtMaxMission.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMaxMission.Name = "txtMaxMission";
            this.txtMaxMission.Size = new System.Drawing.Size(164, 51);
            this.txtMaxMission.TabIndex = 21;
            this.txtMaxMission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxMission_KeyDown);
            this.txtMaxMission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxMission_KeyPress);
            // 
            // txtMinMission
            // 
            this.txtMinMission.Location = new System.Drawing.Point(338, 1096);
            this.txtMinMission.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMinMission.Name = "txtMinMission";
            this.txtMinMission.Size = new System.Drawing.Size(164, 51);
            this.txtMinMission.TabIndex = 20;
            this.txtMinMission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinMission_KeyDown);
            this.txtMinMission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinMission_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(130, 1100);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 44);
            this.label11.TabIndex = 19;
            this.label11.Text = "Minimum : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(130, 1179);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 44);
            this.label12.TabIndex = 18;
            this.label12.Text = "Maximum :";
            // 
            // rdbSans
            // 
            this.rdbSans.AutoSize = true;
            this.rdbSans.Location = new System.Drawing.Point(464, 604);
            this.rdbSans.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rdbSans.Name = "rdbSans";
            this.rdbSans.Size = new System.Drawing.Size(122, 48);
            this.rdbSans.TabIndex = 17;
            this.rdbSans.TabStop = true;
            this.rdbSans.Text = "Sans";
            this.rdbSans.UseVisualStyleBackColor = true;
            this.rdbSans.Click += new System.EventHandler(this.rdbSans_Click);
            // 
            // rdbAvec
            // 
            this.rdbAvec.AutoSize = true;
            this.rdbAvec.Location = new System.Drawing.Point(298, 604);
            this.rdbAvec.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.rdbAvec.Name = "rdbAvec";
            this.rdbAvec.Size = new System.Drawing.Size(133, 48);
            this.rdbAvec.TabIndex = 16;
            this.rdbAvec.TabStop = true;
            this.rdbAvec.Text = "Avec";
            this.rdbAvec.UseVisualStyleBackColor = true;
            this.rdbAvec.Click += new System.EventHandler(this.rdbAvec_Click);
            // 
            // txtMaxGrav
            // 
            this.txtMaxGrav.Location = new System.Drawing.Point(420, 458);
            this.txtMaxGrav.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMaxGrav.Name = "txtMaxGrav";
            this.txtMaxGrav.Size = new System.Drawing.Size(148, 51);
            this.txtMaxGrav.TabIndex = 15;
            this.txtMaxGrav.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxGrav_KeyDown);
            this.txtMaxGrav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxGrav_KeyPress);
            // 
            // txtMinGrav
            // 
            this.txtMinGrav.Location = new System.Drawing.Point(420, 379);
            this.txtMinGrav.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMinGrav.Name = "txtMinGrav";
            this.txtMinGrav.Size = new System.Drawing.Size(148, 51);
            this.txtMinGrav.TabIndex = 14;
            this.txtMinGrav.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinGrav_KeyDown);
            this.txtMinGrav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinGrav_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 388);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 44);
            this.label5.TabIndex = 13;
            this.label5.Text = "Min";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(420, 246);
            this.txtMaxTemp.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(148, 51);
            this.txtMaxTemp.TabIndex = 11;
            this.txtMaxTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxTemp_KeyDown);
            this.txtMaxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxTemp_KeyPress);
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(420, 171);
            this.txtMinTemp.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(148, 51);
            this.txtMinTemp.TabIndex = 10;
            this.txtMinTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinTemp_KeyDown);
            this.txtMinTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinTemp_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(316, 173);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 44);
            this.label13.TabIndex = 9;
            this.label13.Text = "Min";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 246);
            this.label14.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 44);
            this.label14.TabIndex = 8;
            this.label14.Text = "Max";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(212, 75);
            this.txtNom.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(412, 51);
            this.txtNom.TabIndex = 7;
            this.txtNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNom_KeyDown);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(68, 379);
            this.label16.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 44);
            this.label16.TabIndex = 5;
            this.label16.Text = "Gravité :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(72, 604);
            this.label17.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(176, 44);
            this.label17.TabIndex = 4;
            this.label17.Text = "DataBaz :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(56, 175);
            this.label18.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(243, 44);
            this.label18.TabIndex = 3;
            this.label18.Text = "Temperature :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(74, 1017);
            this.label19.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(517, 44);
            this.label19.TabIndex = 2;
            this.label19.Text = "Nombre de missions effectués :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(56, 75);
            this.label20.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 44);
            this.label20.TabIndex = 0;
            this.label20.Text = "Nom :";
            // 
            // plAliens
            // 
            this.plAliens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.plAliens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plAliens.Controls.Add(this.lblAliens);
            this.plAliens.Controls.Add(this.grpFiltresAlliees);
            this.plAliens.Controls.Add(this.groupBox3);
            this.plAliens.Controls.Add(this.grpAlliees);
            this.plAliens.Controls.Add(this.grpFiltresEnnemis);
            this.plAliens.Location = new System.Drawing.Point(564, 42);
            this.plAliens.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.plAliens.Name = "plAliens";
            this.plAliens.Size = new System.Drawing.Size(2280, 1521);
            this.plAliens.TabIndex = 1;
            // 
            // lblAliens
            // 
            this.lblAliens.AutoSize = true;
            this.lblAliens.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliens.Location = new System.Drawing.Point(44, 35);
            this.lblAliens.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAliens.Name = "lblAliens";
            this.lblAliens.Size = new System.Drawing.Size(278, 74);
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
            this.grpFiltresAlliees.Location = new System.Drawing.Point(8, 123);
            this.grpFiltresAlliees.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpFiltresAlliees.Name = "grpFiltresAlliees";
            this.grpFiltresAlliees.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpFiltresAlliees.Size = new System.Drawing.Size(1120, 502);
            this.grpFiltresAlliees.TabIndex = 4;
            this.grpFiltresAlliees.TabStop = false;
            this.grpFiltresAlliees.Text = "Filtres";
            // 
            // btnReinitialiserAlliees
            // 
            this.btnReinitialiserAlliees.BackgroundImage = global::Formulaire_principal.Properties.Resources.raz_vrai;
            this.btnReinitialiserAlliees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReinitialiserAlliees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinitialiserAlliees.Location = new System.Drawing.Point(884, 406);
            this.btnReinitialiserAlliees.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnReinitialiserAlliees.Name = "btnReinitialiserAlliees";
            this.btnReinitialiserAlliees.Size = new System.Drawing.Size(86, 81);
            this.btnReinitialiserAlliees.TabIndex = 11;
            this.btnReinitialiserAlliees.UseVisualStyleBackColor = true;
            this.btnReinitialiserAlliees.Click += new System.EventHandler(this.btnReinitialiserAlliees_Click);
            // 
            // cboBienveillance
            // 
            this.cboBienveillance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBienveillance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBienveillance.FormattingEnabled = true;
            this.cboBienveillance.Location = new System.Drawing.Point(556, 263);
            this.cboBienveillance.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cboBienveillance.Name = "cboBienveillance";
            this.cboBienveillance.Size = new System.Drawing.Size(444, 52);
            this.cboBienveillance.TabIndex = 9;
            this.cboBienveillance.SelectedIndexChanged += new System.EventHandler(this.cboBienveillance_SelectedIndexChanged);
            this.cboBienveillance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AliensAllies_KeyDown);
            // 
            // btnRechercherAlliees
            // 
            this.btnRechercherAlliees.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnRechercherAlliees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRechercherAlliees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherAlliees.Location = new System.Drawing.Point(1016, 406);
            this.btnRechercherAlliees.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnRechercherAlliees.Name = "btnRechercherAlliees";
            this.btnRechercherAlliees.Size = new System.Drawing.Size(86, 81);
            this.btnRechercherAlliees.TabIndex = 2;
            this.btnRechercherAlliees.UseVisualStyleBackColor = true;
            this.btnRechercherAlliees.Click += new System.EventHandler(this.btnRechercherAlliees_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bienveillance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Couleur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom (like)";
            // 
            // cboCouleurAlliees
            // 
            this.cboCouleurAlliees.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCouleurAlliees.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCouleurAlliees.FormattingEnabled = true;
            this.cboCouleurAlliees.Location = new System.Drawing.Point(18, 263);
            this.cboCouleurAlliees.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cboCouleurAlliees.Name = "cboCouleurAlliees";
            this.cboCouleurAlliees.Size = new System.Drawing.Size(444, 52);
            this.cboCouleurAlliees.TabIndex = 1;
            this.cboCouleurAlliees.SelectedIndexChanged += new System.EventHandler(this.cboCouleurAlliees_SelectedIndexChanged);
            this.cboCouleurAlliees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AliensAllies_KeyDown);
            // 
            // txtNomAlliees
            // 
            this.txtNomAlliees.Location = new System.Drawing.Point(18, 113);
            this.txtNomAlliees.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtNomAlliees.Name = "txtNomAlliees";
            this.txtNomAlliees.Size = new System.Drawing.Size(444, 51);
            this.txtNomAlliees.TabIndex = 0;
            this.txtNomAlliees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomAlliees_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblErreur2);
            this.groupBox3.Controls.Add(this.flp2);
            this.groupBox3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1144, 642);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox3.Size = new System.Drawing.Size(1128, 869);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informations sur les races ennemies";
            // 
            // lblErreur2
            // 
            this.lblErreur2.AutoSize = true;
            this.lblErreur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur2.Location = new System.Drawing.Point(200, 433);
            this.lblErreur2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblErreur2.Name = "lblErreur2";
            this.lblErreur2.Size = new System.Drawing.Size(586, 31);
            this.lblErreur2.TabIndex = 1;
            this.lblErreur2.Text = "Aucun résultat ne correspond à votre recherche";
            this.lblErreur2.Visible = false;
            // 
            // flp2
            // 
            this.flp2.AutoScroll = true;
            this.flp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp2.Location = new System.Drawing.Point(8, 52);
            this.flp2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(1112, 809);
            this.flp2.TabIndex = 0;
            // 
            // grpAlliees
            // 
            this.grpAlliees.Controls.Add(this.lblErreur);
            this.grpAlliees.Controls.Add(this.flp1);
            this.grpAlliees.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAlliees.Location = new System.Drawing.Point(8, 642);
            this.grpAlliees.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpAlliees.Name = "grpAlliees";
            this.grpAlliees.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpAlliees.Size = new System.Drawing.Size(1120, 869);
            this.grpAlliees.TabIndex = 5;
            this.grpAlliees.TabStop = false;
            this.grpAlliees.Text = "Informations sur les races alliées";
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.Location = new System.Drawing.Point(200, 433);
            this.lblErreur.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(586, 31);
            this.lblErreur.TabIndex = 0;
            this.lblErreur.Text = "Aucun résultat ne correspond à votre recherche";
            this.lblErreur.Visible = false;
            // 
            // flp1
            // 
            this.flp1.AutoScroll = true;
            this.flp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp1.Location = new System.Drawing.Point(8, 52);
            this.flp1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(1104, 809);
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
            this.grpFiltresEnnemis.Location = new System.Drawing.Point(1144, 127);
            this.grpFiltresEnnemis.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpFiltresEnnemis.Name = "grpFiltresEnnemis";
            this.grpFiltresEnnemis.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.grpFiltresEnnemis.Size = new System.Drawing.Size(1128, 498);
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
            this.btnReinitialiserEnnemis.Location = new System.Drawing.Point(910, 402);
            this.btnReinitialiserEnnemis.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnReinitialiserEnnemis.Name = "btnReinitialiserEnnemis";
            this.btnReinitialiserEnnemis.Size = new System.Drawing.Size(86, 81);
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
            this.cboAgressivite.Location = new System.Drawing.Point(26, 417);
            this.cboAgressivite.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cboAgressivite.Name = "cboAgressivite";
            this.cboAgressivite.Size = new System.Drawing.Size(444, 52);
            this.cboAgressivite.TabIndex = 10;
            this.cboAgressivite.SelectedIndexChanged += new System.EventHandler(this.cboAgressivite_SelectedIndexChanged);
            this.cboAgressivite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AliensEnnemis_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 44);
            this.label6.TabIndex = 8;
            this.label6.Text = "Agressivité";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(538, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 44);
            this.label8.TabIndex = 6;
            this.label8.Text = "Type arme";
            // 
            // cboTypeArme
            // 
            this.cboTypeArme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTypeArme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTypeArme.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeArme.FormattingEnabled = true;
            this.cboTypeArme.Location = new System.Drawing.Point(546, 273);
            this.cboTypeArme.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cboTypeArme.Name = "cboTypeArme";
            this.cboTypeArme.Size = new System.Drawing.Size(444, 52);
            this.cboTypeArme.TabIndex = 5;
            this.cboTypeArme.SelectedIndexChanged += new System.EventHandler(this.cboTypeArme_SelectedIndexChanged);
            this.cboTypeArme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AliensEnnemis_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 44);
            this.label9.TabIndex = 4;
            this.label9.Text = "Couleur";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 44);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nom (like)";
            // 
            // btnRechercherEnnemis
            // 
            this.btnRechercherEnnemis.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnRechercherEnnemis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRechercherEnnemis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercherEnnemis.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercherEnnemis.Location = new System.Drawing.Point(1028, 404);
            this.btnRechercherEnnemis.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnRechercherEnnemis.Name = "btnRechercherEnnemis";
            this.btnRechercherEnnemis.Size = new System.Drawing.Size(86, 81);
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
            this.cboCouleurEnnemis.Location = new System.Drawing.Point(22, 273);
            this.cboCouleurEnnemis.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cboCouleurEnnemis.Name = "cboCouleurEnnemis";
            this.cboCouleurEnnemis.Size = new System.Drawing.Size(444, 52);
            this.cboCouleurEnnemis.TabIndex = 1;
            this.cboCouleurEnnemis.SelectedIndexChanged += new System.EventHandler(this.cboCouleurEnnemis_SelectedIndexChanged);
            this.cboCouleurEnnemis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AliensEnnemis_KeyDown);
            // 
            // txtNomEnnemis
            // 
            this.txtNomEnnemis.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomEnnemis.Location = new System.Drawing.Point(26, 138);
            this.txtNomEnnemis.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtNomEnnemis.Name = "txtNomEnnemis";
            this.txtNomEnnemis.Size = new System.Drawing.Size(444, 51);
            this.txtNomEnnemis.TabIndex = 0;
            this.txtNomEnnemis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomEnnemis_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formulaire_principal.Properties.Resources.fond_acceuil1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2884, 1588);
            this.Controls.Add(this.plAliens);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.plMissions);
            this.Controls.Add(this.plPlanetes);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
    }
}

