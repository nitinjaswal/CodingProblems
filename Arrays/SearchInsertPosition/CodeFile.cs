public class SolutionSearchInsert
{
    public int SearchInsert(int[] nums, int target)
    {
        int index = 0;
        int low = 0;
        int high = nums.Length - 1;

        //Using binary search to find index in O(Log n) time
        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (target == nums[mid])
            {
                return mid;
            }

            if (target > nums[mid])
            {
                low = mid + 1;
                index = low;
            }
            else
            {
                index = mid;
                high = mid - 1;
            }
        }
        return index;

    }
}