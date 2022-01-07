using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    class LinkedList
    {

        Node head, head2;

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
            list.head = new Node(1);
            list.head.next = new Node(2);
            list.head.next.next = new Node(3);
            list.head.next.next.next = new Node(4);
            list.head.next.next.next.next = new Node(5);

            var node = list.ReverseList(list.head);
        }

        public Node ReverseList(Node head)
        {

            Node previousNode = null;
            var currentNode = head;
            while (currentNode != null)
            {
                Node temp = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = temp;
            }
            return previousNode;
        }
    }

}





