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
            this.lblNomMission = new System.Windows.Forms.Label();
            this.btnValidPlanete = new System.Windows.Forms.Button();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.lblChoix = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.btnValidMission = new System.Windows.Forms.Button();
            this.lblEuros = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblTonnes = new System.Windows.Forms.Label();
            this.txtobjDataBaz = new System.Windows.Forms.TextBox();
            this.lblobjDataBaz = new System.Windows.Forms.Label();
            this.lblPersonnes = new System.Windows.Forms.Label();
            this.txtnbMembres = new System.Windows.Forms.TextBox();
            this.lblnbMembres = new System.Windows.Forms.Label();
            this.txtfeuilleRoute = new System.Windows.Forms.TextBox();
            this.lblfdr = new System.Windows.Forms.Label();
            this.dtpRetour = new System.Windows.Forms.DateTimePicker();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.lbldateRetour = new System.Windows.Forms.Label();
            this.lbldateDepart = new System.Windows.Forms.Label();
            this.lblParam = new System.Windows.Forms.Label();
            this.lblChef = new System.Windows.Forms.Label();
            this.cboChef = new System.Windows.Forms.ComboBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.grpNouvelleMission.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNouvelleMission
            // 
            this.grpNouvelleMission.AutoSize = true;
            this.grpNouvelleMission.Controls.Add(this.lblNum);
            this.grpNouvelleMission.Controls.Add(this.pnl);
            this.grpNouvelleMission.Controls.Add(this.lblNomMission);
            this.grpNouvelleMission.Controls.Add(this.btnValidPlanete);
            this.grpNouvelleMission.Controls.Add(this.cboPlanete);
            this.grpNouvelleMission.Controls.Add(this.lblChoix);
            this.grpNouvelleMission.Location = new System.Drawing.Point(29, 24);
            this.grpNouvelleMission.Name = "grpNouvelleMission";
            this.grpNouvelleMission.Size = new System.Drawing.Size(1029, 1129);
            this.grpNouvelleMission.TabIndex = 0;
            this.grpNouvelleMission.TabStop = false;
            this.grpNouvelleMission.Text = "Nouvelle mission";
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
            // btnValidPlanete
            // 
            this.btnValidPlanete.Location = new System.Drawing.Point(803, 49);
            this.btnValidPlanete.Name = "btnValidPlanete";
            this.btnValidPlanete.Size = new System.Drawing.Size(179, 61);
            this.btnValidPlanete.TabIndex = 2;
            this.btnValidPlanete.Text = "Valider planète";
            this.btnValidPlanete.UseVisualStyleBackColor = true;
            this.btnValidPlanete.Click += new System.EventHandler(this.btnValidPlanete_Click);
            // 
            // cboPlanete
            // 
            this.cboPlanete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlanete.FormattingEnabled = true;
            this.cboPlanete.Location = new System.Drawing.Point(366, 64);
            this.cboPlanete.Name = "cboPlanete";
            this.cboPlanete.Size = new System.Drawing.Size(352, 33);
            this.cboPlanete.TabIndex = 1;
            this.cboPlanete.SelectedIndexChanged += new System.EventHandler(this.cboPlanete_SelectedIndexChanged);
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Location = new System.Drawing.Point(59, 69);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(228, 25);
            this.lblChoix.TabIndex = 0;
            this.lblChoix.Text = "1 - Choix de la planète";
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
            this.pnl.Size = new System.Drawing.Size(978, 863);
            this.pnl.TabIndex = 4;
            // 
            // btnValidMission
            // 
            this.btnValidMission.Location = new System.Drawing.Point(755, 766);
            this.btnValidMission.Name = "btnValidMission";
            this.btnValidMission.Size = new System.Drawing.Size(188, 65);
            this.btnValidMission.TabIndex = 41;
            this.btnValidMission.Text = "Valider la mission";
            this.btnValidMission.UseVisualStyleBackColor = true;
            this.btnValidMission.Click += new System.EventHandler(this.btnValidMission_Click);
            // 
            // lblEuros
            // 
            this.lblEuros.AutoSize = true;
            this.lblEuros.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEuros.Location = new System.Drawing.Point(387, 794);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(24, 25);
            this.lblEuros.TabIndex = 40;
            this.lblEuros.Text = "€";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(306, 791);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(62, 31);
            this.txtBudget.TabIndex = 39;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBudget.Location = new System.Drawing.Point(68, 794);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(80, 25);
            this.lblBudget.TabIndex = 38;
            this.lblBudget.Text = "Budget";
            // 
            // lblTonnes
            // 
            this.lblTonnes.AutoSize = true;
            this.lblTonnes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTonnes.Location = new System.Drawing.Point(387, 733);
            this.lblTonnes.Name = "lblTonnes";
            this.lblTonnes.Size = new System.Drawing.Size(77, 25);
            this.lblTonnes.TabIndex = 37;
            this.lblTonnes.Text = "tonnes";
            // 
            // txtobjDataBaz
            // 
            this.txtobjDataBaz.Location = new System.Drawing.Point(306, 730);
            this.txtobjDataBaz.Name = "txtobjDataBaz";
            this.txtobjDataBaz.Size = new System.Drawing.Size(62, 31);
            this.txtobjDataBaz.TabIndex = 36;
            // 
            // lblobjDataBaz
            // 
            this.lblobjDataBaz.AutoSize = true;
            this.lblobjDataBaz.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblobjDataBaz.Location = new System.Drawing.Point(68, 733);
            this.lblobjDataBaz.Name = "lblobjDataBaz";
            this.lblobjDataBaz.Size = new System.Drawing.Size(173, 25);
            this.lblobjDataBaz.TabIndex = 35;
            this.lblobjDataBaz.Text = "Objectif DataBaz";
            // 
            // lblPersonnes
            // 
            this.lblPersonnes.AutoSize = true;
            this.lblPersonnes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPersonnes.Location = new System.Drawing.Point(387, 671);
            this.lblPersonnes.Name = "lblPersonnes";
            this.lblPersonnes.Size = new System.Drawing.Size(115, 25);
            this.lblPersonnes.TabIndex = 34;
            this.lblPersonnes.Text = "Personnes";
            // 
            // txtnbMembres
            // 
            this.txtnbMembres.Location = new System.Drawing.Point(306, 668);
            this.txtnbMembres.Name = "txtnbMembres";
            this.txtnbMembres.Size = new System.Drawing.Size(62, 31);
            this.txtnbMembres.TabIndex = 33;
            // 
            // lblnbMembres
            // 
            this.lblnbMembres.AutoSize = true;
            this.lblnbMembres.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblnbMembres.Location = new System.Drawing.Point(68, 671);
            this.lblnbMembres.Name = "lblnbMembres";
            this.lblnbMembres.Size = new System.Drawing.Size(211, 25);
            this.lblnbMembres.TabIndex = 32;
            this.lblnbMembres.Text = "Nombre de membres";
            // 
            // txtfeuilleRoute
            // 
            this.txtfeuilleRoute.Location = new System.Drawing.Point(306, 400);
            this.txtfeuilleRoute.Multiline = true;
            this.txtfeuilleRoute.Name = "txtfeuilleRoute";
            this.txtfeuilleRoute.Size = new System.Drawing.Size(614, 230);
            this.txtfeuilleRoute.TabIndex = 31;
            // 
            // lblfdr
            // 
            this.lblfdr.AutoSize = true;
            this.lblfdr.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblfdr.Location = new System.Drawing.Point(68, 390);
            this.lblfdr.Name = "lblfdr";
            this.lblfdr.Size = new System.Drawing.Size(161, 25);
            this.lblfdr.TabIndex = 30;
            this.lblfdr.Text = "Feuille de route";
            // 
            // dtpRetour
            // 
            this.dtpRetour.CustomFormat = "yyyy-MM-dd";
            this.dtpRetour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRetour.Location = new System.Drawing.Point(306, 310);
            this.dtpRetour.Name = "dtpRetour";
            this.dtpRetour.Size = new System.Drawing.Size(220, 31);
            this.dtpRetour.TabIndex = 29;
            // 
            // dtpDepart
            // 
            this.dtpDepart.CustomFormat = "yyyy-MM-dd";
            this.dtpDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepart.Location = new System.Drawing.Point(306, 233);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(220, 31);
            this.dtpDepart.TabIndex = 28;
            // 
            // lbldateRetour
            // 
            this.lbldateRetour.AutoSize = true;
            this.lbldateRetour.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbldateRetour.Location = new System.Drawing.Point(68, 310);
            this.lbldateRetour.Name = "lbldateRetour";
            this.lbldateRetour.Size = new System.Drawing.Size(119, 25);
            this.lbldateRetour.TabIndex = 27;
            this.lbldateRetour.Text = "Date retour";
            // 
            // lbldateDepart
            // 
            this.lbldateDepart.AutoSize = true;
            this.lbldateDepart.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbldateDepart.Location = new System.Drawing.Point(68, 238);
            this.lbldateDepart.Name = "lbldateDepart";
            this.lbldateDepart.Size = new System.Drawing.Size(124, 25);
            this.lbldateDepart.TabIndex = 26;
            this.lbldateDepart.Text = "Date départ";
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblParam.Location = new System.Drawing.Point(36, 141);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(279, 25);
            this.lblParam.TabIndex = 25;
            this.lblParam.Text = "3- Paramètres de la mission";
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblChef.Location = new System.Drawing.Point(36, 39);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(284, 25);
            this.lblChef.TabIndex = 24;
            this.lblChef.Text = "2 - Choix du chef de mission";
            // 
            // cboChef
            // 
            this.cboChef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChef.FormattingEnabled = true;
            this.cboChef.Location = new System.Drawing.Point(343, 31);
            this.cboChef.Name = "cboChef";
            this.cboChef.Size = new System.Drawing.Size(450, 33);
            this.cboChef.TabIndex = 23;
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
            // FrmMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1092, 1177);
            this.Controls.Add(this.grpNouvelleMission);
            this.Name = "FrmMission";
            this.Text = "Création d\'une nouvelle mission";
            this.Load += new System.EventHandler(this.FrmMission_Load);
            this.grpNouvelleMission.ResumeLayout(false);
            this.grpNouvelleMission.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNouvelleMission;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Button btnValidPlanete;
        private System.Windows.Forms.ComboBox cboPlanete;
        private System.Windows.Forms.Label lblChoix;
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
        private System.Windows.Forms.Label lblNum;
    }
}