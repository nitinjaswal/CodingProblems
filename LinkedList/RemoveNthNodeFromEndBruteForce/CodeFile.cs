/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class SolutionRemoveNthFromEnd
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.next == null)
        {
            return null;
        }
        int count = getCount(head);
        int counter = 1;
        var currentNode = head;
        if (count == n)
        {
            return head.next;
        }
        //Loop till the length of linked list minus node to delete
        while (counter < count - n)
        {
            counter++;
            currentNode = currentNode.next;
        }

        var temp = currentNode.next.next;
        currentNode.next = temp;

        return head;

    }
    public int getCount(ListNode node)
    {
        ListNode current = node;
        int count = 0;

        while (current != null)
        {
            count++;
            current = current.next;
        }

        return count;
    }
}