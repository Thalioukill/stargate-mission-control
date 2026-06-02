using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire_principal
{
    public partial class InfoEnnemis : UserControl
    {
        private Color couleurCadre = Color.Black;
        public InfoEnnemis()
        {
            InitializeComponent();
        }

        public InfoEnnemis(string nom, string agressivite, string couleur, string planete, string arme, string nomalien)
        {
            InitializeComponent();
            lblNomEnnemis.Text = "Nom : " + nom;
            lblAgressivite.Text = "Agressivité : " + agressivite;
            lblCouleurEnnemis.Text = "Couleur : " + couleur;
            lblPlaneteEnnemis.Text = "Planète d'origine : " + planete;
            lblArme.Text = "Arme : " + arme;
            if (nomalien != string.Empty)
            {
                string path = "../../Images/Aliens/" + nomalien;
                if (System.IO.File.Exists(path))
                {
                    picEnnemis.SizeMode = PictureBoxSizeMode.Zoom;
                    picEnnemis.Image = Image.FromFile(path);
                }
                else
                {
                    path = "../../Images/Aliens/link.jpg";
                    picEnnemis.SizeMode = PictureBoxSizeMode.Zoom;
                    picEnnemis.Image = Image.FromFile(path);
                }
            }
            switch (couleur) 
            {
                case "Pourpre":
                    couleurCadre = Color.Red;
                    lblCouleurEnnemis.ForeColor = Color.Red;
                    break;
                case "Vert":
                    couleurCadre = Color.Green;
                    lblCouleurEnnemis.ForeColor = Color.Green;
                    break;
                case "Bleu":
                    couleurCadre = Color.Blue;
                    lblCouleurEnnemis.ForeColor = Color.Blue;
                    break;
                case "Orange":
                    couleurCadre = Color.Orange;
                    lblCouleurEnnemis.ForeColor = Color.Orange;
                    break;
                case "Gris":
                    couleurCadre = Color.Gray;
                    lblCouleurEnnemis.ForeColor = Color.Gray;
                    break;
                case "Marron":
                    couleurCadre = Color.Brown;
                    lblCouleurEnnemis.ForeColor = Color.Brown;
                    break;
                case "Violet":
                    couleurCadre = Color.Purple;
                    lblCouleurEnnemis.ForeColor = Color.Purple;
                    break;
                case "Rose":
                    couleurCadre = Color.Pink;
                    lblCouleurEnnemis.ForeColor = Color.Pink;
                    break;
                default:
                    couleurCadre = Color.Black;
                    break;
            }
        }

        private void InfoEnnemis_Load(object sender, EventArgs e)
        {
        }

        private void InfoEnnemis_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(couleurCadre, 7))
            {
                e.Graphics.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}
