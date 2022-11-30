using System;
using System.Linq;
using System.Media;
using System.Windows.Forms;
/**
 * \file $FILENAME
 * \brief UserControl qui affiche le menu du jeu
 * \version 1
 * \date $MONTHNAME_EN $YEAR
 * \author les canards boiteux
 */
namespace Projet_T3
{
    /**
<<<<<<< HEAD
     * \class Menu
     * \brief classe du userControl Menu, affiche le menu et gère le changement de pseudo, le tutoriel et le choix de la difficulté 
     * \class ucMenu
     * \brief classe du userControl Menu
     */
    public partial class Menu : UserControl
    {
        /**
         * \brief difficulté se met à jour quand un joueur clique sur une difficulté 
         */
        int difficulte = -1;

        /**
         *  Constructeur
         */
        public Menu()
        {
            InitializeComponent();
            SoundPlayer son = new SoundPlayer();
            son.SoundLocation = "stardew-valley-ost-spring-its-a-big-world-outside_1.wav";
            son.Play();
        }


        

        /**
         * \fn void btn_tuto_Click
         * \brief Affiche le tutoriel dans un formulaire à part qui s'affiche au dessus du formulaire principal
         */
        private void btn_tuto_Click(object sender, EventArgs e)
        {
            //ouvre une popup
            frmTuto tuto = new frmTuto();
            tuto.ShowDialog();
        }

        /**
         * \fn void btn_quitter_Click
         * \brief permet de fermer le formulaire
         */
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /**
         * \fn void pnl_facile_Click
         * \brief Selectionne la difficulté en fonction du formulaire qui est séléctionné
         */
        private void pnl_facile_Click(object sender, EventArgs e)
        {
            difficulte = Convert.ToInt32(((Panel)sender).Tag);
            //Pour chaque composant de type Panel dans le uc on regarde s'il est déjà cliqué
            //si oui on le décoche pour cocher le nouveau
            foreach (var pnl in Controls.OfType<Panel>())
            {
                if (pnl.BorderStyle == BorderStyle.Fixed3D)
                {
                    pnl.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            ((Panel)sender).BorderStyle = BorderStyle.Fixed3D;


            //ouvre une popup
            frmPerso perso = new frmPerso(difficulte);

            if (perso.ShowDialog() == DialogResult.OK)
            {
                this.Controls.Clear();
                ucPartie partie = new ucPartie(difficulte, tbx_pseudo.Text, 1, 1, 100);
                this.Controls.Add(partie);
            }

        }

        /**
         * \fn void txt_pseudo_KeyPress
         * \brief permet de rentrer son pseudo (et de gérer ce que l'utilisateur peut taper)
         */
        private void tbx_pseudo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        /**
        * \fn void Tbx_pseudo_Click
        * \brief remet à vide le pseudo quant on veut en entrer un nouveau
        */
        private void Tbx_pseudo_Click(object sender, EventArgs e)
        {
            tbx_pseudo.Text = "";
        }
    }
}
