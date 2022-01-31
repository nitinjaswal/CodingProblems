using System;
using System.Collections.Generic;

public class SolutionEvalRPN
{
    public int EvalRPN(string[] tokens)
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

    private int calculate(int op1, int op2, string opr)
    {
        if (opr == "+")
        {
            return op1 + op2;
        }
        else if (opr == "-")
        {
            return op1 - op2;
        }
        else if (opr == "*")
        {
            return op1 * op2;
        }
        else
        {
            return op1 / op2;
        }
    }

    private bool isOperator(string c)
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