namespace Formulaire_principal
{
    partial class FrmDetailPlanete
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
            this.flpPourcentageEspeces = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAucuneInfo = new System.Windows.Forms.Label();
            this.flpPourcentageEspeces.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpPourcentageEspeces
            // 
            this.flpPourcentageEspeces.Controls.Add(this.lblAucuneInfo);
            this.flpPourcentageEspeces.Location = new System.Drawing.Point(12, 12);
            this.flpPourcentageEspeces.Name = "flpPourcentageEspeces";
            this.flpPourcentageEspeces.Size = new System.Drawing.Size(498, 474);
            this.flpPourcentageEspeces.TabIndex = 0;
            // 
            // lblAucuneInfo
            // 
            this.lblAucuneInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAucuneInfo.AutoSize = true;
            this.lblAucuneInfo.Location = new System.Drawing.Point(3, 0);
            this.lblAucuneInfo.Name = "lblAucuneInfo";
            this.lblAucuneInfo.Size = new System.Drawing.Size(79, 16);
            this.lblAucuneInfo.TabIndex = 0;
            this.lblAucuneInfo.Text = "Aucune info.";
            // 
            // FrmDetailPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 498);
            this.Controls.Add(this.flpPourcentageEspeces);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDetailPlanete";
            this.Text = "FrmDetailPlanete";
            this.Load += new System.EventHandler(this.FrmDetailPlanete_Load);
            this.flpPourcentageEspeces.ResumeLayout(false);
            this.flpPourcentageEspeces.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPourcentageEspeces;
        private System.Windows.Forms.Label lblAucuneInfo;
    }
}