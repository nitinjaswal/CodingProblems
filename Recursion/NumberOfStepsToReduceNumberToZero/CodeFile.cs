public class RecursiveSolutionNumberOfSteps
{
    public int NumberOfSteps(int num)
    {
        return helper(num, 0);
    }
    int helper(int n, int count)
    {
        if (n == 0)
        {
            return count;
        }
        if (n % 2 == 0)
        {
            return helper(n / 2, count + 1);
        }
        else
        {
            return helper(n = n - 1, count + 1);
        }
    }
}