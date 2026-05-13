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

        //instanciation du DataSet

        private DataSet ds = MesDatas.DsGlobal;

        public FrmAliens()
        {
            InitializeComponent();
        }

        private void chargerAliensAlliees()
        {
            flp1.Controls.Clear();
            try
            {
                string sql = "SELECT count(*) FROM Allie";
                SQLiteCommand cmd = new SQLiteCommand(sql, this.co);
                int nbAlliees = Convert.ToInt32(cmd.ExecuteScalar());
                sql = "SELECT min(idEspece) FROM Allie";
                cmd = new SQLiteCommand(sql, this.co);
                int idMin = Convert.ToInt32(cmd.ExecuteScalar());
                for (int i = idMin; i <= idMin + nbAlliees; i++)
                {
                    sql = $@"SELECT e.nom, a.degreBienveillance, e.couleur, GROUP_CONCAT(h.nomPlanete, '/') as Planetes, a.instrumentMusique
                            FROM Allie a
                            JOIN Espece e ON e.id = a.idEspece
                            LEFT JOIN Habiter h ON h.idEspece = e.id
                            WHERE a.idEspece = {i} AND e.nom LIKE '%{txtNomAlliees.Text}%' AND a.degreBienveillance LIKE '%{cboBienveillance.Text}%' AND e.couleur LIKE '%{cboCouleurAlliees.Text}%'
                            GROUP BY e.nom";
                    SQLiteCommand cmd2 = new SQLiteCommand(sql, this.co);
                    SQLiteDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        string nomAlien = dr["nom"].ToString();
                        string bienveillance = dr["degreBienveillance"].ToString();
                        string couleur = dr["couleur"].ToString();
                        string planete;

                        if (dr["Planetes"] == DBNull.Value)
                        {
                            planete = "Origine inconnue";
                        }
                        else
                        {
                            planete = dr["Planetes"].ToString();
                        }
                        string instrument = dr["instrumentMusique"].ToString();
                        string image = dr["nom"] + ".png";

                        InfoAliensAlliees info = new InfoAliensAlliees(nomAlien, bienveillance, couleur, planete, instrument, image);
                        flp1.Controls.Add(info);
                    }
                    dr.Close();
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void chargerAliensEnnemis()
        {
            flp2.Controls.Clear();
            try
            {
                string sql = "SELECT count(*) FROM Ennemi";
                SQLiteCommand cmd = new SQLiteCommand(sql, this.co);
                int nbEnnemis = Convert.ToInt32(cmd.ExecuteScalar());
                sql = "SELECT min(idEspece) FROM Ennemi";
                cmd = new SQLiteCommand(sql, this.co);
                int idMin = Convert.ToInt32(cmd.ExecuteScalar());
                for (int i = idMin; i <= idMin + nbEnnemis; i++)
                {
                    sql = $@"SELECT e.nom, en.degreAgressivite, e.couleur, GROUP_CONCAT(h.nomPlanete, '/') as Planetes, en.typeArme
                            FROM Ennemi en
                            JOIN Espece e ON e.id = en.idEspece
                            LEFT JOIN Habiter h ON h.idEspece = e.id
                            WHERE en.idEspece = {i} AND e.nom LIKE '%{txtNomEnnemis.Text}%' AND en.degreAgressivite LIKE '%{cboAgressivite.Text}%' AND e.couleur LIKE '%{cboCouleurEnnemis.Text}%' AND en.typeArme LIKE '%{cboTypeArme.Text}%'
                            GROUP BY e.nom";
                    SQLiteCommand cmd2 = new SQLiteCommand(sql, this.co);
                    SQLiteDataReader dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        string nomAlien = dr["nom"].ToString();
                        string bienveillance = dr["degreAgressivite"].ToString();
                        string couleur = dr["couleur"].ToString();
                        string planete;

                        if (dr["Planetes"] == DBNull.Value)
                        {
                            planete = "Origine inconnue";
                        }
                        else
                        {
                            planete = dr["Planetes"].ToString();
                        }
                        string instrument = dr["typeArme"].ToString();
                        string image = dr["nom"] + ".png";

                        InfoAliensEnnemis info = new InfoAliensEnnemis(nomAlien, bienveillance, couleur, planete, instrument, image);
                        flp2.Controls.Add(info);
                    }
                    dr.Close();
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void FrmAliens_Load(object sender, EventArgs e)
        {
            try
            {
                string sql;
                DataTable schemaTable = co.GetSchema("Tables");
                string liste = "";
                for (int i = 0; i < schemaTable.Rows.Count; i++)
                {
                    string nomTable = schemaTable.Rows[i][2].ToString();
                    sql = "SELECT * FROM " + nomTable;
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql, this.co);
                    da.Fill(ds, nomTable);
                    liste = liste + nomTable + "\n";
                }

                string sql2 = "SELECT DISTINCT couleur FROM Espece";
                SQLiteCommand cm2 = new SQLiteCommand(sql2, this.co);
                SQLiteDataReader dr2 = cm2.ExecuteReader();
                while (dr2.Read())
                {
                    cboCouleurAlliees.Items.Add(dr2["couleur"].ToString());
                    cboCouleurEnnemis.Items.Add(dr2["couleur"].ToString());
                }
                dr2.Close();

                string sql3 = "SELECT DISTINCT degreBienveillance FROM Allie ORDER BY degreBienveillance";
                SQLiteCommand cm3 = new SQLiteCommand(sql3, this.co);
                SQLiteDataReader dr3 = cm3.ExecuteReader();
                while (dr3.Read())
                {
                    cboBienveillance.Items.Add(dr3["degreBienveillance"].ToString());
                    cboAgressivite.Items.Add(dr3["degreBienveillance"].ToString());
                }
                dr3.Close();

                string sql5 = "SELECT DISTINCT typeArme FROM Ennemi ORDER BY typeArme";
                SQLiteCommand cm5 = new SQLiteCommand(sql5, this.co);
                SQLiteDataReader dr5 = cm5.ExecuteReader();
                while (dr5.Read())
                {
                    cboTypeArme.Items.Add(dr5["typeArme"].ToString());
                }
                dr5.Close();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            chargerAliensAlliees();
            chargerAliensEnnemis();
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
    }
}
