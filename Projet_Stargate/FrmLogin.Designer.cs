namespace Projet_Stargate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.grpAuthentification = new System.Windows.Forms.GroupBox();
            this.btnOeil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.ttValid = new System.Windows.Forms.ToolTip(this.components);
            this.ttVoirMdp = new System.Windows.Forms.ToolTip(this.components);
            this.grpAuthentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAuthentification
            // 
            this.grpAuthentification.BackColor = System.Drawing.Color.Transparent;
            this.grpAuthentification.Controls.Add(this.btnOeil);
            this.grpAuthentification.Controls.Add(this.label2);
            this.grpAuthentification.Controls.Add(this.btnValider);
            this.grpAuthentification.Controls.Add(this.txtMdp);
            this.grpAuthentification.Controls.Add(this.txtLogin);
            this.grpAuthentification.Controls.Add(this.label1);
            this.grpAuthentification.Controls.Add(this.lblLog);
            this.grpAuthentification.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAuthentification.Location = new System.Drawing.Point(49, 47);
            this.grpAuthentification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAuthentification.Name = "grpAuthentification";
            this.grpAuthentification.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAuthentification.Size = new System.Drawing.Size(621, 380);
            this.grpAuthentification.TabIndex = 0;
            this.grpAuthentification.TabStop = false;
            this.grpAuthentification.Text = "Authentification";
            // 
            // btnOeil
            // 
            this.btnOeil.BackgroundImage = global::Projet_Stargate.Properties.Resources.oeil1;
            this.btnOeil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOeil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOeil.Location = new System.Drawing.Point(549, 167);
            this.btnOeil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOeil.Name = "btnOeil";
            this.btnOeil.Size = new System.Drawing.Size(54, 39);
            this.btnOeil.TabIndex = 6;
            this.ttVoirMdp.SetToolTip(this.btnOeil, "Voir le mot de passe");
            this.btnOeil.UseVisualStyleBackColor = true;
            this.btnOeil.Click += new System.EventHandler(this.btnOeil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(256, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Accès restreint";
            // 
            // btnValider
            // 
            this.btnValider.BackgroundImage = global::Projet_Stargate.Properties.Resources.valider;
            this.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Location = new System.Drawing.Point(457, 252);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(70, 56);
            this.btnValider.TabIndex = 4;
            this.ttValid.SetToolTip(this.btnValider, "Valider");
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(195, 170);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(333, 35);
            this.txtMdp.TabIndex = 3;
            this.txtMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMdp_KeyPress);
            this.txtMdp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMdp_KeyUp);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(195, 99);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(333, 35);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyDown);
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mot de passe";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(11, 104);
            this.lblLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(68, 28);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Login";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Stargate.Properties.Resources.fond_mission;
            this.ClientSize = new System.Drawing.Size(721, 474);
            this.Controls.Add(this.grpAuthentification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolTip ttValid;
        private System.Windows.Forms.ToolTip ttVoirMdp;
    }
}