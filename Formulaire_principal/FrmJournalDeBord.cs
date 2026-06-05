using System;
using System.Collections;
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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
            //InitDepenses();
            ChercherDepenses(idPlanete, Convert.ToInt32(idNumero));
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
            if (this.bsContacts.Count > 0)
            {
                // Pour la grille des CONTACTS : 
                dgvInformateurs.Visible = true;
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
                dgvInformateurs.Columns["sommeVersee"].HeaderText = "Montant en $";
                dgvInformateurs.Columns["appreciation"].HeaderText = "Détail du contact";
                dgvInformateurs.Columns["libelleInformateur"].HeaderText = "Informateur";
                dgvInformateurs.Columns["libelleInformateur"].DisplayIndex = 6;

                // Remplissage de la liste pour le PDF
                this.contactsInformateurs.Clear(); // On vide avant de remplir
                foreach (DataRowView drv in this.bsContacts)
                {
                    string dateC = drv["dateC"].ToString();
                    string appreciation = drv["appreciation"].ToString();
                    string nomInformateur = drv["libelleInformateur"].ToString();
                    string objectif = drv["sommeVersee"].ToString();
                    this.contactsInformateurs.Add($"Date du contact : {dateC}\nSomme versée : {objectif}\nDétail du contact : {appreciation}\nInformateur : {nomInformateur}");
                }
            }
            else
            {
                // Aucune info à mettre dans la grille
                dgvInformateurs.Visible = false;
                this.contactsInformateurs.Clear();
                lblPasDinformateurs.Text = "Aucun contact avec des informateurs n'a été enregistré pour cette mission.";
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
            

            // Somme des sommes versées aux informateurs (via le BindingSource bsContacts)
            foreach (DataRowView drv in bsContacts)
            {
                totalC += Convert.ToDouble(drv["sommeVersee"]);
            }

            // Affichage dans labels
            lblTotSommes.Text += $" {totalC}$";
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
                string nomEspece = "";

                if(rowEspece != null)
                {
                    nomEspece = rowEspece["nom"].ToString();
                }
                nomEspece = "Inconnue";

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
            lblPasInfosCaptures_renta.Visible = false;
            if (ds.Tables[nomTableBilan].Rows.Count > 0)
            {
                dgvBilan.Visible = true;
                dgvBilan.DataSource = ds.Tables[nomTableBilan];
            }
            else
            {
                dgvBilan.Visible = false;
                lblPasInfosCaptures_renta.Text = "Aucune capture n'a été enregistrée pour cette mission.";
                lblPasInfosCaptures_renta.Visible = true;
                lblPasInfosCaptures_renta.ForeColor = Color.FromArgb(255, 21, 64);
            }

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
                chartIndiv.Size = new Size(180, 180);

                // Zone de graphique
                ChartArea area = new ChartArea();
                chartIndiv.ChartAreas.Add(area);

                // Titre : Nom de l'espèce + le taux calculé 
                var titrePrincipal = chartIndiv.Titles.Add($"Taux de capture : {nomEspece} ({row["Taux de réussite (%)"]}%)");
                titrePrincipal.Font = new Font("Kristen ITC", 12, FontStyle.Underline);

                // Configuration de la série en type "Doughnut" (Anneau) ou Pie
                Series s = new Series("Taux");
                s.ChartType = SeriesChartType.Doughnut;
                s.Font = new Font("Kristen ITC", 9);

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
                default: return Color.Aquamarine; // Couleur par défaut si non trouvé
            }
        }

        private void GenererGraphiqueBudget()
        {
            // récup des données dans le DataSet
            string filtreBase = $"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}";
            string filtreMission = $"nomPlanete = '{idPlanete}' AND numero = {idNumero}";

            // Budget initial (Table Mission)
            DataRow[] mission = ds.Tables["Mission"].Select(filtreMission);
            double budgetInitial = (mission.Length > 0) ? Convert.ToDouble(mission[0]["budget"]) : 0;
            this.budgetInitial = budgetInitial.ToString(); // Stockage pour le rapport PDF

            // Extraction des 4 categ de TypeDepenses
            // On utilise .Compute sur le DataSet local pour chaque type

            // DataBaz (Type 1)
            object resDataBaz = ds.Tables["Depense"].Compute("SUM(montant)", filtreBase + " AND idTypeDepense = 1");
            double totalDataBaz = (resDataBaz == DBNull.Value) ? 0 : Convert.ToDouble(resDataBaz);

            // Réparation (Type 3)
            object resReparation = ds.Tables["Depense"].Compute("SUM(montant)", filtreBase + " AND idTypeDepense = 3");
            double totalReparation = (resReparation == DBNull.Value) ? 0 : Convert.ToDouble(resReparation);

            // Droit de passage (Type 4)
            object resPassage = ds.Tables["Depense"].Compute("SUM(montant)", filtreBase + " AND idTypeDepense = 4");
            double totalPassage = (resPassage == DBNull.Value) ? 0 : Convert.ToDouble(resPassage);

            // Informateurs (Table Contact - Somme versée)
            object resInf = ds.Tables["Contact"].Compute("SUM(sommeVersee)", filtreBase);
            double totalInformateurs = (resInf == DBNull.Value) ? 0 : Convert.ToDouble(resInf);

            // Calculs globaux
            double totalConsomme = totalDataBaz + totalReparation + totalPassage + totalInformateurs;
            double reste = budgetInitial - totalConsomme;

            //config du graphique
            chartBudget.Series.Clear();
            chartBudget.Titles.Clear();
            chartBudget.Legends.Clear();

            Legend lg = new Legend("Default");
            lg.Font = new Font("Kristen ITC", 8);
            lg.Docking = Docking.Right;
            chartBudget.Legends.Add(lg);

            /*chartBudget.ChartAreas.InnerPlotPosition.Auto = false;
            chartBudget.ChartAreas.InnerPlotPosition.Height = 85; // Ajustez selon vos besoins
            chartBudget.ChartAreas.InnerPlotPosition.Width = 85;
            chartBudget.ChartAreas.InnerPlotPosition.X = 7;
            chartBudget.ChartAreas.InnerPlotPosition.Y = 7;

            // On cible la PREMIÈRE zone de la collection 
            var area = chartBudget.ChartAreas;

            // On désactive le positionnement automatique
            area.InnerPlotPosition.Auto = false;

            // On définit la taille (ex: 85% de l'espace disponible)
            area.InnerPlotPosition.Height = 85;
            area.InnerPlotPosition.Width = 85;*/


            var titrePrincipal = chartBudget.Titles.Add("Analyse budgétaire de la mission : " + idPlanete + "-" + idNumero);
            titrePrincipal.Font = new Font("Kristen ITC", 13, FontStyle.Underline);

            Series s = new Series("Répartition");
            s.ChartType = SeriesChartType.Doughnut;
            s.Font = new Font("Kristen ITC", 8);
            s.IsValueShownAsLabel = true;
            s.LabelFormat = "{0}$";
            s["DoughnutRadius"] = "76";

            // Remplissage intelligent des points
            void AjouterPoint(string label, double valeur)
            {
                if (valeur > 0) { 
                    s.Points.AddXY(label, valeur); 
                }
            }

            AjouterPoint("DataBaz", totalDataBaz);
            AjouterPoint("Réparations", totalReparation);
            AjouterPoint("Droits passage", totalPassage);
            AjouterPoint("Informateurs", totalInformateurs);

            // Gestion du dépassement ou du disponible
            if (reste < 0)
            {
                // CAS => DÉPASSEMENT
                double depassement = Math.Abs(reste);
                int idx = s.Points.AddXY("DÉPASSEMENT !", depassement);
                s.Points[idx].Color = Color.Red; // alerteeeee
                s.Points[idx].Font = new Font("Kristen ITC", 12, FontStyle.Bold);

                lblEtatBudget.Text = "ATTENTION : Budget dépassé !";
                lblEtatBudget.ForeColor = Color.Red;
            }
            else if (reste > 0)
            {
                // CAS => BUDGET OK
                int idxDispo = s.Points.AddXY("Disponible", reste);
                s.Points[idxDispo].Color = Color.LightGreen; // Vert pour la sécurité

                lblEtatBudget.Text = "Budget sous contrôle";
                lblEtatBudget.ForeColor = Color.Green;
            }

            chartBudget.Series.Add(s);
        }


        // REQUETES SQL COMPLEXES SUR UNE MISSION (Volet 7) 

        public void GetDepensesMaximales()
        {
            lblPasDeResultat.Visible = false;
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
            lblPasDinformateurs.Visible = false;

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
                    dgvInformateurs.Visible = true;
                }
                else
                {
                    dgvInformateurs.Visible = false;
                    lblPasDinformateurs.Text = "Aucun contact enregistré pour cette mission.";
                    lblPasDinformateurs.ForeColor = Color.FromArgb(255, 21, 64);
                    lblPasDinformateurs.Visible = true;
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur lors de la recherche des informateurs : " + err.Message);
            }
        }

        private void GetTauxInvestissement(string p, int n)
        {
            lblPasInfosCaptures_renta.Visible = false;

            // Requête utilisant des sous-requêtes pour calculer les deux totaux indépendamment
            string sql = $@"SELECT @p || '-' || @n AS Mission, m.budget AS 'Budget Total ($)', (SELECT SUM(montant) FROM Depense WHERE nomPlanete = @p AND numeroMission = @n AND idTypeDepense = 1) AS 'Investi en DataBaz ($)',
                            ROUND((SELECT SUM(montant) FROM Depense WHERE nomPlanete = @p AND numeroMission = @n AND idTypeDepense = 1) * 100.0 / m.budget, 2) AS 'Taux d''investissement (%)'
                            FROM Mission m
                            WHERE m.nomPlanete = @p AND m.numero = @n";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                cmd.Parameters.AddWithValue("@p", p);
                cmd.Parameters.AddWithValue("@n", n);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count > 0 && dt.Rows[0]["Investi en DataBaz ($)"] != DBNull.Value)
                {

                    dgvBilan.DataSource = dt;
                    dgvBilan.Visible = true;
                }
                else
                {
                    dgvBilan.Visible = false;
                    lblPasInfosCaptures_renta.Text = "Aucune dépense concernant le Databaz n'a été enregistrée pour cette mission.";
                    lblPasInfosCaptures_renta.ForeColor = Color.FromArgb(255, 21, 64);
                    lblPasInfosCaptures_renta.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
        }



        private void GetReussiteObjectif(string p, int n)
        {
            lblPasInfosCaptures_renta.Visible = false;

            // Requête utilisant des sous-requêtes pour calculer les deux totaux indépendamment
            string sql = $@"SELECT @p || '-' || @n AS Mission,m.objectifDatabaz AS 'Objectif (kg)', IFNULL((SELECT SUM(qteDataBaz) FROM Negocier 
                                                                                                                 WHERE nomPlanete=@p AND numeroMission=@n), 0) AS 'Récupéré (kg)',ROUND(IFNULL((SELECT SUM(qteDataBaz) FROM Negocier 
                                                                                                                                                                                                             WHERE nomPlanete=@p AND numeroMission=@n), 0) * 100.0 / m.objectifDatabaz, 2) AS 'Réussite Objectif (%)'
                            FROM Mission m
                            WHERE m.nomPlanete = @p AND m.numero = @n";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                cmd.Parameters.AddWithValue("@p", p);
                cmd.Parameters.AddWithValue("@n", n);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count > 0)
                {

                    dgvBilan.DataSource = dt;
                    dgvBilan.Visible = true;
                }
                else
                {
                    dgvBilan.Visible = false;
                    lblPasInfosCaptures_renta.Text = "Aucune dépense concernant le Databaz n'a été enregistrée pour cette mission.";
                    lblPasInfosCaptures_renta.ForeColor = Color.FromArgb(255, 21, 64);
                    lblPasInfosCaptures_renta.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
        }

        public void ChercherDepenses(string nom, int num)
        {
            double totalCumule = 0;

            // calcul du budget actuel + "filtre" sur le nombre de membres (> 10)
            // On utilise LEFT JOIN pour avoir les budgets même si 0 dépenses sont enregistrées
            string sql = $@"SELECT m.budget AS 'budgetInitial', (m.budget - IFNULL((SELECT SUM(montant) 
                                                                 FROM Depense WHERE nomPlanete = m.nomPlanete AND numeroMission = m.numero), 0)) AS 'budgetActuel', d.id, d.dateD, d.motif, d.montant, td.libelle
                            FROM Mission m
                            JOIN Depense d ON m.nomPlanete = d.nomPlanete AND m.numero = d.numeroMission
                            JOIN TypeDepense td ON d.idTypeDepense = td.id
                            WHERE m.nomPlanete = @nom 
                            AND m.numero = @num
                            AND m.nbMembreRequis > 10";

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@num", num);

                SQLiteDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Columns.Add("Budget Initial", typeof(string));
                dt.Columns.Add("Budget Actuel", typeof(string)); 
                dt.Columns.Add("Numéro de dépense", typeof(string)); 
                dt.Columns.Add("Date de dépense", typeof(string)); 
                dt.Columns.Add("Motif", typeof(string)); 
                dt.Columns.Add("Montant en $", typeof(string)); 
                dt.Columns.Add("Catégorie de la dépense", typeof(string)); 
                //dt.Load(dr);

                int i = 1;

                while (dr.Read())
                {                    
                    DataRow dataR = dt.NewRow();

                    dataR[0] = dr[0].ToString();
                    dataR[1] = dr[1].ToString();
                    dataR[2] = i;

                    if (dr["dateD"] != DBNull.Value)
                    {
                        dataR[3] = DateTime.Parse(dr["dateD"].ToString()).ToShortDateString();
                    }

                    dataR[4] = dr[4].ToString();

                    // logique de clcul total
                    if (dr["montant"] != DBNull.Value)
                    {
                        double montantLigne = Convert.ToDouble(dr["montant"]);
                        totalCumule += montantLigne; // On additionne chaque montant
                        dataR[5] = montantLigne.ToString() + " $"; // Affichage propre dans la grille
                    }
                    dataR[6] = dr[6].ToString();

                    // IMPORTANT : N'oubliez pas d'ajouter la ligne créée à votre DataTable !
                    dt.Rows.Add(dataR);

                    i++;

                }

                lblBudgetInitial.Visible = true;
                lblBudgetActuel.Visible = true;
                lblPasDeResultat.Visible = false;
                lblTotalDepenses.Visible = false;

                if (dt.Rows.Count > 0)
                {
                    // Si + de 10 membres
                    dgvDepenses.Visible = true;

                    // Mise à jour des labels de budget avec la première ligne du résultat

                    lblBudgetInitial.Text = "★ Budget initial : "+dt.Rows[0]["Budget Initial"].ToString() + " $";
                    lblBudgetActuel.Text = "★ Budget actuel : "+dt.Rows[0]["Budget Actuel"].ToString() + " $";


                    dgvDepenses.DataSource = dt;

                    if (dgvDepenses.Columns.Contains("Budget Initial"))
                    {
                        dgvDepenses.Columns["Budget Initial"].Visible = false;
                    }

                    if (dgvDepenses.Columns.Contains("Budget Actuel"))
                    {
                        dgvDepenses.Columns["Budget Actuel"].Visible = false;
                    }
                    // AFFICHAGE DU TOTAL CALCULÉ
                    lblTotalDepenses.Text = $"Total des dépenses : {totalCumule} $";
                    lblTotalDepenses.Visible = true;

                }
                else
                {
                    // si < 10 membres (ou mission inexistante)
                    dgvDepenses.DataSource = null;
                    dgvDepenses.Visible = false;

                    lblBudgetInitial.Text = "★ Budget initial : N/C";
                    lblBudgetActuel.Text = "★ Budget actuel : N/C";

                    // On remplit l'ErrorProvider pour avertir l'utilisateur
                    lblPasDeResultat.Text = "Accès refusé : Les détails financiers sont réservés aux missions \ndisposant d'un équipage de plus de 10 membres.";
                    lblPasDeResultat.Visible = true;
                    lblPasDeResultat.ForeColor = Color.FromArgb(255, 21, 64);
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur SQL : " + err.Message);
            }
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
            if (rdbTauxInvestissement.Checked)
            {
                dgvBilan.DataSource = null;
                dgvBilan.Columns.Clear();

                GetTauxInvestissement(this.idPlanete, int.Parse(this.idNumero));
            }
        }



        private void rdbReussiteObjectifs_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbReussiteObjectifs.Checked)
            {
                dgvBilan.DataSource = null;
                dgvBilan.Columns.Clear();

                GetReussiteObjectif(this.idPlanete, int.Parse(this.idNumero));
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

                ChercherDepenses(idPlanete, Convert.ToInt32(idNumero));
            }
        }

        private void rrdDepensesMax_CheckedChanged(object sender, EventArgs e)
        {
            if (rrdDepensesMax.Checked)
            {
                lblBudgetInitial.Visible = false;
                lblBudgetActuel.Visible = false;
                dgvDepenses.DataSource = null;
                dgvDepenses.Columns.Clear();

                GetDepensesMaximales();
                dgvDepenses.Visible = true;
            }
        }


        // EDITER LE PDF
        private void btnEditerPDF_Click(object sender, EventArgs e)
        {
            FrmPDF fdm = new FrmPDF(this.nomMission, this.dateDepart, this.dateArrivee, this.nomChef, this.budgetInitial, this.txtFeuilleRoute, this.membres, this.nbJours, this.evenements, this.captures, this.depenses, this.sommeVersee, this.contactsInformateurs);
            DialogResult dr = fdm.ShowDialog();
        }
    }
}
