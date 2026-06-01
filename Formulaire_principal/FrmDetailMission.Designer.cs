namespace Formulaire_principal
{
    partial class FrmDetailMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetailMission));
            this.lblNomMission = new System.Windows.Forms.Label();
            this.picMission = new System.Windows.Forms.PictureBox();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblSoldeApresDepenses = new System.Windows.Forms.Label();
            this.flpEquipage = new System.Windows.Forms.FlowLayoutPanel();
            this.flpObjectifCaptures = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNbJours = new System.Windows.Forms.Label();
            this.rtbFeuilleDeRoute = new System.Windows.Forms.RichTextBox();
            this.btnJournal = new System.Windows.Forms.Button();
            this.tbcNouvEvnmt = new System.Windows.Forms.TabControl();
            this.tpNouvContact = new System.Windows.Forms.TabPage();
            this.dtpContact = new System.Windows.Forms.DateTimePicker();
            this.txtSomme = new System.Windows.Forms.TextBox();
            this.txtAppreciation = new System.Windows.Forms.TextBox();
            this.btnValidNouvC = new System.Windows.Forms.Button();
            this.btnAnnulNouvC = new System.Windows.Forms.Button();
            this.cboInformateur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcNouvDepense = new System.Windows.Forms.TabPage();
            this.dtpDepense = new System.Windows.Forms.DateTimePicker();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.btnValidDepense = new System.Windows.Forms.Button();
            this.btnAnnulNouvD = new System.Windows.Forms.Button();
            this.cboTypeDepense = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbcEvnmt = new System.Windows.Forms.TabPage();
            this.dtpEvnmt = new System.Windows.Forms.DateTimePicker();
            this.txtCommentaires = new System.Windows.Forms.TextBox();
            this.btnValidEvnmt = new System.Windows.Forms.Button();
            this.btnAnnulNouvE = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpCommentaires = new System.Windows.Forms.GroupBox();
            this.grpMembresEquipage = new System.Windows.Forms.GroupBox();
            this.grpObjectifCaptures = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMission)).BeginInit();
            this.tbcNouvEvnmt.SuspendLayout();
            this.tpNouvContact.SuspendLayout();
            this.tbcNouvDepense.SuspendLayout();
            this.tbcEvnmt.SuspendLayout();
            this.grpCommentaires.SuspendLayout();
            this.grpMembresEquipage.SuspendLayout();
            this.grpObjectifCaptures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.BackColor = System.Drawing.Color.Transparent;
            this.lblNomMission.Font = new System.Drawing.Font("Kristen ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.lblNomMission.Location = new System.Drawing.Point(680, 18);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(183, 45);
            this.lblNomMission.TabIndex = 0;
            this.lblNomMission.Text = "Mission : ";
            // 
            // picMission
            // 
            this.picMission.BackColor = System.Drawing.Color.White;
            this.picMission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMission.Location = new System.Drawing.Point(25, 29);
            this.picMission.Name = "picMission";
            this.picMission.Size = new System.Drawing.Size(168, 154);
            this.picMission.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMission.TabIndex = 2;
            this.picMission.TabStop = false;
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDates.Location = new System.Drawing.Point(212, 67);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(88, 28);
            this.lblDates.TabIndex = 3;
            this.lblDates.Text = "Dates : ";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.BackColor = System.Drawing.Color.Transparent;
            this.lblBudget.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(212, 155);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(101, 28);
            this.lblBudget.TabIndex = 5;
            this.lblBudget.Text = "Budget : ";
            // 
            // lblSoldeApresDepenses
            // 
            this.lblSoldeApresDepenses.AutoSize = true;
            this.lblSoldeApresDepenses.BackColor = System.Drawing.Color.Transparent;
            this.lblSoldeApresDepenses.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldeApresDepenses.Location = new System.Drawing.Point(552, 155);
            this.lblSoldeApresDepenses.Name = "lblSoldeApresDepenses";
            this.lblSoldeApresDepenses.Size = new System.Drawing.Size(235, 28);
            this.lblSoldeApresDepenses.TabIndex = 6;
            this.lblSoldeApresDepenses.Text = "Solde après dépenses : ";
            // 
            // flpEquipage
            // 
            this.flpEquipage.AutoScroll = true;
            this.flpEquipage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.flpEquipage.Location = new System.Drawing.Point(6, 29);
            this.flpEquipage.Name = "flpEquipage";
            this.flpEquipage.Size = new System.Drawing.Size(864, 224);
            this.flpEquipage.TabIndex = 7;
            // 
            // flpObjectifCaptures
            // 
            this.flpObjectifCaptures.AutoScroll = true;
            this.flpObjectifCaptures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.flpObjectifCaptures.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpObjectifCaptures.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpObjectifCaptures.Location = new System.Drawing.Point(6, 26);
            this.flpObjectifCaptures.Name = "flpObjectifCaptures";
            this.flpObjectifCaptures.Size = new System.Drawing.Size(671, 107);
            this.flpObjectifCaptures.TabIndex = 13;
            // 
            // lblNbJours
            // 
            this.lblNbJours.AutoSize = true;
            this.lblNbJours.BackColor = System.Drawing.Color.Transparent;
            this.lblNbJours.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbJours.Location = new System.Drawing.Point(212, 110);
            this.lblNbJours.Name = "lblNbJours";
            this.lblNbJours.Size = new System.Drawing.Size(193, 28);
            this.lblNbJours.TabIndex = 4;
            this.lblNbJours.Text = "Nombre de jours : ";
            // 
            // rtbFeuilleDeRoute
            // 
            this.rtbFeuilleDeRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.rtbFeuilleDeRoute.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFeuilleDeRoute.Location = new System.Drawing.Point(6, 25);
            this.rtbFeuilleDeRoute.Name = "rtbFeuilleDeRoute";
            this.rtbFeuilleDeRoute.ReadOnly = true;
            this.rtbFeuilleDeRoute.Size = new System.Drawing.Size(864, 106);
            this.rtbFeuilleDeRoute.TabIndex = 8;
            this.rtbFeuilleDeRoute.Text = "";
            // 
            // btnJournal
            // 
            this.btnJournal.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJournal.Location = new System.Drawing.Point(744, 716);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(122, 73);
            this.btnJournal.TabIndex = 12;
            this.btnJournal.Text = "Accès Journal";
            this.btnJournal.UseVisualStyleBackColor = true;
            this.btnJournal.Click += new System.EventHandler(this.btnJournal_Click);
            // 
            // tbcNouvEvnmt
            // 
            this.tbcNouvEvnmt.Controls.Add(this.tpNouvContact);
            this.tbcNouvEvnmt.Controls.Add(this.tbcNouvDepense);
            this.tbcNouvEvnmt.Controls.Add(this.tbcEvnmt);
            this.tbcNouvEvnmt.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcNouvEvnmt.Location = new System.Drawing.Point(960, 110);
            this.tbcNouvEvnmt.Margin = new System.Windows.Forms.Padding(2);
            this.tbcNouvEvnmt.Name = "tbcNouvEvnmt";
            this.tbcNouvEvnmt.SelectedIndex = 0;
            this.tbcNouvEvnmt.Size = new System.Drawing.Size(741, 679);
            this.tbcNouvEvnmt.TabIndex = 10;
            // 
            // tpNouvContact
            // 
            this.tpNouvContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.tpNouvContact.Controls.Add(this.dtpContact);
            this.tpNouvContact.Controls.Add(this.txtSomme);
            this.tpNouvContact.Controls.Add(this.txtAppreciation);
            this.tpNouvContact.Controls.Add(this.btnValidNouvC);
            this.tpNouvContact.Controls.Add(this.btnAnnulNouvC);
            this.tpNouvContact.Controls.Add(this.cboInformateur);
            this.tpNouvContact.Controls.Add(this.label5);
            this.tpNouvContact.Controls.Add(this.label4);
            this.tpNouvContact.Controls.Add(this.label3);
            this.tpNouvContact.Controls.Add(this.label2);
            this.tpNouvContact.Location = new System.Drawing.Point(4, 37);
            this.tpNouvContact.Margin = new System.Windows.Forms.Padding(2);
            this.tpNouvContact.Name = "tpNouvContact";
            this.tpNouvContact.Padding = new System.Windows.Forms.Padding(2);
            this.tpNouvContact.Size = new System.Drawing.Size(733, 638);
            this.tpNouvContact.TabIndex = 0;
            this.tpNouvContact.Text = "Nouveau Contact";
            // 
            // dtpContact
            // 
            this.dtpContact.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtpContact.CustomFormat = "dd/MM/yyyy";
            this.dtpContact.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpContact.Location = new System.Drawing.Point(175, 67);
            this.dtpContact.Margin = new System.Windows.Forms.Padding(2);
            this.dtpContact.Name = "dtpContact";
            this.dtpContact.Size = new System.Drawing.Size(257, 35);
            this.dtpContact.TabIndex = 19;
            // 
            // txtSomme
            // 
            this.txtSomme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtSomme.Location = new System.Drawing.Point(189, 145);
            this.txtSomme.Margin = new System.Windows.Forms.Padding(2);
            this.txtSomme.Name = "txtSomme";
            this.txtSomme.Size = new System.Drawing.Size(137, 35);
            this.txtSomme.TabIndex = 18;
            this.txtSomme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSomme_KeyDown);
            this.txtSomme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSomme_KeyPress);
            // 
            // txtAppreciation
            // 
            this.txtAppreciation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.txtAppreciation.Location = new System.Drawing.Point(189, 228);
            this.txtAppreciation.Margin = new System.Windows.Forms.Padding(2);
            this.txtAppreciation.Multiline = true;
            this.txtAppreciation.Name = "txtAppreciation";
            this.txtAppreciation.Size = new System.Drawing.Size(486, 148);
            this.txtAppreciation.TabIndex = 17;
            // 
            // btnValidNouvC
            // 
            this.btnValidNouvC.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnValidNouvC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidNouvC.Location = new System.Drawing.Point(618, 559);
            this.btnValidNouvC.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidNouvC.Name = "btnValidNouvC";
            this.btnValidNouvC.Size = new System.Drawing.Size(57, 52);
            this.btnValidNouvC.TabIndex = 16;
            this.btnValidNouvC.UseVisualStyleBackColor = true;
            this.btnValidNouvC.Click += new System.EventHandler(this.btnValidNouvC_Click);
            // 
            // btnAnnulNouvC
            // 
            this.btnAnnulNouvC.BackgroundImage = global::Formulaire_principal.Properties.Resources.supprimer;
            this.btnAnnulNouvC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnulNouvC.Location = new System.Drawing.Point(514, 559);
            this.btnAnnulNouvC.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnulNouvC.Name = "btnAnnulNouvC";
            this.btnAnnulNouvC.Size = new System.Drawing.Size(57, 52);
            this.btnAnnulNouvC.TabIndex = 15;
            this.btnAnnulNouvC.UseVisualStyleBackColor = true;
            this.btnAnnulNouvC.Click += new System.EventHandler(this.btnAnnulNouvC_Click);
            // 
            // cboInformateur
            // 
            this.cboInformateur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboInformateur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboInformateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboInformateur.FormattingEnabled = true;
            this.cboInformateur.Location = new System.Drawing.Point(214, 436);
            this.cboInformateur.Margin = new System.Windows.Forms.Padding(2);
            this.cboInformateur.Name = "cboInformateur";
            this.cboInformateur.Size = new System.Drawing.Size(357, 36);
            this.cboInformateur.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 444);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Informateur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apréciation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Somme :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date :";
            // 
            // tbcNouvDepense
            // 
            this.tbcNouvDepense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.tbcNouvDepense.Controls.Add(this.dtpDepense);
            this.tbcNouvDepense.Controls.Add(this.txtMontant);
            this.tbcNouvDepense.Controls.Add(this.txtMotif);
            this.tbcNouvDepense.Controls.Add(this.btnValidDepense);
            this.tbcNouvDepense.Controls.Add(this.btnAnnulNouvD);
            this.tbcNouvDepense.Controls.Add(this.cboTypeDepense);
            this.tbcNouvDepense.Controls.Add(this.label6);
            this.tbcNouvDepense.Controls.Add(this.label7);
            this.tbcNouvDepense.Controls.Add(this.label8);
            this.tbcNouvDepense.Controls.Add(this.label9);
            this.tbcNouvDepense.Location = new System.Drawing.Point(4, 37);
            this.tbcNouvDepense.Margin = new System.Windows.Forms.Padding(2);
            this.tbcNouvDepense.Name = "tbcNouvDepense";
            this.tbcNouvDepense.Padding = new System.Windows.Forms.Padding(2);
            this.tbcNouvDepense.Size = new System.Drawing.Size(733, 638);
            this.tbcNouvDepense.TabIndex = 1;
            this.tbcNouvDepense.Text = "Nouvelle dépense";
            // 
            // dtpDepense
            // 
            this.dtpDepense.CustomFormat = "dd/MM/yyyy";
            this.dtpDepense.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepense.Location = new System.Drawing.Point(175, 67);
            this.dtpDepense.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDepense.Name = "dtpDepense";
            this.dtpDepense.Size = new System.Drawing.Size(257, 35);
            this.dtpDepense.TabIndex = 19;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(189, 145);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(2);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(257, 35);
            this.txtMontant.TabIndex = 18;
            this.txtMontant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMontant_KeyDown);
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(189, 228);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(486, 177);
            this.txtMotif.TabIndex = 17;
            // 
            // btnValidDepense
            // 
            this.btnValidDepense.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnValidDepense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidDepense.Location = new System.Drawing.Point(618, 559);
            this.btnValidDepense.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidDepense.Name = "btnValidDepense";
            this.btnValidDepense.Size = new System.Drawing.Size(57, 52);
            this.btnValidDepense.TabIndex = 16;
            this.btnValidDepense.UseVisualStyleBackColor = true;
            this.btnValidDepense.Click += new System.EventHandler(this.btnValidDepense_Click);
            // 
            // btnAnnulNouvD
            // 
            this.btnAnnulNouvD.BackgroundImage = global::Formulaire_principal.Properties.Resources.supprimer;
            this.btnAnnulNouvD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnulNouvD.Location = new System.Drawing.Point(514, 559);
            this.btnAnnulNouvD.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnulNouvD.Name = "btnAnnulNouvD";
            this.btnAnnulNouvD.Size = new System.Drawing.Size(57, 52);
            this.btnAnnulNouvD.TabIndex = 15;
            this.btnAnnulNouvD.UseVisualStyleBackColor = true;
            this.btnAnnulNouvD.Click += new System.EventHandler(this.btnAnnulNouvD_Click);
            // 
            // cboTypeDepense
            // 
            this.cboTypeDepense.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTypeDepense.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTypeDepense.FormattingEnabled = true;
            this.cboTypeDepense.Location = new System.Drawing.Point(289, 456);
            this.cboTypeDepense.Margin = new System.Windows.Forms.Padding(2);
            this.cboTypeDepense.Name = "cboTypeDepense";
            this.cboTypeDepense.Size = new System.Drawing.Size(357, 36);
            this.cboTypeDepense.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 459);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type de dépense :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Motif :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Montant :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 28);
            this.label9.TabIndex = 10;
            this.label9.Text = "Date :";
            // 
            // tbcEvnmt
            // 
            this.tbcEvnmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.tbcEvnmt.Controls.Add(this.dtpEvnmt);
            this.tbcEvnmt.Controls.Add(this.txtCommentaires);
            this.tbcEvnmt.Controls.Add(this.btnValidEvnmt);
            this.tbcEvnmt.Controls.Add(this.btnAnnulNouvE);
            this.tbcEvnmt.Controls.Add(this.label11);
            this.tbcEvnmt.Controls.Add(this.label13);
            this.tbcEvnmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbcEvnmt.Location = new System.Drawing.Point(4, 37);
            this.tbcEvnmt.Margin = new System.Windows.Forms.Padding(2);
            this.tbcEvnmt.Name = "tbcEvnmt";
            this.tbcEvnmt.Padding = new System.Windows.Forms.Padding(2);
            this.tbcEvnmt.Size = new System.Drawing.Size(733, 638);
            this.tbcEvnmt.TabIndex = 2;
            this.tbcEvnmt.Text = "Nouvel évènement";
            // 
            // dtpEvnmt
            // 
            this.dtpEvnmt.Location = new System.Drawing.Point(189, 72);
            this.dtpEvnmt.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEvnmt.Name = "dtpEvnmt";
            this.dtpEvnmt.Size = new System.Drawing.Size(257, 35);
            this.dtpEvnmt.TabIndex = 15;
            // 
            // txtCommentaires
            // 
            this.txtCommentaires.Location = new System.Drawing.Point(52, 231);
            this.txtCommentaires.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommentaires.Multiline = true;
            this.txtCommentaires.Name = "txtCommentaires";
            this.txtCommentaires.Size = new System.Drawing.Size(645, 267);
            this.txtCommentaires.TabIndex = 14;
            // 
            // btnValidEvnmt
            // 
            this.btnValidEvnmt.BackgroundImage = global::Formulaire_principal.Properties.Resources.valider;
            this.btnValidEvnmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidEvnmt.Location = new System.Drawing.Point(618, 559);
            this.btnValidEvnmt.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidEvnmt.Name = "btnValidEvnmt";
            this.btnValidEvnmt.Size = new System.Drawing.Size(57, 52);
            this.btnValidEvnmt.TabIndex = 13;
            this.btnValidEvnmt.UseVisualStyleBackColor = true;
            this.btnValidEvnmt.Click += new System.EventHandler(this.btnValidEvnmt_Click);
            // 
            // btnAnnulNouvE
            // 
            this.btnAnnulNouvE.BackgroundImage = global::Formulaire_principal.Properties.Resources.supprimer;
            this.btnAnnulNouvE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnnulNouvE.Location = new System.Drawing.Point(514, 559);
            this.btnAnnulNouvE.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnulNouvE.Name = "btnAnnulNouvE";
            this.btnAnnulNouvE.Size = new System.Drawing.Size(57, 52);
            this.btnAnnulNouvE.TabIndex = 12;
            this.btnAnnulNouvE.UseVisualStyleBackColor = true;
            this.btnAnnulNouvE.Click += new System.EventHandler(this.btnAnnulNouvE_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 184);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(441, 28);
            this.label11.TabIndex = 11;
            this.label11.Text = "Évènement à écrire dans le journal de bord :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 77);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 28);
            this.label13.TabIndex = 10;
            this.label13.Text = "Date :";
            // 
            // grpCommentaires
            // 
            this.grpCommentaires.BackColor = System.Drawing.Color.Transparent;
            this.grpCommentaires.Controls.Add(this.rtbFeuilleDeRoute);
            this.grpCommentaires.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCommentaires.Location = new System.Drawing.Point(25, 219);
            this.grpCommentaires.Name = "grpCommentaires";
            this.grpCommentaires.Size = new System.Drawing.Size(876, 125);
            this.grpCommentaires.TabIndex = 14;
            this.grpCommentaires.TabStop = false;
            this.grpCommentaires.Text = "Feuille de route : ";
            // 
            // grpMembresEquipage
            // 
            this.grpMembresEquipage.BackColor = System.Drawing.Color.Transparent;
            this.grpMembresEquipage.Controls.Add(this.flpEquipage);
            this.grpMembresEquipage.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMembresEquipage.Location = new System.Drawing.Point(25, 380);
            this.grpMembresEquipage.Name = "grpMembresEquipage";
            this.grpMembresEquipage.Size = new System.Drawing.Size(876, 259);
            this.grpMembresEquipage.TabIndex = 15;
            this.grpMembresEquipage.TabStop = false;
            this.grpMembresEquipage.Text = "Membres de l\'équipage :";
            // 
            // grpObjectifCaptures
            // 
            this.grpObjectifCaptures.BackColor = System.Drawing.Color.Transparent;
            this.grpObjectifCaptures.Controls.Add(this.flpObjectifCaptures);
            this.grpObjectifCaptures.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpObjectifCaptures.Location = new System.Drawing.Point(25, 656);
            this.grpObjectifCaptures.Name = "grpObjectifCaptures";
            this.grpObjectifCaptures.Size = new System.Drawing.Size(683, 139);
            this.grpObjectifCaptures.TabIndex = 0;
            this.grpObjectifCaptures.TabStop = false;
            this.grpObjectifCaptures.Text = "Objectifs de capture : ";
            // 
            // FrmDetailMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1779, 807);
            this.Controls.Add(this.grpObjectifCaptures);
            this.Controls.Add(this.grpMembresEquipage);
            this.Controls.Add(this.tbcNouvEvnmt);
            this.Controls.Add(this.btnJournal);
            this.Controls.Add(this.grpCommentaires);
            this.Controls.Add(this.lblSoldeApresDepenses);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblNbJours);
            this.Controls.Add(this.lblDates);
            this.Controls.Add(this.picMission);
            this.Controls.Add(this.lblNomMission);
            this.Name = "FrmDetailMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche Mission : ";
            this.Load += new System.EventHandler(this.FrmDetailMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMission)).EndInit();
            this.tbcNouvEvnmt.ResumeLayout(false);
            this.tpNouvContact.ResumeLayout(false);
            this.tpNouvContact.PerformLayout();
            this.tbcNouvDepense.ResumeLayout(false);
            this.tbcNouvDepense.PerformLayout();
            this.tbcEvnmt.ResumeLayout(false);
            this.tbcEvnmt.PerformLayout();
            this.grpCommentaires.ResumeLayout(false);
            this.grpMembresEquipage.ResumeLayout(false);
            this.grpObjectifCaptures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.PictureBox picMission;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblSoldeApresDepenses;
        private System.Windows.Forms.FlowLayoutPanel flpEquipage;
        private System.Windows.Forms.Label lblNbJours;
        private System.Windows.Forms.RichTextBox rtbFeuilleDeRoute;
        private System.Windows.Forms.Button btnJournal;
        private System.Windows.Forms.FlowLayoutPanel flpObjectifCaptures;
        private System.Windows.Forms.TabControl tbcNouvEvnmt;
        private System.Windows.Forms.TabPage tpNouvContact;
        private System.Windows.Forms.TabPage tbcNouvDepense;
        private System.Windows.Forms.TabPage tbcEvnmt;
        private System.Windows.Forms.DateTimePicker dtpContact;
        private System.Windows.Forms.TextBox txtSomme;
        private System.Windows.Forms.TextBox txtAppreciation;
        private System.Windows.Forms.Button btnValidNouvC;
        private System.Windows.Forms.Button btnAnnulNouvC;
        private System.Windows.Forms.ComboBox cboInformateur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDepense;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Button btnValidDepense;
        private System.Windows.Forms.Button btnAnnulNouvD;
        private System.Windows.Forms.ComboBox cboTypeDepense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEvnmt;
        private System.Windows.Forms.TextBox txtCommentaires;
        private System.Windows.Forms.Button btnValidEvnmt;
        private System.Windows.Forms.Button btnAnnulNouvE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpCommentaires;
        private System.Windows.Forms.GroupBox grpMembresEquipage;
        private System.Windows.Forms.GroupBox grpObjectifCaptures;
    }
}