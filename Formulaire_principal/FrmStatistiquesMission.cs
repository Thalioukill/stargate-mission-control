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
    public partial class FrmStatistiquesMission : Form
    {
        private SQLiteConnection co = Connexion.Connec;

        //instanciation du DataSet
        private DataSet ds = MesDatas.DsGlobal;

        private string idPlanete;
        private string idNum;
        public FrmStatistiquesMission()
        {
            InitializeComponent();
        }

        public FrmStatistiquesMission(string planete, string numero)
        {
            InitializeComponent();
            this.idPlanete = planete;
            this.idNum = numero;
        }

        public void GetDepensesMaximales()
        {

            string sql = $@"SELECT d.dateD || ' - ' || d.motif || ' - ' || d.montant || '€' AS 'Dépenses les plus importantes', m.nomPlanete AS 'Mission', chef.prenom || ' ' || chef.nom AS 'Chef de mission'
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
                dgvStatistiques.DataSource = dt;

            }
            catch (SQLiteException err)
            {
                MessageBox.Show("Erreur SQL : " + err.Message);
            }
        }

        public void GetInformateursMoinsPayes(string planete, int numero)
        {
            SQLiteConnection connec = Connexion.Connec;

            // Requête complexe avec regroupement et filtre sur agrégation (HAVING)
            string sql = $@"SELECT i.nomCode, e.nom AS Espece, SUM(c.sommeVersee) AS SommeTotale FROM Informateur i
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
                    dgvStatistiques.DataSource = dt;
                else
                    MessageBox.Show("Aucun contact enregistré pour cette mission.");
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
                   (SELECT SUM(montant) FROM Depense WHERE nomPlanete=@p AND numeroMission=@n) AS 'Coût Total (€)',
                   ROUND((SELECT SUM(qteDataBaz) FROM Negocier WHERE nomPlanete=@p AND numeroMission=@n) / 
                         (SELECT SUM(montant) FROM Depense WHERE nomPlanete=@p AND numeroMission=@n), 3) AS 'Rentabilité (kg/€)'";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                cmd.Parameters.AddWithValue("@p", p);
                cmd.Parameters.AddWithValue("@n", n);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvStatistiques.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
        }

        private void GetComparaisonBudgets()
        {
            string sql = @"SELECT nomPlanete || '-' || numero AS Mission, budget AS 'Budget Initial', (SELECT IFNULL(SUM(montant), 0) FROM Depense d 
                           WHERE d.nomPlanete = m.nomPlanete AND d.numeroMission = m.numero) AS 'Dépenses', budget - (SELECT IFNULL(SUM(montant), 0) FROM Depense d 
                             WHERE d.nomPlanete = m.nomPlanete AND d.numeroMission = m.numero) AS 'Solde Restant' FROM Mission m";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvStatistiques.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void GetSuccesGlobalCaptures()
        {
            string sql = @"SELECT (SELECT SUM(objectif) FROM ObjectifCapture) AS 'Total Objectifs',(SELECT SUM(nombre) FROM Capturer) AS 'Captures Réalisées', ROUND((SELECT SUM(nombre) FROM Capturer) * 100.0 / (SELECT SUM(objectif) FROM ObjectifCapture), 2) || '%' AS 'Taux de Succès'";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvStatistiques.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FrmStatistiquesMission_Load(object sender, EventArgs e)
        {

        }

        private void rdbRentabilite_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRentabilite.Checked)
            {
                // Nettoyage
                dgvStatistiques.DataSource = null;
                dgvStatistiques.Columns.Clear();

                GetRentabiliteMission(this.idPlanete, int.Parse(this.idNum));
            }
        }

        private void rdbDepensesMax_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDepensesMax.Checked)
            {
                dgvStatistiques.DataSource = null;
                dgvStatistiques.Columns.Clear();

                GetDepensesMaximales();
            }
        }

        private void rdbInformateursMoinsPayes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInformateursMoinsPayes.Checked)
            {
                dgvStatistiques.DataSource = null;
                dgvStatistiques.Columns.Clear();

                GetInformateursMoinsPayes(this.idPlanete, int.Parse(this.idNum));
            }
        }

        private void rdbComparaisonBudget_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbComparaisonBudget.Checked)
            {
                dgvStatistiques.DataSource = null;
                dgvStatistiques.Columns.Clear();

                GetComparaisonBudgets();
            }
        }

        private void rdbSuccesGlobal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSuccesGlobal.Checked)
            {
                dgvStatistiques.DataSource = null;
                dgvStatistiques.Columns.Clear();

                GetSuccesGlobalCaptures();
            }
        }
    }
}
