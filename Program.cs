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
            listNode = new ListNode(4);
            listNode.next = new ListNode(5);
            listNode.next.next = new ListNode(1);
            listNode.next.next.next = new ListNode(9);
            //listNode.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            DeleteNode(listNode.next);
        }
        public static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}








