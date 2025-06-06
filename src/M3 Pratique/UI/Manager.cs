﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using M3_Pratique.UI.Components;

namespace M3_Pratique
{
    /// <summary>
    /// Classe représentant le gestionnaire principal de l'application.
    /// </summary>
    public partial class Manager : Form
    {
        private LotCarte carteSelectionnee = null;

        /// <summary>
        /// Constructeur de la classe Manager.
        /// </summary>
        public Manager()
        {
            InitializeComponent();

            // Prépare la combobox des états
            InitialiserComboBoxEtat();

            // masque les controle de la groupBox 
            foreach (Control ctrl in groupBoxLotSelectionner.Controls)
            {
                ctrl.Visible = false;
            }

            // met a jour la combobox
            MiseAJourComboBoxRecette();

            // Affiche les recettes
            AfficherRecettes(Global.Recettes);

            // Affiche tous les lots
            AfficherLots(Global.Lots);
        }

        /// <summary>
        /// Initialise la combobox contenant les états possibles, avec un état "Tous".
        /// </summary>
        private void InitialiserComboBoxEtat()
        {
            comboBoxEtat.DataSource = null;

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
            buttonTypePiece.Text = lot.Recette.Nom;


            foreach (Control ctrl in groupBoxLotSelectionner.Controls)
            {
                ctrl.Visible = true;
            }
        }

        /// <summary>
        /// Affiche tous les événements associés à un lot.
        /// </summary>
        private void AfficherEvenementsLot(long idLot)
        {
            flowLayoutPanelEvenements.Controls.Clear();

            var evenements = Global.GetEvenementsByLot(idLot);

            groupBoxEvenement.Visible = evenements.Count > 0;

            foreach (var evenement in evenements)
            {
                var carteEvenement = new EvenementCarte(evenement);
                flowLayoutPanelEvenements.Controls.Add(carteEvenement);
            }
        }

        /// <summary>
        /// Réagit à la modification du texte de recherche pour filtrer les lots.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxRechercheLot_TextChanged(object sender, EventArgs e)
        {
            FiltrerLots();
        }

        /// <summary>
        /// Réagit au changement de sélection dans la ComboBox des états.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Rafraichit les données de l'application en récupérant les dernières informations depuis la base de données.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelIconRefresh_Click(object sender, EventArgs e)
        {
            if (Global.RecupererTout())
            {
                // Prépare la combobox des états
                InitialiserComboBoxEtat();

                // Affiche tous les lots
                AfficherLots(Global.Lots);
                // Affiche toutes les recettes
                AfficherRecettes(Global.Recettes);

                // Mise a jour de la combobox recette
                MiseAJourComboBoxRecette();
            }
        }

        /// <summary>
        /// Met à jour la ComboBox des recettes avec les recettes disponibles.
        /// </summary>
        private void MiseAJourComboBoxRecette()
        {
            // Ajout des recettes à la selection
            BindingList<Recette> recettes = new BindingList<Recette>();
            for (int i = 0; i < Global.Recettes.Count; i++)
            {
                recettes.Add(new Recette(Global.Recettes[i].Id, Global.Recettes[i].Nom, Global.Recettes[i].DateCreation));
            }
            comboBoxRecette.ValueMember = null;
            comboBoxRecette.DisplayMember = "Nom";
            comboBoxRecette.DataSource = recettes;
        }

        /// <summary>
        /// Ouvre la fenêtre d'information de la recette associée au lot sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTypePiece_Click(object sender, EventArgs e)
        {
            FormManager.OuvrirRecetteInformation(carteSelectionnee.Lot.Recette);
        }

        /// <summary>
        /// Crée un nouveau lot en fonction des informations saisies dans les champs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreer_Click(object sender, EventArgs e)
        {
            // Vérification des champs
            if (numericUpDownNbPiece.Value <= 0)
            {
                MessageBox.Show("Le nombre de pièce doit être supérieur à 0", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxRecette.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une recette", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idEtat = 1;

                Global.AjouterLot((int)numericUpDownNbPiece.Value, idEtat, ((Recette)comboBoxRecette.SelectedItem).Id, ((Recette)comboBoxRecette.SelectedItem).Nom);

                // Ajout de l'évènement pour mettre à jours la listes des lots
                AfficherLots(Global.Lots);

                // Sélectionne le dernier lot créé
                SelectionCarte(flowLayoutPanelLots.Controls[0] as LotCarte, Global.Lots.Last().Id);

            }
        }

        /// <summary>
        /// Ouvre le formulaire de création de recette pour ajouter une nouvelle recette.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerRecette_Click(object sender, EventArgs e)
        {
            FormManager.OuvrirRecetteCreation(() => AfficherRecettes(Global.Recettes));
        }


        /// <summary>
        /// Applique un filtre sur les recettes en fonction du texte saisi
        /// </summary>
        private void FiltrerRecettes()
        {
            var recherche = textBoxRechercheRecette.Text.ToLower();

            var recettesFiltres = Global.Recettes
                .Where(recette =>
                    (string.IsNullOrWhiteSpace(recherche) || recette.Nom.ToLower().Contains(recherche)));

            AfficherRecettes(recettesFiltres);
        }

        /// <summary>
        /// Réagit à la modification du texte de recherche pour filtrer les lots.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxRechercheRecette_TextChanged(object sender, EventArgs e)
        {
            FiltrerRecettes();
        }

        /// <summary>
        /// Affiche une collection de lots dans le FlowLayoutPanel.
        /// </summary>
        /// <param name="recettes">Recette à afficher</param>
        public void AfficherRecettes(IEnumerable<Recette> recettes)
        {
            flowLayoutPanelRecettes.Controls.Clear();

            foreach (var recette in recettes)
            {
                var carte = new RecetteCarte(recette);
                flowLayoutPanelRecettes.Controls.Add(carte);
            }
        }
    }
}
