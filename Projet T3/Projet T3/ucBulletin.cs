using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
/**
* \file $FILENAME
* \brief UserControl qui permet d'afficher le bulletin a chaque fin de journée
* \version 1
* \date $MONTHNAME_EN $YEAR
* \author les canards boiteux
*/
namespace Projet_T3
{
    /**
     * \class ucBulletin
     * \brief Classe du userControl Bulletin, affiche le bulletin du joueur
     */
    public partial class ucBulletin : UserControl
    {
        /**
         * \brief Connexion pour la base de données
         */
        OleDbConnection connex = new OleDbConnection();
        /**
         * \brief DataSet où on charge la base de données pour travailler en déconnecté
         */
        DataSet dsLocal = new DataSet();
        /**
         * \brief difficulté choisie par le joueur
         */
        int difficulte;
        /**
         * \brief pseudo choisi par le joueur
         */
        string pseudo;
        /**
         * \brief numéro du jour
         */
        int numJour;

        /**
        *  Constructeur
        *  \param[in] diff : difficulté que le joueur choisie
        *  \param[in] jour : numéro du jour de cours
        *  \param[in] pseu : pseudo du joueur
        */
        public ucBulletin(int diff,int jour,string pseu)
        {
            InitializeComponent();
            chargementDsLocal();
            //initialisation des variables
            difficulte = diff;
            pseudo = pseu;
            numJour = jour;

            //affichage de l'élève correspondant à la difficulté choisie
            if (diff == 0)
            {
                pcb_perso.BackgroundImage = Projet_T3.Properties.Resources.eleve_1;
            }
            else if (diff == 1)
            {
                pcb_perso.BackgroundImage = Projet_T3.Properties.Resources.eleve3;
            }
            else
            {
                pcb_perso.BackgroundImage = Projet_T3.Properties.Resources.eleve_2;
            }

            //initialisation des composants
            lbl_pseudo.Text += pseu;
            remplirBulletin();
        }

        /**
          * \fn void Btn_quitter_Click
          * \brief permet de fermer le jeu (le formulaire principal)
          */
        private void Btn_quitter_Click(object sender, EventArgs e)
        {
            //ajout du joueur à la table des scores
            ajoutScore();
            Application.Exit();
        }

        /**
         * \fn void Btn_menu_Click
         * \brief affiche le menu (fin de la partie)
         */
        private void Btn_menu_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Menu menu = new Menu();
            this.Controls.Add(menu);
        }

