using System.Collections.Generic;

public class MinStack
{

    Stack<int> stack;
    Stack<int> minStack;
    int min = 0;
    /** initialize your data structure here. */
    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int x)
    {
        stack.Push(x);

        //IF minStack is empty then insert value
        ////If minStack is not empty, then insert value only if minStack top element is greater than new value
        if (minStack.Count == 0 || x <= minStack.Peek())
        {
            minStack.Push(x);
        }

    }

    public void Pop()
    {
        int val = stack.Pop();
        if (val == minStack.Peek())
        {
            minStack.Pop();
        }
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Count != 0 ? minStack.Peek() : 0;
        // return minStack.Peek();
    }
}
