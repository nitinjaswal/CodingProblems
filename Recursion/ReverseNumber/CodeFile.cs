using System;

public class RecursiveReverseNumber
{
    static long ReverseNumber(int num)
    {
        int digits = (int)Math.Floor(Math.Log10(num) + 1);
        return helper(num, digits);
    }

    private static long helper(int n, int digits)
    {
        if (n % 10 == 0)
        {
            return n;
        }
        int rem = n % 10;
        return rem * (long)Math.Pow(10, digits - 1) + helper(n / 10, digits - 1);
    }
}
