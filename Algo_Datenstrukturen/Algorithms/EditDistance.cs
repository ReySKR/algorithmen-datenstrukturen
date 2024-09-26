namespace Algo_Datenstrukturen.Algorithms;

public class EditDistance
{
    public static int Calculate(string source, string target)
    {
        //Orange
        int[,] distanceMatrix = new int[source.Length + 1, target.Length + 1];

        // Initialisierung der ersten Zeile und Spalte
        //Pink
        for (int i = 0; i <= source.Length; i++)
            distanceMatrix[i, 0] = i;
        //Green
        for (int j = 0; j <= target.Length; j++)
            distanceMatrix[0, j] = j;

        // Berechnung der Distanzmatrix
        for (int i = 1; i <= source.Length; i++)
        {
            for (int j = 1; j <= target.Length; j++)
            {
                int cost = (source[i - 1] == target[j - 1]) ? 0 : 1;

                distanceMatrix[i, j] = Math.Min(
                    Math.Min(distanceMatrix[i - 1, j] + 1, distanceMatrix[i, j - 1] + 1),
                    distanceMatrix[i - 1, j - 1] + cost);
            }
        }

        return distanceMatrix[source.Length,   
            target.Length];
    }
}