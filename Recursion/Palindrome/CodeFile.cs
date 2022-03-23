using System;

public class SolutionPalindromeRecursive
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        return x == ReverseNumber(x);
    }

    long ReverseNumber(int num)
    {
        int digits = (int)Math.Floor(Math.Log10(num) + 1);
        return helper(num, digits);
    }

    long helper(int n, int digits)
    {
        if (n % 10 == n)
        {
            return n;
        }
        int rem = n % 10;
        return rem * (long)Math.Pow(10, digits - 1) + helper(n / 10, digits - 1);
    }
}