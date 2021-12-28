/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class SolutionDetectCycle
{
    public ListNode DetectCycle(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        //Solvin the problem with 2 pointer approach using slow and fast pointer
        var slowPointer = head;
        var fastPointer = head;
        //If first node is null or there is only head node, it means there is no cyc
        while (fastPointer != null && fastPointer.next != null)
        {
            slowPointer = slowPointer.next;//slow pointer will move 1 step
            fastPointer = fastPointer.next.next;//fast pointer will move 2 step ahead

            if (slowPointer == fastPointer)///At some point "fastpointer" will cross "slowpointer"
            {
                break;
            }
        }

        if (slowPointer != fastPointer)
        {
            return null;
        }
        if (head.next == null)
        {
            return null;
        }
        slowPointer = head;
        while (slowPointer != fastPointer)
        {
            slowPointer = slowPointer.next;//slow pointer will move 1 step
            fastPointer = fastPointer.next;//fast pointer will move 2 step ahead
        }
        return slowPointer;
    }
}