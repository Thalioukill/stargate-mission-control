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

        private string idMission;
        public FrmDetailMission()
        {
            InitializeComponent();
        }
        public FrmDetailMission(string idRecu)
        {
            InitializeComponent();
            this.idMission = idRecu;

            // Création d'une vue sur la table "Composer" (qui lie membres et missions)
            DataView dvEquipage = new DataView(mesDatas.dsStargate.Tables["Composer"]);

            // Application du filtre local
            dvEquipage.RowFilter = $"nomPlanete = '{idRecu.Substring(0, idRecu.size()-1)}' AND numeroMission = {idRecu.Substring(idRecu.size() - 1), 1}";

            // 3. Parcours de la vue filtrée pour afficher les User Controls
            foreach (DataRowView ligne in dvEquipage)
            {
                // On récupère le matricule du membre dans la ligne de la vue
                string matricule = ligne["matriculeMembre"].ToString();

                // On va chercher les détails du membre (nom, grade...) dans la table Membre du DataSet
                DataRow rMembre = mesDatas.dsStargate.Tables["Membre"].Rows.Find(matricule);

                if (rMembre != null)
                {
                    string nomComplet = rMembre["prenom"] + " " + rMembre["nom"];

                    // Logique Grade vs Spécialité (vu précédemment)
                    string infoSup = rMembre["grade"].ToString();
                    if (string.IsNullOrEmpty(infoSup)) infoSup = rMembre["Specialite"].ToString();

                    // Est-ce le chef ? (On compare avec le matriculeChef de la mission)
                    bool estChef = (matricule == this.idChefMission);

                    // Création de l'UC avec la couleur si chef
                    UserControl_Membre uc = new UserControl_Membre(nomComplet, infoSup, rMembre["photo"].ToString(), estChef);
                    flpEquipage.Controls.Add(uc);
                }
            }



        }

        private void FrmDetailMission_Load(object sender, EventArgs e)
        {

        }
    }
}
