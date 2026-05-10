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
    public partial class FrmMission : Form
    {
        private SQLiteConnection co = Connexion.Connec;

        //instanciation du DataSet

        private DataSet ds = MesDatas.DsGlobal;
        public FrmMission()
        {
            InitializeComponent();
            cboChef.Enabled = false;
            txtfeuilleRoute.Enabled = false;
            dtpDepart.Enabled = false;
            dtpRetour.Enabled = false;
            btnValidMission.Enabled = false;

        }

        private void FrmMission_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT nom FROM Planete";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, co);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboPlanete.DataSource = dt;
                cboPlanete.DisplayMember = "nom";
                cboPlanete.ValueMember = "nom";
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            /*cboPlanete.DataSource = ds.Tables["Planete"];
            cboPlanete.DisplayMember = "nom";
            cboPlanete.ValueMember = "nom";
            cboPlanete.Focus();*/

            try
            {
                string sql = @"SELECT (me.nom || ' ' || me.prenom || ' - ' || mi.grade) 
                            AS nomComplet, me.matricule FROM Membre me
                            JOIN Militaire mi ON
                            me.matricule = mi.matriculeMembre
                            WHERE me.matricule LIKE 'M%'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, co);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboChef.DataSource = dt;
                cboChef.DisplayMember = "nomComplet";
                cboChef.ValueMember = "matricule";

            }
            catch(SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void cboPlanete_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string nomPlanete = cboPlanete.Text.ToString();
                int numMiss;
                string sql = $@"SELECT MAX(numero) FROM Mission WHERE 
                            nomPlanete = '{nomPlanete}'";

                SQLiteCommand cmd = new SQLiteCommand(sql, co);

                object resultat = cmd.ExecuteScalar();
                if (resultat != null && resultat != DBNull.Value)
                {
                    numMiss = (Convert.ToInt32(resultat.ToString()))+1;
                }
                else
                {
                    numMiss = 1;
                }
                lblNomMission.Text = $"Nom de mission: {nomPlanete}     -";
                lblNum.Text = numMiss.ToString();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnValidPlanete_Click(object sender, EventArgs e)
        {
            cboPlanete.Enabled = false;
            btnValidPlanete.Enabled = false;
            
            foreach (Control c in pnl.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.ForeColor = SystemColors.ControlText;
                }

            }
               
            
            cboChef.Enabled = true;
            txtfeuilleRoute.Enabled = true;
            dtpDepart.Enabled = true;
            dtpRetour.Enabled = true;
            btnValidMission.Enabled = true;
            cboChef.Focus();
        }

        private void btnValidMission_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"INSERT INTO Mission 
                              (nomPlanete, numero, nbMembreRequis, dateDepart, dateRetour, matriculeChef, feuilleDeRoute, objectifDatabaz, budget)
                              VALUES (@nomPlanete, @numero, @nbMembres, @dateDepart, @dateRetour, @matriculeChef, @feuilleRoute, @objDataBaz, @budget)";

                SQLiteCommand cmd = new SQLiteCommand(sql, co);

                cmd.Parameters.AddWithValue("@nomPlanete", cboPlanete.Text);
                cmd.Parameters.AddWithValue("@numero", lblNum.Text);
                cmd.Parameters.AddWithValue("@nbMembres", txtnbMembres.Text);
                cmd.Parameters.AddWithValue("@dateDepart", dtpDepart.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@dateRetour", dtpRetour.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@matriculeChef", cboChef.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@feuilleRoute", txtfeuilleRoute.Text);
                cmd.Parameters.AddWithValue("@objDataBaz", txtobjDataBaz.Text);
                cmd.Parameters.AddWithValue("@budget", txtBudget.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Mission ajoutée !");
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
                MessageBox.Show("Echec de l'ajout !");
            }


        }
    }
}
