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
            this.SuspendLayout();
            // 
            // btnCreerLot
            // 
            this.btnCreerLot.Location = new System.Drawing.Point(78, 32);
            this.btnCreerLot.Name = "btnCreerLot";
            this.btnCreerLot.Size = new System.Drawing.Size(75, 23);
            this.btnCreerLot.TabIndex = 0;
            this.btnCreerLot.Text = "Créer";
            this.btnCreerLot.UseVisualStyleBackColor = true;
            this.btnCreerLot.Click += new System.EventHandler(this.btnCreerLot_Click);
            // 
            // LotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreerLot);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LotManager";
            this.Text = "Manager de lot";
            this.Load += new System.EventHandler(this.LotManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreerLot;
    }
}

