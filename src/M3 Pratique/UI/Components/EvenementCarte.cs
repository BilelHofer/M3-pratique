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
    public partial class EvenementCarte : UserControl
    {
        public EvenementCarte(Evenement evenement)
        {
            InitializeComponent();

            // Met à jour les label de la carte
            labelMessage.Text = evenement.Message;
            labelDate.Text = evenement.Date.ToString("dd/MM/yyyy hh:m");
        }
    }
}
