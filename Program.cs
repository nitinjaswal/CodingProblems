using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    class MyQueue
    {
        int[] a;
        int capacity;
        int rear;

        public MyQueue(int n)
        {
            capacity = n;
            a = new int[n];
            rear = -1;
        }

        public static void Main(String[] args)
        {

            MyCircularQueue obj = new MyCircularQueue(5);
            obj.EnQueue(1);
            obj.EnQueue(2);
            obj.EnQueue(3);
            obj.EnQueue(4);
            obj.EnQueue(5);
            obj.DeQueue();
            obj.DeQueue();
            obj.EnQueue(6);
            obj.Front();
        }

        public class MyCircularQueue
        {
            int front = 0;
            int rear = -1;
            int[] a;
            int n;
            int length;
            public MyCircularQueue(int k)
            {

                this.n = k; //length of the queue(array)
                a = new int[n];
            }

            public bool EnQueue(int value)
            {
                if (IsFull())
                {
                    return false;
                }
                //calculate rear
                rear = (rear + 1) % a.Length;
                a[rear] = value;
                length++;
                return true;

            }

            public bool DeQueue()
            {
                if (IsEmpty())
                {
                    return false;
                }
                //calculate front
                front = (front + 1) % a.Length;
                length--;
                return true;

            }

            public int Front()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                else
                {
                    return a[front];
                }
            }

            public int Rear()
            {
                if (IsEmpty())
                {
                    return -1;
                }
                else
                {
                    return a[rear];
                }
            }

            public bool IsEmpty()
            {
                if (length == 0)
                {
                    return true;
                }
                return false;
            }

            public bool IsFull()
            {
                if (length == a.Length)
                {
                    return true;
                }
                return false;
            }
        }
    }

}





