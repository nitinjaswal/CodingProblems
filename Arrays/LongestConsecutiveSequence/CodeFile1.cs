using System;
using System.Collections.Generic;

public class SolutionLongestConsecutivehashMap
{
    public int LongestConsecutive(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }


        HashSet<int> set = new HashSet<int>();

        foreach (var item in arr)
        {
            set.Add(item);
        }

        int longestStreak = 0;
        foreach (int num in arr)
        {
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentStreak++;
                    currentNum = currentNum + 1;
                }
                longestStreak = Math.Max(currentStreak, longestStreak);
            }
        }
        return longestStreak;
    }
}