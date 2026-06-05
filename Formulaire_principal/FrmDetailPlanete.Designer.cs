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
            this.SuspendLayout();
            // 
            // flpPourcentageEspeces
            // 
            this.flpPourcentageEspeces.AutoScroll = true;
            this.flpPourcentageEspeces.BackColor = System.Drawing.Color.Transparent;
            this.flpPourcentageEspeces.Location = new System.Drawing.Point(12, 30);
            this.flpPourcentageEspeces.Name = "flpPourcentageEspeces";
            this.flpPourcentageEspeces.Size = new System.Drawing.Size(566, 296);
            this.flpPourcentageEspeces.TabIndex = 0;
            // 
            // lblAucuneInfo
            // 
            this.lblAucuneInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblAucuneInfo.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAucuneInfo.ForeColor = System.Drawing.Color.Purple;
            this.lblAucuneInfo.Location = new System.Drawing.Point(56, 104);
            this.lblAucuneInfo.Name = "lblAucuneInfo";
            this.lblAucuneInfo.Size = new System.Drawing.Size(475, 190);
            this.lblAucuneInfo.TabIndex = 0;
            this.lblAucuneInfo.Text = "Aucune info.";
            this.lblAucuneInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmDetailPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Formulaire_principal.Properties.Resources.fond_mission;
            this.ClientSize = new System.Drawing.Size(590, 333);
            this.Controls.Add(this.lblAucuneInfo);
            this.Controls.Add(this.flpPourcentageEspeces);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDetailPlanete";
            this.Load += new System.EventHandler(this.FrmDetailPlanete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPourcentageEspeces;
        private System.Windows.Forms.Label lblAucuneInfo;
    }
}