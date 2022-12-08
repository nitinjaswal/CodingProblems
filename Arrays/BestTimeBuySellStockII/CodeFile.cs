public class SolutionMaxProfit
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;

        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] < prices[i + 1])
            {
                maxProfit = maxProfit + (prices[i + 1] - prices[i]);
            }
        }
        return maxProfit;
    }
}