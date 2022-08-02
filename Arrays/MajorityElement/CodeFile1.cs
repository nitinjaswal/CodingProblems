using System.Collections.Generic;

public class SolutionMajorityElementHashtable
{
    public int MajorityElement(int[] nums)
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
        int n = nums.Length / 2;
        int result = set.FirstOrDefault(x => x.Value > n).Key;
        return result;
    }
}