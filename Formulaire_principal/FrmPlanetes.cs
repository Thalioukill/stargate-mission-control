using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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

        private void charger_donnees()
        {
            try
            {
                string sql2 = $@"SELECT p.nom, p.temperature, p.gravite, p.dataBazON, 
                    GROUP_CONCAT(e.nom, '/') as Especes, 
                    GROUP_CONCAT(h.pourcentage, '/') as Pourcentages, 
                    stats_m.nbMissions
                    FROM Planete p
                    LEFT JOIN Habiter h ON h.nomPlanete = p.nom
                    LEFT JOIN Espece e ON e.id = h.idEspece
                    LEFT JOIN(
                        SELECT nomPlanete, COUNT(*) AS nbMissions
                        FROM Mission
                        GROUP BY nomPlanete
                    ) AS stats_m ON stats_m.nomPlanete = p.nom
                    GROUP BY p.nom";

                SQLiteDataAdapter da = new SQLiteDataAdapter(sql2, co);

                if (ds.Tables.Contains("TablePlanetesRecherche"))
                    ds.Tables["TablePlanetesRecherche"].Clear();

                da.Fill(ds, "TablePlanetesRecherche");
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void charger_planetes()
        {
            try
            {
                flp1.Controls.Clear();
                string filtre = $"nom LIKE '%{txtNom.Text}%'";

                if (txtMinTemp.Text != "")
                {
                    filtre += $" AND temperature >= {txtMinTemp.Text}";
                }
                if (txtMaxTemp.Text != "")
                {
                    filtre += $" AND temperature <= {txtMaxTemp.Text}";
                }
                if (txtMinGrav.Text != "")
                {
                    filtre += $" AND gravite >= {txtMinGrav.Text}";
                }
                if (txtMaxGrav.Text != "")
                {
                    filtre += $" AND gravite <= {txtMaxGrav.Text}";
                }
                if (rdbSans.Checked)
                {
                    filtre += " AND dataBazON = 0";
                }
                else if (rdbAvec.Checked)
                {
                    filtre += " AND dataBazON = 1";
                }
                string filtreEspece = "";
                for (int i = 0; i < flp2.Controls.Count; i++)
                {
                    if (flp2.Controls[i] is CheckboxEspeces userCtrl)
                    {
                        CheckBox cb = userCtrl.Controls["chkEspece"] as CheckBox;

                        if (cb != null && cb.Checked)
                        {
                            if (filtreEspece != "")
                            { 
                                filtreEspece += " OR ";
                            }
                            filtreEspece += $"Especes LIKE '%{cb.Text}%'";
                        }
                    }
                }
                if(filtreEspece != "") 
                {
                    filtre += $" AND ({filtreEspece})";
                }
                DataRow[] rows = ds.Tables["TablePlanetesRecherche"].Select(filtre);

                foreach(DataRow dr in rows) 
                {
                    string nom = dr["nom"].ToString();
                    string temp = dr["temperature"] == DBNull.Value ? "Température inconnue" : dr["temperature"].ToString();
                    string grav = dr["gravite"] == DBNull.Value ? "Gravité inconnue" : dr["gravite"].ToString();
                    string dbz = dr["dataBazON"] == DBNull.Value ? "Aucune information" : dr["dataBazON"].ToString();
                    string esp = dr["Especes"] == DBNull.Value ? "Espèces inconnues" : dr["Especes"].ToString();
                    string pct = dr["Pourcentages"] == DBNull.Value ? "Taux d'espèces inconnue" : dr["Pourcentages"].ToString();

                    int nbMissions = 0;
                    if (dr["nbMissions"] != DBNull.Value)
                        int.TryParse(dr["nbMissions"].ToString(), out nbMissions);

                    int fMin = 0, fMax = int.MaxValue;
                    int.TryParse(txtMinMission.Text, out fMin);
                    if (!string.IsNullOrWhiteSpace(txtMaxMission.Text)) int.TryParse(txtMaxMission.Text, out fMax);

                    if (nbMissions >= fMin && nbMissions <= fMax)
                    {
                        InfoPlanete info = new InfoPlanete(nom, temp, grav, dbz, esp, pct, nbMissions.ToString());
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
                flp2.Controls.Clear();
                foreach (DataRow dr in ds.Tables["Espece"].Rows)
                {
                    string nom = dr["nom"].ToString();
                    CheckboxEspeces cb = new CheckboxEspeces(nom);
                    flp2.Controls.Add(cb);
                }
            }
            catch (SQLiteException err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void FrmPlanetes_Load(object sender, EventArgs e)
        {
            charger_donnees();
            chargerEspeces();
            charger_planetes();
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
            charger_planetes();
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
