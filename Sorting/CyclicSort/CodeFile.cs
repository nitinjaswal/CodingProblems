public class SolutionCyclicSort
{
    //Cyclic sort works for number :0---N
    private static void CyclicSort(int[] arr)
    {
        for (int i = 0; i <= arr.Length - 1;)
        {
            if (i == arr[i] - 1)
            {
                i++;
            }
            else
            {
                int temp = arr[arr[i] - 1];
                arr[arr[i] - 1] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
