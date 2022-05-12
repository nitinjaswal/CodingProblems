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


public class SolutionReverseBetween
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        var dummyNode = new ListNode(0, head);
        var prev = dummyNode;
        var currentNode = head;

        for (int i = 1; i < left; i++)
        {
            prev = currentNode;
            currentNode = currentNode.next;
        }

        //reverse
        ListNode prevNode = null;
        for (int i = left; i <= right; i++)
        {
            ListNode temp = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = temp;
        }
        prev.next.next = currentNode;
        prev.next = prevNode;
        return dummyNode.next;
    }
}