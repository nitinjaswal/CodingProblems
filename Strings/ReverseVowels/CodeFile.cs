public class SolutionReverseVowels
{
    public string ReverseVowels(string s)
    {
        var newString = s.ToCharArray();

        int left = 0;
        int right = s.ToCharArray().Length - 1;
        while (left < right)
        {
            if (!isVowel(newString[left]))
            {
                left++;
            }
            else if (!isVowel(newString[right]))
            {
                right--;
            }
            else
            {
                swap(newString, left, right);
                left++;
                right--;
            }
        }
        string charsStr = new string(newString);
        return charsStr;
    }
    private static void swap(char[] chars, int x, int y)
    {
        char temp = chars[x];
        chars[x] = chars[y];
        chars[y] = temp;
    }

    private static bool isVowel(char c)
    {
        return c == 'a' || c == 'i' || c == 'e' || c == 'o' || c == 'u'
         || c == 'A' || c == 'I' || c == 'E' || c == 'O' || c == 'U';
    }
}