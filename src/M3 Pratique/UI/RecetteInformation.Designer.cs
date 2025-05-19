namespace M3_Pratique
{
    partial class RecetteInformation
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
            this.labelNomRecette = new System.Windows.Forms.Label();
            this.labelInfoDate = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.groupBoxOpération = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // labelNomRecette
            // 
            this.labelNomRecette.AutoSize = true;
            this.labelNomRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomRecette.Location = new System.Drawing.Point(12, 3);
            this.labelNomRecette.Name = "labelNomRecette";
            this.labelNomRecette.Size = new System.Drawing.Size(56, 25);
            this.labelNomRecette.TabIndex = 0;
            this.labelNomRecette.Text = "Nom";
            // 
            // labelInfoDate
            // 
            this.labelInfoDate.AutoSize = true;
            this.labelInfoDate.Location = new System.Drawing.Point(13, 32);
            this.labelInfoDate.Name = "labelInfoDate";
            this.labelInfoDate.Size = new System.Drawing.Size(115, 16);
            this.labelInfoDate.TabIndex = 1;
            this.labelInfoDate.Text = "Date de création : ";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(129, 32);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(34, 16);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "date";
            // 
            // groupBoxOpération
            // 
            this.groupBoxOpération.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxOpération.Location = new System.Drawing.Point(10, 65);
            this.groupBoxOpération.Name = "groupBoxOpération";
            this.groupBoxOpération.Size = new System.Drawing.Size(1047, 479);
            this.groupBoxOpération.TabIndex = 3;
            this.groupBoxOpération.TabStop = false;
            this.groupBoxOpération.Text = "Opération";
            // 
            // RecetteInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBoxOpération);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelInfoDate);
            this.Controls.Add(this.labelNomRecette);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecetteInformation";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "Information de la recette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomRecette;
        private System.Windows.Forms.Label labelInfoDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.GroupBox groupBoxOpération;
    }
}