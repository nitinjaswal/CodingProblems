using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    class LinkedList
    {

        Node head1, head2;

        public class Node
        {

            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public static void Main(String[] args)
        {
            LinkedList list = new LinkedList();

            // creating first linked list
            list.head1 = new Node(1);
            list.head1.next = new Node(2);
            list.head1.next.next = new Node(3);
            list.head1.next.next.next = new Node(4);
            list.head1.next.next.next.next = new Node(5);

            // creating second linked list
            list.head2 = new Node(10);
            list.head2.next = new Node(15);
            list.head2.next.next = new Node(30);

            var node = list.RemoveNthFromEnd(list.head1, 2);
        }

        public Node RemoveNthFromEnd(Node head, int n)
        {
            if (head.next == null)
            {
                return null;
            }
            int count = getCount(head);
            int counter = 1;
            var currentNode = head;
            if (count == n)
            {
                return head.next;
            }
            while (counter < count - n)
            {
                counter++;
                currentNode = currentNode.next;
            }

            var temp = currentNode.next.next;
            currentNode.next = temp;

            return head;
        }

        public int getCount(Node node)
        {
            Node current = node;
            int count = 0;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }
    }

}





