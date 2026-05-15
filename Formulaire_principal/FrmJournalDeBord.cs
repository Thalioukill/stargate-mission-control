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
using static System.Windows.Forms.LinkLabel;

namespace Formulaire_principal
{
    public partial class FrmJournalDeBord : Form
    {

        private SQLiteConnection co = Connexion.Connec;

        //instanciation du DataSet
        private DataSet ds = MesDatas.DsGlobal;

        private string idPlanete;
        private string idNumero;

        // On déclare les BindingSources ici pour qu'ils soient accessibles partout dans le formulaire
        private BindingSource bsMissions;
        private BindingSource bsJournal;

        public FrmJournalDeBord()
        {
            InitializeComponent();
        }

        public FrmJournalDeBord(string planete, string numero)
        {
            InitializeComponent();
            this.idPlanete = planete;
            this.idNumero = numero;
        }

        private void FrmJournalDeBord_Load(object sender, EventArgs e)
        {
            InitBinding();
        }


        private void InitBinding()
        {
            DataTable dtMission = ds.Tables["Mission"];
            DataTable dtJournal = ds.Tables["JournalDeBord"];

            // On définit les colonnes parentes et enfants pour la clé
            DataColumn[] parentCols = { dtMission.Columns["nomPlanete"], dtMission.Columns["numero"] };
            DataColumn[] childCols = { dtJournal.Columns["nomPlanete"], dtJournal.Columns["numero"] };

            // Création de la relation "MissionEvents"
            DataRelation rel = new DataRelation("MissionEvents", parentCols, childCols);
            ds.Relations.Add(rel);


            //2. Configuration des BindingSources
            this.bsMissions = new BindingSource();

            // liaison à la DataTable Mission du ds
            bsMissions.DataSource = ds.Tables["Mission"];
            // Appliquer un tri par défaut (ex: par date de départ)
            bsMissions.Sort = "dateDepart DESC";

            // IMPORTANCE : On filtre pour ne garder que la mission consultée
            bsMissions.Filter = $"nomPlanete = '{this.idPlanete}' AND numero = {this.idNumero}";

            // BindingSource Détail (le Journal)
            // On le lie au BS Maître en utilisant le nom de la Relation
            BindingSource bsJournal = new BindingSource();
            bsJournal.DataSource = bsMissions;
            bsJournal.DataMember = "MissionEvents";
            try
            {
                //Liaison aux composants(Labels / TextBox)
                lblDateEvenement.DataBindings.Add("Text", bsJournal, "dateJ");
                lblCommentaire.DataBindings.Add("Text", bsJournal, "commentaires");
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            bsJournal.MoveLast();
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            bsJournal.MovePrevious();
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            bsJournal.MoveNext();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bsJournal.MoveFirst();
        }
    }
}
