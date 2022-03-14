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
            Console.WriteLine(SumOfDigits(number));
        }

        static int SumOfDigits(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return SumOfDigits(num / 10) * (num % 10);
        }

    }

}








