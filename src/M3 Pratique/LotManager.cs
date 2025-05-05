using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Global.RecupererRecette();
            Global.recupererEvenement();
            AfficherLots(Global.Lots);

            // Ajout des Etat à la combobox
            comboBoxEtat.Items.Clear();

            BindingList<Etat> etats = new BindingList<Etat>();

            // Création des états
            etats.Add(new Etat(-1, "Tous"));
            for (int i = 0; i < Global.Etats.Count; i++)
            {
                etats.Add(new Etat(Global.Etats[i].Id, Global.Etats[i].Libelle));
            }

            comboBoxEtat.ValueMember = null;
            comboBoxEtat.DisplayMember = "Libelle";
            comboBoxEtat.DataSource = etats;
        }

        /// <summary>
        /// Affiche une collection de lots dans le FlowLayoutPanel.
        /// </summary>
        private void AfficherLots(IEnumerable<Lot> lots)
        {
            flowLayoutPanelLots.Controls.Clear();

            // Trie la liste par la date
            var lotsTries = lots.OrderByDescending(lot => lot.Date);

            foreach (var lot in lotsTries)
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

                // Afficher les détails du lot sélectionné
                labelLotNom.Text = carteSelectionnee.Lot.Nom;
                labelEtat.Text = Global.Etats.FirstOrDefault(etat => etat.Id == carteSelectionnee.Lot.IdEtat).Libelle;
                labelCreation.Text = carteSelectionnee.Lot.Date.ToString("dd/MM/yyyy");
                labelNbPiece.Text = carteSelectionnee.Lot.Quantite.ToString();
                labelRecette.Text = Global.Recettes.FirstOrDefault(recette => recette.Id == carteSelectionnee.Lot.IdRecette).Nom;

                // Ajout des événements 
                flowLayoutPanelEvenements.Controls.Clear();

                // récupère les événements du lot
                var evenements = Global.Evenements.Where(evenement => evenement.IdLot == carteSelectionnee.Lot.Id).ToList();

                groupBoxEvenement.Visible = evenements.Count > 0;

                foreach (var evenement in evenements)
                {
                    var carteEvenement = new EvenementCarte(evenement);
                    flowLayoutPanelEvenements.Controls.Add(carteEvenement);
                }

                groupBoxLotSelectionner.Visible = true;
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
            FiltrerLots();
        }

        private void comboBoxEtat_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrerLots();
        }

        /// <summary>
        /// Applique les filtres de recherche et d'état pour afficher les lots.
        /// </summary>
        private void FiltrerLots()
        {
            string recherche = textBoxRechercheLot.Text.ToLower();
            long idEtatSelectionne = (comboBoxEtat.SelectedItem as Etat)?.Id ?? -1;

            IEnumerable<Lot> lotsFiltres = Global.Lots;

            // Filtrage par texte si recherche non vide
            if (!string.IsNullOrWhiteSpace(recherche))
            {
                lotsFiltres = lotsFiltres.Where(lot => lot.Nom.ToLower().Contains(recherche));
            }

            // Filtrage par état si un état spécifique est sélectionné
            if (idEtatSelectionne != -1)
            {
                lotsFiltres = lotsFiltres.Where(lot => lot.IdEtat == idEtatSelectionne);
            }

            AfficherLots(lotsFiltres);
        }
    }
}
