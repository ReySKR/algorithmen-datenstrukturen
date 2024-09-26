using Algo_Datenstrukturen.Algorithms;

namespace Algo_Datenstrukturen;

class Program
{
    static void Main(string[] args)
    {
        int[] array =  {1, 3, 2, 5, 4};

        SortingAlgorithms<int> sort = new SortingAlgorithms<int>(array);
        sort.QuickSort(0, 4);
        Console.WriteLine(SearchAlgorithms.BinarySearch(array, 5, 0, 4));
    }
}