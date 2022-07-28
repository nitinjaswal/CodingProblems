using System.Collections.Generic;

public class SolutionSetZeroes
{
    public void SetZeroes(int[][] matrix)
    {
        int row = matrix.Length;//matrix row length
        int col = matrix[0].Length;//matrix column lenght

        HashSet<int> rows = new HashSet<int>();
        HashSet<int> cols = new HashSet<int>();

        //mark each row and col when it is ZERO and add row and col in Hash
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (matrix[i][j] == 0)
                {
                    rows.Add(i);
                    cols.Add(j);
                }
            }
        }

        //Now for added row and col in hash we check for [i][j]
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (rows.Contains(i) || cols.Contains(j))
                {
                    matrix[i][j] = 0;
                    //eg
                    //matrix[0][1]=0;
                    //matrix[1][0]=0
                    //matrix[1][1]=0
                    //matrix[1][2]=0
                }
            }
        }
    }
}