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
public class SolutionMergeTwoLists
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        var dummyNode = new ListNode(0);
        var head = dummyNode;

        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                dummyNode.next = l1;
                l1 = l1.next;
            }
            else
            {
                dummyNode.next = l2;

                l2 = l2.next;
            }
            dummyNode = dummyNode.next;
        }

        dummyNode.next = l1 == null ? l2 : l1;
        return head.next;
    }
}