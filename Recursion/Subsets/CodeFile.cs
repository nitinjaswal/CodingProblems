using System;

public class SolutionPrintStringSubets
{
    private static void SubSets(string originalString, string newString)
    {
        if (string.IsNullOrEmpty(originalString))
        {
            Console.WriteLine(newString);
            return;
        }

        string ch = originalString.Substring(0, 1);

        SubSets(originalString.Substring(1), newString + ch);
        SubSets(originalString.Substring(1), newString);
    }
}