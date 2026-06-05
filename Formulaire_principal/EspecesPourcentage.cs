using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Formulaire_principal
{
    public partial class EspecesPourcentage : UserControl
    {
        public EspecesPourcentage()
        {
            InitializeComponent();
        }

        private void EspecesPourcentage_Load(object sender, EventArgs e)
        {

        }

        public EspecesPourcentage(string nomEspece, string pourcentage, string couleur)
        {
            InitializeComponent();
            // ===== Nom de l'espèce =====
            lblNomEspece.Text = nomEspece;
            lblNomEspece.ForeColor = ConvertirNomCouleur(couleur);

            // ===== Pourcentage affiché =====
            lblPourcentage.Text = pourcentage + " de présence";

            // ===== Image de l'espèce =====
            string path = "../../Images/Aliens/" + nomEspece + ".png";
            if (System.IO.File.Exists(path))
            {
                picEspece.Image = Image.FromFile(path);
                picEspece.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                // Image par défaut si introuvable
                picEspece.BackColor = Color.FromArgb(40, 40, 40);
            }

            // ===== Génération de la jauge =====
            GenererJauge(pourcentage, ConvertirNomCouleur(couleur));
        }

        private void GenererJauge(string pourcentageStr, Color couleur)
        {
            // Parsing du pourcentage ("30%" → 30)
            int.TryParse(pourcentageStr.Replace("%", "").Trim(), out int valeur);

            chartJauge.Series.Clear();
            chartJauge.Titles.Clear();
            chartJauge.ChartAreas.Clear();
            chartJauge.Legends.Clear();

            // ===== Zone du graphique =====
            ChartArea area = new ChartArea();

            // On cache les axes pour un rendu jauge propre
            area.AxisX.Enabled = AxisEnabled.False;
            area.AxisY.Enabled = AxisEnabled.False;
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 100;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.BackColor = Color.Transparent;
            area.BorderColor = Color.Transparent;
            chartJauge.ChartAreas.Add(area);
            chartJauge.BackColor = Color.Transparent;

            // ===== Série "remplie" — la part du pourcentage =====
            Series sRempli = new Series("Présence");
            sRempli.ChartType = SeriesChartType.Bar;
            sRempli.Points.AddXY("", valeur);
            sRempli.Points[0].Color = couleur;
            sRempli.IsValueShownAsLabel = true;
            sRempli.Points[0].Label = valeur + "%";
            sRempli.Font = new Font("Kristen ITC", 9, FontStyle.Bold);
            sRempli["DrawingStyle"] = "Cylinder";
            chartJauge.Series.Add(sRempli);

            // ===== Série "vide" — le reste jusqu'à 100% =====
            Series sVide = new Series("Reste");
            sVide.ChartType = SeriesChartType.Bar;
            sVide.Points.AddXY("", 100 - valeur);
            sVide.Points[0].Color = Color.FromArgb(60, 60, 60);
            sVide.IsValueShownAsLabel = false;
            sVide["DrawingStyle"] = "Cylinder";
            chartJauge.Series.Add(sVide);
        }

        private Color ConvertirNomCouleur(string couleurFr)
        {
            if (string.IsNullOrEmpty(couleurFr)) return Color.DodgerBlue;

            switch (couleurFr.ToLower())
            {
                case "gris": return Color.Gray;
                case "pourpre": return Color.MediumPurple;
                case "orange": return Color.Orange;
                case "rose": return Color.HotPink;
                case "violet": return Color.BlueViolet;
                case "marron": return Color.SaddleBrown;
                case "vert": return Color.LimeGreen;
                case "bleu": return Color.DodgerBlue;
                default: return Color.DodgerBlue;
            }
        }
    }
}
