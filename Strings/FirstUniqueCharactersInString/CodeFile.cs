using System.Collections.Generic;

public class SolutionFirstUniqChar
{
    public int FirstUniqChar(string s)
    {
        var charArr = s.ToCharArray();
        Dictionary<char, int> set = new Dictionary<char, int>();

        //create hashtable and maintain count of each character
        for (int i = 0; i <= charArr.Length - 1; i++)
        {
            if (!set.ContainsKey(charArr[i]))
            {
                set.Add(charArr[i], 1);
            }
            else
            {
                //if element exist more than once, then update count
                int old = (int)set[charArr[i]];
                set[charArr[i]] = old + 1;
            }
        }


        for (int i = 0; i <= charArr.Length - 1; i++)
        {
            if (set[charArr[i]].Equals(1))
            {
                return i;
            }
        }

        return -1;
    }
}