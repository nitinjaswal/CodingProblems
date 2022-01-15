using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    class LinkedList
    {
        ListNode head, head2;

        public class ListNode
        {

            public int val;
            public ListNode next;
            public ListNode prev;
            public ListNode child;

            public ListNode(int d)
            {
                val = d;
                next = null;
                prev = null;
                child = null;
            }
        }

        public static void Main(String[] args)
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.child = new ListNode(7);
            head.next.child.child = new ListNode(9);
            head.next.child.child.child = new ListNode(14);
            head.next.child.child.child.child = new ListNode(15);
            head.next.child.child.child.child.next = new ListNode(23);
            head.next.child.child.child.child.next.child = new ListNode(24);
            head.next.child.next = new ListNode(8);
            head.next.child.next.child = new ListNode(16);
            head.next.child.next.child.child = new ListNode(17);
            head.next.child.next.child.child.next = new ListNode(18);
            head.next.child.next.child.child.next.next = new ListNode(19);
            head.next.child.next.child.child.next.next.next
                                                = new ListNode(20);
            head.next.child.next.child.child.next.next.next.child
                                                = new ListNode(21);
            head.next.child.next.next = new ListNode(10);
            head.next.child.next.next.child = new ListNode(11);
            head.next.child.next.next.next = new ListNode(12);
            var list = FlattenLinkedList(head);
        }

        public static ListNode FlattenLinkedList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            var dummyNode = new ListNode(0);
            dummyNode.next = head;
            ListNode currentNode;
            ListNode prevNode = dummyNode;

            Stack<ListNode> stack = new Stack<ListNode>();
            stack.Push(head);

            while (stack.Count > 0)
            {
                currentNode = stack.Pop();
                prevNode.next = currentNode;
                currentNode.prev = prevNode;

                if (currentNode.next != null)
                {
                    stack.Push(currentNode.next);
                }

                if (currentNode.child != null)
                {
                    stack.Push(currentNode.child);
                    currentNode.child = null;
                }
                prevNode = currentNode;
            }
            dummyNode.next.prev = null;
            return dummyNode.next;
        }

    }

}





