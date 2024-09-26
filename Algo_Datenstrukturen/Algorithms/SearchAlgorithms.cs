namespace Algo_Datenstrukturen.Algorithms;

public static class SearchAlgorithms
{
    public static bool BinarySearch(int[] arr, int searchValue, int left, int right)
    {
        while (left <= right)
        {
            int middle = (left + right) / 2;
            if(arr[middle] == searchValue)
            {
                return true;
            }
            if (arr[middle] > searchValue)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return false;
    }
}