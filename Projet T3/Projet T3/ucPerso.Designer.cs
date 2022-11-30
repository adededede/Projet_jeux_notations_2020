namespace Projet_T3
{
    partial class ucPerso
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
            this.lblMath = new System.Windows.Forms.Label();
            this.lblFrancais = new System.Windows.Forms.Label();
            this.lblHisto = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.pcb_nomDuJeu = new System.Windows.Forms.PictureBox();
            this.pcb_perso = new System.Windows.Forms.PictureBox();
            this.tbMath = new System.Windows.Forms.TrackBar();
            this.tbFrancais = new System.Windows.Forms.TrackBar();
            this.tbHisto = new System.Windows.Forms.TrackBar();
            this.btn_quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_nomDuJeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_perso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFrancais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHisto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMath
            // 
            this.lblMath.AutoSize = true;
            this.lblMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMath.Location = new System.Drawing.Point(83, 117);
            this.lblMath.Name = "lblMath";
            this.lblMath.Size = new System.Drawing.Size(106, 16);
            this.lblMath.TabIndex = 12;
            this.lblMath.Text = "Mathématiques :";
            // 
            // lblFrancais
            // 
            this.lblFrancais.AutoSize = true;
            this.lblFrancais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrancais.Location = new System.Drawing.Point(83, 152);
            this.lblFrancais.Name = "lblFrancais";
            this.lblFrancais.Size = new System.Drawing.Size(66, 16);
            this.lblFrancais.TabIndex = 13;
            this.lblFrancais.Text = "Français :";
            // 
            // lblHisto
            // 
            this.lblHisto.AutoSize = true;
            this.lblHisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHisto.Location = new System.Drawing.Point(83, 188);
            this.lblHisto.Name = "lblHisto";
            this.lblHisto.Size = new System.Drawing.Size(90, 16);
            this.lblHisto.TabIndex = 14;
            this.lblHisto.Text = "Histoire/Geo :";
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.Gray;
            this.btn_continue.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_continuer;
            this.btn_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_continue.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continue.Location = new System.Drawing.Point(248, 237);
            this.btn_continue.Margin = new System.Windows.Forms.Padding(2);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(119, 54);
            this.btn_continue.TabIndex = 19;
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // pcb_nomDuJeu
            // 
            this.pcb_nomDuJeu.BackgroundImage = global::Projet_T3.Properties.Resources.Nom_du_jeu;
            this.pcb_nomDuJeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_nomDuJeu.Location = new System.Drawing.Point(334, 15);
            this.pcb_nomDuJeu.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_nomDuJeu.Name = "pcb_nomDuJeu";
            this.pcb_nomDuJeu.Size = new System.Drawing.Size(167, 86);
            this.pcb_nomDuJeu.TabIndex = 11;
            this.pcb_nomDuJeu.TabStop = false;
            // 
            // pcb_perso
            // 
            this.pcb_perso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_perso.Location = new System.Drawing.Point(16, 2);
            this.pcb_perso.Margin = new System.Windows.Forms.Padding(2);
            this.pcb_perso.Name = "pcb_perso";
            this.pcb_perso.Size = new System.Drawing.Size(80, 113);
            this.pcb_perso.TabIndex = 4;
            this.pcb_perso.TabStop = false;
            // 
            // tbMath
            // 
            this.tbMath.LargeChange = 10;
            this.tbMath.Location = new System.Drawing.Point(188, 117);
            this.tbMath.Margin = new System.Windows.Forms.Padding(2);
            this.tbMath.Maximum = 100;
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(313, 45);
            this.tbMath.SmallChange = 10;
            this.tbMath.TabIndex = 28;
            this.tbMath.Tag = "0";
            this.tbMath.TickFrequency = 10;
            this.tbMath.ValueChanged += new System.EventHandler(this.TbMath_ValueChanged);
            // 
            // tbFrancais
            // 
            this.tbFrancais.LargeChange = 10;
            this.tbFrancais.Location = new System.Drawing.Point(188, 152);
            this.tbFrancais.Margin = new System.Windows.Forms.Padding(2);
            this.tbFrancais.Maximum = 100;
            this.tbFrancais.Name = "tbFrancais";
            this.tbFrancais.Size = new System.Drawing.Size(313, 45);
            this.tbFrancais.SmallChange = 10;
            this.tbFrancais.TabIndex = 29;
            this.tbFrancais.Tag = "1";
            this.tbFrancais.TickFrequency = 10;
            this.tbFrancais.ValueChanged += new System.EventHandler(this.TbMath_ValueChanged);
            // 
            // tbHisto
            // 
            this.tbHisto.LargeChange = 10;
            this.tbHisto.Location = new System.Drawing.Point(188, 188);
            this.tbHisto.Margin = new System.Windows.Forms.Padding(2);
            this.tbHisto.Maximum = 100;
            this.tbHisto.Name = "tbHisto";
            this.tbHisto.Size = new System.Drawing.Size(313, 45);
            this.tbHisto.SmallChange = 10;
            this.tbHisto.TabIndex = 30;
            this.tbHisto.Tag = "2";
            this.tbHisto.TickFrequency = 10;
            this.tbHisto.ValueChanged += new System.EventHandler(this.TbMath_ValueChanged);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_quitter;
            this.btn_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitter.Location = new System.Drawing.Point(382, 237);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(119, 54);
            this.btn_quitter.TabIndex = 31;
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.Btn_quitter_Click);
            // 
            // ucPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(207)))), ((int)(((byte)(193)))));
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.tbHisto);
            this.Controls.Add(this.tbFrancais);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.lblHisto);
            this.Controls.Add(this.lblFrancais);
            this.Controls.Add(this.lblMath);
            this.Controls.Add(this.pcb_nomDuJeu);
            this.Controls.Add(this.pcb_perso);
            this.Name = "ucPerso";
            this.Size = new System.Drawing.Size(528, 306);
            this.Tag = "0";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_nomDuJeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_perso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFrancais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHisto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_perso;
        private System.Windows.Forms.PictureBox pcb_nomDuJeu;
        private System.Windows.Forms.Label lblMath;
        private System.Windows.Forms.Label lblFrancais;
        private System.Windows.Forms.Label lblHisto;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.TrackBar tbMath;
        private System.Windows.Forms.TrackBar tbFrancais;
        private System.Windows.Forms.TrackBar tbHisto;
        private System.Windows.Forms.Button btn_quitter;
    }
}
