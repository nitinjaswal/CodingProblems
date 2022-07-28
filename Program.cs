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


        static int[][] intMatrix = new int[][]
           {
                new int[] {0,1,0 },
                new int[] {1,5,1 },
                new int[] {1,1,1 },
          };

        public static void Main(String[] args)
        {
            SetZeroes(intMatrix);
            //ListNode node = new ListNode(1);
            //node.next = new ListNode(2);
            //node.next.next = new ListNode(3);
            //node.next.next.next = new ListNode(4);
            //node.next.next.next.next = new ListNode(5);


            //var count = NumIslands(arr);
        }
        public static void SetZeroes(int[][] matrix)
        {
            int row = matrix.Length;//matrix row length
            int col = matrix[0].Length;//matrix column lenght
            bool isCol = false;
            int[] rows = new int[] { row };


            for (int i = 0; i < row; i++)
            {
                if (matrix[i][0] == 0)
                {
                    isCol = true;
                }

                // If an element is zero, we set the first element of the corresponding row and column to 0
                for (int j = 1; j < col; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            // Iterate over the array once again and using the first row and first column, update the elements.
            for (int i = 1; i < row; i++)
            {
                for (int j = 1; j < col; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            // See if the first row needs to be set to zero as well
            if (matrix[0][0] == 0)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[0][j] = 0;
                }
            }

            // See if the first column needs to be set to zero as well
            if (isCol)
            {
                for (int i = 0; i < row; i++)
                {
                    matrix[i][0] = 0;
                }
            }
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











