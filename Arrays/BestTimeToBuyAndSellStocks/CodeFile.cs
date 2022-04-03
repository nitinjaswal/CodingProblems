public class SolutionBestTimeToBuyAndSellStocks
{
    //Optimal approach
    public int MaxProfit(int[] prices)
    {

        int min = prices[0];
        int maxProfit = 0;
        for (int i = 0; i <= prices.Length - 1; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else if (maxProfit < prices[i] - min)
            {
                maxProfit = prices[i] - min;
            }
        }
        return maxProfit;
    }
    //brute force approach:O(n^2)
    public static int MaxProfit1(int[] prices)
    {
        //using 2 loops and checking max profit 
        int maxProfit = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            for (int j = i + 1; j <= prices.Length - 1; j++)
            {
                int currentProfit = prices[j] - prices[i];
                if (currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                }
            }
        }
        return maxProfit;
    }
}