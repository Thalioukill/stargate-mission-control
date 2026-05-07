namespace Formulaire_principal
{
    partial class FrmLogin
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
            this.grpAuthentification = new System.Windows.Forms.GroupBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpAuthentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAuthentification
            // 
            this.grpAuthentification.Controls.Add(this.button1);
            this.grpAuthentification.Controls.Add(this.txtMdp);
            this.grpAuthentification.Controls.Add(this.txtLogin);
            this.grpAuthentification.Controls.Add(this.label1);
            this.grpAuthentification.Controls.Add(this.lblLog);
            this.grpAuthentification.Location = new System.Drawing.Point(73, 73);
            this.grpAuthentification.Name = "grpAuthentification";
            this.grpAuthentification.Size = new System.Drawing.Size(931, 593);
            this.grpAuthentification.TabIndex = 0;
            this.grpAuthentification.TabStop = false;
            this.grpAuthentification.Text = "Authentification";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(67, 157);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(65, 25);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mot de passe";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(293, 155);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(445, 31);
            this.txtLogin.TabIndex = 2;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(293, 221);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(445, 31);
            this.txtMdp.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 740);
            this.Controls.Add(this.grpAuthentification);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.grpAuthentification.ResumeLayout(false);
            this.grpAuthentification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAuthentification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button button1;
    }
}