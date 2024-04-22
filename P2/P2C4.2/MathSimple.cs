namespace P2C4._2;

public class MathSimple
{
    /// <summary>
    /// calculer la valeur moyenne d'une liste d'entiers. 
    /// return la moyenne de la liste
    /// </summary>
    /// <param name="listeDesEntiers"></param>
    /// <returns></returns>
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
