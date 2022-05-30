using System;
using System.Text;

public class SolutionLongestCommonPrefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        Array.Sort(strs);
        char[] first = strs[0].ToCharArray();
        char[] last = strs[strs.Length - 1].ToCharArray();
        StringBuilder longestCommonPrefix = new StringBuilder();
        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != last[i])
            {
                break;
            }
            else
            {
                longestCommonPrefix.Append(first[i]);

            }
        }
        return longestCommonPrefix.ToString();
    }
}