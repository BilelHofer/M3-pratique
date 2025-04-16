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
            // LotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 590);
            this.Controls.Add(this.comboBoxEtat);
            this.Controls.Add(this.labelRechercherIcon);
            this.Controls.Add(this.textBoxRechercheLot);
            this.Controls.Add(this.flowLayoutPanelLots);
            this.Controls.Add(this.btnCreerLot);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LotManager";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.Text = "Manager de lot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreerLot;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLots;
        private System.Windows.Forms.TextBox textBoxRechercheLot;
        private System.Windows.Forms.Label labelRechercherIcon;
        private System.Windows.Forms.ComboBox comboBoxEtat;
    }
}

