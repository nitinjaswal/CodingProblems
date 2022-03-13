using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Challenges.Queue.ShortestDistance;

namespace Challenges
{
    public class TreeNode
    {
        public int val;
        public TreeNode left, right;

        public TreeNode(int item)
        {
            val = item;
            left = right = null;
        }
    }
    class LinkedList
    {

        public static void Main(String[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(Fib(i));
            }           
        }

        static int Fib(int n)
        {
            if (n == 0)
            {

                return 0;
            }
            if (n == 1)
            {

                return 1;
            }

            return Fib(n - 1) + Fib(n - 2);

        }

    }

}








