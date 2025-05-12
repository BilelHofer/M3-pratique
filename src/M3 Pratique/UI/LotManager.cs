using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace M3_Pratique
{
    public partial class LotManager : Form
    {
        private LotCreation lotCreationForm = null;
        private LotCarte carteSelectionnee = null;

        public LotManager()
        {
            InitializeComponent();

            // Charge les données nécessaires depuis les objets globaux
            Global.RecupererLots();
            Global.RecupererEtat();
            Global.RecupererRecette();
            Global.recupererEvenement();

            // Prépare la combobox des états
            InitialiserComboBoxEtat();

            // Affiche tous les lots
            AfficherLots(Global.Lots);
        }

        /// <summary>
        /// Initialise la combobox contenant les états possibles, avec un état "Tous".
        /// </summary>
        private void InitialiserComboBoxEtat()
        {
            comboBoxEtat.Items.Clear();

            // Fusionne l'état "Tous" avec les états récupérés
            comboBoxEtat.DataSource = new BindingList<Etat>(
                new[] { new Etat(-1, "Tous") }.Concat(Global.Etats).ToList()
            );

            comboBoxEtat.DisplayMember = "Libelle";
            comboBoxEtat.ValueMember = "Id";
        }

        /// <summary>
        /// Affiche les lots dans le FlowLayoutPanel, triés par date décroissante.
        /// </summary>
        private void AfficherLots(IEnumerable<Lot> lots)
        {
            flowLayoutPanelLots.Controls.Clear();

            var lotsTries = lots.OrderByDescending(lot => lot.Date);

            foreach (var lot in lotsTries)
            {
                var carte = new LotCarte(lot);
                carte.LotSelectionne += SelectionCarte;
                flowLayoutPanelLots.Controls.Add(carte);
            }
        }

        /// <summary>
        /// Événement déclenché lors de la sélection d’un lot.
        /// Met à jour l’UI avec les détails et événements du lot sélectionné.
        /// </summary>
        private void SelectionCarte(object sender, long idLot)
        {
            // Réinitialise la couleur de la carte précédemment sélectionnée
            if (carteSelectionnee != null)
                carteSelectionnee.BackColor = Color.White;

            // Sélectionne la nouvelle carte
            carteSelectionnee = sender as LotCarte;
            if (carteSelectionnee != null)
            {
                carteSelectionnee.BackColor = Color.LightBlue;

                // Affiche les infos détaillées du lot
                AfficherDetailsLot(carteSelectionnee.Lot);

                // Affiche les événements associés à ce lot
                AfficherEvenementsLot(carteSelectionnee.Lot.Id);
            }
        }

        /// <summary>
        /// Met à jour les libellés et champs avec les données du lot sélectionné.
        /// </summary>
        private void AfficherDetailsLot(Lot lot)
        {
            labelLotNom.Text = lot.Nom;
            labelEtat.Text = Global.Etats.FirstOrDefault(etat => etat.Id == lot.IdEtat)?.Libelle ?? "";
            labelCreation.Text = lot.Date.ToString("dd/MM/yyyy");
            labelNbPiece.Text = lot.Quantite.ToString();
            labelRecette.Text = Global.Recettes.FirstOrDefault(r => r.Id == lot.IdRecette)?.Nom ?? "";
            groupBoxLotSelectionner.Visible = true;
        }

        /// <summary>
        /// Affiche tous les événements associés à un lot.
        /// </summary>
        private void AfficherEvenementsLot(long idLot)
        {
            flowLayoutPanelEvenements.Controls.Clear();

            var evenements = Global.Evenements
                .Where(e => e.IdLot == idLot)
                .OrderByDescending(e => e.Date)
                .ToList();

            groupBoxEvenement.Visible = evenements.Count > 0;

            foreach (var evenement in evenements)
            {
                var carteEvenement = new EvenementCarte(evenement);
                flowLayoutPanelEvenements.Controls.Add(carteEvenement);
            }
        }

        /// <summary>
        /// Gère l’ouverture de la fenêtre de création de lot.
        /// </summary>
        private void OuvrirFormulaireCreationLot()
        {
            if (lotCreationForm == null || lotCreationForm.IsDisposed)
            {
                lotCreationForm = new LotCreation();
                lotCreationForm.LotAjoute += (s, args) => AfficherLots(Global.Lots);
            }

            lotCreationForm.Show();
            lotCreationForm.BringToFront();
        }

        /// <summary>
        /// Gère le clic sur le bouton "Créer un lot".
        /// </summary>
        private void btnCreerLot_Click(object sender, EventArgs e)
        {
            OuvrirFormulaireCreationLot();
        }

        /// <summary>
        /// Réagit à la modification du texte de recherche pour filtrer les lots.
        /// </summary>
        private void textBoxRechercheLot_TextChanged(object sender, EventArgs e)
        {
            FiltrerLots();
        }

        /// <summary>
        /// Réagit au changement de sélection dans la ComboBox des états.
        /// </summary>
        private void comboBoxEtat_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrerLots();
        }

        /// <summary>
        /// Applique un filtre sur les lots en fonction du texte saisi et de l’état sélectionné.
        /// </summary>
        private void FiltrerLots()
        {
            var recherche = textBoxRechercheLot.Text.ToLower();
            var idEtat = (comboBoxEtat.SelectedItem as Etat)?.Id ?? -1;

            var lotsFiltres = Global.Lots
                .Where(lot =>
                    (string.IsNullOrWhiteSpace(recherche) || lot.Nom.ToLower().Contains(recherche)) &&
                    (idEtat == -1 || lot.IdEtat == idEtat)
                );

            AfficherLots(lotsFiltres);
        }
    }
}
