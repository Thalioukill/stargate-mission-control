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
    public partial class InfoAliensAlliees : UserControl
    {
        public InfoAliensAlliees()
        {
            InitializeComponent();
        }

        public InfoAliensAlliees(string nom, string bienveillance, string couleur, string panete, string instrument, string nomalien)
        {
            InitializeComponent();
            lblNomAlliees.Text = nom;
            lblBienveillance.Text = bienveillance;
            lblCouleurAlliees.Text = couleur;
            lblPlaneteAlliees.Text = panete;
            lblInstrument.Text = instrument;
            if (nomalien != string.Empty)
            {
                string path = "../../Images/Aliens/noomahS.jpg";
                if (System.IO.File.Exists(path))
                {
                    picAlliees.Image = Image.FromFile(path);
                }
                else
                {
                    MessageBox.Show("Fichier introuvable à : " + System.IO.Path.GetFullPath(path));
                }
            }

        }

        private void InfoAlien_Load(object sender, EventArgs e)
        {
        }
    }
}
