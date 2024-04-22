using P2C4._3;

List<int> temperaturesEnregistreDegresCelcius = new List<int>();

// remplir la liste à partir des valeurs fournies comme arguments en ligne de commande
foreach (string stringRepresentationTemperature in args)
{
    int temperature = int.Parse(stringRepresentationTemperature);
    temperaturesEnregistreDegresCelcius.Add(temperature);
}

// Calculer et afficher la température moyenne
int moyenneTemperature = MathSimple.CalculMoyenne(temperaturesEnregistreDegresCelcius);
Console.WriteLine("La température moyenne est " + moyenneTemperature);