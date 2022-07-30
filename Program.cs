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

        static char[][] arr = new char[][]
           {
                new char[] {'1','1','1','1','0' },
                new char[] {'1','1','0','1','0' },
                new char[] {'1','1','0','0','0' },
                new char[] {'0','0','0','0','0' },
          };


        public static void Main(String[] args)
        {
            //ListNode node = new ListNode(1);
            //node.next = new ListNode(2);
            int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            SortColors(arr);
        }

        public static void SortColors(int[] nums)
        {
            //Dutch national flag algo
            //We assume that al the lement to the low are 0 ie: a[0...low-1]==0
            //and all the element to right of high are 2 ie: a[high+1...]==2
            //and [low...mid-1} ie: 1
            int low = 0;
            int mid = 0;
            int high = nums.Length - 1;
            while (mid <= high)
            {
                if (nums[mid] == 0)//When mid is zero: Swap values at (nums[low] & nums[mid])
                {
                    int temp = nums[low];
                    nums[low] = nums[mid];
                    nums[mid] = temp;
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1)//if Mid is zero then simply increment Mid pointer
                {
                    mid++;
                }
                else
                {
                    int temp = nums[mid];
                    nums[mid] = nums[high];
                    nums[high] = temp;
                    high--;
                }
            }
        }
        private static void Swap(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
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











