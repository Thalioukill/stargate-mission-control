namespace Projet_Stargate
{
    partial class EspecesPourcentage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.picEspece = new System.Windows.Forms.PictureBox();
            this.lblNomEspece = new System.Windows.Forms.Label();
            this.lblPourcentage = new System.Windows.Forms.Label();
            this.chartJauge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.picEspece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJauge)).BeginInit();
            this.SuspendLayout();
            // 
            // picEspece
            // 
            this.picEspece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEspece.Location = new System.Drawing.Point(18, 33);
            this.picEspece.Name = "picEspece";
            this.picEspece.Size = new System.Drawing.Size(143, 121);
            this.picEspece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEspece.TabIndex = 0;
            this.picEspece.TabStop = false;
            // 
            // lblNomEspece
            // 
            this.lblNomEspece.AutoSize = true;
            this.lblNomEspece.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEspece.Location = new System.Drawing.Point(177, 33);
            this.lblNomEspece.Name = "lblNomEspece";
            this.lblNomEspece.Size = new System.Drawing.Size(99, 28);
            this.lblNomEspece.TabIndex = 1;
            this.lblNomEspece.Text = "Espèce : ";
            // 
            // lblPourcentage
            // 
            this.lblPourcentage.AutoSize = true;
            this.lblPourcentage.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPourcentage.Location = new System.Drawing.Point(13, 175);
            this.lblPourcentage.Name = "lblPourcentage";
            this.lblPourcentage.Size = new System.Drawing.Size(66, 28);
            this.lblPourcentage.TabIndex = 2;
            this.lblPourcentage.Text = "label2";
            // 
            // chartJauge
            // 
            chartArea2.Name = "ChartArea1";
            this.chartJauge.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartJauge.Legends.Add(legend2);
            this.chartJauge.Location = new System.Drawing.Point(182, 44);
            this.chartJauge.Name = "chartJauge";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartJauge.Series.Add(series2);
            this.chartJauge.Size = new System.Drawing.Size(341, 121);
            this.chartJauge.TabIndex = 3;
            this.chartJauge.Text = "chart1";
            // 
            // EspecesPourcentage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lblNomEspece);
            this.Controls.Add(this.chartJauge);
            this.Controls.Add(this.lblPourcentage);
            this.Controls.Add(this.picEspece);
            this.Name = "EspecesPourcentage";
            this.Size = new System.Drawing.Size(526, 253);
            this.Load += new System.EventHandler(this.EspecesPourcentage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEspece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJauge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEspece;
        private System.Windows.Forms.Label lblNomEspece;
        private System.Windows.Forms.Label lblPourcentage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartJauge;
    }
}
