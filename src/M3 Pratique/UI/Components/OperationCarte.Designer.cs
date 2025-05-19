namespace M3_Pratique.UI.Components
{
    partial class OperationCarte
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
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPositionMoteur = new System.Windows.Forms.Label();
            this.labelTempsAttente = new System.Windows.Forms.Label();
            this.checkBoxCycleVerin = new System.Windows.Forms.CheckBox();
            this.checkBoxQuittance = new System.Windows.Forms.CheckBox();
            this.checkBoxSensMoteur = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(13, 12);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(32, 16);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "num";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(58, 12);
            this.labelNom.MaximumSize = new System.Drawing.Size(187, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(36, 16);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // labelPositionMoteur
            // 
            this.labelPositionMoteur.AutoSize = true;
            this.labelPositionMoteur.Location = new System.Drawing.Point(251, 12);
            this.labelPositionMoteur.Name = "labelPositionMoteur";
            this.labelPositionMoteur.Size = new System.Drawing.Size(72, 16);
            this.labelPositionMoteur.TabIndex = 2;
            this.labelPositionMoteur.Text = "PosMoteur";
            // 
            // labelTempsAttente
            // 
            this.labelTempsAttente.AutoSize = true;
            this.labelTempsAttente.Location = new System.Drawing.Point(329, 12);
            this.labelTempsAttente.Name = "labelTempsAttente";
            this.labelTempsAttente.Size = new System.Drawing.Size(89, 16);
            this.labelTempsAttente.TabIndex = 3;
            this.labelTempsAttente.Text = "PosTempsAtt";
            // 
            // checkBoxCycleVerin
            // 
            this.checkBoxCycleVerin.AutoSize = true;
            this.checkBoxCycleVerin.Enabled = false;
            this.checkBoxCycleVerin.Location = new System.Drawing.Point(424, 11);
            this.checkBoxCycleVerin.Name = "checkBoxCycleVerin";
            this.checkBoxCycleVerin.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCycleVerin.TabIndex = 4;
            this.checkBoxCycleVerin.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuittance
            // 
            this.checkBoxQuittance.AutoSize = true;
            this.checkBoxQuittance.Enabled = false;
            this.checkBoxQuittance.Location = new System.Drawing.Point(448, 11);
            this.checkBoxQuittance.Name = "checkBoxQuittance";
            this.checkBoxQuittance.Size = new System.Drawing.Size(18, 17);
            this.checkBoxQuittance.TabIndex = 5;
            this.checkBoxQuittance.UseVisualStyleBackColor = true;
            // 
            // checkBoxSensMoteur
            // 
            this.checkBoxSensMoteur.AutoSize = true;
            this.checkBoxSensMoteur.Enabled = false;
            this.checkBoxSensMoteur.Location = new System.Drawing.Point(472, 11);
            this.checkBoxSensMoteur.Name = "checkBoxSensMoteur";
            this.checkBoxSensMoteur.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSensMoteur.TabIndex = 6;
            this.checkBoxSensMoteur.UseVisualStyleBackColor = true;
            // 
            // OperationCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBoxSensMoteur);
            this.Controls.Add(this.checkBoxQuittance);
            this.Controls.Add(this.checkBoxCycleVerin);
            this.Controls.Add(this.labelTempsAttente);
            this.Controls.Add(this.labelPositionMoteur);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelNumero);
            this.MinimumSize = new System.Drawing.Size(520, 0);
            this.Name = "OperationCarte";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(520, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPositionMoteur;
        private System.Windows.Forms.Label labelTempsAttente;
        private System.Windows.Forms.CheckBox checkBoxCycleVerin;
        private System.Windows.Forms.CheckBox checkBoxQuittance;
        private System.Windows.Forms.CheckBox checkBoxSensMoteur;
    }
}
