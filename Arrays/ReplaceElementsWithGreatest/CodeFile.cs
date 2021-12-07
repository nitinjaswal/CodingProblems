public class SolutionReplaceElements
{
    public int[] ReplaceElements(int[] arr)
    {
        int max = 0;
        int curr = 0;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (i == arr.Length - 1)
            {
                curr = arr[i];
                max = arr[i];
                arr[i] = -1;
            }
            else
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    arr[i] = curr;
                    curr = max;
                }
                else
                {
                    arr[i] = curr;
                }
            }
        }
        return arr;
    }
}