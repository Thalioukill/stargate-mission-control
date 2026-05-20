namespace Formulaire_principal
{
    partial class FrmStatistiquesMission
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStatistiques = new System.Windows.Forms.DataGridView();
            this.grpFiltres = new System.Windows.Forms.GroupBox();
            this.rdbRentabilite = new System.Windows.Forms.RadioButton();
            this.rdbDepensesMax = new System.Windows.Forms.RadioButton();
            this.rdbInformateursMoinsPayes = new System.Windows.Forms.RadioButton();
            this.rdbComparaisonBudget = new System.Windows.Forms.RadioButton();
            this.rdbSuccesGlobal = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistiques)).BeginInit();
            this.grpFiltres.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStatistiques);
            this.groupBox1.Location = new System.Drawing.Point(64, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvStatistiques
            // 
            this.dgvStatistiques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistiques.Location = new System.Drawing.Point(31, 40);
            this.dgvStatistiques.Name = "dgvStatistiques";
            this.dgvStatistiques.RowHeadersWidth = 51;
            this.dgvStatistiques.RowTemplate.Height = 24;
            this.dgvStatistiques.Size = new System.Drawing.Size(672, 150);
            this.dgvStatistiques.TabIndex = 0;
            // 
            // grpFiltres
            // 
            this.grpFiltres.Controls.Add(this.rdbSuccesGlobal);
            this.grpFiltres.Controls.Add(this.rdbComparaisonBudget);
            this.grpFiltres.Controls.Add(this.rdbInformateursMoinsPayes);
            this.grpFiltres.Controls.Add(this.rdbDepensesMax);
            this.grpFiltres.Controls.Add(this.rdbRentabilite);
            this.grpFiltres.Location = new System.Drawing.Point(64, 47);
            this.grpFiltres.Name = "grpFiltres";
            this.grpFiltres.Size = new System.Drawing.Size(734, 207);
            this.grpFiltres.TabIndex = 1;
            this.grpFiltres.TabStop = false;
            this.grpFiltres.Text = "Filtres :";
            // 
            // rdbRentabilite
            // 
            this.rdbRentabilite.AutoSize = true;
            this.rdbRentabilite.Location = new System.Drawing.Point(31, 48);
            this.rdbRentabilite.Name = "rdbRentabilite";
            this.rdbRentabilite.Size = new System.Drawing.Size(155, 20);
            this.rdbRentabilite.TabIndex = 0;
            this.rdbRentabilite.TabStop = true;
            this.rdbRentabilite.Text = "Rentabilité (DataBaz)";
            this.rdbRentabilite.UseVisualStyleBackColor = true;
            this.rdbRentabilite.CheckedChanged += new System.EventHandler(this.rdbRentabilite_CheckedChanged);
            // 
            // rdbDepensesMax
            // 
            this.rdbDepensesMax.AutoSize = true;
            this.rdbDepensesMax.Location = new System.Drawing.Point(31, 92);
            this.rdbDepensesMax.Name = "rdbDepensesMax";
            this.rdbDepensesMax.Size = new System.Drawing.Size(165, 20);
            this.rdbDepensesMax.TabIndex = 1;
            this.rdbDepensesMax.TabStop = true;
            this.rdbDepensesMax.Text = "Dépenses maximales  ";
            this.rdbDepensesMax.UseVisualStyleBackColor = true;
            this.rdbDepensesMax.CheckedChanged += new System.EventHandler(this.rdbDepensesMax_CheckedChanged);
            // 
            // rdbInformateursMoinsPayes
            // 
            this.rdbInformateursMoinsPayes.AutoSize = true;
            this.rdbInformateursMoinsPayes.Location = new System.Drawing.Point(31, 134);
            this.rdbInformateursMoinsPayes.Name = "rdbInformateursMoinsPayes";
            this.rdbInformateursMoinsPayes.Size = new System.Drawing.Size(202, 20);
            this.rdbInformateursMoinsPayes.TabIndex = 2;
            this.rdbInformateursMoinsPayes.TabStop = true;
            this.rdbInformateursMoinsPayes.Text = "Informateurs les moins payés";
            this.rdbInformateursMoinsPayes.UseVisualStyleBackColor = true;
            this.rdbInformateursMoinsPayes.CheckedChanged += new System.EventHandler(this.rdbInformateursMoinsPayes_CheckedChanged);
            // 
            // rdbComparaisonBudget
            // 
            this.rdbComparaisonBudget.AutoSize = true;
            this.rdbComparaisonBudget.Location = new System.Drawing.Point(357, 48);
            this.rdbComparaisonBudget.Name = "rdbComparaisonBudget";
            this.rdbComparaisonBudget.Size = new System.Drawing.Size(172, 20);
            this.rdbComparaisonBudget.TabIndex = 3;
            this.rdbComparaisonBudget.TabStop = true;
            this.rdbComparaisonBudget.Text = "Comparaison du budget";
            this.rdbComparaisonBudget.UseVisualStyleBackColor = true;
            this.rdbComparaisonBudget.CheckedChanged += new System.EventHandler(this.rdbComparaisonBudget_CheckedChanged);
            // 
            // rdbSuccesGlobal
            // 
            this.rdbSuccesGlobal.AutoSize = true;
            this.rdbSuccesGlobal.Location = new System.Drawing.Point(356, 92);
            this.rdbSuccesGlobal.Name = "rdbSuccesGlobal";
            this.rdbSuccesGlobal.Size = new System.Drawing.Size(196, 20);
            this.rdbSuccesGlobal.TabIndex = 4;
            this.rdbSuccesGlobal.TabStop = true;
            this.rdbSuccesGlobal.Text = "Succès global de la mission";
            this.rdbSuccesGlobal.UseVisualStyleBackColor = true;
            this.rdbSuccesGlobal.CheckedChanged += new System.EventHandler(this.rdbSuccesGlobal_CheckedChanged);
            // 
            // FrmStatistiquesMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 867);
            this.Controls.Add(this.grpFiltres);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStatistiquesMission";
            this.Text = "FrmStatistiquesMission";
            this.Load += new System.EventHandler(this.FrmStatistiquesMission_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistiques)).EndInit();
            this.grpFiltres.ResumeLayout(false);
            this.grpFiltres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStatistiques;
        private System.Windows.Forms.GroupBox grpFiltres;
        private System.Windows.Forms.RadioButton rdbRentabilite;
        private System.Windows.Forms.RadioButton rdbDepensesMax;
        private System.Windows.Forms.RadioButton rdbInformateursMoinsPayes;
        private System.Windows.Forms.RadioButton rdbComparaisonBudget;
        private System.Windows.Forms.RadioButton rdbSuccesGlobal;
    }
}