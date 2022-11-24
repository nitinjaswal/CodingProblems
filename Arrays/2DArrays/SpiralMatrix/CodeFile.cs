using System.Collections.Generic;

public class SolutionSpiralOrder
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int left = 0; int right = matrix[0].Length;
        int top = 0; int bottom = matrix.Length;
        var output = new List<int>();
        while (left < right && top < bottom)
        {
            //Traverse left to right from top row
            for (int i = left; i < right; i++)
            {
                output.Add(matrix[top][i]);
            }
            top++;

            //Traversing top to bottom from Right column
            for (int j = top; j < bottom; j++)
            {
                output.Add(matrix[j][right - 1]);
            }
            right--;

            //This check is added if the Matrix is (1 x n) or (n x 1)
            if (!(left < right && top < bottom))
            {
                break;
            }

            //Traversing right to left from Bottom-1 Row
            for (int i = right - 1; i >= left; i--)
            {
                output.Add(matrix[bottom - 1][i]);
            }
            bottom--;

            //Traversing bottom to top
            for (int j = bottom - 1; j >= top; j--)
            {
                output.Add(matrix[j][left]);
            }
            left++;
        }
        return output;
    }
}