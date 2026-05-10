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
        private int idNumero;

        private string idMission;
        public FrmDetailMission()
        {
            InitializeComponent();
        }
        public FrmDetailMission(string laPlanete, string leNumero)
        {
            InitializeComponent();
            this.idPlanete = laPlanete;
            this.idNumero = leNumero;

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
        }

        private void FrmDetailMission_Load(object sender, EventArgs e)
        {

        }
    }
}
