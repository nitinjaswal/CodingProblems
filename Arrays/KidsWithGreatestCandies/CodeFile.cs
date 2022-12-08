using System.Collections.Generic;
using System;

public class SolutionKidsWithCandies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var result = new List<bool>();
        Dictionary<int, int> map = new Dictionary<int, int>();
        int max = 0;
        for (int i = 0; i < candies.Length; i++)
        {
            max = Math.Max(max, candies[i]);
        }

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= max)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }
        return result;
    }
}