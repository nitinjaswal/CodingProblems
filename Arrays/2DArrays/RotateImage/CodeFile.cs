public class SolutionRotateImageWithoutExtraSpace
{
    public void Rotate(int[][] matrix)
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
}