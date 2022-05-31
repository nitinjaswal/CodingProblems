public class SolutionSearchMatrixII
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int row = 0;
        int column = matrix[0].Length - 1;
        while (row < matrix.Length && column >= 0)
        {
            if (target == matrix[row][column])
            {
                return true;
            }
            else if (target < matrix[row][column])
            {
                column--;
            }
            else
            {
                row++;
            }
        }
        return false;
    }
}