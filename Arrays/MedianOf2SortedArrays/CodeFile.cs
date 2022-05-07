public class SolutionFindMedianSortedArraysBruteForce
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        double median = 0;
        int[] sortedArray = MergeArrays(nums1, nums2);
        median = Median(sortedArray);
        return median;
    }

    private static double Median(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;
        double median = 0.0;

        int mid = low + (high - low) / 2;

        if (arr.Length % 2 == 0)
        {
            median = (arr[mid] + arr[mid + 1]) / 2.0;
        }
        else
        {
            median = arr[mid];
        }
        return median;

    }
    private static int[] MergeArrays(int[] nums1, int[] nums2)
    {
        int[] mergeSortedArray = new int[nums1.Length + nums2.Length];
        int left = 0;
        int right = 0;
        int k = 0;
        while (left < nums1.Length && right < nums2.Length)
        {
            if (nums1[left] < nums2[right])
            {
                mergeSortedArray[k] = nums1[left];
                left++;
            }
            else
            {
                mergeSortedArray[k] = nums2[right];
                right++;
            }
            k++;
        }

        for (; left < nums1.Length; left++)
        {
            mergeSortedArray[k] = nums1[left];
            k++;
        }
        for (; right < nums2.Length; right++)
        {
            mergeSortedArray[k] = nums2[right];
            k++;
        }
        return mergeSortedArray;
    }
}