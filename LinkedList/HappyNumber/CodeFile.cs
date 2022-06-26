using System.Collections.Generic;

public class SolutionIsHappyHashSet
{
    public bool IsHappy(int n)
    {

        HashSet<int> map = new HashSet<int>();
        while (n > 0)
        {
            if (n == 1)
            {
                return true;
            }
            if (!map.Contains(n))
            {
                map.Add(n);
                int square = GetSquare(n);
                n = square;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
    private static int GetSquare(int n)
    {
        int result = 0;
        while (n > 0)
        {
            int digit = n % 10;
            n = n / 10;
            result = result + (digit * digit);
        }
        return result;
    }
}