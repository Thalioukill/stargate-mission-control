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
                else
                {
                    path = "../../Images/Aliens/link.jpg";
                    picAlliees.SizeMode = PictureBoxSizeMode.Zoom;
                    picAlliees.Image = Image.FromFile(path);
                }
            }

        }

        private void InfoAlien_Load(object sender, EventArgs e)
        {
        }
    }
}
