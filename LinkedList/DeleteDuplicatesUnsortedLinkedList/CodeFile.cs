using System.Collections.Generic;

public class SolutionDeleteDuplicatesUnsortedList
{
    private static ListNode DeleteDuplicatesUnsortedList(ListNode head)
    {
        var currentNode = head;
        var previousNode = new ListNode(0);
        HashSet<int> map = new HashSet<int>();
        while (currentNode != null)
        {
            if (!map.Contains(currentNode.val))
            {
                map.Add(currentNode.val);
                previousNode = currentNode;
            }
            else
            {
                previousNode.next = currentNode.next;
            }
            currentNode = currentNode.next;
        }
        return head;
    }
}
