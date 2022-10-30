using System.Collections.Generic;

public class SolutionCheckSubarraySum
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        int sum = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        dic.Add(0, -1);
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            sum = sum + nums[i];
            int rem = sum % k;
            if (!dic.ContainsKey(rem))
            {
                dic.Add(rem, i);
            }
            else if (i - dic[rem] > 1)
            {
                return true;
            }
        }
        return false;
    }
}