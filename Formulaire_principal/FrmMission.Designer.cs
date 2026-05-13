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
            this.lblChoix = new System.Windows.Forms.Label();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.grpNouvelleMission = new System.Windows.Forms.GroupBox();
            this.btnValidPlanete = new System.Windows.Forms.Button();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.cboChef = new System.Windows.Forms.ComboBox();
            this.lblChef = new System.Windows.Forms.Label();
            this.lblParam = new System.Windows.Forms.Label();
            this.lbldateDepart = new System.Windows.Forms.Label();
            this.lbldateRetour = new System.Windows.Forms.Label();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.dtpRetour = new System.Windows.Forms.DateTimePicker();
            this.lblfdr = new System.Windows.Forms.Label();
            this.txtfeuilleRoute = new System.Windows.Forms.TextBox();
            this.lblnbMembres = new System.Windows.Forms.Label();
            this.txtnbMembres = new System.Windows.Forms.TextBox();
            this.lblPersonnes = new System.Windows.Forms.Label();
            this.lblobjDataBaz = new System.Windows.Forms.Label();
            this.txtobjDataBaz = new System.Windows.Forms.TextBox();
            this.lblTonnes = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.lblEuros = new System.Windows.Forms.Label();
            this.btnValidMission = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.lblNum = new System.Windows.Forms.Label();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.lblAffect = new System.Windows.Forms.Label();
            this.lblreste = new System.Windows.Forms.Label();
            this.cboMembres = new System.Windows.Forms.ComboBox();
            this.btnAddMembre = new System.Windows.Forms.Button();
            this.btnvalidMembres = new System.Windows.Forms.Button();
            this.lstbPartis = new System.Windows.Forms.ListBox();
            this.lblnomMembre = new System.Windows.Forms.Label();
            this.lstbMembres = new System.Windows.Forms.ListBox();
            this.btnRefaire = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSelect = new System.Windows.Forms.Button();
            this.btnSuppSelect = new System.Windows.Forms.Button();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCapture = new System.Windows.Forms.ComboBox();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.lstbCapture = new System.Windows.Forms.ListBox();
            this.btnValidObj = new System.Windows.Forms.Button();
            this.btnAddCapture = new System.Windows.Forms.Button();
            this.btnSuppSelectCapt = new System.Windows.Forms.Button();
            this.grpPrecisions = new System.Windows.Forms.GroupBox();
            this.grpNouvelleMission.SuspendLayout();
            this.pnl.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.grpPrecisions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Location = new System.Drawing.Point(59, 69);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(333, 37);
            this.lblChoix.TabIndex = 0;
            this.lblChoix.Text = "1 - Choix de la planète";
            // 
            // cboPlanete
            // 
            this.cboPlanete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlanete.FormattingEnabled = true;
            this.cboPlanete.Location = new System.Drawing.Point(398, 66);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(355, 45);
            this.cboPlanete.TabIndex = 1;
            this.cboPlanete.SelectedIndexChanged += new System.EventHandler(this.cboPlanete_SelectedIndexChanged);
            this.cboPlanete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPlanete_KeyPress);
            // 
            // grpNouvelleMission
            // 
            this.grpNouvelleMission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpNouvelleMission.AutoSize = true;
            this.grpNouvelleMission.Controls.Add(this.lblNum);
            this.grpNouvelleMission.Controls.Add(this.pnl);
            this.grpNouvelleMission.Controls.Add(this.lblNomMission);
            this.grpNouvelleMission.Controls.Add(this.btnValidPlanete);
            this.grpNouvelleMission.Controls.Add(this.cboPlanete);
            this.grpNouvelleMission.Controls.Add(this.lblChoix);
            this.grpNouvelleMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNouvelleMission.Location = new System.Drawing.Point(68, 24);
            this.grpNouvelleMission.Name = "grpNouvelleMission";
            this.grpNouvelleMission.Size = new System.Drawing.Size(1099, 1403);
            this.grpNouvelleMission.TabIndex = 0;
            this.grpNouvelleMission.TabStop = false;
            this.grpNouvelleMission.Text = "Nouvelle mission";
            // 
            // btnValidPlanete
            // 
            this.btnValidPlanete.Location = new System.Drawing.Point(788, 58);
            this.btnValidPlanete.Name = "btnValidPlanete";
            this.btnValidPlanete.Size = new System.Drawing.Size(251, 65);
            this.btnValidPlanete.TabIndex = 2;
            this.btnValidPlanete.Text = "Valider planète";
            this.btnValidPlanete.UseVisualStyleBackColor = true;
            this.btnValidPlanete.Click += new System.EventHandler(this.btnValidPlanete_Click);
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMission.Location = new System.Drawing.Point(63, 154);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(124, 42);
            this.lblNomMission.TabIndex = 3;
            this.lblNomMission.Text = "label1";
            // 
            // cboChef
            // 
            this.cboChef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChef.FormattingEnabled = true;
            this.cboChef.Location = new System.Drawing.Point(493, 39);
            this.cboChef.Name = "cboChef";
            this.cboChef.Size = new System.Drawing.Size(517, 45);
            this.cboChef.TabIndex = 23;
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblChef.Location = new System.Drawing.Point(36, 39);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(420, 37);
            this.lblChef.TabIndex = 24;
            this.lblChef.Text = "2 - Choix du chef de mission";
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblParam.Location = new System.Drawing.Point(36, 141);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(415, 37);
            this.lblParam.TabIndex = 25;
            this.lblParam.Text = "3- Paramètres de la mission";
            // 
            // lbldateDepart
            // 
            this.lbldateDepart.AutoSize = true;
            this.lbldateDepart.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbldateDepart.Location = new System.Drawing.Point(68, 238);
            this.lbldateDepart.Name = "lbldateDepart";
            this.lbldateDepart.Size = new System.Drawing.Size(184, 37);
            this.lbldateDepart.TabIndex = 26;
            this.lbldateDepart.Text = "Date départ";
            // 
            // lbldateRetour
            // 
            this.lbldateRetour.AutoSize = true;
            this.lbldateRetour.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbldateRetour.Location = new System.Drawing.Point(68, 310);
            this.lbldateRetour.Name = "lbldateRetour";
            this.lbldateRetour.Size = new System.Drawing.Size(177, 37);
            this.lbldateRetour.TabIndex = 27;
            this.lbldateRetour.Text = "Date retour";
            // 
            // dtpDepart
            // 
            this.dtpDepart.CustomFormat = "yyyy-MM-dd";
            this.dtpDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepart.Location = new System.Drawing.Point(324, 233);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(278, 44);
            this.dtpDepart.TabIndex = 28;
            // 
            // dtpRetour
            // 
            this.dtpRetour.CustomFormat = "yyyy-MM-dd";
            this.dtpRetour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRetour.Location = new System.Drawing.Point(324, 310);
            this.dtpRetour.Name = "dtpRetour";
            this.dtpRetour.Size = new System.Drawing.Size(278, 44);
            this.dtpRetour.TabIndex = 29;
            // 
            // lblfdr
            // 
            this.lblfdr.AutoSize = true;
            this.lblfdr.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblfdr.Location = new System.Drawing.Point(64, 400);
            this.lblfdr.Name = "lblfdr";
            this.lblfdr.Size = new System.Drawing.Size(236, 37);
            this.lblfdr.TabIndex = 30;
            this.lblfdr.Text = "Feuille de route";
            // 
            // txtfeuilleRoute
            // 
            this.txtfeuilleRoute.Location = new System.Drawing.Point(324, 400);
            this.txtfeuilleRoute.Multiline = true;
            this.txtfeuilleRoute.Name = "txtfeuilleRoute";
            this.txtfeuilleRoute.Size = new System.Drawing.Size(686, 230);
            this.txtfeuilleRoute.TabIndex = 31;
            // 
            // lblnbMembres
            // 
            this.lblnbMembres.AutoSize = true;
            this.lblnbMembres.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblnbMembres.Location = new System.Drawing.Point(68, 741);
            this.lblnbMembres.Name = "lblnbMembres";
            this.lblnbMembres.Size = new System.Drawing.Size(318, 37);
            this.lblnbMembres.TabIndex = 32;
            this.lblnbMembres.Text = "Nombre de membres";
            // 
            // txtnbMembres
            // 
            this.txtnbMembres.Location = new System.Drawing.Point(394, 738);
            this.txtnbMembres.Name = "txtnbMembres";
            this.txtnbMembres.Size = new System.Drawing.Size(82, 44);
            this.txtnbMembres.TabIndex = 33;
            this.txtnbMembres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnbMembres_KeyPress);
            // 
            // lblPersonnes
            // 
            this.lblPersonnes.AutoSize = true;
            this.lblPersonnes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPersonnes.Location = new System.Drawing.Point(501, 741);
            this.lblPersonnes.Name = "lblPersonnes";
            this.lblPersonnes.Size = new System.Drawing.Size(169, 37);
            this.lblPersonnes.TabIndex = 34;
            this.lblPersonnes.Text = "Personnes";
            // 
            // lblobjDataBaz
            // 
            this.lblobjDataBaz.AutoSize = true;
            this.lblobjDataBaz.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblobjDataBaz.Location = new System.Drawing.Point(64, 836);
            this.lblobjDataBaz.Name = "lblobjDataBaz";
            this.lblobjDataBaz.Size = new System.Drawing.Size(257, 37);
            this.lblobjDataBaz.TabIndex = 35;
            this.lblobjDataBaz.Text = "Objectif DataBaz";
            // 
            // txtobjDataBaz
            // 
            this.txtobjDataBaz.Location = new System.Drawing.Point(394, 833);
            this.txtobjDataBaz.Name = "txtobjDataBaz";
            this.txtobjDataBaz.Size = new System.Drawing.Size(82, 44);
            this.txtobjDataBaz.TabIndex = 36;
            this.txtobjDataBaz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtobjDataBaz_KeyPress);
            // 
            // lblTonnes
            // 
            this.lblTonnes.AutoSize = true;
            this.lblTonnes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTonnes.Location = new System.Drawing.Point(501, 836);
            this.lblTonnes.Name = "lblTonnes";
            this.lblTonnes.Size = new System.Drawing.Size(113, 37);
            this.lblTonnes.TabIndex = 37;
            this.lblTonnes.Text = "tonnes";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBudget.Location = new System.Drawing.Point(68, 930);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(118, 37);
            this.lblBudget.TabIndex = 38;
            this.lblBudget.Text = "Budget";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(394, 927);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(82, 44);
            this.txtBudget.TabIndex = 39;
            this.txtBudget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBudget_KeyPress);
            // 
            // lblEuros
            // 
            this.lblEuros.AutoSize = true;
            this.lblEuros.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEuros.Location = new System.Drawing.Point(501, 930);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(35, 37);
            this.lblEuros.TabIndex = 40;
            this.lblEuros.Text = "€";
            // 
            // btnValidMission
            // 
            this.btnValidMission.Location = new System.Drawing.Point(741, 980);
            this.btnValidMission.Name = "btnValidMission";
            this.btnValidMission.Size = new System.Drawing.Size(291, 108);
            this.btnValidMission.TabIndex = 41;
            this.btnValidMission.Text = "Valider la mission";
            this.btnValidMission.UseVisualStyleBackColor = true;
            this.btnValidMission.Click += new System.EventHandler(this.btnValidMission_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.btnValidMission);
            this.pnl.Controls.Add(this.lblEuros);
            this.pnl.Controls.Add(this.txtBudget);
            this.pnl.Controls.Add(this.lblBudget);
            this.pnl.Controls.Add(this.lblTonnes);
            this.pnl.Controls.Add(this.txtobjDataBaz);
            this.pnl.Controls.Add(this.lblobjDataBaz);
            this.pnl.Controls.Add(this.lblPersonnes);
            this.pnl.Controls.Add(this.txtnbMembres);
            this.pnl.Controls.Add(this.lblnbMembres);
            this.pnl.Controls.Add(this.txtfeuilleRoute);
            this.pnl.Controls.Add(this.lblfdr);
            this.pnl.Controls.Add(this.dtpRetour);
            this.pnl.Controls.Add(this.dtpDepart);
            this.pnl.Controls.Add(this.lbldateRetour);
            this.pnl.Controls.Add(this.lbldateDepart);
            this.pnl.Controls.Add(this.lblParam);
            this.pnl.Controls.Add(this.lblChef);
            this.pnl.Controls.Add(this.cboChef);
            this.pnl.Location = new System.Drawing.Point(29, 234);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1056, 1119);
            this.pnl.TabIndex = 4;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(796, 154);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(124, 42);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "label1";
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.btnSuppSelect);
            this.pnl2.Controls.Add(this.btnAddSelect);
            this.pnl2.Controls.Add(this.label2);
            this.pnl2.Controls.Add(this.btnRefaire);
            this.pnl2.Controls.Add(this.lstbMembres);
            this.pnl2.Controls.Add(this.lblnomMembre);
            this.pnl2.Controls.Add(this.lstbPartis);
            this.pnl2.Controls.Add(this.btnvalidMembres);
            this.pnl2.Controls.Add(this.btnAddMembre);
            this.pnl2.Controls.Add(this.cboMembres);
            this.pnl2.Controls.Add(this.lblreste);
            this.pnl2.Controls.Add(this.lblAffect);
            this.pnl2.Location = new System.Drawing.Point(18, 61);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1079, 880);
            this.pnl2.TabIndex = 27;
            // 
            // lblAffect
            // 
            this.lblAffect.AutoSize = true;
            this.lblAffect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAffect.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAffect.Location = new System.Drawing.Point(38, 11);
            this.lblAffect.Name = "lblAffect";
            this.lblAffect.Size = new System.Drawing.Size(675, 37);
            this.lblAffect.TabIndex = 6;
            this.lblAffect.Text = "4 - Affectation des membres - reste à affecter :";
            // 
            // lblreste
            // 
            this.lblreste.AutoSize = true;
            this.lblreste.Location = new System.Drawing.Point(719, 13);
            this.lblreste.Name = "lblreste";
            this.lblreste.Size = new System.Drawing.Size(26, 37);
            this.lblreste.TabIndex = 7;
            this.lblreste.Text = ".";
            // 
            // cboMembres
            // 
            this.cboMembres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMembres.FormattingEnabled = true;
            this.cboMembres.Location = new System.Drawing.Point(43, 93);
            this.cboMembres.Name = "cboMembres";
            this.cboMembres.Size = new System.Drawing.Size(702, 45);
            this.cboMembres.TabIndex = 8;
            this.cboMembres.SelectedIndexChanged += new System.EventHandler(this.cboMembres_SelectedIndexChanged);
            // 
            // btnAddMembre
            // 
            this.btnAddMembre.Location = new System.Drawing.Point(793, 87);
            this.btnAddMembre.Name = "btnAddMembre";
            this.btnAddMembre.Size = new System.Drawing.Size(227, 61);
            this.btnAddMembre.TabIndex = 9;
            this.btnAddMembre.Text = "Ajouter";
            this.btnAddMembre.UseVisualStyleBackColor = true;
            this.btnAddMembre.Click += new System.EventHandler(this.btnAddMembre_Click);
            // 
            // btnvalidMembres
            // 
            this.btnvalidMembres.Location = new System.Drawing.Point(737, 790);
            this.btnvalidMembres.Name = "btnvalidMembres";
            this.btnvalidMembres.Size = new System.Drawing.Size(283, 72);
            this.btnvalidMembres.TabIndex = 11;
            this.btnvalidMembres.Text = "Valider membres";
            this.btnvalidMembres.UseVisualStyleBackColor = true;
            this.btnvalidMembres.Click += new System.EventHandler(this.btnvalidMembres_Click);
            // 
            // lstbPartis
            // 
            this.lstbPartis.FormattingEnabled = true;
            this.lstbPartis.ItemHeight = 37;
            this.lstbPartis.Location = new System.Drawing.Point(43, 242);
            this.lstbPartis.Name = "lstbPartis";
            this.lstbPartis.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbPartis.Size = new System.Drawing.Size(976, 189);
            this.lstbPartis.TabIndex = 12;
            // 
            // lblnomMembre
            // 
            this.lblnomMembre.AutoSize = true;
            this.lblnomMembre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblnomMembre.Location = new System.Drawing.Point(41, 183);
            this.lblnomMembre.Name = "lblnomMembre";
            this.lblnomMembre.Size = new System.Drawing.Size(86, 37);
            this.lblnomMembre.TabIndex = 13;
            this.lblnomMembre.Text = "Nom";
            // 
            // lstbMembres
            // 
            this.lstbMembres.FormattingEnabled = true;
            this.lstbMembres.ItemHeight = 37;
            this.lstbMembres.Location = new System.Drawing.Point(47, 598);
            this.lstbMembres.Name = "lstbMembres";
            this.lstbMembres.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbMembres.Size = new System.Drawing.Size(973, 189);
            this.lstbMembres.TabIndex = 15;
            // 
            // btnRefaire
            // 
            this.btnRefaire.Location = new System.Drawing.Point(610, 437);
            this.btnRefaire.Name = "btnRefaire";
            this.btnRefaire.Size = new System.Drawing.Size(409, 67);
            this.btnRefaire.TabIndex = 16;
            this.btnRefaire.Text = "Refaire la même équipe";
            this.btnRefaire.UseVisualStyleBackColor = true;
            this.btnRefaire.Click += new System.EventHandler(this.btnRefaire_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(40, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Les membres affectés :";
            // 
            // btnAddSelect
            // 
            this.btnAddSelect.Location = new System.Drawing.Point(151, 437);
            this.btnAddSelect.Name = "btnAddSelect";
            this.btnAddSelect.Size = new System.Drawing.Size(413, 67);
            this.btnAddSelect.TabIndex = 25;
            this.btnAddSelect.Text = "Ajouter la sélection";
            this.btnAddSelect.UseVisualStyleBackColor = true;
            this.btnAddSelect.Click += new System.EventHandler(this.btnAddSelect_Click);
            // 
            // btnSuppSelect
            // 
            this.btnSuppSelect.Location = new System.Drawing.Point(160, 793);
            this.btnSuppSelect.Name = "btnSuppSelect";
            this.btnSuppSelect.Size = new System.Drawing.Size(516, 69);
            this.btnSuppSelect.TabIndex = 26;
            this.btnSuppSelect.Text = "Supprimer la sélection";
            this.btnSuppSelect.UseVisualStyleBackColor = true;
            this.btnSuppSelect.Click += new System.EventHandler(this.btnSuppSelect_Click);
            // 
            // pnl3
            // 
            this.pnl3.Controls.Add(this.btnSuppSelectCapt);
            this.pnl3.Controls.Add(this.btnAddCapture);
            this.pnl3.Controls.Add(this.btnValidObj);
            this.pnl3.Controls.Add(this.lstbCapture);
            this.pnl3.Controls.Add(this.nud1);
            this.pnl3.Controls.Add(this.cboCapture);
            this.pnl3.Controls.Add(this.label3);
            this.pnl3.Location = new System.Drawing.Point(23, 947);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1074, 477);
            this.pnl3.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(36, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "5 - Objectifs de capture";
            // 
            // cboCapture
            // 
            this.cboCapture.FormattingEnabled = true;
            this.cboCapture.Location = new System.Drawing.Point(41, 115);
            this.cboCapture.Name = "cboCapture";
            this.cboCapture.Size = new System.Drawing.Size(518, 45);
            this.cboCapture.TabIndex = 19;
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(605, 115);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(85, 44);
            this.nud1.TabIndex = 21;
            // 
            // lstbCapture
            // 
            this.lstbCapture.FormattingEnabled = true;
            this.lstbCapture.ItemHeight = 37;
            this.lstbCapture.Location = new System.Drawing.Point(38, 186);
            this.lstbCapture.Name = "lstbCapture";
            this.lstbCapture.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbCapture.Size = new System.Drawing.Size(976, 189);
            this.lstbCapture.TabIndex = 22;
            // 
            // btnValidObj
            // 
            this.btnValidObj.Location = new System.Drawing.Point(732, 381);
            this.btnValidObj.Name = "btnValidObj";
            this.btnValidObj.Size = new System.Drawing.Size(283, 84);
            this.btnValidObj.TabIndex = 23;
            this.btnValidObj.Text = "Valider Objectifs";
            this.btnValidObj.UseVisualStyleBackColor = true;
            this.btnValidObj.Click += new System.EventHandler(this.btnValidObj_Click);
            // 
            // btnAddCapture
            // 
            this.btnAddCapture.Location = new System.Drawing.Point(769, 103);
            this.btnAddCapture.Name = "btnAddCapture";
            this.btnAddCapture.Size = new System.Drawing.Size(245, 66);
            this.btnAddCapture.TabIndex = 24;
            this.btnAddCapture.Text = "Ajouter";
            this.btnAddCapture.UseVisualStyleBackColor = true;
            this.btnAddCapture.Click += new System.EventHandler(this.btnAddCapture_Click);
            // 
            // btnSuppSelectCapt
            // 
            this.btnSuppSelectCapt.Location = new System.Drawing.Point(172, 381);
            this.btnSuppSelectCapt.Name = "btnSuppSelectCapt";
            this.btnSuppSelectCapt.Size = new System.Drawing.Size(499, 84);
            this.btnSuppSelectCapt.TabIndex = 27;
            this.btnSuppSelectCapt.Text = "Supprimer la sélection";
            this.btnSuppSelectCapt.UseVisualStyleBackColor = true;
            this.btnSuppSelectCapt.Click += new System.EventHandler(this.btnSuppSelectCapt_Click);
            // 
            // grpPrecisions
            // 
            this.grpPrecisions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpPrecisions.Controls.Add(this.pnl3);
            this.grpPrecisions.Controls.Add(this.pnl2);
            this.grpPrecisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrecisions.Location = new System.Drawing.Point(1208, 24);
            this.grpPrecisions.Name = "grpPrecisions";
            this.grpPrecisions.Size = new System.Drawing.Size(1100, 1403);
            this.grpPrecisions.TabIndex = 1;
            this.grpPrecisions.TabStop = false;
            this.grpPrecisions.Text = "Précisions sur la mission créée";
            // 
            // FrmMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2376, 1466);
            this.Controls.Add(this.grpPrecisions);
            this.Controls.Add(this.grpNouvelleMission);
            this.Name = "FrmMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création d\'une nouvelle mission";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMission_Load);
            this.grpNouvelleMission.ResumeLayout(false);
            this.grpNouvelleMission.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.grpPrecisions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.ComboBox cboPlanete;
        private System.Windows.Forms.GroupBox grpNouvelleMission;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnValidMission;
        private System.Windows.Forms.Label lblEuros;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblTonnes;
        private System.Windows.Forms.TextBox txtobjDataBaz;
        private System.Windows.Forms.Label lblobjDataBaz;
        private System.Windows.Forms.Label lblPersonnes;
        private System.Windows.Forms.TextBox txtnbMembres;
        private System.Windows.Forms.Label lblnbMembres;
        private System.Windows.Forms.TextBox txtfeuilleRoute;
        private System.Windows.Forms.Label lblfdr;
        private System.Windows.Forms.DateTimePicker dtpRetour;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.Label lbldateRetour;
        private System.Windows.Forms.Label lbldateDepart;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.ComboBox cboChef;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Button btnValidPlanete;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnSuppSelect;
        private System.Windows.Forms.Button btnAddSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefaire;
        private System.Windows.Forms.ListBox lstbMembres;
        private System.Windows.Forms.Label lblnomMembre;
        private System.Windows.Forms.ListBox lstbPartis;
        private System.Windows.Forms.Button btnvalidMembres;
        private System.Windows.Forms.Button btnAddMembre;
        private System.Windows.Forms.ComboBox cboMembres;
        private System.Windows.Forms.Label lblreste;
        private System.Windows.Forms.Label lblAffect;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Button btnSuppSelectCapt;
        private System.Windows.Forms.Button btnAddCapture;
        private System.Windows.Forms.Button btnValidObj;
        private System.Windows.Forms.ListBox lstbCapture;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.ComboBox cboCapture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpPrecisions;
    }
}