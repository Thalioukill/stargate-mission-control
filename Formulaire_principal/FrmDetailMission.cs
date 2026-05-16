using Formulaire_principal;
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
            AfficherObjectifs();

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
            try
            {
                // Récupération des infos de la mission dans le DataSet
                /*
                string filtre = $"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}";
                DataRow rMission = MesDatas.DsGlobal.Tables["Composer"].Select(filtre);
                */
                // la méthode Find ne fonctionne que si on a mis en place les clés primaires dans le DataSet
                DataRow rMission = ds.Tables["Mission"].Rows.Find(new object[] { idPlanete, idNumero });

                if (rMission != null)
                {
                    this.lblNomMission.Text += idPlanete + idNumero;
                    this.lblDateDepart.Text += rMission["dateDepart"].ToString();
                    this.lblDateRetour.Text += rMission["dateRetour"].ToString();
                    this.rtbFeuilleDeRoute.Text = rMission["feuilleDeRoute"].ToString();
                    this.picMission.Image = Image.FromFile("../../Images/Missions/" + idPlanete + ".jpg");

                    // Calcul du budget (Budget initial - Somme des dépenses) 
                    double budgetInitial = Convert.ToDouble(rMission["budget"]);

                    // On filtre les dépenses de cette mission dans la table locale
                    DataRow[] depenses = ds.Tables["Depense"].Select($"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}");
                    double totalDepenses = 0;

                    foreach (DataRow d in depenses)
                    {
                        totalDepenses += Convert.ToDouble(d["montant"]);
                    }

                    this.lblBudget.Text += $"{budgetInitial}€";
                    this.lblSoldeApresDepenses.Text += budgetInitial - totalDepenses+ "€";
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void AfficherEquipage()
        {
            flpEquipage.Controls.Clear();

            //On filtre les membres de CETTE mission dans la table de jointure "Composer"
            string filtre = $"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}";
            DataRow[] lignesEquipage = ds.Tables["Composer"].Select(filtre);

            foreach (DataRow ligne in lignesEquipage)
            {
                string matricule = ligne["matriculeMembre"].ToString();
                string grade_specialite = "Inconnu";
                string image = "";
                string nomComplet = "";

                // RÉCUPÉRATION DIRECTE SELON LE PRÉFIXE
                // On regarde le premier caractère (indice 0)

                char prefixe = matricule[0];

                if (prefixe == 'M') // C'est un Militaire
                {
                    DataRow[] res = ds.Tables["Militaire"].Select($"matriculeMembre = '{matricule}'");
                    if (res.Length > 0)
                    {
                        grade_specialite = "Grade : " + res[0]["grade"].ToString();
                        image = "Militaire";
                    }
                }
                else if (prefixe == 'C') // C'est un Civil
                {
                    DataRow[] res = ds.Tables["Civil"].Select($"matriculeMembre = '{matricule}'");
                    if (res.Length > 0)
                    {
                        grade_specialite = "Spécialité : " + res[0]["Specialite"].ToString();
                        image = "Civil";
                    }
                }

                // Récupération du reste (Nom, Prénom, Photo) dans la table Membre
                DataRow[] tabInfosBase = ds.Tables["Membre"].Select($"matricule = '{matricule}'");

                if (tabInfosBase.Length > 0)
                {
                    nomComplet = tabInfosBase[0]["prenom"] + " " + tabInfosBase[0]["nom"];
                }
                // On vérifie si c'est le chef 
                bool estChef = (matricule == this.idChefMission);

                // Instanciation de l'UC avec les bonnes variables
                UserControl_MembresMission uc = new UserControl_MembresMission(nomComplet, grade_specialite, image, estChef);
                flpEquipage.Controls.Add(uc);
            }
        }

        private void AfficherObjectifs()
        {
            // On vide d'abord le panel pour éviter les doublons si on rafraîchit l'affichage
            flpObjectifCaptures.Controls.Clear();

            string filtre = $"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}";
            DataRow[] lignesEspeceEnnemie = ds.Tables["Capturer"].Select(filtre);

            foreach (DataRow ligne in lignesEspeceEnnemie)
            {
                string idEspeceEnnemi = ligne["idEspeceEnnemi"].ToString();
                string captures = ligne["nombre"].ToString();

                // On cherche le nom de l'espèce dans la table Espece
                DataRow[] tabInfosEnnemi = ds.Tables["Espece"].Select($"id = '{idEspeceEnnemi}'");

                if (tabInfosEnnemi.Length > 0)
                {
                    //Création de l'instance du Label
                    Label lbl = new Label();

                    // on récupère le nom de la couleur pour ensuite afficher le label en couleur
                    string nomCouleur = tabInfosEnnemi[0]["couleur"].ToString(); // Ex: "Gris"

                    lbl.Text = tabInfosEnnemi[0]["nom"].ToString() + " --> " + captures + " prise(s)";


                    lbl.AutoSize = true; // Pour que le label s'adapte à la longueur du texte
                    lbl.Margin = new Padding(5); // Pour aérer l'affichage dans le panel
                    lbl.Font = new Font(lbl.Font, FontStyle.Bold);

                    // attribution de la couleur grâce à une méthode de conversion
                    lbl.ForeColor = ConvertirNomCouleur(nomCouleur);

                    //AJOUT AU PANEL
                    flpObjectifCaptures.Controls.Add(lbl);

                }
            }

        }

        // Méthode pour mapper les couleurs du projet Stargate
        private Color ConvertirNomCouleur(string couleurFr)
        {
            // On utilise un switch pour faire correspondre le texte DB et la couleur C#
            switch (couleurFr.ToLower())
            {
                case "gris": return Color.Gray;
                case "pourpre": return Color.Purple;
                case "orange": return Color.Orange;
                case "rose": return Color.Pink;
                case "violet": return Color.Violet;
                case "marron": return Color.SaddleBrown;
                case "vert": return Color.Green;
                case "bleu": return Color.Blue;
                default: return Color.Black; // Couleur par défaut si non trouvé
            }
        }

        private void FrmDetailMission_Load(object sender, EventArgs e)
        {

        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            FrmJournalDeBord fjdb = new FrmJournalDeBord(this.idPlanete, this.idNumero);
            DialogResult dr = fjdb.ShowDialog();
        }
    }
}
