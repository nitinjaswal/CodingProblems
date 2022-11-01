using System;
using System.Collections.Generic;

public class SolutionPrintpaths
{
    private Dictionary<String, int> map = new Dictionary<String, int>();
    public static void Printpaths(string p, int m, int n)
    {

        if (m == 1 && n == 1)
        {
            Console.WriteLine(p);
            return;
        }

        if (m > 1)
        {
            Printpaths(p: p + 'D', m: m - 1, n);
        }
        if (n > 1)
        {
            Printpaths(p: p + 'R', m, n: n - 1);
        }
    }
}