using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
/**
* \file $FILENAME
* \brief UserControl qui affiche les 5 meilleurs scores pour la difficulté du joueur
* \version 1
* \date $MONTHNAME_EN $YEAR
* \author les canards boiteux
*/
namespace Projet_T3
{
    /**
     * \class ucScore
     * \brief classe du userControl Score, gère l'affichage des 5 meilleurs scores dans la difficulté choisie
     */
    public partial class ucScore : UserControl
    {
        /**
         * \brief difficulté choisie par le joueur 
         */
        int difficulte;
        /**
         * \brief pseudo choisi par le joueur 
         */
        string pseudo;
        /**
         * \brief numéro du jour de cours
         */
        int numJour;
        /**
         * \brief connexion à la base de données
         */
        OleDbConnection connex = new OleDbConnection();
        /**
         * \brief dataSet où on copie la base de données pour travailler en déconnecté
         */
        DataSet dsLocal = new DataSet();

        /**
        *  Constructeur
        *  \param[in] diff : diffculté choisie par le joueur 
        *  \param[in] surnom : pseudo choisi par le joueur 
        *  \param[in] jour : numéro du jour de cours
        */
        public ucScore(int diff,string surnom,int jour)
        {
            InitializeComponent();
            
            chargementDsLocal();
            difficulte = diff;
            pseudo = surnom;
            numJour = jour;
            remplirScore();
        }

        /**
         * \fn void remplirScore
         * \brief permet de remplir le tableau des scores
         */
        public void remplirScore()
        {
            
            int i =  0;
            int j = 0;
            int top = 151;
            
            while (j < 5 && i < dsLocal.Tables["scores"].Rows.Count)
            {
                //mise en place des labels affichant le pseudo et les scores pour les 5 meilleurs
                if (Convert.ToInt32(dsLocal.Tables["scores"].Rows[i][3]) == difficulte)
                {
                    Label lblPseudo = new Label();
                    Label lblScore = new Label();

                    lblPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    lblPseudo.ForeColor = Color.FromArgb(255, 255, 255);
                    lblScore.ForeColor = Color.FromArgb(255, 255, 255);
                    
                    lblPseudo.BackColor = Color.FromArgb(48, 141, 22);
                    lblScore.BackColor = Color.FromArgb(48, 141, 22);



                    lblPseudo.Text = dsLocal.Tables["scores"].Rows[i][1].ToString();
                    lblPseudo.Top = top;
                    lblPseudo.Left = 120;


                    lblScore.Text = dsLocal.Tables["scores"].Rows[i][2].ToString();
                    lblScore.Top = top;
                    lblScore.Left = 430;

                    pcbScores.Controls.Add(lblPseudo);
                    pcbScores.Controls.Add(lblScore);
                    top += 33;
                    j++;
                }
                i++;
            }


        }

        /**
         * \fn void chargementDsLocal
         * \brief permet de remplir le DsLocal
         */
        private void chargementDsLocal()
        {

            //ouverture connection
            connex.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ..\DBJeu.mdb";
            connex.Open();

            //Etape 2 : recuperation du schema de la base 
            DataTable schemaTable = connex.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

            connex.Close();

            string nomTable;
            string requete;
            // Etape 3 : Parcours de la table
            for (int i = 0; i < schemaTable.Rows.Count; i++) // compte le nb de lignes du tableau
            {
                //pour recuperer la 3eme case d'une ligne
                nomTable = schemaTable.Rows[i][2].ToString(); //dans la ligne i on recupere la cellule n°3
               
                //etape 4 : construction de la req
                if (nomTable == "scores")
                {
                    requete = "select * from [" + nomTable + "] order by difficulte DESC,score DESC";
                }
                else if (nomTable == "cours")
                    requete = "select * from [" + nomTable + "] order by idProf";
                else
                    requete = "select * from [" + nomTable + "]";

                //Etape 5 : Execution de la req
                OleDbCommand cd = new OleDbCommand(requete, connex);
                OleDbDataAdapter da = new OleDbDataAdapter(cd);

                // Etape 6 : Phase de remplissage
                da.Fill(dsLocal, nomTable);

            }
        }


        /**
        * \fn void Btn_menu_Click
        * \brief permet de revenir au menu
        */
        private void Btn_menu_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Menu menu = new Menu();
            this.Controls.Add(menu);
        }

        /**
        * \fn void Btn_continue_Click
        * \brief permet de continuer à jouer en passant à jour+1
        */
        private void Btn_continue_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucPartie partie = new ucPartie(difficulte, pseudo, 1, numJour + 1, 100);
            this.Controls.Add(partie);
        }

        /**
        * \fn void Btn_quitter_Click
        * \brief permet de quitter l'application
        */
        private void Btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
