public class SolutionMoveZeroes
{
    public void MoveZeroes(int[] nums)
    {
        int i = 0;
        for (int j = 0; j <= nums.Length - 1;)
        {
            if (nums[j] != 0)
            {
                nums[i] = nums[j];
                i++;
                j++;
            }
            else
            {
                j++;
            }
        }
        while (i <= nums.Length - 1)
        {
            nums[i++] = 0;
        }
    }
}