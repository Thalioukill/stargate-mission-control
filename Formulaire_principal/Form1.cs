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

            plAliens.Visible = false;


            RemplirDataSet();
            CreerClesPrim();
            CreerRelations();
            ChargerComboBox();
            AfficherBudgetMax();
            chargerAliens();
            chargerEspeces();
            charger_planetes();



            /* Vérification de la connection : 
             
            String requete = $@"SELECT COUNT(*) from Mission";

            SQLiteCommand cmd = new SQLiteCommand(requete, this.co);

            int nbMission = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("il y a " + nbMission.ToString() + "clients");

            */
        }

        private void CreerRelations()
        {
            DataTable dtMission = ds.Tables["Mission"];
            DataTable dtJournal = ds.Tables["JournalDeBord"];
            DataTable dtDepenses = ds.Tables["Depense"];
            DataTable dtTyp = ds.Tables["TypeDepense"];
            DataTable dtContacts = ds.Tables["Contact"];
            DataTable dtInf = ds.Tables["Informateur"];

            //GESTION DES 3 RELATIONS
            // On vérifie si les relations existent déjà dans le ds
            if (!ds.Relations.Contains("RelJournalDeBord"))
            {
                DataColumn[] parentCols = { dtMission.Columns["nomPlanete"], dtMission.Columns["numero"] };
                DataColumn[] enfantCols = { dtJournal.Columns["nomPlanete"], dtJournal.Columns["numero"] };
                DataRelation rel = new DataRelation("RelJournalDeBord", parentCols, enfantCols);
                ds.Relations.Add(rel);
            }

            //Relation pour les dépenses
            if (!ds.Relations.Contains("RelDepenses"))
            {
                DataColumn[] pk = { dtMission.Columns["nomPlanete"], dtMission.Columns["numero"] };
                DataColumn[] fk = { dtDepenses.Columns["nomPlanete"], dtDepenses.Columns["numeroMission"] };
                ds.Relations.Add("RelDepenses", pk, fk);
            }

            //Relation pour les TypeDepense
            if (!ds.Relations.Contains("RelType"))
            {
                // Parent : TypeDepense (id), Enfant : Depense (idTypeDepense)
                ds.Relations.Add("RelType", dtTyp.Columns["id"], dtDepenses.Columns["idTypeDepense"]);
            }

            // On ajoute une colonne de texte si elle n'existe pas encore
            if (!dtDepenses.Columns.Contains("libelleType"))
            {
                DataColumn colLibType = new DataColumn("libelleType", typeof(string));

                // "Parent(NomRelation).NomColonneDuParent"
                colLibType.Expression = "Parent(RelType).libelle";

                dtDepenses.Columns.Add(colLibType);
            }

            // Relation pour les Contacts
            if (!ds.Relations.Contains("RelContacts"))
            {
                DataColumn[] pk = { dtMission.Columns["nomPlanete"], dtMission.Columns["numero"] };
                DataColumn[] fk = { dtContacts.Columns["nomPlanete"], dtContacts.Columns["numeroMission"] };
                ds.Relations.Add("RelContacts", pk, fk);
            }

            //Relation pour le nom de l'informateur d'un contact 
            if (!ds.Relations.Contains("RelInformateur"))
            {
                ds.Relations.Add("RelInformateur", dtInf.Columns["nomCode"], dtContacts.Columns["nomCodeInformateur"]);
            }

            // On ajoute une colonne pour le nom de l'informateur
            if (!dtContacts.Columns.Contains("libelleInformateur"))
            {
                DataColumn colLibInf = new DataColumn("libelleInformateur", typeof(string));

                // "Parent(NomRelation).NomColonneDuParent"
                colLibInf.Expression = "Parent(RelInformateur).nom";

                dtContacts.Columns.Add(colLibInf);
            }
        }

        private void ChargerComboBox()
        {
            // On charge les ComboBox des filtres du tableau de bord (invisible pour l'instant)

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
        }

        private void AfficherBudgetMax()
        {
            //on affiche le budget maximum 
            string remplirBudgetMax = $@"SELECT MAX(CAST (budget as integer)) FROM Mission";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirBudgetMax, this.co);
                lblBd.Text += cmd.ExecuteScalar().ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void CreerClesPrim()
        {
            // CléS primaireS de la table Mission
            //On récupère la table Mission dans le DataSet
            DataTable dtMission = MesDatas.DsGlobal.Tables["Mission"];

            // On crée un tableau de DataColumn contenant les deux colonnes de la clé primaire
            DataColumn[] cles = new DataColumn[2];
            cles[0] = dtMission.Columns["nomPlanete"];
            cles[1] = dtMission.Columns["numero"];

            //on affecte ce tableau à la propriété PrimaryKey de la table
            dtMission.PrimaryKey = cles;


            //clé primaire de Membre 
            DataColumn clePrimMembre = ds.Tables["Membre"].Columns["matricule"];

            // mise en place de la clé primaire 
            ds.Tables["Membre"].PrimaryKey = new DataColumn[] { clePrimMembre };


            //Clé primaire de Militaire
            DataColumn clePrimMilitaire = ds.Tables["Militaire"].Columns["matriculeMembre"];

            // mise en place de la clé primaire 
            ds.Tables["Militaire"].PrimaryKey = new DataColumn[] { clePrimMilitaire };



            //Clé primaire de Civil
            DataColumn clePrimCivil = ds.Tables["Civil"].Columns["matriculeMembre"];

            // mise en place de la clé primaire 
            ds.Tables["Civil"].PrimaryKey = new DataColumn[] { clePrimCivil };

            // Clé prim de Espece 
            DataColumn clePrimEspece = ds.Tables["Espece"].Columns["id"];

            // mise en place de la clé primaire 
            ds.Tables["Espece"].PrimaryKey = new DataColumn[] { clePrimEspece };

            // Clé prim de Capturer
            DataTable dtCapturer = ds.Tables["Capturer"];

            // On crée un tableau de DataColumn contenant les trois colonnes de la clé primaire
            DataColumn[] clesCapturer = new DataColumn[3];
            clesCapturer[0] = dtCapturer.Columns["nomPlanete"];
            clesCapturer[1] = dtCapturer.Columns["numeroMission"];
            clesCapturer[2] = dtCapturer.Columns["idEspeceEnnemi"];

            //on affecte ce tableau à la propriété PrimaryKey de la table
            dtCapturer.PrimaryKey = clesCapturer;

        }

        private void RemplirDataSet()
        {
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
            //MessageBox.Show(liste + "\n" + ds.Tables.Count.ToString() + "tables");

            string sqlAllies = @"SELECT e.nom, a.degreBienveillance, e.couleur, a.instrumentMusique, e.id as idEspece,
                            GROUP_CONCAT(h.nomPlanete, '/') as Planetes
                            FROM Allie a
                            JOIN Espece e ON e.id = a.idEspece
                            LEFT JOIN Habiter h ON h.idEspece = e.id
                            GROUP BY e.nom";

            string sqlEnnemis = @"SELECT e.nom, en.degreAgressivite, e.couleur, en.typeArme, e.id as idEspece,
                             GROUP_CONCAT(h.nomPlanete, '/') as Planetes
                             FROM Ennemi en
                             JOIN Espece e ON e.id = en.idEspece
                             LEFT JOIN Habiter h ON h.idEspece = e.id
                             GROUP BY e.nom";

            SQLiteDataAdapter daAllies = new SQLiteDataAdapter(sqlAllies, co);
            if (ds.Tables.Contains("TableAllies")) ds.Tables["TableAllies"].Clear();
            daAllies.Fill(ds, "TableAllies");

            SQLiteDataAdapter daEnnemis = new SQLiteDataAdapter(sqlEnnemis, co);
            if (ds.Tables.Contains("TableEnnemis")) ds.Tables["TableEnnemis"].Clear();
            daEnnemis.Fill(ds, "TableEnnemis");

            string sql2 = $@"SELECT p.nom, p.temperature, p.gravite, p.dataBazON, 
                    GROUP_CONCAT(e.nom, '/') as Especes, 
                    GROUP_CONCAT(h.pourcentage, '/') as Pourcentages, 
                    stats_m.nbMissions
                    FROM Planete p
                    LEFT JOIN Habiter h ON h.nomPlanete = p.nom
                    LEFT JOIN Espece e ON e.id = h.idEspece
                    LEFT JOIN(
                        SELECT nomPlanete, COUNT(*) AS nbMissions
                        FROM Mission
                        GROUP BY nomPlanete
                    ) AS stats_m ON stats_m.nomPlanete = p.nom
                    GROUP BY p.nom";

            SQLiteDataAdapter da2 = new SQLiteDataAdapter(sql2, co);

            if (ds.Tables.Contains("TablePlanetesRecherche"))
                ds.Tables["TablePlanetesRecherche"].Clear();

            da2.Fill(ds, "TablePlanetesRecherche");
        }

        // =======> Code TABLEAU DE BORD

        private void tsmiTableauDeBord_Click(object sender, EventArgs e)
        {
            plMissions.Visible = true;
            ActualiserAffichage();
        }

        // La méthode qui reçoit la délégation du clic
        private void OuvrirDetailMission(object sender, EventArgs e)
        {
            // On cast le sender générique en votre type d'UC
            UserControl_Missions ucClique = (UserControl_Missions)sender;

            //on récupère la planète et le numéro directement depuis l'UC cliqué
            string planete = ucClique.Planete;
            string numero = ucClique.Numero;
            string matricule = ucClique.Matricule;

            // ouverture d'un formulaire enfant avec constructeur surchargé pour les détails de la mission
            FrmDetailMission fdm = new FrmDetailMission(planete, numero, matricule);
            DialogResult dr = fdm.ShowDialog();
        }

        private void OuvrirStatMission(object sender, EventArgs e)
        {
            // On cast le sender générique en votre type d'UC
            UserControl_Missions ucClique = (UserControl_Missions)sender;

            //on récupère la planète et le numéro directement depuis l'UC cliqué
            string planete = ucClique.Planete;
            string numero = ucClique.Numero;

            // ouverture d'un formulaire enfant avec constructeur surchargé pour les détails de la mission
            FrmStatistiquesMission fdm = new FrmStatistiquesMission(planete, numero);
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
                        string nom = dr["nomPlanete"].ToString();
                        string numero = dr["numero"].ToString();
                        string date = dr["dateDepart"].ToString().Replace("-", "/") + " - " + dr["dateRetour"].ToString().Replace("-", "/");
                        string chef = dr["prenom"]+ " " + dr["nom"];
                        DateTime dateDepart = DateTime.Parse(dr["dateDepart"].ToString());
                        DateTime dateRetour = DateTime.Parse(dr["dateRetour"].ToString());
                        TimeSpan diff = dateRetour.Subtract(dateDepart);
                        string nbJours = diff.Days.ToString()+ " jours";
                        string matriculeChef = dr["matriculeChef"].ToString();
                        string budget = dr["budget"].ToString();
                        string image = dr["nomPlanete"] + ".jpg";

                        // Instanciation du User Control
                        UserControl_Missions uc = new UserControl_Missions(nom, numero, date, nbJours, chef, matriculeChef, budget, image);

                        // délégué 
                        uc.details = OuvrirDetailMission;
                        uc.stats = OuvrirStatMission;

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





        // =======>  Code partie ALIENS


        private void chargerAliensAlliees()
        {
            flp1.Controls.Clear();

            string filtre = $"nom LIKE '%{txtNomAlliees.Text}%'";
            if (cboBienveillance.SelectedIndex != -1)
            {
                filtre += $" AND degreBienveillance = '{cboBienveillance.Text}'";
            }
            if (cboCouleurAlliees.SelectedIndex != -1)
            {
                filtre += $" AND couleur = '{cboCouleurAlliees.Text}'";
            }

            DataRow[] rows = ds.Tables["TableAllies"].Select(filtre);

            foreach (DataRow dr in rows)
            {
                string nom = dr["nom"].ToString();
                string bien = dr["degreBienveillance"].ToString();
                string coul = dr["couleur"].ToString();
                string planete = dr["Planetes"] == DBNull.Value ? "Origine inconnue" : dr["Planetes"].ToString();
                string inst = dr["instrumentMusique"].ToString();
                string image = nom + ".jpg";

                InfoAlien info = new InfoAlien(nom, bien, coul, planete, inst, image);
                flp1.Controls.Add(info);
            }
        }

        private void chargerAliensEnnemis()
        {
            flp2.Controls.Clear();
            try
            {
                string filtre = $"nom LIKE '%{txtNomEnnemis.Text.Replace("'", "''")}%'";

                if (cboAgressivite.SelectedIndex != -1)
                {
                    filtre += $" AND degreAgressivite = '{cboAgressivite.Text}'";
                }
                if (cboCouleurEnnemis.SelectedIndex != -1)
                {
                    filtre += $" AND couleur = '{cboCouleurEnnemis.Text}'";
                }
                if (cboTypeArme.SelectedIndex != -1)
                {
                    filtre += $" AND typeArme = '{cboTypeArme.Text}'";
                }

                DataRow[] rows = ds.Tables["TableEnnemis"].Select(filtre);

                foreach (DataRow dr in rows)
                {
                    string nomAlien = dr["nom"].ToString();
                    string agressivite = dr["degreAgressivite"].ToString();
                    string couleur = dr["couleur"].ToString();

                    string planete = dr["Planetes"] == DBNull.Value
                        ? "Origine inconnue"
                        : dr["Planetes"].ToString();

                    string arme = dr["typeArme"].ToString();
                    string image = nomAlien + ".jpg";

                    InfoAlien info = new InfoAlien(nomAlien, agressivite, couleur, planete, arme, image);
                    flp2.Controls.Add(info);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur filtrage ennemis : " + err.Message);
            }
        }

        private void chargerAliens() 
        {
            try
            {

                foreach (DataRow dr in ds.Tables["Espece"].Rows)
                {
                    string coul = dr["couleur"].ToString();
                    if (!string.IsNullOrEmpty(coul) && !cboCouleurAlliees.Items.Contains(coul))
                    {
                        cboCouleurAlliees.Items.Add(coul);
                        cboCouleurEnnemis.Items.Add(coul);
                    }
                }
                foreach (DataRow dr in ds.Tables["Ennemi"].Rows)
                {
                    string arme = dr["typeArme"].ToString();
                    string ag = dr["degreAgressivite"].ToString();

                    if (!string.IsNullOrEmpty(arme) && !cboTypeArme.Items.Contains(arme))
                    {
                        cboTypeArme.Items.Add(arme);
                    }
                    if (!string.IsNullOrEmpty(ag) && !cboAgressivite.Items.Contains(ag))
                    {
                        cboAgressivite.Items.Add(ag);
                    }
                }
                foreach (DataRow dr in ds.Tables["Allie"].Rows)
                {
                    string bv = dr["degreBienveillance"].ToString();

                    if (!string.IsNullOrEmpty(bv) && !cboBienveillance.Items.Contains(bv))
                    {
                        cboBienveillance.Items.Add(bv);
                    }
                }
                chargerAliensAlliees();
                chargerAliensEnnemis();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tmsiAliens_Click(object sender, EventArgs e)
        {
            //plPlanetes.Visible = false;
            plMissions.Visible = false;
            plAliens.Visible = true;
        }

        private void btnReinitialiserAlliees_Click(object sender, EventArgs e)
        {
            txtNomAlliees.Text = "";
            cboBienveillance.SelectedIndex = -1;
            cboCouleurAlliees.SelectedIndex = -1;
            chargerAliensAlliees();
        }

        private void btnReinitialiserEnnemis_Click(object sender, EventArgs e)
        {
            txtNomEnnemis.Text = "";
            cboAgressivite.SelectedIndex = -1;
            cboCouleurEnnemis.SelectedIndex = -1;
            cboTypeArme.SelectedIndex = -1;
            chargerAliensEnnemis();

        }

        private void btnRechercherAlliees_Click(object sender, EventArgs e)
        {
            chargerAliensAlliees();
        }

        private void btnReinitialiserCouleurAlliees_Click(object sender, EventArgs e)
        {
            cboCouleurAlliees.SelectedIndex = -1;
            chargerAliensAlliees();
        }

        private void btnReinitialiserBienveillance_Click(object sender, EventArgs e)
        {
            cboBienveillance.SelectedIndex = -1;
            chargerAliensAlliees();
        }

        private void btnRechercherEnnemis_Click(object sender, EventArgs e)
        {
            chargerAliensEnnemis();
        }

        private void btnReinitialiserCouleurEnnemis_Click(object sender, EventArgs e)
        {
            cboCouleurEnnemis.SelectedIndex = -1;
            chargerAliensEnnemis();
        }

        private void btnTypeArme_Click(object sender, EventArgs e)
        {
            cboTypeArme.SelectedIndex = -1;
            chargerAliensEnnemis();
        }

        private void btnAgressivité_Click(object sender, EventArgs e)
        {
            cboAgressivite.SelectedIndex = -1;
            chargerAliensEnnemis();
        }

        private void btnReinitialiserCouleurAlliees_Click_1(object sender, EventArgs e)
        {
            cboCouleurAlliees.SelectedIndex = -1;
            chargerAliensAlliees();
        }

        private void txtNomAlliees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnRechercherAlliees.PerformClick();
            }
        }

        private void txtNomEnnemis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnRechercherEnnemis.PerformClick();
            }
        }


        //========> Code FrmPlanetes 

        private void tmsiPlanete_Click(object sender, EventArgs e)
        {
            plPlanetes.Visible = true;
        }

        private void chargerEspeces()
        {
            try
            {
                flpEspece.Controls.Clear();
                foreach (DataRow dr in ds.Tables["Espece"].Rows)
                {
                    string nom = dr["nom"].ToString();
                    CheckboxEspeces cb = new CheckboxEspeces(nom);
                    flpEspece.Controls.Add(cb);
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void charger_planetes()
        {
            try
            {
                flpPlanete.Controls.Clear();
                string filtre = $"nom LIKE '%{txtNom.Text}%'";

                if (txtMinTemp.Text != "")
                {
                    filtre += $" AND temperature >= {txtMinTemp.Text}";
                }
                if (txtMaxTemp.Text != "")
                {
                    filtre += $" AND temperature <= {txtMaxTemp.Text}";
                }
                if (txtMinGrav.Text != "")
                {
                    filtre += $" AND gravite >= {txtMinGrav.Text}";
                }
                if (txtMaxGrav.Text != "")
                {
                    filtre += $" AND gravite <= {txtMaxGrav.Text}";
                }
                if (rdbSans.Checked)
                {
                    filtre += " AND dataBazON = 0";
                }
                else if (rdbAvec.Checked)
                {
                    filtre += " AND dataBazON = 1";
                }
                string filtreEspece = "";
                for (int i = 0; i < flp2.Controls.Count; i++)
                {
                    if (flpEspece.Controls[i] is CheckboxEspeces userCtrl)
                    {
                        CheckBox cb = userCtrl.Controls["chkEspece"] as CheckBox;

                        if (cb != null && cb.Checked)
                        {
                            if (filtreEspece != "")
                            {
                                filtreEspece += " OR ";
                            }
                            filtreEspece += $"Especes LIKE '%{cb.Text}%'";
                        }
                    }
                }
                if (filtreEspece != "")
                {
                    filtre += $" AND ({filtreEspece})";
                }
                DataRow[] rows = ds.Tables["TablePlanetesRecherche"].Select(filtre);

                foreach (DataRow dr in rows)
                {
                    string nom = dr["nom"].ToString();
                    string temp = dr["temperature"] == DBNull.Value ? "Température inconnue" : dr["temperature"].ToString();
                    string grav = dr["gravite"] == DBNull.Value ? "Gravité inconnue" : dr["gravite"].ToString();
                    string dbz = dr["dataBazON"] == DBNull.Value ? "Aucune information" : dr["dataBazON"].ToString();
                    string esp = dr["Especes"] == DBNull.Value ? "Espèces inconnues" : dr["Especes"].ToString();
                    string pct = dr["Pourcentages"] == DBNull.Value ? "Taux d'espèces inconnue" : dr["Pourcentages"].ToString();

                    int nbMissions = 0;
                    if (dr["nbMissions"] != DBNull.Value)
                        int.TryParse(dr["nbMissions"].ToString(), out nbMissions);

                    int fMin = 0, fMax = int.MaxValue;
                    int.TryParse(txtMinMission.Text, out fMin);
                    if (!string.IsNullOrWhiteSpace(txtMaxMission.Text)) int.TryParse(txtMaxMission.Text, out fMax);

                    if (nbMissions >= fMin && nbMissions <= fMax)
                    {
                        InfoPlanete info = new InfoPlanete(nom, temp, grav, dbz, esp, pct, nbMissions.ToString());
                        flpPlanete.Controls.Add(info);
                    }
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtMinTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (e.KeyChar == '-' && txtMinTemp.Text.Length == 0)
            {
                e.Handled = false;
            }
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtMaxTemp.Focus();
            }
        }

        private void txtMaxTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (e.KeyChar == '-' && txtMinTemp.Text.Length == 0)
            {
                e.Handled = false;
            }
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtMinGrav.Focus();
            }
        }

        private void txtMinGrav_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (e.KeyChar == '-' && txtMinTemp.Text.Length == 0)
            {
                e.Handled = false;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (txtMinGrav.Text.Contains(".") || txtMinGrav.Text.Length == 0 || (txtMinGrav.Text.Length == 1 && txtMinGrav.Text == "-"))
                {
                    e.KeyChar = '.';
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = '.';
                    e.Handled = false;
                }
            }
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtMaxGrav.Focus();
            }
        }

        private void txtMaxGrav_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (e.KeyChar == '-' && txtMaxTemp.Text.Length == 0)
            {
                e.Handled = false;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (txtMaxGrav.Text.Contains(".") || txtMaxGrav.Text.Length == 0 || (txtMaxGrav.Text.Length == 1 && txtMaxGrav.Text == "-"))
                {
                    e.KeyChar = '.';
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = '.';
                    e.Handled = false;
                }
            }
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtMinMission.Focus();
            }
        }

        private void btnReinitialiserDataBaz_Click(object sender, EventArgs e)
        {
            rdbSans.Checked = false;
            rdbAvec.Checked = false;
            charger_planetes();
        }

        private void btnReinitialiserEspeces_Click(object sender, EventArgs e)
        {
            flp2.Controls.Clear();
            chargerEspeces();
            charger_planetes();
        }

        private void txtMinMission_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtMaxMission.Focus();
            }
        }

        private void txtMaxMission_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinGrav.Text, out int minG) && int.TryParse(txtMaxGrav.Text, out int maxG))
            {
                if (minG > maxG)
                {
                    MessageBox.Show("max > min impossible");
                    txtMinGrav.Focus();
                    return;
                }
            }
            if (int.TryParse(txtMinTemp.Text, out int minT) && int.TryParse(txtMaxTemp.Text, out int maxT))
            {
                if (minT > maxT)
                {
                    MessageBox.Show("max > min impossible");
                    txtMinTemp.Focus();
                    return;
                }
            }
            if (int.TryParse(txtMinMission.Text, out int minM) && int.TryParse(txtMaxMission.Text, out int maxM))
            {
                if (minM > maxM)
                {
                    MessageBox.Show("max > min impossible");
                    txtMinMission.Focus();
                    return;
                }
            }
            charger_planetes();
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            rdbSans.Checked = false;
            rdbAvec.Checked = false;
            txtMinTemp.Text = "";
            txtMaxTemp.Text = "";
            txtMinGrav.Text = "";
            txtMaxGrav.Text = "";
            txtMinMission.Text = "";
            txtMaxMission.Text = "";
            flp2.Controls.Clear();
            chargerEspeces();
            txtNom.Text = "";
            charger_planetes();
        }

        private void txtNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtMinTemp.Focus();
            }
        }

        private void txtMinTemp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtMaxTemp.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtNom.Focus();
            }
        }

        private void txtMaxTemp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtMinGrav.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtMinTemp.Focus();
            }
        }

        private void txtMinGrav_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtMaxGrav.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtMaxTemp.Focus();
            }
        }

        private void txtMaxGrav_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtMinMission.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtMinGrav.Focus();
            }
        }

        private void txtMinMission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtMaxMission.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtMaxGrav.Focus();
            }
        }

        private void txtMaxMission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtMinMission.Focus();
            }
        }
    }
}
