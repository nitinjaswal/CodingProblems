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
            list.head1 = new Node(3);
            list.head1.next = new Node(6);
            list.head1.next.next = new Node(9);
            list.head1.next.next.next = new Node(15);
            list.head1.next.next.next.next = new Node(30);

            // creating second linked list
            list.head2 = new Node(10);
            list.head2.next = new Node(15);
            list.head2.next.next = new Node(30);

            var node = list.GetIntersectionNode(list, list);
        }

        public Node GetIntersectionNode(LinkedList list1, LinkedList list2)
        {
            var head1 = list1.head1;
            var head2 = list2.head2;
            int count1 = getCount(head1);//Get count of linked list 1
            int count2 = getCount(head2);//Get count of linked list 2

            //Calculating diff of noded between both linked list to check how many extra nodes are present in larger list
            int diff = Math.Abs(count1 - count2);

            if (count1 > count2)
            {
                //if list1 count is greater than the list2, then we move pointer1 position to the (diff between 2 nodes)
                //else we move pointer2
                for (int i = 0; i < diff; i++)
                {
                    head1 = head1.next;
                }
            }
            else
            {
                for (int i = 0; i < diff; i++)
                {
                    head2 = head2.next;
                }
            }

            //Now both pointers are at same distance from intersection nodes(if ther are any)
            while (head1 != head2)
            {
                head1 = head1.next;
                head2 = head2.next;
            }

            return head1;
        }



        public int getCount(Node node)
        {
            Node current = node;
            int count = 0;

            while (current.next != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }
    }

}





