using System;
using System.Windows.Forms;
/**
 * \file $FILENAME
 * \brief Formulaire dans lequel le jeu s'affiche
 * \version 1
 * \date $MONTHNAME_EN $YEAR
 * \author les canards boiteux
 */

/**
* \mainpage Form1.cs
* \brief Formulaire principal dans lequel on affiche le menu, la partie et le résultat
*/
namespace Projet_T3
{
    /**
     * \class Form1
     * \brief classe du formulaire principal
     */
    public partial class Form1 : Form
    {
        /**
        *  Constructeur
        */
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * \fn void Form1_Load
         * \brief affiche le menu dans le formulaire
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Controls.Add(menu);
            this.Text = "School Simulator";
        }

    }
}
