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
    public int MaxProfit2(int[] prices)
    {

        int maxProfit = 0;
        // let use initialize Left and Right pointer to first and second position of array
        //Here Left is to buy stock and Right is to sell stock
        int left = 0;
        int right = 1;


        //Then we initialize our max_profit as 0

        //Now we will start our while loop and we will run till our Right pointer less then length of array
        while (right <= prices.Length - 1)
        {

            if (prices[left] < prices[right])
            {
                int profit = prices[right] - prices[left];
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
            else
            {
                left = right;
            }
            right++;
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