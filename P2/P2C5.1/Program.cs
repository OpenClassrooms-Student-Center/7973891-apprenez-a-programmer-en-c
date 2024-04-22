string chaineUrl = "";
int nombreArguments;

if (args == null)
{
    nombreArguments = 0;
}
else
{
    nombreArguments = args.Length;
}

// affecter une valeur à chaineUrl ou quitter
switch (nombreArguments)
{
    case 0:
        chaineUrl = DemanderUneUrl();
        break;
    case 1:
        chaineUrl = args[0];
        break;
    default:
        Console.WriteLine("Veuillez exécuter le programme avec une URL ou rien du tout");
        Environment.Exit(-1);
        break;
}

Console.WriteLine("Vérification de l'URL " + chaineUrl);

if (URLValide(chaineUrl))
{
    Console.WriteLine(chaineUrl + " est une URL valide");
}
else
{
    Console.WriteLine(chaineUrl + " n'est pas une URL valide");
}


/// <summary>
/// Demander à l'utilisateur de saisir une URL
/// </summary>
/// <returns>Demander à l'utilisateur de saisir une URL</returns>
static string DemanderUneUrl()
{
    Console.WriteLine("Veuillez saisir une URL valide");
    string url = Console.ReadLine();
    return url;
}

/// <summary>
/// Vérifier le formatage d'une URL
/// </summary>
/// <param name="chaineUrl"></param>
/// <returns>vrai si le format correspond a une URL, sinon faux</returns>
static bool URLValide(string chaineUrl)
{
    if (Uri.IsWellFormedUriString(chaineUrl, UriKind.Absolute))
    {
        return true;
    }
    else
    {
        return false;
    }
}