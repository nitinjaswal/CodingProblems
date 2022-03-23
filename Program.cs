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

            var result = Count(30204);
        }

        static int Count(int x)
        {
            return helper(x, 0);
        }

        private static int helper(int n, int count)
        {
            if (n == 0)
            {
                return count;
            }

            int rem = n % 10;
            if(rem == 0)
            {
                return helper(n / 10, count + 1);
            }
            else
            {
                return helper(n / 10, count);
            }
        }

    }

}








