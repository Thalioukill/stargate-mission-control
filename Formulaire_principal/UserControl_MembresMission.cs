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
            this.lblNom.Text += nomComplet;
            this.lbl.Text += grade_specialite;

            if (image != string.Empty)
            {
                picMembre.Image = Image.FromFile("../../Images/Membres_Mission/" + image +".jpg");
            }

            if (estChef)
            {
                this.BackColor = Color.FromArgb(104,106, 255);
                this.lblNom.Font = new Font(this.lblNom.Font, FontStyle.Bold);
            }

        }

        private void UserControl_MembresMission_Load(object sender, EventArgs e)
        {

        }
    }
}
