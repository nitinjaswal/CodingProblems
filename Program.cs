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
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            // creating first linked list
            list1.head = new Node(-9);
            list1.head.next = new Node(3);
           // list1.head.next.next = new Node(4);

            // creating first linked list

            list2.head = new Node(5);
            list2.head.next = new Node(7);
           // list2.head.next.next = new Node(4);
            //list.head.next.next.next = new Node(1);
            //list.head.next.next.next.next = new Node(5);
            //list.head.next.next.next.next.next = new Node(4);
            //list.head.next.next.next.next.next.next = new Node(6);
            var sortedList = MergeTwoLists(list1.head, list2.head);
        }

        public static Node MergeTwoLists(Node l1, Node l2)
        {
            var head = new Node(0);
            var dummyNode = head;
            var list1 = l1;
            var list2 = l2;

            while (list1 != null && list2 != null)
            {
                if (list1.data < list2.data)
                {
                    dummyNode.next = list1;
                    dummyNode = dummyNode.next;
                    list1 = list1.next;
                }
                else
                {
                    dummyNode.next = list2;
                    dummyNode = dummyNode.next;
                    list2 = list2.next;
                }
            }

            while (list1 != null)
            {
                dummyNode.next = list1;
                dummyNode = dummyNode.next;
                list1 = list1.next;
            }
            while (list2 != null)
            {
                dummyNode.next = list2;
                dummyNode = dummyNode.next;
                list2 = list2.next;
            }
            return head.next;
        }
    }

}





