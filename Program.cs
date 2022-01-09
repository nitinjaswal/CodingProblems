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
            list.head.next.next = new Node(1);
            list.head.next.next.next = new Node(1);
            //list.head.next.next.next.next = new Node(5);
            //list.head.next.next.next.next.next = new Node(4);
            //list.head.next.next.next.next.next.next = new Node(6);
            var node = list.IsPalindrome(list.head);
        }

        public bool IsPalindrome(Node head)
        {
            //In brute force we can simply reverse a linked list and compare both the linked list
            // it will tak extra space
            //Solution in O(N) and O(1) space: Reverse second half of linked list and start comparing first and last element 
            
            if (head == null)
            {
                return true;
            }
            var currentNode = head;//1->2
            var middleNode = MiddleElement(head);//it will find middle element in the list
            var lastNode = ReverseList(middleNode);//it contains second half of the list in reverse order (2->1 will become NULL<-2<-1)

            while (lastNode != null)
            {
                if (lastNode.data != currentNode.data)
                {
                    return false;
                }
                else
                {
                    currentNode = currentNode.next;
                    lastNode = lastNode.next;
                }
            }
            return true;
        }

        private Node MiddleElement(Node head)
        {
            var slowPointer = head;
            var fastPointer = head;
            while (fastPointer != null && fastPointer.next != null)
            {
                fastPointer = fastPointer.next.next;
                slowPointer = slowPointer.next;
            }

            return slowPointer;
        }

        private Node ReverseList(Node head)
        {
            Node previuosNode = null;
            Node currentNode = head;

            while (currentNode != null)
            {
                var temp = currentNode.next;
                currentNode.next = previuosNode;//First it will point to NULL(as previuosNode is set to NULL initially)
                previuosNode = currentNode;
                currentNode = temp;

            }
            return previuosNode;

        }
    }

}





