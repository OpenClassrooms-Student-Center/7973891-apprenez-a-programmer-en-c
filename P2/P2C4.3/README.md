# Exécutez le code
Cliquez sur le bouton vert Run pour compiler et exécuter l'application.
Saisissez dans le terminal ou console Powershell dans Visual Studio, "dotnet run 3 9 4". Que produit-elle en sortie ? Pourquoi obtenez-vous une valeur entière ?
Saisissez dans le terminal ou console Powershell dans Visual Studio, "dotnet run". Pourquoi le programme plante-t-il ?
Notez le nom de l'exception mentionnée dans la trace d'appel, DivideByZeroException.

# Protection contre les arguments vides
Ouvrez le fichier Program.cs. Entourez le code (à partir de List<int>...) avec un bloc try.
Ajoutez un bloc catch qui prend en paramètre l'exception mentionnée dans la trace d'appel à l'étape précédente.
À l'intérieur du bloc catch, ajoutez une instruction Console.WriteLine avec un message pertinent pour l'utilisateur, lui demandant de fournir des arguments numériques de type entier.
Compilez et exécutez votre programme avec et sans fournir d'arguments.
La trace d'appel devrait maintenant être remplacée par le message que vous avez écrit à l'intérieur de votre bloc catch.
Bonus : ajoutez une autre instruction catch pour vous protéger contre les arguments non numériques, comme indiqué dans le cours.