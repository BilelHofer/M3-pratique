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
            this.comboBoxPoition = new System.Windows.Forms.ComboBox();
            this.numericUpDownTempsAttente = new System.Windows.Forms.NumericUpDown();
            this.btnQuittance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempsAttente)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPoition
            // 
            this.comboBoxPoition.FormattingEnabled = true;
            this.comboBoxPoition.Location = new System.Drawing.Point(20, 20);
            this.comboBoxPoition.Name = "comboBoxPoition";
            this.comboBoxPoition.Size = new System.Drawing.Size(250, 24);
            this.comboBoxPoition.TabIndex = 0;
            this.comboBoxPoition.SelectedIndexChanged += new System.EventHandler(this.comboBoxPoition_SelectedIndexChanged);
            // 
            // numericUpDownTempsAttente
            // 
            this.numericUpDownTempsAttente.Location = new System.Drawing.Point(300, 20);
            this.numericUpDownTempsAttente.Name = "numericUpDownTempsAttente";
            this.numericUpDownTempsAttente.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownTempsAttente.TabIndex = 1;
            this.numericUpDownTempsAttente.ValueChanged += new System.EventHandler(this.numericUpDownTempsAttente_ValueChanged);
            // 
            // btnQuittance
            // 
            this.btnQuittance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuittance.Location = new System.Drawing.Point(530, 20);
            this.btnQuittance.Name = "btnQuittance";
            this.btnQuittance.Size = new System.Drawing.Size(200, 24);
            this.btnQuittance.TabIndex = 2;
            this.btnQuittance.Text = "Quittance";
            this.btnQuittance.UseVisualStyleBackColor = true;
            this.btnQuittance.Click += new System.EventHandler(this.btnQuittance_Click);
            // 
            // OperationCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuittance);
            this.Controls.Add(this.numericUpDownTempsAttente);
            this.Controls.Add(this.comboBoxPoition);
            this.Name = "OperationCarte";
            this.Size = new System.Drawing.Size(760, 60);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempsAttente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPoition;
        private System.Windows.Forms.NumericUpDown numericUpDownTempsAttente;
        private System.Windows.Forms.Button btnQuittance;
    }
}
