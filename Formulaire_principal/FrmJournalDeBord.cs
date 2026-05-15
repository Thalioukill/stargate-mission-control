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

        public FrmJournalDeBord(string planete, string numero)
        {
            InitializeComponent();
            this.Text += planete.ToUpper() + "-" + numero;
            this.idPlanete = planete;
            this.idNumero = numero;
            this.nomTableBilan = $"BilanCapture{this.idPlanete.ToUpper()}-{this.idNumero}";
            CreerTableBilanCapture();
            RemplirTableBilan();
            AfficherBilan();
            InitBinding();
            CalculerTotaux();
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
            this.bsMissions.Sort = "dateDepart DESC";

            // IMPORTANCE : On filtre pour ne garder que la mission consultée
            this.bsMissions.Filter = $"nomPlanete = '{this.idPlanete}' AND numero = {this.idNumero}";


            // Configurations des Details (Journal de Bord, Depenses et Contacts)
            // On le lie au BS Maître (Mission) en utilisant le nom de la Relation
            this.bsJournal = new BindingSource();
            this.bsJournal.DataSource = bsMissions;
            this.bsJournal.DataMember = "RelJournalDeBord";
            
            /*
            if (dgvDepenses.Columns.Contains("dateJ"))
            {
                dgvDepenses.Columns["dateJ"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            */

            try
            {
                //Liaison aux composants(Labels / TextBox)
                lblDateEvenement.DataBindings.Add("Text", this.bsJournal, "dateJ");
                lblCommentaire.DataBindings.Add("Text", this.bsJournal, "commentaires");
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

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
            dgvDepenses.Columns["id"].HeaderText = "Numéro de dépense : ";
            dgvDepenses.Columns["dateD"].HeaderText = "Date de dépense : ";
            dgvDepenses.Columns["montant"].HeaderText = "Montant en € : ";
            dgvDepenses.Columns["motif"].HeaderText = "Motif : ";
            // On peut maintenant utiliser "libelleType" comme n'importe quelle autre colonne
            dgvDepenses.Columns["libelleType"].HeaderText = "Catégorie de la dépense : ";
            dgvDepenses.Columns["libelleType"].DisplayIndex = 6; // Pour choisir l'ordre d'affichage


            this.bsContacts = new BindingSource();
            this.bsContacts.DataSource = bsMissions;
            this.bsContacts.DataMember = "RelContacts";

            try
            {
                dgvContacts.DataSource = bsContacts;
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            // Formatage de la date pour la grille des contacts
            if (dgvContacts.Columns.Contains("dateC"))
            {
                dgvContacts.Columns["dateC"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            // Pour la grille des contacts
            if (dgvContacts.Columns.Contains("nomPlanete"))
            {
                dgvContacts.Columns["nomPlanete"].Visible = false;
            }  

            if (dgvContacts.Columns.Contains("numeroMission"))
            {
                dgvContacts.Columns["numeroMission"].Visible = false;
            }

            if (dgvContacts.Columns.Contains("nomCodeInformateur"))
            {
                dgvContacts.Columns["nomCodeInformateur"].Visible = false;
            }

            // Renommer les colonnes pour un affichage plus propre
            dgvContacts.Columns["dateC"].HeaderText = "Date du contact :  ";
            dgvContacts.Columns["sommeVersee"].HeaderText = "Montant en € : ";
            dgvContacts.Columns["appreciation"].HeaderText = "Détail du contact : ";
            // On peut maintenant utiliser "libelleType" comme n'importe quelle autre colonne
            dgvContacts.Columns["libelleInformateur"].HeaderText = "Informateur : ";
            dgvContacts.Columns["libelleInformateur"].DisplayIndex = 6; // Pour choisir l'ordre d'affichage
            
        }

        //Depart
        private void btnDepart_Click(object sender, EventArgs e)
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

        // Précédent
        private void btnBefore_Click(object sender, EventArgs e)
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

            if(bsJournal.Position == bsJournal.Count - 1)
            {
                btnBefore.Enabled = false;
            }
        }

        //Suivant
        private void btnAfter_Click(object sender, EventArgs e)
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

        // Fin
        private void btnEnd_Click(object sender, EventArgs e)
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
                // expression ternaire pour définir le nombre de captures 
                int captures = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);

                // Ajout de la ligne de synthèse
                dtBilan.Rows.Add(nomEspece, objectif, captures);
            }
        }

        private void AfficherBilan()
        {
            // On crée l'instance du BindingSource lié à notre table de synthèse
            this.bsBilan = new BindingSource();
            this.bsBilan.DataSource = ds.Tables[nomTableBilan];

            // On lie la grille au BindingSource
            dgvBilan.DataSource = this.bsBilan;
        }
    }
}
