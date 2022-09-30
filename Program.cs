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
    public class ListNodeDoubly
    {
        public int val;
        public ListNodeDoubly prev;
        public ListNodeDoubly next;
        public ListNodeDoubly child;

        public ListNodeDoubly(int d)
        {
            val = d;
            next = null;
            prev = null;
            child = null;
        }
    }
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
    public class MyHashSet
    {
        static int[,] matrix = { { 1, 3, 5, 7 },
                        { 10, 11, 16, 20 },
                        { 23, 30, 34, 50 } };
        int K = 3;

        static int[][] arr = new int[][]
           {
               new int[]{1,5,9 },
               new int[]{10,11,13 },
               new int[]{12,13,15},
           };


        public static void Main(String[] args)
        {
            //ListNode node = new ListNode(1);
            //node.next = new ListNode(2);
            int[] nums = { 0, 2, 1, 5, 3, 4 };
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int maxArea = MaxArea(height);
        }

        //Brute force approach: Giving Time limit exceeded error
        public static int MaxArea1(int[] height)
        {
            int maxArea = 0;

            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i; j < height.Length; j++)
                {
                    int currArea = Math.Min(height[j], height[i]) * (j - i);
                    maxArea = Math.Max(maxArea, currArea);
                }
            }
            return maxArea;
        }
        private Dictionary<String, int> map = new Dictionary<String, int>();
        public int UniquePaths(int m, int n)
        {
            if (m == 1 || n == 1)
            {
                return 1;
            }

            // using memoization to cehck if cell value is already calculated
            string cell = m + "," + n;
            if (map.ContainsKey(cell))
            {
                return map[cell];
            }

            // Down moves: reducing row
            int left = UniquePaths(m: m - 1, n);
            // Right moves: reducing columns
            int right = UniquePaths(m, n: n - 1);
            map.Add(cell, left + right);


            return left + right;
        }
        public static int MaxArea(int[] height)
        {
            int maxArea = 0;

            //using 2 pointers approach
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int currArea = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, currArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
    }
}










