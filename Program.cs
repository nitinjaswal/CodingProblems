using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }



    public class MyHashSet
    {
        static int[,] matrix = { { 1, 3, 5, 7 },
                        { 10, 11, 16, 20 },
                        { 23, 30, 34, 50 } };
        int K = 3;

        static int[][] arr = new int[][]
           {
                new int[] {1, 2, 3},
                new int[] {11, 34, 67},
                new int[] {89, 23,33}
          };
        public static void Main(String[] args)
        {
            // SearchMatrix(arr, 3);
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.left.right = null;
            root.left.left = null;
            root.right.right = new TreeNode(7);
            root.right.left = new TreeNode(15);

            int[] arr = { 7, 8, 9, 11, 12 };
            int number = FirstMissingPositive(arr);
        }

        public static int FirstMissingPositive(int[] nums)
        {
            for (int i = 0; i <= nums.Length - 1;)
            {
                int correctIndex = nums[i] - 1;
                if (nums[i] > 0 && nums[i] <= nums.Length && nums[i] != nums[correctIndex])
                {
                    int temp = nums[i];
                    nums[i] = nums[correctIndex];
                    nums[correctIndex] = temp;
                }
                else
                {
                    i++;
                }
            }
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] != i + 1)
                {
                    return i + 1;
                }
            }
            return nums.Length + 1;
        }
        public static int MissingNumber(int[] arr)
        {
            for (int i = 0; i <= arr.Length - 1;)
            {
                //if i==n : ignore the number
                if (arr[i] == arr.Length)
                {
                    i++;
                    continue;
                }
                //Here numbers are starting from 0:so correct position of each number in sorted array is at its index

                int correctIndex = arr[i];
                if (arr[i] != arr[correctIndex])
                {
                    int temp = arr[i];
                    arr[i] = arr[correctIndex];
                    arr[correctIndex] = temp;
                }
                else
                {
                    i++;
                }
            }
            int j = 0;
            for (; j <= arr.Length - 1; j++)
            {
                if (arr[j] != j)
                {
                    break;
                }
            }
            return j;
        }
        private static void CyclicSort(int[] arr)
        {
            for (int i = 0; i <= arr.Length - 1;)
            {
                //correct index for number is i-1;
                //eg: 3 will be at 3-1 inde
                int correctIndex = arr[i] - 1;
                if (arr[i] != arr[correctIndex])
                {
                    int temp = arr[i];
                    arr[i] = arr[correctIndex];
                    arr[correctIndex] = temp;
                }
                else
                {
                    i++;
                }
            }

        }
    }

}











