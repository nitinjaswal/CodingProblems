public class SolutionTranspose
{
    public int[][] Transpose(int[][] matrix)
    {
        int R = matrix.Length;
        int C = matrix[0].Length;
        int[][] ans = new int[C][];

        for (int i = 0; i < C; i++)
        {
            ans[i] = new int[R];
            for (int j = 0; j < R; j++)
            {
                ans[i][j] = matrix[j][i];
            }
        }
        return ans;
    }
}