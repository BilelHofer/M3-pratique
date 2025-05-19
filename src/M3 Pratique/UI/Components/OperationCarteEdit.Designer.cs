namespace M3_Pratique
{
    partial class OperationCarteEdit
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
            this.numericUpDownTempsAttente = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCycleVerin = new System.Windows.Forms.CheckBox();
            this.checkBoxQuittance = new System.Windows.Forms.CheckBox();
            this.textBoxNomOperation = new System.Windows.Forms.TextBox();
            this.numericUpDownNumeroOperation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPositionMoteur = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSensHoraire = new System.Windows.Forms.CheckBox();
            this.labelIconCroix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempsAttente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionMoteur)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownTempsAttente
            // 
            this.numericUpDownTempsAttente.Location = new System.Drawing.Point(410, 19);
            this.numericUpDownTempsAttente.Name = "numericUpDownTempsAttente";
            this.numericUpDownTempsAttente.Size = new System.Drawing.Size(110, 22);
            this.numericUpDownTempsAttente.TabIndex = 1;
            this.numericUpDownTempsAttente.ValueChanged += new System.EventHandler(this.numericUpDownTempsAttente_ValueChanged);
            // 
            // checkBoxCycleVerin
            // 
            this.checkBoxCycleVerin.AutoSize = true;
            this.checkBoxCycleVerin.Location = new System.Drawing.Point(571, 21);
            this.checkBoxCycleVerin.Name = "checkBoxCycleVerin";
            this.checkBoxCycleVerin.Size = new System.Drawing.Size(18, 17);
            this.checkBoxCycleVerin.TabIndex = 3;
            this.checkBoxCycleVerin.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuittance
            // 
            this.checkBoxQuittance.AutoSize = true;
            this.checkBoxQuittance.Location = new System.Drawing.Point(671, 21);
            this.checkBoxQuittance.Name = "checkBoxQuittance";
            this.checkBoxQuittance.Size = new System.Drawing.Size(18, 17);
            this.checkBoxQuittance.TabIndex = 4;
            this.checkBoxQuittance.UseVisualStyleBackColor = true;
            // 
            // textBoxNomOperation
            // 
            this.textBoxNomOperation.Location = new System.Drawing.Point(0, 19);
            this.textBoxNomOperation.Name = "textBoxNomOperation";
            this.textBoxNomOperation.Size = new System.Drawing.Size(150, 22);
            this.textBoxNomOperation.TabIndex = 5;
            // 
            // numericUpDownNumeroOperation
            // 
            this.numericUpDownNumeroOperation.Location = new System.Drawing.Point(170, 19);
            this.numericUpDownNumeroOperation.Name = "numericUpDownNumeroOperation";
            this.numericUpDownNumeroOperation.Size = new System.Drawing.Size(80, 22);
            this.numericUpDownNumeroOperation.TabIndex = 7;
            // 
            // numericUpDownPositionMoteur
            // 
            this.numericUpDownPositionMoteur.Location = new System.Drawing.Point(270, 19);
            this.numericUpDownPositionMoteur.Name = "numericUpDownPositionMoteur";
            this.numericUpDownPositionMoteur.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPositionMoteur.TabIndex = 10;
            // 
            // checkBoxSensHoraire
            // 
            this.checkBoxSensHoraire.AutoSize = true;
            this.checkBoxSensHoraire.Location = new System.Drawing.Point(771, 21);
            this.checkBoxSensHoraire.Name = "checkBoxSensHoraire";
            this.checkBoxSensHoraire.Size = new System.Drawing.Size(18, 17);
            this.checkBoxSensHoraire.TabIndex = 15;
            this.checkBoxSensHoraire.UseVisualStyleBackColor = true;
            // 
            // labelIconCroix
            // 
            this.labelIconCroix.Image = global::M3_Pratique.Properties.Resources.croix;
            this.labelIconCroix.Location = new System.Drawing.Point(846, 10);
            this.labelIconCroix.Name = "labelIconCroix";
            this.labelIconCroix.Size = new System.Drawing.Size(37, 39);
            this.labelIconCroix.TabIndex = 16;
            // 
            // OperationCarteEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelIconCroix);
            this.Controls.Add(this.checkBoxSensHoraire);
            this.Controls.Add(this.numericUpDownPositionMoteur);
            this.Controls.Add(this.numericUpDownNumeroOperation);
            this.Controls.Add(this.textBoxNomOperation);
            this.Controls.Add(this.checkBoxQuittance);
            this.Controls.Add(this.checkBoxCycleVerin);
            this.Controls.Add(this.numericUpDownTempsAttente);
            this.Name = "OperationCarteEdit";
            this.Size = new System.Drawing.Size(887, 60);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempsAttente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionMoteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownTempsAttente;
        private System.Windows.Forms.CheckBox checkBoxCycleVerin;
        private System.Windows.Forms.CheckBox checkBoxQuittance;
        private System.Windows.Forms.TextBox textBoxNomOperation;
        private System.Windows.Forms.NumericUpDown numericUpDownNumeroOperation;
        private System.Windows.Forms.NumericUpDown numericUpDownPositionMoteur;
        private System.Windows.Forms.CheckBox checkBoxSensHoraire;
        private System.Windows.Forms.Label labelIconCroix;
    }
}
