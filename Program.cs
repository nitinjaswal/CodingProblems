using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Challenges.Queue.ShortestDistance;

namespace Challenges
{
    class MyQueue
    {

        private Stack<int> s1 = new Stack<int>();
        private Stack<int> s2 = new Stack<int>();
        public static void Main(String[] args)
        {

        }

        public MyQueue()
        {

        }

        //Push element to the queue
        public void Enqueue(int x)
        {
            s1.Push(x);
        }

        //Dequeue element from queue
        public int Dequeue()
        {
            //copy all elements from stack1 to stack2
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }

            //remove top element from the stack(eventually it is first element in the stack1)
            int elementToRemove = s2.Pop();

            //copy back all the elements to stack1
            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }

            return elementToRemove;
        }

        //get the front element
        public int Peek()
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
            int element = s2.Peek();
            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }

            return element;
        }

        public bool Empty()
        {
            if (s1.Count == 0)
                return true;
            else
                return false;
        }
    }
}







