using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaire_principal
{
    public partial class InfoPlanete : UserControl
    {
        string pourcentages;

        public InfoPlanete()
        {
            InitializeComponent();
            InitialiserEvenementsHover();
        }

        public InfoPlanete(string nom, string temperature, string gravite, string dataBazON, string especes, string pourcentages, string missions)
        {
            InitializeComponent();

            lblNom.Text = "Nom : " + nom;
            lblTemperature.Text = "Température : " + temperature + " °C";
            lblGravite.Text = "Gravité : " + gravite + " G";

            if (dataBazON == "1")
            {
                dataBazON = "Présent";
                lblDataBaz.ForeColor = Color.Green;
            }
            else
            {
                dataBazON = "Non présent";
                lblDataBaz.ForeColor = Color.Red;
            }

            lblDataBaz.Text = "DataBAZ : " + dataBazON;
            lblEspeces.Text = "Espèces : " + especes;
            this.pourcentages = pourcentages;
            lblMission.Text = "Nombres de missions effectuées : " + missions;

            if (nom != string.Empty)
            {
                picPlanete.Image = Image.FromFile("../../Images/Missions/" + nom + ".jpg");
                picPlanete.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            InitialiserEvenementsHover();
        }

        private void InitialiserEvenementsHover()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            this.MouseEnter += (s, e) => this.Invalidate();
            this.MouseLeave += (s, e) => this.Invalidate();
        }

        private void InfoPlanete_Load(object sender, EventArgs e)
        {
        }

        private void InfoPlanete_Click(object sender, EventArgs e)
        {
            FrmDetailPlanete fdp = new FrmDetailPlanete(this.pourcentages);
            DialogResult dr = fdp.ShowDialog();
        }

        private void InfoPlanete_Paint(object sender, PaintEventArgs e)
        {
            if (this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                using (Pen p = new Pen(Color.Purple, 7))
                {
                    e.Graphics.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }
    }
}