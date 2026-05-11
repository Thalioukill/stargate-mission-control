using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire_principal
{
    public partial class FrmPlanetes : Form
    {
        private SQLiteConnection co = Connexion.Connec;

        private DataSet ds = MesDatas.DsGlobal;

        public FrmPlanetes()
        {
            InitializeComponent();
        }

        private void charger_planetes()
        {
            try
            {
                string sql2 = $@"SELECT p.nom, p.temperature, p.gravite, p.dataBazON, GROUP_CONCAT(e.nom, '/') as Especes, GROUP_CONCAT(h.pourcentage, '/') as Pourcentages
                            FROM Planete p
                            LEFT JOIN Habiter h ON h.nomPlanete = p.nom
                            LEFT JOIN Espece e ON e.id = h.idEspece
                            GROUP BY p.nom";
                SQLiteCommand cmd2 = new SQLiteCommand(sql2, co);
                SQLiteDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    string nom = dr2["nom"].ToString();
                    string temperature;
                    string gravite;
                    string dataBazON;
                    string especes;
                    string pourcentages;
                    string missions = "0";
                    if (dr2["temperature"] == DBNull.Value)
                    {
                        temperature = "Température inconnue";
                    }
                    else
                    {
                        temperature = dr2["temperature"].ToString();
                    }
                    if (dr2["gravite"] == DBNull.Value)
                    {
                        gravite = "Gravité inconnue";
                    }
                    else
                    {
                        gravite = Convert.ToSingle(dr2["gravite"]).ToString();
                    }
                    if (dr2["dataBazON"] == DBNull.Value)
                    {
                        dataBazON = "Aucune information sur le dataBaz";
                    }
                    else
                    {
                        dataBazON = Convert.ToInt32(dr2["dataBazON"]).ToString();
                    }
                    if (dr2["Especes"] == DBNull.Value)
                    {
                        especes = "Espèces inconnues";
                    }
                    else
                    {
                        especes = dr2["Especes"].ToString();
                    }
                    if (dr2["Pourcentages"] == DBNull.Value)
                    {
                        pourcentages = "Taux d'espèces inconnue";
                    }
                    else
                    {
                        pourcentages = dr2["Pourcentages"].ToString();
                    }
                    string sql = $@"SELECT p.nom, COUNT(m.nomPlanete) AS nbMissions
                              FROM Planete p 
                              LEFT JOIN Mission m ON p.nom = m.nomPlanete 
                              GROUP BY p.nom";
                    SQLiteCommand cmd = new SQLiteCommand(sql, co);
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr["nom"].ToString() == nom) 
                        {
                           missions = Convert.ToInt32(dr["nbMissions"]).ToString();
                        }
                    }
                    InfoPlanete info = new InfoPlanete(nom, temperature, gravite, dataBazON, especes, pourcentages, missions);
                    flp1.Controls.Add(info);
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void FrmPlanetes_Load(object sender, EventArgs e)
        {
            charger_planetes();
            string sql = "SELECT nom FROM Espece";
            SQLiteCommand cmd = new SQLiteCommand(sql, co);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string nom = dr["nom"].ToString();
                CheckboxEspeces checkbox = new CheckboxEspeces(nom);
                flp2.Controls.Add(checkbox);
            }
        }
    }
}
