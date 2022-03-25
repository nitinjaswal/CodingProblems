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
            int[] arr = { 2, 0, 2, 1, 1, 0 };
            BubbleSort(arr, arr.Length - 1, c: 0);
        }
        public static void BubbleSort(int[] arr, int r, int c)
        {
            if (r == 0)
            {
                return;
            }
            if (c < r)
            {
                if (arr[c] > arr[c + 1])
                {
                    int temp = arr[c];
                    arr[c] = arr[c + 1];
                    arr[c + 1] = temp;
                    BubbleSort(arr, r, c: c + 1);
                }
            }
            else
            {
                BubbleSort(arr, r: r - 1, c: 0);
            }
        }

    }

}








