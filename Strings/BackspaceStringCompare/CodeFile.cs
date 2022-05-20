using System.Collections.Generic;
using System.Text;

public class SolutionBackspaceCompare
{
    public bool BackspaceCompare(string s, string t)
    {
        return BuildString(s).Equals(BuildString(t));
    }

    public static string BuildString(string s)
    {
        Stack<string> stack = new Stack<string>();

        for (int i = 0; i <= s.Length - 1; i++)
        {
            if (s[i].ToString() == "#")
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(s[i].ToString());
            }
        }
        StringBuilder sb1 = new StringBuilder();
        while (stack.Count > 0)
        {
            sb1.Append(stack.Peek());
            stack.Pop();
        }
        return sb1.ToString();
    }
}