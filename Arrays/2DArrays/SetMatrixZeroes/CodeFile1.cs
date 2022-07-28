public class SolutionSetZeroesWithoutSpace
{
    public void SetZeroes(int[][] matrix)
    {

        int row = matrix.Length;//matrix row length
        int col = matrix[0].Length;//matrix column lenght
        bool isCol = false;
        int[] rows = new int[] { row };


        for (int i = 0; i < row; i++)
        {
            if (matrix[i][0] == 0)
            {
                isCol = true;
            }

            // If an element is zero, we set the first element of the corresponding row and column to 0
            for (int j = 1; j < col; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }

        // Iterate over the array once again and using the first row and first column, update the elements.
        for (int i = 1; i < row; i++)
        {
            for (int j = 1; j < col; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        // See if the first row needs to be set to zero as well
        if (matrix[0][0] == 0)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[0][j] = 0;
            }
        }

        // See if the first column needs to be set to zero as well
        if (isCol)
        {
            for (int i = 0; i < row; i++)
            {
                matrix[i][0] = 0;
            }
        }
    }
}