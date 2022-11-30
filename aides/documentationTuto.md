
# Comment documenter son code
Il faut commenter le code dès qu'on en écrit, comme ça a la fin du projet on va pouvoir générer les commentaire avec doxygen et ça sera magnifique 
## Début d'un fichier 
```cs
/**
 * \file $FILENAME
 * \brief description de ce que fait le file
 * \version numeroDeVersionDuFile
 * \date $MONTHNAME_EN $YEAR
 * \author nomDeAuteur
 */
```
## Mainpage 
Au début du fichier principal (je ne sais pas exactement lequel pour l'instant) il faut un commentaire pour dire ce que fait l'ensemble du code 
```cs 
/**
 * \mainpage titre
 * \brief détail de ce que fait le code
 */
```
## Fonctions
```cs
/**
 * \fn typeRetour nomFonction
 * \brief descriptionFonction
 * \param[in] $PARAMS : descriptionParam
 * \return $RETURN : descriptionReturn
 */
 ```

## Classe
```cs
/**
 * \class nomClass
 * \brief description de la classe
 */
 ```
