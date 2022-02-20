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

            var swappedList = ReverseList(node);
        }


        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode newHead = ReverseList(head.next);
            head.next.next = head;
            head.next = null;

            return newHead;
        }

        static void Reverse(ListNode currentNode, ListNode previousNode)
        {
            if (currentNode == null)
            {
                return;
            }
            var temp = currentNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
            currentNode = temp;
            Reverse(currentNode, previousNode);
        }
    }

}








