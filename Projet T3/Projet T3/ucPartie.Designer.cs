namespace Projet_T3
{
    partial class ucPartie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPartie));
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.btnDodo = new System.Windows.Forms.Button();
            this.btnBavarde = new System.Windows.Forms.Button();
            this.btnTravail = new System.Windows.Forms.Button();
            this.lblJour = new System.Windows.Forms.Label();
            this.pcb_perso = new System.Windows.Forms.PictureBox();
            this.btnParticipe = new System.Windows.Forms.Button();
            this.lblHeure = new System.Windows.Forms.Label();
            this.pgbMoral = new System.Windows.Forms.ProgressBar();
            this.lbl_bulle = new System.Windows.Forms.Label();
            this.lblMatiere = new System.Windows.Forms.Label();
            this.pcbMoral = new System.Windows.Forms.PictureBox();
            this.pcb_prof = new System.Windows.Forms.PictureBox();
            this.pcb_bulle = new System.Windows.Forms.PictureBox();
            this.pcb_nomDuJeu = new System.Windows.Forms.PictureBox();
            this.pcb_tableau = new System.Windows.Forms.PictureBox();
            this.grbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_perso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMoral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_prof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_bulle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_nomDuJeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Location = new System.Drawing.Point(4, 171);
            this.lblDiff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(57, 13);
            this.lblDiff.TabIndex = 0;
            this.lblDiff.Text = "Difficulté : ";
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Location = new System.Drawing.Point(4, 153);
            this.lblPseudo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(46, 13);
            this.lblPseudo.TabIndex = 1;
            this.lblPseudo.Text = "Pseudo:";
            // 
            // grbAction
            // 
            this.grbAction.Controls.Add(this.btnDodo);
            this.grbAction.Controls.Add(this.btnBavarde);
            this.grbAction.Controls.Add(this.btnTravail);
            this.grbAction.Controls.Add(this.lblJour);
            this.grbAction.Controls.Add(this.pcb_perso);
            this.grbAction.Controls.Add(this.btnParticipe);
            this.grbAction.Controls.Add(this.lblHeure);
            this.grbAction.Controls.Add(this.lblPseudo);
            this.grbAction.Controls.Add(this.lblDiff);
            this.grbAction.Location = new System.Drawing.Point(9, 2);
            this.grbAction.Margin = new System.Windows.Forms.Padding(2);
            this.grbAction.Name = "grbAction";
            this.grbAction.Padding = new System.Windows.Forms.Padding(2);
            this.grbAction.Size = new System.Drawing.Size(191, 452);
            this.grbAction.TabIndex = 9;
            this.grbAction.TabStop = false;
            // 
            // btnDodo
            // 
            this.btnDodo.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_dormir_2;
            this.btnDodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodo.Location = new System.Drawing.Point(28, 387);
            this.btnDodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodo.Name = "btnDodo";
            this.btnDodo.Size = new System.Drawing.Size(128, 48);
            this.btnDodo.TabIndex = 7;
            this.btnDodo.Tag = "3";
            this.btnDodo.UseVisualStyleBackColor = true;
            this.btnDodo.Click += new System.EventHandler(this.btnParticipe_Click);
            // 
            // btnBavarde
            // 
            this.btnBavarde.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_bavarder;
            this.btnBavarde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBavarde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBavarde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBavarde.Location = new System.Drawing.Point(28, 323);
            this.btnBavarde.Margin = new System.Windows.Forms.Padding(2);
            this.btnBavarde.Name = "btnBavarde";
            this.btnBavarde.Size = new System.Drawing.Size(128, 48);
            this.btnBavarde.TabIndex = 6;
            this.btnBavarde.Tag = "1";
            this.btnBavarde.UseVisualStyleBackColor = true;
            this.btnBavarde.Click += new System.EventHandler(this.btnParticipe_Click);
            // 
            // btnTravail
            // 
            this.btnTravail.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_travailler;
            this.btnTravail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTravail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTravail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTravail.Location = new System.Drawing.Point(28, 262);
            this.btnTravail.Margin = new System.Windows.Forms.Padding(2);
            this.btnTravail.Name = "btnTravail";
            this.btnTravail.Size = new System.Drawing.Size(128, 48);
            this.btnTravail.TabIndex = 5;
            this.btnTravail.Tag = "2";
            this.btnTravail.UseVisualStyleBackColor = true;
            this.btnTravail.Click += new System.EventHandler(this.btnParticipe_Click);
            // 
            // lblJour
            // 
            this.lblJour.AutoSize = true;
            this.lblJour.Location = new System.Drawing.Point(112, 153);
            this.lblJour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJour.Name = "lblJour";
            this.lblJour.Size = new System.Drawing.Size(36, 13);
            this.lblJour.TabIndex = 15;
            this.lblJour.Text = "Jour : ";
            // 
            // pcb_perso
            // 
            this.pcb_perso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_perso.Location = new System.Drawing.Point(47, 15);
            this.pcb_perso.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_perso.Name = "pcb_perso";
            this.pcb_perso.Size = new System.Drawing.Size(92, 129);
            this.pcb_perso.TabIndex = 3;
            this.pcb_perso.TabStop = false;
            // 
            // btnParticipe
            // 
            this.btnParticipe.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_participer;
            this.btnParticipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParticipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParticipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParticipe.Location = new System.Drawing.Point(28, 203);
            this.btnParticipe.Margin = new System.Windows.Forms.Padding(2);
            this.btnParticipe.Name = "btnParticipe";
            this.btnParticipe.Size = new System.Drawing.Size(128, 48);
            this.btnParticipe.TabIndex = 4;
            this.btnParticipe.Tag = "0";
            this.btnParticipe.UseVisualStyleBackColor = true;
            this.btnParticipe.Click += new System.EventHandler(this.btnParticipe_Click);
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(112, 171);
            this.lblHeure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(56, 13);
            this.lblHeure.TabIndex = 13;
            this.lblHeure.Text = "Cours n° : ";
            // 
            // pgbMoral
            // 
            this.pgbMoral.Location = new System.Drawing.Point(347, 142);
            this.pgbMoral.Name = "pgbMoral";
            this.pgbMoral.Size = new System.Drawing.Size(294, 26);
            this.pgbMoral.Step = 6;
            this.pgbMoral.TabIndex = 23;
            this.pgbMoral.Value = 100;
            // 
            // lbl_bulle
            // 
            this.lbl_bulle.BackColor = System.Drawing.Color.White;
            this.lbl_bulle.Location = new System.Drawing.Point(392, 388);
            this.lbl_bulle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bulle.Name = "lbl_bulle";
            this.lbl_bulle.Size = new System.Drawing.Size(198, 35);
            this.lbl_bulle.TabIndex = 12;
            this.lbl_bulle.Text = "Bienvenue !! Commençons le cours";
            this.lbl_bulle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatiere
            // 
            this.lblMatiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(224)))));
            this.lblMatiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatiere.Location = new System.Drawing.Point(216, 205);
            this.lblMatiere.Name = "lblMatiere";
            this.lblMatiere.Size = new System.Drawing.Size(158, 20);
            this.lblMatiere.TabIndex = 22;
            this.lblMatiere.Text = "label4";
            this.lblMatiere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pcbMoral
            // 
            this.pcbMoral.BackgroundImage = global::Projet_T3.Properties.Resources.Votre_moral;
            this.pcbMoral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbMoral.Location = new System.Drawing.Point(220, 142);
            this.pcbMoral.Margin = new System.Windows.Forms.Padding(2);
            this.pcbMoral.Name = "pcbMoral";
            this.pcbMoral.Size = new System.Drawing.Size(115, 26);
            this.pcbMoral.TabIndex = 24;
            this.pcbMoral.TabStop = false;
            // 
            // pcb_prof
            // 
            this.pcb_prof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(224)))));
            this.pcb_prof.BackgroundImage = global::Projet_T3.Properties.Resources.Merry_Tocratick;
            this.pcb_prof.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_prof.Location = new System.Drawing.Point(247, 268);
            this.pcb_prof.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_prof.Name = "pcb_prof";
            this.pcb_prof.Size = new System.Drawing.Size(109, 180);
            this.pcb_prof.TabIndex = 14;
            this.pcb_prof.TabStop = false;
            // 
            // pcb_bulle
            // 
            this.pcb_bulle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(224)))));
            this.pcb_bulle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcb_bulle.BackgroundImage")));
            this.pcb_bulle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_bulle.Location = new System.Drawing.Point(360, 363);
            this.pcb_bulle.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_bulle.Name = "pcb_bulle";
            this.pcb_bulle.Size = new System.Drawing.Size(244, 70);
            this.pcb_bulle.TabIndex = 11;
            this.pcb_bulle.TabStop = false;
            // 
            // pcb_nomDuJeu
            // 
            this.pcb_nomDuJeu.BackgroundImage = global::Projet_T3.Properties.Resources.Nom_du_jeu;
            this.pcb_nomDuJeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_nomDuJeu.Location = new System.Drawing.Point(339, 16);
            this.pcb_nomDuJeu.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_nomDuJeu.Name = "pcb_nomDuJeu";
            this.pcb_nomDuJeu.Size = new System.Drawing.Size(194, 92);
            this.pcb_nomDuJeu.TabIndex = 10;
            this.pcb_nomDuJeu.TabStop = false;
            // 
            // pcb_tableau
            // 
            this.pcb_tableau.BackColor = System.Drawing.Color.Transparent;
            this.pcb_tableau.BackgroundImage = global::Projet_T3.Properties.Resources.salle;
            this.pcb_tableau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_tableau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcb_tableau.Location = new System.Drawing.Point(205, 197);
            this.pcb_tableau.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_tableau.Name = "pcb_tableau";
            this.pcb_tableau.Size = new System.Drawing.Size(444, 256);
            this.pcb_tableau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_tableau.TabIndex = 2;
            this.pcb_tableau.TabStop = false;
            // 
            // ucPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.Controls.Add(this.pcbMoral);
            this.Controls.Add(this.pgbMoral);
            this.Controls.Add(this.lblMatiere);
            this.Controls.Add(this.pcb_prof);
            this.Controls.Add(this.lbl_bulle);
            this.Controls.Add(this.pcb_bulle);
            this.Controls.Add(this.pcb_nomDuJeu);
            this.Controls.Add(this.grbAction);
            this.Controls.Add(this.pcb_tableau);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucPartie";
            this.Size = new System.Drawing.Size(660, 467);
            this.grbAction.ResumeLayout(false);
            this.grbAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_perso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMoral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_prof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_bulle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_nomDuJeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_tableau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.PictureBox pcb_tableau;
        private System.Windows.Forms.PictureBox pcb_perso;
        private System.Windows.Forms.Button btnParticipe;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.PictureBox pcb_nomDuJeu;
        private System.Windows.Forms.PictureBox pcb_bulle;
        private System.Windows.Forms.Label lbl_bulle;
        private System.Windows.Forms.Button btnDodo;
        private System.Windows.Forms.Button btnBavarde;
        private System.Windows.Forms.Button btnTravail;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.PictureBox pcb_prof;
        private System.Windows.Forms.Label lblJour;
        private System.Windows.Forms.Label lblMatiere;
        private System.Windows.Forms.ProgressBar pgbMoral;
        private System.Windows.Forms.PictureBox pcbMoral;
    }
}
