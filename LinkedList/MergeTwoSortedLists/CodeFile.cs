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
        var head = new ListNode(0);
        var dummyNode = head;
        var list1 = l1;
        var list2 = l2;

        if (l1 == null)
        {
            return l2;
        }
        if (l2 == null)
        {
            return l1;
        }
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                dummyNode.next = list1;
                dummyNode = dummyNode.next;
                list1 = list1.next;
            }
            else
            {
                dummyNode.next = list2;
                dummyNode = dummyNode.next;
                list2 = list2.next;
            }
        }

        while (list1 != null)
        {
            dummyNode.next = list1;
            dummyNode = dummyNode.next;
            list1 = list1.next;
        }
        while (list2 != null)
        {
            dummyNode.next = list2;
            dummyNode = dummyNode.next;
            list2 = list2.next;
        }
        return head.next;
    }
}