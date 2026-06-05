namespace Formulaire_principal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.picEspece = new System.Windows.Forms.PictureBox();
            this.lblNomEspece = new System.Windows.Forms.Label();
            this.lblPourcentage = new System.Windows.Forms.Label();
            this.chartJaug = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.picEspece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJaug)).BeginInit();
            this.SuspendLayout();
            // 
            // picEspece
            // 
            this.picEspece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEspece.Location = new System.Drawing.Point(33, 38);
            this.picEspece.Name = "picEspece";
            this.picEspece.Size = new System.Drawing.Size(182, 155);
            this.picEspece.TabIndex = 0;
            this.picEspece.TabStop = false;
            // 
            // lblNomEspece
            // 
            this.lblNomEspece.AutoSize = true;
            this.lblNomEspece.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEspece.Location = new System.Drawing.Point(254, 38);
            this.lblNomEspece.Name = "lblNomEspece";
            this.lblNomEspece.Size = new System.Drawing.Size(65, 28);
            this.lblNomEspece.TabIndex = 1;
            this.lblNomEspece.Text = "label1";
            // 
            // lblPourcentage
            // 
            this.lblPourcentage.AutoSize = true;
            this.lblPourcentage.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPourcentage.Location = new System.Drawing.Point(254, 165);
            this.lblPourcentage.Name = "lblPourcentage";
            this.lblPourcentage.Size = new System.Drawing.Size(66, 28);
            this.lblPourcentage.TabIndex = 2;
            this.lblPourcentage.Text = "label2";
            // 
            // chartJaug
            // 
            chartArea1.Name = "ChartArea1";
            this.chartJaug.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartJaug.Legends.Add(legend1);
            this.chartJaug.Location = new System.Drawing.Point(259, 78);
            this.chartJaug.Name = "chartJaug";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartJaug.Series.Add(series1);
            this.chartJaug.Size = new System.Drawing.Size(325, 72);
            this.chartJaug.TabIndex = 3;
            this.chartJaug.Text = "chart1";
            // 
            // EspecesPourcentage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartJaug);
            this.Controls.Add(this.lblPourcentage);
            this.Controls.Add(this.lblNomEspece);
            this.Controls.Add(this.picEspece);
            this.Name = "EspecesPourcentage";
            this.Size = new System.Drawing.Size(635, 236);
            this.Load += new System.EventHandler(this.EspecesPourcentage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEspece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJaug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEspece;
        private System.Windows.Forms.Label lblNomEspece;
        private System.Windows.Forms.Label lblPourcentage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartJaug;
    }
}
