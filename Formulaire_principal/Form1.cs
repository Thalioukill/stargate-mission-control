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
            FrmTableauDeBord ftdb = new FrmTableauDeBord();
            DialogResult dr = ftdb.ShowDialog();
        }
    }
}
