public class SolutionSearchRange
{
    public int[] SearchRange(int[] nums, int target)
    {
        int firstIndex = ReturnFirstIndex(nums, target);
        int lastIndex = ReturnLastIndex(nums, target);
        int[] arr = { firstIndex, lastIndex };
        return arr;
    }
    private int ReturnFirstIndex(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;
        int index = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] >= target)
            {
                high = mid - 1;

            }
            else
            {
                low = mid + 1;
            }
            if (nums[mid] == target)
            {
                index = mid;
            }
        }
        return index;
    }
    private int ReturnLastIndex(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length - 1;
        int index = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (nums[mid] <= target)
            {

                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
            if (nums[mid] == target)
            {
                index = mid;
            }
        }
        return index;
    }
}