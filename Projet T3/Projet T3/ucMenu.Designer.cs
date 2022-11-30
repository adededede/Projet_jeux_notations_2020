namespace Projet_T3
{
    partial class Menu
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
            this.tbx_pseudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.btn_tuto = new System.Windows.Forms.Button();
            this.pcb_nomDuJeu = new System.Windows.Forms.PictureBox();
            this.pnl_facile = new System.Windows.Forms.Panel();
            this.pct_facile = new System.Windows.Forms.PictureBox();
            this.pcb_eleve1 = new System.Windows.Forms.PictureBox();
            this.pnl_moyen = new System.Windows.Forms.Panel();
            this.pcb_moyen = new System.Windows.Forms.PictureBox();
            this.pcb_eleve2 = new System.Windows.Forms.PictureBox();
            this.pnl_difficile = new System.Windows.Forms.Panel();
            this.pcb_difficile = new System.Windows.Forms.PictureBox();
            this.pcb_eleve3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_nomDuJeu)).BeginInit();
            this.pnl_facile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_facile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eleve1)).BeginInit();
            this.pnl_moyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_moyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eleve2)).BeginInit();
            this.pnl_difficile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_difficile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eleve3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_pseudo
            // 
            this.tbx_pseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_pseudo.Location = new System.Drawing.Point(374, 98);
            this.tbx_pseudo.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_pseudo.Name = "tbx_pseudo";
            this.tbx_pseudo.Size = new System.Drawing.Size(234, 26);
            this.tbx_pseudo.TabIndex = 8;
            this.tbx_pseudo.Text = "eleve";
            this.tbx_pseudo.Click += new System.EventHandler(this.Tbx_pseudo_Click);
            this.tbx_pseudo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_pseudo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Entrez votre pseudo :";
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_quitter;
            this.btn_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitter.Location = new System.Drawing.Point(515, 303);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(119, 54);
            this.btn_quitter.TabIndex = 7;
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // btn_tuto
            // 
            this.btn_tuto.BackgroundImage = global::Projet_T3.Properties.Resources.bouton_tuto;
            this.btn_tuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tuto.Location = new System.Drawing.Point(515, 224);
            this.btn_tuto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tuto.Name = "btn_tuto";
            this.btn_tuto.Size = new System.Drawing.Size(119, 54);
            this.btn_tuto.TabIndex = 5;
            this.btn_tuto.UseVisualStyleBackColor = true;
            this.btn_tuto.Click += new System.EventHandler(this.btn_tuto_Click);
            // 
            // pcb_nomDuJeu
            // 
            this.pcb_nomDuJeu.BackgroundImage = global::Projet_T3.Properties.Resources.Nom_du_jeu;
            this.pcb_nomDuJeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_nomDuJeu.Location = new System.Drawing.Point(7, 6);
            this.pcb_nomDuJeu.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_nomDuJeu.Name = "pcb_nomDuJeu";
            this.pcb_nomDuJeu.Size = new System.Drawing.Size(281, 136);
            this.pcb_nomDuJeu.TabIndex = 0;
            this.pcb_nomDuJeu.TabStop = false;
            // 
            // pnl_facile
            // 
            this.pnl_facile.BackColor = System.Drawing.Color.ForestGreen;
            this.pnl_facile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_facile.Controls.Add(this.pct_facile);
            this.pnl_facile.Controls.Add(this.pcb_eleve1);
            this.pnl_facile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_facile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_facile.Location = new System.Drawing.Point(26, 161);
            this.pnl_facile.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_facile.Name = "pnl_facile";
            this.pnl_facile.Size = new System.Drawing.Size(136, 260);
            this.pnl_facile.TabIndex = 1;
            this.pnl_facile.Tag = "0";
            this.pnl_facile.Click += new System.EventHandler(this.pnl_facile_Click);
            // 
            // pct_facile
            // 
            this.pct_facile.BackgroundImage = global::Projet_T3.Properties.Resources.facile;
            this.pct_facile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_facile.Enabled = false;
            this.pct_facile.Location = new System.Drawing.Point(28, 21);
            this.pct_facile.Margin = new System.Windows.Forms.Padding(2);
            this.pct_facile.Name = "pct_facile";
            this.pct_facile.Size = new System.Drawing.Size(80, 35);
            this.pct_facile.TabIndex = 1;
            this.pct_facile.TabStop = false;
            // 
            // pcb_eleve1
            // 
            this.pcb_eleve1.BackgroundImage = global::Projet_T3.Properties.Resources.eleve_1;
            this.pcb_eleve1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_eleve1.Enabled = false;
            this.pcb_eleve1.Location = new System.Drawing.Point(16, 72);
            this.pcb_eleve1.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_eleve1.Name = "pcb_eleve1";
            this.pcb_eleve1.Size = new System.Drawing.Size(100, 166);
            this.pcb_eleve1.TabIndex = 0;
            this.pcb_eleve1.TabStop = false;
            // 
            // pnl_moyen
            // 
            this.pnl_moyen.BackColor = System.Drawing.Color.Orange;
            this.pnl_moyen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_moyen.Controls.Add(this.pcb_moyen);
            this.pnl_moyen.Controls.Add(this.pcb_eleve2);
            this.pnl_moyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_moyen.Location = new System.Drawing.Point(188, 161);
            this.pnl_moyen.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_moyen.Name = "pnl_moyen";
            this.pnl_moyen.Size = new System.Drawing.Size(136, 260);
            this.pnl_moyen.TabIndex = 2;
            this.pnl_moyen.Tag = "1";
            this.pnl_moyen.Click += new System.EventHandler(this.pnl_facile_Click);
            // 
            // pcb_moyen
            // 
            this.pcb_moyen.BackgroundImage = global::Projet_T3.Properties.Resources.moyen;
            this.pcb_moyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_moyen.Enabled = false;
            this.pcb_moyen.Location = new System.Drawing.Point(25, 21);
            this.pcb_moyen.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_moyen.Name = "pcb_moyen";
            this.pcb_moyen.Size = new System.Drawing.Size(86, 46);
            this.pcb_moyen.TabIndex = 2;
            this.pcb_moyen.TabStop = false;
            // 
            // pcb_eleve2
            // 
            this.pcb_eleve2.BackgroundImage = global::Projet_T3.Properties.Resources.eleve3;
            this.pcb_eleve2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_eleve2.Enabled = false;
            this.pcb_eleve2.Location = new System.Drawing.Point(18, 72);
            this.pcb_eleve2.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_eleve2.Name = "pcb_eleve2";
            this.pcb_eleve2.Size = new System.Drawing.Size(100, 166);
            this.pcb_eleve2.TabIndex = 1;
            this.pcb_eleve2.TabStop = false;
            // 
            // pnl_difficile
            // 
            this.pnl_difficile.BackColor = System.Drawing.Color.Red;
            this.pnl_difficile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_difficile.Controls.Add(this.pcb_difficile);
            this.pnl_difficile.Controls.Add(this.pcb_eleve3);
            this.pnl_difficile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_difficile.Location = new System.Drawing.Point(352, 161);
            this.pnl_difficile.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_difficile.Name = "pnl_difficile";
            this.pnl_difficile.Size = new System.Drawing.Size(136, 260);
            this.pnl_difficile.TabIndex = 3;
            this.pnl_difficile.Tag = "2";
            this.pnl_difficile.Click += new System.EventHandler(this.pnl_facile_Click);
            // 
            // pcb_difficile
            // 
            this.pcb_difficile.BackgroundImage = global::Projet_T3.Properties.Resources.difficile;
            this.pcb_difficile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_difficile.Enabled = false;
            this.pcb_difficile.Location = new System.Drawing.Point(19, 21);
            this.pcb_difficile.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_difficile.Name = "pcb_difficile";
            this.pcb_difficile.Size = new System.Drawing.Size(102, 35);
            this.pcb_difficile.TabIndex = 2;
            this.pcb_difficile.TabStop = false;
            // 
            // pcb_eleve3
            // 
            this.pcb_eleve3.BackgroundImage = global::Projet_T3.Properties.Resources.eleve_2;
            this.pcb_eleve3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_eleve3.Enabled = false;
            this.pcb_eleve3.Location = new System.Drawing.Point(21, 72);
            this.pcb_eleve3.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_eleve3.Name = "pcb_eleve3";
            this.pcb_eleve3.Size = new System.Drawing.Size(100, 166);
            this.pcb_eleve3.TabIndex = 2;
            this.pcb_eleve3.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_pseudo);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_tuto);
            this.Controls.Add(this.pnl_difficile);
            this.Controls.Add(this.pnl_moyen);
            this.Controls.Add(this.pnl_facile);
            this.Controls.Add(this.pcb_nomDuJeu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(660, 467);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_nomDuJeu)).EndInit();
            this.pnl_facile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_facile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eleve1)).EndInit();
            this.pnl_moyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_moyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eleve2)).EndInit();
            this.pnl_difficile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_difficile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_eleve3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_nomDuJeu;
        private System.Windows.Forms.Button btn_tuto;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.TextBox tbx_pseudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_facile;
        private System.Windows.Forms.PictureBox pct_facile;
        private System.Windows.Forms.PictureBox pcb_eleve1;
        private System.Windows.Forms.Panel pnl_moyen;
        private System.Windows.Forms.PictureBox pcb_moyen;
        private System.Windows.Forms.PictureBox pcb_eleve2;
        private System.Windows.Forms.Panel pnl_difficile;
        private System.Windows.Forms.PictureBox pcb_difficile;
        private System.Windows.Forms.PictureBox pcb_eleve3;
    }
}
