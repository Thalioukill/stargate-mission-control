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
            this.lblPourcentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPourcentage
            // 
            this.lblPourcentage.AutoSize = true;
            this.lblPourcentage.Location = new System.Drawing.Point(215, 184);
            this.lblPourcentage.Name = "lblPourcentage";
            this.lblPourcentage.Size = new System.Drawing.Size(41, 15);
            this.lblPourcentage.TabIndex = 0;
            this.lblPourcentage.Text = "label1";
            // 
            // FrmDetailPlanete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPourcentage);
            this.Name = "FrmDetailPlanete";
            this.Text = "FrmDetailPlanete";
            this.Load += new System.EventHandler(this.FrmDetailPlanete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPourcentage;
    }
}