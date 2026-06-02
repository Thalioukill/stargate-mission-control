using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Forms.DataVisualization.Charting;

namespace Formulaire_principal
{
    public partial class FrmJournalDeBord : Form
    {

        private SQLiteConnection co = Connexion.Connec;

        //instanciation du DataSet
        private DataSet ds = MesDatas.DsGlobal;

        private string idPlanete;
        private string idNumero;
        private string nomTableBilan;
        private string nomMission;
        private string dateDepart;
        private string dateArrivee;
        private string nomChef;
        private string budgetInitial;
        private string txtFeuilleRoute;
        private List<string> membres = new List<string>();
        private int nbJours;
        private List<string> evenements = new List<string>();
        private List<string> captures = new List<string>();
        private int depenses;
        private int sommeVersee;
        private List<string> contactsInformateurs = new List<string>();
        private double maxMontantMission = 0;

        // On déclare les BindingSources ici pour qu'ils soient accessibles partout dans le formulaire
        private BindingSource bsMissions;
        private BindingSource bsJournal;
        private BindingSource bsContacts;
        private BindingSource bsDepenses;
        private BindingSource bsBilan;

        public FrmJournalDeBord()
        {
            InitializeComponent();
        }

        public FrmJournalDeBord(string planete, string numero, string dateDepart, string dateArrivee, string nomChef, string txtFeuilleRoute, List<string> membres, int nbJours)
        {
            InitializeComponent();
            this.Text += planete.ToUpper() + "-" + numero;
            this.idPlanete = planete;
            this.idNumero = numero;
            this.dateDepart = dateDepart;
            this.dateArrivee = dateArrivee;
            this.nomChef = nomChef;
            this.txtFeuilleRoute = txtFeuilleRoute;
            this.membres = membres;
            this.nbJours = nbJours;
            this.nomMission = $"{planete.ToUpper()}-{numero}";
            this.nomTableBilan = $"BilanCapture{this.idPlanete.ToUpper()}-{this.idNumero}";
            
            CreerTableBilanCapture();
            RemplirTableBilan();
            AfficherBilan();
            InitBinding();
            InitContacts();
            InitDepenses();
            CalculerTotaux();
            GenererGraphiqueBudget();
        }

        private void FrmJournalDeBord_Load(object sender, EventArgs e)
        {

        }

