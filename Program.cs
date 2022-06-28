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

            ListNode node = new ListNode(3);
            node.next = new ListNode(5);
            //node.next.next = new ListNode(3);
            //node.next.next.next = new ListNode(4);
            //node.next.next.next.next = new ListNode(5);

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
            var middleNode = ReverseBetween(node, 1, 2);

        }
        public static ListNode ReverseBetween(ListNode head, int left, int right)
        {
            
            if (left == right)
            {
                return head;
            }

            var dummyNode = new ListNode(0, head);
            //skip the first left-1 nodes

            ListNode previousNodeBeforeReverse = dummyNode;
            ListNode currentNode = head;
            for (int i = 1; i < left; i++)
            {
                previousNodeBeforeReverse = currentNode;
                currentNode = currentNode.next;
            }

            ListNode previousNode = null;
            for (int i = left; i <= right; i++)
            {
                var temp = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = temp;
            }

            previousNodeBeforeReverse.next.next = currentNode;
            previousNodeBeforeReverse.next = previousNode;
            return previousNodeBeforeReverse.next;
        }
        public static ListNode Reverse(ListNode head)
        {
            var currentNode = head;
            ListNode previousNode = null;

            while (currentNode != null)
            {
                var tempNode = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = tempNode;

            }
            return previousNode;
        }

    }

}











