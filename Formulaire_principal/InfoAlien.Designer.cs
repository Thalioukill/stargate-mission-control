namespace Formulaire_principal
{
    partial class InfoAlien
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomAlliees = new System.Windows.Forms.Label();
            this.lblBienveillance = new System.Windows.Forms.Label();
            this.lblCouleurAlliees = new System.Windows.Forms.Label();
            this.lblPlaneteAlliees = new System.Windows.Forms.Label();
            this.lblInstrument = new System.Windows.Forms.Label();
            this.picAlliees = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAlliees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomAlliees
            // 
            this.lblNomAlliees.AutoSize = true;
            this.lblNomAlliees.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAlliees.Location = new System.Drawing.Point(183, 19);
            this.lblNomAlliees.Name = "lblNomAlliees";
            this.lblNomAlliees.Size = new System.Drawing.Size(57, 24);
            this.lblNomAlliees.TabIndex = 1;
            this.lblNomAlliees.Text = "label1";
            // 
            // lblBienveillance
            // 
            this.lblBienveillance.AutoSize = true;
            this.lblBienveillance.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienveillance.Location = new System.Drawing.Point(183, 54);
            this.lblBienveillance.Name = "lblBienveillance";
            this.lblBienveillance.Size = new System.Drawing.Size(58, 24);
            this.lblBienveillance.TabIndex = 2;
            this.lblBienveillance.Text = "label2";
            // 
            // lblCouleurAlliees
            // 
            this.lblCouleurAlliees.AutoSize = true;
            this.lblCouleurAlliees.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleurAlliees.Location = new System.Drawing.Point(183, 88);
            this.lblCouleurAlliees.Name = "lblCouleurAlliees";
            this.lblCouleurAlliees.Size = new System.Drawing.Size(57, 24);
            this.lblCouleurAlliees.TabIndex = 3;
            this.lblCouleurAlliees.Text = "label3";
            // 
            // lblPlaneteAlliees
            // 
            this.lblPlaneteAlliees.AutoSize = true;
            this.lblPlaneteAlliees.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneteAlliees.Location = new System.Drawing.Point(183, 125);
            this.lblPlaneteAlliees.Name = "lblPlaneteAlliees";
            this.lblPlaneteAlliees.Size = new System.Drawing.Size(57, 24);
            this.lblPlaneteAlliees.TabIndex = 4;
            this.lblPlaneteAlliees.Text = "label4";
            // 
            // lblInstrument
            // 
            this.lblInstrument.AutoSize = true;
            this.lblInstrument.Font = new System.Drawing.Font("Kristen ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrument.Location = new System.Drawing.Point(183, 163);
            this.lblInstrument.Name = "lblInstrument";
            this.lblInstrument.Size = new System.Drawing.Size(57, 24);
            this.lblInstrument.TabIndex = 5;
            this.lblInstrument.Text = "label5";
            // 
            // picAlliees
            // 
            this.picAlliees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAlliees.Location = new System.Drawing.Point(14, 9);
            this.picAlliees.Name = "picAlliees";
            this.picAlliees.Size = new System.Drawing.Size(150, 184);
            this.picAlliees.TabIndex = 0;
            this.picAlliees.TabStop = false;
            // 
            // InfoAlien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblInstrument);
            this.Controls.Add(this.lblPlaneteAlliees);
            this.Controls.Add(this.lblCouleurAlliees);
            this.Controls.Add(this.lblBienveillance);
            this.Controls.Add(this.lblNomAlliees);
            this.Controls.Add(this.picAlliees);
            this.Name = "InfoAlien";
            this.Size = new System.Drawing.Size(522, 204);
            this.Load += new System.EventHandler(this.InfoAlien_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.InfoAlien_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picAlliees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlliees;
        private System.Windows.Forms.Label lblNomAlliees;
        private System.Windows.Forms.Label lblBienveillance;
        private System.Windows.Forms.Label lblCouleurAlliees;
        private System.Windows.Forms.Label lblPlaneteAlliees;
        private System.Windows.Forms.Label lblInstrument;
    }
}
