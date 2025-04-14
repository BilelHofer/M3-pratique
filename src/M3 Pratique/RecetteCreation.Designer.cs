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
            this.btnSupprimerRecette = new System.Windows.Forms.Button();
            this.btnEnregistrerRecette = new System.Windows.Forms.Button();
            this.textBoxNomRecette = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelOperation = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAjoutOperation = new System.Windows.Forms.Button();
            this.btnSupprimerOperation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTextRecette
            // 
            this.labelTextRecette.AutoSize = true;
            this.labelTextRecette.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTextRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextRecette.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTextRecette.Location = new System.Drawing.Point(97, 95);
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
            this.labelNomRecette.Location = new System.Drawing.Point(100, 150);
            this.labelNomRecette.Name = "labelNomRecette";
            this.labelNomRecette.Size = new System.Drawing.Size(54, 20);
            this.labelNomRecette.TabIndex = 1;
            this.labelNomRecette.Text = "Nom :";
            this.labelNomRecette.Click += new System.EventHandler(this.labelNomRecette_Click);
            // 
            // btnSupprimerRecette
            // 
            this.btnSupprimerRecette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerRecette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSupprimerRecette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerRecette.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSupprimerRecette.Location = new System.Drawing.Point(902, 12);
            this.btnSupprimerRecette.Name = "btnSupprimerRecette";
            this.btnSupprimerRecette.Size = new System.Drawing.Size(150, 100);
            this.btnSupprimerRecette.TabIndex = 2;
            this.btnSupprimerRecette.Text = "Supprimer la recette";
            this.btnSupprimerRecette.UseVisualStyleBackColor = false;
            this.btnSupprimerRecette.Click += new System.EventHandler(this.btnSupprimerRecette_Click);
            // 
            // btnEnregistrerRecette
            // 
            this.btnEnregistrerRecette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnregistrerRecette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrerRecette.Location = new System.Drawing.Point(902, 601);
            this.btnEnregistrerRecette.Name = "btnEnregistrerRecette";
            this.btnEnregistrerRecette.Size = new System.Drawing.Size(150, 100);
            this.btnEnregistrerRecette.TabIndex = 3;
            this.btnEnregistrerRecette.Text = "Enregistrer";
            this.btnEnregistrerRecette.UseVisualStyleBackColor = true;
            this.btnEnregistrerRecette.Click += new System.EventHandler(this.btnEnregistrerRecette_Click);
            // 
            // textBoxNomRecette
            // 
            this.textBoxNomRecette.Location = new System.Drawing.Point(160, 150);
            this.textBoxNomRecette.Name = "textBoxNomRecette";
            this.textBoxNomRecette.Size = new System.Drawing.Size(188, 22);
            this.textBoxNomRecette.TabIndex = 4;
            this.textBoxNomRecette.TextChanged += new System.EventHandler(this.textBoxNomRecette_TextChanged);
            // 
            // flowLayoutPanelOperation
            // 
            this.flowLayoutPanelOperation.AutoScroll = true;
            this.flowLayoutPanelOperation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelOperation.Location = new System.Drawing.Point(104, 301);
            this.flowLayoutPanelOperation.Name = "flowLayoutPanelOperation";
            this.flowLayoutPanelOperation.Size = new System.Drawing.Size(792, 400);
            this.flowLayoutPanelOperation.TabIndex = 5;
            this.flowLayoutPanelOperation.WrapContents = false;
            this.flowLayoutPanelOperation.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelOperation_Paint);
            // 
            // btnAjoutOperation
            // 
            this.btnAjoutOperation.Location = new System.Drawing.Point(125, 249);
            this.btnAjoutOperation.Name = "btnAjoutOperation";
            this.btnAjoutOperation.Size = new System.Drawing.Size(29, 33);
            this.btnAjoutOperation.TabIndex = 6;
            this.btnAjoutOperation.Text = "+";
            this.btnAjoutOperation.UseVisualStyleBackColor = true;
            this.btnAjoutOperation.Click += new System.EventHandler(this.btnAjoutOperation_Click);
            // 
            // btnSupprimerOperation
            // 
            this.btnSupprimerOperation.Location = new System.Drawing.Point(196, 249);
            this.btnSupprimerOperation.Name = "btnSupprimerOperation";
            this.btnSupprimerOperation.Size = new System.Drawing.Size(60, 23);
            this.btnSupprimerOperation.TabIndex = 7;
            this.btnSupprimerOperation.Text = "-";
            this.btnSupprimerOperation.UseVisualStyleBackColor = true;
            this.btnSupprimerOperation.Click += new System.EventHandler(this.btnSupprimerOperation_Click);
            // 
            // RecetteCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 713);
            this.Controls.Add(this.btnSupprimerOperation);
            this.Controls.Add(this.btnAjoutOperation);
            this.Controls.Add(this.flowLayoutPanelOperation);
            this.Controls.Add(this.textBoxNomRecette);
            this.Controls.Add(this.btnEnregistrerRecette);
            this.Controls.Add(this.btnSupprimerRecette);
            this.Controls.Add(this.labelNomRecette);
            this.Controls.Add(this.labelTextRecette);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecetteCreation";
            this.Text = "Création d\'une recette";
            this.Load += new System.EventHandler(this.RecetteCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextRecette;
        private System.Windows.Forms.Label labelNomRecette;
        private System.Windows.Forms.Button btnSupprimerRecette;
        private System.Windows.Forms.Button btnEnregistrerRecette;
        private System.Windows.Forms.TextBox textBoxNomRecette;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOperation;
        private System.Windows.Forms.Button btnAjoutOperation;
        private System.Windows.Forms.Button btnSupprimerOperation;
    }
}