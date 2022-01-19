using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Queue
{
    class DesignQueueUsingArray
    {
        int[] a;
        int capacity;
        int rear;

        public DesignQueueUsingArray(int n)
        {
            capacity = n;
            a = new int[n];
            rear = -1;
        }

        private void enqueue(int val)
        {
            if (rear == capacity - 1)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                rear++;
                a[rear] = val;
            }
        }

        private int dequeue(int val)
        {
            if (rear == -1)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            int result = a[0];//we dequeue from front
            //After removing element from front, shift all elementts to the left
            for (int i = 0; i < rear; i++)
            {
                a[i] = a[i + 1];
            }
            rear--;//updating rear position
            return result;
        }
    }
}
