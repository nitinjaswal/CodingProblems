public class SolutionFirstMissingPositive
{
    public int FirstMissingPositive(int[] nums)
    {
        for (int i = 0; i <= nums.Length - 1;)
        {
            int correctIndex = nums[i] - 1;
            if (nums[i] > 0 && nums[i] <= nums.Length && nums[i] != nums[correctIndex])
            {
                int temp = nums[i];
                nums[i] = nums[correctIndex];
                nums[correctIndex] = temp;
            }
            else
            {
                i++;
            }
        }
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] != i + 1)
            {
                return i + 1;
            }
        }
        return nums.Length + 1;
    }
}