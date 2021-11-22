public class SolutionMergeSortedArrays
{
    public void Merge(int[] arr1, int m, int[] arr2, int n)
    {

        //Here we are using 2 pointers approach and will start filling the array1 from end
        // Set p1 and p2 to point to the end of their respective arrays.
        int p1 = m - 1;
        int p2 = n - 1;

        // And move p backwards through the array, we
        //will write the smallest value in nums1[p] (by comparing p1 and p2)

        for (int p = m + n - 1; p >= 0; p--)
        {
            //if index at p2 is -1, means we have iterated al the values in array 2
            if (p2 < 0)
            {
                break;
            }

            if (p1 >= 0 && arr1[p1] > arr2[p2])
            {
                arr1[p] = arr1[p1--];
            }
            else
            {
                arr1[p] = arr2[p2--];
            }
        }
    }
}