public class SolutionGenerateMatrix
{
    public int[][] GenerateMatrix(int n)
    {
        int[][] matrix = new int[n][];

        for (int i = 0; i < n; i++)
            matrix[i] = new int[n];

        int rowStart = 0;
        int rowEnd = n - 1;
        int colStart = 0;
        int colEnd = n - 1;

        int num = 1;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {

            //Fill left to right top row
            for (int i = colStart; i <= colEnd; i++)
            {
                matrix[rowStart][i] = num++;
            }
            rowStart++;

            //Fill top to bottom last column
            for (int i = rowStart; i <= rowEnd; i++)
            {
                matrix[i][colEnd] = num++;
            }
            colEnd--;


            //Fill Right to Left
            for (int i = colEnd; i >= colStart; i--)
            {
                if (rowStart <= rowEnd)
                    matrix[rowEnd][i] = num++;
            }
            rowEnd--;

            //Fill bottom to top
            for (int i = rowEnd; i >= rowStart; i--)
            {
                if (colStart <= colEnd)
                    matrix[i][colStart] = num++;
            }
            colStart++;
        }
        return matrix;
    }
}