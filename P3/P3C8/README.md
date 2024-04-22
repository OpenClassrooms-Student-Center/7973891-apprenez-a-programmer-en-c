# Activité C#

Création d'un gestionnaire de compte bancaire

Créez une application console pour gérer un compte courant et un compte épargne. Implémentez la possibilité d'afficher les informations sur le titulaire de ces comptes et leurs soldes, ainsi que d'effectuer des dépôts et des retraits.

Lorsque l'application se termine, écrivez toutes les transactions du compte courant et du compte épargne dans un fichier texte.

__Incluez les fonctionnalités suivantes :__

* Afficher les informations sur le titulaire du compte, telles que le nom et le numéro de compte du titulaire du compte
* Afficher le solde du compte courant
* Afficher le solde du compte d'épargne
* Effectuer un dépôt sur le compte courant
* Effectuer un dépôt sur le compte épargne
* Effectuer un retrait sur le compte courant
* Effectuer un retrait sur le compte épargne
* Quitter l'application
* Lorsque vous cliquez sur le bouton bleu Run, affichez le message :

```
Appuyez sur Entrée pour afficher le menu.
  ```
  
Lorsque l'utilisateur appuie sur Entrée, le menu s'affiche :

```
Veuillez sélectionner une option ci-dessous :
[I] Voir les informations sur le titulaire du compte
[CS] Compte courant - Consulter le solde
[CD] Compte courant - Déposer des fonds
[CR] Compte courant - Retirer des fonds
[ES] Compte épargne - Consulter le solde
[ED] Compte épargne - Déposer des fonds
[ER] Compte épargne - Retirer des fonds
[X] Quitter
```

Lorsque vous saisissez l'une des séquences de touches entre crochets, la fonction correspondante est exécutée.

Par exemple, si vous tapez « CD » et que vous validez, le message suivant s'affiche:

```
Quel montant souhaitez-vous déposer ? 
  ```
  
Vous tapez « 20 » et appuyez sur Entrée.

```
Vous avez déposé : 20 €.
Appuyez sur Entrée pour afficher le menu.

  ```
Appuyez sur Entrée pour afficher à nouveau le menu, puis tapez « CS ».

```
Solde du compte courant : 20 €
Appuyez sur Entrée pour afficher le menu.
  ```
  
Le même principe s'applique pour les autres fonctions de l'application.

__Dans cet exercice, vous devriez utiliser les notions suivantes :__

* Héritage
* Constructeurs
* Liste
* Boucle
* Propriétés



  