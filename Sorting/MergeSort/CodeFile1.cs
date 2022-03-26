using System;

class SolutioMergeSort
{

   public static void SortArray(int[] nums)
    {
        MergeSort(nums, 0, nums.Length - 1);
    }

    public static void MergeSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int mid = low + (high - low) / 2;
            MergeSort(arr, low, mid);
            MergeSort(arr, mid + 1, high);
            Merge(arr, low, mid, high);
        }
    }

    private static void Merge(int[] A, int low, int mid, int high)
    {
        int[] b = new int[high + 1];

        int i = low;
        int j = mid + 1;
        int k = low;

        while (i <= mid && j <= high)
        {
            if (A[i] < A[j])
            {
                b[k] = A[i];
                i++;
            }
            else
            {
                b[k] = A[j];
                j++;
            }
            k++;
        }

        //add remaining elements in new array. Either one of the loop will work
        while (i <= mid)
        {
            b[k++] = A[i++];
        }
        while (j <= high)
        {
            b[k++] = A[j++];
        }

        for (i = low; i <= high; i++)
        {
            A[i] = b[i];
        }


    }

}