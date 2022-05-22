public class SolutionPlusOne
{
    public int[] PlusOne(int[] digits)
    {

        int n = digits.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i] = digits[i] + 1;
                break;
            }
            else
            {
                digits[i] = 0;
            }
        }
        if (digits[0] == 0)
        {
            int[] result = new int[n + 1];
            result[0] = 1;
            return result;
        }
        return digits;
    }
}