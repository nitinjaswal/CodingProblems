using System;

public class SolutionHeightChecker
{
    public int HeightChecker(int[] heights)
    {
        int max = 0;
        int[] inputArray = new int[heights.Length];
        for (int i = 0; i <= heights.Length - 1; i++)
        {
            inputArray[i] = heights[i];
        }
        Array.Sort(heights);

        for (int i = 0; i <= heights.Length - 1; i++)
        {
            if (inputArray[i] != heights[i])
            {
                max++;
            }
        }
        return max;
    }
}