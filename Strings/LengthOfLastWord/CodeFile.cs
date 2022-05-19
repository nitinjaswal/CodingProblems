public class SolutionLengthOfLastWord
{
    public int LengthOfLastWord(string s)
    {
        char[] charArray = s.ToCharArray();
        int length = 0;
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            if (charArray[i] != ' ')
            {
                length++;
            }
            else
            {
                if (length > 0)
                {
                    return length;
                }
            }
        }
        return length;
    }
}