public class SolutionLongestPalindromeSubstring
{
    private int lo, maxLen;
    public string LongestPalindrome(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            IsPalindrome(i, i, s); //To check the palindrome of odd length palindromic sub-string
            IsPalindrome(i, i + 1, s); //To check the palindrome of even length palindromic sub-string

        }
        return s.Substring(lo, maxLen);
    }
    private void IsPalindrome(int s, int e, string str)
    {
        while (s >= 0 && e < str.Length && str[s] == str[e])
        {
            s--;
            e++;
        }
        string currentString = str.Substring(s + 1, e - s - 1);
        if (maxLen < currentString.Length)
        {
            maxLen = currentString.Length;
            lo = s + 1;
        }
    }
}