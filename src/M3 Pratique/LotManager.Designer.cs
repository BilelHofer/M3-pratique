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
            this.labelRechercherIcon = new System.Windows.Forms.Label();
            this.comboBoxEtat = new System.Windows.Forms.ComboBox();
            this.groupBoxLotSelectionner = new System.Windows.Forms.GroupBox();
            this.labelRecette = new System.Windows.Forms.Label();
            this.labelNbPiece = new System.Windows.Forms.Label();
            this.labelCreation = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            this.labelTitreType = new System.Windows.Forms.Label();
            this.labelTitreNbPièce = new System.Windows.Forms.Label();
            this.labelTitreCreation = new System.Windows.Forms.Label();
            this.labelTitreEtat = new System.Windows.Forms.Label();
            this.labelLotNom = new System.Windows.Forms.Label();
            this.groupBoxLotSelectionner.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreerLot
            // 
            this.btnCreerLot.Location = new System.Drawing.Point(331, 14);
            this.btnCreerLot.Name = "btnCreerLot";
            this.btnCreerLot.Size = new System.Drawing.Size(86, 32);
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
            this.flowLayoutPanelLots.Name = "flowLayoutPanelLots";
            this.flowLayoutPanelLots.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.flowLayoutPanelLots.Size = new System.Drawing.Size(443, 510);
            this.flowLayoutPanelLots.TabIndex = 1;
            this.flowLayoutPanelLots.WrapContents = false;
            // 
            // textBoxRechercheLot
            // 
            this.textBoxRechercheLot.Location = new System.Drawing.Point(12, 14);
            this.textBoxRechercheLot.Name = "textBoxRechercheLot";
            this.textBoxRechercheLot.Size = new System.Drawing.Size(219, 22);
            this.textBoxRechercheLot.TabIndex = 2;
            this.textBoxRechercheLot.TextChanged += new System.EventHandler(this.textBoxRechercheLot_TextChanged);
            // 
            // labelRechercherIcon
            // 
            this.labelRechercherIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelRechercherIcon.Image = global::M3_Pratique.Properties.Resources.rechercheIcon;
            this.labelRechercherIcon.Location = new System.Drawing.Point(236, 10);
            this.labelRechercherIcon.Name = "labelRechercherIcon";
            this.labelRechercherIcon.Size = new System.Drawing.Size(34, 31);
            this.labelRechercherIcon.TabIndex = 3;
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Location = new System.Drawing.Point(12, 44);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(76, 24);
            this.comboBoxEtat.TabIndex = 4;
            this.comboBoxEtat.SelectedIndexChanged += new System.EventHandler(this.comboBoxEtat_SelectedIndexChanged);
            // 
            // groupBoxLotSelectionner
            // 
            this.groupBoxLotSelectionner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLotSelectionner.Controls.Add(this.labelRecette);
            this.groupBoxLotSelectionner.Controls.Add(this.labelNbPiece);
            this.groupBoxLotSelectionner.Controls.Add(this.labelCreation);
            this.groupBoxLotSelectionner.Controls.Add(this.labelEtat);
            this.groupBoxLotSelectionner.Controls.Add(this.labelTitreType);
            this.groupBoxLotSelectionner.Controls.Add(this.labelTitreNbPièce);
            this.groupBoxLotSelectionner.Controls.Add(this.labelTitreCreation);
            this.groupBoxLotSelectionner.Controls.Add(this.labelTitreEtat);
            this.groupBoxLotSelectionner.Controls.Add(this.labelLotNom);
            this.groupBoxLotSelectionner.Location = new System.Drawing.Point(463, 14);
            this.groupBoxLotSelectionner.Name = "groupBoxLotSelectionner";
            this.groupBoxLotSelectionner.Size = new System.Drawing.Size(544, 561);
            this.groupBoxLotSelectionner.TabIndex = 6;
            this.groupBoxLotSelectionner.TabStop = false;
            this.groupBoxLotSelectionner.Text = "Lot sélectionné";
            this.groupBoxLotSelectionner.Visible = false;
            // 
            // labelRecette
            // 
            this.labelRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecette.Location = new System.Drawing.Point(134, 145);
            this.labelRecette.Name = "labelRecette";
            this.labelRecette.Size = new System.Drawing.Size(116, 16);
            this.labelRecette.TabIndex = 8;
            this.labelRecette.Text = "Type de pièce";
            this.labelRecette.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelNbPiece
            // 
            this.labelNbPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNbPiece.Location = new System.Drawing.Point(149, 119);
            this.labelNbPiece.Name = "labelNbPiece";
            this.labelNbPiece.Size = new System.Drawing.Size(101, 16);
            this.labelNbPiece.TabIndex = 7;
            this.labelNbPiece.Text = "Nb Pièce";
            this.labelNbPiece.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCreation
            // 
            this.labelCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreation.Location = new System.Drawing.Point(149, 93);
            this.labelCreation.Name = "labelCreation";
            this.labelCreation.Size = new System.Drawing.Size(101, 16);
            this.labelCreation.TabIndex = 6;
            this.labelCreation.Text = "Creation";
            this.labelCreation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelEtat
            // 
            this.labelEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtat.Location = new System.Drawing.Point(60, 66);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(190, 16);
            this.labelEtat.TabIndex = 5;
            this.labelEtat.Text = "Etat";
            this.labelEtat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTitreType
            // 
            this.labelTitreType.AutoSize = true;
            this.labelTitreType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreType.Location = new System.Drawing.Point(21, 145);
            this.labelTitreType.Name = "labelTitreType";
            this.labelTitreType.Size = new System.Drawing.Size(116, 16);
            this.labelTitreType.TabIndex = 4;
            this.labelTitreType.Text = "Type de pièce :";
            // 
            // labelTitreNbPièce
            // 
            this.labelTitreNbPièce.AutoSize = true;
            this.labelTitreNbPièce.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreNbPièce.Location = new System.Drawing.Point(21, 119);
            this.labelTitreNbPièce.Name = "labelTitreNbPièce";
            this.labelTitreNbPièce.Size = new System.Drawing.Size(135, 16);
            this.labelTitreNbPièce.TabIndex = 3;
            this.labelTitreNbPièce.Text = "Nombre de pièce :";
            // 
            // labelTitreCreation
            // 
            this.labelTitreCreation.AutoSize = true;
            this.labelTitreCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreCreation.Location = new System.Drawing.Point(19, 93);
            this.labelTitreCreation.Name = "labelTitreCreation";
            this.labelTitreCreation.Size = new System.Drawing.Size(130, 16);
            this.labelTitreCreation.TabIndex = 2;
            this.labelTitreCreation.Text = "Date de création :";
            // 
            // labelTitreEtat
            // 
            this.labelTitreEtat.AutoSize = true;
            this.labelTitreEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreEtat.Location = new System.Drawing.Point(20, 66);
            this.labelTitreEtat.Name = "labelTitreEtat";
            this.labelTitreEtat.Size = new System.Drawing.Size(42, 16);
            this.labelTitreEtat.TabIndex = 1;
            this.labelTitreEtat.Text = "Etat :";
            // 
            // labelLotNom
            // 
            this.labelLotNom.AutoSize = true;
            this.labelLotNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLotNom.Location = new System.Drawing.Point(19, 30);
            this.labelLotNom.Name = "labelLotNom";
            this.labelLotNom.Size = new System.Drawing.Size(47, 20);
            this.labelLotNom.TabIndex = 0;
            this.labelLotNom.Text = "Nom";
            // 
            // LotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 590);
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
            this.groupBoxLotSelectionner.ResumeLayout(false);
            this.groupBoxLotSelectionner.PerformLayout();
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
        private System.Windows.Forms.Label labelRecette;
        private System.Windows.Forms.Label labelNbPiece;
        private System.Windows.Forms.Label labelCreation;
        private System.Windows.Forms.Label labelEtat;
    }
}

