public class SolutionSearchMatrix
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int row = 0;
        int column = matrix[0].Length - 1;

        //Brute force aproach
        //for (int i = 0; i < matrix.Length; i++)
        //{
        //    for (int j = 0; j < matrix[0].Length; j++)
        //    {
        //        if (matrix[i][j] == target) return true;
        //    }
        //}
        //return false;

        //Binary Search
        while (row <= matrix.Length && column >= 0)
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