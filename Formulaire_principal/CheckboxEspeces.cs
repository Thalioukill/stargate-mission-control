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
    public partial class CheckboxEspeces : UserControl
    {
        public CheckboxEspeces()
        {
            InitializeComponent();
        }

        public CheckboxEspeces(string nom)
        {
            InitializeComponent();
            this.chkEspece.Text = nom;
        }

        private void CheckboxEspeces_Load(object sender, EventArgs e)
        {

        }
    }
}
