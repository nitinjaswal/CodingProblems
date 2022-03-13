public class SolutionBinarySearchRecursive
{
    public int Search(int[] nums, int target)
    {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }

    private int BinarySearch(int[] arr, int target, int start, int end)
    {
        if (start > end)
        {
            return -1;
        }

        int middle = start + (end - start) / 2;
        if (arr[middle] == target)
        {
            return middle;
        }
        else if (target < arr[middle])
        {
            end = middle - 1;
            return BinarySearch(arr, target, start, end);
        }
        else
        {
            start = middle + 1;
            return BinarySearch(arr, target, start, end);
        }
    }
}