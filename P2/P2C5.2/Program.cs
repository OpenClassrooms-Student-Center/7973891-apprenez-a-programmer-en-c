// Définir l'URL à laquelle se connecter
using System.Net;

string chaineUrl = DonneeUtilisateur.DemanderUneUrl();

Console.WriteLine(RecupererContenu(chaineUrl));

/// <summary>
/// Retourner le contenu de l'URL
/// </summary>
/// <param name="url">L'adresse Web dont le contenu sera renvoyé</param>
string RecupererContenu(string url)
{
    string contenu = "";

    try
    {
        using (WebClient client = new WebClient())
        {
            contenu = client.DownloadString(url);
        }
    }
    catch (WebException e)
    {
        Console.WriteLine("Impossible d'établir une connexion - " + e.ToString());
    }

    return contenu;
}