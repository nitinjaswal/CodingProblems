using System;

public class SolutionLengthOfLongestSubstring
{
    public int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;

        if (s == "")
        {
            return 0;
        }
        for (int i = 0; i <= s.Length - 1; i++)
        {
            string subString = "";
            for (int j = i; j <= s.Length - 1; j++)
            {
                if (!subString.Contains(s[j]))
                {
                    subString = subString + s[j];
                    maxLength = Math.Max(maxLength, subString.Length);
                }
                else
                {
                    break;
                }
            }

        }
        return maxLength;
    }
}