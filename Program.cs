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
            public ListNode random;
            public ListNode(int d)
            {
                val = d;
                next = null;
                random = null;
            }
        }

        public static void Main(String[] args)
        {

            ListNode start = new ListNode(1);
            start.next = new ListNode(2);
            start.next.next = new ListNode(3);
            start.next.next.next = new ListNode(4);
            start.next.next.next.next = new ListNode(5);

            // 1's random points to 3
            start.random = start.next.next;

            // 2's random points to 1
            start.next.random = start;

            // 3's and 4's random points to 5
            start.next.next.random = start.next.next.next.next;
            start.next.next.next.random = start.next.next.next.next;

            // 5's random points to 2
            start.next.next.next.next.random = start.next;

            var copiedList = CopyRandomList(start);
        }
        static Dictionary<ListNode, ListNode> map = new Dictionary<ListNode, ListNode>();
        public static ListNode CopyRandomList(ListNode head)
        {
            // Hash map which contains node to node mapping of
            // original and clone linked list.
            if (head == null)
            {
                return head;
            }
            ListNode originalNode = head;
            ListNode copiedNode = new ListNode(head.val);
            map.Add(originalNode, copiedNode);
            // Traverse the original list and making a copy of that
            // in the clone linked list.
            while (originalNode != null)
            {
                //Copying value of orignialNode to copiedNode
                copiedNode.random = GetNode(originalNode.random);
                copiedNode.next = GetNode(originalNode.next);

                originalNode = originalNode.next;
                copiedNode = copiedNode.next;
            }
            return map[head];
        }

        private static ListNode GetNode(ListNode node)
        {
            if (node != null)
            {
                if (map.ContainsKey(node))
                {
                    return map[node];
                }
                else
                {
                    var newNode = new ListNode(node.val);
                    map.Add(node, newNode);
                    return map[node];
                }
            }
            return null;
        }
    }

}