        /**
         * \fn void Btn_continue_Click
         * \brief permet de continuer la partie, donc affiche le UserControl ucPartie
         */
        private void Btn_continue_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ucPartie partie = new ucPartie(difficulte,pseudo,1,numJour+1,100);
            this.Controls.Add(partie);
        }

        /**
         * \fn void note
         * \brief permet de calculer la note de l'élève pour un prof donné
         * \param[in] idProf : identifiant du professeur
         * \return la note de l'élève selon le prof 
         */
        private double note(int idProf)
        {
            int merite = -1;
            int comp = -1;
            //parcours de la table cours à la recherche de la ligne correspondant à l'idProf passé en paramètre
            for (int i = 0; i < dsLocal.Tables["cours"].Rows.Count; i++)
            {
                if (dsLocal.Tables["cours"].Rows[i][0].ToString() == idProf.ToString())
                {
                    merite = Convert.ToInt32(dsLocal.Tables["cours"].Rows[i][2]);
                    comp = Convert.ToInt32(dsLocal.Tables["cours"].Rows[i][3]);
                }
            }
            //retourne la note du prof méritocratique
            if (idProf == 0)
            {
                return (((3.0 * merite / 100.0) + (comp / 100.0)) / 4.0) * 20.0;
            }
            //retourne la note du prof élitiste
            if (idProf == 1)
            {
                return (((merite / 100.0) + (comp * 3.0 / 100.0)) / 4.0) * 20.0;
            }
            //retourne la note du prof entre deux
            else
            {
                return (((1.5 * merite / 100.0) + (2.5 * comp / 100.0)) / 4.0) * 20.0;
            }
                
        }
       

        

        /**
         * \fn void chargementDsLocal
         * \brief charge la base de données en local
         */
        private void remplirBulletin()
        {

            double noteNorm = Math.Round(note(2),2);
            lblNoteNormal.Text += " " + noteNorm.ToString();

            double noteMeri = Math.Round(note(0),2);
            lblNoteMerito.Text += " " + noteMeri.ToString();


            double noteEllit =Math.Round(note(1),2);
            lblNoteElli.Text += " " + noteEllit.ToString();

            for (int i = 0; i < dsLocal.Tables["profs"].Rows.Count; i++)
            {
                //On récupère le prof méritocratique à l'id 0
                if (Convert.ToInt32(dsLocal.Tables["profs"].Rows[i][0]) == 0)
                {
                    lblProfMerito.Text += dsLocal.Tables["profs"].Rows[i][2].ToString();
                    lblMatiereMerito.Text = "Français";
                    
                }
                //On récupère le prof élitiste à l'id 1
                else if (Convert.ToInt32(dsLocal.Tables["profs"].Rows[i][0]) == 1)
                {
                    lblProfElli.Text += dsLocal.Tables["profs"].Rows[i][2].ToString();
                    lblMatiereElli.Text = "Mathématiques";                   
                }
                //On récupère le prof normal à l'id 2
                else
                {
                    lblProfZen.Text += dsLocal.Tables["profs"].Rows[i][2].ToString();
                    lblMatiereZen.Text = "Histoire";            
                }
            }

            //on met les appréciations de méritocratique
            if (noteMeri < 10)
                lblApprMerito.Text = "Il faut plus participer en classe pour y arriver";
            else if (noteMeri < 15)
                lblApprMerito.Text = "Bonne participation, poursuivez vos effort";
            else
                lblApprMerito.Text = "Excellent travail ! Très bonne participation en classe ! Bravo !";
            //on met les appréciations de elitiste
            if (noteEllit < 10)
                lblApprElli.Text = "Je ne vois même pas ce que vous faites dans cette classe";
            else if (noteEllit < 15)
                lblApprElli.Text = "A quelques éclairs de génie les jours de pleines lunes";
            else
                lblApprElli.Text = "Travail remarquable";
            //on met les appréciations de normal
            if (noteNorm < 10)
                lblApprNormal.Text = "Dommage";
            else if (noteNorm < 15)
                lblApprNormal.Text = "Travail sérieux mais pas toujours concentré";
            else
                lblApprNormal.Text = "Rien à dire ! Continuez ainsi";

            double notegenerale = Math.Round(((noteEllit + noteMeri + noteNorm) / 3),2);

            lblNoteGeneral.Text = notegenerale.ToString();
        }


        /**
        * \fn void ajoutScore
        * \brief ajoute le score du joueur à la table des scores
        */
        public void ajoutScore()
        {
            int nbPartie = dsLocal.Tables["scores"].Rows.Count;
            string moy = Math.Round(((note(0) + note(1) + note(2))/3),2).ToString();
             string requete = "INSERT INTO scores Values (" + nbPartie + ",\"" + pseudo + "\",\"" + moy + "\","+ difficulte+")";
            //Modifier la table 
            try
            {
                //Ouverture de la connexion
                connex.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\DBJeu.mdb";
                connex.Open();
                //entrée de la requete
                OleDbCommand cmd = new OleDbCommand(requete, connex);
                cmd.ExecuteNonQuery();

            }
            //Permet de retourner le type d'erreurs que le try catch soulève 
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
            finally
            {
                //fermeture de la connexion
                if (connex.State == ConnectionState.Open)
                {
                    connex.Close();
                }
            }
        }


        /**
         * \fn void chargementDsLocal
         * \brief charge la base de données en local
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
            for (int i = 0; i < schemaTable.Rows.Count; i++) // compte le nb de ligne du tableau
            {
                //pour recuperer la 3eme case d'une ligne
                nomTable = schemaTable.Rows[i][2].ToString(); //dans la ligne i on recupere la cellule n°3

                //etape 4 : construction de la req
                if (nomTable == "cours")
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
         * \fn void Button1_Click
         * \brief enregistre la note du joueur dans la table scores et ouvre le tableau des scores
         */
        private void Button1_Click(object sender, EventArgs e)
        {
            //ajout du joueur à la table des scores
            ajoutScore();
            ucScore score = new ucScore(difficulte,pseudo,numJour);
            this.Controls.Clear();
            this.Controls.Add(score);

        }
    }
}

