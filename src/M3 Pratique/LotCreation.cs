using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3_Pratique
{
    public partial class LotCreation : Form
    {
        public LotCreation()
        {
            InitializeComponent();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            
        }

        // Bouton annuler 
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // Ferme la fenêtre
            this.Close();
        }
    }
}
