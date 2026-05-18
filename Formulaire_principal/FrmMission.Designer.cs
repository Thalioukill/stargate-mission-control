namespace Formulaire_principal
{
    partial class FrmMission
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
            this.grpNouvelleMission = new System.Windows.Forms.GroupBox();
            this.pnlSection1 = new System.Windows.Forms.Panel();
            this.btnValidMission = new System.Windows.Forms.Button();
            this.lblEuros = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblTonnes = new System.Windows.Forms.Label();
            this.txtobjDataBaz = new System.Windows.Forms.TextBox();
            this.lblObjDataBaz = new System.Windows.Forms.Label();
            this.lblPersonnes = new System.Windows.Forms.Label();
            this.txtnbMembres = new System.Windows.Forms.TextBox();
            this.lblNbMembres = new System.Windows.Forms.Label();
            this.txtfeuilleRoute = new System.Windows.Forms.TextBox();
            this.lblFDR = new System.Windows.Forms.Label();
            this.dtpRetour = new System.Windows.Forms.DateTimePicker();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblParam = new System.Windows.Forms.Label();
            this.lblChef = new System.Windows.Forms.Label();
            this.cboChef = new System.Windows.Forms.ComboBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.lblChoix = new System.Windows.Forms.Label();
            this.grpPrecisions = new System.Windows.Forms.GroupBox();
            this.pnlSection2 = new System.Windows.Forms.Panel();
            this.btnSuppSelect = new System.Windows.Forms.Button();
            this.btnAddSelect = new System.Windows.Forms.Button();
            this.lblMembresAffect = new System.Windows.Forms.Label();
            this.btnRefaire = new System.Windows.Forms.Button();
            this.lstbMembres = new System.Windows.Forms.ListBox();
            this.lblNomMembre = new System.Windows.Forms.Label();
            this.lstbPartis = new System.Windows.Forms.ListBox();
            this.btnvalidMembres = new System.Windows.Forms.Button();
            this.btnAddMembre = new System.Windows.Forms.Button();
            this.cboMembres = new System.Windows.Forms.ComboBox();
            this.lblreste = new System.Windows.Forms.Label();
            this.lblAffect = new System.Windows.Forms.Label();
            this.pnlSection3 = new System.Windows.Forms.Panel();
            this.btnSuppSelectCapt = new System.Windows.Forms.Button();
            this.btnAddCapture = new System.Windows.Forms.Button();
            this.btnValidObj = new System.Windows.Forms.Button();
            this.lstbCaptures = new System.Windows.Forms.ListBox();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.cboCaptures = new System.Windows.Forms.ComboBox();
            this.lblObjCapture = new System.Windows.Forms.Label();
            this.grpNouvelleMission.SuspendLayout();
            this.pnlSection1.SuspendLayout();
            this.grpPrecisions.SuspendLayout();
            this.pnlSection2.SuspendLayout();
            this.pnlSection3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNouvelleMission
            // 
            this.grpNouvelleMission.AutoSize = true;
            this.grpNouvelleMission.Controls.Add(this.pnlSection1);
            this.grpNouvelleMission.Location = new System.Drawing.Point(17, 14);
            this.grpNouvelleMission.Name = "grpNouvelleMission";
            this.grpNouvelleMission.Size = new System.Drawing.Size(1013, 1266);
            this.grpNouvelleMission.TabIndex = 0;
            this.grpNouvelleMission.TabStop = false;
            this.grpNouvelleMission.Text = "Nouvelle mission";
            // 
            // pnlSection1
            // 
            this.pnlSection1.Controls.Add(this.btnValidMission);
            this.pnlSection1.Controls.Add(this.lblEuros);
            this.pnlSection1.Controls.Add(this.txtBudget);
            this.pnlSection1.Controls.Add(this.lblBudget);
            this.pnlSection1.Controls.Add(this.lblTonnes);
            this.pnlSection1.Controls.Add(this.txtobjDataBaz);
            this.pnlSection1.Controls.Add(this.lblObjDataBaz);
            this.pnlSection1.Controls.Add(this.lblPersonnes);
            this.pnlSection1.Controls.Add(this.txtnbMembres);
            this.pnlSection1.Controls.Add(this.lblNbMembres);
            this.pnlSection1.Controls.Add(this.txtfeuilleRoute);
            this.pnlSection1.Controls.Add(this.lblFDR);
            this.pnlSection1.Controls.Add(this.dtpRetour);
            this.pnlSection1.Controls.Add(this.dtpDepart);
            this.pnlSection1.Controls.Add(this.lblDateRetour);
            this.pnlSection1.Controls.Add(this.lblDateDepart);
            this.pnlSection1.Controls.Add(this.lblParam);
            this.pnlSection1.Controls.Add(this.lblChef);
            this.pnlSection1.Controls.Add(this.cboChef);
            this.pnlSection1.Controls.Add(this.lblNum);
            this.pnlSection1.Controls.Add(this.lblNomMission);
            this.pnlSection1.Controls.Add(this.cboPlanete);
            this.pnlSection1.Controls.Add(this.lblChoix);
            this.pnlSection1.Location = new System.Drawing.Point(31, 36);
            this.pnlSection1.Name = "pnlSection1";
            this.pnlSection1.Size = new System.Drawing.Size(964, 1188);
            this.pnlSection1.TabIndex = 0;
            // 
            // btnValidMission
            // 
            this.btnValidMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidMission.Location = new System.Drawing.Point(725, 1075);
            this.btnValidMission.Name = "btnValidMission";
            this.btnValidMission.Size = new System.Drawing.Size(188, 86);
            this.btnValidMission.TabIndex = 60;
            this.btnValidMission.Text = "Valider la mission";
            this.btnValidMission.UseVisualStyleBackColor = true;
            this.btnValidMission.Click += new System.EventHandler(this.btnValidMission_Click);
            // 
            // lblEuros
            // 
            this.lblEuros.AutoSize = true;
            this.lblEuros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEuros.Location = new System.Drawing.Point(380, 1011);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(24, 25);
            this.lblEuros.TabIndex = 59;
            this.lblEuros.Text = "€";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(299, 1008);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(62, 31);
            this.txtBudget.TabIndex = 58;
            this.txtBudget.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBudget_KeyDown);
            this.txtBudget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBudget_KeyPress);
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBudget.Location = new System.Drawing.Point(61, 1011);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(80, 25);
            this.lblBudget.TabIndex = 57;
            this.lblBudget.Text = "Budget";
            // 
            // lblTonnes
            // 
            this.lblTonnes.AutoSize = true;
            this.lblTonnes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTonnes.Location = new System.Drawing.Point(380, 930);
            this.lblTonnes.Name = "lblTonnes";
            this.lblTonnes.Size = new System.Drawing.Size(77, 25);
            this.lblTonnes.TabIndex = 56;
            this.lblTonnes.Text = "tonnes";
            // 
            // txtobjDataBaz
            // 
            this.txtobjDataBaz.Location = new System.Drawing.Point(299, 927);
            this.txtobjDataBaz.Name = "txtobjDataBaz";
            this.txtobjDataBaz.Size = new System.Drawing.Size(62, 31);
            this.txtobjDataBaz.TabIndex = 55;
            this.txtobjDataBaz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtobjDataBaz_KeyDown);
            this.txtobjDataBaz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtobjDataBaz_KeyPress);
            // 
            // lblObjDataBaz
            // 
            this.lblObjDataBaz.AutoSize = true;
            this.lblObjDataBaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObjDataBaz.Location = new System.Drawing.Point(61, 930);
            this.lblObjDataBaz.Name = "lblObjDataBaz";
            this.lblObjDataBaz.Size = new System.Drawing.Size(173, 25);
            this.lblObjDataBaz.TabIndex = 54;
            this.lblObjDataBaz.Text = "Objectif DataBaz";
            // 
            // lblPersonnes
            // 
            this.lblPersonnes.AutoSize = true;
            this.lblPersonnes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPersonnes.Location = new System.Drawing.Point(380, 855);
            this.lblPersonnes.Name = "lblPersonnes";
            this.lblPersonnes.Size = new System.Drawing.Size(115, 25);
            this.lblPersonnes.TabIndex = 53;
            this.lblPersonnes.Text = "Personnes";
            // 
            // txtnbMembres
            // 
            this.txtnbMembres.Location = new System.Drawing.Point(299, 852);
            this.txtnbMembres.Name = "txtnbMembres";
            this.txtnbMembres.Size = new System.Drawing.Size(62, 31);
            this.txtnbMembres.TabIndex = 52;
            this.txtnbMembres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnbMembres_KeyDown);
            this.txtnbMembres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnbMembres_KeyPress);
            // 
            // lblNbMembres
            // 
            this.lblNbMembres.AutoSize = true;
            this.lblNbMembres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNbMembres.Location = new System.Drawing.Point(61, 855);
            this.lblNbMembres.Name = "lblNbMembres";
            this.lblNbMembres.Size = new System.Drawing.Size(211, 25);
            this.lblNbMembres.TabIndex = 51;
            this.lblNbMembres.Text = "Nombre de membres";
            // 
            // txtfeuilleRoute
            // 
            this.txtfeuilleRoute.Location = new System.Drawing.Point(299, 580);
            this.txtfeuilleRoute.Multiline = true;
            this.txtfeuilleRoute.Name = "txtfeuilleRoute";
            this.txtfeuilleRoute.Size = new System.Drawing.Size(614, 230);
            this.txtfeuilleRoute.TabIndex = 50;
            this.txtfeuilleRoute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfeuilleRoute_KeyDown);
            // 
            // lblFDR
            // 
            this.lblFDR.AutoSize = true;
            this.lblFDR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFDR.Location = new System.Drawing.Point(61, 583);
            this.lblFDR.Name = "lblFDR";
            this.lblFDR.Size = new System.Drawing.Size(161, 25);
            this.lblFDR.TabIndex = 49;
            this.lblFDR.Text = "Feuille de route";
            // 
            // dtpRetour
            // 
            this.dtpRetour.CustomFormat = "dd/MM/yyyy";
            this.dtpRetour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRetour.Location = new System.Drawing.Point(299, 480);
            this.dtpRetour.Name = "dtpRetour";
            this.dtpRetour.Size = new System.Drawing.Size(220, 31);
            this.dtpRetour.TabIndex = 48;
            // 
            // dtpDepart
            // 
            this.dtpDepart.CustomFormat = "dd/MM/yyyy";
            this.dtpDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepart.Location = new System.Drawing.Point(299, 401);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(220, 31);
            this.dtpDepart.TabIndex = 47;
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateRetour.Location = new System.Drawing.Point(61, 485);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(119, 25);
            this.lblDateRetour.TabIndex = 46;
            this.lblDateRetour.Text = "Date retour";
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateDepart.Location = new System.Drawing.Point(61, 406);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(124, 25);
            this.lblDateDepart.TabIndex = 45;
            this.lblDateDepart.Text = "Date départ";
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblParam.Location = new System.Drawing.Point(29, 333);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(279, 25);
            this.lblParam.TabIndex = 44;
            this.lblParam.Text = "3- Paramètres de la mission";
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChef.Location = new System.Drawing.Point(29, 230);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(284, 25);
            this.lblChef.TabIndex = 43;
            this.lblChef.Text = "2 - Choix du chef de mission";
            // 
            // cboChef
            // 
            this.cboChef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboChef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboChef.FormattingEnabled = true;
            this.cboChef.Location = new System.Drawing.Point(335, 227);
            this.cboChef.Name = "cboChef";
            this.cboChef.Size = new System.Drawing.Size(450, 33);
            this.cboChef.TabIndex = 3;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(765, 118);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(124, 42);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "label1";
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMission.Location = new System.Drawing.Point(32, 118);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(124, 42);
            this.lblNomMission.TabIndex = 3;
            this.lblNomMission.Text = "label1";
            // 
            // cboPlanete
            // 
            this.cboPlanete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPlanete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPlanete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlanete.FormattingEnabled = true;
            this.cboPlanete.Location = new System.Drawing.Point(335, 28);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(352, 33);
            this.cboPlanete.TabIndex = 1;
            this.cboPlanete.SelectedIndexChanged += new System.EventHandler(this.cboPlanete_SelectedIndexChanged);
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Location = new System.Drawing.Point(28, 33);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(228, 25);
            this.lblChoix.TabIndex = 0;
            this.lblChoix.Text = "1 - Choix de la planète";
            // 
            // grpPrecisions
            // 
            this.grpPrecisions.Controls.Add(this.pnlSection3);
            this.grpPrecisions.Controls.Add(this.pnlSection2);
            this.grpPrecisions.Location = new System.Drawing.Point(1030, 14);
            this.grpPrecisions.Name = "grpPrecisions";
            this.grpPrecisions.Size = new System.Drawing.Size(1059, 1266);
            this.grpPrecisions.TabIndex = 1;
            this.grpPrecisions.TabStop = false;
            this.grpPrecisions.Text = "Précisions sur la mission créée";
            // 
            // pnlSection2
            // 
            this.pnlSection2.Controls.Add(this.btnSuppSelect);
            this.pnlSection2.Controls.Add(this.btnAddSelect);
            this.pnlSection2.Controls.Add(this.lblMembresAffect);
            this.pnlSection2.Controls.Add(this.btnRefaire);
            this.pnlSection2.Controls.Add(this.lstbMembres);
            this.pnlSection2.Controls.Add(this.lblNomMembre);
            this.pnlSection2.Controls.Add(this.lstbPartis);
            this.pnlSection2.Controls.Add(this.btnvalidMembres);
            this.pnlSection2.Controls.Add(this.btnAddMembre);
            this.pnlSection2.Controls.Add(this.cboMembres);
            this.pnlSection2.Controls.Add(this.lblreste);
            this.pnlSection2.Controls.Add(this.lblAffect);
            this.pnlSection2.Location = new System.Drawing.Point(18, 61);
            this.pnlSection2.Name = "pnlSection2";
            this.pnlSection2.Size = new System.Drawing.Size(1016, 809);
            this.pnlSection2.TabIndex = 27;
            // 
            // btnSuppSelect
            // 
            this.btnSuppSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppSelect.Location = new System.Drawing.Point(473, 730);
            this.btnSuppSelect.Name = "btnSuppSelect";
            this.btnSuppSelect.Size = new System.Drawing.Size(272, 55);
            this.btnSuppSelect.TabIndex = 26;
            this.btnSuppSelect.Text = "Supprimer la sélection";
            this.btnSuppSelect.UseVisualStyleBackColor = true;
            this.btnSuppSelect.Click += new System.EventHandler(this.btnSuppSelect_Click);
            // 
            // btnAddSelect
            // 
            this.btnAddSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSelect.Location = new System.Drawing.Point(396, 381);
            this.btnAddSelect.Name = "btnAddSelect";
            this.btnAddSelect.Size = new System.Drawing.Size(272, 55);
            this.btnAddSelect.TabIndex = 25;
            this.btnAddSelect.Text = "Ajouter la sélection";
            this.btnAddSelect.UseVisualStyleBackColor = true;
            this.btnAddSelect.Click += new System.EventHandler(this.btnAddSelect_Click);
            // 
            // lblMembresAffect
            // 
            this.lblMembresAffect.AutoSize = true;
            this.lblMembresAffect.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblMembresAffect.Location = new System.Drawing.Point(38, 489);
            this.lblMembresAffect.Name = "lblMembresAffect";
            this.lblMembresAffect.Size = new System.Drawing.Size(235, 25);
            this.lblMembresAffect.TabIndex = 17;
            this.lblMembresAffect.Text = "Les membres affectés :";
            // 
            // btnRefaire
            // 
            this.btnRefaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefaire.Location = new System.Drawing.Point(699, 382);
            this.btnRefaire.Name = "btnRefaire";
            this.btnRefaire.Size = new System.Drawing.Size(272, 55);
            this.btnRefaire.TabIndex = 16;
            this.btnRefaire.Text = "Refaire la même équipe";
            this.btnRefaire.UseVisualStyleBackColor = true;
            this.btnRefaire.Click += new System.EventHandler(this.btnRefaire_Click);
            // 
            // lstbMembres
            // 
            this.lstbMembres.FormattingEnabled = true;
            this.lstbMembres.ItemHeight = 25;
            this.lstbMembres.Location = new System.Drawing.Point(43, 531);
            this.lstbMembres.Name = "lstbMembres";
            this.lstbMembres.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbMembres.Size = new System.Drawing.Size(928, 179);
            this.lstbMembres.TabIndex = 15;
            // 
            // lblNomMembre
            // 
            this.lblNomMembre.AutoSize = true;
            this.lblNomMembre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNomMembre.Location = new System.Drawing.Point(38, 144);
            this.lblNomMembre.Name = "lblNomMembre";
            this.lblNomMembre.Size = new System.Drawing.Size(56, 25);
            this.lblNomMembre.TabIndex = 13;
            this.lblNomMembre.Text = "Nom";
            // 
            // lstbPartis
            // 
            this.lstbPartis.FormattingEnabled = true;
            this.lstbPartis.ItemHeight = 25;
            this.lstbPartis.Location = new System.Drawing.Point(43, 188);
            this.lstbPartis.Name = "lstbPartis";
            this.lstbPartis.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbPartis.Size = new System.Drawing.Size(928, 179);
            this.lstbPartis.TabIndex = 12;
            // 
            // btnvalidMembres
            // 
            this.btnvalidMembres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvalidMembres.Location = new System.Drawing.Point(771, 730);
            this.btnvalidMembres.Name = "btnvalidMembres";
            this.btnvalidMembres.Size = new System.Drawing.Size(200, 55);
            this.btnvalidMembres.TabIndex = 11;
            this.btnvalidMembres.Text = "Valider membres";
            this.btnvalidMembres.UseVisualStyleBackColor = true;
            this.btnvalidMembres.Click += new System.EventHandler(this.btnvalidMembres_Click);
            // 
            // btnAddMembre
            // 
            this.btnAddMembre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMembre.Location = new System.Drawing.Point(792, 71);
            this.btnAddMembre.Name = "btnAddMembre";
            this.btnAddMembre.Size = new System.Drawing.Size(179, 49);
            this.btnAddMembre.TabIndex = 9;
            this.btnAddMembre.Text = "Ajouter";
            this.btnAddMembre.UseVisualStyleBackColor = true;
            this.btnAddMembre.Click += new System.EventHandler(this.btnAddMembre_Click);
            // 
            // cboMembres
            // 
            this.cboMembres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMembres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMembres.FormattingEnabled = true;
            this.cboMembres.Location = new System.Drawing.Point(43, 80);
            this.cboMembres.Name = "cboMembres";
            this.cboMembres.Size = new System.Drawing.Size(702, 33);
            this.cboMembres.TabIndex = 8;
            this.cboMembres.SelectedIndexChanged += new System.EventHandler(this.cboMembres_SelectedIndexChanged);
            // 
            // lblreste
            // 
            this.lblreste.AutoSize = true;
            this.lblreste.Location = new System.Drawing.Point(510, 11);
            this.lblreste.Name = "lblreste";
            this.lblreste.Size = new System.Drawing.Size(18, 25);
            this.lblreste.TabIndex = 7;
            this.lblreste.Text = ".";
            // 
            // lblAffect
            // 
            this.lblAffect.AutoSize = true;
            this.lblAffect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAffect.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAffect.Location = new System.Drawing.Point(38, 11);
            this.lblAffect.Name = "lblAffect";
            this.lblAffect.Size = new System.Drawing.Size(455, 25);
            this.lblAffect.TabIndex = 6;
            this.lblAffect.Text = "4 - Affectation des membres - reste à affecter :";
            // 
            // pnlSection3
            // 
            this.pnlSection3.Controls.Add(this.btnSuppSelectCapt);
            this.pnlSection3.Controls.Add(this.btnAddCapture);
            this.pnlSection3.Controls.Add(this.btnValidObj);
            this.pnlSection3.Controls.Add(this.lstbCaptures);
            this.pnlSection3.Controls.Add(this.nud1);
            this.pnlSection3.Controls.Add(this.cboCaptures);
            this.pnlSection3.Controls.Add(this.lblObjCapture);
            this.pnlSection3.Location = new System.Drawing.Point(16, 872);
            this.pnlSection3.Name = "pnlSection3";
            this.pnlSection3.Size = new System.Drawing.Size(1018, 352);
            this.pnlSection3.TabIndex = 28;
            // 
            // btnSuppSelectCapt
            // 
            this.btnSuppSelectCapt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppSelectCapt.Location = new System.Drawing.Point(732, 172);
            this.btnSuppSelectCapt.Name = "btnSuppSelectCapt";
            this.btnSuppSelectCapt.Size = new System.Drawing.Size(242, 55);
            this.btnSuppSelectCapt.TabIndex = 41;
            this.btnSuppSelectCapt.Text = "Supprimer la sélection";
            this.btnSuppSelectCapt.UseVisualStyleBackColor = true;
            this.btnSuppSelectCapt.Click += new System.EventHandler(this.btnSuppSelectCapt_Click);
            // 
            // btnAddCapture
            // 
            this.btnAddCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCapture.Location = new System.Drawing.Point(794, 106);
            this.btnAddCapture.Name = "btnAddCapture";
            this.btnAddCapture.Size = new System.Drawing.Size(179, 49);
            this.btnAddCapture.TabIndex = 40;
            this.btnAddCapture.Text = "Ajouter";
            this.btnAddCapture.UseVisualStyleBackColor = true;
            this.btnAddCapture.Click += new System.EventHandler(this.btnAddCapture_Click);
            // 
            // btnValidObj
            // 
            this.btnValidObj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidObj.Location = new System.Drawing.Point(773, 272);
            this.btnValidObj.Name = "btnValidObj";
            this.btnValidObj.Size = new System.Drawing.Size(200, 54);
            this.btnValidObj.TabIndex = 39;
            this.btnValidObj.Text = "Valider Objectifs";
            this.btnValidObj.UseVisualStyleBackColor = true;
            this.btnValidObj.Click += new System.EventHandler(this.btnValidObj_Click);
            // 
            // lstbCaptures
            // 
            this.lstbCaptures.FormattingEnabled = true;
            this.lstbCaptures.ItemHeight = 25;
            this.lstbCaptures.Location = new System.Drawing.Point(45, 172);
            this.lstbCaptures.Name = "lstbCaptures";
            this.lstbCaptures.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbCaptures.Size = new System.Drawing.Size(651, 154);
            this.lstbCaptures.TabIndex = 38;
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(611, 106);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(85, 31);
            this.nud1.TabIndex = 37;
            // 
            // cboCaptures
            // 
            this.cboCaptures.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCaptures.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCaptures.FormattingEnabled = true;
            this.cboCaptures.Location = new System.Drawing.Point(45, 106);
            this.cboCaptures.Name = "cboCaptures";
            this.cboCaptures.Size = new System.Drawing.Size(518, 33);
            this.cboCaptures.TabIndex = 36;
            // 
            // lblObjCapture
            // 
            this.lblObjCapture.AutoSize = true;
            this.lblObjCapture.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblObjCapture.Location = new System.Drawing.Point(40, 49);
            this.lblObjCapture.Name = "lblObjCapture";
            this.lblObjCapture.Size = new System.Drawing.Size(235, 25);
            this.lblObjCapture.TabIndex = 35;
            this.lblObjCapture.Text = "5 - Objectifs de capture";
            // 
            // FrmMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2127, 1292);
            this.Controls.Add(this.grpPrecisions);
            this.Controls.Add(this.grpNouvelleMission);
            this.Name = "FrmMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création d\'une nouvelle mission";
            this.Load += new System.EventHandler(this.FrmMission_Load);
            this.grpNouvelleMission.ResumeLayout(false);
            this.pnlSection1.ResumeLayout(false);
            this.pnlSection1.PerformLayout();
            this.grpPrecisions.ResumeLayout(false);
            this.pnlSection2.ResumeLayout(false);
            this.pnlSection2.PerformLayout();
            this.pnlSection3.ResumeLayout(false);
            this.pnlSection3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNouvelleMission;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.ComboBox cboPlanete;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.GroupBox grpPrecisions;
        private System.Windows.Forms.Label lblreste;
        private System.Windows.Forms.Label lblAffect;
        private System.Windows.Forms.Button btnvalidMembres;
        private System.Windows.Forms.Button btnAddMembre;
        private System.Windows.Forms.ComboBox cboMembres;
        private System.Windows.Forms.Button btnRefaire;
        private System.Windows.Forms.ListBox lstbMembres;
        private System.Windows.Forms.Label lblNomMembre;
        private System.Windows.Forms.ListBox lstbPartis;
        private System.Windows.Forms.Label lblMembresAffect;
        private System.Windows.Forms.Button btnAddSelect;
        private System.Windows.Forms.Button btnSuppSelect;
        private System.Windows.Forms.Panel pnlSection2;
        private System.Windows.Forms.Panel pnlSection1;
        private System.Windows.Forms.Button btnValidMission;
        private System.Windows.Forms.Label lblEuros;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblTonnes;
        private System.Windows.Forms.TextBox txtobjDataBaz;
        private System.Windows.Forms.Label lblObjDataBaz;
        private System.Windows.Forms.Label lblPersonnes;
        private System.Windows.Forms.TextBox txtnbMembres;
        private System.Windows.Forms.Label lblNbMembres;
        private System.Windows.Forms.TextBox txtfeuilleRoute;
        private System.Windows.Forms.Label lblFDR;
        private System.Windows.Forms.DateTimePicker dtpRetour;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.ComboBox cboChef;
        private System.Windows.Forms.Panel pnlSection3;
        private System.Windows.Forms.Button btnSuppSelectCapt;
        private System.Windows.Forms.Button btnAddCapture;
        private System.Windows.Forms.Button btnValidObj;
        private System.Windows.Forms.ListBox lstbCaptures;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.ComboBox cboCaptures;
        private System.Windows.Forms.Label lblObjCapture;
    }
}