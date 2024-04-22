//TODO
//Ajoutez les lignes manquantes à ce fichier pour pouvoir y accéder depuis une autre classe.

/// <summary>
/// Demande à l'utilisateur de saisir une URL
/// </summary>
/// <returns>Une représentation sous forme de chaîne de caractères de l'URL saisie par l'utilisateur</returns>.
public static string DemanderUneUrl()
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
private static bool URLValide(string chaineUrl)
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
