public class SolutionIsHappyWithoutExtraSpace
{
    public bool IsHappy(int n)
    {
        //using o(n) without extra space: Slow and fast pointer
        int slow = n;
        int fast = n;
        do
        {
            slow = GetSquare(slow);
            fast = GetSquare(GetSquare(fast));
        }
        while (slow != fast);
        if (slow == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
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