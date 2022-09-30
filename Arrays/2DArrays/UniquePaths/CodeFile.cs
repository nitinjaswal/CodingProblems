using System;
using System.Collections.Generic;

public class SolutionUniquePaths
{
    private Dictionary<String, int> map = new Dictionary<String, int>();
    public int UniquePaths(int m, int n)
    {

        if (m == 1 || n == 1)
        {
            return 1;
        }

        // using memoization to cehck if cell value is already calculated
        string cell = m + "," + n;
        if (map.ContainsKey(cell))
        {
            return map[cell];
        }

        // Down moves: reducing row
        int left = UniquePaths(m: m - 1, n);
        // Right moves: reducing columns
        int right = UniquePaths(m, n: n - 1);
        map.Add(cell, left + right);


        return left + right;
    }
}