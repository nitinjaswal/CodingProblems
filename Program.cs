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
    public class MyHashSet
    {
        static int[,] matrix = { { 1, 3, 5, 7 },
                        { 10, 11, 16, 20 },
                        { 23, 30, 34, 50 } };
        int K = 3;

        static int[][] arr = new int[][]
           {
                new int[] {1,4 },
                new int[] {2,3 }
                //new int[] {8,10 },
                //new int[] {1,3 }
          };


        public static void Main(String[] args)
        {
            //ListNode node = new ListNode(1);
            //node.next = new ListNode(2);
            //int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            //var list = Merge(arr);
            int[] nums1 = { 2,6,4,1,3,1,5 };
            int[] nums2 = { 2, 3, 9 };
            int s = FindDuplicate(nums1);

        }

        public static int FindDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];

            do
            {
                slow = nums[slow];//slow pointer will move one step
                fast = nums[nums[fast]];//fast pointer will move 2 steps
            }
            while (slow != fast);//loop until slow and fast meet

            fast = nums[0];
            while (slow!=fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }
            return slow;
        }

        public static int NumIslands(char[][] grid)
        {
            if (grid.Length == 0)
            {
                return 0;
            }
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        DFS(grid, i, j);
                    }
                }
            }
            return count;
        }

        private static void DFS(char[][] grid, int row, int col)
        {
            if (row >= 0 && col >= 0 && row < grid.Length && col < grid[0].Length && grid[row][col] == '1')
            {
                //if element is 1 then set to '0'
                grid[row][col] = '0';

                //Call in all 4 directions
                DFS(grid, row + 1, col);
                DFS(grid, row - 1, col);
                DFS(grid, row, col + 1);
                DFS(grid, row, col - 1);
            }
        }

    }

}











