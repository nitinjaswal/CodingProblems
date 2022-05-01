public class SolutionFindPeakElement
{
    public int FindPeakElement(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 0;
        }

        int low = 0;
        int high = nums.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (nums[mid] < nums[mid + 1])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }
        return low;
    }
}