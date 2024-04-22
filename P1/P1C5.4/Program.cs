IDictionary<string, int> mois = new Dictionary<string, int>();

// TODO : Remplacer les noms par des constantes de type chaine de caractères
mois.Add("Juin", 6);
mois.Add("Septembre", 9);
mois.Add("Mars", 5);

// TODO : Corriger la valeur de Mars avec (3)


// TODO : Retirer Juin


// Afficher le contenu du dictionnaire
Console.WriteLine("La liste des mois est :");
foreach (KeyValuePair<string, int> clePaire in mois)
{
    Console.WriteLine(clePaire.Key.ToString() + " est le numéro du mois de " + clePaire.Value + " de l'année ");
}