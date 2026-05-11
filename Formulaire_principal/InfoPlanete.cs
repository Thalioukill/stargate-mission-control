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
        public InfoPlanete(string nom, int temperature, float gravite, int dataBazON, string especes, string pourcentages, int missions)
        {
            InitializeComponent();
            lblNom.Text = nom;
            lblTemperature.Text = temperature.ToString();
            lblGravite.Text = gravite.ToString();
            lblDataBazON.Text = dataBazON.ToString();
            lblEspeces.Text = especes;
            lblPourcentages.Text = pourcentages;
            lblMissions.Text = missions.ToString();
        }

        private void InfoPlanete_Load(object sender, EventArgs e)
        {

        }
    }
}
