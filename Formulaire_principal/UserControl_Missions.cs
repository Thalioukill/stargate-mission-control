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
    public delegate void afficherMission(object sender, EventArgs e);

    [ToolboxBitmap(typeof(afficherMission), "UserControl_Missions.jpg")]

    // Variables pour stocker la clé primaire double de Mission
    private string planete;
    private int numero;

    public partial class UserControl_Missions : UserControl
    {
        // instance du délgate accessible depuis le formulaire parent
        public afficherMission afficheur;

        public UserControl_Missions(string nomMission, string numeroMission, string date, string chefMission, string budget, string nomImage)
        {
            InitializeComponent();
            this.lblNomMission.Text += nomPlanete+numeroMission;
            this.lblDate.Text += date;
            this.lblChefMission.Text += chefMission;
            this.lblBudget.Text += budget;

            if (nomImage != string.Empty)
            {
                picMission.Image = Image.FromFile("../../Images/Missions/"+nomImage);
            }

            // On stocke ls informations propres à la mission
            this.planete = nomPlanete;
            this.numero = numeroMission;
        }

        public UserControl_Missions()
        {
            InitializeComponent();
        }

        private void UserControl_Missions_Load(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            // Si le formulaire parent a bien défini une méthode à exécuter
            if (this.afficheur != null)
            {
                this.afficheur(sender, e); // on "passe la main" au parent
            }
        }
    }
}
