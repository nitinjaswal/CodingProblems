using System.Collections.Generic;

class MovingAverage
{
    Queue<int> queue;
    int windowSize;
    double sum;
    public MovingAverage(int size)
    {
        queue = new Queue<int>();
        windowSize = size;
    }


    public double Next(int val)
    {
        //If queue count is equal to window size, then dequeue first element
        if (queue.Count == windowSize)
        {
            queue.Dequeue();
        }

        //add new element in queue
        queue.Enqueue(val);

        //now iterate each element in the queue for runing sum
        foreach (var item in queue)
        {
            sum = sum + item;
        }

        //calculating average
        double runningAverage = (double)sum / queue.Count;

        return runningAverage;

    }

}