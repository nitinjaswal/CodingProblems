public class SolutionZerosInDigit
{
    static int Count(int x)
    {
        return helper(x, 0);
    }

    private static int helper(int n, int count)
    {
        if (n == 0)
        {
            return count;
        }

        int rem = n % 10;
        if (rem == 0)
        {
            return helper(n / 10, count + 1);
        }
        else
        {
            return helper(n / 10, count);
        }
    }
}
