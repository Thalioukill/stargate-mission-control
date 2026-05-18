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
            this.btnOeil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.grpAuthentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAuthentification
            // 
            this.grpAuthentification.Controls.Add(this.btnOeil);
            this.grpAuthentification.Controls.Add(this.label2);
            this.grpAuthentification.Controls.Add(this.btnValider);
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
            // btnOeil
            // 
            this.btnOeil.Location = new System.Drawing.Point(761, 206);
            this.btnOeil.Name = "btnOeil";
            this.btnOeil.Size = new System.Drawing.Size(81, 61);
            this.btnOeil.TabIndex = 6;
            this.btnOeil.UseVisualStyleBackColor = true;
            this.btnOeil.Click += new System.EventHandler(this.btnOeil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(381, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Accès restreint";
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Location = new System.Drawing.Point(563, 350);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(175, 55);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(293, 221);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(445, 31);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMdp_KeyPress);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(293, 155);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(445, 31);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
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
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(67, 157);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(65, 25);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Login";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 740);
            this.Controls.Add(this.grpAuthentification);
            this.Name = "FrmLogin";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
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
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOeil;
    }
}