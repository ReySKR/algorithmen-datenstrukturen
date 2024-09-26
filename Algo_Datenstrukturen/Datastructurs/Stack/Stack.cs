namespace Algo_Datenstrukturen.Datastructurs.Stack;

public class Stack<T>
{
    private int MAX = 1000;
    private int top;
    private T[] stack;

    public Stack(int size)
    {
        MAX = size;
        stack = new T[MAX];
        top = 0;
    }

    public void push(T item)
    {
        if (top + 1 < MAX)
        {
            top = top + 1;
            stack[top] = item;
        }
        else
        {
            throw new StackOverflowException();
        }
    }

    public T pop()
    {
        if (top - 1 >= 0)
        {
            top = top - 1;
            return stack[top + 1];
        }
        else
        {
            throw new Exception("Stack Underflow Exception");
        }
    }
}