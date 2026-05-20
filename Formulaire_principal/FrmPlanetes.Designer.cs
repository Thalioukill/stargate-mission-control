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
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.btnReinitialiserEspeces = new System.Windows.Forms.Button();
            this.btnReinitialiserDataBaz = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.flp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMaxMission = new System.Windows.Forms.TextBox();
            this.txtMinMission = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rdbSans = new System.Windows.Forms.RadioButton();
            this.rdbAvec = new System.Windows.Forms.RadioButton();
            this.txtMaxGrav = new System.Windows.Forms.TextBox();
            this.txtMinGrav = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp1
            // 
            this.flp1.AutoScroll = true;
            this.flp1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flp1.Location = new System.Drawing.Point(394, 0);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(289, 566);
            this.flp1.TabIndex = 0;
            // 
            // grpFiltre
            // 
            this.grpFiltre.Controls.Add(this.btnReinitialiserEspeces);
            this.grpFiltre.Controls.Add(this.btnReinitialiserDataBaz);
            this.grpFiltre.Controls.Add(this.btnReinitialiser);
            this.grpFiltre.Controls.Add(this.btnRechercher);
            this.grpFiltre.Controls.Add(this.flp2);
            this.grpFiltre.Controls.Add(this.txtMaxMission);
            this.grpFiltre.Controls.Add(this.txtMinMission);
            this.grpFiltre.Controls.Add(this.label11);
            this.grpFiltre.Controls.Add(this.label12);
            this.grpFiltre.Controls.Add(this.rdbSans);
            this.grpFiltre.Controls.Add(this.rdbAvec);
            this.grpFiltre.Controls.Add(this.txtMaxGrav);
            this.grpFiltre.Controls.Add(this.txtMinGrav);
            this.grpFiltre.Controls.Add(this.label9);
            this.grpFiltre.Controls.Add(this.label10);
            this.grpFiltre.Controls.Add(this.txtMaxTemp);
            this.grpFiltre.Controls.Add(this.txtMinTemp);
            this.grpFiltre.Controls.Add(this.label8);
            this.grpFiltre.Controls.Add(this.label2);
            this.grpFiltre.Controls.Add(this.txtNom);
            this.grpFiltre.Controls.Add(this.label7);
            this.grpFiltre.Controls.Add(this.label6);
            this.grpFiltre.Controls.Add(this.label5);
            this.grpFiltre.Controls.Add(this.label4);
            this.grpFiltre.Controls.Add(this.label3);
            this.grpFiltre.Controls.Add(this.label1);
            this.grpFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpFiltre.Location = new System.Drawing.Point(12, 12);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Size = new System.Drawing.Size(370, 542);
            this.grpFiltre.TabIndex = 1;
            this.grpFiltre.TabStop = false;
            this.grpFiltre.Text = "Filtres";
            // 
            // btnReinitialiserEspeces
            // 
            this.btnReinitialiserEspeces.Location = new System.Drawing.Point(205, 370);
            this.btnReinitialiserEspeces.Name = "btnReinitialiserEspeces";
            this.btnReinitialiserEspeces.Size = new System.Drawing.Size(159, 32);
            this.btnReinitialiserEspeces.TabIndex = 26;
            this.btnReinitialiserEspeces.Text = "Réinitialiser Especes";
            this.btnReinitialiserEspeces.UseVisualStyleBackColor = true;
            this.btnReinitialiserEspeces.Click += new System.EventHandler(this.btnReinitialiserEspeces_Click);
            // 
            // btnReinitialiserDataBaz
            // 
            this.btnReinitialiserDataBaz.Location = new System.Drawing.Point(217, 215);
            this.btnReinitialiserDataBaz.Name = "btnReinitialiserDataBaz";
            this.btnReinitialiserDataBaz.Size = new System.Drawing.Size(147, 32);
            this.btnReinitialiserDataBaz.TabIndex = 25;
            this.btnReinitialiserDataBaz.Text = "Réinitialiser DataBaz";
            this.btnReinitialiserDataBaz.UseVisualStyleBackColor = true;
            this.btnReinitialiserDataBaz.Click += new System.EventHandler(this.btnReinitialiserDataBaz_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(227, 499);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(127, 33);
            this.btnReinitialiser.TabIndex = 24;
            this.btnReinitialiser.Text = "Tout réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(10, 499);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(106, 33);
            this.btnRechercher.TabIndex = 23;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // flp2
            // 
            this.flp2.AutoScroll = true;
            this.flp2.Location = new System.Drawing.Point(82, 264);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(282, 100);
            this.flp2.TabIndex = 22;
            // 
            // txtMaxMission
            // 
            this.txtMaxMission.Location = new System.Drawing.Point(254, 451);
            this.txtMaxMission.Name = "txtMaxMission";
            this.txtMaxMission.Size = new System.Drawing.Size(100, 23);
            this.txtMaxMission.TabIndex = 21;
            this.txtMaxMission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxMission_KeyDown);
            // 
            // txtMinMission
            // 
            this.txtMinMission.Location = new System.Drawing.Point(254, 419);
            this.txtMinMission.Name = "txtMinMission";
            this.txtMinMission.Size = new System.Drawing.Size(100, 23);
            this.txtMinMission.TabIndex = 20;
            this.txtMinMission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinMission_KeyDown);
            this.txtMinMission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinMission_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Max";
            // 
            // rdbSans
            // 
            this.rdbSans.AutoSize = true;
            this.rdbSans.Location = new System.Drawing.Point(147, 221);
            this.rdbSans.Name = "rdbSans";
            this.rdbSans.Size = new System.Drawing.Size(58, 21);
            this.rdbSans.TabIndex = 17;
            this.rdbSans.TabStop = true;
            this.rdbSans.Text = "Sans";
            this.rdbSans.UseVisualStyleBackColor = true;
            // 
            // rdbAvec
            // 
            this.rdbAvec.AutoSize = true;
            this.rdbAvec.Location = new System.Drawing.Point(84, 221);
            this.rdbAvec.Name = "rdbAvec";
            this.rdbAvec.Size = new System.Drawing.Size(57, 21);
            this.rdbAvec.TabIndex = 16;
            this.rdbAvec.TabStop = true;
            this.rdbAvec.Text = "Avec";
            this.rdbAvec.UseVisualStyleBackColor = true;
            // 
            // txtMaxGrav
            // 
            this.txtMaxGrav.Location = new System.Drawing.Point(106, 178);
            this.txtMaxGrav.Name = "txtMaxGrav";
            this.txtMaxGrav.Size = new System.Drawing.Size(100, 23);
            this.txtMaxGrav.TabIndex = 15;
            this.txtMaxGrav.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxGrav_KeyDown);
            this.txtMaxGrav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxGrav_KeyPress);
            // 
            // txtMinGrav
            // 
            this.txtMinGrav.Location = new System.Drawing.Point(106, 146);
            this.txtMinGrav.Name = "txtMinGrav";
            this.txtMinGrav.Size = new System.Drawing.Size(100, 23);
            this.txtMinGrav.TabIndex = 14;
            this.txtMinGrav.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinGrav_KeyDown);
            this.txtMinGrav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinGrav_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Max";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(142, 101);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(100, 23);
            this.txtMaxTemp.TabIndex = 11;
            this.txtMaxTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaxTemp_KeyDown);
            this.txtMaxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxTemp_KeyPress);
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(142, 69);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(100, 23);
            this.txtMinTemp.TabIndex = 10;
            this.txtMinTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMinTemp_KeyDown);
            this.txtMinTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinTemp_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(84, 27);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(157, 23);
            this.txtNom.TabIndex = 7;
            this.txtNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNom_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Especes :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gravité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "DataBaz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperature :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de missions effectués :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom (like) :";
            // 
            // FrmPlanetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 665);
            this.Controls.Add(this.grpFiltre);
            this.Controls.Add(this.flp1);
            this.Name = "FrmPlanetes";
            this.Text = "FrmPlanetes";
            this.Load += new System.EventHandler(this.FrmPlanetes_Load);
            this.grpFiltre.ResumeLayout(false);
            this.grpFiltre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.GroupBox grpFiltre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxGrav;
        private System.Windows.Forms.TextBox txtMinGrav;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbSans;
        private System.Windows.Forms.RadioButton rdbAvec;
        private System.Windows.Forms.TextBox txtMaxMission;
        private System.Windows.Forms.TextBox txtMinMission;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flp2;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnReinitialiserDataBaz;
        private System.Windows.Forms.Button btnReinitialiserEspeces;
    }
}