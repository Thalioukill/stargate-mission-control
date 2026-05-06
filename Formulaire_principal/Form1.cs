using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using BCrypt.Net;

namespace Formulaire_principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SQLiteConnection co = Connexion.Connec;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
