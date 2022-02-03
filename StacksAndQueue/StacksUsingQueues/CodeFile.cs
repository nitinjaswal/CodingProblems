using System.Collections.Generic;

public class MyStack
{
    private Queue<int> q1 = new Queue<int>();
    private Queue<int> q2 = new Queue<int>();
    public MyStack()
    {

    }

    public void Push(int x)
    {
        //copy all elements from queue1 to queue2
        while (q1.Count > 0)
        {
            q2.Enqueue(q1.Dequeue());
        }

        q1.Enqueue(x);

        //copy back all the elements to queue1
        while (q2.Count > 0)
        {
            q1.Enqueue(q2.Dequeue());
        }
    }

    public int Pop()
    {
        return q1.Dequeue();
    }

    public int Top()
    {
        return q1.Peek();
    }

    public bool Empty()
    {
        if (q1.Count == 0)
            return true;
        else
            return false;
    }
}