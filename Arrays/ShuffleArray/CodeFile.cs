public class SolutionShuffle
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] result = new int[nums.Length];
        int j = 0;
        for (int i = 0; i < nums.Length;)
        {
            if (i % 2 == 0)
            {
                result[i++] = nums[j++];
            }
            else
            {
                result[i++] = nums[n++];
            }
        }
        return result;
    }
}