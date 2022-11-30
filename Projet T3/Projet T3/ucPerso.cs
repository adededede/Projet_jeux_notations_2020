using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
/**
 * \file $FILENAME
 * \brief UserControl qui affiche le personnage et ses caractéristiques
 * \version 1
 * \date $MONTHNAME_EN $YEAR
 * \author les canards boiteux
 */
namespace Projet_T3
{
    /**
     * \class ucPerso
     * \brief classe du userControl Personnage, permet de changer les caractéristiques de l'élève
     */
    public partial class ucPerso : UserControl
    {
        /**
         * \brief connexion pour la base de donnée
         */
        OleDbConnection connex = new OleDbConnection();
        /**
         * \brief dataSet où on copie la base de données pour travailler en déconnécté
         */
        DataSet dsLocal = new DataSet();
        /**
         * \brief difficulté choisi par le joueur
         */
        int difficulte; //difficulté séléctionnée par le joueur
        /**
         * \brief nombre de points à attribuer en fonction de la difficulté
         */
        int pointDeBase; //nombre de points à distribuer en fonction de la difficulté
        /**
         * \brief valeur de la TrackBar des maths
         */
        int valeurActuelleMath; //valeur des points de compétences en math
        /**
         * \brief valeur de la TrackBar de français
         */
        int valeurActuelleFrancais; //valeur des points de compétences en français
        /**
         * \brief valeur de la TrackBar d'histoire
         */
        int valeurActuelleHisto; //valeur des points de compétences en histoire
        /**
         * \brief true si les valeurs initiales ne sont pas mise, false sinon
         */
        bool debut=true; //true si les valeurs initiales ne sont pas mise, false sinon
        /**
         * true si on a pas enregistré le changement de valeur du joueur, false pour qu'on modifie les deux autres valeurs sans passer dans les if
         */
        bool chang = false; //true si on a pas enregistré le changement de valeur du joueur, false pour qu'on modifie les deux autres valeurs sans passer dans les if

        /**
        *  Constructeur
        *  \param[in] diff : difficulté choisie par le joueur 
        */
        public ucPerso(int diff)
        {
            difficulte = diff;
            InitializeComponent();
            //affichage de l'élève et du nombre de points correspondant à la difficulté choisie
            if (diff == 0)
            {
                pcb_perso.BackgroundImage = Projet_T3.Properties.Resources.eleve_1;
                pointDeBase = 240;
                tbMath.Value = pointDeBase / 3;
                tbFrancais.Value = pointDeBase / 3;
                tbHisto.Value = pointDeBase / 3;

            }
            else if (diff == 1)
            {
                pcb_perso.BackgroundImage = Projet_T3.Properties.Resources.eleve3;
                pointDeBase = 120;
                tbMath.Value = pointDeBase / 3;
                tbFrancais.Value = pointDeBase / 3;
                tbHisto.Value = pointDeBase / 3;
            }
            else
            {
                pcb_perso.BackgroundImage = Projet_T3.Properties.Resources.eleve_2;
                pointDeBase = 60;
                tbMath.Value = pointDeBase / 3;
                tbFrancais.Value = pointDeBase / 3;
                tbHisto.Value = pointDeBase / 3;
            }

            valeurActuelleMath = pointDeBase / 3;
            valeurActuelleFrancais = pointDeBase / 3;
            valeurActuelleHisto = pointDeBase / 3;

            debut = false;
        }

      

        /**
        * \fn void viderCours
        * \brief permet de vider la table des cours
        */
        private void viderCours()
        {
            string requete = "DELETE FROM cours";
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
        * \fn void majCompetence
        * \brief permet de mettre à jour les compétences dans la base de données
        * \param[in] val : valeur des compétences de l'élève en question
        * \param[in] idProf : identifiant du prof 
        */
        private void majCompetence(int val,int idProf)
        {
            int merite;
            if (difficulte == 0)
            {
                merite = 50;
            }
            else if (difficulte == 1)
            {
                merite = 40;
            }
            else
            {
                merite = 30;
            }
            string requete = "INSERT INTO cours Values(" + idProf + ",\"" + difficulte + "\"," + merite + "," + val + ")";

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
                //fermeture de la connection
                if (connex.State == ConnectionState.Open)
                {
                    connex.Close();
                }
            }
        }

