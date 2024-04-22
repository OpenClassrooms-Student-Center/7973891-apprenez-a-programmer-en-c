using P2C2._2;

Couleur couleurChoisie = Couleur.Vert;

// TODO : Remplacer la séquence if/else par une instruction switch équivalente qui fonctionne selon la valeur de couleurChoisie
if (couleurChoisie == Couleur.Bleu)
{
    Console.WriteLine("La couleur est bleue");
}
else if (couleurChoisie == Couleur.Vert)
{
    Console.WriteLine("La couleur est verte");
}
else if (couleurChoisie == Couleur.Rouge)
{
    Console.WriteLine("La couleur est rouge");
}
else if (couleurChoisie == Couleur.Jaune)
{
    Console.WriteLine("La couleur est jaune");
}
else
{
    Console.WriteLine("Cette couleur n'est pas connue !");
}