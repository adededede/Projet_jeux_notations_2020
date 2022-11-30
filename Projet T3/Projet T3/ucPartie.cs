using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
/**
 * \file $FILENAME
 * \brief UserControl qui affiche la partie du joueur
 * \version 1
 * \date $MONTHNAME_EN $YEAR
 * \author les canards boiteux
 */
namespace Projet_T3
{
    /**
     * \class ucPartie
     * \brief classe du userControl Partie, gère une partie en affichant le cours actuel, en gérant les actions du joueur, en affichant les réponses utilisateurs
     */
    public partial class ucPartie : UserControl
    {
        /**
         * \brief connexion pour la base de données
         */
        OleDbConnection connex = new OleDbConnection();
        /**
         * \brief dataSet où on copie la base de données pour travailler en déconnécté
         */
        DataSet dsLocal = new DataSet();
        /**
         * \brief nombre d'actions que le joueur fait dans le cours
         */
        int nbrAction = 0; //possibilité de faire 4 actions par cours, donc 12 par jour
        /**
         * \brief moral de l'élève lors de la partie
         */
        int moral;

        /**
         * \brief numéro de l'heure de cours de la journée
         */
        int heure; // 3 heures de cours dans la journée 
        /**
         * \brief numéro du jour de cours
         */
        int jour; //nombre de jours = nombre de fois que le joueur continue la partie
        /**
         * \brief identifiant du prof qui fait cours
         */
        int idProf; //type de prof (0 merite,1 elitiste, 2 normal)
        /**
         * \brief difficulté choisie par le joueur
         */
        int diff; //difficulté choisie par le joueur, c'est le niveau de l'élève
        /**
         * \brief pseudo choisi par le joueur
         */
        string surnom;//pseudo du joueur


        /**
          *  Constructeur
          *  \param[in] difficulte : difficulté choisie par le joueur
          *  \param[in] pseudo : pseudo choisi par le joueur
          *  \param[in] numHeure : numéro de l'heure de cours de la journée
          *  \param[in] numJour : numéro du jour de cours
          *  \param[in] morall : quantité de moral de l'élève
          */
        public ucPartie(int difficulte, string pseudo, int numHeure, int numJour, int morall)
        {
            //initialisation des variables globales
            heure = numHeure;
            diff = difficulte;
            surnom = pseudo;
            jour = numJour;
            moral = morall;


            InitializeComponent();
            chargementDsLocal();

            //initialisation du texte

            lblPseudo.Text += " " + surnom;
            lblHeure.Text += heure;
            lblJour.Text += jour;
            pgbMoral.Value = moral;

            enabledBouton();

            //affichage de l'élève correspondant à la difficulté choisie
            if (diff == 0)
            {
                pcb_perso.BackgroundImage = Projet_T3.Properties.Resources.eleve_1;
                lblDiff.Text += "Facile";
            }
            else if (diff == 1)
            {
                pcb_perso.BackgroundImage = Projet_T3.Properties.Resources.eleve3;
                lblDiff.Text += "Moyen";
            }
            else
            {
                pcb_perso.BackgroundImage = Projet_T3.Properties.Resources.eleve_2;
                lblDiff.Text += "Difficile";
            }

            //affichage du prof qui change en fonction du jour
            if (heure == 1)
            {
                pcb_prof.BackgroundImage = Projet_T3.Properties.Resources.Merry_Tocratick;
                idProf = 0;
                lblMatiere.Text = "Français";
            }
            else if (heure == 2)
            {
                pcb_prof.BackgroundImage = Projet_T3.Properties.Resources.Zen_Omax;
                idProf = 2;
                lblMatiere.Text = "Histoire";
            }
            else
            {
                pcb_prof.BackgroundImage = Projet_T3.Properties.Resources.Eli_Tiste;
                idProf = 1;
                lblMatiere.Text = "Mathématiques";
            }

        }

