namespace Projet_T3
{
    partial class ucEtape
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
            this.lbl_tuto = new System.Windows.Forms.Label();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.pcbGauche = new System.Windows.Forms.PictureBox();
            this.pcbDroite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGauche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDroite)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tuto
            // 
            this.lbl_tuto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lbl_tuto.Location = new System.Drawing.Point(78, 291);
            this.lbl_tuto.Name = "lbl_tuto";
            this.lbl_tuto.Size = new System.Drawing.Size(530, 73);
            this.lbl_tuto.TabIndex = 13;
            this.lbl_tuto.Text = "Pour lancer une partie : Séléctionnez une difficulté et entrez un pseudo et cliqu" +
    "ez sur commencer";
            this.lbl_tuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbImage
            // 
            this.pcbImage.BackgroundImage = global::Projet_T3.Properties.Resources.Tuto_Menu;
            this.pcbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImage.Location = new System.Drawing.Point(119, 12);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(453, 285);
            this.pcbImage.TabIndex = 7;
            this.pcbImage.TabStop = false;
            // 
            // pcbGauche
            // 
            this.pcbGauche.Image = global::Projet_T3.Properties.Resources.fleche_gauche;
            this.pcbGauche.Location = new System.Drawing.Point(4, 172);
            this.pcbGauche.Margin = new System.Windows.Forms.Padding(4);
            this.pcbGauche.Name = "pcbGauche";
            this.pcbGauche.Size = new System.Drawing.Size(67, 44);
            this.pcbGauche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGauche.TabIndex = 6;
            this.pcbGauche.TabStop = false;
            this.pcbGauche.Click += new System.EventHandler(this.btnPrec_Click);
            // 
            // pcbDroite
            // 
            this.pcbDroite.Image = global::Projet_T3.Properties.Resources.fleche_droite;
            this.pcbDroite.Location = new System.Drawing.Point(615, 172);
            this.pcbDroite.Margin = new System.Windows.Forms.Padding(4);
            this.pcbDroite.Name = "pcbDroite";
            this.pcbDroite.Size = new System.Drawing.Size(67, 44);
            this.pcbDroite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDroite.TabIndex = 5;
            this.pcbDroite.TabStop = false;
            this.pcbDroite.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // ucEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lbl_tuto);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.pcbGauche);
            this.Controls.Add(this.pcbDroite);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucEtape";
            this.Size = new System.Drawing.Size(685, 377);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGauche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDroite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbDroite;
        private System.Windows.Forms.PictureBox pcbGauche;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.Label lbl_tuto;
    }
}
