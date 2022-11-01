
using System;

public class SolutionDiagnolPaths
{
    public static void PrintDiagnolpaths(string p, int m, int n)
    {

        if (m == 1 && n == 1)
        {
            Console.WriteLine(p);
            return;
        }
        if (m > 1 && n > 1)
        {
            PrintDiagnolpaths(p: p + 'D', m: m - 1, n: n - 1);
        }
        if (m > 1)
        {
            PrintDiagnolpaths(p: p + 'V', m: m - 1, n);
        }
        if (n > 1)
        {
            PrintDiagnolpaths(p: p + 'H', m, n: n - 1);
        }

    }
}

