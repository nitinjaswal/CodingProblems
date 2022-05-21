public class SolutionDominantIndex
{
    public int DominantIndex(int[] nums)
    {
        int largestNum = 0;
        int maxIndex = 0;
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] > largestNum)
            {
                largestNum = nums[i];
                maxIndex = i;
            }
        }
        bool islargest = false;
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] != largestNum && nums[i] * 2 > largestNum)
            {
                islargest = false;
                return -1;
            }
            else
            {
                islargest = true;
            }
        }

        if (islargest)
        {
            return maxIndex;
        }
        else
        {
            return -1;
        }
    }
}