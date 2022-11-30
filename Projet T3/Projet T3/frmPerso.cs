
using System.Windows.Forms;
/**
 * \file $FILENAME
 * \brief Formulaire dans lequel le personnage et ses caractérisiques s'affichent
 * \version 1
 * \date $MONTHNAME_EN $YEAR
 * \author les canards boiteux
 */

/**
* \mainpage frmPerso.cs
* \brief Formulaire du personnage dans lequel on affiche ses points de compétences pour chaque cours
*/
namespace Projet_T3
{
    /**
     * \class frmPerso
     * \brief classe du formulaire personnage
     */
    public partial class frmPerso : Form
    {
        /**
        *  Constructeur
        */
        public frmPerso(int diff)
        {
            InitializeComponent();
            ucPerso iniPerso = new ucPerso(diff);
            this.Controls.Clear();
            this.Controls.Add(iniPerso);
        }

      
    }
}
