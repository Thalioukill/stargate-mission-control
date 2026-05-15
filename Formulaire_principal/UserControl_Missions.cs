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
    //[ToolboxBitmap(typeof(afficherMission), "UserControl_Missions.jpg")]
    
    public delegate void afficherMission(object sender, EventArgs e);

    public partial class UserControl_Missions : UserControl
    {
        // Variables pour stocker la clé primaire double de Mission
        private string planete;
        private string numero;
        public string idChef;

        // instance du délgate accessible depuis le formulaire parent
        public afficherMission details;
        public afficherMission stats;

        public UserControl_Missions(string nomPlanete, string numeroMission, string date, string nbJours, string chef, string matriculeChef, string budget, string nomImage)
        {
            InitializeComponent();
            this.lblNomMission.Text += nomPlanete+numeroMission;
            this.lblDate.Text += date;
            this.lblChefMission.Text += chef;
            this.lblBudget.Text += budget;
            this.lblNbJours.Text += nbJours;

            if (nomImage != string.Empty)
            {
                picMission.Image = Image.FromFile("../../Images/Missions/"+nomImage);
            }

            // On stocke ls informations propres à la mission
            this.planete = nomPlanete;
            this.numero = numeroMission;
            this.idChef = matriculeChef;
        }
        public string Planete { 
            get { 
                return planete;
            } 
        }
        public string Numero {
            get { 
                return numero; 
            }
        }

        public string Matricule
        {
            get
            {
                return idChef;
            }
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
            if (this.details != null)
            {
                this.details(this, e); // on déclenche la fonction avec le UserControl lui-meme
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            // Si le formulaire parent a bien défini une méthode à exécuter
            if (this.stats != null)
            {
                this.stats(this, e); // on déclenche la fonction avec le UserControl lui-meme
            }
        }
    }
}