        /**
        * \fn void btn_continue_Click
        * \brief appel les fonctions de mise à jour et charge la table en local
        */
        private void btn_continue_Click(object sender, EventArgs e)
        {
            //appel des fonctions de maj des compétences
            viderCours();
            majCompetence(tbMath.Value, 1); //mathématiques prof elitiste
            majCompetence(tbFrancais.Value, 0); //français prof méritocratique
            majCompetence(tbHisto.Value, 2); //histoire prof normal

            chargementDsLocal();

            
            //on initialise f comme le frmPerso qui est ouvert, il n'y en a qu'un
            frmPerso f = (frmPerso)Application.OpenForms["frmPerso"];
            f.Close();
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
                
                //etape 4 : construction de la requête
                if (nomTable == "scores")
                    requete = "select * from [" + nomTable + "] order by score,pseudo";
                else if (nomTable == "cours")
                    requete = "select * from [" + nomTable + "] order by idProf";
                else
                    requete = "select * from [" + nomTable + "]";

                //Etape 5 : Execution de la requête
                OleDbCommand cd = new OleDbCommand(requete, connex);
                OleDbDataAdapter da = new OleDbDataAdapter(cd);

                // Etape 6 : Phase de remplissage
                da.Fill(dsLocal, nomTable);


            }
        }



