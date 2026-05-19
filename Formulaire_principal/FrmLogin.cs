using BCrypt.Net;
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
    public partial class FrmLogin : Form
    {
        private SQLiteConnection co = Connexion.Connec;

        //instanciation du DataSet

        private DataSet ds = MesDatas.DsGlobal;
        public FrmLogin()
        {
            InitializeComponent();
            btnOeil.BackgroundImage = Image.FromFile("../../Images/Missions/oeil.png");
            //Pour que l'image occupe tout le bouton
            btnOeil.BackgroundImageLayout = ImageLayout.Stretch;
            txtMdp.UseSystemPasswordChar = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //Pour supprimer le jeu Login/mdp actuel :
                //string sqlDelete = "DELETE FROM Admin WHERE login = 'demo'";
                //SQLiteCommand cmdDelete = new SQLiteCommand(sqlDelete, co);
                //cmdDelete.ExecuteNonQuery();

                string sql = "SELECT COUNT(*) FROM Admin";
                SQLiteCommand cmd = new SQLiteCommand(sql, co);
                int nb = Convert.ToInt32(cmd.ExecuteScalar());

                if (nb == 1)
                {
                    string sql2 = "INSERT INTO Admin (login,mdp) VALUES ('demo','$2y$10$/EXwxuogBbQQb7q.MkdCK.UrHOhv77hr8CR7DH6n5//vkQFRpnvv2')";

                    SQLiteCommand cmd2 = new SQLiteCommand(sql2, co);

                    cmd2.ExecuteNonQuery();
                }
            }
            catch(SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                //Récupération du mot de passe en fonction du login
                string sql = $"SELECT mdp FROM Admin WHERE login = '{txtLogin.Text}'";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                object resultat = cmd.ExecuteScalar();
                //Test si la requête a renvoyé un résultat non null
                if (resultat != DBNull.Value && resultat != null)
                {
                    string mdpStocke = resultat.ToString();
                    //Vérification du mot de passe
                    bool valide = BCrypt.Net.BCrypt.Verify(txtMdp.Text, mdpStocke);//Résultat de l'authentification
                    if (valide)
                    {
                        MettreaJourDS();
                        MessageBox.Show("Accès autorisé", "Authentification");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Accès refusé", "Authentification");
                        txtMdp.Text = "";
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnOeil_Click(object sender, EventArgs e)
        {
            if(txtMdp.UseSystemPasswordChar)
            {
                txtMdp.UseSystemPasswordChar = false;
            }
            else
            {
                txtMdp.UseSystemPasswordChar = true;
            }

        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si on appuie sur la touche entrée ...
            if(e.KeyChar == 13)
            {
                txtMdp.Focus();
            }
        }

        private void txtMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnValider_Click(sender, e);
            }
        }

        private void MettreaJourDS()
        {
            if (ds.Tables.Contains("Admin"))
            {
                ds.Tables["Admin"].Clear();
            }
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Mission", co);
            da.Fill(ds, "Admin");
        }

    }
}
