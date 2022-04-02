public class SolutionQuickSort
{
    private static void QuickSort(int[] nums, int low, int high)
    {
        if (low < high)
        {
            int start = low;
            int end = high;
            int pivot = nums[low];
            while (start < end)
            {
                while (nums[start] <= pivot)//When start is less than pivot 
                {
                    start++;
                }
                while (nums[end] > pivot)//When end is greater than pivot
                {
                    end--;
                }

                if (start < end)
                {
                    int temp = nums[start];
                    nums[start] = nums[end];
                    nums[end] = temp;
                }
            }

            //place pivot at its right position

            int temp1 = nums[end];
            nums[end] = nums[low];
            nums[low] = temp1;

            pivot = end;
            QuickSort(nums, low, pivot - 1);
            QuickSort(nums, pivot + 1, high);
        }
    }
}

