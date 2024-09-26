namespace Algo_Datenstrukturen;

public class SortingAlgorithms<T> where T : IComparable<T>
{
    /*Klausurtipps / -erkenntnisse:
     1. Überlege ob die Funktion für ein Minima geht und für von deren Maxima-1 auf das Maxima schließbar ist. Wenn das so ist stimmt die Funktion mit hoher Wahrscheinlichkeit! */
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

    public void InsertionSort()
    {
        printArray();
        /*
         * Idee:
         * Iteriere über Liste. Nehme dabei den aktuellen Index der Iteration als Teiler der Liste. Unterer Teil ist sortiert, oberere unsortiert.
         * Vergleiche ob Elemente der unsortierten Liste kleiner sind als das Maximum der unsortierten Liste. Wenn ja dann Inserte diese solange ein bis sortiert
         */
        for (int i = 1; i < toSort.Length+1; i++)
        {
            int currentMaximumIndex = i - 1;
            int j = currentMaximumIndex;
            while ((j >= 1) && (toSort[j].CompareTo(toSort[j - 1]) < 0))
            {
                Swap(j, j - 1);
                j--;
            }
        }
    }

    public void QuickSort(int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(left, right);
            QuickSort(left, pivotIndex-1);
            QuickSort(pivotIndex+1, right);
        }
    }

    private int Partition(int left, int right)
    {
        int pivotIndex = new Random().Next(left, right);
        var pivot = toSort[pivotIndex];
        Console.WriteLine("Swap of Pivot");
        Swap(pivotIndex, right);
        int leftPointer = left;
        for (int i = left; i < right; i++)
        {
            if (toSort[i].CompareTo(pivot) <= 0)
            {
                Swap(i, leftPointer);
                leftPointer++;
            }
        }
        Swap(leftPointer, right);
        return leftPointer;
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