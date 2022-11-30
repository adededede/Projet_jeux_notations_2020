# Commandes git courantes (et suffisantes, si on veut éviter les problèmes)
*Par pitié, commencez en utilisant uniquement la ligne de commande*

**git status**


    Montre l'état du dépot (ce qu'il faut commit ou pas par exemple) et donne les commandes a utiliser ==> Très utile 



**git remote -v**

    Montre la liste des dépots distants (origin: ton dépot, group: le dépot du groupe)

**git branch -a**

    Permet de voir la liste des branches connues. La branche courante est notée avec une ‘*’.

**git diff [file]**

    Montre les modifications apportées à un fichier qui ne sont pas encore commit

**git checkout -- [file]**

    Permet d’annuler les modifications apportées à un fichier et de le remettre dans l’état où il était précédemment.

**git add [file]**

    Permet aussi bien :
    - d’ajouter un fichier non contrôlé au dépôt lors du prochain commit
    - d’ajouter les modifications d’un fichier sous contrôle au prochain commit

**git reset HEAD [file]**

    Permet d’enlever un fichier de la liste des fichiers à ajouter au prochain commit.

**git commit -m "Commentaire"**

    Crée un nouveau commit dans la branche courante (sous réserve d’avoir fait au moins un add avant). 


**git fetch [remote]**

    Récupère les commits du dépôt distant indiqué dont le dépôt local ne dispose pas encore. Si on n’indique pas de dépôt distant, c’est le dépôt origin qui sera interrogé.

**git merge [branch]**

    Crée un nouveau commit dans la branche courante qui fusionne les historiques de la branche courante et de la branche indiquée.

**git pull [remote] [branch]**

    Effectue un fetch suivi d’un merge. Si on n’indique ni dépôt distant ni branche, cette commande interroge le dépôt origin et fusionne la branche courante.


**git pull groupe master**

    Récupère les commits du dépôt du groupe dont le dépôt local ne dispose pas encore et fusionne la tête de la branche master de ce dernier dans la branche courante.

**git push**

    Envoie vers le dépôt d’origine les commits dont il ne dispose pas encore (vous pouvez constater sur l’interface web GitLab que vos nouveaux commits ont bien été ajoutés).



# Quand il y a un merge conflict : 
```
git fetch "git@git.unistra.fr:[login unistra]/projet1.git" "master"
git checkout -b "[login unistra]/projet1-master" FETCH_HEAD
git pull groupe master
```
Normalement sur votre console il y a marqué les fichier qui sont en conflit de merge,
Il faut que vous alliez dans ses fichiers, il y aura un endroit qui ressemblera a :
```
<<<<<<<< HEAD
        ce que vous avez modifier en local
====================
        ce qui était modifié sur git (mais que vous n'aviez pas en local)
>>>>>>>> origin/master
```
Il faut que vous gardiez soit [ce que vous avez modifier en local] soit [ce qui était modifié sur git (mais que vous n'aviez pas en local)], vous enlevez tout le reste. Puis : 
```
git add .
git commit -m "commentaire"
git fetch origin
git checkout "master"
git merge --no-ff "[login unistra]/projet1-master"
git push origin master
```
Et ensuite vous pouvez accepter le merge.