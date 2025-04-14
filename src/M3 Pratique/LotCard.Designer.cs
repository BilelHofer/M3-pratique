namespace M3_Pratique
{
    partial class LotCard
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNom = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(11, 10);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(298, 18);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // labelEtat
            // 
            this.labelEtat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEtat.Location = new System.Drawing.Point(295, 12);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEtat.Size = new System.Drawing.Size(97, 18);
            this.labelEtat.TabIndex = 1;
            this.labelEtat.Text = "Etat";
            this.labelEtat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LotCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelEtat);
            this.Controls.Add(this.labelNom);
            this.Name = "LotCard";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(403, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelEtat;
    }
}
