namespace M3_Pratique
{
    partial class RecetteInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomRecette = new System.Windows.Forms.Label();
            this.labelInfoDate = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.groupBoxOpération = new System.Windows.Forms.GroupBox();
            this.labelEnTeteSensHoraire = new System.Windows.Forms.Label();
            this.labelEnTeteQuittance = new System.Windows.Forms.Label();
            this.labelEnTeteCycleVerin = new System.Windows.Forms.Label();
            this.labelEnTeteTempsAttente = new System.Windows.Forms.Label();
            this.labelEnTetePosMoteur = new System.Windows.Forms.Label();
            this.labelEnTeteNom = new System.Windows.Forms.Label();
            this.labelEnTeteNum = new System.Windows.Forms.Label();
            this.flowLayoutPanelOperations = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonModifierRecette = new System.Windows.Forms.Button();
            this.buttonSupprimerRecette = new System.Windows.Forms.Button();
            this.groupBoxOpération.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomRecette
            // 
            this.labelNomRecette.AutoSize = true;
            this.labelNomRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomRecette.Location = new System.Drawing.Point(15, 5);
            this.labelNomRecette.Name = "labelNomRecette";
            this.labelNomRecette.Size = new System.Drawing.Size(56, 25);
            this.labelNomRecette.TabIndex = 0;
            this.labelNomRecette.Text = "Nom";
            // 
            // labelInfoDate
            // 
            this.labelInfoDate.AutoSize = true;
            this.labelInfoDate.Location = new System.Drawing.Point(15, 30);
            this.labelInfoDate.Name = "labelInfoDate";
            this.labelInfoDate.Size = new System.Drawing.Size(115, 16);
            this.labelInfoDate.TabIndex = 1;
            this.labelInfoDate.Text = "Date de création : ";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(130, 30);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(34, 16);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "date";
            // 
            // groupBoxOpération
            // 
            this.groupBoxOpération.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxOpération.Controls.Add(this.labelEnTeteSensHoraire);
            this.groupBoxOpération.Controls.Add(this.labelEnTeteQuittance);
            this.groupBoxOpération.Controls.Add(this.labelEnTeteCycleVerin);
            this.groupBoxOpération.Controls.Add(this.labelEnTeteTempsAttente);
            this.groupBoxOpération.Controls.Add(this.labelEnTetePosMoteur);
            this.groupBoxOpération.Controls.Add(this.labelEnTeteNom);
            this.groupBoxOpération.Controls.Add(this.labelEnTeteNum);
            this.groupBoxOpération.Controls.Add(this.flowLayoutPanelOperations);
            this.groupBoxOpération.Location = new System.Drawing.Point(10, 60);
            this.groupBoxOpération.Name = "groupBoxOpération";
            this.groupBoxOpération.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBoxOpération.Size = new System.Drawing.Size(960, 480);
            this.groupBoxOpération.TabIndex = 3;
            this.groupBoxOpération.TabStop = false;
            this.groupBoxOpération.Text = "Opération";
            // 
            // labelEnTeteSensHoraire
            // 
            this.labelEnTeteSensHoraire.AutoSize = true;
            this.labelEnTeteSensHoraire.Location = new System.Drawing.Point(761, 30);
            this.labelEnTeteSensHoraire.Name = "labelEnTeteSensHoraire";
            this.labelEnTeteSensHoraire.Size = new System.Drawing.Size(94, 16);
            this.labelEnTeteSensHoraire.TabIndex = 7;
            this.labelEnTeteSensHoraire.Text = "Sense Horaire";
            // 
            // labelEnTeteQuittance
            // 
            this.labelEnTeteQuittance.AutoSize = true;
            this.labelEnTeteQuittance.Location = new System.Drawing.Point(670, 30);
            this.labelEnTeteQuittance.Name = "labelEnTeteQuittance";
            this.labelEnTeteQuittance.Size = new System.Drawing.Size(63, 16);
            this.labelEnTeteQuittance.TabIndex = 6;
            this.labelEnTeteQuittance.Text = "Quittance";
            // 
            // labelEnTeteCycleVerin
            // 
            this.labelEnTeteCycleVerin.AutoSize = true;
            this.labelEnTeteCycleVerin.Location = new System.Drawing.Point(560, 30);
            this.labelEnTeteCycleVerin.Name = "labelEnTeteCycleVerin";
            this.labelEnTeteCycleVerin.Size = new System.Drawing.Size(75, 16);
            this.labelEnTeteCycleVerin.TabIndex = 5;
            this.labelEnTeteCycleVerin.Text = "Cycle Verin";
            // 
            // labelEnTeteTempsAttente
            // 
            this.labelEnTeteTempsAttente.AutoSize = true;
            this.labelEnTeteTempsAttente.Location = new System.Drawing.Point(390, 30);
            this.labelEnTeteTempsAttente.Name = "labelEnTeteTempsAttente";
            this.labelEnTeteTempsAttente.Size = new System.Drawing.Size(122, 16);
            this.labelEnTeteTempsAttente.TabIndex = 4;
            this.labelEnTeteTempsAttente.Text = "Temps d\'attente [s]";
            // 
            // labelEnTetePosMoteur
            // 
            this.labelEnTetePosMoteur.AutoSize = true;
            this.labelEnTetePosMoteur.Location = new System.Drawing.Point(275, 30);
            this.labelEnTetePosMoteur.Name = "labelEnTetePosMoteur";
            this.labelEnTetePosMoteur.Size = new System.Drawing.Size(99, 16);
            this.labelEnTetePosMoteur.TabIndex = 3;
            this.labelEnTetePosMoteur.Text = "Position Moteur";
            // 
            // labelEnTeteNom
            // 
            this.labelEnTeteNom.AutoSize = true;
            this.labelEnTeteNom.Location = new System.Drawing.Point(85, 30);
            this.labelEnTeteNom.Name = "labelEnTeteNom";
            this.labelEnTeteNom.Size = new System.Drawing.Size(36, 16);
            this.labelEnTeteNom.TabIndex = 2;
            this.labelEnTeteNom.Text = "Nom";
            // 
            // labelEnTeteNum
            // 
            this.labelEnTeteNum.AutoSize = true;
            this.labelEnTeteNum.Location = new System.Drawing.Point(15, 30);
            this.labelEnTeteNum.Name = "labelEnTeteNum";
            this.labelEnTeteNum.Size = new System.Drawing.Size(55, 16);
            this.labelEnTeteNum.TabIndex = 1;
            this.labelEnTeteNum.Text = "Numéro";
            // 
            // flowLayoutPanelOperations
            // 
            this.flowLayoutPanelOperations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelOperations.AutoScroll = true;
            this.flowLayoutPanelOperations.Location = new System.Drawing.Point(10, 50);
            this.flowLayoutPanelOperations.Name = "flowLayoutPanelOperations";
            this.flowLayoutPanelOperations.Size = new System.Drawing.Size(850, 430);
            this.flowLayoutPanelOperations.TabIndex = 0;
            // 
            // buttonModifierRecette
            // 
            this.buttonModifierRecette.Location = new System.Drawing.Point(600, 5);
            this.buttonModifierRecette.Name = "buttonModifierRecette";
            this.buttonModifierRecette.Size = new System.Drawing.Size(100, 30);
            this.buttonModifierRecette.TabIndex = 4;
            this.buttonModifierRecette.Text = "Modifier";
            this.buttonModifierRecette.UseVisualStyleBackColor = true;
            this.buttonModifierRecette.Visible = false;
            this.buttonModifierRecette.Click += new System.EventHandler(this.buttonModifierRecette_Click);
            // 
            // buttonSupprimerRecette
            // 
            this.buttonSupprimerRecette.Location = new System.Drawing.Point(750, 5);
            this.buttonSupprimerRecette.Name = "buttonSupprimerRecette";
            this.buttonSupprimerRecette.Size = new System.Drawing.Size(100, 30);
            this.buttonSupprimerRecette.TabIndex = 5;
            this.buttonSupprimerRecette.Text = "Supprimer";
            this.buttonSupprimerRecette.UseVisualStyleBackColor = true;
            this.buttonSupprimerRecette.Visible = false;
            this.buttonSupprimerRecette.Click += new System.EventHandler(this.buttonSupprimerRecette_Click);
            // 
            // RecetteInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.buttonSupprimerRecette);
            this.Controls.Add(this.buttonModifierRecette);
            this.Controls.Add(this.groupBoxOpération);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelInfoDate);
            this.Controls.Add(this.labelNomRecette);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecetteInformation";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "Information de la recette";
            this.groupBoxOpération.ResumeLayout(false);
            this.groupBoxOpération.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomRecette;
        private System.Windows.Forms.Label labelInfoDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.GroupBox groupBoxOpération;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOperations;
        private System.Windows.Forms.Label labelEnTeteCycleVerin;
        private System.Windows.Forms.Label labelEnTeteTempsAttente;
        private System.Windows.Forms.Label labelEnTetePosMoteur;
        private System.Windows.Forms.Label labelEnTeteNom;
        private System.Windows.Forms.Label labelEnTeteNum;
        private System.Windows.Forms.Label labelEnTeteSensHoraire;
        private System.Windows.Forms.Label labelEnTeteQuittance;
        private System.Windows.Forms.Button buttonModifierRecette;
        private System.Windows.Forms.Button buttonSupprimerRecette;
    }
}