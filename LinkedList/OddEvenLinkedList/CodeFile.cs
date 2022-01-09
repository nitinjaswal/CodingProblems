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
public class SolutionOddEvenList
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        var evenHead = head.next;
        var currentOdd = head;
        var currentEven = head.next;

        while (currentOdd != null && currentEven != null)
        {
            if (currentOdd.next == currentEven)
            {
                currentOdd.next = currentEven.next;
                if (currentOdd.next != null)
                {
                    currentOdd = currentOdd.next;
                }
            }
            else
            {
                currentEven.next = currentOdd.next;
                currentEven = currentEven.next;
            }
        }
        currentOdd.next = evenHead;

        return head;
    }
}