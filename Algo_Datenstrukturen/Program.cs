namespace Algo_Datenstrukturen;

class Program
{
    static void Main(string[] args)
    {
        int[] toSort = { 5, 9, 2, 3, 8, 1, 3 };
        SortingAlgorithms<int> sortingAlgorithms = new SortingAlgorithms<int>(toSort);
        sortingAlgorithms.Selectionsort();
    }
}