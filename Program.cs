using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public static void Main(String[] args)
        {
            var listNode = new ListNode(1);
            listNode.next = new ListNode(1);
            listNode.next.next = new ListNode(2);
            listNode.next.next.next = new ListNode(3);
            listNode.next.next.next.next = new ListNode(3);

            var list = DeleteDuplicates(listNode);
        }
        public static ListNode DeleteDuplicates(ListNode head)
        {
            Dictionary<ListNode, int> dictionary = new Dictionary<ListNode, int>();
            var currentNode = head;
          
            while (currentNode != null && currentNode.next != null)
            {
                if (currentNode.val == currentNode.next.val)
                {
                    currentNode.next = currentNode.next.next;
                }
                else
                {
                    currentNode = currentNode.next;
                }
            }
            return head;

            //while (currentNode != null && currentNode.next != null)
            //{
            //    if (!dictionary.ContainsValue(currentNode.val))
            //    {
            //        dictionary.Add(currentNode, currentNode.val);
            //    }
            //    currentNode = currentNode.next;
            //}

            //return head;
        }
    }
}








