using System;
using System.Collections.Generic;

public class SolutionMerge
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0] - b[0]);

        List<int[]> result = new List<int[]>();

        //Get previous interval array
        int[] prev = intervals[0];

        for (int i = 1; i < intervals.Length; i++)
        {
            //Current array
            int[] curr = intervals[i];

            //comparing first element of curr array with value
            //at index 1 of prev array
            if (curr[0] <= prev[1])
            {
                prev[1] = Math.Max(curr[1], prev[1]);//copy larger value from interval
            }
            else
            {
                result.Add(prev);
                prev = curr;
            }
        }
        //if there is no else case
        result.Add(prev);
        return result.ToArray();
    }
}