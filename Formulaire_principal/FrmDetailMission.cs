using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire_principal 
{ 
    public partial class FrmDetailMission : Form
    {
        private SQLiteConnection co = Connexion.Connec;

        //instanciation du DataSet

        private DataSet ds = MesDatas.DsGlobal;

        private string idPlanete;
        private string idNumero;
        private string image;
        private string idChefMission;

        public FrmDetailMission()
        {
            InitializeComponent();
        }
        public FrmDetailMission(string laPlanete, string leNumero, string matricule)
        {
            InitializeComponent();
            this.idPlanete = laPlanete;
            this.idNumero = leNumero;
            this.idChefMission = matricule;

            AfficherDetailsMission();
            AfficherEquipage();

            /*
            // Création d'une vue sur la table "Composer" (qui lie membres et missions)
            DataView dvEquipage = new DataView(mesDatas.dsStargate.Tables["Composer"]);

            // Application du filtre local
            dvEquipage.RowFilter = $"nomPlanete = '{laPlanete}' AND numeroMission = {leNumero}";

            //parcours de la vue filtrée pour afficher les User Controls
            foreach (DataRowView ligne in dvEquipage)
            {
                // On récupère le matricule du membre de la mission en cours dans la ligne de la vue
                string matricule = ligne["matricule"].ToString();

                // On va chercher les détails du membre (nom, grade...) dans la table Membre du DataSet
                DataRow rMembre = mesDatas.dsStargate.Tables["Membre"].Rows.Find(matricule);

                if (rMembre != null)
                {
                    string nomComplet = rMembre["prenom"] + " " + rMembre["nom"];

                    // Grade OU Spécialité 
                    string grade_specialite = rMembre["grade"].ToString();

                    if (string.IsNullOrEmpty(grade_specialite)) {
                        grade_specialite = rMembre["Specialite"].ToString();
                    }
                    // Création de l'UC avec la couleur si chef
                    UserControl_MembresMission uc = new UserControl_MembresMission(nomComplet, infoSup, rMembre["photo"].ToString(), estChef);

                    flpEquipage.Controls.Add(uc);
                }
            }
            */
        }

        private void AfficherDetailsMission()
        {
            // Récupération des infos de la mission dans le DataSet
            DataRow rMission = MesDatas.DsGlobal.Tables["Mission"].Rows.Find(new object[] { idPlanete, idNumero });

            if (rMission != null)
            {
                this.lblNomMission.Text += idPlanete + idNumero;
                this.lblDateDepart.Text = $"Du {rMission["dateDepart"]} au {rMission["dateRetour"]}";
                this.rtbFeuilleDeRoute.Text = rMission["feuilleDeRoute"].ToString();
                //this.idChefMission = rMission["matriculeChef"].ToString();

                // Calcul du budget (Budget initial - Somme des dépenses) 
                double budgetInitial = Convert.ToDouble(rMission["budget"]);

                // On filtre les dépenses de cette mission dans la table locale
                DataRow[] depenses = MesDatas.DsGlobal.Tables["Depense"].Select($"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}");
                double totalDepenses = 0;

                foreach (DataRow d in depenses) { 
                    totalDepenses += Convert.ToDouble(d["montant"]); 
                }

                this.lblBudget.Text += $"Initial : {budgetInitial}€ | Solde : {budgetInitial - totalDepenses}€";
            }
        }

        private void AfficherEquipage()
        {
            flpEquipage.Controls.Clear();

            //On filtre les membres de CETTE mission dans la table de jointure "Composer"
            string filtre = $"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}";
            DataRow[] lignesEquipage = MesDatas.DsGlobal.Tables["Composer"].Select(filtre);

            foreach (DataRow ligne in lignesEquipage)
            {
                string matricule = ligne["matriculeMembre"].ToString();

                // on récupère l'identité dans "Membre" (nécessite matricule en clé primaire)
                DataRow rMembre = MesDatas.DsGlobal.Tables["Membre"].Rows.Find(matricule);

                if (rMembre != null)
                {
                    string nomComplet = rMembre["prenom"] + " " + rMembre["nom"];
                    string grade_specialite = "";

                    // Recherche du Grade (Militaire) ou de la Spécialité (Civil)
                    DataRow rMilitaire = MesDatas.DsGlobal.Tables["Militaire"].Rows.Find(matricule);
                    if (rMilitaire != null)
                    {
                        grade_specialite = "Grade : "+rMilitaire["grade"].ToString();
                        this.image = "Militaire";
                    }
                    else
                    {
                        DataRow rCivil = MesDatas.DsGlobal.Tables["Civil"].Rows.Find(matricule);

                        if (rCivil != null) {
                            grade_specialite = "Spécialité : "+rCivil["Specialite"].ToString();
                            this.image = "Civil";
                        }
                    }

                    // on vérifie si c'est le chef pour la mise en vert
                    bool estChef = (matricule == this.idChefMission);

                    // Instanciation de l'UC
                    UserControl_MembresMission uc = new UserControl_MembresMission(nomComplet, grade_specialite, this.image, estChef);
                    flpEquipage.Controls.Add(uc);
                }
            }
        }

        private void FrmDetailMission_Load(object sender, EventArgs e)
        {

        }
    }
}
