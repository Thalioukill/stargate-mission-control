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
            plPlanetes.Visible = false;
            plAliens.Visible = false;


            RemplirDataSet();
            CreerClesPrim();
            CreerRelations();
            ChargerComboBox();
            AfficherBudgetMax();
            chargerAliens();
            chargerEspeces();
            charger_planetes();

            msMenu.Renderer = new MyRenderer();


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

                // On crée une nouvelle ligne manuellement pour l'option "Tous"
                DataRow ligneTous = dt.NewRow();
                ligneTous["matricule"] = "TOUS"; // Valeur mémorisée neutre
                ligneTous["nomComplet"] = "Tous les chefs"; // Texte affiché
                dt.Rows.InsertAt(ligneTous, 0); // On l'insère à l'index 0 (le début)

                cboChefMission.DataSource = dt;
                cboChefMission.ValueMember = "matricule";
                cboChefMission.DisplayMember = "nomComplet";

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            cboChefMission.SelectedIndex = 0; // On sélectionne tous les chefs par défaut

            // ComboBox pour les noms de planetes
            string remplirCboPlanete = $"SELECT nomPlanete FROM Mission ORDER BY nomPlanete";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(remplirCboPlanete, this.co);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                DataRow ligneToutesP = dt.NewRow();
                ligneToutesP["nomPlanete"] = "Toutes les planètes";
                dt.Rows.InsertAt(ligneToutesP, 0);

                cboPlanete.DataSource = dt;
                cboPlanete.ValueMember = "nomPlanete";
                cboPlanete.DisplayMember = "nomPlanete";

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            cboPlanete.SelectedIndex = 0;
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
                            GROUP_CONCAT(h.nomPlanete, ' / ') as Planetes
                            FROM Allie a
                            JOIN Espece e ON e.id = a.idEspece
                            LEFT JOIN Habiter h ON h.idEspece = e.id
                            GROUP BY e.nom";

            string sqlEnnemis = @"SELECT e.nom, en.degreAgressivite, e.couleur, en.typeArme, e.id as idEspece,
                             GROUP_CONCAT(h.nomPlanete, ' / ') as Planetes
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
                    GROUP_CONCAT(e.nom, ' / ') as Especes, 
                    GROUP_CONCAT(h.pourcentage, ' / ') as Pourcentages, 
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
        public void ActualiserPanel(Panel panelAAfficher)
        {
            // On parcourt tous les contrôles du formulaire pour masquer les panels
            foreach (Panel p in this.Controls.OfType<Panel>())
            {
                // On évite de masquer un éventuel panel de menu permanent
                if (p == plMissions || p == plAliens || p == plPlanetes)
                {
                    p.Visible = false;
                }
            }

            // On affiche uniquement celui passé en paramètre
            if (panelAAfficher != null)
            {
                panelAAfficher.Visible = true;
            }
        }



        // =======> Code TABLEAU DE BORD

        private void tsmiTableauDeBord_Click(object sender, EventArgs e)
        {
            ActualiserPanel(plMissions);
            ActualiserAffichage();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                if (e.Item.Selected) // Si la souris survole l'élément
                {
                    //définit la couleur du texte au survol (équivaent de mouveOver)
                    e.TextColor = Color.FromArgb(229, 255, 204); // Blanc en RGB
                }
                else
                {
                    // couleur du texte au repos
                    e.TextColor = Color.FromArgb(0, 51, 25);
                }
                base.OnRenderItemText(e);
            }
        }

        // La table des couleurs qui gère le FOND (Background)
        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(102, 0, 255); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(102, 0, 255); } 
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(223, 115, 255); }
            }

            // Pour supprimer la bordure moche autour de la sélection
            public override Color MenuItemBorder
            {
                get { return Color.Transparent; }
            }
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

            // pour compter le nombre de missions
            int nbMissions = 0;
            grpNbMissionsTrouvees.Text = "";

            // on remet l'affichage à zéro
            grpNbMissionsTrouvees.ForeColor = SystemColors.ControlText;
            grpNbMissionsTrouvees.Font = new Font(grpNbMissionsTrouvees.Font, FontStyle.Regular);

            // si le rdbRAZ est coché on ne change rien, on ajoute aucun filtre...
            string condition = " WHERE 1=1"; // astuce pour ajouter des AND facilement

            // filtre status de la mission dans la groupBox
            // on utilise localtime parce que sinon ca ne prends pas en compte les heures... (test à 0h45 et ca créer des soucis..)
            if (rdbPasse.Checked) { 
                condition += " AND date(dateRetour) < date('now', 'localtime')"; 
            }
            else if (rdbEnCours.Checked) { 
                condition += " AND date(dateDepart) <= date('now', 'localtime') AND date(dateRetour) >= date('now', 'localtime')"; 
            }
            else if (rdbAVenir.Checked) { 
                condition += " AND date(dateDepart) > date('now','localtime')"; 
            }

            // Filtre chef
            if (cboChefMission.SelectedIndex > 0)
            {
                condition += " AND matriculeChef = '" + cboChefMission.SelectedValue + "'"; // On utilise le champ mémorisé
            }

            // Filtre Planète 
            if (cboPlanete.SelectedIndex > 0)
            {
                condition += " AND nomPlanete = '" + cboPlanete.Text + "'";
            }

            // filtre budget
            if (!string.IsNullOrEmpty(txtBudgetMin.Text))
            {
                condition += " AND budget >= '"+txtBudgetMin.Text+"'";
            }

            // filtre durée avec le NumericUpDown
            if (nupNbMissions.Value > 0)
            {
                condition += " AND (julianday(dateRetour) - julianday(dateDepart)) >= " + nupNbMissions.Value;
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
                        // on doit d'abord convertir le tout en DateTime et ensuite formater la sortie.
                        string date = Convert.ToDateTime(dr["dateDepart"]).ToString("dd/MM/yyyy") + " - "+ Convert.ToDateTime(dr["dateRetour"]).ToString("dd/MM/yyyy");
                        string chef = dr["prenom"]+ " " + dr["nom"];
                        DateTime dateDepart = DateTime.Parse(dr["dateDepart"].ToString());
                        DateTime dateRetour = DateTime.Parse(dr["dateRetour"].ToString());
                        TimeSpan diff = dateRetour.Subtract(dateDepart);
                        string nbJours = diff.Days.ToString()+ " jours";
                        string matriculeChef = dr["matriculeChef"].ToString();
                        string budget = dr["budget"].ToString();
                        string image = dr["nomPlanete"] + ".jpg";
                        DateTime aujourdhui = DateTime.Now;
                        

                        // Instanciation du User Control
                        UserControl_Missions uc = new UserControl_Missions(nom, numero, date, nbJours, chef, matriculeChef, budget, image);
                        // DATES (pour la couleur du cadre)
                        uc.DateDepart = dateDepart;
                        uc.DateRetour = dateRetour;

                        // délégué 
                        uc.details = OuvrirDetailMission;
                        uc.stats = OuvrirStatMission;

                        // ajout au conteneur (FlowLayoutPanel)
                        flpMissions.Controls.Add(uc);
                        nbMissions++;
                    }
                    if(nbMissions > 0)
                    {
                        grpNbMissionsTrouvees.Text = "Nombre de missions trouvées : "+nbMissions.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Erreur : Aucune mission ne correspond à vos critères.", "Filtre invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grpNbMissionsTrouvees.Text = "Aucune mission trouvée...";
                    // Changer la couleur en rouge
                    grpNbMissionsTrouvees.ForeColor = Color.FromArgb(255, 50, 50);

                    // Mettre en gras
                    grpNbMissionsTrouvees.Font = new Font(grpNbMissionsTrouvees.Font, FontStyle.Bold);
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
            cboChefMission.SelectedIndex = 0;
            cboPlanete.SelectedIndex = 0;
            txtBudgetMin.Text = string.Empty;
            lblBd.Text = "Budget maximum : ";
            rdbRAZ.Checked = true;

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


        private void cbo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;

            if (cbo.SelectedIndex != -1)
            {
                ActualiserAffichage();
            }

        }

        //J'ai sélectionné les 4 radioButtons du tableau de bord et j'ai fais en sorte de tous les abonner (pour la propriété CheckedChange) à cette méthode que j'ai écrite
        private void btn_CheckedChanged(object sender, EventArgs e)
        {
            // on caste le sender en radiobutton
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                ActualiserAffichage();
            }

        }

        private void nupNbMissions_KeyDown(object sender, KeyEventArgs e)
        {
            // si l'utilisateur tape sur entrée
            if (e.KeyCode == Keys.Enter)
            {
                // On vérifie la valeur avant de lancer la recherche
                if (nupNbMissions.Value < 1)
                {
                    MessageBox.Show("Erreur : il faut choisir au moins 1 jour pour filtrer les missions.", "Filtre invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Si c'est bon, on actualise le tableau de bord
                    ActualiserAffichage();
                }
            }
        }



        // =======>  Code partie ALIENS

        private void tmsiAliens_Click(object sender, EventArgs e)
        {
            ActualiserPanel(plAliens);
        }

        private void chargerAliensAlliees()
        {
            flp1.Controls.Clear();
            lblErreur.Visible = false;
            errorProvider1.Clear();
            string filtre = $"nom LIKE '%{txtNomAlliees.Text}%'";
            if (cboBienveillance.SelectedIndex != -1 && cboBienveillance.Text != "Toutes")
            {
                filtre += $" AND degreBienveillance = '{cboBienveillance.Text}'";
            }
            if (cboCouleurAlliees.SelectedIndex != -1 && cboCouleurAlliees.Text != "Toutes")
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
            if (flp1.Controls.Count == 0)
            {
                lblErreur.Visible = true;
                errorProvider1.SetError(lblErreur, "Veuillez réinitialiser les filtres.");
            }
        }

        private void chargerAliensEnnemis()
        {
            lblErreur2.Visible = false;
            errorProvider1.Clear();
            flp2.Controls.Clear();
            try
            {
                string filtre = $"nom LIKE '%{txtNomEnnemis.Text.Replace("'", "''")}%'";

                if (cboAgressivite.SelectedIndex != -1 && cboAgressivite.Text != "Toutes")
                {
                    filtre += $" AND degreAgressivite = '{cboAgressivite.Text}'";
                }
                if (cboCouleurEnnemis.SelectedIndex != -1 && cboCouleurEnnemis.Text != "Toutes")
                {
                    filtre += $" AND couleur = '{cboCouleurEnnemis.Text}'";
                }
                if (cboTypeArme.SelectedIndex != -1 && cboTypeArme.Text != "Toutes")
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

                    InfoEnnemis info = new InfoEnnemis(nomAlien, agressivite, couleur, planete, arme, image);
                    flp2.Controls.Add(info);
                }
                if(flp2.Controls.Count == 0)
                {
                    lblErreur2.Visible = true;
                    errorProvider1.SetError(lblErreur2, "Veuillez réinitialiser les filtres.");
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
                List<string> listeCouleurs = new List<string>();
                List<string> listeArmes = new List<string>();
                List<string> listeAgressivite = new List<string>();
                List<string> listeBienveillance = new List<string>();
                foreach (DataRow dr in ds.Tables["Espece"].Rows)
                {
                    string coul = dr["couleur"].ToString();
                    if (!string.IsNullOrEmpty(coul) && !listeCouleurs.Contains(coul))
                    {
                        listeCouleurs.Add(coul);
                    }
                }

                foreach (DataRow dr in ds.Tables["Ennemi"].Rows)
                {
                    string arme = dr["typeArme"].ToString();
                    string ag = dr["degreAgressivite"].ToString();

                    if (!string.IsNullOrEmpty(arme) && !listeArmes.Contains(arme))
                    {
                        listeArmes.Add(arme);
                    }
                    if (!string.IsNullOrEmpty(ag) && !listeAgressivite.Contains(ag))
                    {
                        listeAgressivite.Add(ag);
                    }
                }

                foreach (DataRow dr in ds.Tables["Allie"].Rows)
                {
                    string bv = dr["degreBienveillance"].ToString();

                    if (!string.IsNullOrEmpty(bv) && !listeBienveillance.Contains(bv))
                    {
                        listeBienveillance.Add(bv);
                    }
                }
                listeCouleurs.Sort();
                listeArmes.Sort();
                listeAgressivite.Sort();
                listeBienveillance.Sort();
                cboCouleurAlliees.Items.Add("Toutes");
                cboCouleurEnnemis.Items.Add("Toutes");
                cboTypeArme.Items.Add("Toutes");
                cboAgressivite.Items.Add("Toutes");
                cboBienveillance.Items.Add("Toutes");
                cboCouleurAlliees.Items.AddRange(listeCouleurs.ToArray());
                cboCouleurEnnemis.Items.AddRange(listeCouleurs.ToArray());
                cboTypeArme.Items.AddRange(listeArmes.ToArray());
                cboAgressivite.Items.AddRange(listeAgressivite.ToArray());
                cboBienveillance.Items.AddRange(listeBienveillance.ToArray());
                cboCouleurAlliees.SelectedIndex = 0;
                cboCouleurEnnemis.SelectedIndex = 0;
                cboTypeArme.SelectedIndex = 0;
                cboAgressivite.SelectedIndex = 0;
                cboBienveillance.SelectedIndex = 0;
                chargerAliensAlliees();
                chargerAliensEnnemis();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnReinitialiserAlliees_Click(object sender, EventArgs e)
        {
            txtNomAlliees.Text = "";
            cboBienveillance.SelectedIndex = 0;
            cboCouleurAlliees.SelectedIndex = 0;
            chargerAliensAlliees();
        }

        private void btnReinitialiserEnnemis_Click(object sender, EventArgs e)
        {
            txtNomEnnemis.Text = "";
            cboAgressivite.SelectedIndex = 0;
            cboCouleurEnnemis.SelectedIndex = 0;
            cboTypeArme.SelectedIndex = 0;
            chargerAliensEnnemis();

        }

        private void btnRechercherAlliees_Click(object sender, EventArgs e)
        {
            if (cboBienveillance.SelectedIndex == -1 && cboBienveillance.Text != "")
            {
                MessageBox.Show("Veuillez sélectionner un taux de bienveillance valide");
            }
            else if (cboCouleurAlliees.SelectedIndex == -1 && cboCouleurAlliees.Text != "")
            {
                MessageBox.Show("Veuillez sélectionner une couleur valide");
            }
            else 
            {
                chargerAliensAlliees();
            }
        }

        private void btnReinitialiserCouleurAlliees_Click(object sender, EventArgs e)
        {
            cboCouleurAlliees.SelectedIndex = -1;
            cboCouleurAlliees.Text = "";
        }

        private void btnReinitialiserBienveillance_Click(object sender, EventArgs e)
        {
            cboBienveillance.SelectedIndex = -1;
            cboBienveillance.Text = "";
        }

        private void btnRechercherEnnemis_Click(object sender, EventArgs e)
        {
            if (cboAgressivite.SelectedIndex == -1 && cboAgressivite.Text != "")
            {
                MessageBox.Show("Veuillez sélectionner un taux d'agressivité valide");
            }
            else if (cboCouleurEnnemis.SelectedIndex == -1 && cboCouleurEnnemis.Text != "")
            {
                MessageBox.Show("Veuillez sélectionner une couleur valide");
            }
            else if (cboTypeArme.SelectedIndex == -1 && cboTypeArme.Text != "")
            {
                MessageBox.Show("Veuillez sélectionner un type d'arme valide");
            }
            else
            {
                chargerAliensEnnemis();
            }
        }

        private void btnReinitialiserCouleurEnnemis_Click(object sender, EventArgs e)
        {
            cboCouleurEnnemis.SelectedIndex = -1;
            cboCouleurEnnemis.Text = ""; 
        }

        private void btnTypeArme_Click(object sender, EventArgs e)
        {
            cboTypeArme.SelectedIndex = -1;
            cboTypeArme.Text = "";
        }

        private void btnAgressivité_Click(object sender, EventArgs e)
        {
            cboAgressivite.SelectedIndex = -1;
            cboAgressivite.Text = "";
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
                chargerAliensAlliees();
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
                chargerAliensEnnemis();
            }
        }


        //========> Code FrmPlanetes 

        private void tmsiPlanete_Click(object sender, EventArgs e)
        {
            ActualiserPanel(plPlanetes);
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
                    cb.Tag = dr["id"];
                    var checkBoxInterne = cb.Controls.OfType<CheckBox>().FirstOrDefault();
                    if (checkBoxInterne != null)
                    {
                        checkBoxInterne.CheckedChanged += (s, e) => charger_planetes();
                        checkBoxInterne.Font = new Font("Kristen ITC", 12, FontStyle.Regular);
                    }
                    cb.Margin = new Padding(3, 0, 3, 0);
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
                e.Handled = true;
                btnRechercher.PerformClick();
                charger_planetes();
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
                e.Handled = true;
                btnRechercher.PerformClick();
                charger_planetes();
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
                e.Handled = true;
                btnRechercher.PerformClick();
                charger_planetes();
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
                e.Handled = true;
                btnRechercher.PerformClick();
                charger_planetes();
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
                e.Handled = true;
                btnRechercher.PerformClick();
                charger_planetes();
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnRechercher.PerformClick();
                charger_planetes();
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

        // =====> Code FrmCreationMission
        private void tsmiMission_Click(object sender, EventArgs e)
        {
            plAliens.Visible = false;
            plMissions.Visible = false;
            plPlanetes.Visible = false;

            FrmLogin flog = new FrmLogin();
            DialogResult drLog = flog.ShowDialog();

            if (drLog == DialogResult.OK)
            {
                FrmMission fm = new FrmMission();
                DialogResult drMiss = fm.ShowDialog();
                if (drMiss == DialogResult.OK)
                {
                    MessageBox.Show("Mission créée");
                }
                if (drMiss == DialogResult.Cancel)
                {
                    MessageBox.Show("Echec de la création de la mission");
                }
            }

            if (drLog == DialogResult.Cancel)
            {
                MessageBox.Show("Opération annulée");
            }
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if(char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                    e.Handled = true;
                    btnRechercher.PerformClick();
                    charger_planetes();
            }
        }

        private void lblNbMission_Click(object sender, EventArgs e)
        {

        }

        private void cboCouleurAlliees_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargerAliensAlliees();
        }

        private void cboBienveillance_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargerAliensAlliees();
        }

        private void cboAgressivite_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargerAliensEnnemis();
        }

        private void cboTypeArme_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargerAliensEnnemis();
        }

        private void cboCouleurEnnemis_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargerAliensEnnemis();
        }

        private void rdbSans_Click(object sender, EventArgs e)
        {
            charger_planetes();
        }

        private void rdbAvec_Click(object sender, EventArgs e)
        {
            charger_planetes();
        }
    }
}
