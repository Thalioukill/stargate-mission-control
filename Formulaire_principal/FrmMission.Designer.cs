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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMission));
            this.grpNouvelleMission = new System.Windows.Forms.GroupBox();
            this.pnlSection1 = new System.Windows.Forms.Panel();
            this.btnValidDate = new System.Windows.Forms.Button();
            this.lblChoixChef = new System.Windows.Forms.Label();
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
            this.lblDate = new System.Windows.Forms.Label();
            this.cboChef = new System.Windows.Forms.ComboBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.lblChoix = new System.Windows.Forms.Label();
            this.ttValidMission = new System.Windows.Forms.ToolTip(this.components);
            this.ttAddMembre = new System.Windows.Forms.ToolTip(this.components);
            this.btnvalidMembres = new System.Windows.Forms.Button();
            this.btnAddMembre = new System.Windows.Forms.Button();
            this.ttSuppMembre = new System.Windows.Forms.ToolTip(this.components);
            this.btnSuppSelect = new System.Windows.Forms.Button();
            this.ttValidMembre = new System.Windows.Forms.ToolTip(this.components);
            this.ttAddCapture = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddCapture = new System.Windows.Forms.Button();
            this.ttSuppCapture = new System.Windows.Forms.ToolTip(this.components);
            this.btnSuppSelectCapt = new System.Windows.Forms.Button();
            this.ttValidCapture = new System.Windows.Forms.ToolTip(this.components);
            this.btnValidObj = new System.Windows.Forms.Button();
            this.erpPersonnePartis = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttValidDate = new System.Windows.Forms.ToolTip(this.components);
            this.erpCboChef = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAccueil = new System.Windows.Forms.Button();
            this.grpPrecisions = new System.Windows.Forms.GroupBox();
            this.pnlSection3 = new System.Windows.Forms.Panel();
            this.lstbCaptures = new System.Windows.Forms.ListBox();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.cboCaptures = new System.Windows.Forms.ComboBox();
            this.lblObjCapture = new System.Windows.Forms.Label();
            this.pnlSection2 = new System.Windows.Forms.Panel();
            this.btnAddSelect = new System.Windows.Forms.Button();
            this.lblMembresAffect = new System.Windows.Forms.Label();
            this.btnRefaire = new System.Windows.Forms.Button();
            this.lstbMembres = new System.Windows.Forms.ListBox();
            this.lblNomMembre = new System.Windows.Forms.Label();
            this.lstbPartis = new System.Windows.Forms.ListBox();
            this.cboMembres = new System.Windows.Forms.ComboBox();
            this.lblreste = new System.Windows.Forms.Label();
            this.lblAffect = new System.Windows.Forms.Label();
            this.ttAccueil = new System.Windows.Forms.ToolTip(this.components);
            this.grpNouvelleMission.SuspendLayout();
            this.pnlSection1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPersonnePartis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCboChef)).BeginInit();
            this.grpPrecisions.SuspendLayout();
            this.pnlSection3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.pnlSection2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNouvelleMission
            // 
            this.grpNouvelleMission.AutoSize = true;
            this.grpNouvelleMission.BackColor = System.Drawing.Color.Transparent;
            this.grpNouvelleMission.Controls.Add(this.pnlSection1);
            this.grpNouvelleMission.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNouvelleMission.Location = new System.Drawing.Point(11, 5);
            this.grpNouvelleMission.Margin = new System.Windows.Forms.Padding(2);
            this.grpNouvelleMission.Name = "grpNouvelleMission";
            this.grpNouvelleMission.Padding = new System.Windows.Forms.Padding(2);
            this.grpNouvelleMission.Size = new System.Drawing.Size(879, 949);
            this.grpNouvelleMission.TabIndex = 0;
            this.grpNouvelleMission.TabStop = false;
            this.grpNouvelleMission.Text = "Nouvelle mission";
            // 
            // pnlSection1
            // 
            this.pnlSection1.BackColor = System.Drawing.Color.Transparent;
            this.pnlSection1.Controls.Add(this.btnValidDate);
            this.pnlSection1.Controls.Add(this.lblChoixChef);
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
            this.pnlSection1.Controls.Add(this.lblDate);
            this.pnlSection1.Controls.Add(this.cboChef);
            this.pnlSection1.Controls.Add(this.lblNum);
            this.pnlSection1.Controls.Add(this.lblNomMission);
            this.pnlSection1.Controls.Add(this.cboPlanete);
            this.pnlSection1.Controls.Add(this.lblChoix);
            this.pnlSection1.Location = new System.Drawing.Point(21, 23);
            this.pnlSection1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSection1.Name = "pnlSection1";
            this.pnlSection1.Size = new System.Drawing.Size(833, 894);
            this.pnlSection1.TabIndex = 0;
            // 
            // btnValidDate
            // 
            this.btnValidDate.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnValidDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidDate.Location = new System.Drawing.Point(723, 284);
            this.btnValidDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidDate.Name = "btnValidDate";
            this.btnValidDate.Size = new System.Drawing.Size(70, 56);
            this.btnValidDate.TabIndex = 62;
            this.ttValidDate.SetToolTip(this.btnValidDate, "Valider les dates");
            this.btnValidDate.UseVisualStyleBackColor = true;
            this.btnValidDate.Click += new System.EventHandler(this.btnValidDate_Click);
            // 
            // lblChoixChef
            // 
            this.lblChoixChef.AutoSize = true;
            this.lblChoixChef.Location = new System.Drawing.Point(40, 436);
            this.lblChoixChef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoixChef.Name = "lblChoixChef";
            this.lblChoixChef.Size = new System.Drawing.Size(156, 28);
            this.lblChoixChef.TabIndex = 61;
            this.lblChoixChef.Text = "Choix du chef";
            // 
            // btnValidMission
            // 
            this.btnValidMission.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnValidMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidMission.Location = new System.Drawing.Point(729, 830);
            this.btnValidMission.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidMission.Name = "btnValidMission";
            this.btnValidMission.Size = new System.Drawing.Size(70, 56);
            this.btnValidMission.TabIndex = 60;
            this.ttValidMission.SetToolTip(this.btnValidMission, "Valider la mission");
            this.btnValidMission.UseVisualStyleBackColor = true;
            this.btnValidMission.Click += new System.EventHandler(this.btnValidMission_Click);
            // 
            // lblEuros
            // 
            this.lblEuros.AutoSize = true;
            this.lblEuros.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEuros.Location = new System.Drawing.Point(465, 815);
            this.lblEuros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(24, 28);
            this.lblEuros.TabIndex = 59;
            this.lblEuros.Text = "€";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(359, 813);
            this.txtBudget.Margin = new System.Windows.Forms.Padding(2);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(63, 35);
            this.txtBudget.TabIndex = 58;
            this.txtBudget.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBudget_KeyDown);
            this.txtBudget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBudget_KeyPress);
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBudget.Location = new System.Drawing.Point(40, 815);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(83, 28);
            this.lblBudget.TabIndex = 57;
            this.lblBudget.Text = "Budget";
            // 
            // lblTonnes
            // 
            this.lblTonnes.AutoSize = true;
            this.lblTonnes.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonnes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTonnes.Location = new System.Drawing.Point(465, 756);
            this.lblTonnes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTonnes.Name = "lblTonnes";
            this.lblTonnes.Size = new System.Drawing.Size(83, 28);
            this.lblTonnes.TabIndex = 56;
            this.lblTonnes.Text = "Tonnes";
            // 
            // txtobjDataBaz
            // 
            this.txtobjDataBaz.Location = new System.Drawing.Point(359, 751);
            this.txtobjDataBaz.Margin = new System.Windows.Forms.Padding(2);
            this.txtobjDataBaz.Name = "txtobjDataBaz";
            this.txtobjDataBaz.Size = new System.Drawing.Size(63, 35);
            this.txtobjDataBaz.TabIndex = 55;
            this.txtobjDataBaz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtobjDataBaz_KeyDown);
            this.txtobjDataBaz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtobjDataBaz_KeyPress);
            // 
            // lblObjDataBaz
            // 
            this.lblObjDataBaz.AutoSize = true;
            this.lblObjDataBaz.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjDataBaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObjDataBaz.Location = new System.Drawing.Point(42, 756);
            this.lblObjDataBaz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObjDataBaz.Name = "lblObjDataBaz";
            this.lblObjDataBaz.Size = new System.Drawing.Size(186, 28);
            this.lblObjDataBaz.TabIndex = 54;
            this.lblObjDataBaz.Text = "Objectif DataBaz";
            // 
            // lblPersonnes
            // 
            this.lblPersonnes.AutoSize = true;
            this.lblPersonnes.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPersonnes.Location = new System.Drawing.Point(465, 687);
            this.lblPersonnes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonnes.Name = "lblPersonnes";
            this.lblPersonnes.Size = new System.Drawing.Size(111, 28);
            this.lblPersonnes.TabIndex = 53;
            this.lblPersonnes.Text = "Personnes";
            // 
            // txtnbMembres
            // 
            this.txtnbMembres.Location = new System.Drawing.Point(359, 685);
            this.txtnbMembres.Margin = new System.Windows.Forms.Padding(2);
            this.txtnbMembres.Name = "txtnbMembres";
            this.txtnbMembres.Size = new System.Drawing.Size(63, 35);
            this.txtnbMembres.TabIndex = 52;
            this.txtnbMembres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnbMembres_KeyDown);
            this.txtnbMembres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnbMembres_KeyPress);
            // 
            // lblNbMembres
            // 
            this.lblNbMembres.AutoSize = true;
            this.lblNbMembres.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbMembres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNbMembres.Location = new System.Drawing.Point(44, 685);
            this.lblNbMembres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbMembres.Name = "lblNbMembres";
            this.lblNbMembres.Size = new System.Drawing.Size(210, 28);
            this.lblNbMembres.TabIndex = 51;
            this.lblNbMembres.Text = "Nombre de membres";
            // 
            // txtfeuilleRoute
            // 
            this.txtfeuilleRoute.Location = new System.Drawing.Point(359, 516);
            this.txtfeuilleRoute.Margin = new System.Windows.Forms.Padding(2);
            this.txtfeuilleRoute.Multiline = true;
            this.txtfeuilleRoute.Name = "txtfeuilleRoute";
            this.txtfeuilleRoute.Size = new System.Drawing.Size(441, 140);
            this.txtfeuilleRoute.TabIndex = 50;
            this.txtfeuilleRoute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfeuilleRoute_KeyDown);
            // 
            // lblFDR
            // 
            this.lblFDR.AutoSize = true;
            this.lblFDR.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFDR.Location = new System.Drawing.Point(40, 518);
            this.lblFDR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFDR.Name = "lblFDR";
            this.lblFDR.Size = new System.Drawing.Size(164, 28);
            this.lblFDR.TabIndex = 49;
            this.lblFDR.Text = "Feuille de route";
            // 
            // dtpRetour
            // 
            this.dtpRetour.CustomFormat = "dd/MM/yyyy";
            this.dtpRetour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRetour.Location = new System.Drawing.Point(359, 295);
            this.dtpRetour.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRetour.Name = "dtpRetour";
            this.dtpRetour.Size = new System.Drawing.Size(207, 35);
            this.dtpRetour.TabIndex = 48;
            // 
            // dtpDepart
            // 
            this.dtpDepart.CustomFormat = "dd/MM/yyyy";
            this.dtpDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepart.Location = new System.Drawing.Point(359, 237);
            this.dtpDepart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(207, 35);
            this.dtpDepart.TabIndex = 47;
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRetour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateRetour.Location = new System.Drawing.Point(44, 298);
            this.lblDateRetour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(130, 28);
            this.lblDateRetour.TabIndex = 46;
            this.lblDateRetour.Text = "Date retour";
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDepart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateDepart.Location = new System.Drawing.Point(42, 237);
            this.lblDateDepart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(132, 28);
            this.lblDateDepart.TabIndex = 45;
            this.lblDateDepart.Text = "Date départ";
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.lblParam.Location = new System.Drawing.Point(40, 374);
            this.lblParam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(271, 28);
            this.lblParam.TabIndex = 44;
            this.lblParam.Text = "3- Paramètres de la mission";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.lblDate.Location = new System.Drawing.Point(19, 185);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(202, 28);
            this.lblDate.TabIndex = 43;
            this.lblDate.Text = "2 - Choix de la date";
            // 
            // cboChef
            // 
            this.cboChef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboChef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboChef.FormattingEnabled = true;
            this.cboChef.Location = new System.Drawing.Point(359, 436);
            this.cboChef.Margin = new System.Windows.Forms.Padding(2);
            this.cboChef.Name = "cboChef";
            this.cboChef.Size = new System.Drawing.Size(435, 36);
            this.cboChef.TabIndex = 3;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Kristen ITC", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblNum.Location = new System.Drawing.Point(543, 24);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(85, 33);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "label1";
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Font = new System.Drawing.Font("Kristen ITC", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblNomMission.Location = new System.Drawing.Point(21, 24);
            this.lblNomMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(85, 33);
            this.lblNomMission.TabIndex = 3;
            this.lblNomMission.Text = "label1";
            // 
            // cboPlanete
            // 
            this.cboPlanete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPlanete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPlanete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlanete.FormattingEnabled = true;
            this.cboPlanete.Location = new System.Drawing.Point(366, 96);
            this.cboPlanete.Margin = new System.Windows.Forms.Padding(2);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(435, 36);
            this.cboPlanete.TabIndex = 1;
            this.cboPlanete.SelectedIndexChanged += new System.EventHandler(this.cboPlanete_SelectedIndexChanged);
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.lblChoix.Location = new System.Drawing.Point(21, 98);
            this.lblChoix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(228, 28);
            this.lblChoix.TabIndex = 0;
            this.lblChoix.Text = "1 - Choix de la planète";
            // 
            // btnvalidMembres
            // 
            this.btnvalidMembres.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnvalidMembres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvalidMembres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvalidMembres.Location = new System.Drawing.Point(749, 547);
            this.btnvalidMembres.Margin = new System.Windows.Forms.Padding(2);
            this.btnvalidMembres.Name = "btnvalidMembres";
            this.btnvalidMembres.Size = new System.Drawing.Size(70, 56);
            this.btnvalidMembres.TabIndex = 11;
            this.ttAddMembre.SetToolTip(this.btnvalidMembres, "Valider les membres");
            this.btnvalidMembres.UseVisualStyleBackColor = true;
            this.btnvalidMembres.Click += new System.EventHandler(this.btnvalidMembres_Click);
            // 
            // btnAddMembre
            // 
            this.btnAddMembre.BackgroundImage = global::Formulaire_principal.Properties.Resources.ajouter;
            this.btnAddMembre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMembre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMembre.Location = new System.Drawing.Point(588, 56);
            this.btnAddMembre.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMembre.Name = "btnAddMembre";
            this.btnAddMembre.Size = new System.Drawing.Size(70, 56);
            this.btnAddMembre.TabIndex = 9;
            this.ttAddMembre.SetToolTip(this.btnAddMembre, "Ajouter le membre dans la liste \"Les membres affectés\"");
            this.btnAddMembre.UseVisualStyleBackColor = true;
            this.btnAddMembre.Click += new System.EventHandler(this.btnAddMembre_Click);
            // 
            // btnSuppSelect
            // 
            this.btnSuppSelect.BackgroundImage = global::Formulaire_principal.Properties.Resources.supprimer;
            this.btnSuppSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuppSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppSelect.Location = new System.Drawing.Point(588, 547);
            this.btnSuppSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuppSelect.Name = "btnSuppSelect";
            this.btnSuppSelect.Size = new System.Drawing.Size(70, 56);
            this.btnSuppSelect.TabIndex = 26;
            this.ttSuppMembre.SetToolTip(this.btnSuppSelect, "Supprimer le(s) membre(s) sélectionné(s)\r\n(ctrl click pour en sélectionner plusie" +
        "urs)");
            this.btnSuppSelect.UseVisualStyleBackColor = true;
            this.btnSuppSelect.Click += new System.EventHandler(this.btnSuppSelect_Click);
            // 
            // btnAddCapture
            // 
            this.btnAddCapture.BackgroundImage = global::Formulaire_principal.Properties.Resources.ajouter;
            this.btnAddCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCapture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCapture.Location = new System.Drawing.Point(588, 40);
            this.btnAddCapture.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCapture.Name = "btnAddCapture";
            this.btnAddCapture.Size = new System.Drawing.Size(70, 56);
            this.btnAddCapture.TabIndex = 40;
            this.ttAddCapture.SetToolTip(this.btnAddCapture, "Ajouter l\'objectif de capture à la liste");
            this.btnAddCapture.UseVisualStyleBackColor = true;
            this.btnAddCapture.Click += new System.EventHandler(this.btnAddCapture_Click);
            // 
            // btnSuppSelectCapt
            // 
            this.btnSuppSelectCapt.BackgroundImage = global::Formulaire_principal.Properties.Resources.supprimer;
            this.btnSuppSelectCapt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuppSelectCapt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppSelectCapt.Location = new System.Drawing.Point(588, 227);
            this.btnSuppSelectCapt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuppSelectCapt.Name = "btnSuppSelectCapt";
            this.btnSuppSelectCapt.Size = new System.Drawing.Size(70, 56);
            this.btnSuppSelectCapt.TabIndex = 41;
            this.ttSuppCapture.SetToolTip(this.btnSuppSelectCapt, "Supprimer le(s) objectif(s) sélectionné(s)\r\n(ctrl click pour en sélectionner plus" +
        "ieurs)");
            this.btnSuppSelectCapt.UseVisualStyleBackColor = true;
            this.btnSuppSelectCapt.Click += new System.EventHandler(this.btnSuppSelectCapt_Click);
            // 
            // btnValidObj
            // 
            this.btnValidObj.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnValidObj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidObj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidObj.Location = new System.Drawing.Point(749, 227);
            this.btnValidObj.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidObj.Name = "btnValidObj";
            this.btnValidObj.Size = new System.Drawing.Size(70, 56);
            this.btnValidObj.TabIndex = 39;
            this.ttValidCapture.SetToolTip(this.btnValidObj, "Valider les objectifs de capture");
            this.btnValidObj.UseVisualStyleBackColor = true;
            this.btnValidObj.Click += new System.EventHandler(this.btnValidObj_Click);
            // 
            // erpPersonnePartis
            // 
            this.erpPersonnePartis.ContainerControl = this;
            // 
            // erpCboChef
            // 
            this.erpCboChef.ContainerControl = this;
            // 
            // btnAccueil
            // 
            this.btnAccueil.BackgroundImage = global::Formulaire_principal.Properties.Resources.maison2;
            this.btnAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccueil.Location = new System.Drawing.Point(1783, 19);
            this.btnAccueil.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(70, 56);
            this.btnAccueil.TabIndex = 2;
            this.ttAccueil.SetToolTip(this.btnAccueil, "Retourner à l\'acceuil");
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // grpPrecisions
            // 
            this.grpPrecisions.BackColor = System.Drawing.Color.Transparent;
            this.grpPrecisions.BackgroundImage = global::Formulaire_principal.Properties.Resources.deco_frmMission;
            this.grpPrecisions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grpPrecisions.Controls.Add(this.pnlSection3);
            this.grpPrecisions.Controls.Add(this.pnlSection2);
            this.grpPrecisions.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrecisions.Location = new System.Drawing.Point(889, 9);
            this.grpPrecisions.Margin = new System.Windows.Forms.Padding(2);
            this.grpPrecisions.Name = "grpPrecisions";
            this.grpPrecisions.Padding = new System.Windows.Forms.Padding(2);
            this.grpPrecisions.Size = new System.Drawing.Size(883, 945);
            this.grpPrecisions.TabIndex = 1;
            this.grpPrecisions.TabStop = false;
            // 
            // pnlSection3
            // 
            this.pnlSection3.BackColor = System.Drawing.Color.Transparent;
            this.pnlSection3.Controls.Add(this.btnSuppSelectCapt);
            this.pnlSection3.Controls.Add(this.btnAddCapture);
            this.pnlSection3.Controls.Add(this.btnValidObj);
            this.pnlSection3.Controls.Add(this.lstbCaptures);
            this.pnlSection3.Controls.Add(this.nud1);
            this.pnlSection3.Controls.Add(this.cboCaptures);
            this.pnlSection3.Controls.Add(this.lblObjCapture);
            this.pnlSection3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSection3.Location = new System.Drawing.Point(17, 643);
            this.pnlSection3.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSection3.Name = "pnlSection3";
            this.pnlSection3.Size = new System.Drawing.Size(848, 296);
            this.pnlSection3.TabIndex = 28;
            // 
            // lstbCaptures
            // 
            this.lstbCaptures.FormattingEnabled = true;
            this.lstbCaptures.ItemHeight = 28;
            this.lstbCaptures.Location = new System.Drawing.Point(33, 108);
            this.lstbCaptures.Margin = new System.Windows.Forms.Padding(2);
            this.lstbCaptures.Name = "lstbCaptures";
            this.lstbCaptures.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbCaptures.Size = new System.Drawing.Size(788, 88);
            this.lstbCaptures.TabIndex = 38;
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(485, 52);
            this.nud1.Margin = new System.Windows.Forms.Padding(2);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(57, 35);
            this.nud1.TabIndex = 37;
            // 
            // cboCaptures
            // 
            this.cboCaptures.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCaptures.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCaptures.FormattingEnabled = true;
            this.cboCaptures.Location = new System.Drawing.Point(33, 52);
            this.cboCaptures.Margin = new System.Windows.Forms.Padding(2);
            this.cboCaptures.Name = "cboCaptures";
            this.cboCaptures.Size = new System.Drawing.Size(411, 36);
            this.cboCaptures.TabIndex = 36;
            // 
            // lblObjCapture
            // 
            this.lblObjCapture.AutoSize = true;
            this.lblObjCapture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.lblObjCapture.Location = new System.Drawing.Point(27, 15);
            this.lblObjCapture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObjCapture.Name = "lblObjCapture";
            this.lblObjCapture.Size = new System.Drawing.Size(246, 28);
            this.lblObjCapture.TabIndex = 35;
            this.lblObjCapture.Text = "5 - Objectifs de capture";
            // 
            // pnlSection2
            // 
            this.pnlSection2.BackColor = System.Drawing.Color.Transparent;
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
            this.pnlSection2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSection2.Location = new System.Drawing.Point(17, 23);
            this.pnlSection2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSection2.Name = "pnlSection2";
            this.pnlSection2.Size = new System.Drawing.Size(848, 616);
            this.pnlSection2.TabIndex = 27;
            // 
            // btnAddSelect
            // 
            this.btnAddSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSelect.Location = new System.Drawing.Point(157, 294);
            this.btnAddSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSelect.Name = "btnAddSelect";
            this.btnAddSelect.Size = new System.Drawing.Size(285, 52);
            this.btnAddSelect.TabIndex = 25;
            this.btnAddSelect.Text = "Ajouter la sélection";
            this.btnAddSelect.UseVisualStyleBackColor = true;
            this.btnAddSelect.Click += new System.EventHandler(this.btnAddSelect_Click);
            // 
            // lblMembresAffect
            // 
            this.lblMembresAffect.AutoSize = true;
            this.lblMembresAffect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMembresAffect.Location = new System.Drawing.Point(27, 397);
            this.lblMembresAffect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMembresAffect.Name = "lblMembresAffect";
            this.lblMembresAffect.Size = new System.Drawing.Size(238, 28);
            this.lblMembresAffect.TabIndex = 17;
            this.lblMembresAffect.Text = "Les membres affectés :";
            // 
            // btnRefaire
            // 
            this.btnRefaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefaire.Location = new System.Drawing.Point(485, 294);
            this.btnRefaire.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefaire.Name = "btnRefaire";
            this.btnRefaire.Size = new System.Drawing.Size(334, 52);
            this.btnRefaire.TabIndex = 16;
            this.btnRefaire.Text = "Refaire la même équipe";
            this.btnRefaire.UseVisualStyleBackColor = true;
            this.btnRefaire.Click += new System.EventHandler(this.btnRefaire_Click);
            // 
            // lstbMembres
            // 
            this.lstbMembres.FormattingEnabled = true;
            this.lstbMembres.ItemHeight = 28;
            this.lstbMembres.Location = new System.Drawing.Point(33, 428);
            this.lstbMembres.Margin = new System.Windows.Forms.Padding(2);
            this.lstbMembres.Name = "lstbMembres";
            this.lstbMembres.ScrollAlwaysVisible = true;
            this.lstbMembres.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbMembres.Size = new System.Drawing.Size(788, 88);
            this.lstbMembres.TabIndex = 15;
            // 
            // lblNomMembre
            // 
            this.lblNomMembre.AutoSize = true;
            this.lblNomMembre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomMembre.Location = new System.Drawing.Point(27, 135);
            this.lblNomMembre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomMembre.Name = "lblNomMembre";
            this.lblNomMembre.Size = new System.Drawing.Size(58, 28);
            this.lblNomMembre.TabIndex = 13;
            this.lblNomMembre.Text = "Nom";
            // 
            // lstbPartis
            // 
            this.lstbPartis.FormattingEnabled = true;
            this.lstbPartis.ItemHeight = 28;
            this.lstbPartis.Location = new System.Drawing.Point(33, 165);
            this.lstbPartis.Margin = new System.Windows.Forms.Padding(2);
            this.lstbPartis.Name = "lstbPartis";
            this.lstbPartis.ScrollAlwaysVisible = true;
            this.lstbPartis.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbPartis.Size = new System.Drawing.Size(788, 88);
            this.lstbPartis.TabIndex = 12;
            // 
            // cboMembres
            // 
            this.cboMembres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMembres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMembres.FormattingEnabled = true;
            this.cboMembres.Location = new System.Drawing.Point(33, 68);
            this.cboMembres.Margin = new System.Windows.Forms.Padding(2);
            this.cboMembres.Name = "cboMembres";
            this.cboMembres.Size = new System.Drawing.Size(509, 36);
            this.cboMembres.TabIndex = 8;
            this.cboMembres.SelectedIndexChanged += new System.EventHandler(this.cboMembres_SelectedIndexChanged);
            // 
            // lblreste
            // 
            this.lblreste.AutoSize = true;
            this.lblreste.Location = new System.Drawing.Point(609, 8);
            this.lblreste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblreste.Name = "lblreste";
            this.lblreste.Size = new System.Drawing.Size(18, 28);
            this.lblreste.TabIndex = 7;
            this.lblreste.Text = ".";
            // 
            // lblAffect
            // 
            this.lblAffect.AutoSize = true;
            this.lblAffect.BackColor = System.Drawing.Color.Transparent;
            this.lblAffect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.lblAffect.Location = new System.Drawing.Point(27, 8);
            this.lblAffect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAffect.Name = "lblAffect";
            this.lblAffect.Size = new System.Drawing.Size(474, 28);
            this.lblAffect.TabIndex = 6;
            this.lblAffect.Text = "4 - Affectation des membres - reste à affecter :";
            // 
            // FrmMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Formulaire_principal.Properties.Resources.fond_mission;
            this.ClientSize = new System.Drawing.Size(1861, 807);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.grpPrecisions);
            this.Controls.Add(this.grpNouvelleMission);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création d\'une nouvelle mission";
            this.Load += new System.EventHandler(this.FrmMission_Load);
            this.grpNouvelleMission.ResumeLayout(false);
            this.pnlSection1.ResumeLayout(false);
            this.pnlSection1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPersonnePartis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCboChef)).EndInit();
            this.grpPrecisions.ResumeLayout(false);
            this.pnlSection3.ResumeLayout(false);
            this.pnlSection3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.pnlSection2.ResumeLayout(false);
            this.pnlSection2.PerformLayout();
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
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cboChef;
        private System.Windows.Forms.Panel pnlSection3;
        private System.Windows.Forms.Button btnSuppSelectCapt;
        private System.Windows.Forms.Button btnAddCapture;
        private System.Windows.Forms.Button btnValidObj;
        private System.Windows.Forms.ListBox lstbCaptures;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.ComboBox cboCaptures;
        private System.Windows.Forms.Label lblObjCapture;
        private System.Windows.Forms.ToolTip ttValidMission;
        private System.Windows.Forms.ToolTip ttAddMembre;
        private System.Windows.Forms.ToolTip ttSuppMembre;
        private System.Windows.Forms.ToolTip ttSuppCapture;
        private System.Windows.Forms.ToolTip ttAddCapture;
        private System.Windows.Forms.ToolTip ttValidCapture;
        private System.Windows.Forms.ToolTip ttValidMembre;
        private System.Windows.Forms.ErrorProvider erpPersonnePartis;
        private System.Windows.Forms.Label lblChoixChef;
        private System.Windows.Forms.Button btnValidDate;
        private System.Windows.Forms.ToolTip ttValidDate;
        private System.Windows.Forms.ErrorProvider erpCboChef;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.ToolTip ttAccueil;
    }
}