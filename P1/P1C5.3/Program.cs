ISet<string> ingredients = new HashSet<string>();
ingredients.Add("sucre");
ingredients.Add("chocolat");
ingredients.Add("beurre");
ingredients.Add("vanille");

// TODO : ajouter un autre ingrédient à l'ensemble


// TODO : retirer la vanille de l'ensemble


// Afficher la liste des ingrédients
Console.WriteLine("Voici la liste de nos ingrédients");
foreach (string ingredient in ingredients)
{
    Console.WriteLine(ingredient);
}