﻿public class RecursiveReverseList
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode newHead = ReverseList(head.next);
        head.next.next = head;
        head.next = null;

        return newHead;
    }
}