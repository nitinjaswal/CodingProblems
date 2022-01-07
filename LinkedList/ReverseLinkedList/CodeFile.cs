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
public class SolutionReverseList
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode previousNode = null;
        var currentNode = head;
        while (currentNode != null)
        {
            ListNode temp = currentNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
            currentNode = temp;
        }
        return previousNode;
    }
}