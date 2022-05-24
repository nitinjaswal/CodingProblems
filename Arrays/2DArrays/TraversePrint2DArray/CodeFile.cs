using System;

public class SolutionPrint2DArray
{
    public void Print()
    {
        //Declaring and Intializing 2d array
        int[,] array = new int[3, 3]
          {
                {1, 2, 3 },
                {4,5,6 },
                {7,8,9 }
          };

        //Nested loop to print row and columns
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j]);
            }
            Console.WriteLine();
        }
    }
}
