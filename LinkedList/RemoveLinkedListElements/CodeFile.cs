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
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {

        if (head == null)
        {
            return null;
        }

        ListNode dummyNode = new ListNode(0);
        dummyNode.next = head;
        ListNode currentNode = head;
        ListNode previousNode = dummyNode;


        while (currentNode != null)
        {
            if (currentNode.val == val)
            {
                previousNode.next = currentNode.next;
            }
            else
            {
                previousNode = currentNode;
            }
            currentNode = currentNode.next;

        }
        return dummyNode.next;
    }
}