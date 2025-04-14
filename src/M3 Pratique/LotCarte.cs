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
    public partial class LotCard : UserControl
    {
        public LotCard()
        {
            InitializeComponent();
        }

        public void SetData(string nom, string etat)
        {
            labelNom.Text = $"{nom}";
            labelEtat.Text = $"{etat}";
        }
    }
}
