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

            public ListNode(int d)
            {
                val = d;
                next = null;
            }
        }

        public static void Main(String[] args)
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            // creating first linked list
            list1.head = new ListNode(2);
            list1.head.next = new ListNode(4);
            list1.head.next.next = new ListNode(3);

            // creating first linked list

            list2.head = new ListNode(5);
            list2.head.next = new ListNode(6);
            list2.head.next.next = new ListNode(4);
            //list.head.next.next.next = new Node(1);
            //list.head.next.next.next.next = new Node(5);
            //list.head.next.next.next.next.next = new Node(4);
            //list.head.next.next.next.next.next.next = new Node(6);
            var sortedList = AddTwoNumbers(list1.head, list2.head);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyNode = new ListNode(0);
            ListNode list1 = l1, list2 = l2;
            ListNode currentNode = dummyNode;
            int carry = 0;

            //Loop on both the lists till null
            while (list1 != null || list2 != null)
            {
                int x = 0;
                int y = 0;
                //check if node in list1 is not null
                if (list1 != null)
                {
                    //storing value of node in x
                    x = list1.val;
                }
                //check if node in list2 is not null
                if (list2 != null)
                {
                    //storing value of node in y
                    y = list2.val;
                }

                //Adding individual element of both list one by one. Adding carry so that if there is any
                //By default carry is 0. update carry with the sum/10, to get carry
                int sum = x + y + carry;
                carry = sum / 10;

                //Now currenNode.next will point to the sum of 2 numbers without carry and sum is sum%10
                //e.g 7+3=10, sum%10=0, carry =1
                currentNode.next = new ListNode(sum % 10);
                currentNode = currentNode.next;

         
                //When addition is done, move list1 and list2 to next position
                if (list1 != null)
                {
                    list1 = list1.next;
                }
                if (list2 != null)
                {
                    list2 = list2.next;
                }
            }
            //If there is carry while adding last 2 numbers then we can simply point current.next to the carry element
            if (carry > 0)
            {
                currentNode.next = new ListNode(carry);
            }

            //return dummy.next as dummy initially is pointing to 0
            return dummyNode.next;
        }

        private static ListNode ReverseList(ListNode head)
        {
            ListNode previousNode = null;
            var currentNode = head;

            while (currentNode != null)
            {
                var temp = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = temp;
            }
            return previousNode;
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0);
            var dummyNode = head;
            var list1 = l1;
            var list2 = l2;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
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





