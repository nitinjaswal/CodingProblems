public class SolutionRemovePalindromeSub
{
    public int RemovePalindromeSub(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        if (IsPalindrome(s))
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
    bool IsPalindrome(string s)
    {
        int left = 0; int right = s.Length - 1;

        while (left <= right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}