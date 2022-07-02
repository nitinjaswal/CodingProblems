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
public class SolutionDeleteMiddleNode
{
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head.next == null || head == null)
        {
            return null;
        }
        var slowPointer = head;
        var fastPointer = head;
        ListNode previousNode = null;
        while (fastPointer != null && fastPointer.next != null)
        {
            previousNode = slowPointer;
            slowPointer = slowPointer.next;
            fastPointer = fastPointer.next.next;
        }
        previousNode.next = slowPointer.next;
        return head;
    }

}