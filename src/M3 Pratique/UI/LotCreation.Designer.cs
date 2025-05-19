namespace M3_Pratique
{
    partial class LotCreation
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
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.labelNbPiece = new System.Windows.Forms.Label();
            this.numericUpDownNbPiece = new System.Windows.Forms.NumericUpDown();
            this.labelRecette = new System.Windows.Forms.Label();
            this.comboBoxRecette = new System.Windows.Forms.ComboBox();
            this.btnCreerRecette = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(268, 156);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 0;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(176, 156);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // labelNbPiece
            // 
            this.labelNbPiece.AutoSize = true;
            this.labelNbPiece.Location = new System.Drawing.Point(22, 30);
            this.labelNbPiece.Name = "labelNbPiece";
            this.labelNbPiece.Size = new System.Drawing.Size(112, 16);
            this.labelNbPiece.TabIndex = 2;
            this.labelNbPiece.Text = "Nombre de pièce";
            // 
            // numericUpDownNbPiece
            // 
            this.numericUpDownNbPiece.Location = new System.Drawing.Point(140, 28);
            this.numericUpDownNbPiece.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownNbPiece.Name = "numericUpDownNbPiece";
            this.numericUpDownNbPiece.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownNbPiece.TabIndex = 3;
            // 
            // labelRecette
            // 
            this.labelRecette.AutoSize = true;
            this.labelRecette.Location = new System.Drawing.Point(22, 66);
            this.labelRecette.Name = "labelRecette";
            this.labelRecette.Size = new System.Drawing.Size(95, 16);
            this.labelRecette.TabIndex = 4;
            this.labelRecette.Text = "Type de pièce";
            // 
            // comboBoxRecette
            // 
            this.comboBoxRecette.FormattingEnabled = true;
            this.comboBoxRecette.Location = new System.Drawing.Point(140, 63);
            this.comboBoxRecette.Name = "comboBoxRecette";
            this.comboBoxRecette.Size = new System.Drawing.Size(120, 24);
            this.comboBoxRecette.TabIndex = 5;
            this.comboBoxRecette.SelectedIndexChanged += new System.EventHandler(this.comboBoxRecette_SelectedIndexChanged);
            // 
            // btnCreerRecette
            // 
            this.btnCreerRecette.Location = new System.Drawing.Point(266, 63);
            this.btnCreerRecette.Name = "btnCreerRecette";
            this.btnCreerRecette.Size = new System.Drawing.Size(25, 25);
            this.btnCreerRecette.TabIndex = 6;
            this.btnCreerRecette.Text = "+";
            this.btnCreerRecette.UseVisualStyleBackColor = true;
            this.btnCreerRecette.Click += new System.EventHandler(this.btnCreerRecette_Click);
            // 
            // LotCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 197);
            this.Controls.Add(this.btnCreerRecette);
            this.Controls.Add(this.comboBoxRecette);
            this.Controls.Add(this.labelRecette);
            this.Controls.Add(this.numericUpDownNbPiece);
            this.Controls.Add(this.labelNbPiece);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnCreer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LotCreation";
            this.Text = "Création d\'un lot";
            this.Load += new System.EventHandler(this.LotCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label labelNbPiece;
        private System.Windows.Forms.NumericUpDown numericUpDownNbPiece;
        private System.Windows.Forms.Label labelRecette;
        private System.Windows.Forms.ComboBox comboBoxRecette;
        private System.Windows.Forms.Button btnCreerRecette;
    }
}