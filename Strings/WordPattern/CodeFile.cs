using System.Collections.Generic;

public class SolutionWordPattern
{
    public bool WordPattern(string pattern, string s)
    {
        Dictionary<char, string> dic = new Dictionary<char, string>();
        string[] words = s.Split(" ");

        //Check length of words for mapping in both string
        if (pattern.Length != words.Length)
        {
            return false;
        }

        for (int index = 0; index < words.Length; index++)
        {
            if (!dic.ContainsKey(pattern[index]))
            {
                //it means for different key, same value is present
                if (dic.ContainsValue(words[index]))
                {
                    return false;
                }
                dic.Add(pattern[index], words[index]);
            }
            else if (dic[pattern[index]] != words[index])
            {
                return false;
            }
        }
        return true;
    }
}