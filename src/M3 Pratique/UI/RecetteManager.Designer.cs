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
            // RecetteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.labelRechercherIcon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecetteManager";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Text = "Manager de recette";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRechercherIcon;
    }
}