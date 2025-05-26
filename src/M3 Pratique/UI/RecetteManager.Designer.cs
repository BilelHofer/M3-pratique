namespace M3_Pratique
{
    partial class RecetteManager
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
            this.labelRechercherIcon = new System.Windows.Forms.Label();
            this.textBoxRechercheRecette = new System.Windows.Forms.TextBox();
            this.btnCreerRecette = new System.Windows.Forms.Button();
            this.flowLayoutPanelRecettes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelRechercherIcon
            // 
            this.labelRechercherIcon.BackColor = System.Drawing.Color.Transparent;
            this.labelRechercherIcon.Image = global::M3_Pratique.Properties.Resources.rechercheIcon;
            this.labelRechercherIcon.Location = new System.Drawing.Point(236, 8);
            this.labelRechercherIcon.Name = "labelRechercherIcon";
            this.labelRechercherIcon.Size = new System.Drawing.Size(34, 31);
            this.labelRechercherIcon.TabIndex = 6;
            // 
            // textBoxRechercheRecette
            // 
            this.textBoxRechercheRecette.Location = new System.Drawing.Point(12, 12);
            this.textBoxRechercheRecette.Name = "textBoxRechercheRecette";
            this.textBoxRechercheRecette.Size = new System.Drawing.Size(219, 22);
            this.textBoxRechercheRecette.TabIndex = 5;
            this.textBoxRechercheRecette.TextChanged += new System.EventHandler(this.textBoxRechercheRecette_TextChanged);
            // 
            // btnCreerRecette
            // 
            this.btnCreerRecette.Location = new System.Drawing.Point(331, 12);
            this.btnCreerRecette.Name = "btnCreerRecette";
            this.btnCreerRecette.Size = new System.Drawing.Size(86, 32);
            this.btnCreerRecette.TabIndex = 4;
            this.btnCreerRecette.Text = "Créer";
            this.btnCreerRecette.UseVisualStyleBackColor = true;
            this.btnCreerRecette.Click += new System.EventHandler(this.btnCreerRecette_Click);
            // 
            // flowLayoutPanelRecettes
            // 
            this.flowLayoutPanelRecettes.AutoScroll = true;
            this.flowLayoutPanelRecettes.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelRecettes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelRecettes.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanelRecettes.Name = "flowLayoutPanelRecettes";
            this.flowLayoutPanelRecettes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.flowLayoutPanelRecettes.Size = new System.Drawing.Size(443, 973);
            this.flowLayoutPanelRecettes.TabIndex = 7;
            this.flowLayoutPanelRecettes.WrapContents = false;
            // 
            // RecetteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.flowLayoutPanelRecettes);
            this.Controls.Add(this.labelRechercherIcon);
            this.Controls.Add(this.textBoxRechercheRecette);
            this.Controls.Add(this.btnCreerRecette);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecetteManager";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Text = "Manager de recette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRechercherIcon;
        private System.Windows.Forms.TextBox textBoxRechercheRecette;
        private System.Windows.Forms.Button btnCreerRecette;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRecettes;
    }
}