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
    public struct ListItemCapture
    {
        /*Structure pour permettre aux éléments de la listBox lstbCapture 
        d'être attaché à un nom (ce qui sera affiché dans la liste) et une valeur (id de l'espèce).*/
        public string Name { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public struct ListItemMembre
    {
        /*Structure pour permettre aux éléments de la listBox lstbMembres
        d'être attaché à un nom (ce qui sera affiché dans la liste) et une valeur (matricule du membre).*/
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

            //Désactivation des composants de la deuxième partie
            
            foreach(Control c in pnlSection2.Controls)
            {
                c.Enabled = false;
            }
            foreach (Control c in pnlSection3.Controls)
            {
                c.Enabled = false;
            }
        }

        private void FrmMission_Load(object sender, EventArgs e)
        {
            //Chargement des comboBoxs cboPlanete et cboChef au démarrage de l'application
            RemplirCboPlanete();
            RemplirCboChef();
        }

        private void cboPlanete_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dès qu'on change d'index dans la cboPlanete, le nom de la mission change
            try
            {
                string nomPlanete = cboPlanete.Text.ToString();
                int numMiss;
                //Le numéro de notre mission sera le plus grand numéro associé à la planète choisie + 1
                string sql = $@"SELECT MAX(numero) FROM Mission WHERE 
                            nomPlanete = '{nomPlanete}'";

                SQLiteCommand cmd = new SQLiteCommand(sql, co);

                //On récup d'abord un objet resultat et on s'assure qu'il est non nul
                //Sinon notre numéro sera 1 (première mission associée à la planète)
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
            cboChef.Focus();
        }

        private void btnValidMission_Click(object sender, EventArgs e)
        {
            //instance.CompareTo(object value)
            //si < 0 alors instance précède value
            //si = 0 alors instance à la même position que value en terme de trie
            //si > 0 alors instance est après value
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
                    //On insère notre mission dans la base
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

                    //On insère d'office le chef de mission dans la listBox lstbMembres sous forme de ListItemMembre
                    //(Il fera forcément parti des membres de la mission)
                    ListItemMembre li = new ListItemMembre { Name = cboChef.Text, Value = cboChef.SelectedValue.ToString() };
                    lstbMembres.Items.Add(li);
                    cboMembres.Focus();

                    //Le reste des membres à affecter
                    lblreste.Text = (int.Parse(txtnbMembres.Text)-1).ToString();

                    //On rempli les prochaines comboBoxs
                    RemplirCboMembres();
                    cboMembres_SelectedIndexChanged(sender, e);
                    RemplirCboCapture();

                    //On rends la partie 4 utilisable et on désactive la partie 2 - 3
                    PartieDeuxUtilisable();

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

        //Pour la navigation au clavier avec les flèches
        private void txtfeuilleRoute_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtnbMembres.Focus();
            }
        }

        private void txtnbMembres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtobjDataBaz.Focus();
            }
            if(e.KeyCode == Keys.Up)
            {
                txtfeuilleRoute.Focus();
            }
        }

        private void txtobjDataBaz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtBudget.Focus();
            }
            if(e.KeyCode== Keys.Up)
            {
                txtnbMembres.Focus();
            }
        }

        private void txtBudget_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
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

        private void cboMembres_SelectedIndexChanged(object sender, EventArgs e)
        {
            //A chaque changement d'index, les membres déjà partis avec la personne sélectionnée changent
            lstbPartis.Items.Clear();

            //On extrait le nomComplet du membre pour avoir juste son nom et prénom
            string texteDecoup = cboMembres.Text;
            int deuxpt = texteDecoup.IndexOf(':');
            if (deuxpt != -1)
            {
                lblNomMembre.Text = texteDecoup.Substring(0, deuxpt - 1) + " est déjà parti(e) en mission avec :";
            }
            else
            {
                lblNomMembre.Text = texteDecoup + " est déjà parti(e) en mission avec :";
            }
            try
            {
                //Requête imbriquée pour select les membres déjà partis en missions avec la personne sélectionnée
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
                            //S'il n'y a pas de résultat, dr.Read continue
                            continue;
                        }
                        else
                        {
                            matricule = dr[0].ToString();
                        }
                        //Si c'est un militaire
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
                                //On ajoute dans lstbPartis sous forme de ListItemMembre
                                ListItemMembre li = new ListItemMembre { Name = dr2[0].ToString() , Value = matricule };
                                lstbPartis.Items.Add(li);
                            }

                        }
                        //Si c'est un civil
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
                                //On ajoute dans lstbPartis sous forme de ListItemMembre
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
            //On ajoute le membre sélectionné dans cboMembres dans lstbMembres sous forme de ListItemMembre
            //On vérifie s'il reste des membres à ajouter
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
                //On ajoute les membres de lstbPartis dans lstbMembres
                int reste = int.Parse(lblreste.Text);
                int reste2 = int.Parse(txtnbMembres.Text);

                //On vérifie si on a demandé assez de membre dans la mission pour refaire l'équipe ou s'il reste des membres à ajouter
                if (reste2 >= lstbPartis.Items.Count + 1 && (reste - lstbPartis.Items.Count) > 0)
                {
                    //On retire tout de lstbMembres sauf le chef à l'index 0
                    while (lstbMembres.Items.Count > 1)
                    {
                        lstbMembres.Items.RemoveAt(1);
                    }
                    ListItemMembre li = new ListItemMembre { Name = cboMembres.Text, Value = cboMembres.SelectedValue.ToString() };
                    lstbMembres.Items.Add(li);
                    reste --;
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
            if(int.Parse(lblreste.Text) != 0)
            {
                MessageBox.Show("Il reste des membres à ajouter");
            }
            else
            {
                try
                {
                    //On insère le chef de la mission dans la base 
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
            }
            

            //On insère nos membres dans la base 
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
            PartieTroisUtilisable();
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
                //On mets les valeurs de nos ListItemMembre de lstbMembres dans une liste
                List<string> values = new List<string>();
                for (int i = 0; i < lstbMembres.Items.Count; i++)
                {
                    values.Add(((ListItemMembre)lstbMembres.Items[i]).Value);
                }
                
                //On peut comparer pour chaque valeur de lstbPartis si elle ne correspond pas à une valeur de notre liste
                //Sinon, membre déjà présent
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
            //Pour supprimer une sélcetion de lstbMembres
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

        private void btnAddCapture_Click(object sender, EventArgs e)
        {
            //Pour ajouter une capture à lstbCaptures, on créé un ListItemCapture à partir de notre sélection dans cboCaptures
            List<int> values = new List<int>();
            string texte = cboCaptures.Text + "--> objectif de capture : " + nud1.Value.ToString();
            ListItemCapture li = new ListItemCapture { Name = texte, Value = int.Parse(cboCaptures.SelectedValue.ToString()) };
            for (int i = 0; i < lstbCaptures.Items.Count; i++)
            {
                values.Add(((ListItemCapture)lstbCaptures.Items[i]).Value);
            }
            if (!values.Contains(li.Value))
            {
                lstbCaptures.Items.Add(li);
            }
            else
            {
                MessageBox.Show("Espèce déjà présente dans la liste !");
            }
            
        }

        private void btnValidObj_Click(object sender, EventArgs e)
        {
            //Démarrage de la transaction (une erreur -> on annule toutes les insertions)
            this.trans = co.BeginTransaction();

            try
            {
                //On insère nos objectifs dans la base
                for (int i = 0; i < lstbCaptures.Items.Count; i++)
                {
                    int id = ((ListItemCapture)lstbCaptures.Items[i]).Value;

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

                //On a tout renseigné, on peut mettre à jour le data set
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
            //Pour supprimer un objectif de lstbCaptures
            List<ListItemCapture> remove = new List<ListItemCapture>();
            if (lstbCaptures.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un ou plusieurs élément(s) dans la liste ci-contre.");

            }
            else
            {
                foreach (ListItemCapture elt in lstbCaptures.SelectedItems)
                {
                     remove.Add(elt);
                }
                foreach (ListItemCapture elt2 in remove)
                {
                    lstbCaptures.Items.Remove(elt2);
                }
            }
        }

        private void RemplirCboPlanete()
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
        }

        private void RemplirCboChef()
        {
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
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
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
                cboCaptures.DataSource = dt;
                cboCaptures.DisplayMember = "nomComplet";
                cboCaptures.ValueMember = "id";
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void PartieDeuxUtilisable()
        {
            foreach (Control c in pnlSection2.Controls)
            {
                c.Enabled = true;

                if (c is Label lbl)
                {
                    lbl.ForeColor = SystemColors.ControlText;
                }

            }
            foreach (Control c in pnlSection1.Controls)
            {
                c.Enabled = false;

                if (c is Label lbl)
                {
                    lbl.ForeColor = SystemColors.ControlDark;
                }
            }

        }

        private void PartieTroisUtilisable()
        {
            foreach (Control c in pnlSection3.Controls)
            {
                c.Enabled = true;

                if (c is Label lbl)
                {
                    lbl.ForeColor = SystemColors.ControlText;
                }
            }
            foreach (Control c in pnlSection2.Controls)
            {
                c.Enabled = false;

                if (c is Label lbl)
                {
                    lbl.ForeColor = SystemColors.ControlDark;
                }

            }
            
        }

        private void MettreaJourDS()
        {
            //On vide les tables qu'on a changé du data set et on mets les nouvelles à la place
            if (ds.Tables.Contains("Mission"))
            {
                ds.Tables["Mission"].Clear();
            }
            string sqlMiss = "SELECT * FROM Mission";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sqlMiss, co);
            da.Fill(ds, "Mission");

            if (ds.Tables.Contains("Composer"))
            {
                ds.Tables["Composer"].Clear();
            }
            string sqlComp = "SELECT * FROM Composer";
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(sqlComp, co);
            da2.Fill(ds, "Composer");

            if (ds.Tables.Contains("Capturer"))
            {
                ds.Tables["Capturer"].Clear();
            }
            string sqlCapt = "SELECT * FROM Capturer";
            SQLiteDataAdapter da3 = new SQLiteDataAdapter(sqlCapt, co);
            da3.Fill(ds, "Composer");

            MessageBox.Show($"Tout est bon de notre côté, tous les détails de la mission {cboPlanete.Text}{lblNum.Text} ont été validés !");
            this.DialogResult = DialogResult.OK;
        }

        
    }
}
