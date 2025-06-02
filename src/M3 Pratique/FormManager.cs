using System;
using System.Windows.Forms;

namespace M3_Pratique
{
    /// <summary>
    /// Gestionnaire pour l'ouverture et la gestion des formulaires
    /// </summary>
    public static class FormManager
    {
        #region Instances des formulaires
        private static RecetteCreation _recetteCreationForm = null;
        private static RecetteInformation _recetteInformationForm = null;
        private static RecetteManager _recetteManagerForm = null;
        private static LotCreation _lotCreationForm = null;
        private static LotManager _lotManagerForm = null;

        public static RecetteManager RecetteManagerForm { get => _recetteManagerForm; set => _recetteManagerForm = value; }
        public static RecetteCreation RecetteCreationForm { get => _recetteCreationForm; set => _recetteCreationForm = value; }
        public static LotManager LotManagerForm { get => _lotManagerForm; set => _lotManagerForm = value; }
        #endregion

        #region Méthodes génériques de gestion des formulaires

        /// <summary>
        /// Ouvre ou met au premier plan un formulaire existant
        /// </summary>
        /// <typeparam name="T">Type du formulaire</typeparam>
        /// <param name="formInstance">Instance actuelle du formulaire</param>
        /// <param name="createNewForm">Fonction pour créer une nouvelle instance</param>
        /// <param name="updateForm">Action optionnelle pour mettre à jour le formulaire existant</param>
        /// <returns>L'instance du formulaire</returns>
        private static T OuvrirOuActiverFormulaire<T>(ref T formInstance, Func<T> createNewForm, Action<T> updateForm = null)
            where T : Form
        {
            // Vérifie si le formulaire existe et n'est pas fermé
            if (formInstance == null || formInstance.IsDisposed)
            {
                formInstance = createNewForm();
            }
            else if (updateForm != null)
            {
                // Met à jour le formulaire existant si une fonction de mise à jour est fournie
                updateForm(formInstance);
            }

            // Gestion de l'état de la fenêtre
            if (formInstance.WindowState == FormWindowState.Minimized)
                formInstance.WindowState = FormWindowState.Normal;

            // Affiche et met au premier plan
            formInstance.Show();
            formInstance.BringToFront();
            formInstance.Activate();

            return formInstance;
        }


        #endregion

        #region Méthodes spécifiques pour chaque formulaire

        /// <summary>
        /// Ouvre le formulaire d'information de recette
        /// </summary>
        /// <param name="recette">Recette à afficher</param>
        public static void OuvrirRecetteInformation(Recette recette)
        {
            _recetteInformationForm = OuvrirOuActiverFormulaire(
                ref _recetteInformationForm,
                () => new RecetteInformation(recette),
                (form) => form.MiseAJourInformation(recette)
            );
        }

        /// <summary>
        /// Ouvre le formulaire de gestion des recettes
        /// </summary>
        public static void OuvrirRecetteManager()
        {
            _recetteManagerForm = OuvrirOuActiverFormulaire(
                ref _recetteManagerForm,
                () => new RecetteManager()
            );
        }

        /// <summary>
        /// Ouvre le formulaire de création de lot
        /// </summary>
        /// <param name="onLotAjoute">Action à exécuter quand un lot est ajouté</param>
        public static void OuvrirLotCreation(Action onLotAjoute = null)
        {
            // Si le formulaire n'existe pas ou est fermé, on le crée
            if (_lotCreationForm == null || _lotCreationForm.IsDisposed)
            {
                _lotCreationForm = new LotCreation();

                // Abonnement à l'événement lors de la création
                if (onLotAjoute != null)
                {
                    _lotCreationForm.LotAjoute += (s, e) => onLotAjoute();
                }
            }

            // Gestion de l'état de la fenêtre
            if (_lotCreationForm.WindowState == FormWindowState.Minimized)
                _lotCreationForm.WindowState = FormWindowState.Normal;

            // Affichage et activation
            _lotCreationForm.Show();
            _lotCreationForm.BringToFront();
            _lotCreationForm.Activate();
        }

        /// <summary>
        /// Ouvre le formulaire de création de recette
        /// </summary>
        /// <param name="onRecetteAjoute">Action à exécuter</param>
        public static void OuvrirRecetteCreation(Action action = null)
        {
            // Si le formulaire n'existe pas ou est fermé, on le crée
            if (_recetteCreationForm == null || _recetteCreationForm.IsDisposed)
            {
                _recetteCreationForm = new RecetteCreation();

                // Abonnement à l'événement lors de la création
                if (action != null)
                {
                    _recetteCreationForm.RecetteAjoute += (s, e) => action();
                }
            }

            // Gestion de l'état de la fenêtre
            if (_recetteCreationForm.WindowState == FormWindowState.Minimized)
                _recetteCreationForm.WindowState = FormWindowState.Normal;

            // Affichage et activation
            _recetteCreationForm.Show();
            _recetteCreationForm.BringToFront();
            _recetteCreationForm.Activate();
        }

        /// <summary>
        /// Ouvre le formulaire de création de recette avec des données spécifiques
        /// </summary>
        /// <param name="recette">Recette à éditer</param>
        public static void OuvrirRecetteCreation(Recette recette)
        {
            _recetteCreationForm = OuvrirOuActiverFormulaire(
                ref _recetteCreationForm,
                () => new RecetteCreation(recette)
            );
        }

        #endregion
    }
}