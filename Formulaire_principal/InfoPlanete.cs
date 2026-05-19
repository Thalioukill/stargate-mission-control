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
    public partial class InfoPlanete : UserControl
    {
        public InfoPlanete()
        {
            InitializeComponent();
        }
        public InfoPlanete(string nom, string temperature, string gravite, string dataBazON, string especes, string pourcentages, string missions)
        {
            InitializeComponent();
            lblNom.Text = nom;
            lblTemperature.Text = temperature;
            lblGravite.Text = gravite;
            lblDataBaz.Text = dataBazON;
            lblEspeces.Text = especes;
            lblPourcentage.Text = pourcentages;
            lblMission.Text = missions;
            picPlanete.Image = Image.FromFile("../../Images/Planetes/noomahS.png");

        }

        private void InfoPlanete_Load(object sender, EventArgs e)
        {

        }
    }
}
