using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Formulaire_principal
{
    public partial class FrmAliens : Form
    {
        private SQLiteConnection co = Connexion.Connec;

        private DataSet ds = MesDatas.DsGlobal;

        public FrmAliens()
        {
            InitializeComponent();
        }

        private void charger_dataset()
        {
            try
            {
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

                SQLiteDataAdapter daEspece = new SQLiteDataAdapter("SELECT * FROM Espece", co);
                if (ds.Tables.Contains("Espece")) ds.Tables["Espece"].Clear();
                daEspece.Fill(ds, "Espece");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors du chargement initial : " + err.Message);
            }
        }

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

                InfoAliensAlliees info = new InfoAliensAlliees(nom, bien, coul, planete, inst, image);
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

                    InfoAliensEnnemis info = new InfoAliensEnnemis(nomAlien, agressivite, couleur, planete, arme, image);
                    flp2.Controls.Add(info);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur filtrage ennemis : " + err.Message);
            }
        }
        

        private void FrmAliens_Load(object sender, EventArgs e)
        {
            try
            {
                charger_dataset();

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
    }
}
