
using P2C2._1;

/// <summary>
/// Ce programme affiche :
/// - un message Bonjour personnalisé si un argument a été envoyé lors de l'exécution du programme
/// - le traditionnel message "Bonjour le monde" si ce n'est pas le cas
/// </summary>
/// <remarks>Créé par l'équipe éducative d'OpenClassrooms</remarks>

if (args.Count() == 1)
{
    BonjourConditionel.DireBonjour(args[0]);
}
else
{
    BonjourConditionel.DireBonjour("le monde");
}

