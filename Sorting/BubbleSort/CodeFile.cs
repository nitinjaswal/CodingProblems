public class SolutionRecursiveBubbleSort
{
    public void BubbleSort(int[] arr, int r, int c)
    {
        if (r == 0)
        {
            return;
        }
        if (c < r)
        {
            if (arr[c] > arr[c + 1])
            {
                int temp = arr[c];
                arr[c] = arr[c + 1];
                arr[c + 1] = temp;
                BubbleSort(arr, r, c: c + 1);
            }
        }
        else
        {
            BubbleSort(arr, r: r - 1, c: 0);
        }
    }
}

