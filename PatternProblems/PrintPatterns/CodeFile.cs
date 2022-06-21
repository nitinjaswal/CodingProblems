using System;

public class SolutionPrintPatterns
{
    private static void PrintPattern1()
    {
        int row = 4;

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

    private static void PrintPattern2()
    {
        int row = 4;
        //outer loop will run for number of lines yo want to print
        //no of lines = no of rows = no of times outer loop will run
        for (int i = 0; i < row; i++)
        {
            //for every row run the column
            for (int j = i; j < row; j++)
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
                Console.WriteLine(" ");
            }
            for (int col = row; col >= 1; col--)
            {
                Console.WriteLine(col);
            }
            for (int col = 2; col <= row; col++)
            {
                Console.WriteLine(col);
            }
        }
        Console.ReadKey();
    }
}
