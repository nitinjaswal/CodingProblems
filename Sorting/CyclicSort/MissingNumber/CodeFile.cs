public class SolutionMissingNumber
{
    public int MissingNumber(int[] arr)
    {
        for (int i = 0; i <= arr.Length - 1;)
        {
            //if i==n : ignore the number
            if (arr[i] == arr.Length)
            {
                i++;
                continue;
            }
            //correct index for number is i-1;
            //eg: 3 will be at 3-1 inde
            int correctIndex = arr[i];
            if (arr[i] != arr[correctIndex])
            {
                int temp = arr[i];
                arr[i] = arr[correctIndex];
                arr[correctIndex] = temp;
            }
            else
            {
                i++;
            }
        }
        int j = 0;
        for (; j <= arr.Length - 1;)
        {
            if (arr[j] != j)
            {
                break;
            }
            else
            {
                j++;
            }
        }
        return j;
    }
}