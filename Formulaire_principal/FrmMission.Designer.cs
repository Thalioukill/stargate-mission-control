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
            this.lblChef = new System.Windows.Forms.Label();
            this.cboChef = new System.Windows.Forms.ComboBox();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.btnValidPlanete = new System.Windows.Forms.Button();
            this.cboPlanete = new System.Windows.Forms.ComboBox();
            this.lblChoix = new System.Windows.Forms.Label();
            this.grpNouvelleMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNouvelleMission
            // 
            this.grpNouvelleMission.AutoSize = true;
            this.grpNouvelleMission.Controls.Add(this.lblChef);
            this.grpNouvelleMission.Controls.Add(this.cboChef);
            this.grpNouvelleMission.Controls.Add(this.lblNomMission);
            this.grpNouvelleMission.Controls.Add(this.btnValidPlanete);
            this.grpNouvelleMission.Controls.Add(this.cboPlanete);
            this.grpNouvelleMission.Controls.Add(this.lblChoix);
            this.grpNouvelleMission.Location = new System.Drawing.Point(29, 24);
            this.grpNouvelleMission.Name = "grpNouvelleMission";
            this.grpNouvelleMission.Size = new System.Drawing.Size(1115, 916);
            this.grpNouvelleMission.TabIndex = 0;
            this.grpNouvelleMission.TabStop = false;
            this.grpNouvelleMission.Text = "Nouvelle mission";
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblChef.Location = new System.Drawing.Point(59, 298);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(284, 25);
            this.lblChef.TabIndex = 5;
            this.lblChef.Text = "2 - Choix du chef de mission";
            // 
            // cboChef
            // 
            this.cboChef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChef.FormattingEnabled = true;
            this.cboChef.Location = new System.Drawing.Point(366, 290);
            this.cboChef.Name = "cboChef";
            this.cboChef.Size = new System.Drawing.Size(450, 33);
            this.cboChef.TabIndex = 4;
            // 
            // lblNomMission
            // 
            this.lblNomMission.AutoSize = true;
            this.lblNomMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMission.Location = new System.Drawing.Point(146, 154);
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
            // FrmMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1172, 966);
            this.Controls.Add(this.grpNouvelleMission);
            this.Name = "FrmMission";
            this.Text = "Création d\'une nouvelle mission";
            this.Load += new System.EventHandler(this.FrmMission_Load);
            this.grpNouvelleMission.ResumeLayout(false);
            this.grpNouvelleMission.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNouvelleMission;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Button btnValidPlanete;
        private System.Windows.Forms.ComboBox cboPlanete;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.ComboBox cboChef;
        private System.Windows.Forms.Label lblChef;
    }
}