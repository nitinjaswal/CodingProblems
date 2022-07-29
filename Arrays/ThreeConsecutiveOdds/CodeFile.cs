public class SolutionThreeConsecutiveOdds
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        int oddStreak = 0;
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] % 2 != 0 || arr[i] == 1)
            {
                oddStreak++;
                if (oddStreak == 3)
                {
                    return true;
                }
            }
            else
            {
                oddStreak = 0;
            }
        }
        return false;
    }
}