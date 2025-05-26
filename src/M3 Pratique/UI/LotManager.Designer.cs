namespace M3_Pratique
{
    partial class LotManager
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
            this.btnCreerLot = new System.Windows.Forms.Button();
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
            this.buttonRecette = new System.Windows.Forms.Button();
            this.LabelIconRefresh = new System.Windows.Forms.Label();
            this.labelRechercherIcon = new System.Windows.Forms.Label();
            this.groupBoxLotSelectionner.SuspendLayout();
            this.groupBoxEvenement.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreerLot
            // 
            this.btnCreerLot.Location = new System.Drawing.Point(350, 15);
            this.btnCreerLot.Name = "btnCreerLot";
            this.btnCreerLot.Size = new System.Drawing.Size(100, 30);
            this.btnCreerLot.TabIndex = 0;
            this.btnCreerLot.Text = "Créer";
            this.btnCreerLot.UseVisualStyleBackColor = true;
            this.btnCreerLot.Click += new System.EventHandler(this.btnCreerLot_Click);
            // 
            // flowLayoutPanelLots
            // 
            this.flowLayoutPanelLots.AutoScroll = true;
            this.flowLayoutPanelLots.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelLots.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelLots.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanelLots.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelLots.Name = "flowLayoutPanelLots";
            this.flowLayoutPanelLots.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.flowLayoutPanelLots.Size = new System.Drawing.Size(450, 953);
            this.flowLayoutPanelLots.TabIndex = 1;
            this.flowLayoutPanelLots.WrapContents = false;
            this.flowLayoutPanelLots.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelLots_Paint);
            // 
            // textBoxRechercheLot
            // 
            this.textBoxRechercheLot.Location = new System.Drawing.Point(20, 19);
            this.textBoxRechercheLot.Name = "textBoxRechercheLot";
            this.textBoxRechercheLot.Size = new System.Drawing.Size(220, 22);
            this.textBoxRechercheLot.TabIndex = 2;
            this.textBoxRechercheLot.TextChanged += new System.EventHandler(this.textBoxRechercheLot_TextChanged);
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Location = new System.Drawing.Point(20, 50);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(80, 24);
            this.comboBoxEtat.TabIndex = 4;
            this.comboBoxEtat.SelectedIndexChanged += new System.EventHandler(this.comboBoxEtat_SelectedIndexChanged);
            // 
            // groupBoxLotSelectionner
            // 
            this.groupBoxLotSelectionner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.groupBoxLotSelectionner.Location = new System.Drawing.Point(460, 15);
            this.groupBoxLotSelectionner.Name = "groupBoxLotSelectionner";
            this.groupBoxLotSelectionner.Size = new System.Drawing.Size(1440, 1004);
            this.groupBoxLotSelectionner.TabIndex = 6;
            this.groupBoxLotSelectionner.TabStop = false;
            this.groupBoxLotSelectionner.Text = "Lot sélectionné";
            this.groupBoxLotSelectionner.Visible = false;
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
            // buttonRecette
            // 
            this.buttonRecette.Location = new System.Drawing.Point(350, 50);
            this.buttonRecette.Name = "buttonRecette";
            this.buttonRecette.Size = new System.Drawing.Size(100, 30);
            this.buttonRecette.TabIndex = 7;
            this.buttonRecette.Text = "Recette";
            this.buttonRecette.UseVisualStyleBackColor = true;
            this.buttonRecette.Click += new System.EventHandler(this.buttonRecette_Click);
            // 
            // LabelIconRefresh
            // 
            this.LabelIconRefresh.BackColor = System.Drawing.Color.Transparent;
            this.LabelIconRefresh.Image = global::M3_Pratique.Properties.Resources.refresh;
            this.LabelIconRefresh.Location = new System.Drawing.Point(300, 15);
            this.LabelIconRefresh.Name = "LabelIconRefresh";
            this.LabelIconRefresh.Size = new System.Drawing.Size(30, 30);
            this.LabelIconRefresh.TabIndex = 8;
            this.LabelIconRefresh.Click += new System.EventHandler(this.LabelIconRefresh_Click);
            // 
            // labelRechercherIcon
            // 
            this.labelRechercherIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelRechercherIcon.Image = global::M3_Pratique.Properties.Resources.rechercheIcon;
            this.labelRechercherIcon.Location = new System.Drawing.Point(230, 15);
            this.labelRechercherIcon.Margin = new System.Windows.Forms.Padding(0);
            this.labelRechercherIcon.Name = "labelRechercherIcon";
            this.labelRechercherIcon.Size = new System.Drawing.Size(30, 30);
            this.labelRechercherIcon.TabIndex = 3;
            // 
            // LotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.LabelIconRefresh);
            this.Controls.Add(this.buttonRecette);
            this.Controls.Add(this.groupBoxLotSelectionner);
            this.Controls.Add(this.comboBoxEtat);
            this.Controls.Add(this.labelRechercherIcon);
            this.Controls.Add(this.textBoxRechercheLot);
            this.Controls.Add(this.flowLayoutPanelLots);
            this.Controls.Add(this.btnCreerLot);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LotManager";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.Text = "Manager de lot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxLotSelectionner.ResumeLayout(false);
            this.groupBoxLotSelectionner.PerformLayout();
            this.groupBoxEvenement.ResumeLayout(false);
            this.groupBoxEvenement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreerLot;
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
        private System.Windows.Forms.Button buttonRecette;
        private System.Windows.Forms.Label LabelIconRefresh;
        private System.Windows.Forms.Button buttonTypePiece;
    }
}

