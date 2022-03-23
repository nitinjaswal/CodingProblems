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

            var result = NumberOfSteps(123);
        }

        static int NumberOfSteps(int x)
        {
            return helper(x, 0);
        }

        private static int helper(int n, int count)
        {
            if (n == 0)
            {
                return count;
            }
            if (n % 2 == 0)
            {
                return helper(n/2, count+1);
            }
            else
            {
                return helper(n = n - 1, count + 1);
            }
        }

    }

}