        /**
         * \fn void btnParticipe_Click
         * \brief permet de gérer quand l'utilisateur fait une action (nombre d'actions limitées+réponse du professeur)
         */
        private void btnParticipe_Click(object sender, EventArgs e)
        {

            //action positives
            if (Convert.ToInt32(((Button)sender).Tag) == 0 || Convert.ToInt32(((Button)sender).Tag) == 2) 
            {

                if (Convert.ToInt32(dsLocal.Tables["cours"].Rows[idProf][3]) >= 50 && pgbMoral.Value >= 20) //si on a beaucoup de compétences dans cette matière et qu'on a encore du moral
                {
                    faireAction(sender);
                    pgbMoral.Value = pgbMoral.Value - 20;

                    if (Convert.ToInt32(((Button)sender).Tag) == 2)
                        majCompetence(2); //mise à jour compétence selon son action
                    else
                        majMerite(0); //mise à jour de son mérite en fonction de son action
                }
                if (Convert.ToInt32(dsLocal.Tables["cours"].Rows[idProf][3]) < 50 && pgbMoral.Value >= 40)
                {
                    faireAction(sender);
                    pgbMoral.Value = pgbMoral.Value - 40;

                    if (Convert.ToInt32(((Button)sender).Tag) == 2)
                        majCompetence(2); //mise à jour compétence selon son action
                    else
                        majMerite(0); //mise à jour de son mérite en fonction de son action
                }
            }
            else
            {
                faireAction(sender);
                if (Convert.ToInt32(((Button)sender).Tag) == 3)
                    majCompetence(3); //mise à jour compétence selon son action
                else
                    majMerite(1); //mise à jour de son mérite en fonction de son action

                if (Convert.ToInt32(((Button)sender).Tag) == 3 && pgbMoral.Value < 100) //dormir
                {

                    if (pgbMoral.Value + 40 > 100)
                        pgbMoral.Value = 100;
                    else
                        pgbMoral.Value = pgbMoral.Value + 40;
                }
                else //bavarder
                {

                    if (pgbMoral.Value + 20 > 100)
                        pgbMoral.Value = 100;
                    else
                        pgbMoral.Value = pgbMoral.Value + 20;
                }

            }

            enabledBouton();

            //quand le nombre d'actions du cours est fini => changement de cours
            int limiteAction = 4;
            if (jour != 1)
                limiteAction = 4 + jour; //jour2 il pourra faire 6 actions, jour 3 il pourra en faire 8
            if (limiteAction > 8)
                limiteAction = 8; //on ne pourra jamais faire plus que 8 actions par cours

            if (nbrAction == limiteAction)
            {
                MessageBox.Show("Votre cours est fini", "Fin du cours", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //fin de la journee donc affichage du bulletin
                if (heure == 3)
                {
                    this.Controls.Clear();
                    ucBulletin partie = new ucBulletin(diff, jour, surnom);
                    this.Controls.Add(partie);

                }
                //prochain cours
                else
                {
                    moral = pgbMoral.Value;
                    this.Controls.Clear();
                    ucPartie partie = new ucPartie(diff, surnom, heure + 1, jour, moral);
                    this.Controls.Add(partie);
                }

            }
        }

        /**
         * \fn void faireAction
         * \brief permet de faire une action, change la phrase du prof 
         */
        private void faireAction(object sender)
        {
            nbrAction += 1;
            int min = 0;
            int max = 0;

            //Recupere les id phrase min et max correspondant au prof et à l'action
            for (int i = 0; i < dsLocal.Tables["phrases"].Rows.Count; i++)
            {
                if (dsLocal.Tables["phrases"].Rows[i][1].ToString() == idProf.ToString() && dsLocal.Tables["phrases"].Rows[i][2].ToString() == Convert.ToString(((Button)sender).Tag))
                {
                    min = i;
                    i = dsLocal.Tables["phrases"].Rows.Count; //sortie de la table dès que min est initialisé
                }
            }
            for (int i = 0; i < dsLocal.Tables["phrases"].Rows.Count; i++)
            {
                if (dsLocal.Tables["phrases"].Rows[i][1].ToString() == idProf.ToString() && dsLocal.Tables["phrases"].Rows[i][2].ToString() == Convert.ToString(((Button)sender).Tag))
                {
                    max = i;
                }

            }

            //Affichage de la phrase de façon aléatoire entre min et max qu'on a récupéré
            bool succes = false;
            Random rnd = new Random();
            int numLigne = rnd.Next(min, max);
            //Pour ne pas afficher deux fois le meme texte
            while (!succes)
            {
                string phrase = dsLocal.Tables["phrases"].Rows[numLigne][3].ToString();

                if (lblJour.Text != phrase)
                {
                    lbl_bulle.Text = phrase;
                    succes = true;
                }

                if (numLigne != max)
                {
                    numLigne++;
                }
                else
                {
                    numLigne = min;
                }
            }



        }

        /**
         * \fn void majMerite
         * \brief permet de mettre a jour le merite de l'élève dans un cours donné 
         * \param[in] action : identifiant de l'action (participer/travailler/bavarder/dormir)
         */
        private void majMerite(int action)
        {
            int tauxMerite = calculeMerite(action);
            string requete = "UPDATE cours SET merite=" + tauxMerite + " Where idProf=" + idProf + " AND idEleve=\"" + diff + "\"";
            dsLocal.Tables["cours"].Rows[idProf][2] = tauxMerite;

            //Modifier la table 
            try
            {
                //Ouverture de la connection
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
         * \fn void majCompétence
         * \brief permet de mettre a jour les compétences de l'élève dans un cours donné 
         * \param[in] action : identifiant de l'action (participer/travailler/dormir/bavarder)
         */
        private void majCompetence(int action)
        {
            int tauxCompetence = calculeCompetence(action);
            string requete = "UPDATE cours SET competence=" + tauxCompetence + " Where idProf=" + idProf + " AND idEleve=\"" + diff.ToString() + "\"";
            dsLocal.Tables["cours"].Rows[idProf][3] = tauxCompetence;
            
            //Modifier la table 
            try
            {
                //Ouverture de la connection
                connex.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\DBJeu.mdb";
                connex.Open();

                //entrée de la requete
                OleDbCommand cmd = new OleDbCommand(requete, connex);
                cmd.ExecuteNonQuery();

            }
            //Permet de retourner le type d'erreur que le try catch soulève 
            catch (Exception erreur)
            {
                MessageBox.Show(erreur.Message);
            }
            finally
            {
                //fermeture de la connection
                if (connex.State == ConnectionState.Open)
                {
                    connex.Close();
                }
            }

        }

        /**
         * \fn void calculeMerite
         * \brief calcule le mérite pour une action donné 
         * \param[in] action : identifiant de l'action (participer/travailler/dormir/bavarder)
         */
        private int calculeMerite(int action)
        {
            int res = Convert.ToInt32(dsLocal.Tables["cours"].Rows[idProf][2]); //récupération du mérite
            if (action == 0) //participer
                res += 25;
            if (action == 1) //bavarder
                res -= 25;

            //limite
            if (res < 0)
                res = 0;
            if (res > 100)
                res = 100;
            return res;
        }

        /**
         * \fn void calculeCompetence
         * \brief calcule la compétence pour une action donné 
         * \param[in] action : identifiant de l'action (participer/travailler/dormir/bavarder)
         */
        private int calculeCompetence(int action)
        {

            int res = (int)dsLocal.Tables["cours"].Rows[idProf][3]; //récupération de la compétences 
            if (action == 2) //travailler
                res += 10;
            if (action == 3) //dormir
                res -= 10;

            //limite
            if (res < 0)
                res = 0;
            if (res > 100)
                res = 100;
            return res;
        }

        /**
         * \fn void enabledBouton
         * \brief grise les boutons qui sont trop couteux en "point de moral" et les rends inutilisable
         */
        private void enabledBouton()
        {
            if ((Convert.ToInt32(dsLocal.Tables["cours"].Rows[idProf][3]) >= 50 && pgbMoral.Value < 20) || (Convert.ToInt32(dsLocal.Tables["cours"].Rows[idProf][3]) < 50 && pgbMoral.Value < 40))
            {
                btnParticipe.Enabled = false;
                btnTravail.Enabled = false;
                btnTravail.BackgroundImage = global::Projet_T3.Properties.Resources.travailler_off;
                btnParticipe.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_participer_off;
            }
            else
            {
                btnParticipe.Enabled = true;
                btnTravail.Enabled = true;
                btnTravail.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_travailler;
                btnParticipe.BackgroundImage = global::Projet_T3.Properties.Resources.Bouton_participer;
            }
        }

        /**
         * \fn void chargementDsLocal
         * \brief charge la base de donnée en local
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
                if (nomTable == "scores")
                    requete = "select * from [" + nomTable + "] order by score,pseudo";
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

    }
    
}
