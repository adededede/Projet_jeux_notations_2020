
using System.Windows.Forms;
/**
 * \file $FILENAME
 * \brief Formulaire dans lequel le tutoriel du jeu s'affiche
 * \version 1
 * \date $MONTHNAME_EN $YEAR
 * \author les canards boiteux
 */

/**
* \mainpage frmTuto.cs
* \brief Formulaire du tutoriel dans lequel on affiche les différentes étapes du jeu, leurs mécanismes ainsi que le but du jeu
*/
namespace Projet_T3
{
    /**
     * \class frmTuto
     * \brief classe du formulaire tutoriel
     */
    public partial class frmTuto : Form
    {
        /**
        *  Constructeur
        */
        public frmTuto()
        {
            InitializeComponent();
            ucEtape etape0 = new ucEtape(0);
            this.Controls.Clear();
            this.Controls.Add(etape0);
        }

        
    }
}