        private void InitBinding()
        {

            //Config du BindingSource Mission => Maitre
            this.bsMissions = new BindingSource();

            // liaison à la DataTable Mission du ds
            this.bsMissions.DataSource = ds.Tables["Mission"];
            // tri par défaut (par date de départ)
            //this.bsMissions.Sort = "dateDepart DESC"; UTILE ? 

            // IMPORTANCE : On filtre pour ne garder que la mission consultée
            this.bsMissions.Filter = $"nomPlanete = '{this.idPlanete}' AND numero = {this.idNumero}";


            // Configurations des Details (Journal de Bord, Depenses et Contacts)
            // On le lie au BS Maître (Mission) en utilisant le nom de la Relation
            this.bsJournal = new BindingSource();
            this.bsJournal.DataSource = bsMissions;
            this.bsJournal.DataMember = "RelJournalDeBord";
            this.bsJournal.Sort = "dateJ ASC";
            this.bsJournal.MoveFirst();

            // On lie le changement de position (MoveLast, MoveFirst) à la fonction bsJournal_PositionChanged pour compter le nombre d'évènements
            this.bsJournal.PositionChanged += new EventHandler(bsJournal_PositionChanged);

            // ON force l'affichage dès le début sinon on ne voit rien avant de toucher aux boutons
            bsJournal_PositionChanged(null, null);

            try
            {
                //Liaison aux composants(Labels/TextBox)
                lblDateEvenement.DataBindings.Add("Text", this.bsJournal, "dateJ");
                lblCommentaire.DataBindings.Add("Text", this.bsJournal, "commentaires");

            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            this.evenements.Clear();

            // On parcourt toutes les lignes du journal de bord liées à cette mission
            foreach (DataRowView drv in this.bsJournal)
            {
                string dateEvent = drv["dateJ"].ToString();
                dateEvent = DateTime.Parse(dateEvent).ToString("dd/MM/yyyy");
                string comm = drv["commentaires"].ToString();

                this.evenements.Add($"Date : {dateEvent}\nDétail : {comm}");
            }
        }

        // ===> Code du compteur d'évènement du Journal de Bord

        private void bsJournal_PositionChanged(object sender, EventArgs e)
        {
            // Récupération des informations de bsJournal
            int totalElements = this.bsJournal.Count;
            int indexActuel = this.bsJournal.Position; // index commence à 0

            // Nombre d'éléments avant: c'est l'index actuel (ex position 2 signifie qu'il y a 2 eléments avant)
            int nbAvant = indexActuel;

            // Nombre d'éléments après :(tot - 1) pour avoir le dernier index, moins la position actuelle
            int nbApres = Math.Max(0, (totalElements - 1) - indexActuel);

            if (totalElements > 0)
            {
                lblNavigation.Text = $"Événement {indexActuel + 1} sur {totalElements}";
                //Pas assez de place pour tout afficher mdrrr
                //lblAvant.Text = $"{nbAvant} événement(s) au début";
                //lblApres.Text = $"{nbApres} événement(s) restant(s) à la fin";

                //Désactivation automatique des boutons aux extrémités quand on arrive à la fin ou au début des évènements...
                btnBefore.Enabled = (indexActuel > 0);
                btnDepart.Enabled = (indexActuel > 0);
                btnAfter.Enabled = (indexActuel < totalElements - 1);
                btnEnd.Enabled = (indexActuel < totalElements - 1);
            }
            else
            {
                lblNavigation.Text = "Aucun événement enregistré";
            }
        }


        private void InitDepenses()
        {
            this.bsDepenses = new BindingSource();
            this.bsDepenses.DataSource = bsMissions;
            this.bsDepenses.DataMember = "RelDepenses";

            // Remplissage des DataGridView avec les DEPENSES :
            try
            {
                dgvDepenses.DataSource = bsDepenses;
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            AffichageDepenses();

        }

        private void AffichageDepenses()
        {
            // Pour la grille des DEPENSES :

            // Formatage de la date pour la grille des dépenses
            if (dgvDepenses.Columns.Contains("dateD"))
            {
                dgvDepenses.Columns["dateD"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            // Masquage des colonnes inutiles pour l'utilisateur
            if (dgvDepenses.Columns.Contains("nomPlanete"))
            {
                dgvDepenses.Columns["nomPlanete"].Visible = false;
            }

            if (dgvDepenses.Columns.Contains("numeroMission"))
            {
                dgvDepenses.Columns["numeroMission"].Visible = false;
            }

            if (dgvDepenses.Columns.Contains("idTypeDepense"))
            {
                dgvDepenses.Columns["idTypeDepense"].Visible = false;
            }

            // Renommer les colonnes pour un affichage plus propre
            dgvDepenses.Columns["id"].HeaderText = "Numéro de dépense";
            dgvDepenses.Columns["dateD"].HeaderText = "Date de dépense";
            dgvDepenses.Columns["montant"].HeaderText = "Montant en €";
            dgvDepenses.Columns["motif"].HeaderText = "Motif";
            dgvDepenses.Columns["libelleType"].HeaderText = "Catégorie de la dépense";
            dgvDepenses.Columns["libelleType"].DisplayIndex = 6; // Pour choisir l'ordre d'affichage
        }
        private void InitContacts()
        {

            this.bsContacts = new BindingSource();
            this.bsContacts.DataSource = bsMissions;
            this.bsContacts.DataMember = "RelContacts";

            // Remplissage des DataGridView avec les Contacts :
            try
            {
                dgvInformateurs.DataSource = bsContacts;
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            AffichageContacts();
        }

        private void AffichageContacts()
        {
            // Pour la grille des CONTACTS : 

            // Formatage des dates : 
            if (dgvInformateurs.Columns.Contains("dateC"))
            {
                dgvInformateurs.Columns["dateC"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            // On rend invisible aux yeux de l'utilisateur les informations inutiles :
            if (dgvInformateurs.Columns.Contains("nomPlanete"))
            {
                dgvInformateurs.Columns["nomPlanete"].Visible = false;
            }

            if (dgvInformateurs.Columns.Contains("numeroMission"))
            {
                dgvInformateurs.Columns["numeroMission"].Visible = false;
            }

            if (dgvInformateurs.Columns.Contains("nomCodeInformateur"))
            {
                dgvInformateurs.Columns["nomCodeInformateur"].Visible = false;
            }

            // Renommer les colonnes pour un affichage plus propre :
            dgvInformateurs.Columns["dateC"].HeaderText = "Date du contact";
            dgvInformateurs.Columns["sommeVersee"].HeaderText = "Montant en €";
            dgvInformateurs.Columns["appreciation"].HeaderText = "Détail du contact";
            dgvInformateurs.Columns["libelleInformateur"].HeaderText = "Informateur";
            dgvInformateurs.Columns["libelleInformateur"].DisplayIndex = 6;

            foreach (DataRowView drv in this.bsContacts)
            {
                string dateC = drv["dateC"].ToString();
                string appreciation = drv["appreciation"].ToString();
                string nomInformateur = drv["libelleInformateur"].ToString();
                string objectif = drv["sommeVersee"].ToString();
                this.contactsInformateurs.Add($"Date du contact : {dateC}\nSomme versée : {objectif}\nDétail du contact : {appreciation}\nInformateur : {nomInformateur}");
            }
        }

        //Depart
        private void btnDepart_Click(object sender, EventArgs e)
        {
            //On vérifie si l'instance existe 
            if (bsJournal != null)
            {
                bsJournal.MoveFirst();
            }
            else
            {
                MessageBox.Show("ERREUR : Le journal n'est pas initialisé");
            }
        }

        // Précédent
        private void btnBefore_Click(object sender, EventArgs e)
        {
            //On vérifie si l'instance existe 
            if (bsJournal != null)
            {
                bsJournal.MovePrevious();
            }
            else
            {
                MessageBox.Show("ERREUR : Le journal n'est pas initialisé");
            }
            /*
            if (bsJournal.Position == bsJournal.Count - 1)
            {
                btnBefore.Enabled = false;
            }
            */
        }

        //Suivant
        private void btnAfter_Click(object sender, EventArgs e)
        {

            //On vérifie si l'instance existe 
            if (bsJournal != null)
            {
                bsJournal.MoveNext();
            }
            else
            {
                MessageBox.Show("ERREUR : Le journal n'est pas initialisé");
            }
        }

        // Fin
        private void btnEnd_Click(object sender, EventArgs e)
        {
            //On vérifie si l'instance existe 
            if (bsJournal != null)
            {
                bsJournal.MoveLast();
            }
            else
            {
                MessageBox.Show("ERREUR : Le journal n'est pas initialisé");
            }
        }

        private void CalculerTotaux()
        {
            double totalD = 0;
            double totalC = 0;

            // Calcul de la somme des dépenses (via le BindingSource bsDepenses)
            foreach (DataRowView drv in bsDepenses)
            {
                // On récupère la ligne réelle et on cumule le montant
                totalD += Convert.ToDouble(drv["montant"]);
            }

            // Somme des sommes versées aux informateurs (via le BindingSource bsContacts)
            foreach (DataRowView drv in bsContacts)
            {
                totalC += Convert.ToDouble(drv["sommeVersee"]);
            }

            // Affichage dans les labels
            lblTotSommes.Text += $" {totalC}€";
            lblTotDepenses.Text += $" {totalD}€";
            this.depenses = Convert.ToInt32(totalD); // Stockage pour le PDF
            this.sommeVersee = Convert.ToInt32(totalC); // Stockage pour le PDF
        }

        private void CreerTableBilanCapture()
        {

            // On vérifie si la table existe déjà pour la vider, sinon on la crée
            if (ds.Tables.Contains(nomTableBilan))
            {
                ds.Tables.Remove(nomTableBilan);
            }

            DataTable dtBilan = new DataTable(nomTableBilan);

            // Ajout des colonnes
            dtBilan.Columns.Add("Nom de l'espèce", typeof(string));
            dtBilan.Columns.Add("Objectif initial", typeof(int));
            dtBilan.Columns.Add("Nombre de captures réalisées", typeof(int));

            // Colonne calculée : (Captures / Objectif) * 100
            DataColumn colTaux = new DataColumn("Taux de réussite (%)", typeof(double));
            colTaux.Expression = "( [Nombre de captures réalisées] * 100 ) / [Objectif initial]";
            dtBilan.Columns.Add(colTaux);

            ds.Tables.Add(dtBilan);
        }

        private void RemplirTableBilan()
        {
            DataTable dtBilan = ds.Tables[nomTableBilan];
            string filtreMission = $"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}";

            // On récupère les objectifs pour cette mission
            DataRow[] tabObjectifs = ds.Tables["ObjectifCapture"].Select(filtreMission);

            foreach (DataRow rowObj in tabObjectifs)
            {
                int idEnnemi = Convert.ToInt32(rowObj["idEspeceEnnemi"]);
                int objectif = Convert.ToInt32(rowObj["objectif"]);

                // On cherche le nom de l'espèce (via la table Espece)
                DataRow rowEspece = ds.Tables["Espece"].Rows.Find(idEnnemi);
                string nomEspece = rowEspece != null ? rowEspece["nom"].ToString() : "Inconnue";

                // On cherche le nombre de captures réalisées (table Capturer)
                string filtreCaptures = filtreMission + $" AND idEspeceEnnemi = {idEnnemi}";
                object result = ds.Tables["Capturer"].Compute("SUM(nombre)", filtreCaptures);


                // définir le nombre de captures 
                int captures;

                if (result == DBNull.Value)
                {
                    // Si la base de données renvoie un résultat vide (cas d'un SUM sans lignes)
                    captures = 0;
                }
                else
                {
                    captures = Convert.ToInt32(result);
                }

                // Ajout de la ligne de synthèse
                dtBilan.Rows.Add(nomEspece, objectif, captures);
            }
        }

        private void AfficherBilan()
        {
            // Liaison de la table au BindingSource 
            this.bsBilan = new BindingSource();
            this.bsBilan.DataSource = ds.Tables[nomTableBilan];

            // Liaison de la grille au BindingSource
            dgvBilan.DataSource = this.bsBilan;

            // AJOUT POUR LE GRAPHIQUE

            // On vide le conteneur pour éviter les doublons lors d'un rafraîchissement
            flpGraphiques.Controls.Clear();

            DataTable dtBilan = ds.Tables[nomTableBilan];

            //On boucle sur chaque espèce présente dans le bilan de mission
            foreach (DataRow row in dtBilan.Rows)
            {
                string nomEspece = row["Nom de l'espèce"].ToString();

                string filtre = "nom = '" + nomEspece.Replace("'", "''") + "'";
                DataRow[] tabRows = ds.Tables["Espece"].Select(filtre);


                // A REMPLACER 
                string couleurEspece = "Inconnue";
                if (tabRows.Length > 0)
                {
                    couleurEspece = tabRows[0]["couleur"].ToString();
                }

                int captures = Convert.ToInt32(row["Nombre de captures réalisées"]);
                int objectif = Convert.ToInt32(row["Objectif initial"]);

                // Calcul du reste à capturer (pour la part vide du camembert)
                int reste = Math.Max(0, objectif - captures);

                //Création dynamique d'un composant Chart 
                Chart chartIndiv = new Chart();
                chartIndiv.Size = new Size(200, 200);
                chartIndiv.BackColor = Color.Transparent;

                // Zone de graphique
                ChartArea area = new ChartArea();
                chartIndiv.ChartAreas.Add(area);

                // Titre : Nom de l'espèce + le taux calculé 
                var titrePrincipal = chartIndiv.Titles.Add($"Taux de capture : {nomEspece} ({row["Taux de réussite (%)"]}%)");
                titrePrincipal.Font = new Font("Kristen ITC", 12, FontStyle.Underline);

                // Configuration de la série en type "Doughnut" (Anneau) ou Pie
                Series s = new Series("Taux");
                s.ChartType = SeriesChartType.Doughnut;

                if (reste <= 0)
                {
                    // CAS 100% CAPTURÉS : Une seule part verte
                    s.Points.AddXY("Capturés", captures);
                    s.Points[0].Color = ConvertirNomCouleur(couleurEspece);
                }
                else if (captures <= 0)
                {
                    // CAS 0% CAPTURÉS : Une seule part grise
                    s.Points.AddXY("Reste", reste);
                    s.Points[0].Color = Color.FromArgb(220, 220, 220);
                }
                else
                {
                    // CAS INTERMÉDIAIRE : On affiche les deux parts
                    s.Points.AddXY("Capturés", captures);
                    s.Points.AddXY("Reste", reste);    

                    s.Points[0].Color = ConvertirNomCouleur(couleurEspece);
                    s.Points[1].Color = Color.FromArgb(220, 220, 220);
                }

                chartIndiv.Series.Add(s);
                flpGraphiques.Controls.Add(chartIndiv);
                this.captures.Add($"Nom de l'espèce : {nomEspece}\nObjectif de capture : {objectif}\nCapturés : {captures}\nTaux de réussite de capture : {row["Taux de réussite (%)"]}%");
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

        private void GenererGraphiqueBudget()
        {
            //Récupération des données via le DataSet
            string filtreMission = $"nomPlanete = '{idPlanete}' AND numero = {idNumero}";
            string filtre = $"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}";

            // Budget initial
            DataRow[] mission = ds.Tables["Mission"].Select(filtreMission);
            double budgetInitial = Convert.ToDouble(mission[0]["budget"]);
            this.budgetInitial = budgetInitial.ToString(); // Stockage pour le PDF

            // Somme des dépenses
            object resDep = ds.Tables["Depense"].Compute("SUM(montant)", filtre);
            double totalDepenses = (resDep == DBNull.Value) ? 0 : Convert.ToDouble(resDep);

            // Somme des informateurs (table Contact)
            object resInf = ds.Tables["Contact"].Compute("SUM(sommeVersee)", filtre);
            double totalInformateurs = (resInf == DBNull.Value) ? 0 : Convert.ToDouble(resInf);

            double totalConsomme = totalDepenses + totalInformateurs;
            double reste = budgetInitial - totalConsomme;

            // Configuration du graphique
            chartBudget.Series.Clear();
            chartBudget.Titles.Clear();
            var titrePrincipal = chartBudget.Titles.Add("Utilisation du budget de la mission : "+this.idPlanete+"-"+this.idNumero);
            titrePrincipal.Font = new Font("Kristen ITC", 13, FontStyle.Underline);

            Series s = new Series("Budget");
            s.Font = new Font("Kristen ITC", 12);
            s.ChartType = SeriesChartType.Doughnut; // Forme d'anneau pour le design
            s.IsValueShownAsLabel = true;
            s.LabelFormat = "{0} €";

            lblEtatBudget.Font = new Font("Kristen ITC", 10, FontStyle.Bold);

            //Gestion du dépassement
            if (reste < 0)
            {
                // CAS => DÉPASSEMENT DE BUDGET
                double depassement = Math.Abs(reste);

                // On affiche la part des dépenses et informateurs
                s.Points.AddXY("Dépenses", totalDepenses);
                s.Points.AddXY("Informateurs", totalInformateurs);
                s.Points.AddXY("DÉPASSEMENT !", depassement);

                // Couleur rouge pour la part en trop
                s.Points[s.Points.Count - 1].Color = Color.Red;

                // Alerte visuelle sur le côté
                lblEtatBudget.Text = "ATTENTION : Budget dépassé !";
                lblEtatBudget.ForeColor = Color.Red;
            }
            else
            {
                // CAS => BUDGET Ok
                if (totalDepenses > 0)
                {
                    s.Points.AddXY("Dépenses", totalDepenses);
                }
                if (totalInformateurs > 0)
                {
                    s.Points.AddXY("Informateurs", totalInformateurs);
                }
                if (reste > 0)
                {
                    s.Points.AddXY("Disponible", reste);
                }

                // Couleurs normales
                lblEtatBudget.Text = "Budget sous contrôle";
                lblEtatBudget.ForeColor = Color.Green;

                // On colore la part "Disponible" en vert clair
                int idxDispo = s.Points.IndexOf(s.Points.FirstOrDefault(p => p.AxisLabel == "Disponible"));
                if (idxDispo != -1)
                {
                    s.Points[idxDispo].Color = Color.LightGreen;
                }
            }

            chartBudget.Series.Add(s);
        }


        // REQUETES SQL COMPLEXES SUR UNE MISSION (Volet 7) 

        public void GetDepensesMaximales()
        {
            // on creer une colonne MontantTri pour l'utiliser comme filtre après...
            string sql = $@"SELECT d.dateD || ' - ' || d.motif || ' - ' || d.montant || '€' AS 'Dépenses les plus importantes', m.nomPlanete AS 'Mission', chef.prenom || ' ' || chef.nom AS 'Chef de mission', d.montant AS 'MontantTri'
                   FROM Depense d JOIN Mission m ON d.nomPlanete = m.nomPlanete AND d.numeroMission = m.numero
                   JOIN Membre chef ON m.matriculeChef = chef.matricule
                   WHERE d.montant = (SELECT MAX(montant)
                                      FROM Depense d2
                                      WHERE d2.nomPlanete = d.nomPlanete AND d2.numeroMission = d.numeroMission)";
            
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                SQLiteDataReader dr = cmd.ExecuteReader();

                // On peut charger le résultat dans une DataTable pour l'afficher dans un DataGridView
                DataTable dt = new DataTable();
                dt.Load(dr);

                if (dt.Rows.Count > 0)
                {
                    dt.DefaultView.Sort = "MontantTri ASC";
                    dgvDepenses.DataSource = dt;

                    // On cache la colonne technique de tri pour l'ergonomie
                    dgvDepenses.Columns["MontantTri"].Visible = false;

                    // ON REND LA LIGNE DE LA MISSION ROUGEEEE
                    this.dgvDepenses.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvDepenses_CellFormatting);
                }
                else
                {
                    MessageBox.Show("Aucune dépense n'a été enregistrée pour cette mission.");
                }

            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur SQL : " + err.Message);
            }
        }


        private void dgvDepenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // On vérifie que la ligne en cours existe bien (bon index quoi) et que le datagridview possède une colonne Mission
            if (e.RowIndex >= 0 && dgvDepenses.Columns.Contains("Mission"))
            {
                // On récupère la valeur seulement si la colonne est trouvée
                var cellValue = dgvDepenses.Rows[e.RowIndex].Cells["Mission"].Value;

                if (cellValue != null && cellValue.ToString() == this.idPlanete)   // Si c'est la planète de la mission en cours 
                {
                    // Fond rouge et texte blanc pour détacher la ligne du reste
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Font = new Font(dgvDepenses.Font, FontStyle.Bold);
                }
            }
        }

        public void GetInformateursMoinsPayes(string planete, int numero)
        {
            SQLiteConnection connec = Connexion.Connec;

            // Requête complexe avec regroupement et filtre sur agrégation (HAVING)
            string sql = $@"SELECT i.nom AS [Nom de l'informateur], e.nom AS [Espece], SUM(c.sommeVersee) AS [Somme versée] FROM Informateur i
                            JOIN Espece e ON i.idEspeceEnnemi = e.id
                            JOIN Contact c ON i.nomCode = c.nomCodeInformateur
                            WHERE c.nomPlanete = @planete AND c.numeroMission = @num
                            GROUP BY i.nomCode, e.nom
                            HAVING SUM(c.sommeVersee) = (SELECT MIN(Total) FROM (SELECT SUM(sommeVersee) AS Total
                                                                                 FROM Contact
                                                                                 WHERE nomPlanete = @planete AND numeroMission = @num
                            GROUP BY nomCodeInformateur))";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, connec);
                // Utilisation de paramètres pour sécuriser la saisie (injection SQL) 
                cmd.Parameters.AddWithValue("@planete", planete);
                cmd.Parameters.AddWithValue("@num", numero);

                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                if (dt.Rows.Count > 0)
                {
                    dgvInformateurs.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Aucun contact enregistré pour cette mission.");
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors de la recherche des informateurs : " + err.Message);
            }
        }

        private void GetRentabiliteMission(string p, int n)
        {
            // Requête utilisant des sous-requêtes pour calculer les deux totaux indépendamment
            string sql = @"SELECT @p || '-' || @n AS Mission,(SELECT SUM(qteDataBaz) FROM Negocier WHERE nomPlanete=@p AND numeroMission=@n) AS 'DataBaz (kg)',
                   (SELECT SUM(montant) FROM Depense WHERE nomPlanete=@p AND numeroMission=@n) AS [Coût Total (€)],
                   ROUND((SELECT SUM(qteDataBaz) FROM Negocier WHERE nomPlanete=@p AND numeroMission=@n) / 
                         (SELECT SUM(montant) FROM Depense WHERE nomPlanete=@p AND numeroMission=@n), 3) AS 'Rentabilité (kg/€)'";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                cmd.Parameters.AddWithValue("@p", p);
                cmd.Parameters.AddWithValue("@n", n);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvBilan.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
        }

        //Filtres : 

        // ====> Code pour l'affichage du dgvBilan
        private void rdbCapturesEnnemies_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCapturesEnnemies.Checked)
            {
                dgvBilan.DataSource = null;
                dgvBilan.Columns.Clear();

                AfficherBilan();
            }
        }

        private void rdbRenta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRenta.Checked)
            {
                dgvBilan.DataSource = null;
                dgvBilan.Columns.Clear();

                GetRentabiliteMission(this.idPlanete, int.Parse(this.idNumero));
            }
        }

        // =====> Code d'appel et remplissage pour les dgv sur les Informateurs
        private void rdbInformateursMoinsPayees_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInformateurMoinsPayees.Checked)
            {
                dgvInformateurs.DataSource = null;
                dgvInformateurs.Columns.Clear();

                GetInformateursMoinsPayes(this.idPlanete, int.Parse(this.idNumero));
            }
        }

        private void rdbInf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInf.Checked)
            {
                dgvInformateurs.DataSource = null;
                dgvInformateurs.Columns.Clear();

                InitContacts();
            }
        }


        // ===> Code d'appel et remplissage pour les dgv sur les Dépenses 
        private void rdbListeDepenses_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbListeDepenses.Checked)
            {
                dgvDepenses.DataSource = null;
                dgvDepenses.Columns.Clear();

                InitDepenses();
            }
        }

        private void rrdDepensesMax_CheckedChanged(object sender, EventArgs e)
        {
            if (rrdDepensesMax.Checked)
            {
                dgvDepenses.DataSource = null;
                dgvDepenses.Columns.Clear();

                GetDepensesMaximales();
            }
        }


        // EDITER LE PDF
        private void btnEditerPDF_Click(object sender, EventArgs e)
        {
            FrmPDF fdm = new FrmPDF(this.nomMission, this.dateDepart, this.dateArrivee, this.nomChef, this.budgetInitial, this.txtFeuilleRoute, this.membres, this.nbJours, this.evenements, this.captures, this.depenses, this.sommeVersee, this.contactsInformateurs);
            DialogResult dr = fdm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
