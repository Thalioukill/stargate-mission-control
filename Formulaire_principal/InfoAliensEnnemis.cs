using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire_principal
{
    public partial class InfoAliensEnnemis : UserControl
    {
        public InfoAliensEnnemis()
        {
            InitializeComponent();
        }

        public InfoAliensEnnemis(string nom, string bienveillance, string couleur, string panete, string instrument, string nomalien)
        {
            InitializeComponent();
            lblNomEnnemis.Text = nom;
            lblAgressivite.Text = bienveillance;
            lblCouleurEnnemis.Text = couleur;
            lblPlaneteEnnemis.Text = panete;
            lblTypeArme.Text = instrument;
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
                    MessageBox.Show("Fichier introuvable à : " + System.IO.Path.GetFullPath(path));
                }
            }
        }

        private void InfoAliensEnnemis_Load(object sender, EventArgs e)
        {

        }
    }
}
