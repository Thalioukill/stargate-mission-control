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
            lblNom.Text = "Nom : " + nom;
            lblTemperature.Text = "Température : " + temperature;
            lblGravite.Text = "Gravité : " + gravite;
            if(dataBazON == "1")
            {
                dataBazON = "Présent";
            }
            else
            {
                dataBazON = "Non présent";
            }
            lblDataBaz.Text = "DataBAZ : " + dataBazON;
            lblEspeces.Text = "Espèces : " + especes;
            lblPourcentage.Text = "Taux d'espèces : " + pourcentages;
            lblMission.Text = "Nombres de missions effectuées : " + missions;
            if (nom != string.Empty)
            {
                picPlanete.Image = Image.FromFile("../../Images/Missions/" + nom + ".jpg");
                picPlanete.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void InfoPlanete_Load(object sender, EventArgs e)
        {

        }
    }
}
