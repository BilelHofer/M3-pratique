namespace M3_Pratique
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
            this.numericUpDownTempsAttente = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCycleVerin = new System.Windows.Forms.CheckBox();
            this.checkBoxQuittance = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSensHoraire = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempsAttente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(170, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(270, 19);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 10;
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
            // OperationCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxSensHoraire);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxQuittance);
            this.Controls.Add(this.checkBoxCycleVerin);
            this.Controls.Add(this.numericUpDownTempsAttente);
            this.Name = "OperationCarte";
            this.Size = new System.Drawing.Size(830, 60);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempsAttente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownTempsAttente;
        private System.Windows.Forms.CheckBox checkBoxCycleVerin;
        private System.Windows.Forms.CheckBox checkBoxQuittance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkBoxSensHoraire;
    }
}
