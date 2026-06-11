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

namespace Projet_Stargate
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
            }
            switch (couleur) 
            {
                case "Pourpre":
                    couleurCadre = Color.FromArgb(162, 94, 214);
                    lblCouleurEnnemis.ForeColor = Color.FromArgb(162, 94, 214);
                    break;
                case "Vert":
                    couleurCadre = Color.FromArgb(98, 182, 74);
                    lblCouleurEnnemis.ForeColor = Color.FromArgb(98, 182, 74);
                    break;
                case "Bleu":
                    couleurCadre = Color.FromArgb(74, 146, 182);
                    lblCouleurEnnemis.ForeColor = Color.FromArgb(74, 146, 182);
                    break;
                case "Orange":
                    couleurCadre = Color.FromArgb(214, 128, 74);
                    lblCouleurEnnemis.ForeColor = Color.FromArgb(214, 128, 74);
                    break;
                case "Gris":
                    couleurCadre = Color.FromArgb(124, 126, 132);
                    lblCouleurEnnemis.ForeColor = Color.FromArgb(124, 126, 132);
                    break;
                case "Marron":
                    couleurCadre = Color.FromArgb(114, 75, 55);
                    lblCouleurEnnemis.ForeColor = Color.FromArgb(114, 75, 55);
                    break;
                case "Violet":
                    couleurCadre = Color.FromArgb(99, 48, 166);
                    lblCouleurEnnemis.ForeColor = Color.FromArgb(99, 48, 166);
                    break;
                case "Rose":
                    couleurCadre = Color.FromArgb(214, 101, 195);
                    lblCouleurEnnemis.ForeColor = Color.FromArgb(214, 101, 195);
                    break;
                default:
                    couleurCadre = Color.FromArgb(214, 101, 195);
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
