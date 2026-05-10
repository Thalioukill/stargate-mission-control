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
    [ToolboxBitmap(typeof(afficherMission), "UserControl_MembresMission.jpg")]
    public partial class UserControl_MembresMission : UserControl
    {

        public UserControl_MembresMission()
        {
            InitializeComponent();
        }

        public UserControl_MembresMission(string nomComplet, string grade_specialite, string image, bool estChef)
        {
            InitializeComponent();
            this.lblnom.Text += nom;
            this.lblPn.Text += grade_specialite;

            if (image != string.Empty)
            {
                picMembre.Image = Image.FromFile("../../Images/Membres_Mission/" + image);

            }

        }

        private void UserControl_MembresMission_Load(object sender, EventArgs e)
        {

        }
    }
}
