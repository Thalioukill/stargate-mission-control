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
    public partial class InfoAlien : UserControl
    {
        private Color couleurCadre = Color.Black;

        public InfoAlien()
        {
            InitializeComponent();
        }

        public InfoAlien(string nom, string bienveillance, string couleur, string panete, string instrument, string nomalien)
        {
            InitializeComponent();
            lblNomAlliees.Text = "Nom : " + nom;
            lblBienveillance.Text = "Bienveillance : " + bienveillance;
            lblCouleurAlliees.Text = "Couleur : " + couleur;
            lblPlaneteAlliees.Text = "Planète d'origine : " + panete;
            lblInstrument.Text = "Instrument favoris : " + instrument;
            if (nomalien != string.Empty)
            {
                string path = "../../Images/Aliens/" + nomalien;
                if (System.IO.File.Exists(path))
                {
                    picAlliees.SizeMode = PictureBoxSizeMode.Zoom;
                    picAlliees.Image = Image.FromFile(path);
                }
            }

            switch (couleur)
            {
                case "Pourpre":
                    couleurCadre = Color.FromArgb(162, 94, 214);
                    lblCouleurAlliees.ForeColor = Color.FromArgb(162, 94, 214);
                    break;
                case "Vert":
                    couleurCadre = Color.FromArgb(98, 182, 74); ;
                    lblCouleurAlliees.ForeColor = Color.FromArgb(98, 182, 74); ;
                    break;
                case "Bleu":
                    couleurCadre = Color.FromArgb(74, 146, 182);
                    lblCouleurAlliees.ForeColor = Color.FromArgb(74, 146, 182);
                    break;
                case "Orange":
                    couleurCadre = Color.FromArgb(214, 128, 74);
                    lblCouleurAlliees.ForeColor = Color.FromArgb(214, 128, 74);
                    break;
                case "Gris":
                    couleurCadre = Color.FromArgb(124, 126, 132);
                    lblCouleurAlliees.ForeColor = Color.FromArgb(124, 126, 132);
                    break;
                case "Marron":
                    couleurCadre = Color.FromArgb(114, 75, 55);
                    lblCouleurAlliees.ForeColor = Color.FromArgb(114, 75, 55);
                    break;
                case "Violet":
                    couleurCadre = Color.FromArgb(99, 48, 166);
                    lblCouleurAlliees.ForeColor = Color.FromArgb(99, 48, 166);
                    break;
                case "Rose":
                    couleurCadre = Color.FromArgb(214, 101, 195);
                    lblCouleurAlliees.ForeColor = Color.FromArgb(214, 101, 195);
                    break;
                default:
                    couleurCadre = Color.FromArgb(182, 74, 74);
                    break;
            }

        }

        private void InfoAlien_Load(object sender, EventArgs e)
        {
        }

        private void InfoAlien_Paint(object sender, PaintEventArgs e)
        {
            using (Pen p = new Pen(couleurCadre, 7))
            {
                e.Graphics.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}
