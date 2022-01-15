using System.Collections.Generic;

 //Definition for a Node.
public class ListNodeDoubly
{
    public int val;
    public ListNodeDoubly prev;
    public ListNodeDoubly next;
    public ListNodeDoubly child;

    public ListNodeDoubly(int d)
    {
        val = d;
        next = null;
        prev = null;
        child = null;
    }
}

public class SolutionFlattenDoublyList
{

    public ListNodeDoubly Flatten(ListNodeDoubly head)
    {
        if (head == null)
        {
            return head;
        }

        var dummyNode = new ListNodeDoubly(0);
        dummyNode.next = head;
        ListNodeDoubly currentNode;
        ListNodeDoubly prevNode = dummyNode;

        Stack<ListNodeDoubly> stack = new Stack<ListNodeDoubly>();
        stack.Push(head);

        while (stack.Count > 0)
        {
            currentNode = stack.Pop();
            prevNode.next = currentNode;
            currentNode.prev = prevNode;

            if (currentNode.next != null)
            {
                stack.Push(currentNode.next);
            }

            if (currentNode.child != null)
            {
                stack.Push(currentNode.child);
                currentNode.child = null;
            }
            prevNode = currentNode;
        }
        dummyNode.next.prev = null;
        return dummyNode.next;
    }
}