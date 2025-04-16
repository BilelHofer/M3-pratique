using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace M3_Pratique
{
    // Fenêtre de gestion des lots
    public partial class LotManager : Form
    {
        private LotCreation lotCreationForm = null;
        private LotCarte carteSelectionnee = null;

        public LotManager()
        {
            InitializeComponent();
            Global.RecupererLots();
            Global.RecupererEtat();
            AfficherLots(Global.Lots);
        }

        /// <summary>
        /// Affiche une collection de lots dans le FlowLayoutPanel.
        /// </summary>
        private void AfficherLots(IEnumerable<Lot> lots)
        {
            flowLayoutPanelLots.Controls.Clear();

            foreach (var lot in lots)
            {
                var carte = new LotCarte(lot);
                carte.LotSelectionne += SelectionCarte;
                flowLayoutPanelLots.Controls.Add(carte);
            }
        }

        /// <summary>
        /// Gère la sélection d'une carte de lot.
        /// </summary>
        private void SelectionCarte(object sender, long idLot)
        {
            if (carteSelectionnee != null)
                carteSelectionnee.BackColor = Color.White;

            carteSelectionnee = sender as LotCarte;

            if (carteSelectionnee != null)
            {
                carteSelectionnee.BackColor = Color.LightBlue;

                // TODO affichage en détails du lot
            }
        }

        /// <summary>
        /// Ouvre la fenêtre de création d’un nouveau lot.
        /// </summary>
        private void btnCreerLot_Click(object sender, EventArgs e)
        {
            if (lotCreationForm == null || lotCreationForm.IsDisposed)
            {
                lotCreationForm = new LotCreation();
                lotCreationForm.LotAjoute += (s, args) => AfficherLots(Global.Lots);
                lotCreationForm.Show();
            }
            else
            {
                lotCreationForm.BringToFront();
            }
        }

        /// <summary>
        /// Filtre les lots en fonction du texte saisi dans la barre de recherche.
        /// </summary>
        private void textBoxRechercheLot_TextChanged(object sender, EventArgs e)
        {
            string recherche = textBoxRechercheLot.Text.ToLower();

            var lotsFiltres = string.IsNullOrEmpty(recherche)
                ? Global.Lots
                : Global.Lots.Where(lot => lot.Nom.ToLower().Contains(recherche));

            AfficherLots(lotsFiltres);
        }
    }
}
