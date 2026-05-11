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

            try
            {
                string sql = @"SELECT (me.nom || ' ' || me.prenom || ' : Civil - ' || ci.Specialite) 
                            AS nomComplet, me.matricule FROM Membre me
                            JOIN Civil ci ON
                            me.matricule = ci.matriculeMembre
                            WHERE me.matricule LIKE 'C%'";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, co);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                string sql2 = @"SELECT (me.nom || ' ' || me.prenom || ' : Militaire - ' || mi.grade) 
                            AS nomComplet, me.matricule FROM Membre me
                            JOIN Militaire mi ON
                            me.matricule = mi.matriculeMembre
                            WHERE me.matricule LIKE 'M%'";
                SQLiteDataAdapter da2 = new SQLiteDataAdapter(sql2, co);
                DataTable dtMilitaires = new DataTable();
                da2.Fill(dtMilitaires);

                dt.Merge(dtMilitaires);
                cboMembres.DataSource = dt;
                cboMembres.DisplayMember = "nomComplet";
                cboMembres.ValueMember = "matricule";

            }
            catch (SQLiteException err)
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
            lblChoix.ForeColor = SystemColors.ControlDark;
            lblNomMission.ForeColor = SystemColors.ControlDark;
            
            foreach (Control c in pnl.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.ForeColor = SystemColors.ControlText;
                }

            }
               
            
            cboChef.Enabled = true;
            txtfeuilleRoute.Enabled = true;
            txtBudget.Enabled = true;
            txtnbMembres.Enabled = true;
            txtobjDataBaz.Enabled = true;
            dtpDepart.Enabled = true;
            dtpRetour.Enabled = true;
            btnValidMission.Enabled = true;
            cboChef.Focus();
        }

        private void btnValidMission_Click(object sender, EventArgs e)
        {
            if (dtpDepart.Value > dtpRetour.Value)
            {
                MessageBox.Show("La date de départ ne peut pas être après la date de retour, et la date de retour ne peut pas être avant la date de départ !");
                
            }
            else if(txtBudget.Text == "" || txtobjDataBaz.Text == "" || txtnbMembres.Text == "" || txtfeuilleRoute.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs pour insérer une mission.");
            }
            else
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
                    lstbMembres.Items.Add(cboChef.Text);
                    cboMembres.Focus();
                    cboChef.Enabled = false;
                    dtpDepart.Enabled = false;
                    dtpRetour.Enabled = false;
                    txtfeuilleRoute.Enabled = false;
                    txtBudget.Enabled = false;
                    txtnbMembres.Enabled = false;
                    txtobjDataBaz.Enabled = false;
                    btnValidMission.Enabled = false;

                    foreach (Control c in pnl.Controls)
                    {
                        if (c is Label lbl)
                            lbl.ForeColor = SystemColors.ControlDark;
                    }
                    //Reset();

                }
                catch (SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                    MessageBox.Show("Echec de l'ajout !");
                }
            }
        }

        private void txtnbMembres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //On refuse tout
            e.Handled = true;

            //On réouvre si chiffre ou contrôle uniquement
            if(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled=false;
            }
            if (e.KeyChar == 13)
            {
                txtobjDataBaz.Focus();
            }
        }

        private void txtobjDataBaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            //On refuse tout
            e.Handled = true;

            //On réouvre si chiffre ou contrôle uniquement
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                txtBudget.Focus();
            }
        }

        private void txtBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            //On refuse tout
            e.Handled = true;

            //On réouvre si chiffre ou contrôle uniquement
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            if (e.KeyChar == 13)
            {
                btnValidMission_Click(sender, e);
            }
        }

        private void cboPlanete_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si on appuie sur la touche entrée ...
            if (e.KeyChar == 13)
            {
                btnValidPlanete_Click(sender, e);
            }
        }

        private void Reset()
        {
            cboPlanete.SelectedIndex = -1;
            cboChef.SelectedIndex = -1;

            txtfeuilleRoute.Clear();
            txtobjDataBaz.Clear();
            txtnbMembres.Clear();
            txtBudget.Clear();

            dtpDepart.Value = DateTime.Now;
            dtpRetour.Value = DateTime.Now;

            cboPlanete.Enabled = true;
            btnValidPlanete.Enabled = true;

            cboChef.Enabled = false;
            dtpDepart.Enabled = false;
            dtpRetour.Enabled = false;
            txtfeuilleRoute.Enabled = false;
            txtBudget.Enabled = false;
            txtnbMembres.Enabled = false;
            txtobjDataBaz.Enabled = false;
            btnValidMission.Enabled = false;

            foreach (Control c in pnl.Controls)
            {
                if (c is Label lbl)
                    lbl.ForeColor = SystemColors.ControlDark;
            }
            lblChoix.ForeColor = SystemColors.ControlText;
            cboPlanete.Focus();
        }

        private void cboMembres_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbPartis.Items.Clear();
            string texteDecoup = cboMembres.Text;
            int deuxpt = texteDecoup.IndexOf(':');
            if (deuxpt != -1)
                lblnomMembre.Text = texteDecoup.Substring(0, deuxpt -1) + " est déjà parti(e) en mission avec :";
            else
                lblnomMembre.Text = texteDecoup + " est déjà parti(e) en mission avec :";

            try
            {
                string sql = @"SELECT co.matriculeMembre FROM Composer co
                            WHERE (co.numeroMission, co.nomPlanete) IN
                            (SELECT co2.numeroMission, co2.nomPlanete FROM Composer co2 
                             WHERE co2.matriculeMembre = @matricule)
                            AND co.matriculeMembre != @matricule";

                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                cmd.Parameters.AddWithValue("@matricule",cboMembres.SelectedValue.ToString());

                SQLiteDataReader dr = cmd.ExecuteReader();

                if(dr.HasRows)
                {
                    while (dr.Read())
                    {

                        string matricule = dr[0].ToString();

                        //cboMembres.DataSource est une table
                        DataTable dt = (DataTable)cboMembres.DataSource;
                        //J'utilise un filtre pour garder les lignes de la table voulues
                        DataRow[] rows = dt.Select($"matricule = '{matricule}'");

                        if (rows.Length > 0)
                        {
                            lstbPartis.Items.Add(rows[0]["nomComplet"].ToString());
                        }
                    }
                }
            }
            catch(SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            
        }

        private void btnAddMembre_Click(object sender, EventArgs e)
        {
            if(!lstbMembres.Items.Contains(cboMembres.Text))
            {
                lstbMembres.Items.Add(cboMembres.Text);
            }
            else
            {
                MessageBox.Show($"{cboMembres.Text} déjà présent dans la liste !");
            }
            
        }

        private void btnRefaire_Click(object sender, EventArgs e)
        {
            if (!lstbMembres.Items.Contains(cboMembres.Text))
            {
                lstbMembres.Items.Add(cboMembres.Text);
            }
            else
            {
                MessageBox.Show($"{cboMembres.Text} déjà présent dans la liste !");
            }
            foreach (string i in lstbPartis.Items)
            {
                if (!lstbMembres.Items.Contains(i))
                {
                    lstbMembres.Items.Add(i);
                }
                else
                {
                    MessageBox.Show($"{i} déjà présent dans la liste !");
                }
                
            }
        }
    }
}
