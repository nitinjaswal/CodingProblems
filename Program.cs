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
            list.head = new Node(6);
            list.head.next = new Node(1);
            list.head.next.next = new Node(2);
            list.head.next.next.next = new Node(3);
            list.head.next.next.next.next = new Node(6);
            list.head.next.next.next.next.next = new Node(4);
            list.head.next.next.next.next.next.next = new Node(6);
            var node = list.RemoveElements(list.head, 6);
        }

        public Node RemoveElements(Node head, int val)
        {

            if (head == null)
            {
                return null;
            }
         
            Node dummyNode = new Node(0);
            dummyNode.next = head;

            Node currentNode = head;
            Node previousNode = dummyNode;
           
            while (currentNode != null)
            {
                if (currentNode.data == val)
                {
                    previousNode.next = currentNode.next;
                }
                else
                {
                    previousNode = currentNode;
                }
                currentNode = currentNode.next;

            }
            return dummyNode.next;
        }
    }

}





