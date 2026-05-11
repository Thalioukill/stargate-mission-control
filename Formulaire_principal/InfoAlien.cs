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
            if(nomalien != string.Empty) 
            {
                picAlliees.Image = Image.FromFile("../../Images/Aliens/noomahS.png");
            }
        }

        private void InfoAlien_Load(object sender, EventArgs e)
        {
        }
    }
}
