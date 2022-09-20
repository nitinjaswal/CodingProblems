using System;

public class SolutionMaxArea
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;

        //using 2 pointers approach
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int currArea = Math.Min(height[left], height[right]) * (right - left);//area formula
            maxArea = Math.Max(maxArea, currArea);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxArea;
    }

    //Brute force approach: Giving Time limit exceeded error
    public static int MaxArea1(int[] height)
    {
        int maxArea = 0;

        for (int i = 0; i < height.Length; i++)
        {
            for (int j = i; j < height.Length; j++)
            {
                int currArea = Math.Min(height[j], height[i]) * (j - i);
                maxArea = Math.Max(maxArea, currArea);
            }
        }
        return maxArea;
    }
}
