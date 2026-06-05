using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire_principal
{
    public partial class FrmDetailPlanete : Form
    {
        public FrmDetailPlanete(String nom, Dictionary<string, (string pct, string couleur)> especesPourcentages)
        {
            this.Text = $"Détail sur les espèces peuplant la planète {nom}";

            InitializeComponent();

            if (especesPourcentages == null || especesPourcentages.Count == 0)
            {
                lblAucuneInfo.Text = "Aucune espèce répertoriée sur cette planète.";
                lblAucuneInfo.Visible = true;
            }
            else
            {
                lblAucuneInfo.Visible = false;

                foreach (KeyValuePair<string, (string pct, string couleur)> kvp in especesPourcentages)
                {
                    // kvp.Key         = nom espèce  (ex: "Goa'uld")
                    // kvp.Value.pct   = pourcentage (ex: "30%")
                    // kvp.Value.couleur = couleur   (ex: "Violet")

                    InfoEspecePlanete uc = new InfoEspecePlanete(kvp.Key, kvp.Value.pct, kvp.Value.couleur);
                    uc.Margin = new Padding(5);
                    flpEspeces.Controls.Add(uc);
                }
            }
        }

        private void FrmDetailPlanete_Load(object sender, EventArgs e)
        {
            
        }
    }
}
