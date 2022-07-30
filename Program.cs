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
                new int[] {1,2,3 },
                new int[] {4,5,6 },
                new int[] {7,8,9 }
          };


        public static void Main(String[] args)
        {
            //ListNode node = new ListNode(1);
            //node.next = new ListNode(2);
            //int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            Rotate(arr);

        }

        public static void RotateUsingSecondmatrix(int[][] arr)
        {
            //int[][] nums = new int[arr.Length][arr[0].Length];

        }
        public static void Rotate(int[][] matrix)
        {
            //Transpose a matrix
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < cols; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }

            }

            //Reverse  matrix rows with Swap
            int firstColumn = 0;
            int lastColumn = matrix[0].Length - 1;
            while (firstColumn < lastColumn)
            {
                //swapping of first column with last column
                for (int k = 0; k < matrix.Length; k++)
                {
                    int temp = matrix[k][firstColumn];
                    matrix[k][firstColumn] = matrix[k][lastColumn];
                    matrix[k][lastColumn] = temp;
                }
                firstColumn++;
                lastColumn--;
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











