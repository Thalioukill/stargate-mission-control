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
            panel1.Controls.Clear();
            try
            {
                string sql = "SELECT count(*) FROM Allie";
                SQLiteCommand cmd = new SQLiteCommand(sql, this.co);
                int nbAlliees = Convert.ToInt32(cmd.ExecuteScalar());
                sql = "SELECT min(idEspece) FROM Allie";
                cmd = new SQLiteCommand(sql, this.co);
                int idMin = Convert.ToInt32(cmd.ExecuteScalar());
                int xpicture = 6;
                int ypicture = 23;
                int xlabel = 3;
                int ynom = 97;
                int ybienveillance = 114;
                int ycouleur = 131;
                int yplanete = 148;
                int yinstrument = 163;
                int nbAffiches = 0;
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
                        PictureBox picAlliees = new PictureBox();
                        picAlliees.Location = new System.Drawing.Point(xpicture, ypicture);
                        picAlliees.Name = "picAlliees";
                        picAlliees.Size = new System.Drawing.Size(107, 71);
                        picAlliees.TabIndex = 0;
                        picAlliees.TabStop = false;
                        picAlliees.Image = Image.FromFile("C:\\Users\\yanno\\Pictures\\Screenshots\\Capture d'écran 2026-01-28 101236.png");
                        panel1.Controls.Add(picAlliees);

                        Label lblNomAlliees = new Label();
                        lblNomAlliees.AutoSize = true;
                        lblNomAlliees.Location = new System.Drawing.Point(xlabel, ynom);
                        lblNomAlliees.Name = "lblNomAlliees";
                        lblNomAlliees.Size = new System.Drawing.Size(65, 17);
                        lblNomAlliees.TabIndex = 1;
                        lblNomAlliees.Text = dr["nom"].ToString();
                        panel1.Controls.Add(lblNomAlliees);

                        Label lblBienveillance = new Label();
                        lblBienveillance.AutoSize = true;
                        lblBienveillance.Location = new System.Drawing.Point(xlabel, ybienveillance);
                        lblBienveillance.Name = "lblBienveillance";
                        lblBienveillance.Size = new System.Drawing.Size(103, 17);
                        lblBienveillance.TabIndex = 2;
                        lblBienveillance.Text = "Bienveillance : " + dr["degreBienveillance"].ToString();
                        panel1.Controls.Add(lblBienveillance);

                        Label lblCouleurAlliees = new Label();
                        lblCouleurAlliees.AutoSize = true;
                        lblCouleurAlliees.Location = new System.Drawing.Point(xlabel, ycouleur);
                        lblCouleurAlliees.Name = "lblCouleurAlliees";
                        lblCouleurAlliees.Size = new System.Drawing.Size(57, 17);
                        lblCouleurAlliees.TabIndex = 5;
                        lblCouleurAlliees.Text = dr["couleur"].ToString();
                        panel1.Controls.Add(lblCouleurAlliees);

                        Label lblPlaneteAlliees = new Label();
                        lblPlaneteAlliees.AutoSize = true;
                        lblPlaneteAlliees.Location = new System.Drawing.Point(xlabel, yplanete);
                        lblPlaneteAlliees.Name = "lblPlaneteAlliees";
                        lblPlaneteAlliees.Size = new System.Drawing.Size(56, 17);
                        lblPlaneteAlliees.TabIndex = 3;
                        if(dr["Planetes"] == DBNull.Value)
                        {
                            lblPlaneteAlliees.Text = "Origine inconnue";
                        }
                        else 
                        {
                            lblPlaneteAlliees.Text = dr["Planetes"].ToString();
                        }
                        panel1.Controls.Add(lblPlaneteAlliees);

                        Label lblInstrument = new Label();
                        lblInstrument.AutoSize = true;
                        lblInstrument.Location = new System.Drawing.Point(xlabel, yinstrument);
                        lblInstrument.Name = "lblInstrument";
                        lblInstrument.Size = new System.Drawing.Size(74, 17);
                        lblInstrument.TabIndex = 4;
                        lblInstrument.Text = dr["instrumentMusique"].ToString();
                        panel1.Controls.Add(lblInstrument);

                        nbAffiches++;
                        xpicture = xpicture + 150;
                        xlabel = xlabel + 150;
                        if (nbAffiches % 3 == 0)
                        {
                            xpicture = 6;
                            xlabel = 3;
                            ypicture = ypicture + 200;
                            ynom = ynom + 200;
                            ybienveillance = ybienveillance + 200;
                            ycouleur = ycouleur + 200;
                            yplanete = yplanete + 200;
                            yinstrument = yinstrument + 200;
                        }
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
            panel2.Controls.Clear();
            try
            {
                string sql = "SELECT count(*) FROM Ennemi";
                SQLiteCommand cmd = new SQLiteCommand(sql, this.co);
                int nbEnnemis = Convert.ToInt32(cmd.ExecuteScalar());
                sql = "SELECT min(idEspece) FROM Ennemi";
                cmd = new SQLiteCommand(sql, this.co);
                int idMin = Convert.ToInt32(cmd.ExecuteScalar());
                int xpicture = 6;
                int ypicture = 23;
                int xlabel = 3;
                int ynom = 97;
                int yagressivite = 114;
                int ycouleur = 131;
                int yplanete = 148;
                int ytypeArme = 163;
                int nbAffiches = 0;
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
                        PictureBox picEnnemis = new PictureBox();
                        picEnnemis.Location = new System.Drawing.Point(xpicture, ypicture);
                        picEnnemis.Name = "picEnnemis";
                        picEnnemis.Size = new System.Drawing.Size(107, 71);
                        picEnnemis.TabIndex = 0;
                        picEnnemis.TabStop = false;
                        picEnnemis.Image = Image.FromFile("C:\\Users\\yanno\\Pictures\\Screenshots\\Capture d'écran 2026-01-28 101236.png");
                        panel2.Controls.Add(picEnnemis);

                        Label lblNomEnnemis = new Label();
                        lblNomEnnemis.AutoSize = true;
                        lblNomEnnemis.Location = new System.Drawing.Point(xlabel, ynom);
                        lblNomEnnemis.Name = "lblNomEnnemis";
                        lblNomEnnemis.Size = new System.Drawing.Size(100, 23);
                        lblNomEnnemis.TabIndex = 1;
                        lblNomEnnemis.Text = dr["nom"].ToString();
                        panel2.Controls.Add(lblNomEnnemis);

                        Label lblAgressivite = new Label();
                        lblAgressivite.AutoSize = true;
                        lblAgressivite.Location = new System.Drawing.Point(xlabel, yagressivite);
                        lblAgressivite.Name = "lblAgressivite";
                        lblAgressivite.Size = new System.Drawing.Size(103, 17);
                        lblAgressivite.TabIndex = 2;
                        lblAgressivite.Text = "Agressivité : " + dr["degreAgressivite"].ToString();
                        panel2.Controls.Add(lblAgressivite);

                        Label lblCouleurEnnemis = new Label();
                        lblCouleurEnnemis.AutoSize = true;
                        lblCouleurEnnemis.Location = new System.Drawing.Point(xlabel, ycouleur);
                        lblCouleurEnnemis.Name = "lblCouleurEnnemis";
                        lblCouleurEnnemis.Size = new System.Drawing.Size(57, 17);
                        lblCouleurEnnemis.TabIndex = 5;
                        lblCouleurEnnemis.Text = dr["couleur"].ToString();
                        panel2.Controls.Add(lblCouleurEnnemis);

                        Label lblPlaneteEnnemis = new Label();
                        lblPlaneteEnnemis.AutoSize = true;
                        lblPlaneteEnnemis.Location = new System.Drawing.Point(xlabel, yplanete);
                        lblPlaneteEnnemis.Name = "lblPlaneteEnnemis";
                        lblPlaneteEnnemis.Size = new System.Drawing.Size(56, 17);
                        lblPlaneteEnnemis.TabIndex = 3;
                        if (dr["Planetes"] == DBNull.Value)
                        {
                            lblPlaneteEnnemis.Text = "Origine inconnue";
                        }
                        else
                        {
                            lblPlaneteEnnemis.Text = dr["Planetes"].ToString();
                        }
                        panel2.Controls.Add(lblPlaneteEnnemis);
                        
                        Label lblTypeArme = new Label();
                        lblTypeArme.AutoSize = true;
                        lblTypeArme.Location = new System.Drawing.Point(xlabel, ytypeArme);
                        lblTypeArme.Name = "lblTypeArme";
                        lblTypeArme.Size = new System.Drawing.Size(74, 17);
                        lblTypeArme.TabIndex = 4;
                        lblTypeArme.Text = dr["typeArme"].ToString();
                        panel2.Controls.Add(lblTypeArme);

                        nbAffiches++;
                        xpicture = xpicture + 150;
                        xlabel = xlabel + 150;
                        if (nbAffiches % 3 == 0)
                        {
                            xpicture = 6;
                            xlabel = 3;
                            ypicture = ypicture + 200;
                            ynom = ynom + 200;
                            yagressivite = yagressivite + 200;
                            ycouleur = ycouleur + 200;
                            yplanete = yplanete + 200;
                            ytypeArme = ytypeArme + 200;
                        }
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
