using System.Collections.Generic;

public class MyStackUsingSingleQueue
{
    private Queue<int> q1 = new Queue<int>();

    public MyStackUsingSingleQueue()
    {

    }

    public void Push(int x)
    {
        //Add element
        q1.Enqueue(x);

        // get previous size of queue
        int size = q1.Count;

        // Pop (or Dequeue) all previous
        // elements and put them after current
        // element
        for (int i = 0; i < size - 1; i++)
        {
            // this will add front element into
            // rear of queue
            q1.Enqueue(q1.Dequeue());

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
