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
}
