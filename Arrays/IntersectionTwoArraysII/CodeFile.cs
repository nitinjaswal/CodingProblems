using System.Collections.Generic;

public class SolutionIntersectII
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var dict = new Dictionary<int, int>();
        foreach (var item in nums1)
        {
            if (!dict.ContainsKey(item))
            {
                dict.Add(item, 0);
            }

            dict[item] = 1;
        }

        var result = new List<int>();
        foreach (var item in nums2)
        {
            if (dict.ContainsKey(item) && dict[item] > 0)
            {
                result.Add(item);
                dict[item] = -1;
            }
        }

        return result.ToArray();
    }
}