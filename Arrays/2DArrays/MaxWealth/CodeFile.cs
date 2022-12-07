using System;

public class SolutionMaximumWealth
{
    public int MaximumWealth(int[][] accounts)
    {
        int row = accounts.Length;
        int col = accounts[0].Length - 1;

        int maxWealth = 0;
        for (int i = 0; i < row; i++)
        {
            int currentSum = 0;
            for (int j = 0; j <= col; j++)
            {
                currentSum = currentSum + accounts[i][j];
            }
            maxWealth = Math.Max(currentSum, maxWealth);

        }
        return maxWealth;
    }
}