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
            PrintPattern7();
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
                //for every row run the column
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                //when one row is printed, we need to add a new line
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void PrintPattern2()
        {
            int row = 4;
            //outer loop will run for number of lines yo want to print
            //no of lines = no of rows = no of times outer loop will run
            for (int i = 0; i < row; i++)
            {
                //for every row run the column
                for (int j = 0; j < row - i; j++)
                {
                    Console.Write("*");
                }
                //when one row is printed, we need to add a new line
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void PrintPattern3()
        {
            int row = 4;
            //outer loop will run for number of lines yo want to print
            //no of lines = no of rows = no of times outer loop will run
            for (int i = 1; i <= row; i++)
            {
                //for every row run the column
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                //when one row is printed, we need to add a new line
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        private static void PrintPattern4()
        {
            int row = 4;
            //outer loop will run for number of lines yo want to print
            //no of lines = no of rows = no of times outer loop will run
            for (int i = 0; i < row * 2; i++)
            {
                int totalColsInRow = i > row ? 2 * row - i : i;
                //for every row run the column
                for (int j = 0; j < totalColsInRow; j++)
                {
                    Console.Write("*");
                }
                //when one row is printed, we need to add a new line
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void PrintPattern5()
        {
            int row = 4;

            for (int i = 0; i < 2 * row; i++)
            {
                int totalColsInRow = i > row ? 2 * row - i : i;
                int noOfSpaces = row - totalColsInRow;
                for (int s = 0; s < noOfSpaces; s++)
                {
                    Console.Write(" ");
                }

                //for every row run the column
                for (int j = 0; j < totalColsInRow; j++)
                {
                    Console.Write("* ");
                }
                //when one row is printed, we need to add a new line
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void PrintPattern6()
        {
            int row = 4;

            for (int i = 0; i <= row; i++)
            {
                int totalColsInRow = i;
                int noOfSpaces = row - totalColsInRow;
                for (int s = 0; s < noOfSpaces; s++)
                {
                    Console.Write(" ");
                }

                //for every row run the column
                for (int j = 0; j < totalColsInRow; j++)
                {
                    Console.Write("* ");
                }
                //when one row is printed, we need to add a new line
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static void PrintPattern7()
        {
            int n = 4;

            for (int row = 1; row <= n; row++)
            {
                int spacesToPrint = n - row;
                for (int s = 0; s < spacesToPrint; s++)
                {
                    Console.Write(" ");
                }
                for (int col = row; col >= 1; col--)
                {
                    Console.Write(col);
                }
                for (int col = 2; col <= row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}











