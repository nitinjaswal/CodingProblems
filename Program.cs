using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
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
    class LinkedList
    {
        static ListNode listNode = null;
        public static void Main(String[] args)
        {
            listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            var list = ReverseBetween(listNode, 2, 4);
        }
        public static ListNode ReverseBetween(ListNode head, int left, int right)
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
}








