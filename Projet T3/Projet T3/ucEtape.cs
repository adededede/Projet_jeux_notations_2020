using System;
using System.Windows.Forms;
/**
* \file $FILENAME
* \brief UserControl qui permet d'afficher les étapes du tutoriel
* \version 1
* \date $MONTHNAME_EN $YEAR
* \author les canards boiteux
*/
namespace Projet_T3
{
    /**
     * \class ucEtape
     * \brief classe du userControl Etape, affiche le tutoriel
     */
    public partial class ucEtape : UserControl
    {
        /**
         * \brief numéro de la page du tuto
         */
        int numEtape;
        /**
        *  Constructeur 
        *  \param[in] etape : numéro de pages du tuto
        */
        public ucEtape(int etape)
        {
            numEtape = etape;
            InitializeComponent();

            //premiere page du tuto
            if (etape == 0)
            {
                pcbGauche.Enabled = false;
                pcbGauche.Visible = false;
                pcbImage.BackgroundImage = global::Projet_T3.Properties.Resources.Tuto_Menu;
            }
            //deuxième page du tuto
            else if (etape == 1)
            {
                pcbImage.BackgroundImage = global::Projet_T3.Properties.Resources.Tuto_Caractéristiques;
                lbl_tuto.Text = "Choisissez les caractéristiques de votre personnage";
            }
            //troisième page du tuto
            else if (etape == 2)
            {
                pcbImage.BackgroundImage = global::Projet_T3.Properties.Resources.Tuto_Game;
                lbl_tuto.Text = "Choisissez bien vos actions, les professeurs ont différents critères de notation";
            }
            //quatrième page du tuto
            else if (etape == 3)
            {
                pcbImage.BackgroundImage = global::Projet_T3.Properties.Resources.Tuto_Bulletin;
                lbl_tuto.Text = "Essayez d'obtenir la meilleure note possible !";
            }
            //derniere page du tuto
            else
            {
                pcbDroite.Enabled = false;
                pcbDroite.Visible = false;
                pcbImage.BackgroundImage = global::Projet_T3.Properties.Resources.Tuto_Scores;
                lbl_tuto.Text = "Comparez vos notes avec vos amis !";
            }
        }

        /**
         * \fn void btnPrec_Click
         * \brief permet d'afficher l'étape précédente
         */
        private void btnPrec_Click(object sender, EventArgs e)
        {           
                ucEtape etapeSuiv = new ucEtape(numEtape-1);
                this.Controls.Clear();
                this.Controls.Add(etapeSuiv);
        }

        /**
         * \fn void btnSuivant_Click
         * \brief permet d'afficher l'étape suivante
         */
        private void btnSuivant_Click(object sender, EventArgs e)
        {
                ucEtape etapeSuiv = new ucEtape(numEtape +1);
                this.Controls.Clear();
                this.Controls.Add(etapeSuiv);
        }

    }
}
