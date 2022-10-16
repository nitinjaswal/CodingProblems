public class SolutionCountSubstrings
{
    public int CountSubstrings(string s)
    {
        int palindromicCount = 0;
        if (s.Length == 0)
        {
            return 0;
        }
        for (int i = 0; i < s.Length; i++)
        {
            palindromicCount = palindromicCount + IsPalindrome(i, i, s); //To check the palindrome of odd length palindromic sub-string
            palindromicCount = palindromicCount + IsPalindrome(i, i + 1, s); ////To check the palindrome of even length palindromic sub-string
        }
        return palindromicCount;
    }
    private int IsPalindrome(int s, int e, string str)
    {
        int count = 0;
        while (s >= 0 && e < str.Length && str[s] == str[e])
        {
            s--;
            e++;
            count++;
        }
        return count;
    }
}