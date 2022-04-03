using System;
using System.Collections.Generic;

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
    private static List<string> SubSetsList(string originalString, string newString)
    {
        if (string.IsNullOrEmpty(originalString))
        {
            var list = new List<string>();
            list.Add(newString);
            return list;
        }

        string ch = originalString.Substring(0, 1);

        List<string> left = SubSetsList(originalString.Substring(1), newString + ch);
        List<string> right = SubSetsList(originalString.Substring(1), newString);
        left.AddRange(right);
        return left;
    }

}