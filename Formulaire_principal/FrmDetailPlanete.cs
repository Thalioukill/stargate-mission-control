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
        public FrmDetailPlanete(string pourcentages)
        {
            InitializeComponent();
            if (pourcentages == "inconnue")
            {
                lblPourcentage.Text = "Taux d'espèces : " + pourcentages;
            }
            else
            {
                lblPourcentage.Text = "Taux d'espèces : " + pourcentages + "%";
            }
            
        }

        private void FrmDetailPlanete_Load(object sender, EventArgs e)
        {
            
        }
    }
}
