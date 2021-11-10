public class SolutionFindNumbersWithEvenDigits
{
    public int FindNumbers(int[] nums)
    {
        int counter = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (checkEven(nums[i].ToString().Length))
            {

                counter++;

            }

        }
        return counter;
    }

    private static bool checkEven(int length)
    {
        if (length % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}