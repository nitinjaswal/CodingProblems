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
             PrintNumbers(5);                    

        }

        public static void PrintNumbers(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            PrintNumbers(n-1);
            Console.WriteLine(n);
        }

    }

}








