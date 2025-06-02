namespace M3_Pratique
{
    partial class Manager
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelLots = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxRechercheLot = new System.Windows.Forms.TextBox();
            this.comboBoxEtat = new System.Windows.Forms.ComboBox();
            this.groupBoxLotSelectionner = new System.Windows.Forms.GroupBox();
            this.buttonTypePiece = new System.Windows.Forms.Button();
            this.groupBoxEvenement = new System.Windows.Forms.GroupBox();
            this.labelEvenementMessage = new System.Windows.Forms.Label();
            this.labelEvenementDate = new System.Windows.Forms.Label();
            this.flowLayoutPanelEvenements = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNbPiece = new System.Windows.Forms.Label();
            this.labelCreation = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            this.labelTitreType = new System.Windows.Forms.Label();
            this.labelTitreNbPièce = new System.Windows.Forms.Label();
            this.labelTitreCreation = new System.Windows.Forms.Label();
            this.labelTitreEtat = new System.Windows.Forms.Label();
            this.labelLotNom = new System.Windows.Forms.Label();
            this.groupBoxListeLots = new System.Windows.Forms.GroupBox();
            this.labelRechercherIcon = new System.Windows.Forms.Label();
            this.groupBoxListeRecette = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelRecettes = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelIconRefresh = new System.Windows.Forms.Label();
            this.textBoxRechercheRecette = new System.Windows.Forms.TextBox();
            this.btnCreerRecette = new System.Windows.Forms.Button();
            this.groupBoxCreationLot = new System.Windows.Forms.GroupBox();
            this.comboBoxRecette = new System.Windows.Forms.ComboBox();
            this.labelRecette = new System.Windows.Forms.Label();
            this.numericUpDownNbPiece = new System.Windows.Forms.NumericUpDown();
            this.labelNombrePiece = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.groupBoxLotSelectionner.SuspendLayout();
            this.groupBoxEvenement.SuspendLayout();
            this.groupBoxListeLots.SuspendLayout();
            this.groupBoxListeRecette.SuspendLayout();
            this.groupBoxCreationLot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelLots
            // 
            this.flowLayoutPanelLots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelLots.AutoScroll = true;
            this.flowLayoutPanelLots.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelLots.Location = new System.Drawing.Point(20, 95);
            this.flowLayoutPanelLots.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelLots.Name = "flowLayoutPanelLots";
            this.flowLayoutPanelLots.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.flowLayoutPanelLots.Size = new System.Drawing.Size(500, 900);
            this.flowLayoutPanelLots.TabIndex = 1;
            this.flowLayoutPanelLots.WrapContents = false;
            this.flowLayoutPanelLots.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelLots_Paint);
            // 
            // textBoxRechercheLot
            // 
            this.textBoxRechercheLot.Location = new System.Drawing.Point(20, 29);
            this.textBoxRechercheLot.Name = "textBoxRechercheLot";
            this.textBoxRechercheLot.Size = new System.Drawing.Size(220, 22);
            this.textBoxRechercheLot.TabIndex = 2;
            this.textBoxRechercheLot.TextChanged += new System.EventHandler(this.textBoxRechercheLot_TextChanged);
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Location = new System.Drawing.Point(20, 60);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(80, 24);
            this.comboBoxEtat.TabIndex = 4;
            this.comboBoxEtat.SelectedIndexChanged += new System.EventHandler(this.comboBoxEtat_SelectedIndexChanged);
            // 
            // groupBoxLotSelectionner
            // 
            this.groupBoxLotSelectionner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLotSelectionner.Controls.Add(this.buttonTypePiece);
            this.groupBoxLotSelectionner.Controls.Add(this.groupBoxEvenement);
            this.groupBoxLotSelectionner.Controls.Add(this.labelNbPiece);
            this.groupBoxLotSelectionner.Controls.Add(this.labelCreation);
            this.groupBoxLotSelectionner.Controls.Add(this.labelEtat);
            this.groupBoxLotSelectionner.Controls.Add(this.labelTitreType);
            this.groupBoxLotSelectionner.Controls.Add(this.labelTitreNbPièce);
            this.groupBoxLotSelectionner.Controls.Add(this.labelTitreCreation);
            this.groupBoxLotSelectionner.Controls.Add(this.labelTitreEtat);
            this.groupBoxLotSelectionner.Controls.Add(this.labelLotNom);
            this.groupBoxLotSelectionner.Location = new System.Drawing.Point(640, 10);
            this.groupBoxLotSelectionner.Name = "groupBoxLotSelectionner";
            this.groupBoxLotSelectionner.Size = new System.Drawing.Size(620, 600);
            this.groupBoxLotSelectionner.TabIndex = 6;
            this.groupBoxLotSelectionner.TabStop = false;
            this.groupBoxLotSelectionner.Text = "Lot sélectionné";
            // 
            // buttonTypePiece
            // 
            this.buttonTypePiece.Location = new System.Drawing.Point(136, 141);
            this.buttonTypePiece.Name = "buttonTypePiece";
            this.buttonTypePiece.Size = new System.Drawing.Size(104, 24);
            this.buttonTypePiece.TabIndex = 13;
            this.buttonTypePiece.Text = "Type de pièce";
            this.buttonTypePiece.UseVisualStyleBackColor = true;
            this.buttonTypePiece.Click += new System.EventHandler(this.buttonTypePiece_Click);
            // 
            // groupBoxEvenement
            // 
            this.groupBoxEvenement.Controls.Add(this.labelEvenementMessage);
            this.groupBoxEvenement.Controls.Add(this.labelEvenementDate);
            this.groupBoxEvenement.Controls.Add(this.flowLayoutPanelEvenements);
            this.groupBoxEvenement.Location = new System.Drawing.Point(20, 180);
            this.groupBoxEvenement.Name = "groupBoxEvenement";
            this.groupBoxEvenement.Size = new System.Drawing.Size(420, 380);
            this.groupBoxEvenement.TabIndex = 12;
            this.groupBoxEvenement.TabStop = false;
            this.groupBoxEvenement.Text = "Evénement";
            // 
            // labelEvenementMessage
            // 
            this.labelEvenementMessage.AutoSize = true;
            this.labelEvenementMessage.Location = new System.Drawing.Point(150, 20);
            this.labelEvenementMessage.Name = "labelEvenementMessage";
            this.labelEvenementMessage.Size = new System.Drawing.Size(64, 16);
            this.labelEvenementMessage.TabIndex = 11;
            this.labelEvenementMessage.Text = "Message";
            // 
            // labelEvenementDate
            // 
            this.labelEvenementDate.AutoSize = true;
            this.labelEvenementDate.Location = new System.Drawing.Point(10, 20);
            this.labelEvenementDate.Name = "labelEvenementDate";
            this.labelEvenementDate.Size = new System.Drawing.Size(36, 16);
            this.labelEvenementDate.TabIndex = 10;
            this.labelEvenementDate.Text = "Date";
            // 
            // flowLayoutPanelEvenements
            // 
            this.flowLayoutPanelEvenements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelEvenements.AutoScroll = true;
            this.flowLayoutPanelEvenements.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelEvenements.Location = new System.Drawing.Point(10, 40);
            this.flowLayoutPanelEvenements.Name = "flowLayoutPanelEvenements";
            this.flowLayoutPanelEvenements.Size = new System.Drawing.Size(400, 330);
            this.flowLayoutPanelEvenements.TabIndex = 9;
            this.flowLayoutPanelEvenements.WrapContents = false;
            this.flowLayoutPanelEvenements.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelEvenements_Paint);
            // 
            // labelNbPiece
            // 
            this.labelNbPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbPiece.Location = new System.Drawing.Point(155, 120);
            this.labelNbPiece.Name = "labelNbPiece";
            this.labelNbPiece.Size = new System.Drawing.Size(85, 16);
            this.labelNbPiece.TabIndex = 7;
            this.labelNbPiece.Text = "Nb Pièce";
            this.labelNbPiece.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCreation
            // 
            this.labelCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreation.Location = new System.Drawing.Point(150, 95);
            this.labelCreation.Name = "labelCreation";
            this.labelCreation.Size = new System.Drawing.Size(90, 16);
            this.labelCreation.TabIndex = 6;
            this.labelCreation.Text = "Creation";
            this.labelCreation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelEtat
            // 
            this.labelEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtat.Location = new System.Drawing.Point(62, 70);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(178, 16);
            this.labelEtat.TabIndex = 5;
            this.labelEtat.Text = "Etat";
            this.labelEtat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTitreType
            // 
            this.labelTitreType.AutoSize = true;
            this.labelTitreType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreType.Location = new System.Drawing.Point(20, 145);
            this.labelTitreType.Name = "labelTitreType";
            this.labelTitreType.Size = new System.Drawing.Size(116, 16);
            this.labelTitreType.TabIndex = 4;
            this.labelTitreType.Text = "Type de pièce :";
            // 
            // labelTitreNbPièce
            // 
            this.labelTitreNbPièce.AutoSize = true;
            this.labelTitreNbPièce.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreNbPièce.Location = new System.Drawing.Point(20, 120);
            this.labelTitreNbPièce.Name = "labelTitreNbPièce";
            this.labelTitreNbPièce.Size = new System.Drawing.Size(135, 16);
            this.labelTitreNbPièce.TabIndex = 3;
            this.labelTitreNbPièce.Text = "Nombre de pièce :";
            // 
            // labelTitreCreation
            // 
            this.labelTitreCreation.AutoSize = true;
            this.labelTitreCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreCreation.Location = new System.Drawing.Point(20, 95);
            this.labelTitreCreation.Name = "labelTitreCreation";
            this.labelTitreCreation.Size = new System.Drawing.Size(130, 16);
            this.labelTitreCreation.TabIndex = 2;
            this.labelTitreCreation.Text = "Date de création :";
            // 
            // labelTitreEtat
            // 
            this.labelTitreEtat.AutoSize = true;
            this.labelTitreEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreEtat.Location = new System.Drawing.Point(20, 70);
            this.labelTitreEtat.Name = "labelTitreEtat";
            this.labelTitreEtat.Size = new System.Drawing.Size(42, 16);
            this.labelTitreEtat.TabIndex = 1;
            this.labelTitreEtat.Text = "Etat :";
            // 
            // labelLotNom
            // 
            this.labelLotNom.AutoSize = true;
            this.labelLotNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLotNom.Location = new System.Drawing.Point(20, 30);
            this.labelLotNom.Name = "labelLotNom";
            this.labelLotNom.Size = new System.Drawing.Size(47, 20);
            this.labelLotNom.TabIndex = 0;
            this.labelLotNom.Text = "Nom";
            // 
            // groupBoxListeLots
            // 
            this.groupBoxListeLots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxListeLots.Controls.Add(this.textBoxRechercheLot);
            this.groupBoxListeLots.Controls.Add(this.comboBoxEtat);
            this.groupBoxListeLots.Controls.Add(this.flowLayoutPanelLots);
            this.groupBoxListeLots.Controls.Add(this.labelRechercherIcon);
            this.groupBoxListeLots.Location = new System.Drawing.Point(10, 10);
            this.groupBoxListeLots.Name = "groupBoxListeLots";
            this.groupBoxListeLots.Size = new System.Drawing.Size(620, 1000);
            this.groupBoxListeLots.TabIndex = 9;
            this.groupBoxListeLots.TabStop = false;
            this.groupBoxListeLots.Text = "Liste de lots";
            // 
            // labelRechercherIcon
            // 
            this.labelRechercherIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelRechercherIcon.Image = global::M3_Pratique.Properties.Resources.rechercheIcon;
            this.labelRechercherIcon.Location = new System.Drawing.Point(240, 25);
            this.labelRechercherIcon.Margin = new System.Windows.Forms.Padding(0);
            this.labelRechercherIcon.Name = "labelRechercherIcon";
            this.labelRechercherIcon.Size = new System.Drawing.Size(30, 30);
            this.labelRechercherIcon.TabIndex = 3;
            // 
            // groupBoxListeRecette
            // 
            this.groupBoxListeRecette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxListeRecette.Controls.Add(this.label1);
            this.groupBoxListeRecette.Controls.Add(this.flowLayoutPanelRecettes);
            this.groupBoxListeRecette.Controls.Add(this.LabelIconRefresh);
            this.groupBoxListeRecette.Controls.Add(this.textBoxRechercheRecette);
            this.groupBoxListeRecette.Controls.Add(this.btnCreerRecette);
            this.groupBoxListeRecette.Location = new System.Drawing.Point(1270, 10);
            this.groupBoxListeRecette.Name = "groupBoxListeRecette";
            this.groupBoxListeRecette.Size = new System.Drawing.Size(620, 1000);
            this.groupBoxListeRecette.TabIndex = 10;
            this.groupBoxListeRecette.TabStop = false;
            this.groupBoxListeRecette.Text = "Liste de recettes";
            this.groupBoxListeRecette.Enter += new System.EventHandler(this.groupBoxListeRecette_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::M3_Pratique.Properties.Resources.rechercheIcon;
            this.label1.Location = new System.Drawing.Point(270, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 30);
            this.label1.TabIndex = 5;
            // 
            // flowLayoutPanelRecettes
            // 
            this.flowLayoutPanelRecettes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelRecettes.AutoScroll = true;
            this.flowLayoutPanelRecettes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelRecettes.Location = new System.Drawing.Point(40, 100);
            this.flowLayoutPanelRecettes.Name = "flowLayoutPanelRecettes";
            this.flowLayoutPanelRecettes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.flowLayoutPanelRecettes.Size = new System.Drawing.Size(450, 850);
            this.flowLayoutPanelRecettes.TabIndex = 8;
            this.flowLayoutPanelRecettes.WrapContents = false;
            this.flowLayoutPanelRecettes.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelRecettes_Paint);
            // 
            // LabelIconRefresh
            // 
            this.LabelIconRefresh.BackColor = System.Drawing.Color.Transparent;
            this.LabelIconRefresh.Image = global::M3_Pratique.Properties.Resources.refresh;
            this.LabelIconRefresh.Location = new System.Drawing.Point(587, -2);
            this.LabelIconRefresh.Name = "LabelIconRefresh";
            this.LabelIconRefresh.Size = new System.Drawing.Size(30, 30);
            this.LabelIconRefresh.TabIndex = 8;
            this.LabelIconRefresh.Click += new System.EventHandler(this.LabelIconRefresh_Click);
            // 
            // textBoxRechercheRecette
            // 
            this.textBoxRechercheRecette.Location = new System.Drawing.Point(40, 39);
            this.textBoxRechercheRecette.Name = "textBoxRechercheRecette";
            this.textBoxRechercheRecette.Size = new System.Drawing.Size(220, 22);
            this.textBoxRechercheRecette.TabIndex = 6;
            this.textBoxRechercheRecette.TextChanged += new System.EventHandler(this.textBoxRechercheRecette_TextChanged);
            // 
            // btnCreerRecette
            // 
            this.btnCreerRecette.Location = new System.Drawing.Point(350, 35);
            this.btnCreerRecette.Name = "btnCreerRecette";
            this.btnCreerRecette.Size = new System.Drawing.Size(150, 30);
            this.btnCreerRecette.TabIndex = 5;
            this.btnCreerRecette.Text = "Nouvelle Recette";
            this.btnCreerRecette.UseVisualStyleBackColor = true;
            this.btnCreerRecette.Click += new System.EventHandler(this.btnCreerRecette_Click);
            // 
            // groupBoxCreationLot
            // 
            this.groupBoxCreationLot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCreationLot.Controls.Add(this.comboBoxRecette);
            this.groupBoxCreationLot.Controls.Add(this.labelRecette);
            this.groupBoxCreationLot.Controls.Add(this.numericUpDownNbPiece);
            this.groupBoxCreationLot.Controls.Add(this.labelNombrePiece);
            this.groupBoxCreationLot.Controls.Add(this.btnCreer);
            this.groupBoxCreationLot.Location = new System.Drawing.Point(640, 620);
            this.groupBoxCreationLot.Name = "groupBoxCreationLot";
            this.groupBoxCreationLot.Size = new System.Drawing.Size(620, 390);
            this.groupBoxCreationLot.TabIndex = 11;
            this.groupBoxCreationLot.TabStop = false;
            this.groupBoxCreationLot.Text = "Création d\'un lot";
            this.groupBoxCreationLot.Enter += new System.EventHandler(this.groupBoxCreationLot_Enter);
            // 
            // comboBoxRecette
            // 
            this.comboBoxRecette.FormattingEnabled = true;
            this.comboBoxRecette.Location = new System.Drawing.Point(200, 139);
            this.comboBoxRecette.Name = "comboBoxRecette";
            this.comboBoxRecette.Size = new System.Drawing.Size(120, 24);
            this.comboBoxRecette.TabIndex = 12;
            // 
            // labelRecette
            // 
            this.labelRecette.AutoSize = true;
            this.labelRecette.Location = new System.Drawing.Point(50, 142);
            this.labelRecette.Name = "labelRecette";
            this.labelRecette.Size = new System.Drawing.Size(95, 16);
            this.labelRecette.TabIndex = 11;
            this.labelRecette.Text = "Type de pièce";
            // 
            // numericUpDownNbPiece
            // 
            this.numericUpDownNbPiece.Location = new System.Drawing.Point(200, 99);
            this.numericUpDownNbPiece.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownNbPiece.Name = "numericUpDownNbPiece";
            this.numericUpDownNbPiece.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNbPiece.TabIndex = 10;
            this.numericUpDownNbPiece.ValueChanged += new System.EventHandler(this.numericUpDownNbPiece_ValueChanged);
            // 
            // labelNombrePiece
            // 
            this.labelNombrePiece.AutoSize = true;
            this.labelNombrePiece.Location = new System.Drawing.Point(50, 102);
            this.labelNombrePiece.Name = "labelNombrePiece";
            this.labelNombrePiece.Size = new System.Drawing.Size(112, 16);
            this.labelNombrePiece.TabIndex = 9;
            this.labelNombrePiece.Text = "Nombre de pièce";
            this.labelNombrePiece.Click += new System.EventHandler(this.labelNombrePiece_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreer.Location = new System.Drawing.Point(450, 250);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(100, 50);
            this.btnCreer.TabIndex = 7;
            this.btnCreer.Text = "Créer un lot";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.groupBoxCreationLot);
            this.Controls.Add(this.groupBoxListeRecette);
            this.Controls.Add(this.groupBoxListeLots);
            this.Controls.Add(this.groupBoxLotSelectionner);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manager";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.Text = "Lots et recettes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxLotSelectionner.ResumeLayout(false);
            this.groupBoxLotSelectionner.PerformLayout();
            this.groupBoxEvenement.ResumeLayout(false);
            this.groupBoxEvenement.PerformLayout();
            this.groupBoxListeLots.ResumeLayout(false);
            this.groupBoxListeLots.PerformLayout();
            this.groupBoxListeRecette.ResumeLayout(false);
            this.groupBoxListeRecette.PerformLayout();
            this.groupBoxCreationLot.ResumeLayout(false);
            this.groupBoxCreationLot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbPiece)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLots;
        private System.Windows.Forms.TextBox textBoxRechercheLot;
        private System.Windows.Forms.Label labelRechercherIcon;
        private System.Windows.Forms.ComboBox comboBoxEtat;
        private System.Windows.Forms.GroupBox groupBoxLotSelectionner;
        private System.Windows.Forms.Label labelTitreCreation;
        private System.Windows.Forms.Label labelTitreEtat;
        private System.Windows.Forms.Label labelLotNom;
        private System.Windows.Forms.Label labelTitreNbPièce;
        private System.Windows.Forms.Label labelTitreType;
        private System.Windows.Forms.Label labelNbPiece;
        private System.Windows.Forms.Label labelCreation;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEvenements;
        private System.Windows.Forms.Label labelEvenementMessage;
        private System.Windows.Forms.Label labelEvenementDate;
        private System.Windows.Forms.GroupBox groupBoxEvenement;
        private System.Windows.Forms.Label LabelIconRefresh;
        private System.Windows.Forms.Button buttonTypePiece;
        private System.Windows.Forms.GroupBox groupBoxListeLots;
        private System.Windows.Forms.GroupBox groupBoxListeRecette;
        private System.Windows.Forms.GroupBox groupBoxCreationLot;
        private System.Windows.Forms.ComboBox comboBoxRecette;
        private System.Windows.Forms.Label labelRecette;
        private System.Windows.Forms.NumericUpDown numericUpDownNbPiece;
        private System.Windows.Forms.Label labelNombrePiece;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnCreerRecette;
        private System.Windows.Forms.TextBox textBoxRechercheRecette;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRecettes;
        private System.Windows.Forms.Label label1;
    }
}

