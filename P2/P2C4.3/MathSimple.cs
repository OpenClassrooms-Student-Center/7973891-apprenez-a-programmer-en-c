namespace P2C4._3;

public class MathSimple
{
    // <summary>
    /// Affiche la température moyenne à partir des valeurs fournies comme arguments en ligne de commande
    /// </summary>
    /// <param name="args">liste de températures séparées par des espaces</param>
    public static int CalculMoyenne(List<int> listeDesEntiers)
    {
        int moyenne = 0;

        foreach (int valeur in listeDesEntiers)
        {
            moyenne += valeur;
        }
        moyenne /= listeDesEntiers.Count;

        return moyenne;
    }
}
