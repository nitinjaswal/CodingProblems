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
            int number = 1342;
            Console.WriteLine(ReverseNumber(number));
        }

        static long ReverseNumber(int num)
        {
            int digits = (int)Math.Floor(Math.Log10(num) + 1);
            return helper(num, digits);
        }

        private static long helper(int n, int digits)
        {
            if (n % 10 == 0)
            {
                return n;
            }
            int rem = n % 10;
            return rem * (long)Math.Pow(10, digits - 1) + helper(n / 10, digits - 1);
        }

    }

}








