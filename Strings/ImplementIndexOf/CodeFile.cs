public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle == "")
        {
            return 0;
        }
        string temp = "";
        for (int i = 0; i <= haystack.Length; i++)
        {
            temp = haystack.Substring(0, i);
            if (temp.Contains(needle))
            {
                return i - needle.Length;
            }
        }
        return -1;
    }
}