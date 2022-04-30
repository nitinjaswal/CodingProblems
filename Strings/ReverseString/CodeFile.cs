public class IterativeReverseString
{
    public void ReverseString(char[] s)
    {
        int i = 0;
        for (int j = s.Length - 1; i < j; j--)
        {
            var temp = s[j];
            s[j] = s[i];
            s[i] = temp;
            i++;
        }
    }
}