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
        static ArrayList list = new ArrayList();
        public static void Main(String[] args)
        {
            int[] arr = { 3, 2, 18, 18, 9 };
            var index = FindElement(arr, 18, 0, arr.Length - 1);
        }

        static int FindElement(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (target == arr[mid])
                {
                    return mid;
                }
                //case 1: If array element at start is less than element at array mid
                if (arr[start] <= arr[mid])
                {
                    //Check if target element is in this range
                    if (target >= arr[start] && target <= arr[mid])
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else
                {
                    if (target >= arr[mid] && target <= arr[end])
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }
            return -1;
        }

    }

}








