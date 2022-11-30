namespace Projet_T3
{
    partial class ucScore
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
            this.pcbScores = new System.Windows.Forms.PictureBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbScores)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbScores
            // 
            this.pcbScores.Image = global::Projet_T3.Properties.Resources.tableau_d_scores;
            this.pcbScores.Location = new System.Drawing.Point(15, 15);
            this.pcbScores.Name = "pcbScores";
            this.pcbScores.Size = new System.Drawing.Size(613, 381);
            this.pcbScores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbScores.TabIndex = 19;
            this.pcbScores.TabStop = false;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Gray;
            this.btn_menu.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_menu;
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Location = new System.Drawing.Point(15, 401);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(119, 54);
            this.btn_menu.TabIndex = 18;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.Btn_menu_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.Gray;
            this.btn_continue.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_continuer;
            this.btn_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Location = new System.Drawing.Point(267, 401);
            this.btn_continue.Margin = new System.Windows.Forms.Padding(2);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(119, 54);
            this.btn_continue.TabIndex = 17;
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.Btn_continue_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_quitter;
            this.btn_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitter.Location = new System.Drawing.Point(509, 401);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(119, 54);
            this.btn_quitter.TabIndex = 16;
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.Btn_quitter_Click);
            // 
            // ucScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.Controls.Add(this.pcbScores);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_quitter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucScore";
            this.Size = new System.Drawing.Size(660, 467);
            ((System.ComponentModel.ISupportInitialize)(this.pcbScores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.PictureBox pcbScores;
    }
}
