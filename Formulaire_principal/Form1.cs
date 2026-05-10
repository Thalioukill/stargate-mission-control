using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire_principal
{
    public partial class FrmAccueil : Form
    {
        private SQLiteConnection co = Connexion.Connec;

        //instanciation du DataSet

        private DataSet ds = MesDatas.DsGlobal;

        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plMissions.Visible = false;
            flpMissions.Visible = false;
            grpFiltres.Visible = false;

            /* Vérification de la connection : 
             
            String requete = $@"SELECT COUNT(*) from Mission";

            SQLiteCommand cmd = new SQLiteCommand(requete, this.co);

            int nbMission = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("il y a " + nbMission.ToString() + "clients");

            */

            // On rempli le DataSet ds avec toutes les Tables de la base Stargate.ds
            // ATTENTION POUR L'AJOUT DES MISSIONS IL FAUT BIEN RECREER LES CLE ETRANGERES ET PRIMAIRES
            string sql;

            // méthode GetSchema => pour avoir des méta-données (table qui contient la structure de la Base de données...)
            DataTable schemaTable = co.GetSchema("Tables");

            string liste = "";

            // on parcoure chaque ligne
            for (int i = 0; i < schemaTable.Rows.Count; i++)
            {
                // la troisième colonne (num 2) contient tous les noms des tables 
                string nomTable = schemaTable.Rows[i][2].ToString();
                sql = "SELECT * FROM " + nomTable;

                // le seul objet qui existe dans le monde connecté et deconnecté 
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, this.co);
                da.Fill(ds, nomTable);
                liste = liste + nomTable + "\n";
            }
            MessageBox.Show(liste + "\n" + ds.Tables.Count.ToString() + "tables");

            // On charge les ComboBox des filtres du tableau de bord (invisible pour l'instant

            // ComboBox pour les chefs de mission
            string remplirCboChef = $"SELECT DISTINCT Membre.matricule, Membre.nom || ' ' || Membre.prenom AS nomComplet FROM Mission INNER JOIN Membre ON Mission.matriculeChef = Membre.matricule ORDER BY Membre.nom ASC";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirCboChef, this.co);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cboChefMission.DataSource = dt;
                cboChefMission.ValueMember = "matricule";
                cboChefMission.DisplayMember = "nomComplet";

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            cboChefMission.SelectedIndex = -1;


            // ComboBox pour les noms de planetes
            string remplirCboPlanete = $"SELECT nomPlanete FROM Mission ORDER BY nomPlanete";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirCboPlanete, this.co);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cboPlanete.DataSource = dt;
                cboPlanete.ValueMember = "nomPlanete";

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            cboPlanete.SelectedIndex = -1;

            //on affiche le budget maximum 
            string remplirBudgetMax = $@"SELECT MAX(CAST (budget as integer)) FROM Mission";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirBudgetMax, this.co);
                lblBd.Text += cmd.ExecuteScalar().ToString();
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void btnPlanetes_Click(object sender, EventArgs e)
        {
            FrmPlanetes fp = new FrmPlanetes();
            DialogResult dr = fp.ShowDialog();
        }

        private void btnAliens_Click(object sender, EventArgs e)
        {
            FrmAliens fa = new FrmAliens();
            DialogResult dr = fa.ShowDialog();
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            FrmLogin flog = new FrmLogin();
            DialogResult dr = flog.ShowDialog();
        }

        private void btnTableauDeBord_Click(object sender, EventArgs e)
        {
            plMissions.Visible = true;
            flpMissions.Visible = true;
            grpFiltres.Visible = true;  
            ActualiserAffichage();
            
        }

        // La méthode qui reçoit la délégation du clic
        private void OuvrirDetailMission(object sender, EventArgs e)
        {
            // ouverture d'un formulaire enfant avec constructeur surchargé pour les détails de la mission
            FrmDetailMission fdm = new FrmDetailMission(this.planete, this.numero);
            DialogResult dr = fdm.ShowDialog();
        }

        public void ActualiserAffichage()
        {
            // On vide systématiquement avant de recalculer
            flpMissions.Controls.Clear();

            string condition = " WHERE 1=1"; // astuce pour ajouter des AND facilement

            // filtre status de la mission dans la groupBox
            if (rdbPasse.Checked) { 
                condition += " AND dateRetour < date('now')"; 
            }
            else if (rdbEnCours.Checked) { 
                condition += " AND dateDepart <= date('now') AND dateRetour >= date('now')"; 
            }
            else if (rdbAVenir.Checked) { 
                condition += " AND dateDepart > date('now')"; 
            }

            // Filtre chef
            if (cboChefMission.SelectedIndex != -1)
            {
                condition += " AND matriculeChef = '" + cboChefMission.SelectedValue + "'"; // On utilise le champ mémorisé
            }

            // Filtre Planète 
            if (cboPlanete.SelectedIndex != -1)
            {
                condition += " AND nomPlanete = '" + cboPlanete.Text + "'";
            }

            // filtre budget
            if (!string.IsNullOrEmpty(txtBudgetMax.Text))
            {
                condition += " AND budget <= '"+txtBudgetMax.Text+"'";
            }

            // inner join entre Mission et membre pour ne pas avoir plusieurs fois le meme nom et prénom de chef de mission
            string requeteFinale = "SELECT Mission.*, Membre.nom, Membre.prenom FROM Mission INNER JOIN Membre ON Mission.matriculeChef = Membre.matricule " + condition + " ORDER BY Mission.dateDepart DESC";

            try
            {
                SQLiteCommand cmdRechercheMissions = new SQLiteCommand(requeteFinale, this.co);
                SQLiteDataReader dr = cmdRechercheMissions.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read()) // Parcours de toutes les missions
                    {
                        // Récupération des données
                        string nom = dr["nomPlanete"] 
                        string numero = dr["numero"].ToString();
                        string date = dr["dateDepart"].ToString().Replace("-", "/") + " - " + dr["dateRetour"].ToString().Replace("-", "/");
                        string chef = dr["prenom"]+ " " + dr["nom"];
                        string budget = dr["budget"].ToString();
                        string image = dr["nomPlanete"] + ".jpg";

                        // Instanciation du User Control
                        UserControl_Missions uc = new UserControl_Missions(nom, numero, date, chef, budget, image);

                        // délégué 
                        uc.afficheur = OuvrirDetailMission;

                        // ajout au conteneur (FlowLayoutPanel)
                        flpMissions.Controls.Add(uc);
                    }
                }
                else
                {
                    MessageBox.Show("Aucune mission ne correspond à vos critères.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRAZ_Click(object sender, EventArgs e)
        {
            rdbPasse.Checked = false;
            rdbEnCours.Checked = false;
            rdbAVenir.Checked = false;
            cboChefMission.SelectedIndex = -1;
            cboPlanete.SelectedIndex = -1;
            txtBudgetMax.Text = string.Empty;
            lblBd.Text = "Budget maximum : ";

            ActualiserAffichage(); // On recharge tout
        }

        private void txtBudgetMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            ActualiserAffichage();
        }
    }
}
