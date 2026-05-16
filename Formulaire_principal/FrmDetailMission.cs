using Formulaire_principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire_principal 
{ 
    public partial class FrmDetailMission : Form
    {
        private SQLiteConnection co = Connexion.Connec;

        //instanciation du DataSet

        private DataSet ds = MesDatas.DsGlobal;

        private string idPlanete;
        private string idNumero;
        private string idChefMission;

        public FrmDetailMission()
        {
            InitializeComponent();
        }
        public FrmDetailMission(string laPlanete, string leNumero, string matricule)
        {
            InitializeComponent();

            this.idPlanete = laPlanete;
            this.idNumero = leNumero;
            this.idChefMission = matricule;

            AfficherDetailsMission();
            AfficherEquipage();
            AfficherObjectifs();
            ChargerCboInformateur();
            ChargerCboTypeDepense();




            /*
            // Création d'une vue sur la table "Composer" (qui lie membres et missions)
            DataView dvEquipage = new DataView(mesDatas.dsStargate.Tables["Composer"]);

            // Application du filtre local
            dvEquipage.RowFilter = $"nomPlanete = '{laPlanete}' AND numeroMission = {leNumero}";

            //parcours de la vue filtrée pour afficher les User Controls
            foreach (DataRowView ligne in dvEquipage)
            {
                // On récupère le matricule du membre de la mission en cours dans la ligne de la vue
                string matricule = ligne["matricule"].ToString();

                // On va chercher les détails du membre (nom, grade...) dans la table Membre du DataSet
                DataRow rMembre = mesDatas.dsStargate.Tables["Membre"].Rows.Find(matricule);

                if (rMembre != null)
                {
                    string nomComplet = rMembre["prenom"] + " " + rMembre["nom"];

                    // Grade OU Spécialité 
                    string grade_specialite = rMembre["grade"].ToString();

                    if (string.IsNullOrEmpty(grade_specialite)) {
                        grade_specialite = rMembre["Specialite"].ToString();
                    }
                    // Création de l'UC avec la couleur si chef
                    UserControl_MembresMission uc = new UserControl_MembresMission(nomComplet, infoSup, rMembre["photo"].ToString(), estChef);

                    flpEquipage.Controls.Add(uc);
                }
            }
            */
        }

        private void AfficherDetailsMission()
        {
            try
            {
                // Récupération des infos de la mission dans le DataSet
                /*
                string filtre = $"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}";
                DataRow rMission = MesDatas.DsGlobal.Tables["Composer"].Select(filtre);
                */

                DataRow rMission = MesDatas.DsGlobal.Tables["Mission"].Rows.Find(new object[] { idPlanete, idNumero });

                if (rMission != null)
                {
                    this.lblNomMission.Text += idPlanete + idNumero;
                    this.lblDateDepart.Text += rMission["dateDepart"].ToString();
                    this.lblDateRetour.Text += rMission["dateRetour"].ToString();
                    this.rtbFeuilleDeRoute.Text = rMission["feuilleDeRoute"].ToString();
                    this.picMission.Image = Image.FromFile("../../Images/Missions/" + idPlanete + ".jpg");

                    // Calcul du budget (Budget initial - Somme des dépenses) 
                    double budgetInitial = Convert.ToDouble(rMission["budget"]);

                    // On filtre les dépenses de cette mission dans la table locale
                    DataRow[] depenses = ds.Tables["Depense"].Select($"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}");
                    double totalDepenses = 0;

                    foreach (DataRow d in depenses)
                    {
                        totalDepenses += Convert.ToDouble(d["montant"]);
                    }

                    this.lblBudget.Text += $"{budgetInitial}€";
                    this.lblSoldeApresDepenses.Text += budgetInitial - totalDepenses+ "€";
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void AfficherEquipage()
        {
            flpEquipage.Controls.Clear();

            //On filtre les membres de CETTE mission dans la table de jointure "Composer"
            string filtre = $"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}";
            DataRow[] lignesEquipage = ds.Tables["Composer"].Select(filtre);

            foreach (DataRow ligne in lignesEquipage)
            {
                string matricule = ligne["matriculeMembre"].ToString();
                string grade_specialite = "Inconnu";
                string image = "";
                string nomComplet = "";

                // RÉCUPÉRATION DIRECTE SELON LE PRÉFIXE
                // On regarde le premier caractère (indice 0)

                char prefixe = matricule[0];

                if (prefixe == 'M') // C'est un Militaire
                {
                    DataRow[] res = ds.Tables["Militaire"].Select($"matriculeMembre = '{matricule}'");
                    if (res.Length > 0)
                    {
                        grade_specialite = "Grade : " + res[0]["grade"].ToString();
                        image = "Militaire";
                    }
                }
                else if (prefixe == 'C') // C'est un Civil
                {
                    DataRow[] res = ds.Tables["Civil"].Select($"matriculeMembre = '{matricule}'");
                    if (res.Length > 0)
                    {
                        grade_specialite = "Spécialité : " + res[0]["Specialite"].ToString();
                        image = "Civil";
                    }
                }

                // Récupération du reste (Nom, Prénom, Photo) dans la table Membre
                DataRow[] tabInfosBase = ds.Tables["Membre"].Select($"matricule = '{matricule}'");

                if (tabInfosBase.Length > 0)
                {
                    nomComplet = tabInfosBase[0]["prenom"] + " " + tabInfosBase[0]["nom"];

                }
                // 5. On vérifie si c'est le chef 
                bool estChef = (matricule == this.idChefMission);

                // 6. Instanciation de l'UC avec les bonnes variables
                UserControl_MembresMission uc = new UserControl_MembresMission(nomComplet, grade_specialite, image, estChef);
                flpEquipage.Controls.Add(uc);
            }
        }

        private void AfficherObjectifs()
        {
            // On vide d'abord le panel pour éviter les doublons si on rafraîchit l'affichage
            flpObjectifCaptures.Controls.Clear();

            string filtre = $"nomPlanete = '{idPlanete}' AND numeroMission = {idNumero}";
            DataRow[] lignesEspeceEnnemie = ds.Tables["Capturer"].Select(filtre);

            foreach (DataRow ligne in lignesEspeceEnnemie)
            {
                string idEspeceEnnemi = ligne["idEspeceEnnemi"].ToString();
                string captures = ligne["nombre"].ToString();

                // On cherche le nom de l'espèce dans la table Espece
                DataRow[] tabInfosEnnemi = ds.Tables["Espece"].Select($"id = '{idEspeceEnnemi}'");

                if (tabInfosEnnemi.Length > 0)
                {
                    //Création de l'instance du Label
                    Label lbl = new Label();

                    // on récupère le nom de la couleur pour ensuite afficher le label en couleur
                    string nomCouleur = tabInfosEnnemi[0]["couleur"].ToString(); // Ex: "Gris"

                    lbl.Text = tabInfosEnnemi[0]["nom"].ToString() + " --> " + captures + " prise(s)";


                    lbl.AutoSize = true; // Pour que le label s'adapte à la longueur du texte
                    lbl.Margin = new Padding(5); // Pour aérer l'affichage dans le panel
                    lbl.Font = new Font(lbl.Font, FontStyle.Bold);

                    // attribution de la couleur grâce à une méthode de conversion
                    lbl.ForeColor = ConvertirNomCouleur(nomCouleur);

                    //AJOUT AU PANEL
                    flpObjectifCaptures.Controls.Add(lbl);

                }
            }

        }

        // Méthode pour mapper les couleurs du projet Stargate
        private Color ConvertirNomCouleur(string couleurFr)
        {
            // On utilise un switch pour faire correspondre le texte DB et la couleur C#
            switch (couleurFr.ToLower())
            {
                case "gris": return Color.Gray;
                case "pourpre": return Color.Purple;
                case "orange": return Color.Orange;
                case "rose": return Color.Pink;
                case "violet": return Color.Violet;
                case "marron": return Color.SaddleBrown;
                case "vert": return Color.Green;
                case "bleu": return Color.Blue;
                default: return Color.Black; // Couleur par défaut si non trouvé
            }
        }

        private void FrmDetailMission_Load(object sender, EventArgs e)
        {

        }

        private void btnJournal_Click(object sender, EventArgs e)
        {
            FrmJournalDeBord fjdb = new FrmJournalDeBord(this.idPlanete, this.idNumero);
            DialogResult dr = fjdb.ShowDialog();
        }

        private void ChargerCboInformateur()
        {
            cboInformateur.DataSource = ds.Tables["Informateur"];
            cboInformateur.DisplayMember = "nom";
            cboInformateur.ValueMember = "nomCode";

        }

        private void ChargerCboTypeDepense()
        {
            cboTypeDepense.DataSource = ds.Tables["TypeDepense"];
            cboTypeDepense.DisplayMember = "libelle";
            cboTypeDepense.ValueMember = "id";
        }

        private void btnValidNouvC_Click(object sender, EventArgs e)
        {
            try
            {
                //Mode connecté pour ajouter dans la bse
                string sql = @"INSERT INTO Contact (nomPlanete, numeroMission, dateC, sommeVersee, appreciation, nomCodeInformateur)
                       VALUES (@nomPlanete, @numeroMission, @dateC, @sommeVersee, @appreciation, @nomCodeInformateur)";
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                cmd.Parameters.AddWithValue("@nomPlanete", idPlanete);
                cmd.Parameters.AddWithValue("@numeroMission", idNumero);
                cmd.Parameters.AddWithValue("@dateC", dtpContact.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@sommeVersee", txtSomme.Text);
                cmd.Parameters.AddWithValue("@appreciation", txtAppreciation.Text);
                cmd.Parameters.AddWithValue("@nomCodeInformateur", cboInformateur.SelectedValue.ToString());
                cmd.ExecuteNonQuery();

                //Mode déconnecté pour mettre à jour le data set
                DataRow maRow = ds.Tables["Contact"].NewRow();
                maRow["nomPlanete"] = idPlanete;
                maRow["numeroMission"] = idNumero;
                maRow["dateC"] = dtpContact.Value;
                maRow["sommeVersee"] = txtSomme.Text;
                maRow["appreciation"] = txtAppreciation.Text;
                maRow["nomCodeInformateur"] = cboInformateur.SelectedValue.ToString();
                ds.Tables["Contact"].Rows.Add(maRow);

                MessageBox.Show("Nouveau contact ajouté !");
                RAZContact();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void RAZContact()
        {
            dtpContact.Value = DateTime.Now;
            txtSomme.Clear();
            txtAppreciation.Clear();
            cboInformateur.SelectedIndex = -1;
        }

        private void btnAnnulNouvC_Click(object sender, EventArgs e)
        {
            RAZContact();
        }

        private void btnValidDepense_Click(object sender, EventArgs e)
        {
            try
            {
                //Calcul du max pour l'id des dépenses en mode connecté
                string sqlMax = @"SELECT MAX(id) FROM Depense WHERE nomPlanete = @nomPlanete
                       AND numeroMission = @numeroMission";
                SQLiteCommand cmdMax = new SQLiteCommand(sqlMax, co);
                cmdMax.Parameters.AddWithValue("@nomPlanete", idPlanete);
                cmdMax.Parameters.AddWithValue("@numeroMission", idNumero);

                int maxIdDep = Convert.ToInt32(cmdMax.ExecuteScalar());

                //Ajout à la base en mode connecté
                string sql = @"INSERT INTO Depense (nomPlanete, numeroMission, id, dateD, montant, motif, idTypeDepense)
                       VALUES (@nomPlanete, @numeroMission, @id, @dateD, @montant, @motif, @idTypeDepense)";
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                cmd.Parameters.AddWithValue("@nomPlanete", idPlanete);
                cmd.Parameters.AddWithValue("@numeroMission", idNumero);
                cmd.Parameters.AddWithValue("@id", maxIdDep + 1);
                cmd.Parameters.AddWithValue("@dateD", dtpDepense.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@montant", txtMontant.Text);
                cmd.Parameters.AddWithValue("@motif", txtMotif.Text);
                cmd.Parameters.AddWithValue("@idTypeDepense", cboTypeDepense.SelectedValue.ToString());
                cmd.ExecuteNonQuery();

                //Mise à jour du data set en mode déconnecté
                DataRow maRow = ds.Tables["Depense"].NewRow();
                maRow["nomPlanete"] = idPlanete;
                maRow["numeroMission"] = idNumero;
                maRow["id"] = maxIdDep + 1;
                maRow["dateD"] = dtpDepense.Value;
                maRow["montant"] = txtMontant.Text;
                maRow["motif"] = txtMotif.Text;
                maRow["idTypeDepense"] = cboTypeDepense.SelectedValue.ToString();
                ds.Tables["Depense"].Rows.Add(maRow);

                MessageBox.Show("Nouvelle dépense ajoutée !");
                RAZDepense();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

        }
        private void RAZDepense()
        {
            dtpDepense.Value = DateTime.Now;
            txtMontant.Clear();
            txtMotif.Clear();
            cboTypeDepense.SelectedIndex = -1;
        }

        private void btnAnnulNouvD_Click(object sender, EventArgs e)
        {
            RAZDepense();
        }

        private void btnValidEvnmt_Click(object sender, EventArgs e)
        {
            try
            {
                //Ajout à la base en mode connecté
                string sql = @"INSERT INTO JournalDeBord (nomPlanete, numero, dateJ, commentaires)
                       VALUES (@nomPlanete, @numero, @dateJ, @commentaires)";
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                cmd.Parameters.AddWithValue("@nomPlanete", idPlanete);
                cmd.Parameters.AddWithValue("@numero", idNumero);
                cmd.Parameters.AddWithValue("@dateJ", dtpEvnmt.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@commentaires", txtCommentaires.Text);
                cmd.ExecuteNonQuery();

                //Mise à jour du data set en mode déconnecté
                DataRow maRow = ds.Tables["JournalDeBord"].NewRow();
                maRow["nomPlanete"] = idPlanete;
                maRow["numero"] = idNumero;
                maRow["dateJ"] = dtpEvnmt.Value;
                maRow["commentaires"] = txtCommentaires.Text;
                ds.Tables["JournalDeBord"].Rows.Add(maRow);

                MessageBox.Show("Nouvel évènement ajoutée !");
                RAZEvenement();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void RAZEvenement()
        {
            dtpEvnmt.Value = DateTime.Now;
            txtCommentaires.Clear();
        }

        private void btnAnnulNouvE_Click(object sender, EventArgs e)
        {
            RAZEvenement();

        }

        private void txtSomme_KeyPress(object sender, KeyPressEventArgs e)
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
                txtAppreciation.Focus();
            }
        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
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
                txtMotif.Focus();
            }
        }
    }
}
