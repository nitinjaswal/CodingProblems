public class IterativeSolutionRotatedSortedArraySearch
{
    public int Search(int[] arr, int target)
    {
        int start = 0;
        int end = arr.Length - 1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (target == arr[mid])
            {
                return mid;
            }
            //case 1: Left side is sorted
            if (arr[start] <= arr[mid])
            {
                //Check if elements lies on left half or not
                if (target >= arr[start] && target <= arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            //Right half is sorted
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
            }
        }
        return -1;
    }
}