using System.Collections.Generic;
using System.Linq;

public class SolutionSumOfUnique
{
    public int SumOfUnique(int[] nums)
    {
        var result = 0;
        Dictionary<int, int> set = new Dictionary<int, int>();
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (!set.ContainsKey(nums[i]))
            {
                set.Add(nums[i], 1);
            }
            else
            {
                //if element exist more than once, then update count
                int oldCount = (int)set[nums[i]];
                set[nums[i]] = oldCount + 1;
            }
        }
        result = set.Where(x => x.Value == 1).Select(x => x.Key).Sum();
        return result;
    }
}