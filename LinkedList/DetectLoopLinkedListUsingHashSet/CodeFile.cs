

using System.Collections.Generic;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

//Brute force approach using hashtable. But space complexity is O(n): due to extra space
public class SolutionHasCycle
{
    public bool HasCycle(ListNode head)
    {
        HashSet<ListNode> hashNode = new HashSet<ListNode>();
        while (head != null)
        {
            if (hashNode.Contains(head))
            {
                return true;
            }
            else
            {
                hashNode.Add(head);
            }
            head = head.next;
        }
        return false;
    }


}