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
    public struct ListItem
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public struct ListItemMembre
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public partial class FrmMission : Form
    {
        private SQLiteTransaction trans;

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
            foreach(Control c in pnl2.Controls)
            {
                if(c is Button btn)
                {
                    btn.Enabled = false;
                }
                if (c is ListBox lst)
                {
                    lst.Enabled = false;
                }
                if (c is ComboBox cbo)
                {
                    cbo.Enabled = false;
                }
            }
            foreach(Control c in pnl3.Controls)
            {
                if(c is Button btn)
                {
                    btn.Enabled = false;
                }
                if(c is ComboBox cbo)
                {
                    cbo.Enabled = false;
                }
                if(c is NumericUpDown nud)
                {
                    nud.Enabled = false;
                }
                if(c is ListBox lst)
                {
                    lst.Enabled = false;
                }
            }
            
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
            lblChoix.ForeColor = SystemColors.ControlDark;
            lblNomMission.ForeColor = SystemColors.ControlDark;
            lblNum.ForeColor = SystemColors.ControlDark;
            
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
            if (dtpDepart.Value.Date.CompareTo(dtpRetour.Value.Date) > 0)
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

                    ListItemMembre li = new ListItemMembre { Name = cboChef.Text, Value = cboChef.SelectedValue.ToString() };
                    lstbMembres.Items.Add(li);
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
                    lblreste.Text = (int.Parse(txtnbMembres.Text)-1).ToString();
                    RemplirCboMembres();
                    cboMembres_SelectedIndexChanged(sender, e);
                    PartieQuatreVisible();

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
            {
                lblnomMembre.Text = texteDecoup.Substring(0, deuxpt - 1) + " est déjà parti(e) en mission avec :";
            }
            else
            {
                lblnomMembre.Text = texteDecoup + " est déjà parti(e) en mission avec :";
            }
            try
            {
                string sql = @"SELECT DISTINCT co.matriculeMembre FROM Composer co
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
                        string matricule;

                        if(dr.IsDBNull(0))
                        {
                            continue;
                        }
                        else
                        {
                            matricule = dr[0].ToString();
                        }
                        if(matricule.StartsWith("M"))
                        {
                            string sql2 = $@"SELECT (me.nom || ' ' || me.prenom || ' : Militaire - ' || mi.grade) 
                                        AS nomComplet FROM Membre me
                                        JOIN Militaire mi ON
                                        me.matricule = mi.matriculeMembre
                                        WHERE me.matricule != '{cboChef.SelectedValue.ToString()}' AND me.matricule = '{matricule}'";
                            SQLiteCommand cmd2 = new SQLiteCommand (sql2, co);
                            SQLiteDataReader dr2 = cmd2.ExecuteReader();
                            while(dr2.Read())
                            {
                                ListItemMembre li = new ListItemMembre { Name = dr2[0].ToString() , Value = matricule };
                                lstbPartis.Items.Add(li);
                            }

                        }
                        else if(matricule.StartsWith("C"))
                        {
                            string sql3 = $@"SELECT (me.nom || ' ' || me.prenom || ' : Civil - ' || ci.Specialite) 
                                            AS nomComplet, me.matricule FROM Membre me
                                            JOIN Civil ci ON
                                            me.matricule = ci.matriculeMembre
                                            WHERE me.matricule = '{matricule}'";

                            SQLiteCommand cmd3 = new SQLiteCommand(sql3, co);
                            SQLiteDataReader dr3 = cmd3.ExecuteReader();
                            while (dr3.Read())
                            {
                                ListItemMembre li = new ListItemMembre { Name = dr3[0].ToString(), Value = matricule };
                                lstbPartis.Items.Add(li);
                            }
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
            int reste = int.Parse(lblreste.Text);
            if (reste > 0)
            {
                List<string> values = new List<string>();
                ListItemMembre li = new ListItemMembre { Name = cboMembres.Text, Value = cboMembres.SelectedValue.ToString() };
                for (int i = 0; i < lstbMembres.Items.Count; i++)
                {
                    values.Add(((ListItemMembre)lstbMembres.Items[i]).Value);
                }
                if (!values.Contains(li.Value))
                {
                    reste -= 1;
                    lblreste.Text = reste.ToString();
                    lstbMembres.Items.Add(li);
                }
                else
                {
                    MessageBox.Show($"{cboMembres.Text} déjà présent dans la liste !");
                }
            }
            else
            {
                MessageBox.Show("Tous les membres ont déjà été ajoutés !");
                
            }
            
        }

        private void btnRefaire_Click(object sender, EventArgs e)
        {
            if(lstbPartis.Items.Count == 0)
            {
                MessageBox.Show("Aucun modèle d'équipe disponible !");
            }
            else
            {
                int reste = int.Parse(lblreste.Text);
                int reste2 = int.Parse(txtnbMembres.Text);

                if (reste2 >= lstbPartis.Items.Count + 1 && (reste - lstbPartis.Items.Count) > 0)
                {
                    while (lstbMembres.Items.Count > 1)
                    {
                        lstbMembres.Items.RemoveAt(1);
                    }
                    ListItemMembre li = new ListItemMembre { Name = cboMembres.Text, Value = cboMembres.SelectedValue.ToString() };
                    lstbMembres.Items.Add(li);
                    reste -= 1;
                    reste -= lstbPartis.Items.Count;
                    lblreste.Text = reste.ToString();
                    foreach (ListItemMembre li2 in lstbPartis.Items)
                    {

                        lstbMembres.Items.Add(li2);

                    }
                }

                else
                {
                    MessageBox.Show("Impossible de refaire la même équipe (trop de membres) !");
                }
            }
            
            
            
        }

        private void btnvalidMembres_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"INSERT INTO Composer (nomPlanete,numeroMission,matriculeMembre) VALUES
                            (@nomPlanete, @numeroMission, @matriculeMembre)";
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                cmd.Parameters.AddWithValue("nomPlanete", cboPlanete.Text);
                cmd.Parameters.AddWithValue("numeroMission", lblNum.Text);
                cmd.Parameters.AddWithValue("matriculeMembre", cboChef.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

            for (int i = 1; i < lstbMembres.Items.Count; i++)
            {
                try
                {

                    string sql = @"INSERT INTO Composer (nomPlanete,numeroMission,matriculeMembre) VALUES
                            (@nomPlanete, @numeroMission, @matriculeMembre)";

                    

                    SQLiteCommand cmd = new SQLiteCommand(sql, co);
                    cmd.Parameters.AddWithValue("nomPlanete", cboPlanete.Text);
                    cmd.Parameters.AddWithValue("numeroMission", lblNum.Text);
                    cmd.Parameters.AddWithValue("matriculeMembre", ((ListItemMembre)lstbMembres.Items[i]).Value);
                    cmd.ExecuteNonQuery();
                }
                catch(SQLiteException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            MessageBox.Show("Membres ajoutés !");
            RemplirCboCapture();
            PartieCinqueVisible();

        }

        private void btnAddSelect_Click(object sender, EventArgs e)
        {
            bool tousajoutes = false;
            if (lstbPartis.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un ou plusieurs élément(s) dans la liste ci-dessus.");

            }
            else
            {
                List<string> values = new List<string>();
                for (int i = 0; i < lstbMembres.Items.Count; i++)
                {
                    values.Add(((ListItemMembre)lstbMembres.Items[i]).Value);
                }
                
                foreach (ListItemMembre li in lstbPartis.SelectedItems)
                {
                    int reste = int.Parse(lblreste.Text);
                    if (reste > 0)
                    {
                        if (!values.Contains(li.Value))
                        {
                            reste -= 1;
                            lblreste.Text = reste.ToString();
                            lstbMembres.Items.Add(li);
                        }
                        else
                        {
                            MessageBox.Show($"{li.Name} déjà présent dans la liste !");
                        }
                    }
                    else
                    {
                        tousajoutes = true;
                    } 
                }
                if(tousajoutes)
                {
                    MessageBox.Show("Tous les membres ont déjà été ajoutés !");
                }
            }
        }

        private void btnSuppSelect_Click(object sender, EventArgs e)
        {
            List<ListItemMembre> remove = new List<ListItemMembre>();
            if (lstbMembres.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un ou plusieurs élément(s) dans la liste ci-dessus.");

            }
            else
            {
                foreach (ListItemMembre li in lstbMembres.SelectedItems)
                {
                    if(li.Value == cboChef.SelectedValue.ToString())
                    {
                        MessageBox.Show("Impossible d'enlever le chef de mission de l'équipe ! \n (un peu de bon sens)");
                    }
                    else
                    {
                        remove.Add(li);
                    }         
                }
                foreach(ListItemMembre li2 in remove)
                {
                    int reste = int.Parse(lblreste.Text);
                    reste += 1;
                    lblreste.Text = reste.ToString();
                    lstbMembres.Items.Remove(li2);
                }
            }
            
        }

        private void RemplirCboMembres()
        {
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

                string sql2 = $@"SELECT (me.nom || ' ' || me.prenom || ' : Militaire - ' || mi.grade) 
                            AS nomComplet, me.matricule FROM Membre me
                            JOIN Militaire mi ON
                            me.matricule = mi.matriculeMembre
                            WHERE me.matricule != '{cboChef.SelectedValue.ToString()}' AND me.matricule LIKE 'M%'";
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

        private void RemplirCboCapture()
        {
            try
            {
                string sql = @"SELECT (nom || ' - ' || couleur) AS nomComplet, 
                                id FROM Espece";

                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, co);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboCapture.DataSource = dt;
                cboCapture.DisplayMember = "nomComplet";
                cboCapture.ValueMember = "id";
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void PartieQuatreVisible()
        {
            foreach (Control c in pnl2.Controls)
            {
                if (c is Button btn)
                {
                    btn.Enabled = true;
                }
                if(c is ComboBox cbo)
                {
                    cbo.Enabled = true;
                }
                if (c is Label lbl)
                {
                    lbl.ForeColor = SystemColors.ControlText;
                }
                if(c is ListBox lst)
                {
                    lst.Enabled = true;
                }
                    
            }
            foreach(Control c in pnl.Controls)
            {
                if (c is Button btn)
                {
                    btn.Enabled = false;
                }
                if (c is Label lbl)
                {
                    lbl.ForeColor = SystemColors.ControlDark;
                }
                if(c is TextBox txt)
                {
                    txt.Enabled = false;
                }
                if(c is DateTimePicker dtp)
                {
                    dtp.Enabled = false;
                }
            }
        }

        private void PartieCinqueVisible()
        {
            foreach (Control c in pnl3.Controls)
            {
                if (c is Button btn)
                {
                    btn.Enabled = true;
                }
                if (c is ComboBox cbo)
                {
                    cbo.Enabled = true;
                }
                if (c is NumericUpDown nud)
                {
                    nud.Enabled = true;
                }
                if (c is ListBox lst)
                {
                    lst.Enabled = true;
                }
                if (c is Label lbl)
                {
                    lbl.ForeColor = SystemColors.ControlText;
                }
            }
            foreach (Control c in pnl2.Controls)
            {
                if (c is Button btn)
                {
                    btn.Enabled = false;
                }
                if (c is ComboBox cbo)
                {
                    cbo.Enabled = false;
                }
                if (c is Label lbl)
                {
                    lbl.ForeColor = SystemColors.ControlDark;
                }
                if (c is ListBox lst)
                {
                    lst.SelectedIndex = -1;
                    lst.Enabled = false;
                }

            }
        }

        private void btnAddCapture_Click(object sender, EventArgs e)
        {
            List<int> values = new List<int>();
            string texte = cboCapture.Text + "--> objectif de capture : " + nud1.Value.ToString();
            ListItem li = new ListItem { Name = texte, Value = int.Parse(cboCapture.SelectedValue.ToString()) };
            for (int i = 0; i < lstbCapture.Items.Count; i++)
            {
                values.Add(((ListItem)lstbCapture.Items[i]).Value);
            }
            if (!values.Contains(li.Value))
            {
                lstbCapture.Items.Add(li);
            }
            else
            {
                MessageBox.Show("Espèce déjà présente dans la liste !");
            }
            
        }

        private void btnValidObj_Click(object sender, EventArgs e)
        {
            this.trans = co.BeginTransaction();

            try
            {
                for (int i = 0; i < lstbCapture.Items.Count; i++)
                {
                    int id = ((ListItem)lstbCapture.Items[i]).Value;

                    string sql = @"INSERT INTO Capturer (nomPlanete,numeroMission,idEspeceEnnemi,nombre)
                            VALUES (@nomPlanete,@numeroMission,@idEspeceEnnemi,@nombre)";

                    SQLiteCommand cmd = new SQLiteCommand(sql, co);

                    cmd.Parameters.AddWithValue("@nomPlanete", cboPlanete.Text);
                    cmd.Parameters.AddWithValue("numeroMission", lblNum.Text);
                    cmd.Parameters.AddWithValue("@idEspeceEnnemi", id);
                    cmd.Parameters.AddWithValue("@nombre", int.Parse(nud1.Value.ToString()));

                    cmd.ExecuteNonQuery();
                    
                }
                trans.Commit();
                MessageBox.Show("Objectifs de capture enregistrés !");
                MettreaJourDS();
                
            }
            catch (SQLiteException err)
            {
                trans.Rollback();
                MessageBox.Show(err.Message);
            }

        }

        private void btnSuppSelectCapt_Click(object sender, EventArgs e)
        {
            List<ListItem> remove = new List<ListItem>();
            if (lstbCapture.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un ou plusieurs élément(s) dans la liste ci-contre.");

            }
            else
            {
                foreach (ListItem elt in lstbCapture.SelectedItems)
                {
                     remove.Add(elt);
                }
                foreach (ListItem elt2 in remove)
                {
                    lstbCapture.Items.Remove(elt2);
                }
            }
        }

        private void MettreaJourDS()
        {
            if (ds.Tables.Contains("Mission"))
            {
                ds.Tables["Mission"].Clear();
            }
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Mission", co);
            da.Fill(ds, "Mission");

            if (ds.Tables.Contains("Composer"))
            {
                ds.Tables["Composer"].Clear();
            }
            SQLiteDataAdapter da2 = new SQLiteDataAdapter("SELECT * FROM Composer", co);
            da2.Fill(ds, "Composer");

            if (ds.Tables.Contains("Capturer"))
            {
                ds.Tables["Capturer"].Clear();
            }
            SQLiteDataAdapter da3 = new SQLiteDataAdapter("SELECT * FROM Capturer", co);
            da3.Fill(ds, "Composer");

            MessageBox.Show("Tout est bon de notre côté, tous les détails de votre mission ont été validés !");
            this.DialogResult = DialogResult.OK;
        }

        
    }
}
