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
        public static void Main(String[] args)
        {
            var listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(3);
            listNode.next.next.next.next = new ListNode(4);
            listNode.next.next.next.next.next = new ListNode(4);
            listNode.next.next.next.next.next.next = new ListNode(5);
            var list = DeleteDuplicates(listNode);
        }
        public static ListNode DeleteDuplicates(ListNode head)
        {
            var dummyNode = new ListNode(0,head);
            var prevNode = dummyNode;
            var currNode = head;
            while (currNode != null)
            {
                if (currNode.next != null && currNode.val == currNode.next.val)
                {
                    //Skip the nodes when values are equal
                    while (currNode.next != null && currNode.val == currNode.next.val)
                    {
                        currNode = currNode.next;
                    }
                    //When loop finishes we found duplicate range
                    //Simply point prev pointer to duplicate next
                    prevNode.next = currNode.next;
                }
                else
                {
                    prevNode = prevNode.next;
                }
                currNode = currNode.next;
            }
            return dummyNode.next;
        }
    }
}








