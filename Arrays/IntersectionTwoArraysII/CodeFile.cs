using System;
using System.Collections.Generic;

public class SolutionIntersectII
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var i = 0;
        var j = 0;

        Array.Sort(nums1);
        Array.Sort(nums2);
        var result = new List<int>();
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
            {
                i++;
            }
            else if (nums1[i] > nums2[j])
            {
                j++;
            }
            else
            {
                result.Add(nums1[i]);
                i++;
                j++;
            }
        }

        return result.ToArray();
    }
}