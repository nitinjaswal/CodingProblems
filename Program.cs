﻿using System;
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
            //node.next.next = new ListNode(3);
            //node.next.next.next = new ListNode(4);
            //node.next.next.next.next = new ListNode(5);
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            int len = LongestConsecutive(arr);
            //var count = NumIslands(arr);
        }
        public static int LongestConsecutive(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }

            Array.Sort(arr);
            int longestStreak = 1;
            int currentStreak = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    if (arr[i] == arr[i - 1] + 1)
                    {
                        //If numbers are consecutive then increment
                        currentStreak++;                                               
                    }
                    else
                    {
                        //Reset the streakcount if numbers are not equal
                        longestStreak = Math.Max(longestStreak, currentStreak);
                        currentStreak = 1;
                    }
                }
            }
            return Math.Max(longestStreak, currentStreak);
            Array.Sort(arr);
            int longestStreak = 1;
            int currentStreak = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    if (arr[i] == arr[i - 1] + 1)
                    {
                        //If numbers are consecutive then increment
                        currentStreak++;                                               
                    }
                    else
                    {
                        //Reset the streakcount if numbers are not equal
                        longestStreak = Math.Max(longestStreak, currentStreak);
                        currentStreak = 1;
                    }
                }
            }
            return Math.Max(longestStreak, currentStreak);
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











