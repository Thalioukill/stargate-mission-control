using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Stargate
{
    //[ToolboxBitmap(typeof(afficherMission), "UserControl_Missions.jpg")]
    
    public delegate void afficherMission(object sender, EventArgs e);

    public partial class UserControl_Missions : UserControl
    {
        // Variables pour stocker la clé primaire double de Mission
        private string planete;
        private string numero;
        public string idChef;
        private DateTime dateDepart;
        private DateTime dateRetour;
        private Color couleurCadre = Color.Gray; // cuoleur par défaut


        // instance du délgate accessible depuis le formulaire parent
        public afficherMission details;

        public UserControl_Missions()
        {
            InitializeComponent();
        }

        public UserControl_Missions(string nomPlanete, string numeroMission, string date, string nbJours, string chef, string matriculeChef, string budget, string nomImage)
        {
            InitializeComponent();
            this.lblNomMission.Text += nomPlanete+numeroMission;
            this.lblDate.Text += date;
            this.lblChefMission.Text += chef;
            this.lblBudget.Text += budget + " $";
            this.lblNbJours.Text += nbJours;

            if (nomImage != string.Empty)
            {
                picMission.Image = Image.FromFile("../../Images/Missions/"+nomImage);
            }

            this.Paint += new PaintEventHandler(UserControl_Paint);

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

        public DateTime DateDepart 
        { 
            get { 
                return dateDepart; 
            }
            set { 
                dateDepart = value; // On stocke la valeur reçue dans la variable privée
                mettreAJourStatut(); // On lance la logique de couleur et de statut
                } 
        }

        public DateTime DateRetour
        {
            get
            {
                return dateRetour;
            }
            set
            {
                dateRetour = value;
                mettreAJourStatut();
            }
        }

        private void UserControl_Paint(object sender, PaintEventArgs e)
        {
            // Dessin du cadre permanent
            // épaisseur de74 pour que ce soit bien visible sur le fond 
            using (Pen p = new Pen(couleurCadre, 7))
            {
                e.Graphics.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
            }
        }


        private void mettreAJourStatut()
        {
            // DateTime.Now renvoie aussi des heures et minutes et ca pose des problèmes pour les missions en cours/passées...
            DateTime aujourdhui = DateTime.Today;

            if (dateDepart > aujourdhui)
            {
                lblStatusMission.Text = "Statut : À VENIR";
                couleurCadre = Color.FromArgb(228, 138, 255); // 81, 225, 255
            }
            else if (aujourdhui >= dateDepart && aujourdhui <= dateRetour)
            {
                lblStatusMission.Text = "Statut : EN COURS";
                couleurCadre = Color.FromArgb(131, 164, 255);// 255, 148, 241
            }
            else
            {
                lblStatusMission.Text = "Statut : PASSÉE";
                couleurCadre = Color.FromArgb(148, 102, 255); // 113, 6, 255 // -> 148, 102, 255
            }

            // couleur au texte = couleur du label
            lblStatusMission.ForeColor = couleurCadre;

            // appel à Paint
            this.Invalidate();
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
    }
}
