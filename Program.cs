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
            //PrintHollowSquare(4, 4);
            PrintPattern1();
            // SearchMatrix(arr, 3);
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.left.right = null;
            root.left.left = null;
            root.right.right = new TreeNode(7);
            root.right.left = new TreeNode(15);
    
        }

        private static void PrintHollowSquare(int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if ((i == 0 || i == row - 1) || (j == 0 || j == col - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                 }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void PrintPattern1()
        {
            int row = 4;
            int col = 4;

            //outer loop will run for number of lines yo want to print
            //no of lines = no of rows = no of times outer loop will run
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}











