using System;

public class SolutionMinSubArrayLen
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int sum = 0;
        int left = 0;
        int ans = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            sum = sum + nums[i];
            while (sum >= target)
            {
                ans = Math.Min(ans, i + 1 - left);
                sum = sum - nums[left];
                left++;
            }
        }
        if (ans != int.MaxValue)
        {
            return ans;
        }
        else
        {
            return 0;
        }
    }
}