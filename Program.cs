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
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(BinarySeacrh(arr, 5, 0, arr.Length - 1));
        }

        static int BinarySeacrh(int[] arr, int target, int start, int end)
          {
            if (start > end)
            {
                return -1;
            }

            int middle = start + (end - start) / 2;
            if(arr[middle] == target)
            {
                return middle;
            }
            else if (target < arr[middle])
            {
                end = middle - 1;
                return BinarySeacrh(arr, target, start, end);
            }
            else
            {
                start = middle + 1;
                return BinarySeacrh(arr, target, start, end);
            }
          
        }

    }

}








