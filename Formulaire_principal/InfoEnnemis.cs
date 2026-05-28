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

        }

        private void InfoEnnemis_Load(object sender, EventArgs e)
        {
        }
    }
}
