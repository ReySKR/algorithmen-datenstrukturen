namespace Algo_Datenstrukturen.Datastructurs.Queue;

public class Queue<T> where T : IComparable<T>
{
    private int MAX = 1000;
    private int bottomPointer = 0;
    private int topPointer = 0;
    private T[] queue;

    public Queue()
    {
        queue = new T[MAX];
    }


    public int CompareTo(T? other)
    {
        throw new NotImplementedException();
    }
}