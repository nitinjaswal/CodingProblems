using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Challenges.Queue.ShortestDistance;

namespace Challenges
{
    class IsValidString
    {


        public static void Main(String[] args)
        {
            string s = "{([])}";
            var isValid = IsValid(s);
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            char[] str = s.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                //this is checking if it contains opening bracket
                if (isOpening(str[i]))
                {
                    stack.Push(str[i]);
                }

                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    //if 
                    else if (!isMatching(stack.Peek(), str[i]))
                    {
                        return false;
                    }
                    else
                    {
                        //if elements are matching then remove from stack
                        stack.Pop();
                    }
                }
            }
            return stack.Count == 0 ? true : false;
        }
        //method to check if brackets are opening
        private static bool isOpening(char c)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //a: from Stack.b: new value from string
        private static bool isMatching(char a, char b)
        {
            //check opening and closing pair for the bracket
            if (a == '(' && b == ')' || a == '{' && b == '}' || a == '[' && b == ']')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}







