public class SolutionMergeSortRecursive1
{
    public  int[] SortArrayMerge(int[] nums)
    {
        return MergeSortRecursive(nums, 0, nums.Length - 1);
    }

    public int[] MergeSortRecursive(int[] nums, int low, int high)
    {
        if (low < high)
        {
            int mid = low + (high - low) / 2;
            int[] left = MergeSortRecursive(nums, low, mid);
            int[] right = MergeSortRecursive(nums, mid + 1, high);
            return MergeSort(left, right);
        }

        return new int[] { nums[low] };
    }
    private int[] MergeSort(int[] first, int[] second)
    {
        int[] newArr = new int[first.Length + second.Length];

        int i = 0;
        int j = 0;
        int k = 0;
        while (i < first.Length && j < second.Length)
        {
            if (first[i] < second[j])
            {
                newArr[k] = first[i];
                i++;
            }
            else
            {
                newArr[k] = second[j];
                j++;
            }
            k++;
        }

        //add remaining elements in new array. Either one of the loop will work
        for (; i < first.Length; i++)
        {
            newArr[k] = first[i];
            k++;
        }
        for (; j < second.Length; j++)
        {
            newArr[k] = second[j];
            k++;
        }
        return newArr;
    }
}