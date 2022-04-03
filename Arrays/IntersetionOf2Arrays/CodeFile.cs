using System.Collections.Generic;
using System.Linq;

public class SolutionIntersectionTwoArrays
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> set = new HashSet<int>();

        int count = 0;
        foreach (int i in nums1)
        {
            set.Add(i);
        }

        HashSet<int> intersection = new HashSet<int>();

        foreach (int i in nums2)
        {
            if (set.Contains(i))
            {
                intersection.Add(i);
            }
        }
        return intersection.ToArray();
    }
}