using System;

public class SolutionPrintHollowSquare
{
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
}
