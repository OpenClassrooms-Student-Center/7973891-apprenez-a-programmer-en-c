using P2C5._3;
using System.Net;

string chaineUrl = DonneeUtilisateur.DemanderUneUrl();

var contenu = RecupererContenu(chaineUrl);

try
{
    EcrireFichier.Ecrire(contenu, "output.txt");
}
catch (IOException e)
{
    Console.WriteLine("Impossible d'écrire dans le fichier - " + e.ToString());
}

/// <summary>
/// Retourner le contenu de l'URL
/// </summary>
/// <param name="url">L'URL de la ressource</param>
static string RecupererContenu(string url)
{
    string contenu = "";

    try
    {
        using (WebClient webClient = new WebClient())
        {
            contenu = webClient.DownloadString(url);
        }
    }
    catch (WebException e)
    {
        Console.WriteLine("Impossible d'établir une connexion - " + e.ToString());
    }

    return contenu;
}