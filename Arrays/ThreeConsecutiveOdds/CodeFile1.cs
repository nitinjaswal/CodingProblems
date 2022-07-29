public class SolutionFaster
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        bool isConsecutiveOdd = false; ;
        for (int i = 0; i < arr.Length - 2; i++)
        {
            if (arr[i] % 2 != 0 && arr[i + 1] % 2 != 0 && arr[i + 2] % 2 != 0)
            {
                isConsecutiveOdd = true;
            }
        }
        return isConsecutiveOdd;
    }
}