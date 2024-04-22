namespace P2C5._3;

public class EcrireFichier
{
    /// <summary>
    /// Ecrit le contenu d'une variable string dans un fichier.
    /// </summary>
    /// <param name="contenu">Le contenu à écrire dans le fichier</param>
    /// <param name="nomFichier">Le nom du fichier à écrire</param>
    public static void Ecrire(string contenu, string nomFichier)
    {
        try
        {
            File.WriteAllText(nomFichier, contenu);
            Console.WriteLine("Ecriture terminéee dans le fichier " + nomFichier);
        }
        catch (IOException e)
        {
            Console.WriteLine("Impossible d'écrire dans le fichier " + nomFichier + " " + e.ToString());
        }
    }
}
