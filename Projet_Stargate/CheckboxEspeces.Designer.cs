namespace Projet_Stargate
{
    partial class CheckboxEspeces
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
            this.chkEspece = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkEspece
            // 
            this.chkEspece.AutoSize = true;
            this.chkEspece.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkEspece.Location = new System.Drawing.Point(3, 3);
            this.chkEspece.Name = "chkEspece";
            this.chkEspece.Size = new System.Drawing.Size(95, 21);
            this.chkEspece.TabIndex = 0;
            this.chkEspece.Text = "checkBox1";
            this.chkEspece.UseVisualStyleBackColor = true;
            // 
            // CheckboxEspeces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkEspece);
            this.Name = "CheckboxEspeces";
            this.Size = new System.Drawing.Size(95, 26);
            this.Load += new System.EventHandler(this.CheckboxEspeces_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEspece;
    }
}
