public class SolutionFindMinII
{
    public int FindMin(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        int low = 0;
        int high = nums.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;


            if (nums[mid] > nums[high])
            {
                low = mid + 1;
            }
            else if (nums[mid] < nums[high]) //
            {
                high = mid;
            }
            else
            {
                high = high - 1;
            }
        }
        return nums[low];
    }
}