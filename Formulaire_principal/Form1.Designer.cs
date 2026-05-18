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
            this.btnPlanetes = new System.Windows.Forms.Button();
            this.btnMission = new System.Windows.Forms.Button();
            this.btnAliens = new System.Windows.Forms.Button();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
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
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.plMissions.SuspendLayout();
            this.grpFiltres.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlanetes
            // 
            this.btnPlanetes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanetes.Location = new System.Drawing.Point(1077, 658);
            this.btnPlanetes.Name = "btnPlanetes";
            this.btnPlanetes.Size = new System.Drawing.Size(75, 32);
            this.btnPlanetes.TabIndex = 0;
            this.btnPlanetes.Text = "Planètes";
            this.btnPlanetes.UseVisualStyleBackColor = true;
            this.btnPlanetes.Click += new System.EventHandler(this.btnPlanetes_Click);
            // 
            // btnMission
            // 
            this.btnMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMission.Location = new System.Drawing.Point(499, 658);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(108, 32);
            this.btnMission.TabIndex = 1;
            this.btnMission.Text = "Nouvelle Mission";
            this.btnMission.UseVisualStyleBackColor = true;
            this.btnMission.Click += new System.EventHandler(this.btnMission_Click);
            // 
            // btnAliens
            // 
            this.btnAliens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAliens.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAliens.Location = new System.Drawing.Point(754, 658);
            this.btnAliens.Name = "btnAliens";
            this.btnAliens.Size = new System.Drawing.Size(75, 32);
            this.btnAliens.TabIndex = 3;
            this.btnAliens.Text = "Aliens";
            this.btnAliens.UseVisualStyleBackColor = true;
            this.btnAliens.Click += new System.EventHandler(this.btnAliens_Click);
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableauDeBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableauDeBord.Location = new System.Drawing.Point(242, 658);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Size = new System.Drawing.Size(118, 32);
            this.btnTableauDeBord.TabIndex = 2;
            this.btnTableauDeBord.Text = "Tableau de bord";
            this.btnTableauDeBord.UseVisualStyleBackColor = true;
            this.btnTableauDeBord.Click += new System.EventHandler(this.btnTableauDeBord_Click);
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
            this.plMissions.Size = new System.Drawing.Size(1158, 596);
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
            this.rdbPasse.Checked = true;
            this.rdbPasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbPasse.Location = new System.Drawing.Point(121, 25);
            this.rdbPasse.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPasse.Name = "rdbPasse";
            this.rdbPasse.Size = new System.Drawing.Size(65, 17);
            this.rdbPasse.TabIndex = 1;
            this.rdbPasse.TabStop = true;
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
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.toolStripTextBox4});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(150, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(213, 697);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(25, 100, 2, 1);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(180, 28);
            this.toolStripTextBox1.Text = "Tableau de bord";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox2.Margin = new System.Windows.Forms.Padding(25, 25, 1, 1);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(180, 28);
            this.toolStripTextBox2.Text = "Création d\'une mission";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox3.Margin = new System.Windows.Forms.Padding(25, 25, 1, 1);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.ReadOnly = true;
            this.toolStripTextBox3.Size = new System.Drawing.Size(180, 28);
            this.toolStripTextBox3.Text = "Aliens";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox4.Margin = new System.Windows.Forms.Padding(25, 25, 1, 1);
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.ReadOnly = true;
            this.toolStripTextBox4.Size = new System.Drawing.Size(180, 28);
            this.toolStripTextBox4.Text = "Planète";
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 697);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.plMissions);
            this.Controls.Add(this.btnAliens);
            this.Controls.Add(this.btnTableauDeBord);
            this.Controls.Add(this.btnMission);
            this.Controls.Add(this.btnPlanetes);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlanetes;
        private System.Windows.Forms.Button btnMission;
        private System.Windows.Forms.Button btnAliens;
        private System.Windows.Forms.Button btnTableauDeBord;
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
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
    }
}

