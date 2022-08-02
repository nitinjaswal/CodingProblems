using System.Collections.Generic;
using System.Linq;

public class SolutionMajorityElementII
{
    public IList<int> MajorityElementII(int[] nums)
    {
        Dictionary<int, int> set = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!set.ContainsKey(nums[i]))
            {
                set.Add(nums[i], 1);
            }
            else
            {
                set[nums[i]]++;
            }
        }
        int n = nums.Length / 3;
        var result = set.Where(x => x.Value > n).Select(x => x.Key).ToList();
        return result;
    }
}