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

    public class MyHashSet
    {
        static int[,] matrix = { { 1, 3, 5, 7 },
                        { 10, 11, 16, 20 },
                        { 23, 30, 34, 50 } };
        int K = 3;

        static int[][] arr = new int[][]
           {
                new int[] {1, 2, 3},
                new int[] {11, 34, 67},
                new int[] {89, 23,33}
          };
        public static void Main(String[] args)
        {

            ListNode node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);

            ListNode node1 = new ListNode(1);
            node1.next = new ListNode(3);
            node1.next.next = new ListNode(4);
            //var root = new TreeNode(3);
            //root.left = new TreeNode(9);
            //root.right = new TreeNode(20);
            //root.left.right = null;
            //root.left.left = null;
            //root.right.right = new TreeNode(7);
            //root.right.left = new TreeNode(15);
            //var list = InsertUsingRecursion(node, 3, 7);
            ReorderList(node);

        }
        public static void ReorderList(ListNode head)
        {
            if (head == null && head.next == null)
            {
                return;
            }
            var currentNode = head;
            var middleNode = GetMiddleNode(head);
            var lastNode = Reverse(middleNode);

            while (currentNode != null && lastNode != null)
            {
                var temp = currentNode.next;
                currentNode.next = lastNode;
                currentNode = temp;

                temp = lastNode.next;
                lastNode.next = currentNode;
                lastNode=temp;
            }
            if (currentNode != null)
            {
                currentNode.next = null;
            }
        }
        private static ListNode GetMiddleNode(ListNode head)
        {
            var slowPointer = head;
            var fastPointer = head;
            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }
            return slowPointer;
        }

        private static ListNode Reverse(ListNode midNode)
        {
            ListNode previousNode = null;
            var currentNode = midNode;
            while (currentNode != null)
            {
                var temp = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = temp;
            }
            return previousNode;
        }
    }

}











