using System.Collections.Generic;

public class SolutionClimbStairsRecursive
{
    static Dictionary<int, int> map = new Dictionary<int, int>();
    public int ClimbStairs(int n)
    {
        if (map.ContainsKey(n))
            return map[n];

        if (n == 0 || n == 1)
        {
            return 1;
        }
        int sum = ClimbStairs(n - 1) + ClimbStairs(n - 2);

        map[n] = sum;
        return sum;
    }
}