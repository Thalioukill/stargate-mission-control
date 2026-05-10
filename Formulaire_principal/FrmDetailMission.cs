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
    public partial class FrmDetailMission : Form
    {
        private SQLiteConnection co = Connexion.Connec;

        //instanciation du DataSet

        private DataSet ds = MesDatas.DsGlobal;

        private string idMission;
        public FrmDetailMission()
        {
            InitializeComponent();
        }
        public FrmDetailMission(string idRecu)
        {
            InitializeComponent();
            this.idMission = idRecu;
        }

        private void FrmDetailMission_Load(object sender, EventArgs e)
        {

        }
    }
}
