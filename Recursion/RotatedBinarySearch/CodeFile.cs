public class SolutionBinarySortedArray
{
    static int FindElement(int[] arr, int target, int start, int end)
    {
        if (start > end)
        {
            return -1;
        }
        int mid = start + (end - start) / 2;

        if (target == arr[mid])
        {
            return mid;
        }
        //case 1: If array element at start is less than element at array mid
        if (arr[start] <= arr[mid])
        {
            //Check if target element is in this range
            if (target >= arr[start] && target <= arr[mid])
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
            return FindElement(arr, target, start, end);
        }
        else
        {
            if (target >= arr[mid] && target <= arr[end])
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
            return FindElement(arr, target, start, end);
        }
    }
}
