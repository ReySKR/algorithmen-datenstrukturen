namespace Algo_Datenstrukturen;

public class SortingAlgorithms<T> where T : IComparable<T>
{
    private T[] toSort;
    
    public SortingAlgorithms(T[] toSort)
    {
        this.toSort = toSort;
    }
    

    public void Bubblesort()
    {
        /*Idee: Iteriere solange über jedes Element bis alle sortiert sind nach folgendem Schema:
         * Vergleiche ob aktuelles Element kleiner ist als Nachfolgendes. Wenn ja Tausche!
         * 
         */
        printArray();
        bool wasSorted = true;
        while (wasSorted)
        {
            wasSorted = false;
            for (int i = 0; i < this.toSort.Length-1; i++)
            {
                if(toSort[i].CompareTo(toSort[i+1]) > 0)
                {
                    Swap(i, i+1);
                    wasSorted = true;
                }
                
            }
            
        }
    }

    public void Selectionsort()
    {
        printArray();
        /*Idee:
         1. Iteriere über jedes Element ausgehend vom zweiten denn das erste siehst du als Minimum an
         Für jedes Element (ab Element 2) Vergleiche Nachfolgende Elemente mit dem Minimum und tausche am Ende des Element mit dem Minimum
        */
        for (int i = 0; i < toSort.Length - 1; i++) 
        {
            int currentMinimumIndex = i; 

            for (int j = i + 1; j < toSort.Length; j++) 
            {
                if (toSort[currentMinimumIndex].CompareTo(toSort[j]) > 0)
                {
                    currentMinimumIndex = j;
                }
            }
    
            Swap(currentMinimumIndex, i); 
        }
    }

    private void printArray()
    {
        for (int i = 0; i < toSort.Length; i++)
        {
            Console.Write(toSort[i] + " ");
        }

        Console.WriteLine();
    }

    private void Swap(int index1, int index2)
    {
        for (int i = 0; i < toSort.Length; i++)
        {
            if (i == index1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(toSort[i] + " ");
            }
            else if (i == index2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(toSort[i] + " ");
            }
            else
            {
                Console.Write(toSort[i] + " ");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.Write("->" + " ");
        
        
        (toSort[index1], toSort[index2]) = (toSort[index2], toSort[index1]);


        for (int i = 0; i < toSort.Length; i++)
        {
            if (i == index1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(toSort[i] + " ");
            }
            else if (i == index2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(toSort[i] + " ");
            }
            else
            {
                Console.Write(toSort[i] + " ");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine();
        
    }
    
}