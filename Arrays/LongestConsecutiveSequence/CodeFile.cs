using System;

public class SolutionLongestConsecutive
{
    public int LongestConsecutive(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }
        Array.Sort(arr);
        int longestStreak = 1;
        int currentStreak = 1;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[i - 1])
            {
                if (arr[i] == arr[i - 1] + 1)
                {
                    //If numbers are consecutive then increment
                    currentStreak++;
                }
                else
                {
                    //Reset the streakcount if numbers are not equal
                    longestStreak = Math.Max(longestStreak, currentStreak);
                    currentStreak = 1;
                }
            }
        }
        return Math.Max(longestStreak, currentStreak);
    }
}