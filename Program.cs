using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Challenges.Queue.ShortestDistance;

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
        public Node root;
        public static void Main(String[] args)
        {
            ListNode node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);

            var swappedList = SwapPairs(node);
        }


        public static  ListNode SwapPairs(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            var dummyNode = new ListNode();
            dummyNode.next = head;
            swap(dummyNode);
            return dummyNode;
        }

        static void swap(ListNode node)
        {
            if (node == null)
            {
                return;
            }

            ListNode first = node.next;
            ListNode second = null;
            if (first != null)
            {
                second = first.next;
            }

            if (second != null)
            {
                ListNode secondNext = second.next;
                second.next = first;
                node.next = second;
                first.next = secondNext;
                swap(first);
            }
        }
    }

}








