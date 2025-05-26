namespace M3_Pratique
{
    partial class RecetteCreation
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
            this.labelTextRecette = new System.Windows.Forms.Label();
            this.labelNomRecette = new System.Windows.Forms.Label();
            this.btnCreerRecette = new System.Windows.Forms.Button();
            this.textBoxNomRecette = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelOperation = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAjoutOperation = new System.Windows.Forms.Button();
            this.btnSupprimerOperation = new System.Windows.Forms.Button();
            this.labelOperation = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.labelSensHoraireOperation = new System.Windows.Forms.Label();
            this.labelQuittanceOperation = new System.Windows.Forms.Label();
            this.labelCycleVerinOperation = new System.Windows.Forms.Label();
            this.labelTempsAttenteOperation = new System.Windows.Forms.Label();
            this.labelPositionMoteurOperation = new System.Windows.Forms.Label();
            this.labelNomOperation = new System.Windows.Forms.Label();
            this.btnEnregistrerRecette = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTextRecette
            // 
            this.labelTextRecette.AutoSize = true;
            this.labelTextRecette.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTextRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextRecette.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTextRecette.Location = new System.Drawing.Point(12, 9);
            this.labelTextRecette.Name = "labelTextRecette";
            this.labelTextRecette.Size = new System.Drawing.Size(141, 39);
            this.labelTextRecette.TabIndex = 0;
            this.labelTextRecette.Text = "Recette";
            this.labelTextRecette.Click += new System.EventHandler(this.labelTextRecette_Click);
            // 
            // labelNomRecette
            // 
            this.labelNomRecette.AutoSize = true;
            this.labelNomRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomRecette.Location = new System.Drawing.Point(16, 71);
            this.labelNomRecette.Name = "labelNomRecette";
            this.labelNomRecette.Size = new System.Drawing.Size(54, 20);
            this.labelNomRecette.TabIndex = 1;
            this.labelNomRecette.Text = "Nom :";
            this.labelNomRecette.Click += new System.EventHandler(this.labelNomRecette_Click);
            // 
            // btnCreerRecette
            // 
            this.btnCreerRecette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreerRecette.ForeColor = System.Drawing.Color.Black;
            this.btnCreerRecette.Location = new System.Drawing.Point(901, 510);
            this.btnCreerRecette.Name = "btnCreerRecette";
            this.btnCreerRecette.Size = new System.Drawing.Size(100, 80);
            this.btnCreerRecette.TabIndex = 3;
            this.btnCreerRecette.Text = "Créer";
            this.btnCreerRecette.UseVisualStyleBackColor = true;
            this.btnCreerRecette.Click += new System.EventHandler(this.btnCreerRecette_Click);
            // 
            // textBoxNomRecette
            // 
            this.textBoxNomRecette.Location = new System.Drawing.Point(76, 71);
            this.textBoxNomRecette.Name = "textBoxNomRecette";
            this.textBoxNomRecette.Size = new System.Drawing.Size(188, 22);
            this.textBoxNomRecette.TabIndex = 4;
            this.textBoxNomRecette.TextChanged += new System.EventHandler(this.textBoxNomRecette_TextChanged);
            // 
            // flowLayoutPanelOperation
            // 
            this.flowLayoutPanelOperation.AutoScroll = true;
            this.flowLayoutPanelOperation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelOperation.Location = new System.Drawing.Point(20, 190);
            this.flowLayoutPanelOperation.Name = "flowLayoutPanelOperation";
            this.flowLayoutPanelOperation.Size = new System.Drawing.Size(855, 400);
            this.flowLayoutPanelOperation.TabIndex = 5;
            this.flowLayoutPanelOperation.WrapContents = false;
            this.flowLayoutPanelOperation.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelOperation_Paint);
            // 
            // btnAjoutOperation
            // 
            this.btnAjoutOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjoutOperation.Location = new System.Drawing.Point(116, 99);
            this.btnAjoutOperation.Name = "btnAjoutOperation";
            this.btnAjoutOperation.Size = new System.Drawing.Size(40, 40);
            this.btnAjoutOperation.TabIndex = 6;
            this.btnAjoutOperation.Text = "+";
            this.btnAjoutOperation.UseVisualStyleBackColor = true;
            this.btnAjoutOperation.Click += new System.EventHandler(this.btnAjoutOperation_Click);
            // 
            // btnSupprimerOperation
            // 
            this.btnSupprimerOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerOperation.Location = new System.Drawing.Point(176, 99);
            this.btnSupprimerOperation.Name = "btnSupprimerOperation";
            this.btnSupprimerOperation.Size = new System.Drawing.Size(40, 40);
            this.btnSupprimerOperation.TabIndex = 7;
            this.btnSupprimerOperation.Text = "-";
            this.btnSupprimerOperation.UseVisualStyleBackColor = true;
            this.btnSupprimerOperation.Click += new System.EventHandler(this.btnSupprimerOperation_Click);
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperation.Location = new System.Drawing.Point(16, 109);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(82, 20);
            this.labelOperation.TabIndex = 8;
            this.labelOperation.Text = "Opération";
            this.labelOperation.Click += new System.EventHandler(this.labelOperation_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(901, 424);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 80);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // labelSensHoraireOperation
            // 
            this.labelSensHoraireOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSensHoraireOperation.Location = new System.Drawing.Point(713, 167);
            this.labelSensHoraireOperation.Name = "labelSensHoraireOperation";
            this.labelSensHoraireOperation.Size = new System.Drawing.Size(90, 20);
            this.labelSensHoraireOperation.TabIndex = 42;
            this.labelSensHoraireOperation.Text = "Sens horaire";
            // 
            // labelQuittanceOperation
            // 
            this.labelQuittanceOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuittanceOperation.Location = new System.Drawing.Point(613, 167);
            this.labelQuittanceOperation.Name = "labelQuittanceOperation";
            this.labelQuittanceOperation.Size = new System.Drawing.Size(103, 20);
            this.labelQuittanceOperation.TabIndex = 41;
            this.labelQuittanceOperation.Text = "Quittance";
            // 
            // labelCycleVerinOperation
            // 
            this.labelCycleVerinOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCycleVerinOperation.Location = new System.Drawing.Point(513, 167);
            this.labelCycleVerinOperation.Name = "labelCycleVerinOperation";
            this.labelCycleVerinOperation.Size = new System.Drawing.Size(103, 20);
            this.labelCycleVerinOperation.TabIndex = 40;
            this.labelCycleVerinOperation.Text = "Cycle vérin";
            // 
            // labelTempsAttenteOperation
            // 
            this.labelTempsAttenteOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTempsAttenteOperation.Location = new System.Drawing.Point(383, 167);
            this.labelTempsAttenteOperation.Name = "labelTempsAttenteOperation";
            this.labelTempsAttenteOperation.Size = new System.Drawing.Size(131, 20);
            this.labelTempsAttenteOperation.TabIndex = 39;
            this.labelTempsAttenteOperation.Text = "Temps d\'attente";
            // 
            // labelPositionMoteurOperation
            // 
            this.labelPositionMoteurOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPositionMoteurOperation.Location = new System.Drawing.Point(243, 167);
            this.labelPositionMoteurOperation.Name = "labelPositionMoteurOperation";
            this.labelPositionMoteurOperation.Size = new System.Drawing.Size(141, 20);
            this.labelPositionMoteurOperation.TabIndex = 38;
            this.labelPositionMoteurOperation.Text = "Position du moteur";
            // 
            // labelNomOperation
            // 
            this.labelNomOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNomOperation.Location = new System.Drawing.Point(76, 167);
            this.labelNomOperation.Name = "labelNomOperation";
            this.labelNomOperation.Size = new System.Drawing.Size(172, 20);
            this.labelNomOperation.TabIndex = 36;
            this.labelNomOperation.Text = "Nom                                     ";
            // 
            // btnEnregistrerRecette
            // 
            this.btnEnregistrerRecette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrerRecette.ForeColor = System.Drawing.Color.Black;
            this.btnEnregistrerRecette.Location = new System.Drawing.Point(901, 510);
            this.btnEnregistrerRecette.Name = "btnEnregistrerRecette";
            this.btnEnregistrerRecette.Size = new System.Drawing.Size(100, 80);
            this.btnEnregistrerRecette.TabIndex = 43;
            this.btnEnregistrerRecette.Text = "Enregistrer";
            this.btnEnregistrerRecette.UseVisualStyleBackColor = true;
            this.btnEnregistrerRecette.Click += new System.EventHandler(this.buttonEnregistrerRecette_Click);
            // 
            // RecetteCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 713);
            this.Controls.Add(this.btnEnregistrerRecette);
            this.Controls.Add(this.labelSensHoraireOperation);
            this.Controls.Add(this.labelQuittanceOperation);
            this.Controls.Add(this.labelCycleVerinOperation);
            this.Controls.Add(this.labelTempsAttenteOperation);
            this.Controls.Add(this.labelPositionMoteurOperation);
            this.Controls.Add(this.labelNomOperation);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.btnSupprimerOperation);
            this.Controls.Add(this.btnAjoutOperation);
            this.Controls.Add(this.flowLayoutPanelOperation);
            this.Controls.Add(this.textBoxNomRecette);
            this.Controls.Add(this.btnCreerRecette);
            this.Controls.Add(this.labelNomRecette);
            this.Controls.Add(this.labelTextRecette);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecetteCreation";
            this.Text = "Création d\'une recette";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RecetteCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextRecette;
        private System.Windows.Forms.Label labelNomRecette;
        private System.Windows.Forms.Button btnCreerRecette;
        private System.Windows.Forms.TextBox textBoxNomRecette;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOperation;
        private System.Windows.Forms.Button btnAjoutOperation;
        private System.Windows.Forms.Button btnSupprimerOperation;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label labelSensHoraireOperation;
        private System.Windows.Forms.Label labelQuittanceOperation;
        private System.Windows.Forms.Label labelCycleVerinOperation;
        private System.Windows.Forms.Label labelTempsAttenteOperation;
        private System.Windows.Forms.Label labelPositionMoteurOperation;
        private System.Windows.Forms.Label labelNomOperation;
        private System.Windows.Forms.Button btnEnregistrerRecette;
    }
}