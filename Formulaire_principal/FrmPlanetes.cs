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
                flp1.Controls.Clear();
                string txt = "";
                if (txtMinTemp.Text != "")
                {
                    txt += $" AND p.temperature >= {txtMinTemp.Text}";
                }
                if (txtMaxTemp.Text != "")
                {
                    txt += $" AND p.temperature <= {txtMaxTemp.Text}";
                }
                if (txtMinGrav.Text != "")
                {
                    txt += $" AND p.gravite >= {txtMinGrav.Text}";
                }
                if (txtMaxGrav.Text != "")
                {
                    txt += $" AND p.gravite <= {txtMaxGrav.Text}";
                }
                string txtEspece = "";
                for (int i = 0; i < flp2.Controls.Count; i++)
                {
                    if (flp2.Controls[i] is CheckboxEspeces userCtrl)
                    {
                        CheckBox cb = userCtrl.Controls["chkEspece"] as CheckBox;

                        if (cb != null && cb.Checked)
                        {
                            if(txtEspece == "")
                            {
                                txtEspece += $" AND Especes LIKE '%{cb.Text}%'";
                            }
                            else
                            {
                                txtEspece += $" OR Especes LIKE '%{cb.Text}%'";
                            }
                        }
                    }
                }
                if (rdbSans.Checked)
                {
                    txt += " AND p.dataBazON = 0";
                }
                else if (rdbAvec.Checked)
                {
                    txt += " AND p.dataBazON = 1";
                }
                string sql2 = $@"SELECT p.nom, p.temperature, p.gravite, p.dataBazON, GROUP_CONCAT(e.nom, '/') as Especes, GROUP_CONCAT(h.pourcentage, '/') as Pourcentages
                            FROM Planete p
                            LEFT JOIN Habiter h ON h.nomPlanete = p.nom
                            LEFT JOIN Espece e ON e.id = h.idEspece
                            WHERE p.nom LIKE '%{txtNom.Text}%'{txt}
                            GROUP BY p.nom
                            HAVING 1=1{txtEspece}";
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
                    int filtreMin = 0;
                    if (!string.IsNullOrWhiteSpace(txtMinMission.Text))
                    {
                        int.TryParse(txtMinMission.Text, out filtreMin);
                    }

                    int filtreMax = int.MaxValue;
                    if (!string.IsNullOrWhiteSpace(txtMaxMission.Text))
                    {
                        int.TryParse(txtMaxMission.Text, out filtreMax);
                    }

                    int.TryParse(missions, out int nbMissionsActuelles);

                    if (nbMissionsActuelles >= filtreMin && nbMissionsActuelles <= filtreMax)
                    {
                        InfoPlanete info = new InfoPlanete(nom, temperature, gravite, dataBazON, especes, pourcentages, missions);
                        flp1.Controls.Add(info);
                    }
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void chargerEspeces()
        {
            try
            {
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
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void FrmPlanetes_Load(object sender, EventArgs e)
        {
            charger_planetes();
            chargerEspeces();
        }

        private void txtMinTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if(e.KeyChar == '-' && txtMinTemp.Text.Length == 0)
            {
                e.Handled = false;
            }
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtMaxTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (e.KeyChar == '-' && txtMinTemp.Text.Length == 0)
            {
                e.Handled = false;
            }
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtMinGrav_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (e.KeyChar == '-' && txtMinTemp.Text.Length == 0)
            {
                e.Handled = false;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (txtMinGrav.Text.Contains(".") || txtMinGrav.Text.Length == 0 || (txtMinGrav.Text.Length == 1 && txtMinGrav.Text == "-"))
                {
                    e.KeyChar = '.';
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = '.';
                    e.Handled = false;
                }
            }
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtMaxGrav_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (e.KeyChar == '-' && txtMaxTemp.Text.Length == 0)
            {
                e.Handled = false;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (txtMaxGrav.Text.Contains(".") || txtMaxGrav.Text.Length == 0 || (txtMaxGrav.Text.Length == 1 && txtMaxGrav.Text == "-"))
                {
                    e.KeyChar = '.';
                    e.Handled = true;
                }
                else 
                {
                    e.KeyChar = '.';
                    e.Handled = false;
                }
            }
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnReinitialiserDataBaz_Click(object sender, EventArgs e)
        {
            rdbSans.Checked = false;
            rdbAvec.Checked = false;
            charger_planetes();
        }

        private void btnReinitialiserEspeces_Click(object sender, EventArgs e)
        {
            flp2.Controls.Clear();
            chargerEspeces();
        }

        private void txtMinMission_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtMaxMission_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinGrav.Text, out int minG) && int.TryParse(txtMaxGrav.Text, out int maxG))
            {
                if (minG > maxG)
                {
                    MessageBox.Show("max > min impossible");
                    txtMinGrav.Focus();
                    return;
                }
            }
            if (int.TryParse(txtMinTemp.Text, out int minT) && int.TryParse(txtMaxTemp.Text, out int maxT))
            {
                if (minT > maxT)
                {
                    MessageBox.Show("max > min impossible");
                    txtMinTemp.Focus();
                    return;
                }
            }
            if (int.TryParse(txtMinMission.Text, out int minM) && int.TryParse(txtMaxMission.Text, out int maxM))
            {
                if (minM > maxM)
                {
                    MessageBox.Show("max > min impossible");
                    txtMinMission.Focus();
                    return;
                }
            }
            charger_planetes();
        }

        private void btnReinitialiser_Click(object sender, EventArgs e)
        {
            rdbSans.Checked = false;
            rdbAvec.Checked = false;
            txtMinTemp.Text = "";
            txtMaxTemp.Text = "";
            txtMinGrav.Text = "";
            txtMaxGrav.Text = "";
            txtMinMission.Text = "";
            txtMaxMission.Text = "";
            flp2.Controls.Clear();
            chargerEspeces();
            txtNom.Text = "";
            charger_planetes();
        }
    }
}
