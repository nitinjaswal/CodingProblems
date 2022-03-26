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
            int[] arr = { -2, 3, -5 };
            arr = SortArray(arr);

        }
        public static int[] SortArray(int[] nums)
        {
            return MergeSort(nums, 0, nums.Length - 1);
        }

        public static int[] MergeSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = low + (high - low) / 2;
                int[] left = MergeSort(arr, low, mid);
                int[] right = MergeSort(arr, mid + 1, high);
                return Merge(left, right);
            }

            return new int[] { arr[low] };
        }

        private static int[] Merge(int[] first, int[] second)
        {
            int[] newArr = new int[first.Length + second.Length];

            int i = 0;
            int j = 0;
            int k = 0;
            while (i < first.Length && j < second.Length)
            {
                if (first[i] < second[j])
                {
                    newArr[k] = first[i];
                    i++;
                }
                else
                {
                    newArr[k] = second[j];
                    j++;
                }
                k++;
            }

            //add remaining elements in new array. Either one of the loop will work
            for (; i < first.Length; i++)
            {
                newArr[k] = first[i];
                k++;
            }
            for (; j < second.Length; j++)
            {
                newArr[k] = second[j];
                k++;
            }
            return newArr;
        }

    }

}








