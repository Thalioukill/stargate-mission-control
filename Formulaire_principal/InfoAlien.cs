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
                    couleurCadre = Color.Red;
                    lblCouleurAlliees.ForeColor = Color.Red;
                    break;
                case "Vert":
                    couleurCadre = Color.Green;
                    lblCouleurAlliees.ForeColor = Color.Green;
                    break;
                case "Bleu":
                    couleurCadre = Color.Blue;
                    lblCouleurAlliees.ForeColor = Color.Blue;
                    break;
                case "Orange":
                    couleurCadre = Color.Orange;
                    lblCouleurAlliees.ForeColor = Color.Orange;
                    break;
                case "Gris":
                    couleurCadre = Color.Gray;
                    lblCouleurAlliees.ForeColor = Color.Gray;
                    break;
                case "Marron":
                    couleurCadre = Color.Brown;
                    lblCouleurAlliees.ForeColor = Color.Brown;
                    break;
                case "Violet":
                    couleurCadre = Color.Purple;
                    lblCouleurAlliees.ForeColor = Color.Purple;
                    break;
                case "Rose":
                    couleurCadre = Color.Pink;
                    lblCouleurAlliees.ForeColor = Color.Pink;
                    break;
                default:
                    couleurCadre = Color.Black;
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
