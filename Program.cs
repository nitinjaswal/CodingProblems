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
            //list.head.next.next.next.next.next = new Node(4);
            //list.head.next.next.next.next.next.next = new Node(6);
            var node = list.OddEvenList(list.head);
        }

        public Node OddEvenList(Node head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            var evenHead = head.next;
            var currentOdd = head;
            var currentEven = head.next;

            while (currentOdd != null && currentEven != null)
            {
                if (currentOdd.next == currentEven)
                {
                    currentOdd.next = currentEven.next;
                    if (currentOdd.next != null)
                    {
                        currentOdd = currentOdd.next;
                    }    
                }
                else
                {
                    currentEven.next = currentOdd.next;
                    currentEven = currentEven.next;
                }
            }
            currentOdd.next = evenHead;

            return head;
        }
    }

}





