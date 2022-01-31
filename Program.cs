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
            string[] tokens = { "4", "13", "5", "/", "+" };
            var isValid = EvalRPN(tokens);
        }

        public static int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            int sum = 0;
            for (int i = 0; i < tokens.Length; i++)
            {
                if (!isOperator(tokens[i]))
                {
                    stack.Push(Convert.ToInt32(tokens[i]));
                }
                else
                {
                    int op1 = stack.Pop();
                    int op2 = stack.Pop();
                    sum = calculate(op2, op1, tokens[i]);
                    stack.Push(sum);
                }
            }

            return stack.Pop();
        }

        private static  int calculate(int op1, int op2 , string opr)
        {
            if(opr == "+")
            {
                return op1 + op2;
            }
            else if(opr == "-")
            {
                return op1 - op2;
            }
            else if(opr == "*")
            {
                return op1 * op2;
            }
            else
            {
                return op1 / op2;
            }
        }

        private static bool isOperator(string c)
        {
            if (c == "+" || c == "-" || c == "*" || c == "/")
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







