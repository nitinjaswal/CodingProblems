public class DuplicateZeros
{
    public void SolutionDuplicateZeros(int[] arr)
    {

        int temp = 0;
        for (int currentIndex = 0; currentIndex < arr.Length; currentIndex++)
        {
            if (arr[currentIndex] == 0 && currentIndex != arr.Length - 1)
            {
                for (int i = arr.Length - 2; i >= currentIndex; i--)
                {
                    arr[i + 1] = arr[i];
                    temp = i + 1;
                }
                currentIndex = temp;
            }
        }
    }
}