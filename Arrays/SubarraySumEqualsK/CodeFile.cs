

public class SolutionSubArraySumBruteForce
{
    public int SubarraySum(int[] nums, int k)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                sum = sum + nums[j];
                if (sum == k)
                {
                    count++;
                }
            }
        }
        return count;
    }
}