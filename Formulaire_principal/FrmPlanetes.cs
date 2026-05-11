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
    public partial class FrmPlanetes : Form
    {
        public FrmPlanetes()
        {
            InitializeComponent();
        }

        private void charger_planetes() 
        {
            string sql = @$"SELECT count(nomPlanete)
                            FROM Mission
                            GROUP by nomPlanete";
            sql = @$"SELECT p.nom, p.temperature, p.gravite, p.dataBazON, GROUP_CONCAT(e.nom, '/') as Especes, GROUP_CONCAT(h.pourcentage, '/') as Pourcentages
                            FROM Planete p
                            LEFT JOIN Habiter h ON h.nomPlanete = p.nom
                            LEFT JOIN Espece e ON e.id = h.idEspece
                            GROUP BY p.nom";
        }

        private void FrmPlanetes_Load(object sender, EventArgs e)
        {

        }
    }
}
