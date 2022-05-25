public class SolutionPeakIndexInMountainArray
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;
        while (low < high)
        {
            int mid = low + (high - low) / 2;
            // it means high element must be on left sidde of the mid
            if (arr[mid] > arr[mid + 1])
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }
        return low;
    }
}