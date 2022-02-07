using System;
using System.Collections.Generic;
using System.Text;

public class SolutionDecodeString
{
    public string DecodeString(string s)
    {
        Stack<int> numStack = new Stack<int>();
        Stack<StringBuilder> strStack = new Stack<StringBuilder>();

        StringBuilder str = new StringBuilder();
        int num = 0;
        char[] c = s.ToCharArray();

        for (int i = 0; i < c.Length; i++)
        {
            if (Char.IsDigit(c[i]))
            {
                num = num * 10 + c[i] - '0';
            }
            else if (c[i] == '[')
            {
                strStack.Push(str);  //Store str(stringbuilder) in stack
                str = new StringBuilder();//Reset str
                numStack.Push(num);//push num into the numstack
                num = 0;//Reset num

            }
            else if (c[i] == ']')
            {
                StringBuilder temp = str;
                str = strStack.Pop();
                int count = numStack.Pop();
                while (count > 0)
                {
                    str.Append(temp);
                    count--;
                }
            }
            else
            {
                str.Append(c[i]);
            }
        }
        return str.ToString();
    }
}