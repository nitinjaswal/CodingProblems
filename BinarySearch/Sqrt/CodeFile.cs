public class SolutionMySqrt
{
    public int MySqrt(int x)
    {
        if (x < 2)
        {
            return x;
        }

        long low = 0;
        long high = x;
        long mid = 0;
        while (low <= high)
        {
            mid = low + ((high - low) / 2);
            long square = mid * mid;
            if (square == x)
            {
                return (int)mid;
            }
            else if (square > x)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return (int)high;
    }
}