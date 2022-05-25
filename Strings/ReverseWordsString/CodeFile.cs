using System.Text;

public class SolutionReverseWords
{
    public string ReverseWords(string s)
    {
        StringBuilder sb = new StringBuilder();
        var words = s.Split(' ');

        for (int i = 0; i <= words.Length - 1; i++)
        {
            if (words[i] != "")
            {
                string reversedString = ReverseString(words[i].ToCharArray());
                sb.Append(reversedString);
                sb.Append(' ');
            }
        }

        return sb.ToString().TrimEnd();
    }

    public static string ReverseString(char[] s)
    {
        int i = 0;
        for (int j = s.Length - 1; i < j; j--)
        {
            var temp = s[j];
            s[j] = s[i];
            s[i] = temp;
            i++;
        }
        string str = new string(s);
        return str.ToString();
    }
}