        /**
        * \fn void TbMath_ValueChanged
        * \brief permet de gérer les points de compétences et leurs répartitions
        */
        private void TbMath_ValueChanged(object sender, EventArgs e)
        {

            int ptsArepartir = 0;

            if (Convert.ToInt32(((TrackBar)sender).Tag) == 0 && !debut && !chang) //Trackbar des maths
            {
                chang = true;
              
                if(valeurActuelleMath-tbMath.Value<0) //quand on augmente la valeur de la trackbar des maths
                {
                    //on peut aller que de 10 en 10
                    if (valeurActuelleMath + 10 <= 100)
                    {
                        if (tbMath.Value - valeurActuelleMath != 10)
                            tbMath.Value = valeurActuelleMath + 10;
                    }
                    else
                        tbMath.Value = valeurActuelleMath;

                    ptsArepartir = Math.Abs(valeurActuelleMath - tbMath.Value);
                        
                    if (valeurActuelleFrancais-( ptsArepartir / 2)>=0 && valeurActuelleHisto-(ptsArepartir / 2)>=0)
                    {
                        valeurActuelleMath = tbMath.Value;
                        tbFrancais.Value -= ptsArepartir / 2;
                        valeurActuelleFrancais = tbFrancais.Value;
                        tbHisto.Value -= ptsArepartir / 2;
                        valeurActuelleHisto = tbHisto.Value;
                    }
                    else if (valeurActuelleFrancais-(ptsArepartir / 2)<0 && valeurActuelleHisto-ptsArepartir>=0)
                    {
                        valeurActuelleMath = tbMath.Value;
                        tbHisto.Value -= ptsArepartir ;
                        valeurActuelleHisto = tbHisto.Value;
                    }
                    else if(valeurActuelleHisto-(ptsArepartir/2)<0 && valeurActuelleFrancais-ptsArepartir>=0)
                    {
                        valeurActuelleMath = tbMath.Value;
                        tbFrancais.Value -= ptsArepartir;
                        valeurActuelleFrancais = tbFrancais.Value;
                    }
                    else
                        tbMath.Value = valeurActuelleMath;
                    chang = false;
                    
                }
                else //quand on baisse la valeur de la trackBar
                {

                    //on peut aller que de 10 en 10
                    if (valeurActuelleMath - 10 >= 0)
                    {
                        if (tbMath.Value - valeurActuelleMath != -10)
                            tbMath.Value = valeurActuelleMath - 10;
                    }
                    else
                        tbMath.Value = valeurActuelleMath;

                    ptsArepartir = Math.Abs(valeurActuelleMath - tbMath.Value);
                    

                    if (valeurActuelleHisto + (ptsArepartir / 2) <= 100 && valeurActuelleFrancais + (ptsArepartir / 2) <= 100)
                    {
                        valeurActuelleMath = tbMath.Value;
                        tbFrancais.Value += ptsArepartir / 2;
                        valeurActuelleFrancais = tbFrancais.Value;
                        tbHisto.Value += ptsArepartir / 2;
                        valeurActuelleHisto = tbHisto.Value;
                    }
                    else if (valeurActuelleHisto + (ptsArepartir / 2) > 100 && valeurActuelleFrancais+ptsArepartir<=100)
                    {
                        valeurActuelleMath = tbMath.Value;
                        tbFrancais.Value += ptsArepartir;
                        valeurActuelleFrancais = tbFrancais.Value;
                    }
                    else if(valeurActuelleFrancais+(ptsArepartir/2)>100 && valeurActuelleHisto+ptsArepartir<=100)
                    {
                        valeurActuelleMath = tbMath.Value;
                        tbHisto.Value += ptsArepartir ;
                        valeurActuelleHisto = tbHisto.Value;
                    }
                    else
                        tbMath.Value = valeurActuelleMath;

                    chang = false;
                }
            }
            if(Convert.ToInt32(((TrackBar)sender).Tag) == 1 && !debut && !chang) //trackBar de français
            {
                chang = true;
                if (valeurActuelleFrancais - tbFrancais.Value < 0) //quand on augmente la valeur 
                {
                    //on peut aller que de 10 en 10
                    if (valeurActuelleFrancais + 10 <= 100)
                    {
                        if (tbFrancais.Value - valeurActuelleFrancais != 10)
                            tbFrancais.Value = valeurActuelleFrancais + 10;
                    }
                    else
                        tbFrancais.Value = valeurActuelleFrancais;

                    ptsArepartir = Math.Abs(valeurActuelleFrancais - tbFrancais.Value);
                        

                    if (valeurActuelleMath >= ptsArepartir / 2 && valeurActuelleHisto >= ptsArepartir / 2)
                    {
                        valeurActuelleFrancais = tbFrancais.Value;
                        tbMath.Value -= ptsArepartir / 2;
                        valeurActuelleMath = tbMath.Value;
                        tbHisto.Value -= ptsArepartir / 2;
                        valeurActuelleHisto = tbHisto.Value;
                    }
                    else if (valeurActuelleMath - (ptsArepartir / 2) < 0 && valeurActuelleHisto - ptsArepartir >= 0)
                    {
                        valeurActuelleFrancais = tbFrancais.Value;
                        tbHisto.Value -= ptsArepartir;
                        valeurActuelleHisto = tbHisto.Value;
                    }
                    else if(valeurActuelleHisto - (ptsArepartir / 2) < 0 && valeurActuelleMath - ptsArepartir >= 0)
                    {
                        valeurActuelleFrancais = tbFrancais.Value;
                        tbMath.Value -= ptsArepartir;
                        valeurActuelleMath = tbMath.Value;
                    }
                    else
                        tbFrancais.Value = valeurActuelleFrancais;

                    chang = false;
                   
                }
                else //quand on baisse la valeur de la trackbar de français
                {
                    //on peut aller que de 10 en 10
                    if (valeurActuelleFrancais - 10 >= 0)
                    {
                        if (tbFrancais.Value - valeurActuelleFrancais != -10)
                            tbFrancais.Value = valeurActuelleFrancais - 10;
                    }
                    else
                        tbFrancais.Value = valeurActuelleFrancais;

                    ptsArepartir = Math.Abs(valeurActuelleFrancais - tbFrancais.Value);
                    


                    if (valeurActuelleHisto + (ptsArepartir / 2) <= 100 && valeurActuelleMath + (ptsArepartir / 2) <= 100)
                    {
                        valeurActuelleFrancais = tbFrancais.Value;
                        tbMath.Value += ptsArepartir / 2;
                        valeurActuelleMath = tbMath.Value;
                        tbHisto.Value += ptsArepartir / 2;
                        valeurActuelleHisto = tbHisto.Value;
                    }
                    else if (valeurActuelleHisto + (ptsArepartir / 2) > 100 && valeurActuelleMath+ptsArepartir<=100)
                    {
                        valeurActuelleFrancais = tbFrancais.Value;
                        tbMath.Value += ptsArepartir;
                        valeurActuelleMath = tbMath.Value;
                    }
                    else if(valeurActuelleMath + (ptsArepartir / 2) > 100 && valeurActuelleHisto + ptsArepartir <= 100)
                    {
                        valeurActuelleFrancais = tbFrancais.Value;
                        tbHisto.Value += ptsArepartir;
                        valeurActuelleHisto = tbHisto.Value;
                    }
                    else
                        tbFrancais.Value = valeurActuelleFrancais;

                    chang = false;
                }
            }
            if(Convert.ToInt32(((TrackBar)sender).Tag) == 2 && !debut && !chang) //trackBar d'histoire
            {
                chang = true;
                if (valeurActuelleHisto - tbHisto.Value < 0) //quand on augmente la valeur 
                {
                    //on peut aller que de 10 en 10
                    if (valeurActuelleHisto + 10 <= 100)
                    {
                        if (tbHisto.Value - valeurActuelleHisto != 10)
                            tbHisto.Value = valeurActuelleHisto + 10;
                    }
                    else
                        tbHisto.Value = valeurActuelleHisto;

                    ptsArepartir = Math.Abs(valeurActuelleHisto - tbHisto.Value);
                        

                    if (valeurActuelleMath - (ptsArepartir / 2)>=0 && valeurActuelleFrancais-(ptsArepartir / 2)>=0)
                    {
                        valeurActuelleHisto = tbHisto.Value;
                        tbFrancais.Value -= ptsArepartir / 2;
                        valeurActuelleFrancais = tbFrancais.Value;
                        tbMath.Value -= ptsArepartir / 2;
                        valeurActuelleMath = tbMath.Value;
                    }
                    else if (valeurActuelleMath-(ptsArepartir / 2)<0 && valeurActuelleFrancais-ptsArepartir>=0)
                    {
                        valeurActuelleHisto = tbHisto.Value;
                        tbFrancais.Value -= ptsArepartir;
                        valeurActuelleFrancais = tbFrancais.Value;
                    }
                    else if(valeurActuelleFrancais - (ptsArepartir / 2) < 0 && valeurActuelleMath - ptsArepartir >= 0)
                    {
                        valeurActuelleHisto = tbHisto.Value;
                        tbMath.Value -= ptsArepartir;
                        valeurActuelleMath = tbMath.Value;
                    }
                    else
                        tbHisto.Value = valeurActuelleHisto;

                    chang = false;
                }
                else //quand on baisse la valeur de la trackBar d'histoire
                {
                    //on peut aller que de 10 en 10
                    if (valeurActuelleHisto - 10 >= 0)
                    {
                        if (tbHisto.Value - valeurActuelleHisto != -10)
                            tbHisto.Value = valeurActuelleHisto - 10;
                    }
                    else
                        tbHisto.Value = valeurActuelleHisto;

                    ptsArepartir = Math.Abs(valeurActuelleHisto - tbHisto.Value);

                    if(valeurActuelleFrancais+(ptsArepartir/2)<=100 && valeurActuelleMath + (ptsArepartir / 2) <= 100)
                    {
                        valeurActuelleHisto = tbHisto.Value;
                        tbFrancais.Value += ptsArepartir / 2;
                        valeurActuelleFrancais = tbFrancais.Value;
                        tbMath.Value += ptsArepartir / 2;
                        valeurActuelleMath = tbMath.Value;
                    }
                    else if(valeurActuelleFrancais + (ptsArepartir / 2) > 100 && valeurActuelleMath+ptsArepartir<=100)
                    {
                        valeurActuelleHisto = tbHisto.Value;
                        tbMath.Value += ptsArepartir;
                        valeurActuelleMath = tbMath.Value;
                    }
                    else if(valeurActuelleFrancais + ptsArepartir  <= 100 && valeurActuelleMath + (ptsArepartir/2) > 100)
                    {
                        valeurActuelleHisto = tbHisto.Value;
                        tbFrancais.Value += ptsArepartir;
                        valeurActuelleFrancais = tbFrancais.Value;
                    }
                    else
                    {
                        tbHisto.Value = valeurActuelleHisto;
                    }
                    
                    chang = false;
                }
            }
        }

        /**
        * \fn void Btn_quitter_Click
        * \brief permet de quitter le frmPerso et de revenir au form principal
        */
        private void Btn_quitter_Click(object sender, EventArgs e)
        {
            //on initialise f comme le frmPerso qui est ouvert, il n'y en a qu'un
            frmPerso f = (frmPerso)Application.OpenForms["frmPerso"];
            f.Close();
        }
    }
}
