public class SolutionPivotIndex
{
    public int PivotIndex(int[] nums)
    {
        int totalSum = 0;
        int leftSum = 0;

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            totalSum = totalSum + (nums[i]);
        }
        int rightSum = totalSum;
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            rightSum = rightSum - nums[i];
            if (leftSum == rightSum)
            {
                return i;
            }
            else
            {
                leftSum = leftSum + nums[i];
            }
        }
        return -1;
    }
}