namespace Formulaire_principal
{
    partial class FrmPlanetes
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
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp1
            // 
            this.flp1.AutoScroll = true;
            this.flp1.Location = new System.Drawing.Point(12, 42);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(763, 382);
            this.flp1.TabIndex = 0;
            // 
            // FrmPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flp1);
            this.Name = "FrmPlanetes";
            this.Text = "FrmPlanetes";
            this.Load += new System.EventHandler(this.FrmPlanetes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp1;
    }
}