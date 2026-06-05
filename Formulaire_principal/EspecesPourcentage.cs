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
        private Color couleurCadre = Color.Gray;

        public EspecesPourcentage()
        {
            InitializeComponent();
        }

        private void EspecesPourcentage_Load(object sender, EventArgs e)
        {

        }

        private void EspecesPourcentage_Paint(object sender, PaintEventArgs e)
        {
            // Dessin du cadre permanent
            // épaisseur de74 pour que ce soit bien visible sur le fond 
            using (Pen p = new Pen(couleurCadre, 7))
            {
                e.Graphics.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        public EspecesPourcentage(string nom, string nomEspece, string pourcentage, string couleur)
        {
            InitializeComponent();

            // On abonne l'événement Paint comme dans UserControl_Missions
            this.Paint += new PaintEventHandler(EspecesPourcentage_Paint);

            // Ensuite on stocke la couleur
            this.couleurCadre = ConvertirNomCouleur(couleur);

            // nom de l'espèce
            lblNomEspece.Text += nomEspece;
            lblNomEspece.ForeColor = ConvertirNomCouleur(couleur);

            // pourcentage
            lblPourcentage.Text = pourcentage + " de la population de cette espèce\nest présente sur la planète "+nom;

            // image de l'espèce
            string path = "../../Images/Aliens/" + nomEspece + ".png";
            if (System.IO.File.Exists(path))
            {
                picEspece.Image = Image.FromFile(path);
            }
            else
            {
                // Image par défaut si l'espèce est inconnue ou introuvable
                string pathInconnu = "../../Images/Aliens/inconnue.png";
                if (System.IO.File.Exists(pathInconnu))
                {
                    picEspece.Image = Image.FromFile(pathInconnu);
                    picEspece.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    // Dernier recours si même inconnue.png est absent
                    picEspece.BackColor = Color.FromArgb(40, 40, 40);
                }
            }

                // on génère la jauge
                GenererJauge(pourcentage, ConvertirNomCouleur(couleur));
        }

        private void GenererJauge(string pourcentageStr, Color couleur)
        {
            // Conversion de la string 30% vers 30
            int.TryParse(pourcentageStr.Replace("%", "").Trim(), out int valeur);

            // On vide les Series/Cahrts et Legends tout pour éviter les doublons si la méthode est appelée plusieurs fois
            chartJauge.Series.Clear();
            chartJauge.Titles.Clear();
            chartJauge.ChartAreas.Clear();
            chartJauge.Legends.Clear();

            // Zone du graphique
            ChartArea area = new ChartArea();

            // On cache les axes X et Y car on veut juste une barre sans graduation
            area.AxisX.Enabled = AxisEnabled.False;
            area.AxisY.Enabled = AxisEnabled.False;

            // L'axe Y va de 0 à 100 pour représenter les pourcentages
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 100;

            // On supprime les lignes de grille pour un rendu plus propre
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;

            // Fond transparent pour s'intégrer au design du UserControl
            area.BackColor = Color.Transparent;
            area.BorderColor = Color.Transparent;

            // Réduction des marges pour que la barre occupe tout l'espace disponible
            area.InnerPlotPosition.Auto = false;
            area.InnerPlotPosition.X = 0;
            area.InnerPlotPosition.Y = 5;
            area.InnerPlotPosition.Width = 100;
            area.InnerPlotPosition.Height = 90;

            chartJauge.ChartAreas.Add(area);
            chartJauge.BackColor = Color.Transparent;

            //La série remplie = % de présence
            Series sRempli = new Series("Présence");

            // StackedBar100 : les 2 séries partagent la MÊME barre horizontale et se répartissent sur 100% de sa longueur
            sRempli.ChartType = SeriesChartType.StackedBar100;
            sRempli.Points.AddXY("", valeur);

            // elle prend la couleur de l'espèce
            sRempli.Points[0].Color = couleur;

            // On affiche le pourcentage sur la barre directement
            sRempli.Points[0].Label = valeur + "%";
            sRempli.IsValueShownAsLabel = true;
            sRempli.Font = new Font("Kristen ITC", 14, FontStyle.Bold);

            // épaisseur de la barre (0 à 1, 0.9 = très épais)
            sRempli["PointWidth"] = "1";

            chartJauge.Series.Add(sRempli);

            // série vide = part non occupée jusqu'à 100%
            Series sVide = new Series("Reste");
            sVide.ChartType = SeriesChartType.StackedBar100;
            sVide.Points.AddXY("", 100 - valeur);

            // Gris foncé pour la partie vide
            sVide.Points[0].Color = Color.FromArgb(145, 145, 145);
            sVide.IsValueShownAsLabel = false;

            // Même pointwidth obligatoire pour les 2 séries sinon elles ont des épaisseurs différentes
            sVide["PointWidth"] = "1";

            chartJauge.Series.Add(sVide);
        }

        private Color ConvertirNomCouleur(string couleurFr)
        {
            if (string.IsNullOrEmpty(couleurFr)) return Color.DodgerBlue;

            switch (couleurFr.ToLower())
            {
                case "gris": return Color.FromArgb(124, 126, 132);
                case "pourpre": return Color.FromArgb(162, 94, 214);
                case "orange": return Color.FromArgb(214, 128, 74);
                case "rose": return Color.FromArgb(214, 101, 195);
                case "violet": return Color.FromArgb(99, 48, 166);
                case "marron": return Color.FromArgb(114, 75, 55);
                case "vert": return Color.FromArgb(98, 182, 74);
                case "bleu": return Color.FromArgb(74, 146, 182);
                default: return Color.FromArgb(182, 74, 74);
            }
        }
    }
}
